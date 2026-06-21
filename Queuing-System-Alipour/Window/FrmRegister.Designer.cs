namespace QueuingSystem.Forms
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_rpassword = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_rpassword = new QueuingSystem.Features.SafeUI.SafeLabel();
            this.lbl_password = new QueuingSystem.Features.SafeUI.SafeLabel();
            this.lbl_username = new QueuingSystem.Features.SafeUI.SafeLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_username
            // 
            this.txtbox_username.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_username.Location = new System.Drawing.Point(75, 87);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(179, 32);
            this.txtbox_username.TabIndex = 0;
            this.txtbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_username.TextChanged += new System.EventHandler(this.Txtbox_username_TextChanged);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Enabled = false;
            this.txtbox_password.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.Location = new System.Drawing.Point(75, 157);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(179, 32);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_password.TextChanged += new System.EventHandler(this.Txtbox_password_TextChanged);
            // 
            // txtbox_rpassword
            // 
            this.txtbox_rpassword.Enabled = false;
            this.txtbox_rpassword.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_rpassword.Location = new System.Drawing.Point(75, 227);
            this.txtbox_rpassword.Name = "txtbox_rpassword";
            this.txtbox_rpassword.PasswordChar = '*';
            this.txtbox_rpassword.Size = new System.Drawing.Size(179, 32);
            this.txtbox_rpassword.TabIndex = 2;
            this.txtbox_rpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_rpassword.TextChanged += new System.EventHandler(this.Txtbox_rpassword_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.Enabled = false;
            this.btn_register.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(75, 265);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(127, 35);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "ثبت نام";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // lbl_rpassword
            // 
            this.lbl_rpassword.AutoSize = true;
            this.lbl_rpassword.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpassword.Location = new System.Drawing.Point(116, 197);
            this.lbl_rpassword.Name = "lbl_rpassword";
            this.lbl_rpassword.Size = new System.Drawing.Size(96, 27);
            this.lbl_rpassword.TabIndex = 0;
            this.lbl_rpassword.Text = "تکرار رمز عبور";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(132, 127);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 27);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "رمز عبور";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(127, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(75, 27);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "نام کاربری";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Vazirmatn ExtraBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(208, 265);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(46, 35);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "ورود";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(329, 357);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txtbox_rpassword);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.lbl_rpassword);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پنل ثبت نام";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Features.SafeUI.SafeLabel lbl_username;
        private Features.SafeUI.SafeLabel lbl_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private Features.SafeUI.SafeLabel lbl_rpassword;
        private System.Windows.Forms.TextBox txtbox_rpassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
    }
}