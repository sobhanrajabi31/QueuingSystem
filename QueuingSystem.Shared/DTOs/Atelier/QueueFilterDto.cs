namespace QueuingSystem.Shared.DTOs.Atelier
{
    public enum FilterByTimeFrame
    {
        None = 0, BeforeQueueDay, InQueueDay, AfterQueueDay
    }

    public enum FilterByQueueStatus
    {
        None = 0, Pending, Done, Canceled
    }

    public enum FilterBySearch
    {
        None = 0, FullName, PhoneNumber
    }

    public sealed class QueueFilterDto
    {
        public int EmployeeId { get; set; }
        public FilterByTimeFrame TimeFrame { get; set; }
        public FilterByQueueStatus QueueStatus { get; set; }
        public FilterBySearch Search { get; set; }
        public string Data { get; set; }
    }
}
