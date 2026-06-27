namespace QueuingSystem.Shared.Entities
{
    public sealed class Personnel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public DateTime QueueCreatedAt { get; set; }
        public DateTime QueueEndedAt { get; set; }
        public bool QueueStatus { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
