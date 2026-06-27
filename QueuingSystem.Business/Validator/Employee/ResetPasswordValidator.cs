using QueuingSystem.Business.Validator.Employee.Base;
using QueuingSystem.Shared.DTOs.Employee;

namespace QueuingSystem.Business.Validator.Employee
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
