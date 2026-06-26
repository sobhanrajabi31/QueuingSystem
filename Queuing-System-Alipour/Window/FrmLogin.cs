using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.Services;
using Queuing_System_Alipour.Tool;

namespace Queuing_System_Alipour.Window
{
    public partial class FrmLogin : Form
    {
        private readonly EmployeeService _employeeSrv;

        public FrmLogin()
        {
            InitializeComponent();
            _employeeSrv = new EmployeeService();
        }

        // ============ [ Events ] ============

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoginWithToken();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register();
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
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _employeeSrv.Dispose();
        }

        // ============ [ Methods ] ============

        private void OpenFrmAndSaveData(LoginInfoDto info)
        {
            AppState.IsAuthenticated = true;
            AppState.EmployeeId = info.Id;
            AppState.Username = info.Username;
            AppState.Role = info.Role;

            var frm = new FrmMain();

            Hide();
            frm.ShowDialog();
            Application.Exit();
        }

        private void LoginWithToken()
        {
            if (AppState.IsLoginWithToken)
            {
                var loginDto = DataProtector.Decrypt();

                if (loginDto != null)
                {
                    var result = _employeeSrv.Login(loginDto);

                    if (result.IsSuccess)
                        OpenFrmAndSaveData(result.Data);

                    else
                    {
                        File.Delete(AppState.TokenFileName);
                        Mbox.Error(result.Message, Caption.Error);
                    }
                }

                else
                    File.Delete(AppState.TokenFileName);
            }
        }

        private void Login()
        {
            var loginDto = new LoginDto
            {
                Username = txtbox_username.Text,
                Password = txtbox_password.Text,
            };

            btn_login.Enabled = false;

            var result = _employeeSrv.Login(loginDto);

            if (result.IsSuccess)
            {
                if (chckbox_remember.Checked)
                    DataProtector.Encrypt(result.Data);

                OpenFrmAndSaveData(result.Data);
            }

            else
                Mbox.Error(result.Message, Caption.Error);

            btn_login.Enabled = true;
        }

        private void Register()
        {
            var frmRegister = new FrmRegister();
            Hide();
            frmRegister.ShowDialog();
            Close();
        }
    }
}
