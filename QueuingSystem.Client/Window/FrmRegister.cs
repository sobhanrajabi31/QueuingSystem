using QueuingSystem.Business.Services;
using QueuingSystem.Client.SignalR;
using QueuingSystem.Client.Tool;
using QueuingSystem.Shared.DTOs.Employee;

namespace QueuingSystem.Client.Window
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
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
            if (txtbox_username.Text.Trim().Length > 0)
                txtbox_password.Enabled = true;
            else
            {
                txtbox_password.Enabled = false;
                txtbox_rpassword.Enabled = false;
            }

            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0 && txtbox_rpassword.Text.Trim().Length > 0 &&
                txtbox_password.Text.Trim() == txtbox_rpassword.Text.Trim())
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private void Txtbox_password_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0)
                txtbox_rpassword.Enabled = true;
            else
                txtbox_rpassword.Enabled = false;

            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0 && txtbox_rpassword.Text.Trim().Length > 0 && txtbox_password.Text.Trim() == txtbox_rpassword.Text.Trim())
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private void Txtbox_rpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0 && txtbox_rpassword.Text.Trim().Length > 0 &&
                txtbox_password.Text.Trim() == txtbox_rpassword.Text.Trim())
                btn_register.Enabled = true;
            else
                btn_register.Enabled = false;
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Register();
        }

        // ============ [ Methods ] ============

        private void Register()
        {
            btn_register.Enabled = false;

            var registerData = new RegisterDto
            {
                Username = txtbox_username.Text.Trim(),
                Password = txtbox_password.Text.Trim(),
                RepeatPassword = txtbox_rpassword.Text.Trim(),
                Role = comboBoxRole.SelectedIndex == 0 ? false : true
            };

            using var _employeeSrv = new EmployeeService();
            var registerResult = _employeeSrv.Register(registerData);

            if (registerResult.IsSuccess)
            {
                var _hubHandler = new HubHandler();

                _hubHandler.StartAsync();
                _hubHandler.UpdateEmployeesChanges();

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
