﻿namespace TDTUAbsenceReportingManagement.View.Admin
{
    partial class QuanTriVienForm
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
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.courseTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.baoBuTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.baoVangTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.accountManageTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeTabButton = new Guna.UI2.WinForms.Guna2Button();
            this.adminContainerControl = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1006, 52);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.logo_dai_hoc_ton_duc_thang_dongphucvina_vn_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(54, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.courseTabButton);
            this.guna2Panel2.Controls.Add(this.baoBuTabButton);
            this.guna2Panel2.Controls.Add(this.baoVangTabButton);
            this.guna2Panel2.Controls.Add(this.accountManageTabButton);
            this.guna2Panel2.Controls.Add(this.homeTabButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 52);
            this.guna2Panel2.MinimumSize = new System.Drawing.Size(57, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(204, 501);
            this.guna2Panel2.TabIndex = 1;
            // 
            // courseTabButton
            // 
            this.courseTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.courseTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.courseTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.courseTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.courseTabButton.FillColor = System.Drawing.Color.Transparent;
            this.courseTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.courseTabButton.ForeColor = System.Drawing.Color.Black;
            this.courseTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.courseTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.learning__1_;
            this.courseTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.learning__2_;
            this.courseTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.courseTabButton.Location = new System.Drawing.Point(9, 210);
            this.courseTabButton.Name = "courseTabButton";
            this.courseTabButton.Size = new System.Drawing.Size(186, 45);
            this.courseTabButton.TabIndex = 4;
            this.courseTabButton.Text = "Quản lý môn học";
            this.courseTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.courseTabButton.Click += new System.EventHandler(this.courseTabButton_Click);
            // 
            // baoBuTabButton
            // 
            this.baoBuTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baoBuTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baoBuTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baoBuTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baoBuTabButton.FillColor = System.Drawing.Color.Transparent;
            this.baoBuTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baoBuTabButton.ForeColor = System.Drawing.Color.Black;
            this.baoBuTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.baoBuTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.clock__1_;
            this.baoBuTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.clock;
            this.baoBuTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baoBuTabButton.Location = new System.Drawing.Point(9, 159);
            this.baoBuTabButton.Name = "baoBuTabButton";
            this.baoBuTabButton.Size = new System.Drawing.Size(186, 45);
            this.baoBuTabButton.TabIndex = 3;
            this.baoBuTabButton.Text = "Phản hồi báo bù";
            this.baoBuTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baoBuTabButton.Click += new System.EventHandler(this.baoBuTabButton_Click);
            // 
            // baoVangTabButton
            // 
            this.baoVangTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baoVangTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baoVangTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baoVangTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baoVangTabButton.FillColor = System.Drawing.Color.Transparent;
            this.baoVangTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baoVangTabButton.ForeColor = System.Drawing.Color.Black;
            this.baoVangTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.baoVangTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit__1_;
            this.baoVangTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.exit;
            this.baoVangTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baoVangTabButton.Location = new System.Drawing.Point(9, 108);
            this.baoVangTabButton.Name = "baoVangTabButton";
            this.baoVangTabButton.Size = new System.Drawing.Size(186, 45);
            this.baoVangTabButton.TabIndex = 2;
            this.baoVangTabButton.Text = "Phản hồi báo vắng";
            this.baoVangTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.baoVangTabButton.Click += new System.EventHandler(this.baoVangTabButton_Click);
            // 
            // accountManageTabButton
            // 
            this.accountManageTabButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountManageTabButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountManageTabButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountManageTabButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountManageTabButton.FillColor = System.Drawing.Color.Transparent;
            this.accountManageTabButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.accountManageTabButton.ForeColor = System.Drawing.Color.Black;
            this.accountManageTabButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.accountManageTabButton.HoverState.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.account;
            this.accountManageTabButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.account__1_;
            this.accountManageTabButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountManageTabButton.Location = new System.Drawing.Point(9, 57);
            this.accountManageTabButton.Name = "accountManageTabButton";
            this.accountManageTabButton.Size = new System.Drawing.Size(186, 45);
            this.accountManageTabButton.TabIndex = 1;
            this.accountManageTabButton.Text = "Quản lý tài khoản";
            this.accountManageTabButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountManageTabButton.Click += new System.EventHandler(this.accountManageTabButton_Click);
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
            // adminContainerControl
            // 
            this.adminContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminContainerControl.Location = new System.Drawing.Point(204, 52);
            this.adminContainerControl.Name = "adminContainerControl";
            this.adminContainerControl.Size = new System.Drawing.Size(802, 501);
            this.adminContainerControl.TabIndex = 2;
            this.adminContainerControl.Text = "guna2ContainerControl1";
            // 
            // QuanTriVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 553);
            this.Controls.Add(this.adminContainerControl);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "QuanTriVienForm";
            this.Text = "QuanTriVienForm";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button homeTabButton;
        private Guna.UI2.WinForms.Guna2Button courseTabButton;
        private Guna.UI2.WinForms.Guna2Button baoBuTabButton;
        private Guna.UI2.WinForms.Guna2Button baoVangTabButton;
        private Guna.UI2.WinForms.Guna2Button accountManageTabButton;
        private Guna.UI2.WinForms.Guna2ContainerControl adminContainerControl;
    }
}