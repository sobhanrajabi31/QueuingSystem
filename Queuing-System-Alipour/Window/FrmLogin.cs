using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Authentication;
using Queuing_System_Alipour.Tool.Handler;
using Queuing_System_Alipour.Tool.PasswordHasher;

namespace Queuing_System_Alipour.Window
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            RaiseAllEvents();
            Database.CheckConnection();

            Database.Refresh<UsersModel>();

            if (Setting.RememberMe != null && Setting.RememberMe.Value)
            {
                var result = Auth.Login(Setting.Username, Setting.Password);
                if (result == null)
                {
                    Mbox.Error(ErrorHandler.GetMessage(ErrorCode.Unknown), Caption.Error);
                    return;
                }

                if (result.Value)
                {
                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                    return;
                }

                var model = new SettingModel
                {
                    RememberMe = false,
                    Username = string.Empty,
                    Password = string.Empty
                };

                Setting.Save(model);

                Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.InvalidUsernameOrPassword), Caption.Warning);
                return;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Length > 0)
                txtbox_password.Enabled = true;
            else
                txtbox_password.Enabled = false;

            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0)
                btn_login.Enabled = true;
            else
                btn_login.Enabled = false;
        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0)
                btn_login.Enabled = true;
            else
                btn_login.Enabled = false;
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtbox_username.Text) && !string.IsNullOrWhiteSpace(txtbox_password.Text))
                btn_login_Click(null, null);
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_username.Text) && string.IsNullOrWhiteSpace(txtbox_password.Text))
            {
                Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.InvalidInputType), Caption.Warning);
                return;
            }

            btn_login.Enabled = false;

            var results = await Database.InitialConnectionCheck();

            btn_login.Enabled = true;

            if (results.Item1 == null || !results.Item1.Value)
            {
                Mbox.Error(ErrorHandler.GetMessage(results.Item2), Caption.Error);
                return;
            }

            var result = Auth.Login(txtbox_username.Text.ToLower(), PasswordHasher.Hash(txtbox_password.Text));

            if (result == null)
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.Unknown), Caption.Error);
                return;
            }
            
            if (result.Value)
            {
                if (chckbox_remember.Checked)
                {
                    var model = new SettingModel();

                    model.RememberMe = chckbox_remember.Checked;
                    model.Username = txtbox_username.Text;
                    model.Password = PasswordHasher.Hash(txtbox_password.Text);

                    Setting.Save(model);
                }

                Setting.Username = txtbox_username.Text;

                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
                Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.InvalidUsernameOrPassword), Caption.Warning);
        }

        private void RaiseAllEvents()
        {
            Database.OnError += (code) =>
            {
                ChangePictureConnectionStatus(false);
                Mbox.Error(ErrorHandler.GetMessage(code), Caption.Error);
            };

            Database.OnSuccessfulPing += () => ChangePictureConnectionStatus(true);
            Database.OnFailurePing += () => ChangePictureConnectionStatus(false);
        }

        private void ChangePictureConnectionStatus(bool status)
        {
            var form = Application.OpenForms["FrmMain"];
            if (form != null)
            {
                var FrmMain = (FrmMain)form;
                FrmMain.ConnectionStatus = status;
                FrmMain.PictureConnection();
            }
            else
                FrmMain.ConnectionStatus = status;
        }
    }
}
