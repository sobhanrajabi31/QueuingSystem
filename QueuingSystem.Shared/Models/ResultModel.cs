namespace QueuingSystem.Shared.Models
{
    public class ResultModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class ResultModel<T> : ResultModel
    {
        public T Data { get; set; }
    }
}
