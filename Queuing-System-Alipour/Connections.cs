namespace Queuing_System_Alipour
{
    public static class Connections
    {
        public static string AppCS => Environment.GetEnvironmentVariable("QueuingSystemCS", EnvironmentVariableTarget.User);
    }
}
