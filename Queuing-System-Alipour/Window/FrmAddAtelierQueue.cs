using Queuing_System_Alipour.Tool;
using System.Globalization;
using System.Text.RegularExpressions;

namespace QueuingSystem.Forms
{
    public partial class FrmAddAtelierQueue : Form
    {
        List<DateTime> freeTimesList;
        bool preventShowFreeTimeInDgv = false;

        List<DateTime> ValidTimes = new List<DateTime>
        {
            new DateTime(1, 1, 1, 8, 0 , 0),
            new DateTime(1, 1, 1, 8, 30 , 0),
            new DateTime(1, 1, 1, 9, 0 , 0),
            new DateTime(1, 1, 1, 9, 30 , 0),
            new DateTime(1, 1, 1, 10, 0 , 0),
            new DateTime(1, 1, 1, 10, 30 , 0),
            new DateTime(1, 1, 1, 11, 0 , 0),
            new DateTime(1, 1, 1, 11, 30 , 0),
            new DateTime(1, 1, 1, 12, 0 , 0),
            new DateTime(1, 1, 1, 12, 30 , 0),
            new DateTime(1, 1, 1, 13, 0 , 0),

            new DateTime(1, 1, 1, 16, 0 , 0),
            new DateTime(1, 1, 1, 16, 30 , 0),
            new DateTime(1, 1, 1, 17, 0 , 0),
            new DateTime(1, 1, 1, 17, 30 , 0),
            new DateTime(1, 1, 1, 18, 0 , 0),
            new DateTime(1, 1, 1, 18, 30 , 0),
            new DateTime(1, 1, 1, 19, 0 , 0),
            new DateTime(1, 1, 1, 19, 30 , 0),
            new DateTime(1, 1, 1, 20, 0 , 0),
        };

        public FrmAddAtelierQueue()
        {
            InitializeComponent();
            freeTimesList = new List<DateTime>();
        }
        
        List<DateTime> LastMinute = new List<DateTime>
        {
            new DateTime(1, 1, 1, 13, 30, 0),
            new DateTime(1, 1, 1, 20, 30, 0)
        };

        string note = string.Empty;
        bool second = false;

        private void FrmAddAtelierQueue_Load(object sender, EventArgs e)
        {
            cmb_spentHour.Items.Add("01");
            cmb_spentHour.Items.Add("02");
            cmb_spentHour.Items.Add("03");

            cmb_spentMinute.Items.Add("00");
            cmb_spentMinute.Items.Add("30");

            ValidTimes.Reverse();

            Database.Refresh<AtelierModel>();

            Database.OnRefreshAtelierModel += Database_OnRefreshAtelierModel;
        }

        private void Database_OnRefreshAtelierModel()
        {
            this.Invoke(new Action(() =>
            {
                freeTimesList.Clear();
                ShowFreeTimeInDgv();
            }));
        }

        private void FreeTimeDatagridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FreeTimeDatagridView.SelectedRows.Count > 0)
                txtbox_time.Text = FreeTimeDatagridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;

            var result = await Database.InitialConnectionCheck();

            btn_add.Enabled = true;

            if (result.Item1 == null || !result.Item1.Value)
            {
                Mbox.Error(ErrorHandler.GetMessage(result.Item2), Caption.Error);
                return;
            }

            Regex regex = new Regex(@"^(\+98|0)?9\d{9}$");
            if (!regex.IsMatch(txtbox_phonenumber.Text))
            {
                Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.InvalidPhoneNumber), Caption.Warning);
                return;
            }

            var okDateLen = txtbox_date.GetText("yyyyMMdd").Length == 8;

            if (txtbox_time.Text.IsNull())
            {
                if (okDateLen)
                    Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.FreeTimeNotFound), Caption.Warning);
                else
                    Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.DateTimeIsEmpty), Caption.Warning);
                return;

            }

            if (txtbox_fullname.Text.IsNull()
                || txtbox_phonenumber.Text.IsNull()
                || !okDateLen
                || txtbox_time.Text.IsNull()
                || cmb_spentHour.Text.IsNull()
                || cmb_spentMinute.Text.IsNull())
            {
                Mbox.Warning(ErrorHandler.GetMessage(ErrorCode.InvalidInputType), Caption.Warning);
                return;
            }

            if (Database.AtelierModels.Count > 0)
                AtelierModel.UpdateIncrement(Database.AtelierModels.Max(x => x.Value.Max(y => y.Id)));
            else
                AtelierModel.UpdateIncrement(0);

            var model = new AtelierModel
            {
                Id = AtelierModel.GetNextID(),
                Author = Setting.Username,
                FullName = txtbox_fullname.Text,
                PhoneNumber = txtbox_phonenumber.Text,
                StartHour = txtbox_time.Text,
                Note = note,
                SpentTime = $"{int.Parse(cmb_spentHour.Text)}:{int.Parse(cmb_spentMinute.Text)}",
                Status = null
            };

            var splitedDate = txtbox_date.GetText("yyyy/MM/dd").Replace("-", "/").Split('/');
            var date = new DateTime(int.Parse(splitedDate[0]), int.Parse(splitedDate[1]), int.Parse(splitedDate[2]), new PersianCalendar())
                .ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

            if (Database.AtelierModels.ContainsKey(date))
                Database.AtelierModels[date].Add(model);
            else
                Database.AtelierModels.Add(date, new List<AtelierModel> { model });

            Database.OnRefreshAtelierModel -= Database_OnRefreshAtelierModel;
            var saveResult = Database.Save<AtelierModel>();
            if (saveResult != null && result.Item1.Value)
            {
                this.Close();
                Mbox.Information(MessageHandler.GetMessage(MessageCode.QueueAdded), Caption.Information);
            }
        }

        private void txtbox_date_ValueChanged(object sender, EventArgs e)
        {
            if (txtbox_date.GetText("yyyyMMdd").Replace("-", "/").Length != 8)
                return;
            if (!second)
            {
                second = true;
                return;
            }
            else
                second = false;

            // بررسی اینکه تاریخ انتخابی برای روزهای گذشته نباشد
            var dateEn = Setting.ConvertToEn_Date(txtbox_date.GetText("yyyy/MM/dd").Replace("-", "/"));
            int compare = DateTime.Compare(dateEn, DateTime.Today);
            if (compare == -1)
            {
                txtbox_date.ResetText();
                Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidDateInput), Caption.Error);
                return;
            }
            if (cmb_spentHour.SelectedIndex == -1)
                cmb_spentHour.SelectedIndex = 0;
            else
                ShowFreeTimeInDgv(true);
        }

        private void cmb_time_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_spentHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_spentHour.Text == "03")
            {
                cmb_spentMinute.Items.Clear();
                cmb_spentMinute.Items.Add("00");
                cmb_spentMinute.SelectedIndex = 0;
            }
            else if (cmb_spentMinute.Items.Count == 1)
            {
                cmb_spentMinute.Items.Clear();
                cmb_spentMinute.Items.Add("00");
                cmb_spentMinute.Items.Add("30");
                cmb_spentMinute.SelectedIndex = 0;
            }
            if (cmb_spentHour.SelectedIndex != -1 && cmb_spentMinute.SelectedIndex == -1)
                cmb_spentMinute.SelectedIndex = 0;

            preventShowFreeTimeInDgv = true;
            ShowFreeTimeInDgv();
            preventShowFreeTimeInDgv = false;
        }

        private void cmb_spentMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!preventShowFreeTimeInDgv)
                ShowFreeTimeInDgv();
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            FrmShowNote frm = new FrmShowNote
            {
                Write = true
            };

            frm.txtbox_note.Text = note;
            frm.ShowDialog();

            if (frm.txtbox_note.Text.IsNull())
                note = "یادداشتی یافت نشد";
            else
                note = frm.txtbox_note.Text;
        }

        // بروزرسانی دیتاگرید ویو
        private void ShowFreeTimeInDgv(bool isDateChanged = false)
        {
            string dateFa = txtbox_date.GetText("yyyy/MM/dd").Replace("-", "/");
            string spentHourCmb = cmb_spentHour.Text;
            string spentMinuteCmb = cmb_spentMinute.Text;

            if (dateFa.IsNull() || spentHourCmb.IsNull() || spentMinuteCmb.IsNull())
                return;
            if (freeTimesList.Count == 0 || isDateChanged)
            {
                var splitDate = dateFa.Split('/');
                var dateEn = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), new PersianCalendar());
                int compare = DateTime.Compare(dateEn, DateTime.Today);
                if (compare == -1)
                {
                    txtbox_date.ResetText();
                    Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidDateInput), Caption.Error);
                    return;
                }

                // خالی کردن لیست قدیمی
                freeTimesList.Clear();

                var dateEnStr = dateEn.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                List<AtelierModel> reverseModel;
                if (Database.AtelierModels.ContainsKey(dateEnStr))
                    reverseModel = Database.AtelierModels[dateEnStr].Reverse<AtelierModel>().ToList();
                else
                    reverseModel = new List<AtelierModel>();

                bool findTime = false;
                int skipFreeTimes = 0;

                foreach (var validTime in ValidTimes)
                {
                    if (skipFreeTimes-- > 0)
                        continue;

                    foreach (var model in reverseModel)
                    {
                        if (model.Status != null)
                            continue;
                        // زمان شروع
                        var splitStartTime = model.StartHour.Split(':');
                        int startHour = int.Parse(splitStartTime[0]);
                        int startMinute = int.Parse(splitStartTime[1]);

                        // مدت زمان کار
                        var splitSpentTime = model.SpentTime.Split(':');
                        int spentHour = int.Parse(splitSpentTime[0]);
                        int spentMinute = int.Parse(splitSpentTime[1]);

                        var startDateTIme = new DateTime(1, 1, 1, startHour, startMinute, 0);
                        var spentDateTime = startDateTIme.AddHours(spentHour).AddMinutes(spentMinute);

                        if (startDateTIme <= validTime && spentDateTime > validTime)
                        {
                            skipFreeTimes = 1;
                            findTime = true;
                            break;
                        }
                    }
                    if (!findTime)
                        freeTimesList.Add(validTime);
                    else
                        findTime = false;
                }
                freeTimesList.AddRange(LastMinute);
                freeTimesList.Sort();
            }

            FreeTimeDatagridView.Rows.Clear();
            List<DateTime> freeTimesListBasedDuration = new List<DateTime>();
            const int stepMinute = 30;
            var inSpentHour = int.Parse(cmb_spentHour.Text);
            var inSpentMinute = int.Parse(cmb_spentMinute.Text);
            foreach (var freeTime in freeTimesList)
            {
                var stepCount1 = (inSpentHour * 60 + inSpentMinute) / stepMinute;

                DateTime spentDateTime = freeTime;

                var validFreeTime = true;

                for (int i = 0; i < stepCount1 - 1 && validFreeTime; i++)
                {
                    spentDateTime = spentDateTime.AddMinutes(stepMinute);
                    if (freeTimesList.IndexOf(spentDateTime) == -1)
                        validFreeTime = false;
                }
                if (validFreeTime)
                    freeTimesListBasedDuration.Add(freeTime);
            }

            // اضافه کردن تایم آزاد به دیتاگرید ویو
            freeTimesList.Sort();
            foreach (var item in freeTimesListBasedDuration)
                FreeTimeDatagridView.Rows.Add(item.ToString("HH:mm"));
        }

        private void FrmAddAtelierQueue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.OnRefreshAtelierModel -= Database_OnRefreshAtelierModel;
        }

        private void txtbox_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
