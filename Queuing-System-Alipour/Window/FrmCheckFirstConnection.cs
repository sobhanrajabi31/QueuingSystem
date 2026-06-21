using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Handler;

namespace QueuingSystem.Forms
{
    public partial class FrmCheckFirstConnection : Form
    {
        public FrmCheckFirstConnection()
        {
            InitializeComponent();
        }

        private void FrmCheckFirstConnection_Load(object sender, EventArgs e)
        {
            var results = Setting.CheckSetting();
            if (!results)
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidSettingFile), Caption.Error);
                Application.Exit();
                return;
            }

            btn_TryAgain_Click(null, null);
        }

        private async void btn_TryAgain_Click(object sender, EventArgs e)
        {
            prog_WaitForConn.MarqueeAnimationSpeed = 25;
            lbl_text.Text = "در حال اتصال ...";
            lbl_text.ForeColor = SystemColors.ControlText;
            btn_TryAgain.Enabled = false;
            btn_TryAgain.BackColor = Color.DimGray;

            btn_TryAgain.Enabled = false;

            var result = await Database.InitialConnectionCheck();

            btn_TryAgain.Enabled = true;

            btn_TryAgain.Enabled = true;
            prog_WaitForConn.MarqueeAnimationSpeed = 0;

            if (result.Item1 != null && result.Item1.Value)
            {
                FrmLogin frm = new FrmLogin();
                Hide();
                frm.ShowDialog();
                Close();
            }
            else
            {
                lbl_text.ForeColor = Color.FromArgb(192, 0, 0);
                btn_TryAgain.BackColor = Color.FromArgb(251, 197, 49);

                lbl_text.Text = ErrorHandler.GetMessage(result.Item2);
            }
        }

        private void btn_Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
