using QueuingSystem.Features;
using QueuingSystem.Features.Authentication;
using QueuingSystem.Features.ErrorHandler;
using QueuingSystem.Features.Handler;
using System;
using System.Windows.Forms;

namespace QueuingSystem.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            var results = Setting.CheckSetting();
            if (!results)
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidSettingFile), Caption.Error);
                Application.Exit();
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Txtbox_username_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Length > 0)
                txtbox_password.Enabled = true;
            else
            {
                txtbox_password.Enabled = false;
                txtbox_rpassword.Enabled = false;
            }

            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0 && txtbox_rpassword.Text.Length > 0 && txtbox_password.Text == txtbox_rpassword.Text)
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private void Txtbox_password_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0)
                txtbox_rpassword.Enabled = true;
            else
                txtbox_rpassword.Enabled = false;

            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0 && txtbox_rpassword.Text.Length > 0 && txtbox_password.Text == txtbox_rpassword.Text)
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private void Txtbox_rpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Length > 0 && txtbox_password.Text.Length > 0 && txtbox_rpassword.Text.Length > 0 && txtbox_password.Text == txtbox_rpassword.Text)
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private async void Btn_register_Click(object sender, EventArgs e)
        {
            btn_register.Enabled = false;

            var results = await Database.InitialConnectionCheck();

            btn_register.Enabled = true;

            if (results.Item1 == null || !results.Item1.Value)
            {
                Mbox.Error(ErrorHandler.GetMessage(results.Item2), Caption.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbox_username.Text) && string.IsNullOrWhiteSpace(txtbox_password.Text) && string.IsNullOrWhiteSpace(txtbox_rpassword.Text))
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidInputType), Caption.Error);
                return;
            }

            if (txtbox_password.Text != txtbox_rpassword.Text)
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidRepeatPassword), Caption.Error);
                return;
            }

            var result = Auth.Register(txtbox_username.Text.ToLower(), txtbox_password.Text);

            if (result == null)
            {
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.Unknown), Caption.Error);
                return;
            }

            if (result.Value)
            {
                Mbox.Information(MessageHandler.GetMessage(MessageCode.AccountCreated), Caption.Information);

                FrmLogin frm = new FrmLogin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
                return;
            }

            Mbox.Error(ErrorHandler.GetMessage(ErrorCode.UsernameExists), Caption.Error);
            return;
        }
    }
}
