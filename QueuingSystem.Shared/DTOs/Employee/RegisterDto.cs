namespace QueuingSystem.Shared.DTOs.Employee
{
    public sealed class RegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public bool Role { get; set; }
    }
}
