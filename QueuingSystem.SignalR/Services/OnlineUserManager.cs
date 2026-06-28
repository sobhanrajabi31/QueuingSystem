using System.Collections.Concurrent;

namespace QueuingSystem.SignalR.Services
{
    public sealed class OnlineUserManager
    {
        private readonly ConcurrentDictionary<int, HashSet<string>> _onlineUsers = new();

        public ICollection<int> OnlineUsers
            => _onlineUsers.Keys;

        public void Add(int employeeId, string connectionId)
        {
            _onlineUsers.AddOrUpdate(employeeId, _ => [connectionId], (_, connections) =>
                {
                    connections.Add(connectionId);
                    return connections;
                });
        }

        public void Remove(string connectionId)
        {
            foreach (var item in _onlineUsers)
            {
                if (item.Value.Remove(connectionId))
                {
                    if (item.Value.Count == 0)
                        _onlineUsers.TryRemove(item.Key, out _);

                    break;
                }
            }
        }
    }
}
