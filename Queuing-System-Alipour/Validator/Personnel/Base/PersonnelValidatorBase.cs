using FluentValidation;
using System.Linq.Expressions;

namespace Queuing_System_Alipour.Validator.Personnel.Base
{
    public abstract class PersonnelValidatorBase<T> : AbstractValidator<T>
    {
        protected void IdRules(Expression<Func<T, int>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("ایدی نوبت نمی تواند خالی باشد");
        }

        protected void LastNameRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("نام خانوادگی نمی تواند خالی باشد")

                .MaximumLength(30)
                .WithMessage("نام خانوادگی نمی تواند بیشتر از 30 کاراکتر باشد");
        }

        protected void QueueCreatedAtRules(Expression<Func<T, DateTime>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("تاریخ ایجاد نوبت نمی تواند خالی باشد");
        }

        protected void QueueEndedAtRules(Expression<Func<T, DateTime>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("تاریخ اتمام نوبت نمی تواند خالی باشد");
        }

        protected void QueueStatusRules(Expression<Func<T, bool>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotNull()
                .WithMessage("وضعیت نوبت نمی تواند خالی باشد");
        }
    }
}
