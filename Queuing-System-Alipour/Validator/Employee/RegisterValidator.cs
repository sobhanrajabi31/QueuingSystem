using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Validator.Employee.Base;

namespace Queuing_System_Alipour.Validator.Employee
{
    public class RegisterValidator : EmployeeValidatorBase<RegisterDto>
    {
        public RegisterValidator()
        {
            UsernameRules(x => x.Username);
            PasswordRules(x => x.Password);
            RoleRules(x => x.Role);
        }
    }
}
