namespace TDTUAbsenceReportingManagement.View.Lecturers
{
    partial class ActorGiangVienForm
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
            this.components = new System.ComponentModel.Container();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lecturerContainerControl = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.currentUser = new System.Windows.Forms.Label();
            this.warningDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.dangXuatTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.quanlyLopHocTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.guiBaoVangTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.notificationTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.dropdownMenuButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // successDialog
            // 
            this.successDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successDialog.Caption = null;
            this.successDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successDialog.Parent = null;
            this.successDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.successDialog.Text = "Đăng nhập thành công!";
            // 
            // errorDialog
            // 
            this.errorDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.errorDialog.Caption = null;
            this.errorDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.errorDialog.Parent = null;
            this.errorDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.errorDialog.Text = "Đăng nhập thất bại";
            // 
            // lecturerContainerControl
            // 
            this.lecturerContainerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lecturerContainerControl.Location = new System.Drawing.Point(204, 52);
            this.lecturerContainerControl.Name = "lecturerContainerControl";
            this.lecturerContainerControl.Size = new System.Drawing.Size(802, 501);
            this.lecturerContainerControl.TabIndex = 5;
            this.lecturerContainerControl.Text = "guna2ContainerControl1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.dangXuatTabButton);
            this.guna2Panel2.Controls.Add(this.quanlyLopHocTabButton);
            this.guna2Panel2.Controls.Add(this.guiBaoVangTabButton);
            this.guna2Panel2.Controls.Add(this.notificationTabButton);
            this.guna2Panel2.Controls.Add(this.homeTabButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 52);
            this.guna2Panel2.MinimumSize = new System.Drawing.Size(57, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(204, 501);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.currentUser);
            this.guna2Panel1.Controls.Add(this.dropdownMenuButton);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1006, 52);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(829, 6);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox3.TabIndex = 14;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(888, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox2.TabIndex = 13;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(947, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // currentUser
            // 
            this.currentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.currentUser.ForeColor = System.Drawing.Color.Transparent;
            this.currentUser.Location = new System.Drawing.Point(201, 6);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(576, 40);
            this.currentUser.TabIndex = 11;
            this.currentUser.Text = "who?";
            this.currentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.currentUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentUser_MouseDown);
            // 
            // warningDialog
            // 
            this.warningDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.warningDialog.Caption = null;
            this.warningDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.warningDialog.Parent = this;
            this.warningDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.warningDialog.Text = "Đăng nhập thành công!";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(172, 100);
            // 
            // dangXuatTabButton
            // 
            this.dangXuatTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dangXuatTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dangXuatTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dangXuatTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dangXuatTabButton.FillColor = System.Drawing.Color.Transparent;
            this.dangXuatTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dangXuatTabButton.ForeColor = System.Drawing.Color.Black;
            this.dangXuatTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.dangXuatTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit__2_;
            this.dangXuatTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit__1_1;
            this.dangXuatTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dangXuatTabButton.Location = new System.Drawing.Point(12, 210);
            this.dangXuatTabButton.Name = "dangXuatTabButton";
            this.dangXuatTabButton.Size = new System.Drawing.Size(186, 45);
            this.dangXuatTabButton.TabIndex = 6;
            this.dangXuatTabButton.Text = "Đăng xuất";
            this.dangXuatTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dangXuatTabButton.Click += new System.EventHandler(this.dangXuatTabButton_Click);
            // 
            // quanlyLopHocTabButton
            // 
            this.quanlyLopHocTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quanlyLopHocTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quanlyLopHocTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quanlyLopHocTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quanlyLopHocTabButton.FillColor = System.Drawing.Color.Transparent;
            this.quanlyLopHocTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quanlyLopHocTabButton.ForeColor = System.Drawing.Color.Black;
            this.quanlyLopHocTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.quanlyLopHocTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.learning__1_;
            this.quanlyLopHocTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.image__3_;
            this.quanlyLopHocTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quanlyLopHocTabButton.Location = new System.Drawing.Point(9, 159);
            this.quanlyLopHocTabButton.Name = "quanlyLopHocTabButton";
            this.quanlyLopHocTabButton.Size = new System.Drawing.Size(186, 45);
            this.quanlyLopHocTabButton.TabIndex = 4;
            this.quanlyLopHocTabButton.Text = "Quản lý lớp học";
            this.quanlyLopHocTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quanlyLopHocTabButton.Click += new System.EventHandler(this.quanlyLopHocTabButton_Click);
            // 
            // guiBaoVangTabButton
            // 
            this.guiBaoVangTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guiBaoVangTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guiBaoVangTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guiBaoVangTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guiBaoVangTabButton.FillColor = System.Drawing.Color.Transparent;
            this.guiBaoVangTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guiBaoVangTabButton.ForeColor = System.Drawing.Color.Black;
            this.guiBaoVangTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.guiBaoVangTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit__1_;
            this.guiBaoVangTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit;
            this.guiBaoVangTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guiBaoVangTabButton.Location = new System.Drawing.Point(9, 108);
            this.guiBaoVangTabButton.Name = "guiBaoVangTabButton";
            this.guiBaoVangTabButton.Size = new System.Drawing.Size(186, 45);
            this.guiBaoVangTabButton.TabIndex = 2;
            this.guiBaoVangTabButton.Text = "Gửi báo vắng";
            this.guiBaoVangTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guiBaoVangTabButton.Click += new System.EventHandler(this.guiBaoVangTabButton_Click);
            // 
            // notificationTabButton
            // 
            this.notificationTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notificationTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notificationTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notificationTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notificationTabButton.FillColor = System.Drawing.Color.Transparent;
            this.notificationTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notificationTabButton.ForeColor = System.Drawing.Color.Black;
            this.notificationTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.notificationTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.account;
            this.notificationTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.notify;
            this.notificationTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notificationTabButton.Location = new System.Drawing.Point(9, 57);
            this.notificationTabButton.Name = "notificationTabButton";
            this.notificationTabButton.Size = new System.Drawing.Size(186, 45);
            this.notificationTabButton.TabIndex = 1;
            this.notificationTabButton.Text = "Thông báo";
            this.notificationTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notificationTabButton.Click += new System.EventHandler(this.notificationTabButton_Click);
            // 
            // homeTabButton
            // 
            this.homeTabButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeTabButton.FillColor = System.Drawing.Color.Transparent;
            this.homeTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homeTabButton.ForeColor = System.Drawing.Color.Black;
            this.homeTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.homeTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.home;
            this.homeTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.home__1_;
            this.homeTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeTabButton.Location = new System.Drawing.Point(9, 6);
            this.homeTabButton.Name = "homeTabButton";
            this.homeTabButton.Size = new System.Drawing.Size(186, 45);
            this.homeTabButton.TabIndex = 0;
            this.homeTabButton.Text = "Trang chủ";
            this.homeTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeTabButton.Click += new System.EventHandler(this.homeTabButton_Click);
            // 
            // dropdownMenuButton
            // 
            this.dropdownMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownMenuButton.BackgroundImage = global::TDTUAbsenceReportingManagement.Properties.Resources.profile;
            this.dropdownMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropdownMenuButton.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.dropdownMenuButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.profile;
            this.dropdownMenuButton.ImageRotate = 0F;
            this.dropdownMenuButton.InitialImage = null;
            this.dropdownMenuButton.Location = new System.Drawing.Point(783, 6);
            this.dropdownMenuButton.Name = "dropdownMenuButton";
            this.dropdownMenuButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dropdownMenuButton.Size = new System.Drawing.Size(40, 40);
            this.dropdownMenuButton.TabIndex = 10;
            this.dropdownMenuButton.TabStop = false;
            this.dropdownMenuButton.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.logo_dai_hoc_ton_duc_thang_dongphucvina_vn_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(54, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.circular;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(195, 48);
            this.changePasswordToolStripMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit__1_1;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(195, 48);
            this.logoutToolStripMenuItem.Text = "Đăng xuất";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // ActorGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.lecturerContainerControl);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActorGiangVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.ActorGiangVienForm_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropdownMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2ContainerControl lecturerContainerControl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button quanlyLopHocTabButton;
        private Guna.UI2.WinForms.Guna2Button guiBaoVangTabButton;
        private Guna.UI2.WinForms.Guna2Button notificationTabButton;
        private Guna.UI2.WinForms.Guna2Button homeTabButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button dangXuatTabButton;
        private Guna.UI2.WinForms.Guna2MessageDialog warningDialog;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label currentUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox dropdownMenuButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}