﻿namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan
{
    partial class XacNhanImportDSGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questionDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachGiangVienImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachGiangVienImport)).BeginInit();
            this.SuspendLayout();
            // 
            // questionDialog
            // 
            this.questionDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.questionDialog.Caption = "Confirm";
            this.questionDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.questionDialog.Parent = this;
            this.questionDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.questionDialog.Text = null;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(403, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(385, 31);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.BorderRadius = 10;
            this.confirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(17, 407);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(380, 31);
            this.confirmButton.TabIndex = 34;
            this.confirmButton.Text = "Xác nhận";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // danhSachGiangVienImport
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.danhSachGiangVienImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.danhSachGiangVienImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachGiangVienImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.danhSachGiangVienImport.ColumnHeadersHeight = 18;
            this.danhSachGiangVienImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachGiangVienImport.DefaultCellStyle = dataGridViewCellStyle6;
            this.danhSachGiangVienImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachGiangVienImport.Location = new System.Drawing.Point(17, 67);
            this.danhSachGiangVienImport.Name = "danhSachGiangVienImport";
            this.danhSachGiangVienImport.RowHeadersVisible = false;
            this.danhSachGiangVienImport.RowHeadersWidth = 51;
            this.danhSachGiangVienImport.RowTemplate.Height = 24;
            this.danhSachGiangVienImport.Size = new System.Drawing.Size(771, 325);
            this.danhSachGiangVienImport.TabIndex = 33;
            this.danhSachGiangVienImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachGiangVienImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachGiangVienImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachGiangVienImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachGiangVienImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachGiangVienImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachGiangVienImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachGiangVienImport.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachGiangVienImport.ThemeStyle.ReadOnly = false;
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachGiangVienImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Xác nhận thêm các tài khoản giảng viên";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(617, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox3.TabIndex = 31;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(676, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox2.TabIndex = 30;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(735, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(53, 35);
            this.guna2ControlBox1.TabIndex = 29;
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
            // warningDialog
            // 
            this.warningDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.warningDialog.Caption = null;
            this.warningDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.warningDialog.Parent = null;
            this.warningDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.warningDialog.Text = "Đăng nhập thành công!";
            // 
            // XacNhanImportDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.danhSachGiangVienImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XacNhanImportDSGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XacNhanImportDSGV";
            this.Load += new System.EventHandler(this.XacNhanImportDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachGiangVienImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog questionDialog;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachGiangVienImport;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningDialog;
    }
}