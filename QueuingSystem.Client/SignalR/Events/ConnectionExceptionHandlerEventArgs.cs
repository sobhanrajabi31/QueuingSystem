using QueuingSystem.Shared.Models;

namespace QueuingSystem.Client.SignalR.Events
{
    public sealed class ConnectionExceptionHandlerEventArgs : EventArgs
    {
        public ResultModel Result { get; init; }
    }
}
