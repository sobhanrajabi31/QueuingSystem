using QueuingSystem.Business.Services;
using QueuingSystem.Client.Tool;
using QueuingSystem.Shared.DTOs.Atelier;
using QueuingSystem.Shared.Handler;

namespace QueuingSystem.Client.Window
{
    public partial class FrmAddAtelierQueue : Form
    {
        private readonly FrmMain _frmMain;

        public FrmAddAtelierQueue(FrmMain frmMain)
        {
            InitializeComponent();

            _frmMain = frmMain;
        }

        string note = string.Empty;

        // ============ [ Events ] ============

        private void FrmAddAtelierQueue_Load(object sender, EventArgs e)
        {
            lblTodayDate.Text = DateTime.Today.ConvertToFa_Date();
        }

        private void FreeTimeDatagridView_SelectionChanged(object sender, EventArgs e)
        {
            if (FreeTimeDatagridView.SelectedRows.Count > 0)
            {
                int rowIndex = 0;
                txtbox_startHour.Text = FreeTimeDatagridView.SelectedRows[rowIndex].Cells["AtelierHourColumn"].Value.ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddAtelierQueue();
        }

        private void txtbox_date_ValueChanged(object sender, EventArgs e)
        {
            if (txtbox_date.Value.HasValue)
            {
                var targetDate = txtbox_date.Value.Value;

                if (targetDate.Date >= DateTime.Today.Date)
                    combobox_duration.SelectedIndex = 0;

                else
                {
                    txtbox_date.ResetText();
                    Mbox.Error(ErrorHandler.GetMessage(ErrorCode.InvalidDateInput), Caption.Error);
                }
            }
        }

        private void btn_note_Click(object sender, EventArgs e)
        {
            var frmShowNote = new FrmShowNote
            {
                Write = true
            };

            frmShowNote.txtbox_note.Text = note;
            frmShowNote.ShowDialog();

            if (frmShowNote.txtbox_note.Text != null)
                note = frmShowNote.txtbox_note.Text;
        }

        private void txtbox_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void combobox_duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetLastestFreeTimes();
        }

        // ============ [ Methods ] ============

        private void AddAtelierQueue()
        {
            btn_add.Enabled = false;

            var newQueue = new CreateAtelierQueueDto
            {
                FullName = txtbox_fullname.Text.Trim(),
                PhoneNumber = txtbox_phonenumber.Text.Trim(),
                QueueCreatedAt = txtbox_date.Value.HasValue ? txtbox_date.Value.Value.AddHours(int.Parse(txtbox_startHour.Text.Trim().Substring(0, 2))) : null,
                QueueDuration = string.IsNullOrWhiteSpace(combobox_duration.Text.Trim()) ? null : int.Parse(combobox_duration.Text.Trim()),
                EmployeeId = AppState.EmployeeId,
                Note = note
            };

            using var _atelierSrv = new AtelierService();
            var createResult = _atelierSrv.CreateQueue(newQueue);

            if (createResult.IsSuccess)
            {
                _frmMain.hubHandler.UpdateAtelierChanges(AppState.EmployeeId);
                Mbox.Information(createResult.Message, Caption.Information);
                Close();
            }

            else
                Mbox.Error(createResult.Message, Caption.Error);

            btn_add.Enabled = true;
        }

        private void GetLastestFreeTimes()
        {
            if (combobox_duration.SelectedIndex != -1 && txtbox_date.Value.HasValue)
            {
                using var _atelierSrv = new AtelierService();
                var times = _atelierSrv.GetByDate(AppState.EmployeeId, txtbox_date.Value.Value,
                    TimeSpan.FromHours(int.Parse(combobox_duration.Text.Trim())));

                UpdateFreeTimeDatagrid(times);
            }
        }

        private void UpdateFreeTimeDatagrid(List<TimeSpan> times)
        {
            FreeTimeDatagridView.Rows.Clear();

            times.ForEach(x =>
            {
                FreeTimeDatagridView.Rows.Add(x.ToString().Substring(0, x.ToString().Length - 3));
            });
        }
    }
}
