using QueuingSystem.Business.Validator.Employee.Base;
using QueuingSystem.Shared.DTOs.Employee;

namespace QueuingSystem.Business.Validator.Employee
{
    public class RegisterValidator : EmployeeValidatorBase<RegisterDto>
    {
        public RegisterValidator()
        {
            UsernameRules(x => x.Username);
            PasswordRules(x => x.Password);
            PasswordRules(x => x.RepeatPassword);
            RoleRules(x => x.Role);
        }
    }
}
