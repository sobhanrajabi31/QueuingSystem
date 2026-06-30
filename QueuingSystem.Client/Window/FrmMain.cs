using QueuingSystem.Business.Services;
using QueuingSystem.Client.SignalR;
using QueuingSystem.Client.SignalR.Events;
using QueuingSystem.Client.Tool;
using QueuingSystem.Shared.DTOs.Atelier;
using QueuingSystem.Shared.DTOs.Employee;
using QueuingSystem.Shared.DTOs.Personnel;
using QueuingSystem.Shared.Entities;
using QueuingSystem.Shared.Handler;
using System.Media;
using System.Reflection;
using Resource = QueuingSystem.Client.Resources.Resource;

namespace QueuingSystem.Client.Window
{
    public enum RefreshType
    {
        Atelier,
        Employee,
        Personnel
    };

    public enum ButtonType
    {
        Delete,
        Done,
        Cancel
    }

    public partial class FrmMain : Form
    {
        private readonly Dictionary<int, string> _noteManager;
        private SoundPlayer _player;
        private List<int> _onlineUsers;

        public readonly HubHandler hubHandler;

        private bool firstTimeEmployeeLoad = true;

        public FrmMain()
        {
            InitializeComponent();

            _noteManager = [];
            _onlineUsers = [];

            hubHandler = new HubHandler();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!AppState.IsAuthenticated)
            {
                var frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }

            hubHandler.ExceptionHandler += Hub_Exception;

            hubHandler.OnlineUsersChanged += Hub_OnlineUsersChanged;
            hubHandler.AteliersChanged += Hub_AteliersChanged;
            hubHandler.PersonnelsChanged += Hub_PersonnelsChanged;
            hubHandler.EmployeesChanged += Hub_EmployeesChanged;

            hubHandler.StartAsync();
            hubHandler.ConnectAsync(AppState.EmployeeId);

            LoadAlertSound();
            LoadDisplayImages();
            DigitalClock();

            ShowPanel(DashboardPanel);
            SwitchButton(btnDashboard);

            lblUsername.Text = AppState.Username;
            lblRole.Text = AppState.Role ? "عکاس" : "منشی";

            RefreshDataGrid(RefreshType.Atelier);
            //RefreshDataGrid(RefreshType.Employee); علت ذکر شود
            RefreshDataGrid(RefreshType.Personnel);

            LoadDefaultFilters();
            //ShowTodayQueuesCount(); علت ذکر شود

            AtelierButtonDesign();
        }

        private void LoadDisplayImages()
        {
            UpcomingPic.Image = Img.ConvertToBmp(Resource.Yellow);
            TodayPic.Image = Img.ConvertToBmp(Resource.Green);
            ExpirePic.Image = Img.ConvertToBmp(Resource.Red);

            DonePic.Image = Img.ConvertToBmp(Resource.check);
            CancelPic.Image = Img.ConvertToBmp(Resource.x);
            UndonePic.Image = Img.ConvertToBmp(Resource.clockwise);
        }

        private void LoadAlertSound()
        {
            _player = new SoundPlayer(Resource.alarm);
            _player.Load();
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

                btn_nextQueue.Enabled = true;
            }
            else
            {
                action_panel.Visible = true;
                QueuePanel.Visible = false;

                lbl_next.Visible = true;
                lbl_nextText.Visible = true;

                lbl_personnel.Visible = false;

                btn_nextQueue.Enabled = false;
            }
        }

        private void BtnAtelier_Click(object sender, EventArgs e)
        {
            SwitchButton(btnAtelier);
            ShowPanel(AtelierPanel);
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

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void UsersDatagrid_SelectionChanged(object sender, EventArgs e)
        {
            StatsDatagrid.ClearSelection();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DigitalClock();
        }

        private void Btn_addAtelierQueue_Click(object sender, EventArgs e)
        {
            AddAtelierQueue();
        }

        private void Btn_deleteAtelierQueue_Click(object sender, EventArgs e)
        {
            DeleteAtelierQueue();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            LoadDefaultFilters();
            RefreshDataGrid(RefreshType.Atelier);
        }

        private void LoadDefaultFilters()
        {
            if (combobox_SearchBy.Items.Count > 0 &&
                combobox_TimeFrame.Items.Count > 0 &&
                combobox_QueueStatus.Items.Count > 0)
            {
                combobox_SearchBy.SelectedIndex = 0;
                combobox_TimeFrame.SelectedIndex = 0;
                combobox_QueueStatus.SelectedIndex = 0;
            }

            txtbox_SearchBy.Clear();
        }

        private void AtelierDatagridview_SelectionChanged(object sender, EventArgs e)
        {
            AtelierButtonDesign();
        }

        private void btn_DoneAtelierQueue_Click(object sender, EventArgs e)
        {
            UpdateAtelierQueue(QueueStatus.Done);
        }

        private void btn_CancelAtelierQueue_Click(object sender, EventArgs e)
        {
            UpdateAtelierQueue(QueueStatus.Canceled);
        }

        private void combobox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_SearchBy.SelectedIndex != -1)
            {
                if (combobox_SearchBy.SelectedIndex == 0)
                {
                    txtbox_SearchBy.Enabled = false;
                    txtbox_SearchBy.MaxLength = 0;
                }

                else if (combobox_SearchBy.SelectedIndex == 1)
                {
                    txtbox_SearchBy.Enabled = true;
                    txtbox_SearchBy.MaxLength = 30;
                }

                else if (combobox_SearchBy.SelectedIndex == 2)
                {
                    txtbox_SearchBy.Enabled = true;
                    txtbox_SearchBy.MaxLength = 11;
                }

                txtbox_SearchBy.Clear();
            }
        }

        private void AtelierDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRowNote(e);
        }

        private void btn_addPersonnelQueue_Click(object sender, EventArgs e)
        {
            AddPersonnelQueue();
        }

        private void btn_nextPersonnelQueue_Click(object sender, EventArgs e)
        {
            UpdatePersonnelQueue();
        }

        private void txtbox_fullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddPersonnelQueue();
        }

        private void btn_deletePersonnelQueue_Click(object sender, EventArgs e)
        {
            DeletePersonnelQueue();
        }

        private void txtbox_SearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (combobox_SearchBy.SelectedIndex == 2 && char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtbox_SearchBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddFilterToAtelier();
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            AddFilterToAtelier();
        }

        private void Hub_Exception(object? sender, ConnectionExceptionHandlerEventArgs e)
        {
            if (e.Result.IsSuccess)
                Mbox.Information(e.Result.Message, Caption.Information);

            else
                Mbox.Error(e.Result.Message, Caption.Error);
        }

        private void Hub_OnlineUsersChanged(object? sender, OnlineUsersChangedEventArgs e)
        {
            Invoke(() =>
            {
                _onlineUsers = e.OnlineUsers;
                UpdateOnlineUsers(e.OnlineUsers);

                if (firstTimeEmployeeLoad)
                {
                    RefreshDataGrid(RefreshType.Employee);
                    firstTimeEmployeeLoad = false;
                }
            });
        }

        private void Hub_AteliersChanged(object? sender, EventArgs e)
        {
            Invoke(() =>
             {
                 RefreshDataGrid(RefreshType.Atelier);
             });
        }

        private async void Hub_PersonnelsChanged(object? sender, PersonnelsChangedEventArgs e)
        {
            Invoke(() =>
            {
                using (var _personnelSrv = new PersonnelService())
                {
                    var personnels = _personnelSrv.GetByDate(DateTime.Today);
                    RefreshPersonnelQueue(personnels, e.ExecutedBy);
                }
            });
        }

        private async void Hub_EmployeesChanged(object? sender, EventArgs e)
        {
            Invoke(() =>
            {
                RefreshDataGrid(RefreshType.Employee);
            });
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReadyForClosing();
        }

        // ============ [ Methods ] ============

        private void SwitchButton(Button target)
        {
            btnDashboard.Enabled = true;
            btnStatistics.Enabled = true;
            btnPersonnel.Enabled = true;
            btnAtelier.Enabled = true;
            btnSetting.Enabled = true;

            target.Enabled = false;
        }

        private void ShowPanel(Panel target)
        {
            DashboardPanel.Visible = false;
            StatisticsPanel.Visible = false;
            PersonnelPanel.Visible = false;
            AtelierPanel.Visible = false;
            SettingPanel.Visible = false;

            target.Visible = true;
        }

        public void RefreshDataGrid(RefreshType type)
        {
            switch (type)
            {
                case RefreshType.Atelier:
                    using (var _atelierSrv = new AtelierService())
                    {
                        var ateliers = _atelierSrv.GetByEmployeeId(AppState.EmployeeId);
                        RefreshAtelierQueues(ateliers);
                    }

                    break;

                case RefreshType.Personnel:
                    using (var _personnelSrv = new PersonnelService())
                    {
                        var personnels = _personnelSrv.GetByDate(DateTime.Today);
                        RefreshPersonnelQueue(personnels, AppState.Role);
                    }

                    break;

                case RefreshType.Employee:
                    using (var _employeeSrv = new EmployeeService())
                    {
                        var employees = _employeeSrv.GetStatistics();
                        RefreshEmployees(employees);
                    }

                    break;
            }
        }

        private void RefreshAtelierQueues(List<Atelier> ateliers)
        {
            ShowTodayQueuesCount();

            int selectedIndex = -1;
            int rowIndex = 0;

            if (AtelierDatagridview.SelectedRows.Count > 0)
                selectedIndex = int.Parse(AtelierDatagridview.SelectedRows[rowIndex].Cells["AtelierIdColumn"].Value.ToString());

            AtelierDatagridview.Rows.Clear();
            _noteManager.Clear();

            ateliers.ForEach(x =>
            {
                _noteManager.Add(x.Id, x.Note);

                Image dateImage;
                var today = DateTime.Today.Date;

                if (x.QueueCreatedAt.Date > today)
                    dateImage = Resource.Yellow;

                else if (x.QueueCreatedAt.Date == today)
                    dateImage = Resource.Green;

                else
                    dateImage = Resource.Red;

                Image statusImage;

                if (x.QueueStatus == QueueStatus.Pending)
                    statusImage = Resource.clockwise;

                else if (x.QueueStatus == QueueStatus.Done)
                    statusImage = Resource.check;

                else
                    statusImage = Resource.x;

                var id = x.Id;
                var fullName = x.FullName;
                var phoneNumber = x.PhoneNumber;
                var duration = $"{x.QueueEndAt.Hour - x.QueueCreatedAt.Hour}";
                var startAt = x.QueueCreatedAt.ToString("HH:mm");
                var date = x.QueueCreatedAt.ConvertToFa_Date();

                AtelierDatagridview.Rows.Add("مشاهده", Img.ConvertToBmp(dateImage), Img.ConvertToBmp(statusImage),
                    date, startAt, duration, phoneNumber, fullName, id);

                for (var i = 0; i < AtelierDatagridview.Rows.Count; i++)
                {
                    var targetIndex = int.Parse(AtelierDatagridview.Rows[i].Cells["AtelierIdColumn"].Value.ToString());

                    if (targetIndex == selectedIndex)
                    {
                        AtelierDatagridview.ClearSelection();
                        AtelierDatagridview.Rows[i].Selected = true;
                        AtelierDatagridview.FirstDisplayedScrollingRowIndex = i;
                    }
                }
            });
        }

        private void RefreshPersonnelQueue(List<Personnel> personnels, bool executedBy)
        {
            PersonnelDatagridview.Rows.Clear();
            PersonnelDoneDatagridview.Rows.Clear();

            personnels.ForEach(x =>
            {
                if (x.QueueStatus)
                    PersonnelDoneDatagridview.Rows.Add(x.LastName);

                else
                {
                    int waitTime = (PersonnelDatagridview.Rows.Count + 1) * 3;
                    PersonnelDatagridview.Rows.Add(x.Id, x.LastName, waitTime.ToString());
                }
            });

            if (PersonnelDatagridview.Rows.Count > 0)
            {
                int rowIndex = 0;
                string lastName = PersonnelDatagridview.Rows[rowIndex].Cells["PersonnelLastNameColumn"].Value.ToString();

                btn_nextQueue.Enabled = true;
                btn_deletePersonnelQueue.Enabled = true;

                lbl_CurrentQueue.Text = lastName;
                lbl_next.Text = lastName;
            }

            else
            {
                btn_nextQueue.Enabled = false;
                btn_deletePersonnelQueue.Enabled = false;

                lbl_CurrentQueue.Text = "اتمام نوبت ها";
                lbl_next.Text = "اتمام نوبت ها";
            }

            if (!AppState.Role && executedBy)
            {
                try
                {
                    string toastText = lbl_next.Text.Trim() == "اتمام نوبت ها" 
                        ? lbl_next.Text.Trim() : ("نوبت بعدی: " + lbl_next.Text.Trim());

                    ToastMessage.ShowToast(toastText);
                    _player.Play();
                }
                catch (Exception ex)
                {
                    Mbox.Error(ex.Message, Caption.Error);
                }
            }
        }

        private void RefreshEmployees(List<StatisticsDto> employees)
        {
            StatsDatagrid.Rows.Clear();

            employees.ForEach(x =>
            {
                Image status;

                if (_onlineUsers.Contains(x.Id))
                    status = Resource.Green;

                else
                    status = Resource.Red;

                StatsDatagrid.Rows.Add(Img.ConvertToBmp(status), x.PersonnelCount, x.AtelierCount, x.Username, x.Id);
            });
        }

        private void UpdateOnlineUsers(List<int> users)
        {
            for (int i = 0; i < StatsDatagrid.Rows.Count; i++)
            {
                int id = int.Parse(StatsDatagrid.Rows[i].Cells["StatIdColumn"].Value.ToString());

                Image status;

                if (users.Contains(id))
                    status = Resource.Green;

                else
                    status = Resource.Red;

                StatsDatagrid.Rows[i].Cells["StatConnectionColumn"].Value = Img.ConvertToBmp(status);
            }
        }

        private void ButtonHandler(Button btn, ButtonType type, bool status)
        {
            btn.Enabled = status;
            btn.ForeColor = Color.FromArgb(245, 246, 250);

            switch (type)
            {
                case ButtonType.Delete or ButtonType.Cancel:
                    btn.BackColor = status ? Color.FromArgb(194, 54, 22) : Color.FromArgb(39, 60, 117);
                    break;

                case ButtonType.Done:
                    btn.BackColor = status ? Color.FromArgb(68, 189, 50) : Color.FromArgb(39, 60, 117);
                    break;
            }
        }

        private void AtelierButtonDesign()
        {
            ButtonHandler(btn_deleteAtelierQueue, ButtonType.Delete, false);
            ButtonHandler(btn_DoneAtelierQueue, ButtonType.Done, false);
            ButtonHandler(btn_CancelAtelierQueue, ButtonType.Cancel, false);

            if (AtelierDatagridview.Rows.Count > 0)
            {
                if (AtelierDatagridview.SelectedRows.Count > 0)
                {
                    int rowIndex = 0;

                    int id = int.Parse(AtelierDatagridview.SelectedRows[rowIndex].Cells["AtelierIdColumn"].Value.ToString());

                    using var _atelierSrv = new AtelierService();
                    var queue = _atelierSrv.GetById(id);

                    if (queue != null)
                    {
                        var targetDate = queue.QueueCreatedAt;
                        var todayDate = DateTime.Today;

                        if (targetDate.Date < todayDate.Date) // BeforeDay
                        {
                            ButtonHandler(btn_deleteAtelierQueue, ButtonType.Delete,
                                queue.QueueStatus is QueueStatus.Pending);

                            ButtonHandler(btn_DoneAtelierQueue, ButtonType.Done, false);
                            ButtonHandler(btn_CancelAtelierQueue, ButtonType.Cancel, false);
                        }

                        else if (targetDate.Date == todayDate.Date) // InDay
                        {
                            bool status = (queue.QueueStatus is QueueStatus.Pending);

                            ButtonHandler(btn_deleteAtelierQueue, ButtonType.Delete, status);
                            ButtonHandler(btn_DoneAtelierQueue, ButtonType.Done, status);
                            ButtonHandler(btn_CancelAtelierQueue, ButtonType.Cancel, status);
                        }

                        else if (targetDate.Date > todayDate.Date) // AfterDay
                        {
                            bool status = queue.QueueStatus is QueueStatus.Pending;

                            ButtonHandler(btn_deleteAtelierQueue, ButtonType.Delete, status);
                            ButtonHandler(btn_CancelAtelierQueue, ButtonType.Cancel, status);

                            ButtonHandler(btn_DoneAtelierQueue, ButtonType.Done, false);
                        }
                    }
                }
            }
        }

        private void ShowTodayQueuesCount()
        {
            using var _atelierSrv = new AtelierService();
            var countResult = _atelierSrv.GetTodayQueuesCount(AppState.EmployeeId);

            if (countResult.IsSuccess)
                lblAtelierCount.Text = countResult.Data.ToString();

            else
            {
                lblAtelierCount.Text = string.Empty;
                Mbox.Error(countResult.Message, Caption.Error);
            }
        }

        private void ShowRowNote(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AtelierNoteColumn.Index && e.RowIndex != -1)
            {
                int rowIndex = 0;
                int queueId = int.Parse(AtelierDatagridview.SelectedRows[rowIndex].Cells["AtelierIdColumn"].Value.ToString());

                if (_noteManager.ContainsKey(queueId))
                {
                    var frmShowNote = new FrmShowNote();
                    frmShowNote.txtbox_note.Text = _noteManager[queueId];
                    frmShowNote.Show();
                }
            }
        }

        private void DigitalClock()
        {
            var date = DateTime.Today.ConvertToFa_Date();

            if (date != lblDate.Text.Trim())
                lblDate.Text = date;

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

            var font = new Font("Vazirmatn ExtraBold", 21);
            var brush = new SolidBrush(Color.Black);
            var point = new PointF(60, 8);

            graphic.DrawString(":", font, brush, point);

            picDigitalClock.Image = bmp;

            graphic.Dispose();
        }

        private void AddFilterToAtelier()
        {
            var timeFrameVal = combobox_TimeFrame.SelectedIndex > 0;
            var queueStatusVal = combobox_QueueStatus.SelectedIndex > 0;
            var searchByVal = combobox_SearchBy.SelectedIndex > 0;

            if (timeFrameVal || queueStatusVal || searchByVal)
            {
                var queueFilter = new AtelierQueueFilterDto
                {
                    EmployeeId = AppState.EmployeeId,
                    TimeFrame = (FilterByTimeFrame)(timeFrameVal ? combobox_TimeFrame.SelectedIndex : 0),
                    QueueStatus = (FilterByQueueStatus)(queueStatusVal ? combobox_QueueStatus.SelectedIndex : 0),
                    Search = (FilterBySearch)(searchByVal ? combobox_SearchBy.SelectedIndex : 0),
                    Data = txtbox_SearchBy.Text.Trim()
                };

                using var _atelierSrv = new AtelierService();
                var ateliers = _atelierSrv.GetByFilter(queueFilter);
                RefreshAtelierQueues(ateliers);
            }

            else
                RefreshDataGrid(RefreshType.Atelier);
        }

        private void LogoutAccount()
        {
            if (Mbox.Question(MessageHandler.GetMessage(MessageCode.LogoutQuestion), Caption.Question) == DialogResult.Yes)
            {
                if (File.Exists(AppState.TokenFileName))
                    File.Delete(AppState.TokenFileName);

                ReadyForClosing();

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
                CurrentPassword = txtbox_oldPass.Text.Trim(),
                NewPassword = txtbox_newPass.Text.Trim()
            };

            using var _employeeSrv = new EmployeeService();
            var rpResult = _employeeSrv.ResetPassword(resetPass);

            if (rpResult.IsSuccess)
            {
                Mbox.Information(rpResult.Message, Caption.Information);

                ReadyForClosing();

                var frmLogin = new FrmLogin();
                Hide();
                frmLogin.ShowDialog();
                Close();
            }

            else
                Mbox.Error(rpResult.Message, Caption.Error);
        }

        private void AddAtelierQueue()
        {
            var frmAddAtelier = new FrmAddAtelierQueue(this);
            frmAddAtelier.ShowDialog();
        }

        private void UpdateAtelierQueue(QueueStatus queueStatus)
        {
            if (AtelierDatagridview.SelectedRows.Count > 0)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueStatusToDoneQuestion), Caption.Question) == DialogResult.Yes)
                {
                    int rowIndex = 0;

                    var updateDto = new UpdateAtelierQueueDto
                    {
                        QueueId = int.Parse(AtelierDatagridview.SelectedRows[rowIndex].Cells["AtelierIdColumn"].Value.ToString()),
                        EmployeeId = AppState.EmployeeId,
                        QueueStatus = queueStatus
                    };

                    using var _atelierSrv = new AtelierService();
                    var updateResult = _atelierSrv.UpdateQueue(updateDto);

                    if (updateResult.IsSuccess)
                    {
                        hubHandler.UpdateAtelierChanges(AppState.EmployeeId);
                        AtelierButtonDesign();
                        Mbox.Information(updateResult.Message, Caption.Information);
                    }

                    else
                        Mbox.Error(updateResult.Message, Caption.Error);
                }
            }
        }

        private void DeleteAtelierQueue()
        {
            if (AtelierDatagridview.SelectedRows.Count > 0)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueDeleteQuestion), Caption.Question) == DialogResult.Yes)
                {
                    int rowIndex = 0;

                    var deleteQueueDto = new DeleteAtelierQueueDto
                    {
                        QueueId = int.Parse(AtelierDatagridview.SelectedRows[rowIndex].Cells["AtelierIdColumn"].Value.ToString()),
                        EmployeeId = AppState.EmployeeId
                    };

                    using var _atelierSrv = new AtelierService();
                    var result = _atelierSrv.DeleteQueue(deleteQueueDto);

                    if (result.IsSuccess)
                    {
                        hubHandler.UpdateAtelierChanges(AppState.EmployeeId);
                        Mbox.Information(result.Message, Caption.Information);
                    }

                    else
                        Mbox.Error(result.Message, Caption.Error);
                }
            }
        }

        private void AddPersonnelQueue()
        {
            btn_addQueue.Enabled = false;

            var createPersonnel = new CreatePersonnelQueueDto
            {
                LastName = txtbox_fullname.Text.Trim(),
                QueueCreatedAt = DateTime.Now,
                EmployeeId = AppState.EmployeeId
            };

            using var _personnelSrv = new PersonnelService();
            var createResult = _personnelSrv.CreateQueue(createPersonnel);

            if (createResult.IsSuccess)
            {
                txtbox_fullname.Clear();
                hubHandler.UpdatePersonnelChanges(AppState.Role);

                Mbox.Information(createResult.Message, Caption.Information);
            }

            else
                Mbox.Error(createResult.Message, Caption.Error);

            btn_addQueue.Enabled = true;
        }

        private void UpdatePersonnelQueue()
        {
            if (PersonnelDatagridview.Rows.Count > 0)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueStatusToDoneQuestion), Caption.Question) == DialogResult.Yes)
                {
                    btn_nextQueue.Enabled = false;

                    int rowIndex = 0;

                    var updatePersonnelQueue = new UpdatePersonnelQueueDto
                    {
                        Id = int.Parse(PersonnelDatagridview.Rows[rowIndex].Cells["PersonnelIdColumn"].Value.ToString()),
                        QueueEndedAt = DateTime.Now,
                    };

                    using var _personnelSrv = new PersonnelService();
                    var updateResult = _personnelSrv.UpdateQueue(updatePersonnelQueue);

                    if (updateResult.IsSuccess)
                    {
                        hubHandler.UpdatePersonnelChanges(AppState.Role);
                        Mbox.Information(updateResult.Message, Caption.Information);
                    }

                    else
                        Mbox.Error(updateResult.Message, Caption.Error);

                    btn_nextQueue.Enabled = true;
                }
            }
        }

        private void DeletePersonnelQueue()
        {
            int selectedRowIndex = PersonnelDatagridview.SelectedRows[0].Index;

            if (PersonnelDatagridview.Rows.Count > 0 && selectedRowIndex != -1)
            {
                if (Mbox.Question(MessageHandler.GetMessage(MessageCode.QueueDeleteQuestion), Caption.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(PersonnelDatagridview.Rows[selectedRowIndex].Cells["PersonnelIdColumn"].Value.ToString());

                    using var _personnelSrv = new PersonnelService();
                    var deleteResult = _personnelSrv.DeleteQueue(id);

                    if (deleteResult.IsSuccess)
                    {
                        hubHandler.UpdatePersonnelChanges(AppState.Role);
                        Mbox.Information(deleteResult.Message, Caption.Information);
                    }

                    else
                        Mbox.Error(deleteResult.Message, Caption.Error);
                }
            }
        }

        private void ReadyForClosing()
        {
            hubHandler.AteliersChanged -= Hub_AteliersChanged;
            hubHandler.PersonnelsChanged -= Hub_PersonnelsChanged;
            hubHandler.EmployeesChanged -= Hub_EmployeesChanged;
            hubHandler.OnlineUsersChanged -= Hub_OnlineUsersChanged;
            hubHandler.ExceptionHandler -= Hub_Exception;

            hubHandler.DisposeAsync();
        }
    }
}