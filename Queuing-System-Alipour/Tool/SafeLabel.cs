namespace Queuing_System_Alipour.Tool
{
    public sealed class SafeLabel : Label
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x203)
                return;
            base.WndProc(ref m); 
        }
    }
}