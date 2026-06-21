using Queuing_System_Alipour.Tool.SafeLabel;

namespace QueuingSystem.Features.Toast
{
    public partial class ToastMessage : Form
    {
        private static ToastMessage _instance;

        private SafeLabel lblMessage;
        private Button btnClose;
        System.Windows.Forms.Timer closeTimer;

        public static void ShowToast(string message)
        {
            _instance?.Close();
            _instance = new ToastMessage(message);
            _instance.Show();
        }

        public static void CloseToast()
        {
            _instance?.Close();
            _instance = null;
        }

        private ToastMessage(string message)
        {
            InitializeComponent();

            if (closeTimer == null)
            {
                closeTimer = new System.Windows.Forms.Timer()
                {
                    Interval = 10000
                };
                closeTimer.Tick += (s, e) => { CloseToast(); closeTimer.Stop(); };
            }
            closeTimer.Start();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            ShowInTaskbar = false;
            BackColor = Color.FromArgb(40, 40, 40);
            ForeColor = Color.White;
            Width = 300;
            Height = 100;

            var screen = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(screen.Width - Width - 10, screen.Height - Height - 10);

            btnClose = new Button()
            {
                Text = "×",
                Font = new Font("Vazirmatn", 10, FontStyle.Bold),
                Width = 30,
                Height = 30,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(Width - 35, 5),
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;

            btnClose.Click += (s, e) => CloseToast();
            Controls.Add(btnClose);

            lblMessage = new SafeLabel()
            {
                Text = message,
                Font = new Font("Vazirmatn ExtraBold", 12, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(Width - 20, Height - 20),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                RightToLeft = RightToLeft.Yes
            };
            Controls.Add(lblMessage);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            closeTimer.Stop();
            base.OnFormClosed(e);
            if (_instance == this)
                _instance = null;
        }
    }
}
