namespace QueuingSystem.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAtelierQueue));
            this.txtbox_fullname = new System.Windows.Forms.TextBox();
            this.txtbox_phonenumber = new System.Windows.Forms.TextBox();
            this.cmb_spentHour = new System.Windows.Forms.ComboBox();
            this.txtbox_date = new Atf.UI.DateTimeSelector();
            this.lbl_spenttime = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.lbl_date = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.lbl_phonenumber = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.lbl_fullname = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.lbl_time = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.txtbox_time = new System.Windows.Forms.TextBox();
            this.FreeTimeDatagridView = new System.Windows.Forms.DataGridView();
            this.AtelierHourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_spentMinute = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.safeLabel2 = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.safeLabel1 = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.btn_note = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FreeTimeDatagridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_fullname
            // 
            this.txtbox_fullname.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_fullname.Location = new System.Drawing.Point(12, 44);
            this.txtbox_fullname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbox_fullname.Name = "txtbox_fullname";
            this.txtbox_fullname.Size = new System.Drawing.Size(204, 39);
            this.txtbox_fullname.TabIndex = 0;
            this.txtbox_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_phonenumber
            // 
            this.txtbox_phonenumber.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_phonenumber.Location = new System.Drawing.Point(12, 112);
            this.txtbox_phonenumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbox_phonenumber.MaxLength = 11;
            this.txtbox_phonenumber.Name = "txtbox_phonenumber";
            this.txtbox_phonenumber.Size = new System.Drawing.Size(204, 39);
            this.txtbox_phonenumber.TabIndex = 1;
            this.txtbox_phonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_phonenumber_KeyPress);
            // 
            // cmb_spentHour
            // 
            this.cmb_spentHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_spentHour.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spentHour.FormattingEnabled = true;
            this.cmb_spentHour.Location = new System.Drawing.Point(12, 247);
            this.cmb_spentHour.Name = "cmb_spentHour";
            this.cmb_spentHour.Size = new System.Drawing.Size(100, 38);
            this.cmb_spentHour.TabIndex = 4;
            this.cmb_spentHour.SelectedIndexChanged += new System.EventHandler(this.cmb_spentHour_SelectedIndexChanged);
            // 
            // txtbox_date
            // 
            this.txtbox_date.Location = new System.Drawing.Point(12, 179);
            this.txtbox_date.Name = "txtbox_date";
            this.txtbox_date.Size = new System.Drawing.Size(204, 40);
            this.txtbox_date.TabIndex = 2;
            this.txtbox_date.UsePersianFormat = true;
            this.txtbox_date.ValueChanged += new System.EventHandler(this.txtbox_date_ValueChanged);
            // 
            // lbl_spenttime
            // 
            this.lbl_spenttime.AutoSize = true;
            this.lbl_spenttime.ForeColor = System.Drawing.Color.Black;
            this.lbl_spenttime.Location = new System.Drawing.Point(58, 217);
            this.lbl_spenttime.Name = "lbl_spenttime";
            this.lbl_spenttime.Size = new System.Drawing.Size(141, 34);
            this.lbl_spenttime.TabIndex = 8;
            this.lbl_spenttime.Text = "مدت زمان نوبت";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_date.Location = new System.Drawing.Point(92, 149);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(57, 34);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "تاریخ";
            // 
            // lbl_phonenumber
            // 
            this.lbl_phonenumber.AutoSize = true;
            this.lbl_phonenumber.ForeColor = System.Drawing.Color.Black;
            this.lbl_phonenumber.Location = new System.Drawing.Point(72, 82);
            this.lbl_phonenumber.Name = "lbl_phonenumber";
            this.lbl_phonenumber.Size = new System.Drawing.Size(106, 34);
            this.lbl_phonenumber.TabIndex = 3;
            this.lbl_phonenumber.Text = "شماره تلفن";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.ForeColor = System.Drawing.Color.Black;
            this.lbl_fullname.Location = new System.Drawing.Point(51, 14);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(159, 34);
            this.lbl_fullname.TabIndex = 3;
            this.lbl_fullname.Text = "نام و نام خانوادگی";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.ForeColor = System.Drawing.Color.Black;
            this.lbl_time.Location = new System.Drawing.Point(88, 287);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 34);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "ساعت";
            // 
            // txtbox_time
            // 
            this.txtbox_time.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_time.Location = new System.Drawing.Point(12, 316);
            this.txtbox_time.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbox_time.MaxLength = 11;
            this.txtbox_time.Name = "txtbox_time";
            this.txtbox_time.ReadOnly = true;
            this.txtbox_time.Size = new System.Drawing.Size(204, 39);
            this.txtbox_time.TabIndex = 3;
            this.txtbox_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_time.TextChanged += new System.EventHandler(this.cmb_time_TextChanged);
            // 
            // FreeTimeDatagridView
            // 
            this.FreeTimeDatagridView.AllowUserToAddRows = false;
            this.FreeTimeDatagridView.AllowUserToDeleteRows = false;
            this.FreeTimeDatagridView.AllowUserToResizeColumns = false;
            this.FreeTimeDatagridView.AllowUserToResizeRows = false;
            this.FreeTimeDatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FreeTimeDatagridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.FreeTimeDatagridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FreeTimeDatagridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FreeTimeDatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FreeTimeDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreeTimeDatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AtelierHourColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FreeTimeDatagridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FreeTimeDatagridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.FreeTimeDatagridView.Location = new System.Drawing.Point(250, 31);
            this.FreeTimeDatagridView.MultiSelect = false;
            this.FreeTimeDatagridView.Name = "FreeTimeDatagridView";
            this.FreeTimeDatagridView.ReadOnly = true;
            this.FreeTimeDatagridView.RowHeadersVisible = false;
            this.FreeTimeDatagridView.RowHeadersWidth = 51;
            this.FreeTimeDatagridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FreeTimeDatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FreeTimeDatagridView.ShowCellErrors = false;
            this.FreeTimeDatagridView.ShowCellToolTips = false;
            this.FreeTimeDatagridView.ShowEditingIcon = false;
            this.FreeTimeDatagridView.ShowRowErrors = false;
            this.FreeTimeDatagridView.Size = new System.Drawing.Size(186, 472);
            this.FreeTimeDatagridView.TabIndex = 11;
            this.FreeTimeDatagridView.TabStop = false;
            this.FreeTimeDatagridView.SelectionChanged += new System.EventHandler(this.FreeTimeDatagridView_SelectionChanged);
            // 
            // AtelierHourColumn
            // 
            this.AtelierHourColumn.HeaderText = "ساعت های آزاد";
            this.AtelierHourColumn.MinimumWidth = 6;
            this.AtelierHourColumn.Name = "AtelierHourColumn";
            this.AtelierHourColumn.ReadOnly = true;
            this.AtelierHourColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmb_spentMinute
            // 
            this.cmb_spentMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spentMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_spentMinute.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spentMinute.FormattingEnabled = true;
            this.cmb_spentMinute.Location = new System.Drawing.Point(116, 247);
            this.cmb_spentMinute.Name = "cmb_spentMinute";
            this.cmb_spentMinute.Size = new System.Drawing.Size(100, 38);
            this.cmb_spentMinute.TabIndex = 5;
            this.cmb_spentMinute.SelectedIndexChanged += new System.EventHandler(this.cmb_spentMinute_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.safeLabel2);
            this.panel1.Controls.Add(this.safeLabel1);
            this.panel1.Controls.Add(this.btn_note);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.lbl_fullname);
            this.panel1.Controls.Add(this.txtbox_time);
            this.panel1.Controls.Add(this.txtbox_fullname);
            this.panel1.Controls.Add(this.txtbox_date);
            this.panel1.Controls.Add(this.txtbox_phonenumber);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_phonenumber);
            this.panel1.Controls.Add(this.lbl_spenttime);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.cmb_spentMinute);
            this.panel1.Controls.Add(this.cmb_spentHour);
            this.panel1.Location = new System.Drawing.Point(16, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 472);
            this.panel1.TabIndex = 12;
            // 
            // safeLabel2
            // 
            this.safeLabel2.AutoSize = true;
            this.safeLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.safeLabel2.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeLabel2.ForeColor = System.Drawing.Color.Black;
            this.safeLabel2.Location = new System.Drawing.Point(157, 254);
            this.safeLabel2.Name = "safeLabel2";
            this.safeLabel2.Size = new System.Drawing.Size(47, 26);
            this.safeLabel2.TabIndex = 9;
            this.safeLabel2.Text = "دقیقه";
            // 
            // safeLabel1
            // 
            this.safeLabel1.AutoSize = true;
            this.safeLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.safeLabel1.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeLabel1.ForeColor = System.Drawing.Color.Black;
            this.safeLabel1.Location = new System.Drawing.Point(51, 254);
            this.safeLabel1.Name = "safeLabel1";
            this.safeLabel1.Size = new System.Drawing.Size(50, 26);
            this.safeLabel1.TabIndex = 9;
            this.safeLabel1.Text = "ساعت";
            // 
            // btn_note
            // 
            this.btn_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btn_note.FlatAppearance.BorderSize = 0;
            this.btn_note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_note.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btn_note.Location = new System.Drawing.Point(12, 354);
            this.btn_note.Name = "btn_note";
            this.btn_note.Size = new System.Drawing.Size(204, 41);
            this.btn_note.TabIndex = 7;
            this.btn_note.Text = "افزودن یادداشت";
            this.btn_note.UseVisualStyleBackColor = false;
            this.btn_note.Click += new System.EventHandler(this.btn_note_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btn_add.Location = new System.Drawing.Point(12, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 41);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "ثبت";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btn_cancel.Location = new System.Drawing.Point(116, 401);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 41);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FrmAddAtelierQueue
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(453, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FreeTimeDatagridView);
            this.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddAtelierQueue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن نوبت آتلیه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddAtelierQueue_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddAtelierQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreeTimeDatagridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_fullname;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_fullname;
        private System.Windows.Forms.TextBox txtbox_phonenumber;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_phonenumber;
        private System.Windows.Forms.ComboBox cmb_spentHour;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_spenttime;
        private Atf.UI.DateTimeSelector txtbox_date;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_date;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_time;
        private System.Windows.Forms.TextBox txtbox_time;
        private System.Windows.Forms.DataGridView FreeTimeDatagridView;
        private System.Windows.Forms.ComboBox cmb_spentMinute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtelierHourColumn;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel safeLabel1;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel safeLabel2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_note;
    }
}