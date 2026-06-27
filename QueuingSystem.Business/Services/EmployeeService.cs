using QueuingSystem.Business.Services.Base;
using QueuingSystem.Business.Validator.Employee;
using QueuingSystem.Data.Repositories;
using QueuingSystem.Shared.DTOs.Employee;
using QueuingSystem.Shared.Entities;
using QueuingSystem.Shared.Handler;
using QueuingSystem.Shared.Models;
using QueuingSystem.Shared.Tool;

namespace QueuingSystem.Business.Services
{
    public sealed class EmployeeService : BaseService<EmployeeRepository>
    {
        private readonly ResetPasswordValidator _resetPassvalidator;
        private readonly LoginValidator _loginValidator;
        private readonly RegisterValidator _registerValidator;

        public EmployeeService()
        {
            _resetPassvalidator = new ResetPasswordValidator();
            _loginValidator = new LoginValidator();
            _registerValidator = new RegisterValidator();
        }

        public ResultModel<LoginInfoDto> Login(LoginDto data)
        {
            var validation = _loginValidator.Validate(data);

            if (validation.IsValid)
            {
                var employee = _repo.GetByUsername(data.Username);

                if (employee != null && employee.Password == PasswordHasher.Hash(data.Password))
                    return Success(null, new LoginInfoDto
                    {
                        Id = employee.Id,
                        Username = employee.Username,
                        Password = data.Password,
                        Role = employee.Role
                    });

                else
                    return Fail<LoginInfoDto>(ErrorCode.InvalidUsernameOrPassword, null);
            }

            else
                return Fail<LoginInfoDto>(validation.Errors.ToText(), null);
        }

        public ResultModel Register(RegisterDto data)
        {
            var validation = _registerValidator.Validate(data);

            if (validation.IsValid)
            {
                if (data.Password == data.RepeatPassword)
                {
                    var exists = _repo.ExistsByUsername(data.Username);

                    if (exists)
                        return Fail(ErrorCode.UsernameExists);

                    else
                    {
                        var employee = new Employee
                        {
                            Username = data.Username,
                            Password = PasswordHasher.Hash(data.Password),
                            Role = data.Role,
                            AccessLevel = false
                        };

                        _repo.Create(employee);

                        if (_repo.SaveChanges())
                            return Success(MessageCode.AccountCreated);

                        else
                            return Fail(ErrorCode.FailedToCreateAccount);
                    }
                }

                else
                    return Fail(ErrorCode.InvalidRepeatPassword);
            }

            else
                return Fail(validation.Errors.ToText());
        }

        public ResultModel ResetPassword(ResetPasswordDto data)
        {
            var validation = _resetPassvalidator.Validate(data);

            if (validation.IsValid)
            {
                var employee = _repo.GetById(data.Id);

                if (employee != null)
                {
                    if (employee.Password == PasswordHasher.Hash(data.CurrentPassword))
                    {
                        employee.Password = PasswordHasher.Hash(data.NewPassword);
                        _repo.SaveChanges();

                        return Success(MessageCode.PasswordChanged);
                    }

                    else
                        return Fail(ErrorCode.InvalidCurrentPassword);
                }

                else
                    return Fail(ErrorCode.UsernameNotFound);
            }

            else
                return Fail(validation.Errors.ToText());
        }
    }
}
