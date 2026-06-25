using Queuing_System_Alipour.Window;

namespace Queuing_System_Alipour
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}