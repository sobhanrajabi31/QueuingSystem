using Queuing_System_Alipour.DTOs.Atelier;
using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Repositories;
using Queuing_System_Alipour.Tool.Handler;
using Queuing_System_Alipour.Validator.Atelier;

namespace Queuing_System_Alipour.Services
{
    public sealed class AtelierService : IDisposable
    {
        private readonly AtelierRepository _repo;

        private readonly DeleteAtelierQueueValidator _deleteQueueValidator;
        private readonly UpdateAtelierQueueStatusValidator _updateAtelierQueueStatusValidator;

        public AtelierService()
        {
            _repo = new AtelierRepository();
            _deleteQueueValidator = new DeleteAtelierQueueValidator();
            _updateAtelierQueueStatusValidator = new UpdateAtelierQueueStatusValidator();
        }

        public ResultModel RemoveQueue(DeleteAtelierQueueDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _deleteQueueValidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var queue = _repo.GetById(data.EmployeeId)
                        .SingleOrDefault(x => x.Id == data.QueueId);

                    if (queue != null)
                    {
                        _repo.Delete(queue);

                        if (_repo.SaveChanges())
                        {
                            result.IsSuccess = true;
                            result.Message = MessageHandler.GetMessage(MessageCode.QueueRemoved);
                        }

                        else
                            result.Message = ErrorHandler.GetMessage(ErrorCode.FailedToDeleteQueue);
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.QueueNotFound);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
            }

            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public ResultModel UpdateQueue(UpdateAtelierQueueDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _updateAtelierQueueStatusValidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var queue = _repo.GetById(data.EmployeeId)
                        .SingleOrDefault(x => x.Id == data.QueueId);

                    if (queue != null)
                    {
                        if (queue.QueueStatus == 0)
                        {
                            queue.QueueStatus = data.QueueStatus;
                            _repo.Update(queue);

                            if (_repo.SaveChanges())
                            {
                                MessageCode messageCode = data.QueueStatus == 1
                                    ? MessageCode.QueueStatusToDone : MessageCode.QueueStatusToCancel;

                                result.IsSuccess = true;
                                result.Message = MessageHandler.GetMessage(messageCode);
                            }

                            else
                                result.Message = ErrorHandler.GetMessage(ErrorCode.FailedToUpdateQueue);
                        }

                        else
                            result.Message = ErrorHandler.GetMessage(ErrorCode.CannotSetQueueStatusAnymore);
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.QueueNotFound);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
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
