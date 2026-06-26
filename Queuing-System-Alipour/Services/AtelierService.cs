using Microsoft.EntityFrameworkCore;
using Queuing_System_Alipour.DTOs.Atelier;
using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Repositories;
using Queuing_System_Alipour.Services.Base;
using Queuing_System_Alipour.Tool.Handler;
using Queuing_System_Alipour.Validator.Atelier;

namespace Queuing_System_Alipour.Services
{
    public sealed class AtelierService : BaseService<AtelierRepository>
    {
        private readonly DeleteAtelierQueueValidator _deleteQueueValidator;
        private readonly UpdateAtelierQueueStatusValidator _updateAtelierQueueStatusValidator;

        public AtelierService()
        {
            _deleteQueueValidator = new DeleteAtelierQueueValidator();
            _updateAtelierQueueStatusValidator = new UpdateAtelierQueueStatusValidator();
        }

        public List<Atelier> GetByEmployeeId(int employeeId)
        {
            return _repo.GetByEmployeeId(employeeId);
        }

        public Atelier? GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Atelier> GetQueues(QueueFilterDto filter)
        {
            IQueryable<Atelier> query = _repo.GetByQuery(filter.EmployeeId);

            query = ApplyTimeFilter(query, filter.TimeFrame);
            query = ApplyStatusFilter(query, filter.QueueStatus);
            query = ApplySearchFilter(query, filter.Search, filter.Data);

            return [.. query];
        }

        #region GetQueues shattered into pieces

        private IQueryable<Atelier> ApplyTimeFilter(IQueryable<Atelier> query, FilterByTimeFrame timeFrame)
        {
            if (timeFrame != FilterByTimeFrame.None)
            {
                DateTime today = DateTime.Today;

                switch (timeFrame)
                {
                    case FilterByTimeFrame.BeforeQueueDay:
                        query = query.Where(x => x.QueueCreatedAt.Date > today);
                        break;

                    case FilterByTimeFrame.InQueueDay:
                        query = query.Where(x => x.QueueCreatedAt.Date == today);
                        break;

                    case FilterByTimeFrame.AfterQueueDay:
                        query = query.Where(x => x.QueueCreatedAt < today);
                        break;
                }
            }

            return query;
        }

        private IQueryable<Atelier> ApplyStatusFilter(IQueryable<Atelier> query, FilterByQueueStatus queueStatus)
        {
            if (queueStatus != FilterByQueueStatus.None)
            {
                switch (queueStatus)
                {
                    case FilterByQueueStatus.Pending:
                        query = query.Where(x => x.QueueStatus == QueueStatus.Pending);
                        break;

                    case FilterByQueueStatus.Done:
                        query = query.Where(x => x.QueueStatus == QueueStatus.Done);
                        break;

                    case FilterByQueueStatus.Canceled:
                        query = query.Where(x => x.QueueStatus == QueueStatus.Canceled);
                        break;
                }
            }

            return query;
        }

        private IQueryable<Atelier> ApplySearchFilter(IQueryable<Atelier> query, FilterBySearch search, string data)
        {
            if (search != FilterBySearch.None)
            {
                switch (search)
                {
                    case FilterBySearch.FullName:
                        query = query.Where(x => EF.Functions.Like(
                            x.FullName, $"%{data}%"));
                        break;

                    case FilterBySearch.PhoneNumber:
                        query = query.Where(x => EF.Functions.Like(
                            x.PhoneNumber, $"%{data}%"));
                        break;
                }
            }

            return query;
        }

        #endregion

        public ResultModel<int> GetTodayQueuesCount(int employeeId)
        {
            return Success(null, _repo.GetTodayAtelierQueuesCount(employeeId));
        }

        public ResultModel RemoveQueue(DeleteAtelierQueueDto data)
        {
            var validation = _deleteQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                var exists = _repo.Exists(data.QueueId, data.EmployeeId);

                if (exists)
                {
                    _repo.Delete(data.QueueId);

                    if (_repo.SaveChanges())
                        return Success(MessageCode.QueueRemoved);

                    else
                        return Fail(ErrorCode.FailedToDeleteQueue);
                }

                else
                    return Fail(ErrorCode.QueueNotFound);
            }

            else
                return Fail(validation.Errors.ToText());
        }

        public ResultModel UpdateQueue(UpdateAtelierQueueDto data)
        {
            var validation = _updateAtelierQueueStatusValidator.Validate(data);

            if (validation.IsValid)
            {
                var queue = _repo.GetByIdAndEmployeeId(data.QueueId, data.EmployeeId);

                if (queue != null)
                {
                    if (queue.QueueStatus == QueueStatus.Pending)
                    {
                        queue.QueueStatus = data.QueueStatus;
                        //_repo.Update(queue); It's not nessesery

                        if (_repo.SaveChanges())
                        {
                            MessageCode messageCode = data.QueueStatus == QueueStatus.Done
                                ? MessageCode.QueueStatusToDone : MessageCode.QueueStatusToCancel;

                            return Success(messageCode);
                        }

                        else
                            return Fail(ErrorCode.FailedToUpdateQueue);
                    }

                    else
                        return Fail(ErrorCode.CannotSetQueueStatusAnymore);
                }

                else
                    return Fail(ErrorCode.QueueNotFound);
            }

            else
                return Fail(validation.Errors.ToText());
        }
    }
}
