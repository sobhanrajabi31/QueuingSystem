using QueuingSystem.Business.Services.Base;
using QueuingSystem.Business.Validator.Personnel;
using QueuingSystem.Data.Repositories;
using QueuingSystem.Shared.DTOs.Personnel;
using QueuingSystem.Shared.Entities;
using QueuingSystem.Shared.Handler;
using QueuingSystem.Shared.Models;

namespace QueuingSystem.Business.Services
{
    public sealed class PersonnelService : BaseService<PersonnelRepository>
    {
        private readonly CreatePersonnelQueueValidator _createPersonnelQueueValidator;
        private readonly UpdatePersonnelQueueValidator _updatePersonnelQueueValidator;

        public PersonnelService()
        {
            _createPersonnelQueueValidator = new CreatePersonnelQueueValidator();
            _updatePersonnelQueueValidator = new UpdatePersonnelQueueValidator();
        }

        public List<Personnel> GetByDate(DateTime dateTime)
        {
            return _repo.GetByDate(dateTime);
        }

        public ResultModel CreateQueue(CreatePersonnelQueueDto data)
        {
            var validation = _createPersonnelQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                var newQueue = new Personnel
                {
                    LastName = data.LastName,
                    QueueCreatedAt = data.QueueCreatedAt,
                    QueueStatus = false,
                    EmployeeId = data.EmployeeId
                };

                _repo.CreateQueue(newQueue);

                if (_repo.SaveChanges())
                    return Success(MessageCode.QueueAdded);

                else
                    return Fail(ErrorCode.FailedToCreateQueue);
            }

            else
                return Fail(validation.Errors.ToText());
        }

        public ResultModel UpdateQueue(UpdatePersonnelQueueDto data)
        {
            var validation = _updatePersonnelQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                var queue = _repo.GetById(data.Id);

                if (queue != null)
                {
                    if (queue.QueueStatus)
                        return Fail(ErrorCode.CannotSetQueueStatusAnymore);

                    else
                    {
                        queue.QueueEndedAt = data.QueueEndedAt;
                        queue.QueueStatus = true;

                        if (_repo.SaveChanges())
                            return Success(MessageCode.QueueStatusToDone);

                        else
                            return Fail(ErrorCode.FailedToUpdateQueue);
                    }
                }

                else
                    return Fail(ErrorCode.QueueNotFound);
            }

            else
                return Fail(validation.Errors.ToText());
        }

        public ResultModel DeleteQueue(int id)
        {
            var exists = _repo.Exists(id);

            if (exists)
            {
                bool result = _repo.DeleteQueue(id);

                if (result)
                    return Success(MessageCode.QueueRemoved);

                else
                    return Fail(ErrorCode.FailedToDeleteQueue);
            }

            else
                return Fail(ErrorCode.QueueNotFound);
        }
    }
}
