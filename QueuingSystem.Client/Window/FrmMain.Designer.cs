using QueuingSystem.Client.Tool;
using Resource = QueuingSystem.Client.Resources.Resource;

namespace QueuingSystem.Client.Window
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            sidebarPanel = new Panel();
            btnSetting = new Button();
            btnPersonnel = new Button();
            btnAtelier = new Button();
            btnStatistics = new Button();
            btnDashboard = new Button();
            welcomePanel = new Panel();
            picDigitalClock = new PictureBox();
            DashboardPanel = new Panel();
            RolePanel = new Panel();
            RolePic = new PictureBox();
            lblRole = new SafeLabel();
            lblRoleText = new SafeLabel();
            atelierCountPanel = new Panel();
            picAtelierCountPanel = new PictureBox();
            lblAtelierCount = new SafeLabel();
            lblAtelierCountText = new SafeLabel();
            ConnectionPanel = new Panel();
            DatePic = new PictureBox();
            lblDate = new SafeLabel();
            lblDateText = new SafeLabel();
            UsernamePanel = new Panel();
            picUsernamePanel = new PictureBox();
            lblUsername = new SafeLabel();
            lblWelcomeText = new SafeLabel();
            lbl_dashboard = new SafeLabel();
            StatisticsPanel = new Panel();
            StatsDatagrid = new DataGridView();
            StatUsernameColumn = new DataGridViewTextBoxColumn();
            StatAtelierCount = new DataGridViewTextBoxColumn();
            StatPersonnelCount = new DataGridViewTextBoxColumn();
            StatConnectionColumn = new DataGridViewTextBoxColumn();
            lbl_statistics = new SafeLabel();
            PersonnelPanel = new Panel();
            PersonnelDoneDatagridview = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            PersonnelDatagridview = new DataGridView();
            PersonnelIdColumn = new DataGridViewTextBoxColumn();
            PersonnelLastNameColumn = new DataGridViewTextBoxColumn();
            PersonnelWaitTimeColumn = new DataGridViewTextBoxColumn();
            lbl_next = new SafeLabel();
            lbl_nextText = new SafeLabel();
            lbl_personnel = new SafeLabel();
            action_panel = new Panel();
            txtbox_fullname = new TextBox();
            btn_deletePersonnelQueue = new Button();
            btn_addQueue = new Button();
            lbl_fullname = new SafeLabel();
            QueuePanel = new Panel();
            btn_nextQueue = new Button();
            lbl_CurrentQueue = new SafeLabel();
            lbl_currentQueueText = new SafeLabel();
            AtelierPanel = new Panel();
            panel3 = new Panel();
            lbl_FilterByQueueStatus = new SafeLabel();
            combobox_QueueStatus = new ComboBox();
            panel2 = new Panel();
            lbl_FilterByDate = new SafeLabel();
            combobox_TimeFrame = new ComboBox();
            panel1 = new Panel();
            btnAddFilter = new Button();
            btnClearFilter = new Button();
            StatusPanel = new Panel();
            lbl_Status = new SafeLabel();
            btn_CancelAtelierQueue = new Button();
            btn_DoneAtelierQueue = new Button();
            QueueStatusPanel = new Panel();
            lbl_Undone = new SafeLabel();
            UndonePic = new PictureBox();
            lbl_Cancel = new SafeLabel();
            CancelPic = new PictureBox();
            lbl_Done = new SafeLabel();
            DonePic = new PictureBox();
            DayStatusPanel = new Panel();
            lbl_Expire = new SafeLabel();
            ExpirePic = new PictureBox();
            lbl_Today = new SafeLabel();
            TodayPic = new PictureBox();
            lbl_Upcoming = new SafeLabel();
            UpcomingPic = new PictureBox();
            AtelierDatagridview = new DataGridView();
            ActionPanel = new Panel();
            lbl_Action = new SafeLabel();
            btn_deleteAtelierQueue = new Button();
            btn_addAtelierQueue = new Button();
            FilterPanel = new Panel();
            lbl_FilterBySearch = new SafeLabel();
            combobox_SearchBy = new ComboBox();
            txtbox_SearchBy = new TextBox();
            SettingPanel = new Panel();
            groupbox_accManage = new GroupBox();
            btnLogout = new Button();
            groupbox_ChangePass = new GroupBox();
            btnResetPass = new Button();
            lbl_newPass = new SafeLabel();
            lbl_oldPass = new SafeLabel();
            txtbox_newPass = new TextBox();
            txtbox_oldPass = new TextBox();
            lbl_setting = new SafeLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            AtelierNoteColumn = new DataGridViewButtonColumn();
            AtelierStatusDayColumn = new DataGridViewImageColumn();
            AtelierStatusColumn = new DataGridViewImageColumn();
            AtelierDateColumn = new DataGridViewTextBoxColumn();
            AtelierHourColumn = new DataGridViewTextBoxColumn();
            AtelierSpentColumn = new DataGridViewTextBoxColumn();
            AtelierPhoneNumberColumn = new DataGridViewTextBoxColumn();
            AtelierFullNameColumn = new DataGridViewTextBoxColumn();
            AtelierIDColumn = new DataGridViewTextBoxColumn();
            sidebarPanel.SuspendLayout();
            welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDigitalClock).BeginInit();
            DashboardPanel.SuspendLayout();
            RolePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RolePic).BeginInit();
            atelierCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAtelierCountPanel).BeginInit();
            ConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatePic).BeginInit();
            UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsernamePanel).BeginInit();
            StatisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StatsDatagrid).BeginInit();
            PersonnelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PersonnelDoneDatagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonnelDatagridview).BeginInit();
            action_panel.SuspendLayout();
            QueuePanel.SuspendLayout();
            AtelierPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            StatusPanel.SuspendLayout();
            QueueStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UndonePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CancelPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DonePic).BeginInit();
            DayStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpirePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TodayPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpcomingPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AtelierDatagridview).BeginInit();
            ActionPanel.SuspendLayout();
            FilterPanel.SuspendLayout();
            SettingPanel.SuspendLayout();
            groupbox_accManage.SuspendLayout();
            groupbox_ChangePass.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(25, 42, 86);
            sidebarPanel.Controls.Add(btnSetting);
            sidebarPanel.Controls.Add(btnPersonnel);
            sidebarPanel.Controls.Add(btnAtelier);
            sidebarPanel.Controls.Add(btnStatistics);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(welcomePanel);
            sidebarPanel.Dock = DockStyle.Right;
            sidebarPanel.Location = new Point(795, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(205, 541);
            sidebarPanel.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.FromArgb(245, 246, 250);
            btnSetting.Image = Resource.settings;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(6, 411);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(193, 55);
            btnSetting.TabIndex = 8;
            btnSetting.TabStop = false;
            btnSetting.Text = "تنظیمات";
            btnSetting.TextAlign = ContentAlignment.MiddleRight;
            btnSetting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += BtnSetting_Click;
            // 
            // btnPersonnel
            // 
            btnPersonnel.FlatAppearance.BorderSize = 0;
            btnPersonnel.FlatStyle = FlatStyle.Flat;
            btnPersonnel.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersonnel.ForeColor = Color.FromArgb(245, 246, 250);
            btnPersonnel.Image = Resources.Resource.authors;
            btnPersonnel.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonnel.Location = new Point(6, 289);
            btnPersonnel.Name = "btnPersonnel";
            btnPersonnel.Size = new Size(193, 55);
            btnPersonnel.TabIndex = 5;
            btnPersonnel.TabStop = false;
            btnPersonnel.Text = "نوبت پرسنلی";
            btnPersonnel.TextAlign = ContentAlignment.MiddleRight;
            btnPersonnel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPersonnel.UseVisualStyleBackColor = true;
            btnPersonnel.Click += BtnPersonnel_Click;
            // 
            // btnAtelier
            // 
            btnAtelier.FlatAppearance.BorderSize = 0;
            btnAtelier.FlatStyle = FlatStyle.Flat;
            btnAtelier.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtelier.ForeColor = Color.FromArgb(245, 246, 250);
            btnAtelier.Image = Resources.Resource.palette;
            btnAtelier.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtelier.Location = new Point(6, 350);
            btnAtelier.Name = "btnAtelier";
            btnAtelier.Size = new Size(193, 55);
            btnAtelier.TabIndex = 6;
            btnAtelier.TabStop = false;
            btnAtelier.Text = "نوبت آتلیه";
            btnAtelier.TextAlign = ContentAlignment.MiddleRight;
            btnAtelier.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAtelier.UseVisualStyleBackColor = true;
            btnAtelier.Click += BtnAtelier_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.FromArgb(245, 246, 250);
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(6, 228);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(193, 55);
            btnStatistics.TabIndex = 4;
            btnStatistics.TabStop = false;
            btnStatistics.Text = "آمار";
            btnStatistics.TextAlign = ContentAlignment.MiddleRight;
            btnStatistics.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += BtnStatistics_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(245, 246, 250);
            btnDashboard.Image = Resources.Resource.context;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(6, 167);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(193, 55);
            btnDashboard.TabIndex = 3;
            btnDashboard.TabStop = false;
            btnDashboard.Text = "داشبورد";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += BtnDashboard_Click;
            // 
            // welcomePanel
            // 
            welcomePanel.BackColor = Color.FromArgb(113, 128, 147);
            welcomePanel.Controls.Add(picDigitalClock);
            welcomePanel.Location = new Point(0, 0);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(205, 118);
            welcomePanel.TabIndex = 0;
            // 
            // picDigitalClock
            // 
            picDigitalClock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picDigitalClock.Location = new Point(29, 33);
            picDigitalClock.Name = "picDigitalClock";
            picDigitalClock.Size = new Size(176, 62);
            picDigitalClock.TabIndex = 0;
            picDigitalClock.TabStop = false;
            // 
            // DashboardPanel
            // 
            DashboardPanel.Controls.Add(RolePanel);
            DashboardPanel.Controls.Add(atelierCountPanel);
            DashboardPanel.Controls.Add(ConnectionPanel);
            DashboardPanel.Controls.Add(UsernamePanel);
            DashboardPanel.Controls.Add(lbl_dashboard);
            DashboardPanel.Dock = DockStyle.Fill;
            DashboardPanel.Location = new Point(0, 0);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(1000, 541);
            DashboardPanel.TabIndex = 1;
            // 
            // RolePanel
            // 
            RolePanel.BackColor = Color.FromArgb(113, 128, 147);
            RolePanel.Controls.Add(RolePic);
            RolePanel.Controls.Add(lblRole);
            RolePanel.Controls.Add(lblRoleText);
            RolePanel.Location = new Point(427, 279);
            RolePanel.Name = "RolePanel";
            RolePanel.Size = new Size(192, 132);
            RolePanel.TabIndex = 8;
            // 
            // RolePic
            // 
            RolePic.Image = Resources.Resource.drawio;
            RolePic.Location = new Point(11, 34);
            RolePic.Name = "RolePic";
            RolePic.Size = new Size(64, 64);
            RolePic.SizeMode = PictureBoxSizeMode.StretchImage;
            RolePic.TabIndex = 4;
            RolePic.TabStop = false;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(245, 246, 250);
            lblRole.Location = new Point(35, 63);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(154, 45);
            lblRole.TabIndex = 3;
            lblRole.Text = "{role}";
            lblRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRoleText
            // 
            lblRoleText.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleText.ForeColor = Color.FromArgb(245, 246, 250);
            lblRoleText.Location = new Point(36, 24);
            lblRoleText.Name = "lblRoleText";
            lblRoleText.Size = new Size(154, 39);
            lblRoleText.TabIndex = 2;
            lblRoleText.Text = "نقش";
            lblRoleText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // atelierCountPanel
            // 
            atelierCountPanel.BackColor = Color.FromArgb(113, 128, 147);
            atelierCountPanel.Controls.Add(picAtelierCountPanel);
            atelierCountPanel.Controls.Add(lblAtelierCount);
            atelierCountPanel.Controls.Add(lblAtelierCountText);
            atelierCountPanel.Location = new Point(174, 279);
            atelierCountPanel.Name = "atelierCountPanel";
            atelierCountPanel.Size = new Size(247, 132);
            atelierCountPanel.TabIndex = 6;
            // 
            // picAtelierCountPanel
            // 
            picAtelierCountPanel.Image = Resources.Resource.palette_large;
            picAtelierCountPanel.Location = new Point(11, 34);
            picAtelierCountPanel.Name = "picAtelierCountPanel";
            picAtelierCountPanel.Size = new Size(64, 64);
            picAtelierCountPanel.SizeMode = PictureBoxSizeMode.StretchImage;
            picAtelierCountPanel.TabIndex = 4;
            picAtelierCountPanel.TabStop = false;
            // 
            // lblAtelierCount
            // 
            lblAtelierCount.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtelierCount.ForeColor = Color.FromArgb(245, 246, 250);
            lblAtelierCount.Location = new Point(85, 63);
            lblAtelierCount.Name = "lblAtelierCount";
            lblAtelierCount.Size = new Size(154, 45);
            lblAtelierCount.TabIndex = 3;
            lblAtelierCount.Text = "{count}";
            lblAtelierCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAtelierCountText
            // 
            lblAtelierCountText.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAtelierCountText.ForeColor = Color.FromArgb(245, 246, 250);
            lblAtelierCountText.Location = new Point(86, 24);
            lblAtelierCountText.Name = "lblAtelierCountText";
            lblAtelierCountText.Size = new Size(154, 39);
            lblAtelierCountText.TabIndex = 2;
            lblAtelierCountText.Text = "نوبت‌های آتلیه امروز";
            lblAtelierCountText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ConnectionPanel
            // 
            ConnectionPanel.BackColor = Color.FromArgb(113, 128, 147);
            ConnectionPanel.Controls.Add(DatePic);
            ConnectionPanel.Controls.Add(lblDate);
            ConnectionPanel.Controls.Add(lblDateText);
            ConnectionPanel.Location = new Point(174, 141);
            ConnectionPanel.Name = "ConnectionPanel";
            ConnectionPanel.Size = new Size(247, 132);
            ConnectionPanel.TabIndex = 7;
            // 
            // DatePic
            // 
            DatePic.Image = Resources.Resource.serverless;
            DatePic.Location = new Point(11, 34);
            DatePic.Name = "DatePic";
            DatePic.Size = new Size(64, 64);
            DatePic.SizeMode = PictureBoxSizeMode.StretchImage;
            DatePic.TabIndex = 4;
            DatePic.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(245, 246, 250);
            lblDate.Location = new Point(85, 63);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(154, 45);
            lblDate.TabIndex = 3;
            lblDate.Text = "{date}";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateText
            // 
            lblDateText.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateText.ForeColor = Color.FromArgb(245, 246, 250);
            lblDateText.Location = new Point(86, 24);
            lblDateText.Name = "lblDateText";
            lblDateText.Size = new Size(154, 39);
            lblDateText.TabIndex = 2;
            lblDateText.Text = "امروز";
            lblDateText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.FromArgb(113, 128, 147);
            UsernamePanel.Controls.Add(picUsernamePanel);
            UsernamePanel.Controls.Add(lblUsername);
            UsernamePanel.Controls.Add(lblWelcomeText);
            UsernamePanel.Location = new Point(427, 141);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(192, 132);
            UsernamePanel.TabIndex = 5;
            // 
            // picUsernamePanel
            // 
            picUsernamePanel.Image = (Image)resources.GetObject("picUsernamePanel.Image");
            picUsernamePanel.Location = new Point(11, 34);
            picUsernamePanel.Name = "picUsernamePanel";
            picUsernamePanel.Size = new Size(64, 64);
            picUsernamePanel.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsernamePanel.TabIndex = 4;
            picUsernamePanel.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(245, 246, 250);
            lblUsername.Location = new Point(35, 63);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(154, 45);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "{username}";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWelcomeText
            // 
            lblWelcomeText.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeText.ForeColor = Color.FromArgb(245, 246, 250);
            lblWelcomeText.Location = new Point(36, 24);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(154, 39);
            lblWelcomeText.TabIndex = 2;
            lblWelcomeText.Text = "نام کاربری";
            lblWelcomeText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_dashboard
            // 
            lbl_dashboard.AutoSize = true;
            lbl_dashboard.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_dashboard.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_dashboard.Location = new Point(332, 12);
            lbl_dashboard.Name = "lbl_dashboard";
            lbl_dashboard.Size = new Size(131, 59);
            lbl_dashboard.TabIndex = 0;
            lbl_dashboard.Text = "داشبورد";
            // 
            // StatisticsPanel
            // 
            StatisticsPanel.Controls.Add(StatsDatagrid);
            StatisticsPanel.Controls.Add(lbl_statistics);
            StatisticsPanel.Dock = DockStyle.Fill;
            StatisticsPanel.Location = new Point(0, 0);
            StatisticsPanel.Name = "StatisticsPanel";
            StatisticsPanel.Size = new Size(1000, 541);
            StatisticsPanel.TabIndex = 2;
            // 
            // StatsDatagrid
            // 
            StatsDatagrid.AllowUserToAddRows = false;
            StatsDatagrid.AllowUserToDeleteRows = false;
            StatsDatagrid.AllowUserToResizeColumns = false;
            StatsDatagrid.AllowUserToResizeRows = false;
            StatsDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StatsDatagrid.BackgroundColor = Color.FromArgb(127, 143, 166);
            StatsDatagrid.BorderStyle = BorderStyle.None;
            StatsDatagrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StatsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StatsDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StatsDatagrid.Columns.AddRange(new DataGridViewColumn[] { StatUsernameColumn, StatAtelierCount, StatPersonnelCount, StatConnectionColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            StatsDatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            StatsDatagrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            StatsDatagrid.Location = new Point(17, 76);
            StatsDatagrid.MultiSelect = false;
            StatsDatagrid.Name = "StatsDatagrid";
            StatsDatagrid.ReadOnly = true;
            StatsDatagrid.RowHeadersVisible = false;
            StatsDatagrid.RowHeadersWidth = 51;
            StatsDatagrid.ScrollBars = ScrollBars.Vertical;
            StatsDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StatsDatagrid.ShowCellErrors = false;
            StatsDatagrid.ShowCellToolTips = false;
            StatsDatagrid.ShowEditingIcon = false;
            StatsDatagrid.ShowRowErrors = false;
            StatsDatagrid.Size = new Size(767, 449);
            StatsDatagrid.TabIndex = 3;
            StatsDatagrid.TabStop = false;
            // 
            // StatUsernameColumn
            // 
            StatUsernameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatUsernameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            StatUsernameColumn.Frozen = true;
            StatUsernameColumn.HeaderText = "نام کاربری";
            StatUsernameColumn.Name = "StatUsernameColumn";
            StatUsernameColumn.ReadOnly = true;
            StatUsernameColumn.Resizable = DataGridViewTriState.False;
            StatUsernameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatUsernameColumn.Width = 190;
            // 
            // StatAtelierCount
            // 
            StatAtelierCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatAtelierCount.DefaultCellStyle = dataGridViewCellStyle3;
            StatAtelierCount.Frozen = true;
            StatAtelierCount.HeaderText = "تعداد نوبت های آتلیه";
            StatAtelierCount.Name = "StatAtelierCount";
            StatAtelierCount.ReadOnly = true;
            StatAtelierCount.Resizable = DataGridViewTriState.False;
            StatAtelierCount.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatAtelierCount.Width = 190;
            // 
            // StatPersonnelCount
            // 
            StatPersonnelCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatPersonnelCount.DefaultCellStyle = dataGridViewCellStyle4;
            StatPersonnelCount.Frozen = true;
            StatPersonnelCount.HeaderText = "تعداد نوبت های پرسنلی";
            StatPersonnelCount.Name = "StatPersonnelCount";
            StatPersonnelCount.ReadOnly = true;
            StatPersonnelCount.Resizable = DataGridViewTriState.False;
            StatPersonnelCount.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatPersonnelCount.Width = 190;
            // 
            // StatConnectionColumn
            // 
            StatConnectionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StatConnectionColumn.DefaultCellStyle = dataGridViewCellStyle5;
            StatConnectionColumn.Frozen = true;
            StatConnectionColumn.HeaderText = "وضعیت اتصال";
            StatConnectionColumn.Name = "StatConnectionColumn";
            StatConnectionColumn.ReadOnly = true;
            StatConnectionColumn.Resizable = DataGridViewTriState.False;
            StatConnectionColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            StatConnectionColumn.Width = 190;
            // 
            // lbl_statistics
            // 
            lbl_statistics.AutoSize = true;
            lbl_statistics.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_statistics.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_statistics.Location = new Point(360, 9);
            lbl_statistics.Name = "lbl_statistics";
            lbl_statistics.Size = new Size(74, 59);
            lbl_statistics.TabIndex = 0;
            lbl_statistics.Text = "آمار";
            // 
            // PersonnelPanel
            // 
            PersonnelPanel.Controls.Add(PersonnelDoneDatagridview);
            PersonnelPanel.Controls.Add(PersonnelDatagridview);
            PersonnelPanel.Controls.Add(lbl_next);
            PersonnelPanel.Controls.Add(lbl_nextText);
            PersonnelPanel.Controls.Add(lbl_personnel);
            PersonnelPanel.Controls.Add(action_panel);
            PersonnelPanel.Controls.Add(QueuePanel);
            PersonnelPanel.Dock = DockStyle.Fill;
            PersonnelPanel.Location = new Point(0, 0);
            PersonnelPanel.Name = "PersonnelPanel";
            PersonnelPanel.Size = new Size(1000, 541);
            PersonnelPanel.TabIndex = 10;
            // 
            // PersonnelDoneDatagridview
            // 
            PersonnelDoneDatagridview.AllowUserToAddRows = false;
            PersonnelDoneDatagridview.AllowUserToDeleteRows = false;
            PersonnelDoneDatagridview.AllowUserToResizeColumns = false;
            PersonnelDoneDatagridview.AllowUserToResizeRows = false;
            PersonnelDoneDatagridview.BackgroundColor = Color.FromArgb(127, 143, 166);
            PersonnelDoneDatagridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            PersonnelDoneDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            PersonnelDoneDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonnelDoneDatagridview.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            PersonnelDoneDatagridview.DefaultCellStyle = dataGridViewCellStyle8;
            PersonnelDoneDatagridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            PersonnelDoneDatagridview.Location = new Point(492, 73);
            PersonnelDoneDatagridview.MultiSelect = false;
            PersonnelDoneDatagridview.Name = "PersonnelDoneDatagridview";
            PersonnelDoneDatagridview.ReadOnly = true;
            PersonnelDoneDatagridview.RowHeadersVisible = false;
            PersonnelDoneDatagridview.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonnelDoneDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle9;
            PersonnelDoneDatagridview.ScrollBars = ScrollBars.Vertical;
            PersonnelDoneDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonnelDoneDatagridview.ShowCellErrors = false;
            PersonnelDoneDatagridview.ShowCellToolTips = false;
            PersonnelDoneDatagridview.ShowEditingIcon = false;
            PersonnelDoneDatagridview.ShowRowErrors = false;
            PersonnelDoneDatagridview.Size = new Size(189, 287);
            PersonnelDoneDatagridview.TabIndex = 12;
            PersonnelDoneDatagridview.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 100.2909F;
            dataGridViewTextBoxColumn2.HeaderText = "نوبت های انجام شده امروز";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PersonnelDatagridview
            // 
            PersonnelDatagridview.AllowUserToAddRows = false;
            PersonnelDatagridview.AllowUserToDeleteRows = false;
            PersonnelDatagridview.AllowUserToResizeColumns = false;
            PersonnelDatagridview.AllowUserToResizeRows = false;
            PersonnelDatagridview.BackgroundColor = Color.FromArgb(127, 143, 166);
            PersonnelDatagridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            PersonnelDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            PersonnelDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonnelDatagridview.Columns.AddRange(new DataGridViewColumn[] { PersonnelIdColumn, PersonnelLastNameColumn, PersonnelWaitTimeColumn });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            PersonnelDatagridview.DefaultCellStyle = dataGridViewCellStyle11;
            PersonnelDatagridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            PersonnelDatagridview.Location = new Point(113, 73);
            PersonnelDatagridview.MultiSelect = false;
            PersonnelDatagridview.Name = "PersonnelDatagridview";
            PersonnelDatagridview.ReadOnly = true;
            PersonnelDatagridview.RowHeadersVisible = false;
            PersonnelDatagridview.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonnelDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle12;
            PersonnelDatagridview.ScrollBars = ScrollBars.Vertical;
            PersonnelDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonnelDatagridview.ShowCellErrors = false;
            PersonnelDatagridview.ShowCellToolTips = false;
            PersonnelDatagridview.ShowEditingIcon = false;
            PersonnelDatagridview.ShowRowErrors = false;
            PersonnelDatagridview.Size = new Size(374, 287);
            PersonnelDatagridview.TabIndex = 13;
            PersonnelDatagridview.TabStop = false;
            // 
            // PersonnelIdColumn
            // 
            PersonnelIdColumn.FillWeight = 91.37056F;
            PersonnelIdColumn.HeaderText = "شماره نوبت";
            PersonnelIdColumn.MinimumWidth = 6;
            PersonnelIdColumn.Name = "PersonnelIdColumn";
            PersonnelIdColumn.ReadOnly = true;
            PersonnelIdColumn.Resizable = DataGridViewTriState.False;
            PersonnelIdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PersonnelLastNameColumn
            // 
            PersonnelLastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PersonnelLastNameColumn.FillWeight = 100.2909F;
            PersonnelLastNameColumn.HeaderText = "نام خانوادگی";
            PersonnelLastNameColumn.MinimumWidth = 6;
            PersonnelLastNameColumn.Name = "PersonnelLastNameColumn";
            PersonnelLastNameColumn.ReadOnly = true;
            PersonnelLastNameColumn.Resizable = DataGridViewTriState.False;
            PersonnelLastNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PersonnelWaitTimeColumn
            // 
            PersonnelWaitTimeColumn.HeaderText = "مدت زمان انتظار (دقیقه)";
            PersonnelWaitTimeColumn.Name = "PersonnelWaitTimeColumn";
            PersonnelWaitTimeColumn.ReadOnly = true;
            PersonnelWaitTimeColumn.Resizable = DataGridViewTriState.False;
            PersonnelWaitTimeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            PersonnelWaitTimeColumn.Width = 130;
            // 
            // lbl_next
            // 
            lbl_next.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_next.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_next.Location = new Point(213, 7);
            lbl_next.Name = "lbl_next";
            lbl_next.Size = new Size(188, 59);
            lbl_next.TabIndex = 1;
            lbl_next.Text = "?";
            lbl_next.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nextText
            // 
            lbl_nextText.AutoSize = true;
            lbl_nextText.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nextText.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_nextText.Location = new Point(398, 7);
            lbl_nextText.Name = "lbl_nextText";
            lbl_nextText.Size = new Size(183, 59);
            lbl_nextText.TabIndex = 1;
            lbl_nextText.Text = ":نوبت بعدی";
            // 
            // lbl_personnel
            // 
            lbl_personnel.AutoSize = true;
            lbl_personnel.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_personnel.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_personnel.Location = new Point(295, 9);
            lbl_personnel.Name = "lbl_personnel";
            lbl_personnel.Size = new Size(204, 59);
            lbl_personnel.TabIndex = 1;
            lbl_personnel.Text = "عکس پرسنلی";
            // 
            // action_panel
            // 
            action_panel.BackColor = Color.FromArgb(113, 128, 147);
            action_panel.BorderStyle = BorderStyle.FixedSingle;
            action_panel.Controls.Add(txtbox_fullname);
            action_panel.Controls.Add(btn_deletePersonnelQueue);
            action_panel.Controls.Add(btn_addQueue);
            action_panel.Controls.Add(lbl_fullname);
            action_panel.Location = new Point(113, 364);
            action_panel.Name = "action_panel";
            action_panel.Size = new Size(568, 162);
            action_panel.TabIndex = 15;
            // 
            // txtbox_fullname
            // 
            txtbox_fullname.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_fullname.Location = new Point(173, 56);
            txtbox_fullname.Name = "txtbox_fullname";
            txtbox_fullname.RightToLeft = RightToLeft.Yes;
            txtbox_fullname.Size = new Size(221, 37);
            txtbox_fullname.TabIndex = 0;
            txtbox_fullname.TextAlign = HorizontalAlignment.Center;
            txtbox_fullname.KeyDown += txtbox_fullname_KeyDown;
            // 
            // btn_deletePersonnelQueue
            // 
            btn_deletePersonnelQueue.BackColor = Color.FromArgb(194, 54, 22);
            btn_deletePersonnelQueue.FlatAppearance.BorderSize = 0;
            btn_deletePersonnelQueue.FlatStyle = FlatStyle.Flat;
            btn_deletePersonnelQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deletePersonnelQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_deletePersonnelQueue.Location = new Point(303, 99);
            btn_deletePersonnelQueue.Name = "btn_deletePersonnelQueue";
            btn_deletePersonnelQueue.Size = new Size(90, 41);
            btn_deletePersonnelQueue.TabIndex = 2;
            btn_deletePersonnelQueue.Text = "حذف نوبت";
            btn_deletePersonnelQueue.UseVisualStyleBackColor = false;
            btn_deletePersonnelQueue.Click += btn_deletePersonnelQueue_Click;
            // 
            // btn_addQueue
            // 
            btn_addQueue.BackColor = Color.FromArgb(68, 189, 50);
            btn_addQueue.FlatAppearance.BorderSize = 0;
            btn_addQueue.FlatStyle = FlatStyle.Flat;
            btn_addQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_addQueue.Location = new Point(173, 99);
            btn_addQueue.Name = "btn_addQueue";
            btn_addQueue.Size = new Size(124, 41);
            btn_addQueue.TabIndex = 1;
            btn_addQueue.Text = "افزودن نوبت جدید";
            btn_addQueue.UseVisualStyleBackColor = false;
            btn_addQueue.Click += btn_addPersonnelQueue_Click;
            // 
            // lbl_fullname
            // 
            lbl_fullname.Font = new Font("Vazirmatn ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_fullname.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_fullname.Location = new Point(189, 20);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(188, 35);
            lbl_fullname.TabIndex = 1;
            lbl_fullname.Text = "نام خانوادگی";
            lbl_fullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QueuePanel
            // 
            QueuePanel.BackColor = Color.FromArgb(113, 128, 147);
            QueuePanel.BorderStyle = BorderStyle.FixedSingle;
            QueuePanel.Controls.Add(btn_nextQueue);
            QueuePanel.Controls.Add(lbl_CurrentQueue);
            QueuePanel.Controls.Add(lbl_currentQueueText);
            QueuePanel.Location = new Point(113, 364);
            QueuePanel.Name = "QueuePanel";
            QueuePanel.Size = new Size(568, 162);
            QueuePanel.TabIndex = 14;
            // 
            // btn_nextQueue
            // 
            btn_nextQueue.BackColor = Color.FromArgb(39, 60, 117);
            btn_nextQueue.Dock = DockStyle.Bottom;
            btn_nextQueue.FlatAppearance.BorderSize = 0;
            btn_nextQueue.FlatStyle = FlatStyle.Flat;
            btn_nextQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_nextQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_nextQueue.Location = new Point(0, 111);
            btn_nextQueue.Name = "btn_nextQueue";
            btn_nextQueue.Size = new Size(566, 49);
            btn_nextQueue.TabIndex = 9;
            btn_nextQueue.Text = "اتمام نوبت فعلی و اعلام نوبت بعدی";
            btn_nextQueue.UseVisualStyleBackColor = false;
            btn_nextQueue.Click += btn_nextPersonnelQueue_Click;
            // 
            // lbl_CurrentQueue
            // 
            lbl_CurrentQueue.Dock = DockStyle.Top;
            lbl_CurrentQueue.FlatStyle = FlatStyle.Flat;
            lbl_CurrentQueue.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CurrentQueue.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_CurrentQueue.Location = new Point(0, 48);
            lbl_CurrentQueue.Name = "lbl_CurrentQueue";
            lbl_CurrentQueue.Size = new Size(566, 61);
            lbl_CurrentQueue.TabIndex = 0;
            lbl_CurrentQueue.Text = "?";
            lbl_CurrentQueue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_currentQueueText
            // 
            lbl_currentQueueText.Dock = DockStyle.Top;
            lbl_currentQueueText.FlatStyle = FlatStyle.Flat;
            lbl_currentQueueText.Font = new Font("Vazirmatn ExtraBold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_currentQueueText.ForeColor = Color.FromArgb(251, 197, 49);
            lbl_currentQueueText.Location = new Point(0, 0);
            lbl_currentQueueText.Name = "lbl_currentQueueText";
            lbl_currentQueueText.Size = new Size(566, 48);
            lbl_currentQueueText.TabIndex = 1;
            lbl_currentQueueText.Text = "( نوبت فعلی )";
            lbl_currentQueueText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AtelierPanel
            // 
            AtelierPanel.Controls.Add(panel3);
            AtelierPanel.Controls.Add(panel2);
            AtelierPanel.Controls.Add(panel1);
            AtelierPanel.Controls.Add(StatusPanel);
            AtelierPanel.Controls.Add(QueueStatusPanel);
            AtelierPanel.Controls.Add(DayStatusPanel);
            AtelierPanel.Controls.Add(AtelierDatagridview);
            AtelierPanel.Controls.Add(ActionPanel);
            AtelierPanel.Controls.Add(FilterPanel);
            AtelierPanel.Dock = DockStyle.Fill;
            AtelierPanel.Location = new Point(0, 0);
            AtelierPanel.Name = "AtelierPanel";
            AtelierPanel.Size = new Size(1000, 541);
            AtelierPanel.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_FilterByQueueStatus);
            panel3.Controls.Add(combobox_QueueStatus);
            panel3.Location = new Point(350, 317);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 118);
            panel3.TabIndex = 32;
            // 
            // lbl_FilterByQueueStatus
            // 
            lbl_FilterByQueueStatus.AutoSize = true;
            lbl_FilterByQueueStatus.Font = new Font("Vazirmatn ExtraBold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FilterByQueueStatus.ForeColor = Color.White;
            lbl_FilterByQueueStatus.Location = new Point(5, 27);
            lbl_FilterByQueueStatus.Name = "lbl_FilterByQueueStatus";
            lbl_FilterByQueueStatus.Size = new Size(178, 26);
            lbl_FilterByQueueStatus.TabIndex = 28;
            lbl_FilterByQueueStatus.Text = "فیلتر براساس وضعیت نوبت";
            // 
            // combobox_QueueStatus
            // 
            combobox_QueueStatus.BackColor = Color.FromArgb(245, 246, 250);
            combobox_QueueStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_QueueStatus.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_QueueStatus.FormattingEnabled = true;
            combobox_QueueStatus.Items.AddRange(new object[] { "پیشفرض (هیچکدام)", "انجام نشده", "انجام شده", "کنسل شده" });
            combobox_QueueStatus.Location = new Point(15, 61);
            combobox_QueueStatus.Name = "combobox_QueueStatus";
            combobox_QueueStatus.RightToLeft = RightToLeft.Yes;
            combobox_QueueStatus.Size = new Size(158, 30);
            combobox_QueueStatus.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_FilterByDate);
            panel2.Controls.Add(combobox_TimeFrame);
            panel2.Location = new Point(155, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 118);
            panel2.TabIndex = 31;
            // 
            // lbl_FilterByDate
            // 
            lbl_FilterByDate.AutoSize = true;
            lbl_FilterByDate.Font = new Font("Vazirmatn ExtraBold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FilterByDate.ForeColor = Color.White;
            lbl_FilterByDate.Location = new Point(18, 27);
            lbl_FilterByDate.Name = "lbl_FilterByDate";
            lbl_FilterByDate.Size = new Size(152, 26);
            lbl_FilterByDate.TabIndex = 27;
            lbl_FilterByDate.Text = "فیلتر براساس بازه زمانی";
            // 
            // combobox_TimeFrame
            // 
            combobox_TimeFrame.BackColor = Color.FromArgb(245, 246, 250);
            combobox_TimeFrame.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_TimeFrame.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_TimeFrame.FormattingEnabled = true;
            combobox_TimeFrame.Items.AddRange(new object[] { "پیشفرض (هیچکدام)", "قبل از روز نوبت", "روز نوبت", "روز نوبت رد شده" });
            combobox_TimeFrame.Location = new Point(15, 61);
            combobox_TimeFrame.Name = "combobox_TimeFrame";
            combobox_TimeFrame.RightToLeft = RightToLeft.Yes;
            combobox_TimeFrame.Size = new Size(158, 30);
            combobox_TimeFrame.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddFilter);
            panel1.Controls.Add(btnClearFilter);
            panel1.Location = new Point(14, 317);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 118);
            panel1.TabIndex = 30;
            // 
            // btnAddFilter
            // 
            btnAddFilter.BackColor = Color.FromArgb(68, 189, 50);
            btnAddFilter.FlatAppearance.BorderSize = 0;
            btnAddFilter.FlatStyle = FlatStyle.Flat;
            btnAddFilter.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFilter.ForeColor = Color.FromArgb(245, 246, 250);
            btnAddFilter.Location = new Point(16, 62);
            btnAddFilter.Name = "btnAddFilter";
            btnAddFilter.Size = new Size(103, 39);
            btnAddFilter.TabIndex = 29;
            btnAddFilter.Text = "اعمال فیلتر";
            btnAddFilter.UseVisualStyleBackColor = false;
            btnAddFilter.Click += btnAddFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(194, 54, 22);
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearFilter.ForeColor = Color.FromArgb(245, 246, 250);
            btnClearFilter.Location = new Point(16, 17);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(103, 39);
            btnClearFilter.TabIndex = 24;
            btnClearFilter.Text = "حذف فیلتر";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // StatusPanel
            // 
            StatusPanel.BorderStyle = BorderStyle.FixedSingle;
            StatusPanel.Controls.Add(lbl_Status);
            StatusPanel.Controls.Add(btn_CancelAtelierQueue);
            StatusPanel.Controls.Add(btn_DoneAtelierQueue);
            StatusPanel.Location = new Point(545, 441);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(236, 88);
            StatusPanel.TabIndex = 28;
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Font = new Font("Vazirmatn ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Status.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_Status.Location = new Point(51, 2);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(133, 34);
            lbl_Status.TabIndex = 23;
            lbl_Status.Text = "تکمیل وضعیت";
            // 
            // btn_CancelAtelierQueue
            // 
            btn_CancelAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
            btn_CancelAtelierQueue.FlatAppearance.BorderSize = 0;
            btn_CancelAtelierQueue.FlatStyle = FlatStyle.Flat;
            btn_CancelAtelierQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CancelAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_CancelAtelierQueue.Location = new Point(120, 40);
            btn_CancelAtelierQueue.Name = "btn_CancelAtelierQueue";
            btn_CancelAtelierQueue.Size = new Size(104, 41);
            btn_CancelAtelierQueue.TabIndex = 22;
            btn_CancelAtelierQueue.Text = "کنسل شود";
            btn_CancelAtelierQueue.UseVisualStyleBackColor = false;
            btn_CancelAtelierQueue.Click += btn_CancelAtelierQueue_Click;
            // 
            // btn_DoneAtelierQueue
            // 
            btn_DoneAtelierQueue.BackColor = Color.FromArgb(68, 189, 50);
            btn_DoneAtelierQueue.FlatAppearance.BorderSize = 0;
            btn_DoneAtelierQueue.FlatStyle = FlatStyle.Flat;
            btn_DoneAtelierQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_DoneAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_DoneAtelierQueue.Location = new Point(10, 40);
            btn_DoneAtelierQueue.Name = "btn_DoneAtelierQueue";
            btn_DoneAtelierQueue.Size = new Size(104, 41);
            btn_DoneAtelierQueue.TabIndex = 21;
            btn_DoneAtelierQueue.Text = "انجام شود";
            btn_DoneAtelierQueue.UseVisualStyleBackColor = false;
            btn_DoneAtelierQueue.Click += btn_DoneAtelierQueue_Click;
            // 
            // QueueStatusPanel
            // 
            QueueStatusPanel.BorderStyle = BorderStyle.FixedSingle;
            QueueStatusPanel.Controls.Add(lbl_Undone);
            QueueStatusPanel.Controls.Add(UndonePic);
            QueueStatusPanel.Controls.Add(lbl_Cancel);
            QueueStatusPanel.Controls.Add(CancelPic);
            QueueStatusPanel.Controls.Add(lbl_Done);
            QueueStatusPanel.Controls.Add(DonePic);
            QueueStatusPanel.Location = new Point(14, 441);
            QueueStatusPanel.Name = "QueueStatusPanel";
            QueueStatusPanel.Size = new Size(291, 41);
            QueueStatusPanel.TabIndex = 22;
            // 
            // lbl_Undone
            // 
            lbl_Undone.AutoSize = true;
            lbl_Undone.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Undone.Location = new Point(18, 9);
            lbl_Undone.Name = "lbl_Undone";
            lbl_Undone.Size = new Size(58, 19);
            lbl_Undone.TabIndex = 23;
            lbl_Undone.Text = "انجام نشده";
            lbl_Undone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UndonePic
            // 
            UndonePic.Location = new Point(78, 10);
            UndonePic.Name = "UndonePic";
            UndonePic.Size = new Size(16, 16);
            UndonePic.TabIndex = 24;
            UndonePic.TabStop = false;
            // 
            // lbl_Cancel
            // 
            lbl_Cancel.AutoSize = true;
            lbl_Cancel.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cancel.Location = new Point(109, 9);
            lbl_Cancel.Name = "lbl_Cancel";
            lbl_Cancel.Size = new Size(58, 19);
            lbl_Cancel.TabIndex = 25;
            lbl_Cancel.Text = "کنسل شده";
            lbl_Cancel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CancelPic
            // 
            CancelPic.Location = new Point(168, 10);
            CancelPic.Name = "CancelPic";
            CancelPic.Size = new Size(16, 16);
            CancelPic.TabIndex = 26;
            CancelPic.TabStop = false;
            // 
            // lbl_Done
            // 
            lbl_Done.AutoSize = true;
            lbl_Done.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Done.Location = new Point(196, 9);
            lbl_Done.Name = "lbl_Done";
            lbl_Done.Size = new Size(55, 19);
            lbl_Done.TabIndex = 27;
            lbl_Done.Text = "انجام شده";
            lbl_Done.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DonePic
            // 
            DonePic.Location = new Point(254, 10);
            DonePic.Name = "DonePic";
            DonePic.Size = new Size(16, 16);
            DonePic.TabIndex = 28;
            DonePic.TabStop = false;
            // 
            // DayStatusPanel
            // 
            DayStatusPanel.BorderStyle = BorderStyle.FixedSingle;
            DayStatusPanel.Controls.Add(lbl_Expire);
            DayStatusPanel.Controls.Add(ExpirePic);
            DayStatusPanel.Controls.Add(lbl_Today);
            DayStatusPanel.Controls.Add(TodayPic);
            DayStatusPanel.Controls.Add(lbl_Upcoming);
            DayStatusPanel.Controls.Add(UpcomingPic);
            DayStatusPanel.Location = new Point(14, 488);
            DayStatusPanel.Name = "DayStatusPanel";
            DayStatusPanel.Size = new Size(291, 41);
            DayStatusPanel.TabIndex = 22;
            // 
            // lbl_Expire
            // 
            lbl_Expire.AutoSize = true;
            lbl_Expire.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Expire.Location = new Point(5, 9);
            lbl_Expire.Name = "lbl_Expire";
            lbl_Expire.Size = new Size(81, 19);
            lbl_Expire.TabIndex = 23;
            lbl_Expire.Text = "روز نوبت رد شده";
            lbl_Expire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpirePic
            // 
            ExpirePic.Location = new Point(92, 10);
            ExpirePic.Name = "ExpirePic";
            ExpirePic.Size = new Size(16, 16);
            ExpirePic.TabIndex = 24;
            ExpirePic.TabStop = false;
            // 
            // lbl_Today
            // 
            lbl_Today.AutoSize = true;
            lbl_Today.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Today.Location = new Point(120, 9);
            lbl_Today.Name = "lbl_Today";
            lbl_Today.Size = new Size(46, 19);
            lbl_Today.TabIndex = 25;
            lbl_Today.Text = "روز نوبت";
            lbl_Today.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TodayPic
            // 
            TodayPic.Location = new Point(166, 10);
            TodayPic.Name = "TodayPic";
            TodayPic.Size = new Size(16, 16);
            TodayPic.TabIndex = 26;
            TodayPic.TabStop = false;
            // 
            // lbl_Upcoming
            // 
            lbl_Upcoming.AutoSize = true;
            lbl_Upcoming.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Upcoming.Location = new Point(192, 9);
            lbl_Upcoming.Name = "lbl_Upcoming";
            lbl_Upcoming.Size = new Size(76, 19);
            lbl_Upcoming.TabIndex = 27;
            lbl_Upcoming.Text = "قبل از روز نوبت";
            lbl_Upcoming.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpcomingPic
            // 
            UpcomingPic.Location = new Point(268, 10);
            UpcomingPic.Name = "UpcomingPic";
            UpcomingPic.Size = new Size(16, 16);
            UpcomingPic.TabIndex = 28;
            UpcomingPic.TabStop = false;
            // 
            // AtelierDatagridview
            // 
            AtelierDatagridview.AllowUserToAddRows = false;
            AtelierDatagridview.AllowUserToDeleteRows = false;
            AtelierDatagridview.AllowUserToResizeColumns = false;
            AtelierDatagridview.AllowUserToResizeRows = false;
            AtelierDatagridview.BackgroundColor = Color.FromArgb(127, 143, 166);
            AtelierDatagridview.BorderStyle = BorderStyle.Fixed3D;
            AtelierDatagridview.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            AtelierDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            AtelierDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AtelierDatagridview.Columns.AddRange(new DataGridViewColumn[] { AtelierNoteColumn, AtelierStatusDayColumn, AtelierStatusColumn, AtelierDateColumn, AtelierHourColumn, AtelierSpentColumn, AtelierPhoneNumberColumn, AtelierFullNameColumn, AtelierIDColumn });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            AtelierDatagridview.DefaultCellStyle = dataGridViewCellStyle14;
            AtelierDatagridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            AtelierDatagridview.Location = new Point(14, 9);
            AtelierDatagridview.MultiSelect = false;
            AtelierDatagridview.Name = "AtelierDatagridview";
            AtelierDatagridview.ReadOnly = true;
            AtelierDatagridview.RowHeadersVisible = false;
            AtelierDatagridview.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AtelierDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle15;
            AtelierDatagridview.ScrollBars = ScrollBars.Vertical;
            AtelierDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AtelierDatagridview.ShowCellErrors = false;
            AtelierDatagridview.ShowCellToolTips = false;
            AtelierDatagridview.ShowEditingIcon = false;
            AtelierDatagridview.ShowRowErrors = false;
            AtelierDatagridview.Size = new Size(767, 302);
            AtelierDatagridview.TabIndex = 3;
            AtelierDatagridview.TabStop = false;
            AtelierDatagridview.CellContentClick += AtelierDatagridview_CellContentClick;
            AtelierDatagridview.SelectionChanged += AtelierDatagridview_SelectionChanged;
            // 
            // ActionPanel
            // 
            ActionPanel.BorderStyle = BorderStyle.FixedSingle;
            ActionPanel.Controls.Add(lbl_Action);
            ActionPanel.Controls.Add(btn_deleteAtelierQueue);
            ActionPanel.Controls.Add(btn_addAtelierQueue);
            ActionPanel.Location = new Point(311, 441);
            ActionPanel.Name = "ActionPanel";
            ActionPanel.Size = new Size(228, 88);
            ActionPanel.TabIndex = 27;
            // 
            // lbl_Action
            // 
            lbl_Action.AutoSize = true;
            lbl_Action.Font = new Font("Vazirmatn ExtraBold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Action.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_Action.Location = new Point(73, 2);
            lbl_Action.Name = "lbl_Action";
            lbl_Action.Size = new Size(80, 34);
            lbl_Action.TabIndex = 23;
            lbl_Action.Text = "اقدامات";
            // 
            // btn_deleteAtelierQueue
            // 
            btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
            btn_deleteAtelierQueue.Enabled = false;
            btn_deleteAtelierQueue.FlatAppearance.BorderSize = 0;
            btn_deleteAtelierQueue.FlatStyle = FlatStyle.Flat;
            btn_deleteAtelierQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deleteAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_deleteAtelierQueue.Location = new Point(116, 40);
            btn_deleteAtelierQueue.Name = "btn_deleteAtelierQueue";
            btn_deleteAtelierQueue.Size = new Size(104, 41);
            btn_deleteAtelierQueue.TabIndex = 18;
            btn_deleteAtelierQueue.Text = "حذف";
            btn_deleteAtelierQueue.UseVisualStyleBackColor = false;
            btn_deleteAtelierQueue.Click += Btn_deleteAtelierQueue_Click;
            // 
            // btn_addAtelierQueue
            // 
            btn_addAtelierQueue.BackColor = Color.FromArgb(68, 189, 50);
            btn_addAtelierQueue.FlatAppearance.BorderSize = 0;
            btn_addAtelierQueue.FlatStyle = FlatStyle.Flat;
            btn_addAtelierQueue.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_addAtelierQueue.Location = new Point(6, 40);
            btn_addAtelierQueue.Name = "btn_addAtelierQueue";
            btn_addAtelierQueue.Size = new Size(104, 41);
            btn_addAtelierQueue.TabIndex = 17;
            btn_addAtelierQueue.Text = "افزودن";
            btn_addAtelierQueue.UseVisualStyleBackColor = false;
            btn_addAtelierQueue.Click += Btn_addAtelierQueue_Click;
            // 
            // FilterPanel
            // 
            FilterPanel.BorderStyle = BorderStyle.FixedSingle;
            FilterPanel.Controls.Add(lbl_FilterBySearch);
            FilterPanel.Controls.Add(combobox_SearchBy);
            FilterPanel.Controls.Add(txtbox_SearchBy);
            FilterPanel.Location = new Point(545, 317);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(236, 118);
            FilterPanel.TabIndex = 29;
            // 
            // lbl_FilterBySearch
            // 
            lbl_FilterBySearch.AutoSize = true;
            lbl_FilterBySearch.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FilterBySearch.ForeColor = Color.White;
            lbl_FilterBySearch.Location = new Point(59, 9);
            lbl_FilterBySearch.Name = "lbl_FilterBySearch";
            lbl_FilterBySearch.Size = new Size(115, 27);
            lbl_FilterBySearch.TabIndex = 26;
            lbl_FilterBySearch.Text = "جستجو براساس";
            // 
            // combobox_SearchBy
            // 
            combobox_SearchBy.BackColor = Color.FromArgb(245, 246, 250);
            combobox_SearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_SearchBy.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_SearchBy.FormattingEnabled = true;
            combobox_SearchBy.Items.AddRange(new object[] { "پیشفرض (هیچکدام)", "نام و نام خانوادگی", "شماره تماس" });
            combobox_SearchBy.Location = new Point(24, 39);
            combobox_SearchBy.Name = "combobox_SearchBy";
            combobox_SearchBy.RightToLeft = RightToLeft.Yes;
            combobox_SearchBy.Size = new Size(187, 30);
            combobox_SearchBy.TabIndex = 23;
            combobox_SearchBy.SelectedIndexChanged += combobox_SortBy_SelectedIndexChanged;
            // 
            // txtbox_SearchBy
            // 
            txtbox_SearchBy.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_SearchBy.Location = new Point(24, 75);
            txtbox_SearchBy.Name = "txtbox_SearchBy";
            txtbox_SearchBy.Size = new Size(187, 32);
            txtbox_SearchBy.TabIndex = 25;
            txtbox_SearchBy.TextAlign = HorizontalAlignment.Right;
            txtbox_SearchBy.KeyDown += txtbox_SearchBy_KeyDown;
            txtbox_SearchBy.KeyPress += txtbox_SearchBy_KeyPress;
            // 
            // SettingPanel
            // 
            SettingPanel.Controls.Add(groupbox_accManage);
            SettingPanel.Controls.Add(groupbox_ChangePass);
            SettingPanel.Controls.Add(lbl_setting);
            SettingPanel.Dock = DockStyle.Fill;
            SettingPanel.Location = new Point(0, 0);
            SettingPanel.Name = "SettingPanel";
            SettingPanel.Size = new Size(1000, 541);
            SettingPanel.TabIndex = 15;
            // 
            // groupbox_accManage
            // 
            groupbox_accManage.Controls.Add(btnLogout);
            groupbox_accManage.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_accManage.Location = new Point(400, 138);
            groupbox_accManage.Name = "groupbox_accManage";
            groupbox_accManage.RightToLeft = RightToLeft.Yes;
            groupbox_accManage.Size = new Size(269, 264);
            groupbox_accManage.TabIndex = 4;
            groupbox_accManage.TabStop = false;
            groupbox_accManage.Text = "مدیریت حساب";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(39, 60, 117);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(245, 246, 250);
            btnLogout.Location = new Point(62, 113);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(144, 39);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "خروج از حساب کاربری";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // groupbox_ChangePass
            // 
            groupbox_ChangePass.Controls.Add(btnResetPass);
            groupbox_ChangePass.Controls.Add(lbl_newPass);
            groupbox_ChangePass.Controls.Add(lbl_oldPass);
            groupbox_ChangePass.Controls.Add(txtbox_newPass);
            groupbox_ChangePass.Controls.Add(txtbox_oldPass);
            groupbox_ChangePass.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupbox_ChangePass.Location = new Point(125, 138);
            groupbox_ChangePass.Name = "groupbox_ChangePass";
            groupbox_ChangePass.RightToLeft = RightToLeft.Yes;
            groupbox_ChangePass.Size = new Size(269, 264);
            groupbox_ChangePass.TabIndex = 2;
            groupbox_ChangePass.TabStop = false;
            groupbox_ChangePass.Text = "تغییر رمز عبور";
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.FromArgb(39, 60, 117);
            btnResetPass.FlatAppearance.BorderSize = 0;
            btnResetPass.FlatStyle = FlatStyle.Flat;
            btnResetPass.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetPass.ForeColor = Color.FromArgb(245, 246, 250);
            btnResetPass.Location = new Point(41, 189);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(186, 41);
            btnResetPass.TabIndex = 6;
            btnResetPass.Text = "تغییر رمز عبور";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += BtnResetPass_Click;
            // 
            // lbl_newPass
            // 
            lbl_newPass.AutoSize = true;
            lbl_newPass.Location = new Point(84, 118);
            lbl_newPass.Name = "lbl_newPass";
            lbl_newPass.Size = new Size(102, 27);
            lbl_newPass.TabIndex = 2;
            lbl_newPass.Text = "رمز عبور جدید";
            // 
            // lbl_oldPass
            // 
            lbl_oldPass.AutoSize = true;
            lbl_oldPass.Location = new Point(84, 38);
            lbl_oldPass.Name = "lbl_oldPass";
            lbl_oldPass.Size = new Size(101, 27);
            lbl_oldPass.TabIndex = 2;
            lbl_oldPass.Text = "رمز عبور فعلی";
            // 
            // txtbox_newPass
            // 
            txtbox_newPass.Location = new Point(41, 151);
            txtbox_newPass.Name = "txtbox_newPass";
            txtbox_newPass.PasswordChar = '*';
            txtbox_newPass.RightToLeft = RightToLeft.No;
            txtbox_newPass.Size = new Size(186, 32);
            txtbox_newPass.TabIndex = 1;
            txtbox_newPass.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbox_oldPass
            // 
            txtbox_oldPass.Location = new Point(41, 67);
            txtbox_oldPass.Name = "txtbox_oldPass";
            txtbox_oldPass.PasswordChar = '*';
            txtbox_oldPass.RightToLeft = RightToLeft.No;
            txtbox_oldPass.Size = new Size(186, 32);
            txtbox_oldPass.TabIndex = 1;
            txtbox_oldPass.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_setting
            // 
            lbl_setting.AutoSize = true;
            lbl_setting.Font = new Font("Vazirmatn ExtraBold", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_setting.ForeColor = Color.FromArgb(245, 246, 250);
            lbl_setting.Location = new Point(326, 9);
            lbl_setting.Name = "lbl_setting";
            lbl_setting.Size = new Size(142, 59);
            lbl_setting.TabIndex = 1;
            lbl_setting.Text = "تنظیمات";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 60000;
            timerClock.Tick += TimerClock_Tick;
            // 
            // AtelierNoteColumn
            // 
            AtelierNoteColumn.HeaderText = "یادداشت";
            AtelierNoteColumn.MinimumWidth = 6;
            AtelierNoteColumn.Name = "AtelierNoteColumn";
            AtelierNoteColumn.ReadOnly = true;
            AtelierNoteColumn.Resizable = DataGridViewTriState.False;
            AtelierNoteColumn.Width = 70;
            // 
            // AtelierStatusDayColumn
            // 
            AtelierStatusDayColumn.FillWeight = 101.7589F;
            AtelierStatusDayColumn.HeaderText = "وضعیت روز";
            AtelierStatusDayColumn.MinimumWidth = 6;
            AtelierStatusDayColumn.Name = "AtelierStatusDayColumn";
            AtelierStatusDayColumn.ReadOnly = true;
            AtelierStatusDayColumn.Resizable = DataGridViewTriState.False;
            // 
            // AtelierStatusColumn
            // 
            AtelierStatusColumn.FillWeight = 102.837F;
            AtelierStatusColumn.HeaderText = "وضعیت نوبت";
            AtelierStatusColumn.MinimumWidth = 6;
            AtelierStatusColumn.Name = "AtelierStatusColumn";
            AtelierStatusColumn.ReadOnly = true;
            AtelierStatusColumn.Resizable = DataGridViewTriState.False;
            AtelierStatusColumn.Width = 75;
            // 
            // AtelierDateColumn
            // 
            AtelierDateColumn.FillWeight = 100.2909F;
            AtelierDateColumn.HeaderText = "تاریخ";
            AtelierDateColumn.MinimumWidth = 6;
            AtelierDateColumn.Name = "AtelierDateColumn";
            AtelierDateColumn.ReadOnly = true;
            AtelierDateColumn.Resizable = DataGridViewTriState.False;
            AtelierDateColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AtelierHourColumn
            // 
            AtelierHourColumn.FillWeight = 101.7259F;
            AtelierHourColumn.HeaderText = "ساعت";
            AtelierHourColumn.MinimumWidth = 6;
            AtelierHourColumn.Name = "AtelierHourColumn";
            AtelierHourColumn.ReadOnly = true;
            AtelierHourColumn.Resizable = DataGridViewTriState.False;
            AtelierHourColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            AtelierHourColumn.Width = 70;
            // 
            // AtelierSpentColumn
            // 
            AtelierSpentColumn.HeaderText = "مدت زمان نوبت";
            AtelierSpentColumn.Name = "AtelierSpentColumn";
            AtelierSpentColumn.ReadOnly = true;
            AtelierSpentColumn.Resizable = DataGridViewTriState.False;
            AtelierSpentColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            AtelierSpentColumn.Width = 90;
            // 
            // AtelierPhoneNumberColumn
            // 
            AtelierPhoneNumberColumn.FillWeight = 101.7259F;
            AtelierPhoneNumberColumn.HeaderText = "شماره تماس";
            AtelierPhoneNumberColumn.MinimumWidth = 6;
            AtelierPhoneNumberColumn.Name = "AtelierPhoneNumberColumn";
            AtelierPhoneNumberColumn.ReadOnly = true;
            AtelierPhoneNumberColumn.Resizable = DataGridViewTriState.False;
            AtelierPhoneNumberColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AtelierFullNameColumn
            // 
            AtelierFullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AtelierFullNameColumn.FillWeight = 100.2909F;
            AtelierFullNameColumn.HeaderText = "نام و نام خانوادگی";
            AtelierFullNameColumn.MinimumWidth = 6;
            AtelierFullNameColumn.Name = "AtelierFullNameColumn";
            AtelierFullNameColumn.ReadOnly = true;
            AtelierFullNameColumn.Resizable = DataGridViewTriState.False;
            AtelierFullNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AtelierIDColumn
            // 
            AtelierIDColumn.FillWeight = 91.37056F;
            AtelierIDColumn.HeaderText = "آیدی";
            AtelierIDColumn.MinimumWidth = 6;
            AtelierIDColumn.Name = "AtelierIDColumn";
            AtelierIDColumn.ReadOnly = true;
            AtelierIDColumn.Resizable = DataGridViewTriState.False;
            AtelierIDColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            AtelierIDColumn.Width = 60;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 143, 166);
            ClientSize = new Size(1000, 541);
            Controls.Add(sidebarPanel);
            Controls.Add(AtelierPanel);
            Controls.Add(PersonnelPanel);
            Controls.Add(SettingPanel);
            Controls.Add(DashboardPanel);
            Controls.Add(StatisticsPanel);
            Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "سیستم نوبت دهی";
            Load += FrmMain_Load;
            sidebarPanel.ResumeLayout(false);
            welcomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDigitalClock).EndInit();
            DashboardPanel.ResumeLayout(false);
            DashboardPanel.PerformLayout();
            RolePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RolePic).EndInit();
            atelierCountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAtelierCountPanel).EndInit();
            ConnectionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DatePic).EndInit();
            UsernamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUsernamePanel).EndInit();
            StatisticsPanel.ResumeLayout(false);
            StatisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StatsDatagrid).EndInit();
            PersonnelPanel.ResumeLayout(false);
            PersonnelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PersonnelDoneDatagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonnelDatagridview).EndInit();
            action_panel.ResumeLayout(false);
            action_panel.PerformLayout();
            QueuePanel.ResumeLayout(false);
            AtelierPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            QueueStatusPanel.ResumeLayout(false);
            QueueStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UndonePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)CancelPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)DonePic).EndInit();
            DayStatusPanel.ResumeLayout(false);
            DayStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpirePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)TodayPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpcomingPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)AtelierDatagridview).EndInit();
            ActionPanel.ResumeLayout(false);
            ActionPanel.PerformLayout();
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            SettingPanel.ResumeLayout(false);
            SettingPanel.PerformLayout();
            groupbox_accManage.ResumeLayout(false);
            groupbox_ChangePass.ResumeLayout(false);
            groupbox_ChangePass.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnAtelier;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel DashboardPanel;
        private SafeLabel lbl_dashboard;
        private System.Windows.Forms.Panel StatisticsPanel;
        private SafeLabel lbl_statistics;
        private System.Windows.Forms.Panel PersonnelPanel;
        private SafeLabel lbl_personnel;
        private System.Windows.Forms.Panel AtelierPanel;
        private System.Windows.Forms.Panel SettingPanel;
        private SafeLabel lbl_setting;
        private System.Windows.Forms.GroupBox groupbox_ChangePass;
        private System.Windows.Forms.TextBox txtbox_oldPass;
        private SafeLabel lbl_oldPass;
        private System.Windows.Forms.TextBox txtbox_newPass;
        private SafeLabel lbl_newPass;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.PictureBox picDigitalClock;
        private System.Windows.Forms.Timer timerClock;
        private SafeLabel lblUsername;
        private SafeLabel lblWelcomeText;
        private System.Windows.Forms.Panel UsernamePanel;
        private System.Windows.Forms.PictureBox picUsernamePanel;
        private System.Windows.Forms.DataGridView AtelierDatagridview;
        private System.Windows.Forms.Button btn_addAtelierQueue;
        private System.Windows.Forms.Button btn_deleteAtelierQueue;
        private SafeLabel lblDateText;
        public System.Windows.Forms.Panel ConnectionPanel;
        public System.Windows.Forms.PictureBox DatePic;
        public SafeLabel lblDate;
        private System.Windows.Forms.Panel atelierCountPanel;
        private System.Windows.Forms.PictureBox picAtelierCountPanel;
        private SafeLabel lblAtelierCount;
        private SafeLabel lblAtelierCountText;
        private System.Windows.Forms.Panel DayStatusPanel;
        private System.Windows.Forms.PictureBox UpcomingPic;
        private SafeLabel lbl_Upcoming;
        private System.Windows.Forms.PictureBox TodayPic;
        private SafeLabel lbl_Today;
        private System.Windows.Forms.PictureBox ExpirePic;
        private SafeLabel lbl_Expire;
        private System.Windows.Forms.ComboBox combobox_QueueStatus;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ComboBox combobox_SearchBy;
        private System.Windows.Forms.ComboBox combobox_TimeFrame;
        private System.Windows.Forms.Panel QueueStatusPanel;
        private SafeLabel lbl_Undone;
        private System.Windows.Forms.PictureBox UndonePic;
        private SafeLabel lbl_Cancel;
        private System.Windows.Forms.PictureBox CancelPic;
        private SafeLabel lbl_Done;
        private System.Windows.Forms.PictureBox DonePic;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button btn_CancelAtelierQueue;
        private System.Windows.Forms.Button btn_DoneAtelierQueue;
        private SafeLabel lbl_Status;
        private SafeLabel lbl_Action;
        private System.Windows.Forms.GroupBox groupbox_accManage;
        private System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel action_panel;
        private System.Windows.Forms.Button btn_deletePersonnelQueue;
        private System.Windows.Forms.Button btn_addQueue;
        public System.Windows.Forms.Panel QueuePanel;
        private System.Windows.Forms.Button btn_nextQueue;
        private SafeLabel lbl_CurrentQueue;
        private SafeLabel lbl_currentQueueText;
        private System.Windows.Forms.DataGridView PersonnelDoneDatagridview;
        private System.Windows.Forms.DataGridView PersonnelDatagridview;
        private SafeLabel lbl_nextText;
        private SafeLabel lbl_next;
        private System.Windows.Forms.TextBox txtbox_fullname;
        private SafeLabel lbl_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Panel FilterPanel;
        private Tool.SafeLabel lbl_FilterBySearch;
        private TextBox txtbox_SearchBy;
        private Tool.SafeLabel lbl_FilterByDate;
        private Tool.SafeLabel lbl_FilterByQueueStatus;
        private Button btnAddFilter;
        private Panel RolePanel;
        private PictureBox RolePic;
        private Tool.SafeLabel lblRole;
        private Tool.SafeLabel lblRoleText;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridViewTextBoxColumn PersonnelIdColumn;
        private DataGridViewTextBoxColumn PersonnelLastNameColumn;
        private DataGridViewTextBoxColumn PersonnelWaitTimeColumn;
        private DataGridView StatsDatagrid;
        private DataGridViewTextBoxColumn StatUsernameColumn;
        private DataGridViewTextBoxColumn StatAtelierCount;
        private DataGridViewTextBoxColumn StatPersonnelCount;
        private DataGridViewTextBoxColumn StatConnectionColumn;
        private DataGridViewButtonColumn AtelierNoteColumn;
        private DataGridViewImageColumn AtelierStatusDayColumn;
        private DataGridViewImageColumn AtelierStatusColumn;
        private DataGridViewTextBoxColumn AtelierDateColumn;
        private DataGridViewTextBoxColumn AtelierHourColumn;
        private DataGridViewTextBoxColumn AtelierSpentColumn;
        private DataGridViewTextBoxColumn AtelierPhoneNumberColumn;
        private DataGridViewTextBoxColumn AtelierFullNameColumn;
        private DataGridViewTextBoxColumn AtelierIDColumn;
    }
}