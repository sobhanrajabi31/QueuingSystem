namespace Queuing_System_Alipour.Entities
{
    public sealed class Atelier
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime QueueCreatedAt { get; set; }
        public TimeSpan QueueDuration { get; set; }
        public int QueueStatus { get; set; }
        public string Note { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
