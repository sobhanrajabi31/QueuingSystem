using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Entities;
using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Repositories;
using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Handler;
using Queuing_System_Alipour.Validator.Employee;

namespace Queuing_System_Alipour.Services
{
    public sealed class EmployeeService : IDisposable
    {
        private readonly EmployeeRepository _repo;

        private readonly ResetPasswordValidator _resetPassvalidator;
        private readonly LoginValidator _loginValidator;
        private readonly RegisterValidator _registerValidator;

        public EmployeeService()
        {
            _repo = new EmployeeRepository();
            _loginValidator = new LoginValidator();
            _resetPassvalidator = new ResetPasswordValidator();
        }

        public ResultModel<LoginInfoDto> Login(LoginDto data)
        {
            var result = new ResultModel<LoginInfoDto>
            {
                IsSuccess = false
            };

            var validation = _loginValidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var employee = _repo.GetByUsername(data.Username);

                    if (employee != null && employee.Password == PasswordHasher.Hash(data.Password))
                    {
                        result.IsSuccess = true;
                        result.Data = new LoginInfoDto
                        {
                            Id = employee.Id,
                            Username = employee.Username,
                            Role = employee.Role
                        };
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.InvalidUsernameOrPassword);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
            }

            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public ResultModel Register(RegisterDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _registerValidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var exists = _repo.ExistsByUsername(data.Username);

                    if (exists)
                        result.Message = ErrorHandler.GetMessage(ErrorCode.UsernameExists);

                    else
                    {
                        var employee = new Employee
                        {
                            Username = data.Username,
                            Password = data.Password,
                            Role = data.Role,
                            AccessLevel = false
                        };

                        _repo.Create(employee);

                        if (_repo.SaveChanges())
                        {
                            result.IsSuccess = true;
                            result.Message = MessageHandler.GetMessage(MessageCode.AccountCreated);
                        }

                        else
                            result.Message = ErrorHandler.GetMessage(ErrorCode.FailedToCreateAccount);
                    }
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
            }

            else
                result.Message = validation.Errors.ToString();
            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public ResultModel ResetPassword(ResetPasswordDto data)
        {
            var result = new ResultModel
            {
                IsSuccess = false
            };

            var validation = _resetPassvalidator.Validate(data);

            if (validation.IsValid)
            {
                if (_repo.IsConnectionOk())
                {
                    var employee = _repo.GetById(data.Id);

                    if (employee != null)
                    {
                        if (employee.Password == PasswordHasher.Hash(data.CurrentPassword))
                        {
                            employee.Password = PasswordHasher.Hash(data.NewPassword);
                            _repo.SaveChanges();

                            result.IsSuccess = true;
                            result.Message = MessageHandler.GetMessage(MessageCode.PasswordChanged);
                        }

                        else
                            result.Message = ErrorHandler.GetMessage(ErrorCode.InvalidCurrentPassword);
                    }

                    else
                        result.Message = ErrorHandler.GetMessage(ErrorCode.UsernameNotFound);
                }

                else
                    result.Message = ErrorHandler.GetMessage(ErrorCode.DbConnectionFailed);
            }

            else
                result.Message = validation.Errors.ToText();

            return result;
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
