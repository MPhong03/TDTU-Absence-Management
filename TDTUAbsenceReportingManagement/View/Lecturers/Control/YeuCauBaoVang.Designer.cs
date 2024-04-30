namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    partial class YeuCauBaoVang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xoaYeuCauButton = new Guna.UI2.WinForms.Guna2Button();
            this.themYeuCauBVButton = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachYeuCauBaoVang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoVang)).BeginInit();
            this.SuspendLayout();
            // 
            // xoaYeuCauButton
            // 
            this.xoaYeuCauButton.BorderRadius = 10;
            this.xoaYeuCauButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoaYeuCauButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoaYeuCauButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoaYeuCauButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoaYeuCauButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.xoaYeuCauButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xoaYeuCauButton.ForeColor = System.Drawing.Color.White;
            this.xoaYeuCauButton.Location = new System.Drawing.Point(406, 17);
            this.xoaYeuCauButton.Name = "xoaYeuCauButton";
            this.xoaYeuCauButton.Size = new System.Drawing.Size(385, 31);
            this.xoaYeuCauButton.TabIndex = 48;
            this.xoaYeuCauButton.Text = "Xóa yêu cầu";
            this.xoaYeuCauButton.Click += new System.EventHandler(this.xoaYeuCauButton_Click);
            // 
            // themYeuCauBVButton
            // 
            this.themYeuCauBVButton.BorderRadius = 10;
            this.themYeuCauBVButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themYeuCauBVButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themYeuCauBVButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themYeuCauBVButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themYeuCauBVButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.themYeuCauBVButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.themYeuCauBVButton.ForeColor = System.Drawing.Color.White;
            this.themYeuCauBVButton.Location = new System.Drawing.Point(13, 17);
            this.themYeuCauBVButton.Name = "themYeuCauBVButton";
            this.themYeuCauBVButton.Size = new System.Drawing.Size(387, 31);
            this.themYeuCauBVButton.TabIndex = 47;
            this.themYeuCauBVButton.Text = "Báo vắng";
            this.themYeuCauBVButton.Click += new System.EventHandler(this.themYeuCauBVButton_Click);
            // 
            // danhSachYeuCauBaoVang
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.danhSachYeuCauBaoVang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachYeuCauBaoVang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.danhSachYeuCauBaoVang.ColumnHeadersHeight = 18;
            this.danhSachYeuCauBaoVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachYeuCauBaoVang.DefaultCellStyle = dataGridViewCellStyle9;
            this.danhSachYeuCauBaoVang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoVang.Location = new System.Drawing.Point(13, 54);
            this.danhSachYeuCauBaoVang.Name = "danhSachYeuCauBaoVang";
            this.danhSachYeuCauBaoVang.RowHeadersVisible = false;
            this.danhSachYeuCauBaoVang.RowHeadersWidth = 51;
            this.danhSachYeuCauBaoVang.RowTemplate.Height = 24;
            this.danhSachYeuCauBaoVang.Size = new System.Drawing.Size(778, 430);
            this.danhSachYeuCauBaoVang.TabIndex = 49;
            this.danhSachYeuCauBaoVang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachYeuCauBaoVang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoVang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoVang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoVang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachYeuCauBaoVang.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachYeuCauBaoVang.ThemeStyle.ReadOnly = false;
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoVang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachYeuCauBaoVang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachYeuCauBaoVang_CellClick);
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
            // warningDialog
            // 
            this.warningDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.warningDialog.Caption = null;
            this.warningDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.warningDialog.Parent = null;
            this.warningDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.warningDialog.Text = "Đăng nhập thành công!";
            // 
            // YeuCauBaoVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.danhSachYeuCauBaoVang);
            this.Controls.Add(this.xoaYeuCauButton);
            this.Controls.Add(this.themYeuCauBVButton);
            this.Name = "YeuCauBaoVang";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.YeuCauBaoVang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoVang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button xoaYeuCauButton;
        private Guna.UI2.WinForms.Guna2Button themYeuCauBVButton;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachYeuCauBaoVang;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningDialog;
    }
}
