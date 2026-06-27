using FluentValidation;
using System.Linq.Expressions;

namespace QueuingSystem.Business.Validator.Employee.Base
{
    public abstract class EmployeeValidatorBase<T> : AbstractValidator<T>
    {
        protected void IdRules(Expression<Func<T, int>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("ایدی کارمند نمی تواند خالی باشد");
        }

        protected void UsernameRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("نام کاربری نمی تواند خالی باشد")

                .MaximumLength(20)
                .WithMessage("نام کاربری باید حداکثر 20 کاراکتر باشد");
        }

        protected void PasswordRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("پسورد نمی تواند خالی باشد");
        }

        protected void RoleRules(Expression<Func<T, bool>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotNull()
                .WithMessage("نقش نمی تواند خالی باشد");
        }

        protected void AccessLevelRules(Expression<Func<T, bool>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotNull()
                .WithMessage("سطح دسترسی نمی تواند خالی باشد")

                .Must(x => x == false)
                .WithMessage("سطح دسترسی تعریف شده غیرمجاز می باشد");
        }
    }
}
