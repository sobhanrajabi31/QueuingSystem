namespace Queuing_System_Alipour.DTOs.Atelier
{
    public sealed class CreateAtelierQueueDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime QueueCreatedAt { get; set; }
        public TimeSpan QueueDuration { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
    }
}
