using QueuingSystem.Business.Services;
using QueuingSystem.Client.SignalR;
using QueuingSystem.Client.Tool;
using QueuingSystem.Shared.DTOs.Employee;
using QueuingSystem.Shared.Handler;

namespace QueuingSystem.Client.Window
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // ============ [ Events ] ============

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (AppState.IsLoginWithToken)
                Login(DataProtector.Decrypt());
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Trim().Length > 0)
                txtbox_password.Enabled = true;
            else
                txtbox_password.Enabled = false;

            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0)
                btn_login.Enabled = true;
            else
                btn_login.Enabled = false;
        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_username.Text.Trim().Length > 0 && txtbox_password.Text.Trim().Length > 0)
                btn_login.Enabled = true;
            else
                btn_login.Enabled = false;
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginCaller();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginCaller();
        }

        // ============ [ Methods ] ============

        private void LoginCaller()
        {
            var loginDto = new LoginDto
            {
                Username = txtbox_username.Text.Trim(),
                Password = txtbox_password.Text.Trim()
            };

            Login(loginDto);
        }

        private async void Login(LoginDto loginDto)
        {
            if (loginDto == null)
                File.Delete(AppState.TokenFileName);

            else
            {
                btn_login.Enabled = false;

                using var _employeeSrv = new EmployeeService();
                var result = _employeeSrv.Login(loginDto);

                if (result.IsSuccess)
                {
                    var hubHandler = new HubHandler();
                    hubHandler.StartAsync();

                    var onlineUsers = await hubHandler.GetOnlineUsersAsync();

                    if (onlineUsers.Contains(result.Data.Id))
                        Mbox.Error(ErrorHandler.GetMessage(ErrorCode.SessionIsFull), Caption.Error);

                    else
                    {
                        if (chckbox_remember.Checked)
                            DataProtector.Encrypt(loginDto);

                        OpenFrmAndSaveData(result.Data.Id, loginDto.Username, result.Data.Role);
                    }
                }

                else
                {
                    File.Delete(AppState.TokenFileName);
                    Mbox.Error(result.Message, Caption.Error);
                }

                btn_login.Enabled = true;
            }
        }

        private void Register()
        {
            var frmRegister = new FrmRegister();
            Hide();
            frmRegister.ShowDialog();
            Close();
        }

        private void OpenFrmAndSaveData(int id, string username, bool role)
        {
            AppState.IsAuthenticated = true;
            AppState.EmployeeId = id;
            AppState.Username = username;
            AppState.Role = role;

            var frm = new FrmMain();

            Hide();
            frm.ShowDialog();
            Application.Exit();
        }
    }
}
