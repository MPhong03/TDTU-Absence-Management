namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    partial class QuanLyMonHocForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.danhSachMonHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSoMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhSuaMonHocButton = new Guna.UI2.WinForms.Guna2Button();
            this.xoaMonHocButton = new Guna.UI2.WinForms.Guna2Button();
            this.theMonHocButton = new Guna.UI2.WinForms.Guna2Button();
            this.questionDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.doKhoInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.soTinChiInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.tenMonHocInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.maMonHocInput = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // danhSachMonHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.danhSachMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.danhSachMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachMonHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachMonHoc.ColumnHeadersHeight = 18;
            this.danhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoMonHoc,
            this.TenMonHoc,
            this.SoTinChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachMonHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachMonHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachMonHoc.Location = new System.Drawing.Point(28, 90);
            this.danhSachMonHoc.Name = "danhSachMonHoc";
            this.danhSachMonHoc.RowHeadersVisible = false;
            this.danhSachMonHoc.RowHeadersWidth = 51;
            this.danhSachMonHoc.RowTemplate.Height = 24;
            this.danhSachMonHoc.Size = new System.Drawing.Size(752, 395);
            this.danhSachMonHoc.TabIndex = 45;
            this.danhSachMonHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachMonHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachMonHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachMonHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachMonHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachMonHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachMonHoc.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachMonHoc.ThemeStyle.ReadOnly = false;
            this.danhSachMonHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachMonHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachMonHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachMonHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachMonHoc.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachMonHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachMonHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachMonHoc_CellClick);
            // 
            // MaSoMonHoc
            // 
            this.MaSoMonHoc.HeaderText = "MaSoMonHoc";
            this.MaSoMonHoc.MinimumWidth = 6;
            this.MaSoMonHoc.Name = "MaSoMonHoc";
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.HeaderText = "TenMonHoc";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            // 
            // SoTinChi
            // 
            this.SoTinChi.HeaderText = "SoTinChi";
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            // 
            // chinhSuaMonHocButton
            // 
            this.chinhSuaMonHocButton.BorderRadius = 10;
            this.chinhSuaMonHocButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chinhSuaMonHocButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chinhSuaMonHocButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chinhSuaMonHocButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chinhSuaMonHocButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.chinhSuaMonHocButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chinhSuaMonHocButton.ForeColor = System.Drawing.Color.White;
            this.chinhSuaMonHocButton.Location = new System.Drawing.Point(410, 53);
            this.chinhSuaMonHocButton.Name = "chinhSuaMonHocButton";
            this.chinhSuaMonHocButton.Size = new System.Drawing.Size(185, 31);
            this.chinhSuaMonHocButton.TabIndex = 44;
            this.chinhSuaMonHocButton.Text = "Lưu chỉnh sửa";
            this.chinhSuaMonHocButton.Click += new System.EventHandler(this.chinhSuaMonHocButton_Click);
            // 
            // xoaMonHocButton
            // 
            this.xoaMonHocButton.BorderRadius = 10;
            this.xoaMonHocButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoaMonHocButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoaMonHocButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoaMonHocButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoaMonHocButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.xoaMonHocButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xoaMonHocButton.ForeColor = System.Drawing.Color.White;
            this.xoaMonHocButton.Location = new System.Drawing.Point(219, 53);
            this.xoaMonHocButton.Name = "xoaMonHocButton";
            this.xoaMonHocButton.Size = new System.Drawing.Size(185, 31);
            this.xoaMonHocButton.TabIndex = 43;
            this.xoaMonHocButton.Text = "Xóa môn học";
            this.xoaMonHocButton.Click += new System.EventHandler(this.xoaMonHocButton_Click);
            // 
            // theMonHocButton
            // 
            this.theMonHocButton.BorderRadius = 10;
            this.theMonHocButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.theMonHocButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.theMonHocButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.theMonHocButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.theMonHocButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.theMonHocButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.theMonHocButton.ForeColor = System.Drawing.Color.White;
            this.theMonHocButton.Location = new System.Drawing.Point(28, 53);
            this.theMonHocButton.Name = "theMonHocButton";
            this.theMonHocButton.Size = new System.Drawing.Size(185, 31);
            this.theMonHocButton.TabIndex = 42;
            this.theMonHocButton.Text = "Thêm môn học";
            this.theMonHocButton.Click += new System.EventHandler(this.theMonHocButton_Click);
            // 
            // questionDialog
            // 
            this.questionDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.questionDialog.Caption = "Confirm";
            this.questionDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.questionDialog.Parent = null;
            this.questionDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.questionDialog.Text = null;
            // 
            // errorDialog
            // 
            this.errorDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.errorDialog.Caption = "Error";
            this.errorDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.errorDialog.Parent = null;
            this.errorDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.errorDialog.Text = null;
            // 
            // successDialog
            // 
            this.successDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successDialog.Caption = null;
            this.successDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successDialog.Parent = null;
            this.successDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.successDialog.Text = null;
            // 
            // warningMessage
            // 
            this.warningMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.warningMessage.Caption = "Warning";
            this.warningMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.warningMessage.Parent = null;
            this.warningMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.warningMessage.Text = null;
            // 
            // resetButton
            // 
            this.resetButton.BorderRadius = 10;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(166)))), ((int)(((byte)(178)))));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(601, 53);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(179, 31);
            this.resetButton.TabIndex = 46;
            this.resetButton.Text = "Đặt lại";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // doKhoInput
            // 
            this.doKhoInput.BackColor = System.Drawing.Color.Transparent;
            this.doKhoInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.doKhoInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doKhoInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doKhoInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.doKhoInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.doKhoInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.doKhoInput.ItemHeight = 30;
            this.doKhoInput.Items.AddRange(new object[] {
            "Độ khó 0",
            "Độ khó 1",
            "Độ khó 2",
            "Độ khó 3",
            "Độ khó 4",
            "Độ khó 5"});
            this.doKhoInput.Location = new System.Drawing.Point(601, 5);
            this.doKhoInput.Name = "doKhoInput";
            this.doKhoInput.Size = new System.Drawing.Size(179, 36);
            this.doKhoInput.TabIndex = 47;
            this.doKhoInput.SelectedIndexChanged += new System.EventHandler(this.doKhoInput_SelectedIndexChanged);
            // 
            // soTinChiInput
            // 
            this.soTinChiInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soTinChiInput.DefaultText = "";
            this.soTinChiInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soTinChiInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soTinChiInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soTinChiInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soTinChiInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soTinChiInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soTinChiInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soTinChiInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.star;
            this.soTinChiInput.Location = new System.Drawing.Point(410, 5);
            this.soTinChiInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.soTinChiInput.Name = "soTinChiInput";
            this.soTinChiInput.PasswordChar = '\0';
            this.soTinChiInput.PlaceholderText = "Số tín chỉ";
            this.soTinChiInput.SelectedText = "";
            this.soTinChiInput.Size = new System.Drawing.Size(185, 36);
            this.soTinChiInput.TabIndex = 41;
            this.soTinChiInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soTinChiInput_KeyPress);
            // 
            // tenMonHocInput
            // 
            this.tenMonHocInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tenMonHocInput.DefaultText = "";
            this.tenMonHocInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tenMonHocInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tenMonHocInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenMonHocInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenMonHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenMonHocInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tenMonHocInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenMonHocInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.learning__2_;
            this.tenMonHocInput.Location = new System.Drawing.Point(219, 5);
            this.tenMonHocInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tenMonHocInput.Name = "tenMonHocInput";
            this.tenMonHocInput.PasswordChar = '\0';
            this.tenMonHocInput.PlaceholderText = "Tên môn học";
            this.tenMonHocInput.SelectedText = "";
            this.tenMonHocInput.Size = new System.Drawing.Size(185, 36);
            this.tenMonHocInput.TabIndex = 40;
            // 
            // maMonHocInput
            // 
            this.maMonHocInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maMonHocInput.DefaultText = "";
            this.maMonHocInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maMonHocInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maMonHocInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maMonHocInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maMonHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maMonHocInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maMonHocInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maMonHocInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.id;
            this.maMonHocInput.Location = new System.Drawing.Point(28, 5);
            this.maMonHocInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.maMonHocInput.Name = "maMonHocInput";
            this.maMonHocInput.PasswordChar = '\0';
            this.maMonHocInput.PlaceholderText = "Mã môn học";
            this.maMonHocInput.SelectedText = "";
            this.maMonHocInput.Size = new System.Drawing.Size(185, 36);
            this.maMonHocInput.TabIndex = 39;
            // 
            // QuanLyMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.doKhoInput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.danhSachMonHoc);
            this.Controls.Add(this.chinhSuaMonHocButton);
            this.Controls.Add(this.xoaMonHocButton);
            this.Controls.Add(this.theMonHocButton);
            this.Controls.Add(this.soTinChiInput);
            this.Controls.Add(this.tenMonHocInput);
            this.Controls.Add(this.maMonHocInput);
            this.Name = "QuanLyMonHocForm";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.QuanLyMonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView danhSachMonHoc;
        private Guna.UI2.WinForms.Guna2Button chinhSuaMonHocButton;
        private Guna.UI2.WinForms.Guna2Button xoaMonHocButton;
        private Guna.UI2.WinForms.Guna2Button theMonHocButton;
        private Guna.UI2.WinForms.Guna2TextBox soTinChiInput;
        private Guna.UI2.WinForms.Guna2TextBox tenMonHocInput;
        private Guna.UI2.WinForms.Guna2TextBox maMonHocInput;
        private Guna.UI2.WinForms.Guna2MessageDialog questionDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningMessage;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private Guna.UI2.WinForms.Guna2ComboBox doKhoInput;
    }
}
