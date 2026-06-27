namespace QueuingSystem.Shared.DTOs.Employee
{
    public sealed class ResetPasswordDto
    {
        public int Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
