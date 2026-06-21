namespace QueuingSystem.Forms
{
    partial class FrmCheckFirstConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckFirstConnection));
            this.lbl_text = new System.Windows.Forms.Label();
            this.prog_WaitForConn = new System.Windows.Forms.ProgressBar();
            this.btn_TryAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_text.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_text.Location = new System.Drawing.Point(0, 0);
            this.lbl_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_text.Size = new System.Drawing.Size(432, 50);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "در حال اتصال...\r\n";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // prog_WaitForConn
            // 
            this.prog_WaitForConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prog_WaitForConn.Location = new System.Drawing.Point(41, 66);
            this.prog_WaitForConn.MarqueeAnimationSpeed = 0;
            this.prog_WaitForConn.Name = "prog_WaitForConn";
            this.prog_WaitForConn.Size = new System.Drawing.Size(350, 20);
            this.prog_WaitForConn.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prog_WaitForConn.TabIndex = 1;
            // 
            // btn_TryAgain
            // 
            this.btn_TryAgain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TryAgain.BackColor = System.Drawing.Color.DimGray;
            this.btn_TryAgain.Enabled = false;
            this.btn_TryAgain.Location = new System.Drawing.Point(82, 107);
            this.btn_TryAgain.Name = "btn_TryAgain";
            this.btn_TryAgain.Size = new System.Drawing.Size(128, 38);
            this.btn_TryAgain.TabIndex = 2;
            this.btn_TryAgain.Text = "تلاش مجدد";
            this.btn_TryAgain.UseVisualStyleBackColor = false;
            this.btn_TryAgain.Click += new System.EventHandler(this.btn_TryAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.btn_Exit.Location = new System.Drawing.Point(222, 107);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(128, 38);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FrmCheckFirstConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(432, 173);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_TryAgain);
            this.Controls.Add(this.prog_WaitForConn);
            this.Controls.Add(this.lbl_text);
            this.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCheckFirstConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFirstConnection";
            this.Load += new System.EventHandler(this.FrmCheckFirstConnection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.ProgressBar prog_WaitForConn;
        private System.Windows.Forms.Button btn_TryAgain;
        private System.Windows.Forms.Button btn_Exit;
    }
}