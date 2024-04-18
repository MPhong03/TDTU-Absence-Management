namespace TDTUAbsenceReportingManagement
{
    partial class FormDangNhap
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
            this.emailLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.roleLogin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLogin
            // 
            this.emailLogin.BorderColor = System.Drawing.Color.Black;
            this.emailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLogin.DefaultText = "";
            this.emailLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLogin.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.user;
            this.emailLogin.Location = new System.Drawing.Point(34, 130);
            this.emailLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.PasswordChar = '\0';
            this.emailLogin.PlaceholderText = "Email";
            this.emailLogin.SelectedText = "";
            this.emailLogin.Size = new System.Drawing.Size(275, 40);
            this.emailLogin.TabIndex = 1;
            // 
            // passwordLogin
            // 
            this.passwordLogin.BorderColor = System.Drawing.Color.Black;
            this.passwordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLogin.DefaultText = "";
            this.passwordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordLogin.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources._lock;
            this.passwordLogin.Location = new System.Drawing.Point(34, 178);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '\0';
            this.passwordLogin.PlaceholderText = "Mật khẩu";
            this.passwordLogin.SelectedText = "";
            this.passwordLogin.Size = new System.Drawing.Size(275, 40);
            this.passwordLogin.TabIndex = 2;
            // 
            // roleLogin
            // 
            this.roleLogin.BackColor = System.Drawing.Color.Transparent;
            this.roleLogin.BorderColor = System.Drawing.Color.Black;
            this.roleLogin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleLogin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleLogin.ItemHeight = 30;
            this.roleLogin.Items.AddRange(new object[] {
            "Quản trị viên",
            "Giảng viên",
            "Sinh viên"});
            this.roleLogin.Location = new System.Drawing.Point(34, 225);
            this.roleLogin.Name = "roleLogin";
            this.roleLogin.Size = new System.Drawing.Size(275, 36);
            this.roleLogin.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(34, 291);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(275, 45);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "ĐĂNG NHẬP";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // successDialog
            // 
            this.successDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successDialog.Caption = null;
            this.successDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successDialog.Parent = this;
            this.successDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.successDialog.Text = "Đăng nhập thành công!";
            // 
            // errorDialog
            // 
            this.errorDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.errorDialog.Caption = null;
            this.errorDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.errorDialog.Parent = this;
            this.errorDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.errorDialog.Text = "Đăng nhập thất bại";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(105, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quên mật khẩu?";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TDTUAbsenceReportingManagement.Properties.Resources._298221300_404727638419305_983374014522547219_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.roleLogin);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.emailLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDangNhap";
            this.Text = "Absence Reporting Management";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox emailLogin;
        private Guna.UI2.WinForms.Guna2TextBox passwordLogin;
        private Guna.UI2.WinForms.Guna2ComboBox roleLogin;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

