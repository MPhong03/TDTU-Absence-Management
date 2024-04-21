namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    partial class ThemSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.academicRankSV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.genderSV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.huySVbtn = new Guna.UI2.WinForms.Guna2Button();
            this.themSVbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cccdSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.maSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthDateSV = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.messageDIalogSV = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // academicRankSV
            // 
            this.academicRankSV.BackColor = System.Drawing.Color.Transparent;
            this.academicRankSV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.academicRankSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.academicRankSV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.academicRankSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.academicRankSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.academicRankSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.academicRankSV.ItemHeight = 30;
            this.academicRankSV.Items.AddRange(new object[] {
            "Khoa học máy tính",
            "Kỹ thuật phần mềm",
            "Mạng máy tính và truyền thông dữ liệu"});
            this.academicRankSV.Location = new System.Drawing.Point(205, 440);
            this.academicRankSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.academicRankSV.Name = "academicRankSV";
            this.academicRankSV.Size = new System.Drawing.Size(399, 36);
            this.academicRankSV.TabIndex = 27;
            // 
            // genderSV
            // 
            this.genderSV.BackColor = System.Drawing.Color.Transparent;
            this.genderSV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderSV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderSV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderSV.ItemHeight = 30;
            this.genderSV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genderSV.Location = new System.Drawing.Point(205, 389);
            this.genderSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.genderSV.Name = "genderSV";
            this.genderSV.Size = new System.Drawing.Size(399, 36);
            this.genderSV.TabIndex = 26;
            // 
            // huySVbtn
            // 
            this.huySVbtn.BorderRadius = 10;
            this.huySVbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.huySVbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.huySVbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.huySVbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.huySVbtn.FillColor = System.Drawing.Color.Gold;
            this.huySVbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.huySVbtn.ForeColor = System.Drawing.Color.White;
            this.huySVbtn.Location = new System.Drawing.Point(424, 502);
            this.huySVbtn.Name = "huySVbtn";
            this.huySVbtn.Size = new System.Drawing.Size(180, 40);
            this.huySVbtn.TabIndex = 25;
            this.huySVbtn.Text = "Hủy";
            this.huySVbtn.Click += new System.EventHandler(this.huySVbtn_Click);
            // 
            // themSVbtn
            // 
            this.themSVbtn.BorderRadius = 10;
            this.themSVbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themSVbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themSVbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themSVbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themSVbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.themSVbtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.themSVbtn.ForeColor = System.Drawing.Color.White;
            this.themSVbtn.Location = new System.Drawing.Point(205, 502);
            this.themSVbtn.Name = "themSVbtn";
            this.themSVbtn.Size = new System.Drawing.Size(180, 40);
            this.themSVbtn.TabIndex = 24;
            this.themSVbtn.Text = "Thêm";
            this.themSVbtn.Click += new System.EventHandler(this.themSVbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // courseSV
            // 
            this.courseSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseSV.DefaultText = "";
            this.courseSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.courseSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.courseSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.courseSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.learning__2_;
            this.courseSV.Location = new System.Drawing.Point(205, 303);
            this.courseSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.courseSV.Name = "courseSV";
            this.courseSV.PasswordChar = '\0';
            this.courseSV.PlaceholderText = "Năm tuyển sinh";
            this.courseSV.SelectedText = "";
            this.courseSV.Size = new System.Drawing.Size(399, 36);
            this.courseSV.TabIndex = 22;
            this.courseSV.TextChanged += new System.EventHandler(this.courseSV_TextChanged);
            this.courseSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.courseSV_KeyPress);
            // 
            // passwordSV
            // 
            this.passwordSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordSV.DefaultText = "";
            this.passwordSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources._lock;
            this.passwordSV.Location = new System.Drawing.Point(205, 262);
            this.passwordSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.passwordSV.Name = "passwordSV";
            this.passwordSV.PasswordChar = '\0';
            this.passwordSV.PlaceholderText = "Mật khẩu";
            this.passwordSV.SelectedText = "";
            this.passwordSV.Size = new System.Drawing.Size(399, 36);
            this.passwordSV.TabIndex = 21;
            this.passwordSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordSV_KeyPress);
            // 
            // phoneSV
            // 
            this.phoneSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneSV.DefaultText = "";
            this.phoneSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.phone;
            this.phoneSV.Location = new System.Drawing.Point(205, 218);
            this.phoneSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.phoneSV.Name = "phoneSV";
            this.phoneSV.PasswordChar = '\0';
            this.phoneSV.PlaceholderText = "Số điện thoại";
            this.phoneSV.SelectedText = "";
            this.phoneSV.Size = new System.Drawing.Size(399, 36);
            this.phoneSV.TabIndex = 20;
            this.phoneSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneSV_KeyPress);
            // 
            // fullNameSV
            // 
            this.fullNameSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameSV.DefaultText = "";
            this.fullNameSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.user;
            this.fullNameSV.Location = new System.Drawing.Point(205, 174);
            this.fullNameSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fullNameSV.Name = "fullNameSV";
            this.fullNameSV.PasswordChar = '\0';
            this.fullNameSV.PlaceholderText = "Họ và tên";
            this.fullNameSV.SelectedText = "";
            this.fullNameSV.Size = new System.Drawing.Size(399, 36);
            this.fullNameSV.TabIndex = 19;
            this.fullNameSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullNameSV_KeyPress);
            // 
            // cccdSV
            // 
            this.cccdSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cccdSV.DefaultText = "";
            this.cccdSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cccdSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cccdSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cccdSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cccdSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cccdSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cccdSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cccdSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.idcard;
            this.cccdSV.Location = new System.Drawing.Point(205, 130);
            this.cccdSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cccdSV.Name = "cccdSV";
            this.cccdSV.PasswordChar = '\0';
            this.cccdSV.PlaceholderText = "CCCD/CMND";
            this.cccdSV.SelectedText = "";
            this.cccdSV.Size = new System.Drawing.Size(399, 36);
            this.cccdSV.TabIndex = 18;
            this.cccdSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cccdSV_KeyPress);
            // 
            // emailSV
            // 
            this.emailSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailSV.DefaultText = "";
            this.emailSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.email;
            this.emailSV.Location = new System.Drawing.Point(205, 86);
            this.emailSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.emailSV.Name = "emailSV";
            this.emailSV.PasswordChar = '\0';
            this.emailSV.PlaceholderText = "Email";
            this.emailSV.SelectedText = "";
            this.emailSV.Size = new System.Drawing.Size(399, 36);
            this.emailSV.TabIndex = 17;
            // 
            // maSV
            // 
            this.maSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maSV.DefaultText = "";
            this.maSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maSV.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.id;
            this.maSV.Location = new System.Drawing.Point(205, 42);
            this.maSV.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.maSV.Name = "maSV";
            this.maSV.PasswordChar = '\0';
            this.maSV.PlaceholderText = "Mã sinh viên";
            this.maSV.SelectedText = "";
            this.maSV.Size = new System.Drawing.Size(399, 36);
            this.maSV.TabIndex = 16;
            // 
            // birthDateSV
            // 
            this.birthDateSV.Checked = true;
            this.birthDateSV.FillColor = System.Drawing.Color.LightSkyBlue;
            this.birthDateSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthDateSV.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthDateSV.Location = new System.Drawing.Point(205, 345);
            this.birthDateSV.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthDateSV.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthDateSV.Name = "birthDateSV";
            this.birthDateSV.Size = new System.Drawing.Size(399, 36);
            this.birthDateSV.TabIndex = 41;
            this.birthDateSV.Value = new System.DateTime(2024, 4, 18, 11, 33, 27, 219);
            // 
            // messageDIalogSV
            // 
            this.messageDIalogSV.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDIalogSV.Caption = null;
            this.messageDIalogSV.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messageDIalogSV.Parent = null;
            this.messageDIalogSV.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.messageDIalogSV.Text = null;
            // 
            // ThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.birthDateSV);
            this.Controls.Add(this.academicRankSV);
            this.Controls.Add(this.genderSV);
            this.Controls.Add(this.huySVbtn);
            this.Controls.Add(this.themSVbtn);
            this.Controls.Add(this.courseSV);
            this.Controls.Add(this.passwordSV);
            this.Controls.Add(this.phoneSV);
            this.Controls.Add(this.fullNameSV);
            this.Controls.Add(this.cccdSV);
            this.Controls.Add(this.emailSV);
            this.Controls.Add(this.maSV);
            this.Controls.Add(this.label1);
            this.Name = "ThemSinhVien";
            this.Size = new System.Drawing.Size(808, 548);
            this.Load += new System.EventHandler(this.ThemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox academicRankSV;
        private Guna.UI2.WinForms.Guna2ComboBox genderSV;
        private Guna.UI2.WinForms.Guna2Button huySVbtn;
        private Guna.UI2.WinForms.Guna2Button themSVbtn;
        private Guna.UI2.WinForms.Guna2TextBox courseSV;
        private Guna.UI2.WinForms.Guna2TextBox passwordSV;
        private Guna.UI2.WinForms.Guna2TextBox phoneSV;
        private Guna.UI2.WinForms.Guna2TextBox fullNameSV;
        private Guna.UI2.WinForms.Guna2TextBox cccdSV;
        private Guna.UI2.WinForms.Guna2TextBox emailSV;
        private Guna.UI2.WinForms.Guna2TextBox maSV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthDateSV;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDIalogSV;
    }
}
