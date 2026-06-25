using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Services;
using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Handler;

namespace Queuing_System_Alipour.Window
{
    public partial class FrmRegister : Form
    {
        private readonly EmployeeService _employeeSrv;

        public FrmRegister()
        {
            InitializeComponent();
            _employeeSrv = new EmployeeService();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
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

            var registerData = new RegisterDto
            {
                Username = txtbox_username.Text,
                Password = txtbox_password.Text,
                Role = false
            };

            var registerResult = _employeeSrv.Register(registerData);

            if (registerResult.IsSuccess)
            {
                Mbox.Information(registerResult.Message, Caption.Information);

                var frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Application.Exit();
            }

            else
                Mbox.Error(registerResult.Message, Caption.Error);

            btn_register.Enabled = true;
        }
    }
}
