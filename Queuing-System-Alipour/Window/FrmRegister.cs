using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Services;
using Queuing_System_Alipour.Tool;

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

        // ============ [ Events ] ============

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            if (comboBoxRole.Items.Count > 0)
                comboBoxRole.SelectedIndex = 0;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            Login();
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

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            _employeeSrv.Dispose();
        }

        // ============ [ Methods ] ============

        private void Register()
        {
            btn_register.Enabled = false;

            var registerData = new RegisterDto
            {
                Username = txtbox_username.Text,
                Password = txtbox_password.Text,
                RepeatPassword = txtbox_rpassword.Text,
                Role = comboBoxRole.SelectedIndex == 0 ? false : true
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

        private void Login()
        {
            var frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }
    }
}
