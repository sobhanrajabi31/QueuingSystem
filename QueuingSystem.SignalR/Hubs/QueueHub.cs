using Microsoft.AspNetCore.SignalR;
using QueuingSystem.Shared.SignalR;
using QueuingSystem.SignalR.Services;

namespace QueuingSystem.SignalR.Hubs
{
    public sealed class QueueHub : Hub
    {
        private readonly OnlineUserManager _onlineUsers;

        public QueueHub(OnlineUserManager onlineUsers)
        {
            _onlineUsers = onlineUsers;
        }

        public override async Task OnDisconnectedAsync(Exception? ex)
        {
            _onlineUsers.Remove(Context.ConnectionId);

            await Clients.All.SendAsync(
                HubMethods.OnlineUsersChanged,
                _onlineUsers.OnlineUsers);

            await base.OnDisconnectedAsync(ex);
        }

        public async Task Connect(int employeeId)
        {
            await Groups.AddToGroupAsync(
                Context.ConnectionId, employeeId.ToString());

            _onlineUsers.Add(employeeId, Context.ConnectionId);

            await Clients.All.SendAsync(
                HubMethods.OnlineUsersChanged,
                _onlineUsers.OnlineUsers);
        }

        public Task<List<int>> GetOnlineUsers()
        {
            return Task.FromResult(_onlineUsers.OnlineUsers.ToList());
        }

        public async Task AteliersChanged(int employeeId)
        {
            await Clients.Group(employeeId.ToString())
                .SendAsync(HubMethods.AteliersChanged);
        }

        public async Task EmployeesChanged()
        {
            await Clients.All.SendAsync(HubMethods.EmployeesChanged);
        }

        public async Task PersonnelsChanged(bool executedBy)
        {
            await Clients.All.SendAsync(HubMethods.PersonnelsChanged, executedBy);
        }
    }
}
