namespace QueuingSystem.Client.SignalR.Events
{
    public sealed class PersonnelsChangedEventArgs : EventArgs
    {
        public bool ExecutedBy { get; init; }
    }
}
