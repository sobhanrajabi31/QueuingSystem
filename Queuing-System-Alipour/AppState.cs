using Queuing_System_Alipour.Entities;

namespace Queuing_System_Alipour
{
    public static class AppState
    {
        public static string TokenFileName => "token.dat";
        public static bool IsLoginWithToken
        {
            get
            {
                if (File.Exists(TokenFileName))
                    return true;

                else
                    return false;
            }
        }
        public static bool DbConnection { get; set; }

        public static bool IsAuthenticated { get; set; }
        public static int EmployeeId { get; set; }
        public static string Username { get; set; }
        public static bool Role { get; set; }
    }
}
