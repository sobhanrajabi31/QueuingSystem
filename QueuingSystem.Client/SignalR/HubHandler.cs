using Microsoft.AspNetCore.SignalR.Client;
using QueuingSystem.Client.SignalR.Events;
using QueuingSystem.Shared.Handler;
using QueuingSystem.Shared.Models;
using QueuingSystem.Shared.SignalR;

namespace QueuingSystem.Client.SignalR
{
    public sealed class HubHandler : IAsyncDisposable
    {
        private const string hubUrl = "http://localhost:5005/queueHub";

        private readonly HubConnection _connection;

        public event EventHandler<ConnectionExceptionHandlerEventArgs>? ExceptionHandler;

        public event EventHandler<OnlineUsersChangedEventArgs>? OnlineUsersChanged;
        public event EventHandler? AteliersChanged;
        public event EventHandler? PersonnelsChanged;
        public event EventHandler? EmployeesChanged;

        public bool silentMode = false;

        public HubHandler()
        {
            _connection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            _connection.On<List<int>>(HubMethods.OnlineUsersChanged, RaiseOnlineUsersChanged);
            _connection.On(HubMethods.AteliersChanged, RaiseAteliersChanged);
            _connection.On(HubMethods.PersonnelsChanged, RaisePersonnelsChanged);
            _connection.On(HubMethods.EmployeesChanged, RaiseEmployeesChanged);

            _connection.Reconnecting += ex =>
            {
                ExceptionInvoker(false, ErrorCode.ReconnectingToServer);
                return Task.CompletedTask;
            };

            _connection.Reconnected += id =>
            {
                ExceptionInvoker(true, null, MessageCode.ReconnectedConnection);
                return Task.CompletedTask;
            };

            _connection.Closed += ex =>
            {
                if (!silentMode)
                    ExceptionInvoker(false, ErrorCode.ConnectionClosed);

                return Task.CompletedTask;
            };
        }

        private void ExceptionInvoker(bool IsSuccess, ErrorCode? errorCode = null, MessageCode? messageCode = null)
        {
            ExceptionHandler.Invoke(this, new ConnectionExceptionHandlerEventArgs
            {
                Result = new ResultModel
                {
                    IsSuccess = IsSuccess,
                    Message = IsSuccess ? MessageHandler.GetMessage(messageCode.Value) : ErrorHandler.GetMessage(errorCode.Value)
                }
            });
        }

        public async Task StartAsync(int employeeId)
        {
            try
            {
                await _connection.StartAsync();
                await Connect(employeeId);
            }

            catch
            {
                ExceptionInvoker(false, ErrorCode.ConnectionFailedDuringFirstConnection);
            }
        }

        private async Task Connect(int employeeId)
        {
            await _connection.InvokeAsync(HubMethods.Connect, employeeId);
        }

        private void RaiseOnlineUsersChanged(List<int> onlineUsers)
        {
            OnlineUsersChanged?.Invoke(this, new OnlineUsersChangedEventArgs
            {
                OnlineUsers = onlineUsers
            });
        }

        public async Task UpdateAtelierChanges(int employeeId)
        {
            try
            {
                await _connection.InvokeAsync(HubMethods.AteliersChanged, employeeId);
            }

            catch
            {
                ExceptionInvoker(false, ErrorCode.ConnectionFailedDuringAtelierActivity);
            }
        }

        private void RaiseAteliersChanged()
        {
            AteliersChanged?.Invoke(this, EventArgs.Empty);
        }

        public async Task UpdateEmployeesChanges()
        {
            try
            {
                await _connection.InvokeAsync(HubMethods.EmployeesChanged);
            }

            catch
            {
                ExceptionInvoker(false, ErrorCode.ConnectionFailedDuringEmployeeActivity);
            }
        }

        private void RaiseEmployeesChanged()
        {
            EmployeesChanged?.Invoke(this, EventArgs.Empty);
        }

        public async Task UpdatePersonnelChanges()
        {
            try
            {
                await _connection.InvokeAsync(HubMethods.PersonnelsChanged);
            }

            catch
            {
                ExceptionInvoker(false, ErrorCode.ConnectionFailedDuringPersonnelActivity);
            }
        }

        private void RaisePersonnelsChanged()
        {
            PersonnelsChanged?.Invoke(this, EventArgs.Empty);
        }

        public async ValueTask DisposeAsync()
        {
            await _connection.StopAsync();
            await _connection.DisposeAsync();
        }
    }
}
