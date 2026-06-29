using QueuingSystem.Client.Tool;

namespace QueuingSystem.Client.Window
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
            txtbox_username = new TextBox();
            txtbox_password = new TextBox();
            txtbox_rpassword = new TextBox();
            btn_register = new Button();
            lbl_rpassword = new SafeLabel();
            lbl_password = new SafeLabel();
            lbl_username = new SafeLabel();
            btn_login = new Button();
            comboBoxRole = new ComboBox();
            lbl_role = new SafeLabel();
            SuspendLayout();
            // 
            // txtbox_username
            // 
            txtbox_username.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_username.Location = new Point(88, 58);
            txtbox_username.Margin = new Padding(4, 3, 4, 3);
            txtbox_username.Name = "txtbox_username";
            txtbox_username.Size = new Size(208, 32);
            txtbox_username.TabIndex = 0;
            txtbox_username.TextAlign = HorizontalAlignment.Center;
            txtbox_username.TextChanged += Txtbox_username_TextChanged;
            // 
            // txtbox_password
            // 
            txtbox_password.Enabled = false;
            txtbox_password.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_password.Location = new Point(88, 139);
            txtbox_password.Margin = new Padding(4, 3, 4, 3);
            txtbox_password.Name = "txtbox_password";
            txtbox_password.PasswordChar = '*';
            txtbox_password.Size = new Size(208, 32);
            txtbox_password.TabIndex = 1;
            txtbox_password.TextAlign = HorizontalAlignment.Center;
            txtbox_password.TextChanged += Txtbox_password_TextChanged;
            // 
            // txtbox_rpassword
            // 
            txtbox_rpassword.Enabled = false;
            txtbox_rpassword.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbox_rpassword.Location = new Point(88, 220);
            txtbox_rpassword.Margin = new Padding(4, 3, 4, 3);
            txtbox_rpassword.Name = "txtbox_rpassword";
            txtbox_rpassword.PasswordChar = '*';
            txtbox_rpassword.Size = new Size(208, 32);
            txtbox_rpassword.TabIndex = 2;
            txtbox_rpassword.TextAlign = HorizontalAlignment.Center;
            txtbox_rpassword.TextChanged += Txtbox_rpassword_TextChanged;
            // 
            // btn_register
            // 
            btn_register.Enabled = false;
            btn_register.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(88, 349);
            btn_register.Margin = new Padding(4, 3, 4, 3);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(148, 40);
            btn_register.TabIndex = 3;
            btn_register.Text = "ثبت نام";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += Btn_register_Click;
            // 
            // lbl_rpassword
            // 
            lbl_rpassword.AutoSize = true;
            lbl_rpassword.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_rpassword.Location = new Point(144, 185);
            lbl_rpassword.Margin = new Padding(4, 0, 4, 0);
            lbl_rpassword.Name = "lbl_rpassword";
            lbl_rpassword.Size = new Size(96, 27);
            lbl_rpassword.TabIndex = 0;
            lbl_rpassword.Text = "تکرار رمز عبور";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(160, 105);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(64, 27);
            lbl_password.TabIndex = 0;
            lbl_password.Text = "رمز عبور";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(155, 24);
            lbl_username.Margin = new Padding(4, 0, 4, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(75, 27);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "نام کاربری";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Vazirmatn ExtraBold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(243, 349);
            btn_login.Margin = new Padding(4, 3, 4, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(54, 40);
            btn_login.TabIndex = 4;
            btn_login.Text = "ورود";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += Btn_login_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Vazirmatn ExtraBold", 12F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "منشی (ساده)", "عکاس" });
            comboBoxRole.Location = new Point(88, 302);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.RightToLeft = RightToLeft.Yes;
            comboBoxRole.Size = new Size(208, 35);
            comboBoxRole.TabIndex = 5;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Vazirmatn ExtraBold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_role.Location = new Point(148, 272);
            lbl_role.Margin = new Padding(4, 0, 4, 0);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(88, 27);
            lbl_role.TabIndex = 6;
            lbl_role.Text = "نقش کارمند";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 412);
            Controls.Add(lbl_role);
            Controls.Add(comboBoxRole);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(txtbox_rpassword);
            Controls.Add(txtbox_password);
            Controls.Add(lbl_rpassword);
            Controls.Add(txtbox_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل ثبت نام";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private SafeLabel lbl_username;
        private SafeLabel lbl_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private SafeLabel lbl_rpassword;
        private System.Windows.Forms.TextBox txtbox_rpassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private ComboBox comboBoxRole;
        private SafeLabel lbl_role;
    }
}