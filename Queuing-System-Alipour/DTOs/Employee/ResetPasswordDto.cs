namespace Queuing_System_Alipour.DTOs.Employee
{
    public sealed class ResetPasswordDto
    {
        public int Id { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
