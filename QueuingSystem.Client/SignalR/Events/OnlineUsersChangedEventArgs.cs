namespace QueuingSystem.Client.SignalR.Events
{
    public sealed class OnlineUsersChangedEventArgs : EventArgs
    {
        public List<int> OnlineUsers { get; init; } = [];
    }
}
