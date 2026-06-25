using FluentValidation;
using Queuing_System_Alipour.Entities;
using System.Linq.Expressions;

namespace Queuing_System_Alipour.Validator.Atelier.Base
{
    public abstract class AtelierValidatorBase<T> : AbstractValidator<T>
    {
        protected void IdRules(Expression<Func<T, int>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("ایدی نوبت نمی تواند خالی باشد");
        }

        protected void EmployeeIdRules(Expression<Func<T, int>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("ایدی کارمند نمی تواند خالی باشد");
        }

        protected void FullNameRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("نام و نام خانوادگی نمی تواند خالی باشد")

                .MaximumLength(30)
                .WithMessage("نام و نام خانوادگی نمی تواند بیشتر از 30 کاراکتر باشد");
        }

        protected void PhoneNumberRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("شماره تلفن نمی تواند خالی باشد")

                .MaximumLength(11)
                .WithMessage("یک شماره تلفن مجاز 11 کاراکتر دارد")

                .Must(x => x.StartsWith("09"))
                .WithMessage("شماره تلفن وارد شده نامعتبر است");
        }

        protected void QueueCreatedAtRules(Expression<Func<T, DateTime>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)


                .NotEmpty()
                .WithMessage("تاریخ ایجاد نوبت نمی تواند خالی باشد")

                .Must(x => x >= DateTime.Today)
                .WithMessage("تاریخ گذشته نمی تواند انتخاب شود");
        }

        protected void QueueDurationRules(Expression<Func<T, TimeSpan>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .NotEmpty()
                .WithMessage("مدت زمان نوبت نمی تواند خالی باشد");
        }

        protected void QueueStatusRules(Expression<Func<T, QueueStatus>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .IsInEnum()
                .WithMessage("وضعیت نوبت نمی تواند خالی باشد")

                .NotEqual(QueueStatus.Pending)
                .WithMessage("این نوبت از قبل در حالت \"در انتظار\" قرار دارد");
        }

        protected void NoteRules(Expression<Func<T, string>> expression)
        {
            RuleFor(expression)
                .Cascade(CascadeMode.Stop)

                .MaximumLength(100)
                .WithMessage("یادداشت نمی تواند بیشتر از 100 کاراکتر باشد");
        }
    }
}
