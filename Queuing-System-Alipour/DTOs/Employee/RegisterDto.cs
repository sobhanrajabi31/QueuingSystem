namespace Queuing_System_Alipour.DTOs.Employee
{
    public sealed class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public bool Role { get; set; }
    }
}
