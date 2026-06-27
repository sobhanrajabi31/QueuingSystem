using Microsoft.EntityFrameworkCore;
using QueuingSystem.Business.Services.Base;
using QueuingSystem.Business.Validator.Atelier;
using QueuingSystem.Data.Repositories;
using QueuingSystem.Shared.DTOs.Atelier;
using QueuingSystem.Shared.Entities;
using QueuingSystem.Shared.Handler;
using QueuingSystem.Shared.Models;

namespace QueuingSystem.Business.Services
{
    public sealed class AtelierService : BaseService<AtelierRepository>
    {
        private readonly CreateAtelierQueueValidator _createAtelierQueueValidator;
        private readonly UpdateAtelierQueueStatusValidator _updateAtelierQueueStatusValidator;
        private readonly DeleteAtelierQueueValidator _deleteQueueValidator;

        private readonly TimeSpan _workStart;
        private readonly TimeSpan _workEnd;

        public AtelierService()
        {
            _createAtelierQueueValidator = new CreateAtelierQueueValidator();
            _updateAtelierQueueStatusValidator = new UpdateAtelierQueueStatusValidator();
            _deleteQueueValidator = new DeleteAtelierQueueValidator();

            _workStart = TimeSpan.FromHours(8);
            _workEnd = TimeSpan.FromHours(22);
        }

        public List<Atelier> GetByEmployeeId(int employeeId)
        {
            return _repo.GetByEmployeeId(employeeId);
        }

        public Atelier? GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<TimeSpan> GetByDate(int employeeId, DateTime date, TimeSpan duration)
        {
            var queues = _repo.GetByDate(employeeId, date);
            var result = new List<TimeSpan>();

            for (var current = _workStart; current + duration <= _workEnd; current += TimeSpan.FromHours(1))
            {
                var start = date.Date + current;
                var end = start + duration;

                bool hasConflict = queues.Any(x =>
                {
                    var queueStart = x.QueueCreatedAt;
                    var queueEnd = x.QueueEndAt;

                    return start < queueEnd && end > queueStart;
                });

                if (!hasConflict)
                    result.Add(current);
            }

            return result;
        }

        public List<Atelier> GetByFilter(QueueFilterDto filter)
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

        public ResultModel CreateQueue(CreateAtelierQueueDto data)
        {
            var validation = _createAtelierQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                bool exists = _repo.IsTimeSlotExists(data.EmployeeId, data.QueueCreatedAt.Value, data.QueueDuration.Value);

                if (exists)
                    return Fail(ErrorCode.SelectedTimeIsUnavailable);

                else
                {
                    var atelier = new Atelier
                    {
                        FullName = data.FullName,
                        PhoneNumber = data.PhoneNumber,
                        QueueCreatedAt = data.QueueCreatedAt.Value,
                        QueueEndAt = data.QueueCreatedAt.Value.AddHours(data.QueueDuration.Value),
                        QueueStatus = QueueStatus.Pending,
                        Note = data.Note,
                        EmployeeId = data.EmployeeId,
                    };

                    _repo.Create(atelier);

                    if (_repo.SaveChanges())
                        return Success(MessageCode.QueueAdded);

                    else
                        return Fail(ErrorCode.FailedToCreateQueue);
                }
            }

            else
                return Fail(validation.Errors.ToText());
        }

        public ResultModel DeleteQueue(DeleteAtelierQueueDto data)
        {
            var validation = _deleteQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                var exists = _repo.Exists(data.QueueId, data.EmployeeId);

                if (exists)
                {
                    var deleted = _repo.Delete(data.QueueId);

                    if (deleted)
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
