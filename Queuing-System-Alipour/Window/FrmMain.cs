using Queuing_System_Alipour.DTOs.Atelier;
using Queuing_System_Alipour.DTOs.Employee;
using Queuing_System_Alipour.DTOs.Personnel;
using Queuing_System_Alipour.Services;
using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Handler;
using System.Globalization;
using System.Media;
using System.Reflection;
using Resource = Queuing_System_Alipour.Resources.Resource;

namespace Queuing_System_Alipour.Window
{
    public enum SortType
    {
        ComboBoxText = 0, QueueStatus, Date, Time, Duration, FullName, PhoneNumber
    }

    public enum TimeFrame
    {
        ComboBoxText = 0, BeforeQueueDay, QueueDay, ExpireQueue
    }

    public enum QueueStatus
    {
        ComboBoxText = 0, Done, Canceled, Undone
    }

    public partial class FrmMain : Form
    {
        private readonly AtelierService _atelierSrv;
        private readonly PersonnelService _personnelSrv;
        private readonly EmployeeService _employeeSrv;

        public FrmMain()
        {
            InitializeComponent();

            _atelierSrv = new AtelierService();
            _personnelSrv = new PersonnelService();
            _employeeSrv = new EmployeeService();
        }

        SoundPlayer player;

        //public static bool ConnectionStatus = true;

        //public static SortType SortTypeIndex = 0;
        //public static TimeFrame TimeFrameIndex = 0;
        //public static QueueStatus QueueStatusIndex = 0;

        //public static int test = 0;

        //int prePersonelCount = 0;
        //int prePersonelTempCount = 0;

        //private static object PersonelRefresh_Lock = new object();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!AppState.IsAuthenticated)
            {
                FrmLogin frm = new FrmLogin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }

            player = new SoundPlayer(Resource.alarm);
            player.Load();

            //PictureConnection();

            UpcomingPic.Image = Img.ConvertToBmp(Resource.Yellow);
            TodayPic.Image = Img.ConvertToBmp(Resource.Green);
            ExpirePic.Image = Img.ConvertToBmp(Resource.Red);

            DonePic.Image = Img.ConvertToBmp(Resource.check);
            CancelPic.Image = Img.ConvertToBmp(Resource.x);
            UndonePic.Image = Img.ConvertToBmp(Resource.clockwise);

            TimerClock_Tick(null, null);
            SwitchButton(btnDashboard);
            ShowPanel(DashboardPanel);

            lblUsername.Text = AppState.Username;
            //lblRole.Text = AppState.Role ? "عکاس" : "کارمند";

            AtelierDatagridview_SelectionChanged(null, null);

            //DefaultFilter();
            ShowTodayQueuesCount();
        }

        // ============ [ Events ] ============

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            SwitchButton(btnDashboard);
            ShowPanel(DashboardPanel);
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            SwitchButton(btnStatistics);
            ShowPanel(StatisticsPanel);
        }

        private void BtnPersonnel_Click(object sender, EventArgs e)
        {
            SwitchButton(btnPersonnel);
            ShowPanel(PersonnelPanel);

            if (AppState.Role)
            {
                action_panel.Visible = false;
                QueuePanel.Visible = true;

                lbl_next.Visible = false;
                lbl_nextText.Visible = false;

                lbl_personnel.Visible = true;
            }
            else
            {
                action_panel.Visible = true;
                QueuePanel.Visible = false;

                lbl_next.Visible = true;
                lbl_nextText.Visible = true;

                lbl_personnel.Visible = false;
            }
        }

        private void BtnAtelier_Click(object sender, EventArgs e)
        {
            SwitchButton(btnAtelier);
            ShowPanel(AtelierPanel);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            SwitchButton(btnUsers);
            ShowPanel(UsersPanel);

            //TODO: Load users here
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SwitchButton(btnSetting);
            ShowPanel(SettingPanel);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LogoutAccount();
        }

        private async void BtnChangePass_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void UsersDatagrid_SelectionChanged(object sender, EventArgs e)
        {
            UsersDatagrid.ClearSelection();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DigitalClock();
        }

        private void Btn_addAtelierQueue_Click(object sender, EventArgs e)
        {
            FrmAddAtelierQueue frm = new FrmAddAtelierQueue();
            frm.ShowDialog();
        }

        private async void Btn_deleteAtelierQueue_Click(object sender, EventArgs e)
        {
            DeleteAtelierQueue();
        }

        private void Database_OnRefreshPersonnelModel()
        {
            RefreshPersonnelModels();
        }

        private void Database_OnRefreshPersonnelTempModel()
        {
            RefreshPersonnelTempModels();
        }

        private void Database_OnRefreshAtelierModel()
        {
            RefreshAtelierModels();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            combobox_SortBy.SelectedIndex = 0;
            combobox_QueueStatus.SelectedIndex = 0;
            comboboxTimeFrame.SelectedIndex = 0;
        }

        private void AtelierDatagridview_SelectionChanged(object sender, EventArgs e)
        {
            AtelierButtonDesign();
        }

        private async void btn_DoneAtelierQueue_Click(object sender, EventArgs e)
        {
            SetQueueStatus(1);
        }

        private async void btn_CancelAtelierQueue_Click(object sender, EventArgs e)
        {
            SetQueueStatus(2);
        }

        private void combobox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_SortBy.SelectedIndex != -1)
            {

            }
        }

        private void comboboxTimeFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxTimeFrame.SelectedIndex != -1)
            {
            }
        }

        private void combobox_QueueStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_QueueStatus.SelectedIndex != -1)
            {
            }
        }

        private void AtelierDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowNote(e);
        }

        private void btn_addQueue_Click(object sender, EventArgs e)
        {
            AddPersonnelQueue();
        }

        private void btn_nextQueue_Click(object sender, EventArgs e)
        {
            NextPersonnelQueue();
        }

        private void btn_removeQueue_Click(object sender, EventArgs e)
        {
        }

        private void txtbox_fullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_addQueue_Click(null, null);
        }

        // ============ [ Methods ] ============

        private void RefreshPersonnelModels()
        {
            //lock (PersonelRefresh_Lock)
            //{
            //    this.Invoke(new Action(() =>
            //    {
            //        string todayDate = DateTime.Today.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
            //        int personelCount = 0;
            //        if (Database.PersonnelModels.ContainsKey(todayDate))
            //        {
            //            personelCount = Database.PersonnelModels[todayDate].Count;

            //            PersonnelDoneDatagridview.Rows.Clear();
            //            foreach (var model in Database.PersonnelModels[todayDate])
            //                PersonnelDoneDatagridview.Rows.Add(model.FullName);
            //        }

            //        if (prePersonelTempCount > Database.PersonnelTempModels.Count && prePersonelCount < personelCount && !chckbox_accStatus.Checked)
            //        {
            //            if (Database.PersonnelTempModels.Count > 0)
            //            {
            //                try
            //                {
            //                    ToastMessage.ShowToast("نوبت بعدی: " + lbl_next.Text);
            //                }
            //                catch (Exception ex)
            //                {
            //                    Mbox.Error(ex.Message, Caption.Error);
            //                }
            //                try
            //                {
            //                    player.Play();
            //                }
            //                catch (Exception ex)
            //                {
            //                    Mbox.Error(ex.Message, Caption.Error);
            //                }
            //            }
            //        }
            //        prePersonelCount = personelCount;
            //        prePersonelTempCount = Database.PersonnelTempModels.Count;
            //    }));
            //}
        }

        private void RefreshPersonnelTempModels()
        {
            //lock (PersonelRefresh_Lock)
            //{
            //    this.Invoke(new Action(() =>
            //    {
            //        string todayDate = DateTime.Today.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

            //        PersonnelDatagridview.Rows.Clear();

            //        foreach (var model in Database.PersonnelTempModels)
            //            PersonnelDatagridview.Rows.Add(model.Id, "", model.FullName, "");

            //        PersonnelTempNumeric();
            //        PersonnelTempWaitTime();

            //        if (Database.PersonnelTempModels.Count > 0)
            //        {
            //            lbl_CurrentQueue.Text = PersonnelDatagridview.Rows[0].Cells[2].Value.ToString();
            //            lbl_next.Text = lbl_CurrentQueue.Text;
            //        }
            //        else
            //            lbl_next.Text = lbl_CurrentQueue.Text = "?";
            //    }));
            //}
        }

        private void PersonnelTempNumeric()
        {
            int number = 1;
            foreach (DataGridViewRow row in PersonnelDatagridview.Rows)
                row.Cells[1].Value = number++;
        }

        private void PersonnelTempWaitTime()
        {
            int waitTime = 0;
            foreach (DataGridViewRow row in PersonnelDatagridview.Rows)
                row.Cells[3].Value = $"{waitTime += 3}";
        }

        private void RefreshAtelierModels()
        {
            //PersianCalendar calendar = new PersianCalendar();

            //int index = -1;
            //if (AtelierDatagridview.SelectedRows.Count > 0)
            //    index = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

            //AtelierDatagridview.Invoke(new Action(() => { AtelierDatagridview.Rows.Clear(); }));

            //if (!SortHandler())
            //    return;

            //if (!FilterHandler())
            //    return;

            //if (!Filter2Handler())
            //    return;

            //FilteredList.Clear();

            //foreach (var model in Database.AtelierModels)
            //{
            //    Image img = null;
            //    int compare = DateTime.Compare(DateTime.Parse(model.Key), DateTime.Today);

            //    if (compare == 0)
            //        img = Resource.Green;
            //    else if (compare == 1)
            //        img = Resource.Yellow;
            //    else if (compare == -1)
            //        img = Resource.Red;

            //    AtelierDatagridview.Invoke(new Action(() =>
            //    {
            //        foreach (var item in model.Value)
            //        {
            //            Image img2 = null;

            //            if (item.Status == null)
            //                img2 = Resource.clockwise;
            //            else if (item.Status.Value)
            //                img2 = Resource.check;
            //            else if (!item.Status.Value)
            //                img2 = Resource.x;

            //            var TodayDate = DateTime.Parse(model.Key);

            //            //string shamsiDate = string.Format("{0:0000}/{1:00}/{2:00}",
            //            //calendar.GetYear(TodayDate),
            //            //calendar.GetMonth(TodayDate),
            //            //calendar.GetDayOfMonth(TodayDate));
            //            var spentTimeSplited = item.SpentTime.Split(':');
            //            var spentTimeText = " ساعت" + "\u200E" + $" {spentTimeSplited[0]}";

            //            if (spentTimeSplited[1] != "0")
            //                spentTimeText = "نیم" + "\u200E" + spentTimeText;

            //            AtelierDatagridview.Rows.Add(Img.ConvertToBmp(img), Img.ConvertToBmp(img2), Setting.ConvertToFa_Date(DateTime.Parse(model.Key)), item.StartHour, spentTimeText, item.FullName, item.PhoneNumber, "مشاهده", item.Id);
            //        }

            //        for (int i = 0; i < AtelierDatagridview.Rows.Count; i++)
            //        {
            //            if (int.Parse(AtelierDatagridview.Rows[i].Cells[8].Value?.ToString()) == index)
            //            {
            //                AtelierDatagridview.ClearSelection();
            //                AtelierDatagridview.Rows[i].Selected = true;
            //                AtelierDatagridview.FirstDisplayedScrollingRowIndex = i;
            //            }
            //        }
            //    }));
            //}

            //this.Invoke(new Action(() =>
            //{
            //    AtelierButtonDesign();
            //    ShowTodayQueuesCount();
            //}));
        }

        //public void DefaultFilter()
        //{
        //    SortTypeIndex = SortType.ComboBoxText;
        //    combobox_SortBy.SelectedIndex = 0;

        //    combobox_QueueStatus.SelectedIndex = (int)Setting.QueueStatus;
        //    comboboxTimeFrame.SelectedIndex = (int)Setting.TimeFrame;

        //    Database.Refresh<AtelierModel>();
        //}

        private void SwitchButton(Button target)
        {
            btnDashboard.Enabled = true;
            btnStatistics.Enabled = true;
            btnPersonnel.Enabled = true;
            btnAtelier.Enabled = true;
            btnUsers.Enabled = true;
            btnSetting.Enabled = true;

            target.Enabled = false;
        }

        private void ShowPanel(Panel target)
        {
            DashboardPanel.Visible = false;
            StatisticsPanel.Visible = false;
            PersonnelPanel.Visible = false;
            AtelierPanel.Visible = false;
            UsersPanel.Visible = false;
            SettingPanel.Visible = false;

            target.Visible = true;
        }

        private void LogoutAccount()
        {
            if (Mbox.Question(MessageHandler.GetMessage(MessageCode.LogoutQuestion), Caption.Question) == DialogResult.Yes)
            {
                if (File.Exists(AppState.TokenFileName))
                    File.Delete(AppState.TokenFileName);

                var frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }
        }

        private void ResetPassword()
        {
            var resetPass = new ResetPasswordDto
            {
                Id = AppState.EmployeeId,
                CurrentPassword = txtbox_oldPass.Text,
                NewPassword = txtbox_newPass.Text
            };

            var rpResult = _employeeSrv.ResetPassword(resetPass);

            if (rpResult.IsSuccess)
            {
                Mbox.Information(rpResult.Message, Caption.Information);

                var frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }

            else
                Mbox.Error(rpResult.Message, Caption.Error);
        }

        private void DigitalClock()
        {
            var date = DateTime.Today.ConvertToFa_Date();

            if (date != lbl_date.Text)
                lbl_date.Text = date;

            int h, m;
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;

            int[] time = { h / 10, h % 10, m / 10, m % 10 };

            Bitmap bmp = new Bitmap(picDigitalClock.Width, picDigitalClock.Height);

            Graphics graphic = Graphics.FromImage(bmp);

            for (int i = 0; i < time.Length; i++)
            {
                int extra = 30 * i + i / 2 * 5;

                var resType = typeof(Resource);
                var pi = resType.GetProperty($"_{time[i]}", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                var img = (Bitmap)pi.GetValue(null, null);

                graphic.DrawImage(img, 10 + extra, 10, 22, 30);
            }

            Font font = new Font("Vazirmatn", 21);
            SolidBrush brush = new SolidBrush(Color.Black);
            PointF point = new PointF(60, 8);

            graphic.DrawString(":", font, brush, point);

            picDigitalClock.Image = bmp;

            graphic.Dispose();
        }

        //public void PictureConnection()
        //{
        //    if (ConnectionStatus)
        //    {
        //        this.Invoke(new Action(() =>
        //        {
        //            ConnectionPic.Image = Img.ConvertToBmp(Resource.Green_Large);
        //            SmallConnectionPic.Image = Img.ConvertToBmp(Resource.Green_Large);
        //            lbl_ConnectionStatus.Text = "آنلاین";
        //            lbl_ConnectionStatus.ForeColor = Color.Green;
        //        }));
        //    }
        //    else
        //    {
        //        this.Invoke(new Action(() =>
        //        {
        //            ConnectionPic.Image = Img.ConvertToBmp(Resource.Red_Large);
        //            SmallConnectionPic.Image = Img.ConvertToBmp(Resource.Red_Large);
        //            lbl_ConnectionStatus.Text = "آفلاین";
        //            lbl_ConnectionStatus.ForeColor = Color.Red;
        //        }));
        //    }
        //}

        private void AtelierButtonDesign()
        {
            if (AtelierDatagridview.Rows.Count > 0)
            {
                if (AtelierDatagridview.SelectedRows.Count > 0)
                {
                    var date = AtelierDatagridview.SelectedRows[0].Cells[2].Value.ToString().ConvertToEn_Date();
                    int id = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

                    int compare = DateTime.Compare(DateTime.Today, date);
                    var dateStr = date.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

                    // x.EmployeeId == EmployeeId
                    //if (model != null)
                    //{
                    //    // روز نوبت گدشته است
                    //    if (compare == 1)
                    //    {
                    //        if (model.Status == null || !model.Status.Value)
                    //        {
                    //            btn_deleteAtelierQueue.Enabled = true;
                    //            btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
                    //        }
                    //        else if (model.Status.Value)
                    //        {
                    //            btn_deleteAtelierQueue.Enabled = false;
                    //            btn_deleteAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //        }
                    //        btn_DoneAtelierQueue.Enabled = false;
                    //        btn_DoneAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);

                    //        btn_CancelAtelierQueue.Enabled = false;
                    //        btn_CancelAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //    }

                    //    // روز نوبت است
                    //    else if (compare == 0)
                    //    {
                    //        if (model.Status != null)
                    //        {
                    //            if (model.Status.Value)
                    //            {
                    //                btn_deleteAtelierQueue.Enabled = false;
                    //                btn_deleteAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //            }
                    //            else
                    //            {
                    //                btn_deleteAtelierQueue.Enabled = true;
                    //                btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
                    //            }
                    //            btn_DoneAtelierQueue.Enabled = false;
                    //            btn_DoneAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);

                    //            btn_CancelAtelierQueue.Enabled = false;
                    //            btn_CancelAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //        }
                    //        if (model.Status == null)
                    //        {
                    //            btn_DoneAtelierQueue.Enabled = true;
                    //            btn_DoneAtelierQueue.BackColor = Color.FromArgb(68, 189, 50);

                    //            btn_CancelAtelierQueue.Enabled = true;
                    //            btn_CancelAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);

                    //            btn_deleteAtelierQueue.Enabled = true;
                    //            btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
                    //        }
                    //    }
                    //    // روز نوبت نرسیده
                    //    else if (compare == -1)
                    //    {
                    //        if (model.Status != null)
                    //        {
                    //            if (model.Status.Value)
                    //            {
                    //                btn_deleteAtelierQueue.Enabled = false;
                    //                btn_deleteAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //            }
                    //            else
                    //            {
                    //                btn_deleteAtelierQueue.Enabled = true;
                    //                btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
                    //            }
                    //            btn_CancelAtelierQueue.Enabled = false;
                    //            btn_CancelAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //        }
                    //        else
                    //        {
                    //            btn_CancelAtelierQueue.Enabled = true;
                    //            btn_CancelAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);

                    //            btn_deleteAtelierQueue.Enabled = true;
                    //            btn_deleteAtelierQueue.BackColor = Color.FromArgb(194, 54, 22);
                    //        }
                    //        btn_DoneAtelierQueue.Enabled = false;
                    //        btn_DoneAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
                    //    }

                    //    return;
                    //}
                }
            }

            btn_deleteAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
            btn_deleteAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_deleteAtelierQueue.Enabled = false;

            btn_DoneAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
            btn_DoneAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_DoneAtelierQueue.Enabled = false;

            btn_CancelAtelierQueue.BackColor = Color.FromArgb(39, 60, 117);
            btn_CancelAtelierQueue.ForeColor = Color.FromArgb(245, 246, 250);
            btn_CancelAtelierQueue.Enabled = false;
        }

        private void DeleteAtelierQueue()
        {
            btn_deleteAtelierQueue.Enabled = false;

            if (AtelierDatagridview.SelectedRows.Count > 0)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueDeleteQuestion), Caption.Question) == DialogResult.Yes)
                {
                    var deleteQueueDto = new DeleteAtelierQueueDto
                    {
                        QueueId = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString()),
                        EmployeeId = AppState.EmployeeId
                    };

                    var result = _atelierSrv.RemoveQueue(deleteQueueDto);

                    if (result.IsSuccess)
                        Mbox.Information(result.Message, Caption.Information);

                    else
                        Mbox.Error(result.Message, Caption.Error);

                    //key.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture)
                }
            }

            btn_deleteAtelierQueue.Enabled = true;
        }

        private void ShowTodayQueuesCount()
        {
            // Count(x => x.EmployeeId == EmployeeId
            // && x.CreatedAt + x.Duration >= Today && <= Tomorrow)
        }

        private void SetQueueStatus(int queueStatus)
        {
            if (queueStatus == 1)
                btn_DoneAtelierQueue.Enabled = false;

            else
                btn_CancelAtelierQueue.Enabled = false;

            if (AtelierDatagridview.SelectedRows.Count > 0)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueStatusToDoneQuestion),
                    Caption.Question) == DialogResult.Yes)
                {
                    var updateDto = new UpdateAtelierQueueDto
                    {
                        QueueId = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString()),
                        EmployeeId = AppState.EmployeeId,
                        QueueStatus = queueStatus
                    };

                    var updateResult = _atelierSrv.UpdateQueue(updateDto);

                    if (updateResult.IsSuccess)
                        Mbox.Information(updateResult.Message, Caption.Information);

                    else
                        Mbox.Error(updateResult.Message, Caption.Error);
                }
            }

            if (queueStatus == 1)
                btn_DoneAtelierQueue.Enabled = true;

            else
                btn_CancelAtelierQueue.Enabled = true;
        }

        private bool SortHandler()
        {
            //var date = Setting.ConvertToFa_Date(DateTime.Today);
            //List<KeyValuePair<string, AtelierModel>> SortedList = new List<KeyValuePair<string, AtelierModel>>();

            //if (SortTypeIndex == SortType.ComboBoxText)
            //    return true;

            //else if (SortTypeIndex == SortType.QueueStatus)
            //{
            //    SortedList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).OrderBy(x =>
            //        x.Value.Status == null ? 0 :
            //        x.Value.Status.Value == false ? 1 : 2
            //    ).ToList();
            //}

            //else if (SortTypeIndex == SortType.Date)
            //{
            //    Database.AtelierModels = Database.AtelierModels.OrderBy(x =>
            //    {
            //        return DateTime.Parse(x.Key).Ticks;
            //    }).ToDictionary(x => x.Key, y => y.Value);
            //}

            //else if (SortTypeIndex == SortType.Time)
            //{
            //    SortedList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).OrderBy(x => x.Value.StartHour).ToList();
            //}

            //else if (SortTypeIndex == SortType.Duration)
            //{
            //    SortedList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).OrderBy(x => x.Value.SpentTime).ToList();
            //}

            //else if (SortTypeIndex == SortType.FullName)
            //{
            //    SortedList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).OrderBy(x => x.Value.FullName).ToList();
            //}

            //else if (SortTypeIndex == SortType.PhoneNumber)
            //{
            //    SortedList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).OrderBy(x => x.Value.PhoneNumber).ToList();
            //}

            //Image img, img2;
            //int index = -1;
            //if (AtelierDatagridview.SelectedRows.Count > 0)
            //    index = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

            //AtelierDatagridview.Invoke(new Action(() =>
            //{
            //    AtelierDatagridview.Rows.Clear();

            //    foreach (var item in SortedList)
            //    {
            //        int compare = DateTime.Compare(DateTime.Parse(item.Key), DateTime.Today);

            //        if (compare == 0)
            //            img = Resource.Green;
            //        else if (compare == 1)
            //            img = Resource.Yellow;
            //        else
            //            img = Resource.Red;

            //        if (item.Value.Status == null)
            //            img2 = Resource.clockwise;
            //        else if (item.Value.Status.Value)
            //            img2 = Resource.check;
            //        else
            //            img2 = Resource.x;
            //        var spentTimeSplited = item.Value.SpentTime.Split(':');
            //        var spentTimeText = $"{spentTimeSplited[0]} ساعت و {spentTimeSplited[1]} دقیقه";
            //        AtelierDatagridview.Rows.Add(
            //            Img.ConvertToBmp(img), Img.ConvertToBmp(img2), Setting.ConvertToFa_Date(DateTime.Parse(item.Key)), item.Value.StartHour, spentTimeText,
            //            item.Value.FullName, item.Value.PhoneNumber, "مشاهده", item.Value.Id);
            //    }
            //    for (int i = 0; i < AtelierDatagridview.Rows.Count; i++)
            //    {
            //        if (int.Parse(AtelierDatagridview.Rows[i].Cells[8].Value?.ToString()) == index)
            //        {
            //            AtelierDatagridview.ClearSelection();
            //            AtelierDatagridview.Rows[i].Selected = true;
            //            AtelierDatagridview.FirstDisplayedScrollingRowIndex = i;
            //        }
            //    }
            //}));

            //this.Invoke(new Action(() =>
            //{
            //    AtelierButtonDesign();
            //    ShowTodayQueuesCount();
            //}));

            //if (SortTypeIndex == SortType.Date)
            //    return true;
            //else
            //    return false;

            return false;
        }

        //List<KeyValuePair<string, AtelierModel>> FilteredList = new List<KeyValuePair<string, AtelierModel>>();

        private bool FilterHandler()
        {
            //var date = Setting.ConvertToFa_Date(DateTime.Today);

            //if (TimeFrameIndex == TimeFrame.ComboBoxText)
            //    return true;

            //if (TimeFrameIndex == TimeFrame.BeforeQueueDay)
            //{
            //    Database.AtelierModels = Database.AtelierModels
            //        .Where(x => DateTime.Compare(DateTime.Parse(x.Key), DateTime.Today) == 1)
            //        .ToDictionary(x => x.Key, y => y.Value);

            //    return true;
            //}

            //else if (TimeFrameIndex == TimeFrame.QueueDay)
            //{
            //    Database.AtelierModels = Database.AtelierModels
            //        .Where(x => DateTime.Compare(DateTime.Parse(x.Key), DateTime.Today) == 0)
            //        .ToDictionary(x => x.Key, y => y.Value);

            //    return true;
            //}

            //else if (TimeFrameIndex == TimeFrame.ExpireQueue)
            //{
            //    Database.AtelierModels = Database.AtelierModels
            //        .Where(x => DateTime.Compare(DateTime.Parse(x.Key), DateTime.Today) == -1)
            //        .ToDictionary(x => x.Key, y => y.Value);

            //    return true;
            //}

            //Image img, img2;
            //int index = -1;
            //if (AtelierDatagridview.SelectedRows.Count > 0)
            //    index = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

            //AtelierDatagridview.Invoke(new Action(() =>
            //{
            //    AtelierDatagridview.Rows.Clear();

            //    foreach (var item in FilteredList)
            //    {
            //        int compare = DateTime.Compare(DateTime.Parse(item.Key), DateTime.Today);

            //        if (compare == 0)
            //            img = Resource.Green;
            //        else if (compare == 1)
            //            img = Resource.Yellow;
            //        else
            //            img = Resource.Red;

            //        if (item.Value.Status == null)
            //            img2 = Resource.clockwise;
            //        else if (item.Value.Status.Value)
            //            img2 = Resource.check;
            //        else
            //            img2 = Resource.x;
            //        var spentTimeSplited = item.Value.SpentTime.Split(':');
            //        var spentTimeText = $"{spentTimeSplited[0]} ساعت و {spentTimeSplited[1]} دقیقه";
            //        AtelierDatagridview.Rows.Add(
            //            Img.ConvertToBmp(img), Img.ConvertToBmp(img2), Setting.ConvertToFa_Date(DateTime.Parse(item.Key)), item.Value.StartHour, spentTimeText,
            //            item.Value.FullName, item.Value.PhoneNumber, "مشاهده", item.Value.Id);
            //    }
            //    for (int i = 0; i < AtelierDatagridview.Rows.Count; i++)
            //    {
            //        if (int.Parse(AtelierDatagridview.Rows[i].Cells[8].Value?.ToString()) == index)
            //        {
            //            AtelierDatagridview.ClearSelection();
            //            AtelierDatagridview.Rows[i].Selected = true;
            //            AtelierDatagridview.FirstDisplayedScrollingRowIndex = i;
            //        }
            //    }
            //}));

            //this.Invoke(new Action(() =>
            //{
            //    AtelierButtonDesign();
            //    ShowTodayQueuesCount();
            //}));

            return false;
        }

        private bool Filter2Handler()
        {
            //if (QueueStatusIndex == QueueStatus.ComboBoxText)
            //    return true;

            //else if (QueueStatusIndex == QueueStatus.Undone)
            //{
            //    FilteredList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).Where(x => x.Value.Status == null).ToList();
            //}

            //else if (QueueStatusIndex == QueueStatus.Canceled)
            //{
            //    FilteredList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).Where(x => x.Value.Status != null && x.Value.Status.Value == false).ToList();
            //}

            //else if (QueueStatusIndex == QueueStatus.Done)
            //{
            //    FilteredList = Database.AtelierModels.SelectMany(x => x.Value.Select(y =>
            //    {
            //        return new KeyValuePair<string, AtelierModel>(x.Key, y);
            //    })).Where(x => x.Value.Status != null && x.Value.Status.Value == true).ToList();
            //}

            //Image img, img2;
            //int index = -1;
            //if (AtelierDatagridview.SelectedRows.Count > 0)
            //    index = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

            //AtelierDatagridview.Invoke(new Action(() =>
            //{
            //    AtelierDatagridview.Rows.Clear();

            //    foreach (var item in FilteredList)
            //    {
            //        int compare = DateTime.Compare(DateTime.Parse(item.Key), DateTime.Today);

            //        if (compare == 0)
            //            img = Resource.Green;
            //        else if (compare == 1)
            //            img = Resource.Yellow;
            //        else
            //            img = Resource.Red;

            //        if (item.Value.Status == null)
            //            img2 = Resource.clockwise;
            //        else if (item.Value.Status.Value)
            //            img2 = Resource.check;
            //        else
            //            img2 = Resource.x;
            //        var spentTimeSplited = item.Value.SpentTime.Split(':');
            //        var spentTimeText = $"{spentTimeSplited[0]} ساعت و {spentTimeSplited[1]} دقیقه";
            //        AtelierDatagridview.Rows.Add(
            //            Img.ConvertToBmp(img), Img.ConvertToBmp(img2), Setting.ConvertToFa_Date(DateTime.Parse(item.Key)), item.Value.StartHour, spentTimeText,
            //            item.Value.FullName, item.Value.PhoneNumber, "مشاهده", item.Value.Id);
            //    }
            //    for (int i = 0; i < AtelierDatagridview.Rows.Count; i++)
            //    {
            //        if (int.Parse(AtelierDatagridview.Rows[i].Cells[8].Value?.ToString()) == index)
            //        {
            //            AtelierDatagridview.ClearSelection();
            //            AtelierDatagridview.Rows[i].Selected = true;
            //            AtelierDatagridview.FirstDisplayedScrollingRowIndex = i;
            //        }
            //    }
            //}));

            //this.Invoke(new Action(() =>
            //{
            //    AtelierButtonDesign();
            //    ShowTodayQueuesCount();
            //}));

            return false;
        }

        private void ShowRowNote(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AtelierNoteColumn.Index && e.RowIndex != -1)
            {
                int id = int.Parse(AtelierDatagridview.SelectedRows[0].Cells[8].Value.ToString());

                // Get from dictionary;

                FrmShowNote frm = new FrmShowNote();
                frm.txtbox_note.Text = ""; //model.Note;
                frm.Show();
            }
        }

        private void AddPersonnelQueue()
        {
            btn_addQueue.Enabled = false;

            var createPersonnel = new CreatePersonnelQueueDto
            {
                LastName = txtbox_fullname.Text.Trim(),
                QueueCreatedAt = DateTime.Now
            };

            var createResult = _personnelSrv.CreateQueue(createPersonnel);

            if (createResult.IsSuccess)
            {
                txtbox_fullname.Clear();
                Mbox.Information(createResult.Message, Caption.Information);
            }

            else
                Mbox.Error(createResult.Message, Caption.Error);

            btn_addQueue.Enabled = true;
        }

        private void NextPersonnelQueue()
        {
            btn_nextQueue.Enabled = false;

            var updatePersonnelQueue = new UpdatePersonnelQueueDto
            {
                Id = int.Parse(PersonnelDatagridview.Rows[0].Cells[0].Value.ToString()),
                QueueEndedAt = DateTime.Now,
            };

            var updateResult = _personnelSrv.UpdateQueue(updatePersonnelQueue);

            if (updateResult.IsSuccess)
                Mbox.Information(updateResult.Message, Caption.Information);

            else
                Mbox.Error(updateResult.Message, Caption.Error);

            btn_nextQueue.Enabled = true;
        }
    }
}