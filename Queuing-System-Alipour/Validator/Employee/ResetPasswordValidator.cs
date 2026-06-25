using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Validator.Employee.Base;

namespace Queuing_System_Alipour.Validator.Employee
{
    public sealed class ResetPasswordValidator : EmployeeValidatorBase<ResetPasswordDto>
    {
        public ResetPasswordValidator()
        {
            IdRules(x => x.Id);
            PasswordRules(x => x.CurrentPassword);
            PasswordRules(x => x.NewPassword);
        }
    }
}
