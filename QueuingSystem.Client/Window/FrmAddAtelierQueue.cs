using QueuingSystem.Business.Services;
using QueuingSystem.Client.Tool;
using QueuingSystem.Shared.DTOs.Atelier;
using QueuingSystem.Shared.Handler;

namespace QueuingSystem.Client.Window
{
    public partial class FrmAddAtelierQueue : Form
    {
        private readonly FrmMain _frmMain;
        private readonly AtelierService _atelierSrv;

        public FrmAddAtelierQueue(FrmMain frmMain, AtelierService service)
        {
            InitializeComponent();

            _frmMain = frmMain;
            _atelierSrv = service;
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
            btn_add.Enabled = false;

            var newQueue = new CreateAtelierQueueDto
            {
                FullName = txtbox_fullname.Text,
                PhoneNumber = txtbox_phonenumber.Text,
                QueueCreatedAt = txtbox_date.Value.HasValue ? txtbox_date.Value.Value.AddHours(int.Parse(txtbox_startHour.Text.Substring(0, 2))) : null,
                QueueDuration = string.IsNullOrWhiteSpace(combobox_duration.Text) ? null : int.Parse(combobox_duration.Text),
                EmployeeId = AppState.EmployeeId,
                Note = note
            };

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

        private void UpdateFreeTimeDatagrid(List<TimeSpan> times)
        {
            FreeTimeDatagridView.Rows.Clear();

            times.ForEach(x =>
            {
                FreeTimeDatagridView.Rows.Add(x.ToString().Substring(0, x.ToString().Length - 3));
            });
        }

        private void combobox_duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_duration.SelectedIndex != -1 && txtbox_date.Value.HasValue)
            {
                var times = _atelierSrv.GetByDate(AppState.EmployeeId, txtbox_date.Value.Value,
                    TimeSpan.FromHours(int.Parse(combobox_duration.Text)));

                UpdateFreeTimeDatagrid(times);
            }
        }

        private void FreeTimeDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ============ [ Methods ] ============s
    }
}
