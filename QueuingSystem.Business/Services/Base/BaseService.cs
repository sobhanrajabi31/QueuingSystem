using QueuingSystem.Data.Repositories.Base;
using QueuingSystem.Shared.Handler;
using QueuingSystem.Shared.Models;

namespace QueuingSystem.Business.Services.Base
{
    public abstract class BaseService<TRepository> : IDisposable
        where TRepository : BaseRepository, new()
    {
        protected readonly TRepository _repo;

        protected BaseService()
        {
            _repo = new();
        }

        protected ResultModel Success(MessageCode? code = null)
        {
            return new ResultModel
            {
                IsSuccess = true,
                Message = code.HasValue ? MessageHandler.GetMessage(code.Value) : ""
            };
        }

        protected ResultModel<T> Success<T>(MessageCode? code, T data)
        {
            return new ResultModel<T>
            {
                IsSuccess = true,
                Message = code.HasValue ? MessageHandler.GetMessage(code.Value) : "",
                Data = data
            };
        }

        protected ResultModel Fail(ErrorCode code)
        {
            return new ResultModel
            {
                IsSuccess = false,
                Message = ErrorHandler.GetMessage(code)
            };
        }

        protected ResultModel<T> Fail<T>(ErrorCode code, T? data)
        {
            return new ResultModel<T>
            {
                IsSuccess = false,
                Message = ErrorHandler.GetMessage(code),
                Data = data
            };
        }

        protected ResultModel Fail(string message)
        {
            return new ResultModel
            {
                IsSuccess = false,
                Message = message
            };
        }

        protected ResultModel<T> Fail<T>(string message, T? data)
        {
            return new ResultModel<T>
            {
                IsSuccess = false,
                Data = data
            };
        }

        public void Dispose()
        {
            _repo.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
