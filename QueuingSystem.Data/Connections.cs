namespace QueuingSystem.Data
{
    public static class Connections
    {
        public static string AppCS => Environment.GetEnvironmentVariable("QueuingSystemCS", EnvironmentVariableTarget.User);
    }
}
