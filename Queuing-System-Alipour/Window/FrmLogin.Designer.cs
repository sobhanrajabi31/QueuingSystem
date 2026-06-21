namespace Queuing_System_Alipour.Window
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.chckbox_remember = new System.Windows.Forms.CheckBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_password = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.lbl_username = new Queuing_System_Alipour.Tool.SafeLabel.SafeLabel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(72, 241);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 35);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "ورود";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Enabled = false;
            this.txtbox_password.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.Location = new System.Drawing.Point(72, 180);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(179, 32);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_password.TextChanged += new System.EventHandler(this.txtbox_password_TextChanged);
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            // 
            // txtbox_username
            // 
            this.txtbox_username.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.Location = new System.Drawing.Point(72, 110);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(179, 32);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_username.TextChanged += new System.EventHandler(this.txtbox_username_TextChanged);
            // 
            // chckbox_remember
            // 
            this.chckbox_remember.AutoSize = true;
            this.chckbox_remember.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_remember.Location = new System.Drawing.Point(153, 218);
            this.chckbox_remember.Name = "chckbox_remember";
            this.chckbox_remember.Size = new System.Drawing.Size(103, 23);
            this.chckbox_remember.TabIndex = 2;
            this.chckbox_remember.Text = "مرا به خاطر بسپار";
            this.chckbox_remember.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(199, 241);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(52, 35);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "ثبت نام";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(129, 150);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 27);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "رمز عبور";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(124, 80);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(75, 27);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "نام کاربری";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 357);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.chckbox_remember);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل ورود";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_password;
        private Queuing_System_Alipour.Tool.SafeLabel.SafeLabel lbl_username;
        private System.Windows.Forms.CheckBox chckbox_remember;
        private System.Windows.Forms.Button btn_register;
    }
}