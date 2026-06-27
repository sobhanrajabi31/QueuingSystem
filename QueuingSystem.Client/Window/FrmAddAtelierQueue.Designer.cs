using QueuingSystem.Client.Tool;

namespace QueuingSystem.Client.Window
{
    partial class FrmAddAtelierQueue
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAtelierQueue));
            txtbox_fullname = new TextBox();
            txtbox_phonenumber = new TextBox();
            combobox_duration = new ComboBox();
            txtbox_date = new Atf.UI.DateTimeSelector();
            lbl_spenttime = new SafeLabel();
            lbl_date = new SafeLabel();
            lbl_phonenumber = new SafeLabel();
            lbl_fullname = new SafeLabel();
            lbl_time = new SafeLabel();
            txtbox_startHour = new TextBox();
            FreeTimeDatagridView = new DataGridView();
            AtelierHourColumn = new DataGridViewTextBoxColumn();
            panel_data = new Panel();
            btn_note = new Button();
            btn_add = new Button();
            btn_cancel = new Button();
            lblTodayDate = new SafeLabel();
            ((System.ComponentModel.ISupportInitialize)FreeTimeDatagridView).BeginInit();
            panel_data.SuspendLayout();
            SuspendLayout();
            // 
            // txtbox_fullname
            // 
            txtbox_fullname.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_fullname.Location = new Point(12, 51);
            txtbox_fullname.Margin = new Padding(2, 3, 2, 3);
            txtbox_fullname.Name = "txtbox_fullname";
            txtbox_fullname.Size = new Size(204, 32);
            txtbox_fullname.TabIndex = 0;
            txtbox_fullname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtbox_phonenumber
            // 
            txtbox_phonenumber.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_phonenumber.Location = new Point(12, 119);
            txtbox_phonenumber.Margin = new Padding(2, 3, 2, 3);
            txtbox_phonenumber.MaxLength = 11;
            txtbox_phonenumber.Name = "txtbox_phonenumber";
            txtbox_phonenumber.Size = new Size(204, 32);
            txtbox_phonenumber.TabIndex = 1;
            txtbox_phonenumber.TextAlign = HorizontalAlignment.Center;
            txtbox_phonenumber.KeyPress += txtbox_phonenumber_KeyPress;
            // 
            // combobox_duration
            // 
            combobox_duration.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_duration.FlatStyle = FlatStyle.Flat;
            combobox_duration.Font = new Font("Vazirmatn ExtraBold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combobox_duration.FormattingEnabled = true;
            combobox_duration.Items.AddRange(new object[] { "1", "2", "3" });
            combobox_duration.Location = new Point(12, 254);
            combobox_duration.Name = "combobox_duration";
            combobox_duration.RightToLeft = RightToLeft.Yes;
            combobox_duration.Size = new Size(204, 34);
            combobox_duration.TabIndex = 4;
            combobox_duration.SelectedIndexChanged += combobox_duration_SelectedIndexChanged;
            // 
            // txtbox_date
            // 
            txtbox_date.Location = new Point(12, 186);
            txtbox_date.Name = "txtbox_date";
            txtbox_date.Size = new Size(204, 33);
            txtbox_date.TabIndex = 2;
            txtbox_date.UsePersianFormat = true;
            txtbox_date.ValueChanged += txtbox_date_ValueChanged;
            // 
            // lbl_spenttime
            // 
            lbl_spenttime.AutoSize = true;
            lbl_spenttime.ForeColor = Color.Black;
            lbl_spenttime.Location = new Point(28, 224);
            lbl_spenttime.Name = "lbl_spenttime";
            lbl_spenttime.Size = new Size(170, 27);
            lbl_spenttime.TabIndex = 8;
            lbl_spenttime.Text = "مدت زمان نوبت (ساعت)";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.ForeColor = Color.Black;
            lbl_date.Location = new Point(92, 156);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(44, 27);
            lbl_date.TabIndex = 3;
            lbl_date.Text = "تاریخ";
            // 
            // lbl_phonenumber
            // 
            lbl_phonenumber.AutoSize = true;
            lbl_phonenumber.ForeColor = Color.Black;
            lbl_phonenumber.Location = new Point(72, 89);
            lbl_phonenumber.Name = "lbl_phonenumber";
            lbl_phonenumber.Size = new Size(85, 27);
            lbl_phonenumber.TabIndex = 3;
            lbl_phonenumber.Text = "شماره تلفن";
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.ForeColor = Color.Black;
            lbl_fullname.Location = new Point(51, 21);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(127, 27);
            lbl_fullname.TabIndex = 3;
            lbl_fullname.Text = "نام و نام خانوادگی";
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.ForeColor = Color.Black;
            lbl_time.Location = new Point(66, 294);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(94, 27);
            lbl_time.TabIndex = 8;
            lbl_time.Text = "ساعت شروع";
            // 
            // txtbox_startHour
            // 
            txtbox_startHour.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_startHour.Location = new Point(12, 323);
            txtbox_startHour.Margin = new Padding(2, 3, 2, 3);
            txtbox_startHour.MaxLength = 11;
            txtbox_startHour.Name = "txtbox_startHour";
            txtbox_startHour.ReadOnly = true;
            txtbox_startHour.Size = new Size(204, 32);
            txtbox_startHour.TabIndex = 3;
            txtbox_startHour.TextAlign = HorizontalAlignment.Center;
            // 
            // FreeTimeDatagridView
            // 
            FreeTimeDatagridView.AllowUserToAddRows = false;
            FreeTimeDatagridView.AllowUserToDeleteRows = false;
            FreeTimeDatagridView.AllowUserToResizeColumns = false;
            FreeTimeDatagridView.AllowUserToResizeRows = false;
            FreeTimeDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FreeTimeDatagridView.BackgroundColor = Color.FromArgb(127, 143, 166);
            FreeTimeDatagridView.BorderStyle = BorderStyle.Fixed3D;
            FreeTimeDatagridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            FreeTimeDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            FreeTimeDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FreeTimeDatagridView.Columns.AddRange(new DataGridViewColumn[] { AtelierHourColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            FreeTimeDatagridView.DefaultCellStyle = dataGridViewCellStyle6;
            FreeTimeDatagridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            FreeTimeDatagridView.Location = new Point(250, 86);
            FreeTimeDatagridView.MultiSelect = false;
            FreeTimeDatagridView.Name = "FreeTimeDatagridView";
            FreeTimeDatagridView.ReadOnly = true;
            FreeTimeDatagridView.RowHeadersVisible = false;
            FreeTimeDatagridView.RowHeadersWidth = 51;
            FreeTimeDatagridView.ScrollBars = ScrollBars.Vertical;
            FreeTimeDatagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FreeTimeDatagridView.ShowCellErrors = false;
            FreeTimeDatagridView.ShowCellToolTips = false;
            FreeTimeDatagridView.ShowEditingIcon = false;
            FreeTimeDatagridView.ShowRowErrors = false;
            FreeTimeDatagridView.Size = new Size(186, 472);
            FreeTimeDatagridView.TabIndex = 11;
            FreeTimeDatagridView.TabStop = false;
            FreeTimeDatagridView.CellContentClick += FreeTimeDatagridView_CellContentClick;
            FreeTimeDatagridView.SelectionChanged += FreeTimeDatagridView_SelectionChanged;
            // 
            // AtelierHourColumn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AtelierHourColumn.DefaultCellStyle = dataGridViewCellStyle5;
            AtelierHourColumn.HeaderText = "ساعت های آزاد";
            AtelierHourColumn.MinimumWidth = 6;
            AtelierHourColumn.Name = "AtelierHourColumn";
            AtelierHourColumn.ReadOnly = true;
            AtelierHourColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel_data
            // 
            panel_data.BorderStyle = BorderStyle.FixedSingle;
            panel_data.Controls.Add(btn_note);
            panel_data.Controls.Add(btn_add);
            panel_data.Controls.Add(btn_cancel);
            panel_data.Controls.Add(lbl_fullname);
            panel_data.Controls.Add(txtbox_startHour);
            panel_data.Controls.Add(txtbox_fullname);
            panel_data.Controls.Add(txtbox_date);
            panel_data.Controls.Add(txtbox_phonenumber);
            panel_data.Controls.Add(lbl_time);
            panel_data.Controls.Add(lbl_phonenumber);
            panel_data.Controls.Add(lbl_spenttime);
            panel_data.Controls.Add(lbl_date);
            panel_data.Controls.Add(combobox_duration);
            panel_data.Location = new Point(16, 86);
            panel_data.Name = "panel_data";
            panel_data.Size = new Size(228, 472);
            panel_data.TabIndex = 12;
            // 
            // btn_note
            // 
            btn_note.BackColor = Color.FromArgb(39, 60, 117);
            btn_note.FlatAppearance.BorderSize = 0;
            btn_note.FlatStyle = FlatStyle.Flat;
            btn_note.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_note.ForeColor = Color.FromArgb(245, 246, 250);
            btn_note.Location = new Point(12, 361);
            btn_note.Name = "btn_note";
            btn_note.Size = new Size(204, 41);
            btn_note.TabIndex = 7;
            btn_note.Text = "افزودن یادداشت";
            btn_note.UseVisualStyleBackColor = false;
            btn_note.Click += btn_note_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(68, 189, 50);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.FromArgb(245, 246, 250);
            btn_add.Location = new Point(12, 408);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 41);
            btn_add.TabIndex = 7;
            btn_add.Text = "ثبت";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(232, 65, 24);
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Vazirmatn ExtraBold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.ForeColor = Color.FromArgb(245, 246, 250);
            btn_cancel.Location = new Point(116, 408);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(100, 41);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "لغو";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lblTodayDate
            // 
            lblTodayDate.BorderStyle = BorderStyle.FixedSingle;
            lblTodayDate.Font = new Font("Vazirmatn ExtraBold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayDate.ForeColor = Color.White;
            lblTodayDate.Location = new Point(16, 22);
            lblTodayDate.Name = "lblTodayDate";
            lblTodayDate.Size = new Size(420, 57);
            lblTodayDate.TabIndex = 0;
            lblTodayDate.Text = "{today}";
            lblTodayDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAddAtelierQueue
            // 
            AcceptButton = btn_add;
            AutoScaleDimensions = new SizeF(9F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 143, 166);
            CancelButton = btn_cancel;
            ClientSize = new Size(453, 575);
            Controls.Add(lblTodayDate);
            Controls.Add(panel_data);
            Controls.Add(FreeTimeDatagridView);
            Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAddAtelierQueue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "افزودن نوبت آتلیه";
            Load += FrmAddAtelierQueue_Load;
            ((System.ComponentModel.ISupportInitialize)FreeTimeDatagridView).EndInit();
            panel_data.ResumeLayout(false);
            panel_data.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_fullname;
        private SafeLabel lbl_fullname;
        private System.Windows.Forms.TextBox txtbox_phonenumber;
        private SafeLabel lbl_phonenumber;
        private System.Windows.Forms.ComboBox combobox_duration;
        private SafeLabel lbl_spenttime;
        private Atf.UI.DateTimeSelector txtbox_date;
        private SafeLabel lbl_date;
        private SafeLabel lbl_time;
        private System.Windows.Forms.TextBox txtbox_startHour;
        private System.Windows.Forms.DataGridView FreeTimeDatagridView;
        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_note;
        private DataGridViewTextBoxColumn AtelierHourColumn;
        private SafeLabel lblTodayDate;
    }
}