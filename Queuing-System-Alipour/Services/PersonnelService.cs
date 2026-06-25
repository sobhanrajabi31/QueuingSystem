using Queuing_System_Alipour.DTOs.Personnel;
using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Repositories;
using Queuing_System_Alipour.Tool.Handler;
using Queuing_System_Alipour.Validator.Personnel;

namespace Queuing_System_Alipour.Services
{
    public sealed class PersonnelService : IDisposable
    {
        private readonly PersonnelRepository _repo;

        private readonly CreatePersonnelQueueValidator _createPersonnelQueueValidator;
        private readonly UpdatePersonnelQueueValidator _updatePersonnelQueueValidator;

        public PersonnelService()
        {
            _repo = new PersonnelRepository();
            _createPersonnelQueueValidator = new CreatePersonnelQueueValidator();
            _updatePersonnelQueueValidator = new UpdatePersonnelQueueValidator();
        }

        public ResultModel CreateQueue(CreatePersonnelQueueDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _createPersonnelQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var newQueue = new Personnel
                    {
                        LastName = data.LastName,
                        QueueCreatedAt = data.QueueCreatedAt,
                        QueueStatus = false,
                        EmployeeId = AppState.EmployeeId
                    };

                    _repo.CreateQueue(newQueue);

                    if (_repo.SaveChanges())
                    {
                        result.IsSuccess = true;
                        result.Message = MessageHandler.GetMessage(MessageCode.QueueAdded);
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.FailedToCreateQueue);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
            }

            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public ResultModel UpdateQueue(UpdatePersonnelQueueDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _updatePersonnelQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                var queue = _repo.GetById(data.Id);

                if (queue != null)
                {
                    queue.QueueEndedAt = data.QueueEndedAt;
                    queue.QueueStatus = true;

                    if (_repo.SaveChanges())
                    {
                        result.IsSuccess = true;
                        result.Message = MessageHandler.GetMessage(MessageCode.QueueStatusToDone);
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.FailedToUpdateQueue);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.QueueNotFound);
            }

            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
