namespace QueuingSystem.Shared.DTOs.Personnel
{
    public sealed class UpdatePersonnelQueueDto
    {
        public int Id { get; set; }
        public DateTime QueueEndedAt { get; set; }
    }
}
