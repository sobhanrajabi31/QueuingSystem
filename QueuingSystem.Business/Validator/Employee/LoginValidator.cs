using QueuingSystem.Business.Validator.Employee.Base;
using QueuingSystem.Shared.DTOs.Employee;

namespace QueuingSystem.Business.Validator.Employee
{
    public sealed class LoginValidator : EmployeeValidatorBase<LoginDto>
    {
        public LoginValidator()
        {
            UsernameRules(x => x.Username);
            PasswordRules(x => x.Password);
        }
    }
}
