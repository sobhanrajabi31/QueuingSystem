using QueuingSystem.Client.Tool;

namespace QueuingSystem.Client.Window
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
            btn_login = new Button();
            txtbox_password = new TextBox();
            txtbox_username = new TextBox();
            chckbox_remember = new CheckBox();
            btn_register = new Button();
            lbl_password = new SafeLabel();
            lbl_username = new SafeLabel();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Enabled = false;
            btn_login.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(84, 278);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(141, 40);
            btn_login.TabIndex = 3;
            btn_login.Text = "ورود";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtbox_password
            // 
            txtbox_password.Enabled = false;
            txtbox_password.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_password.Location = new Point(84, 208);
            txtbox_password.Margin = new Padding(4, 3, 4, 3);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.PasswordChar = '*';
            txtbox_password.Size = new Size(208, 32);
            txtbox_password.TabIndex = 1;
            txtbox_password.TextAlign = HorizontalAlignment.Center;
            txtbox_password.TextChanged += txtbox_password_TextChanged;
            txtbox_password.KeyDown += txtbox_password_KeyDown;
            // 
            // txtbox_username
            // 
            txtbox_username.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_username.Location = new Point(84, 127);
            txtbox_username.Margin = new Padding(4, 3, 4, 3);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(208, 32);
            txtbox_username.TabIndex = 0;
            txtbox_username.TextAlign = HorizontalAlignment.Center;
            txtbox_username.TextChanged += txtbox_username_TextChanged;
            // 
            // chckbox_remember
            // 
            chckbox_remember.AutoSize = true;
            chckbox_remember.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckbox_remember.Location = new Point(178, 252);
            chckbox_remember.Margin = new Padding(4, 3, 4, 3);
            chckbox_remember.Name = "chckbox_remember";
            chckbox_remember.Size = new Size(103, 23);
            chckbox_remember.TabIndex = 2;
            chckbox_remember.Text = "مرا به خاطر بسپار";
            chckbox_remember.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(232, 278);
            btn_register.Margin = new Padding(4, 3, 4, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(61, 40);
            btn_register.TabIndex = 4;
            btn_register.Text = "ثبت نام";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(150, 173);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(64, 27);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "رمز عبور";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(145, 92);
            lbl_username.Margin = new Padding(4, 0, 4, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(75, 27);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "نام کاربری";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 412);
            Controls.Add(btn_register);
            Controls.Add(chckbox_remember);
            Controls.Add(btn_login);
            Controls.Add(txtbox_password);
            Controls.Add(txtbox_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل ورود";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private SafeLabel lbl_password;
        private SafeLabel lbl_username;
        private System.Windows.Forms.CheckBox chckbox_remember;
        private System.Windows.Forms.Button btn_register;
    }
}