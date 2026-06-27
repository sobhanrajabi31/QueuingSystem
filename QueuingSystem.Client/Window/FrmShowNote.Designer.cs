namespace QueuingSystem.Client.Window
{
    partial class FrmShowNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowNote));
            this.txtbox_note = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_note
            // 
            this.txtbox_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_note.Location = new System.Drawing.Point(0, 0);
            this.txtbox_note.Multiline = true;
            this.txtbox_note.Name = "txtbox_note";
            this.txtbox_note.ReadOnly = true;
            this.txtbox_note.Size = new System.Drawing.Size(451, 324);
            this.txtbox_note.TabIndex = 0;
            // 
            // FrmShowNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 324);
            this.Controls.Add(this.txtbox_note);
            this.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowNote";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "یادداشت";
            this.Load += new System.EventHandler(this.FrmShowNote_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmShowNote_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbox_note;
    }
}