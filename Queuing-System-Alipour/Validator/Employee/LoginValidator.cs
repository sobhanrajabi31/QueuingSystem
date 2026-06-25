using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Validator.Employee.Base;

namespace Queuing_System_Alipour.Validator.Employee
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
