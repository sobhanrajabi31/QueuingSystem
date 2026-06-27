namespace QueuingSystem.Shared.DTOs.Personnel
{
    public sealed class CreatePersonnelQueueDto
    {
        public string LastName { get; set; }
        public DateTime QueueCreatedAt { get; set; }
        public int EmployeeId { get; set; }
    }
}
