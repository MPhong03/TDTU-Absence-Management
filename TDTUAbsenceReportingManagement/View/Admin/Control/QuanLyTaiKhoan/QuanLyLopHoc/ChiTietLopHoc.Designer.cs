namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyLopHoc
{
    partial class ChiTietLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.caDayInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.monHocInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ngayDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.danhSachNgayDay = new Guna.UI2.WinForms.Guna2DataGridView();
            this.themNgayDay = new Guna.UI2.WinForms.Guna2Button();
            this.xoaNgayDay = new Guna.UI2.WinForms.Guna2Button();
            this.themSVVaoLop = new Guna.UI2.WinForms.Guna2Button();
            this.xoaSVKhoiLop = new Guna.UI2.WinForms.Guna2Button();
            this.importCSVMaSoSinhVien = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachSinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSoSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themLopHocButton = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.luuChinhSuaButton = new Guna.UI2.WinForms.Guna2Button();
            this.giangVienPhuTrachInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.hoVaTenSVInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.maSoSVInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.phongHocInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.toHocInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.nhomHocInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.soBuoiDayInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.maLopDayInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.questionDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.NgayDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNgayDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // caDayInput
            // 
            this.caDayInput.BackColor = System.Drawing.Color.Transparent;
            this.caDayInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.caDayInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caDayInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caDayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caDayInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.caDayInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.caDayInput.ItemHeight = 30;
            this.caDayInput.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4",
            "Ca 5"});
            this.caDayInput.Location = new System.Drawing.Point(212, 161);
            this.caDayInput.Name = "caDayInput";
            this.caDayInput.Size = new System.Drawing.Size(185, 36);
            this.caDayInput.TabIndex = 22;
            // 
            // monHocInput
            // 
            this.monHocInput.BackColor = System.Drawing.Color.Transparent;
            this.monHocInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monHocInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monHocInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monHocInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monHocInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.monHocInput.ItemHeight = 30;
            this.monHocInput.Location = new System.Drawing.Point(15, 107);
            this.monHocInput.Name = "monHocInput";
            this.monHocInput.Size = new System.Drawing.Size(382, 36);
            this.monHocInput.TabIndex = 23;
            // 
            // ngayDay
            // 
            this.ngayDay.Checked = true;
            this.ngayDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngayDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ngayDay.Location = new System.Drawing.Point(15, 206);
            this.ngayDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngayDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngayDay.Name = "ngayDay";
            this.ngayDay.Size = new System.Drawing.Size(382, 36);
            this.ngayDay.TabIndex = 24;
            this.ngayDay.Value = new System.DateTime(2024, 4, 23, 14, 11, 1, 148);
            // 
            // danhSachNgayDay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.danhSachNgayDay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachNgayDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachNgayDay.ColumnHeadersHeight = 18;
            this.danhSachNgayDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachNgayDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayDayColumn,
            this.CaDay,
            this.Phong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachNgayDay.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachNgayDay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachNgayDay.Location = new System.Drawing.Point(410, 161);
            this.danhSachNgayDay.Name = "danhSachNgayDay";
            this.danhSachNgayDay.RowHeadersVisible = false;
            this.danhSachNgayDay.RowHeadersWidth = 51;
            this.danhSachNgayDay.RowTemplate.Height = 24;
            this.danhSachNgayDay.Size = new System.Drawing.Size(382, 118);
            this.danhSachNgayDay.TabIndex = 25;
            this.danhSachNgayDay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachNgayDay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachNgayDay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachNgayDay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachNgayDay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachNgayDay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachNgayDay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachNgayDay.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachNgayDay.ThemeStyle.ReadOnly = false;
            this.danhSachNgayDay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachNgayDay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachNgayDay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachNgayDay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachNgayDay.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachNgayDay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachNgayDay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachNgayDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachNgayDay_CellClick);
            // 
            // themNgayDay
            // 
            this.themNgayDay.BorderRadius = 10;
            this.themNgayDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themNgayDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themNgayDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themNgayDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themNgayDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.themNgayDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.themNgayDay.ForeColor = System.Drawing.Color.White;
            this.themNgayDay.Location = new System.Drawing.Point(15, 248);
            this.themNgayDay.Name = "themNgayDay";
            this.themNgayDay.Size = new System.Drawing.Size(185, 31);
            this.themNgayDay.TabIndex = 26;
            this.themNgayDay.Text = "Thêm ngày dạy";
            this.themNgayDay.Click += new System.EventHandler(this.themNgayDay_Click);
            // 
            // xoaNgayDay
            // 
            this.xoaNgayDay.BorderRadius = 10;
            this.xoaNgayDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoaNgayDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoaNgayDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoaNgayDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoaNgayDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.xoaNgayDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xoaNgayDay.ForeColor = System.Drawing.Color.White;
            this.xoaNgayDay.Location = new System.Drawing.Point(212, 248);
            this.xoaNgayDay.Name = "xoaNgayDay";
            this.xoaNgayDay.Size = new System.Drawing.Size(185, 31);
            this.xoaNgayDay.TabIndex = 27;
            this.xoaNgayDay.Text = "Xóa";
            this.xoaNgayDay.Click += new System.EventHandler(this.xoaNgayDay_Click);
            // 
            // themSVVaoLop
            // 
            this.themSVVaoLop.BorderRadius = 10;
            this.themSVVaoLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themSVVaoLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themSVVaoLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themSVVaoLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themSVVaoLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.themSVVaoLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.themSVVaoLop.ForeColor = System.Drawing.Color.White;
            this.themSVVaoLop.Location = new System.Drawing.Point(15, 379);
            this.themSVVaoLop.Name = "themSVVaoLop";
            this.themSVVaoLop.Size = new System.Drawing.Size(382, 31);
            this.themSVVaoLop.TabIndex = 30;
            this.themSVVaoLop.Text = "Thêm sinh viên vào lớp";
            this.themSVVaoLop.Click += new System.EventHandler(this.themSVVaoLop_Click);
            // 
            // xoaSVKhoiLop
            // 
            this.xoaSVKhoiLop.BorderRadius = 10;
            this.xoaSVKhoiLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xoaSVKhoiLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xoaSVKhoiLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xoaSVKhoiLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xoaSVKhoiLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(101)))), ((int)(((byte)(98)))));
            this.xoaSVKhoiLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xoaSVKhoiLop.ForeColor = System.Drawing.Color.White;
            this.xoaSVKhoiLop.Location = new System.Drawing.Point(15, 416);
            this.xoaSVKhoiLop.Name = "xoaSVKhoiLop";
            this.xoaSVKhoiLop.Size = new System.Drawing.Size(382, 31);
            this.xoaSVKhoiLop.TabIndex = 31;
            this.xoaSVKhoiLop.Text = "Xóa sinh viên khỏi lớp";
            this.xoaSVKhoiLop.Click += new System.EventHandler(this.xoaSVKhoiLop_Click);
            // 
            // importCSVMaSoSinhVien
            // 
            this.importCSVMaSoSinhVien.BorderRadius = 10;
            this.importCSVMaSoSinhVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.importCSVMaSoSinhVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.importCSVMaSoSinhVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.importCSVMaSoSinhVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.importCSVMaSoSinhVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.importCSVMaSoSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.importCSVMaSoSinhVien.ForeColor = System.Drawing.Color.White;
            this.importCSVMaSoSinhVien.Location = new System.Drawing.Point(15, 453);
            this.importCSVMaSoSinhVien.Name = "importCSVMaSoSinhVien";
            this.importCSVMaSoSinhVien.Size = new System.Drawing.Size(382, 31);
            this.importCSVMaSoSinhVien.TabIndex = 32;
            this.importCSVMaSoSinhVien.Text = "Import CSV - Mã số sinh viên";
            this.importCSVMaSoSinhVien.Click += new System.EventHandler(this.importCSVMaSoSinhVien_Click);
            // 
            // danhSachSinhVien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.danhSachSinhVien.ColumnHeadersHeight = 18;
            this.danhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoSinhVien,
            this.HoVaTen});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachSinhVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.danhSachSinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVien.Location = new System.Drawing.Point(410, 299);
            this.danhSachSinhVien.Name = "danhSachSinhVien";
            this.danhSachSinhVien.RowHeadersVisible = false;
            this.danhSachSinhVien.RowHeadersWidth = 51;
            this.danhSachSinhVien.RowTemplate.Height = 24;
            this.danhSachSinhVien.Size = new System.Drawing.Size(382, 185);
            this.danhSachSinhVien.TabIndex = 33;
            this.danhSachSinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachSinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachSinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachSinhVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachSinhVien.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachSinhVien.ThemeStyle.ReadOnly = false;
            this.danhSachSinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachSinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachSinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachSinhVien.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachSinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachSinhVien_CellClick);
            // 
            // MaSoSinhVien
            // 
            this.MaSoSinhVien.HeaderText = "Mã Số Sinh Viên";
            this.MaSoSinhVien.MinimumWidth = 6;
            this.MaSoSinhVien.Name = "MaSoSinhVien";
            // 
            // HoVaTen
            // 
            this.HoVaTen.HeaderText = "Họ Và Tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            // 
            // themLopHocButton
            // 
            this.themLopHocButton.BorderRadius = 10;
            this.themLopHocButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themLopHocButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themLopHocButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themLopHocButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themLopHocButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.themLopHocButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.themLopHocButton.ForeColor = System.Drawing.Color.White;
            this.themLopHocButton.Location = new System.Drawing.Point(15, 490);
            this.themLopHocButton.Name = "themLopHocButton";
            this.themLopHocButton.Size = new System.Drawing.Size(250, 31);
            this.themLopHocButton.TabIndex = 34;
            this.themLopHocButton.Text = "Thêm lớp học";
            this.themLopHocButton.Click += new System.EventHandler(this.themLopHocButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(542, 490);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(250, 31);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // luuChinhSuaButton
            // 
            this.luuChinhSuaButton.BorderRadius = 10;
            this.luuChinhSuaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.luuChinhSuaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.luuChinhSuaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.luuChinhSuaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.luuChinhSuaButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.luuChinhSuaButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.luuChinhSuaButton.ForeColor = System.Drawing.Color.White;
            this.luuChinhSuaButton.Location = new System.Drawing.Point(271, 490);
            this.luuChinhSuaButton.Name = "luuChinhSuaButton";
            this.luuChinhSuaButton.Size = new System.Drawing.Size(265, 31);
            this.luuChinhSuaButton.TabIndex = 36;
            this.luuChinhSuaButton.Text = "Lưu chỉnh sửa";
            this.luuChinhSuaButton.Click += new System.EventHandler(this.luuChinhSuaButton_Click);
            // 
            // giangVienPhuTrachInput
            // 
            this.giangVienPhuTrachInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.giangVienPhuTrachInput.DefaultText = "";
            this.giangVienPhuTrachInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.giangVienPhuTrachInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.giangVienPhuTrachInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.giangVienPhuTrachInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.giangVienPhuTrachInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giangVienPhuTrachInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.giangVienPhuTrachInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giangVienPhuTrachInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.image__4_;
            this.giangVienPhuTrachInput.Location = new System.Drawing.Point(410, 25);
            this.giangVienPhuTrachInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.giangVienPhuTrachInput.Name = "giangVienPhuTrachInput";
            this.giangVienPhuTrachInput.PasswordChar = '\0';
            this.giangVienPhuTrachInput.PlaceholderText = "Giảng viên phụ trách";
            this.giangVienPhuTrachInput.SelectedText = "";
            this.giangVienPhuTrachInput.Size = new System.Drawing.Size(382, 36);
            this.giangVienPhuTrachInput.TabIndex = 37;
            // 
            // hoVaTenSVInput
            // 
            this.hoVaTenSVInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hoVaTenSVInput.DefaultText = "";
            this.hoVaTenSVInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hoVaTenSVInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hoVaTenSVInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hoVaTenSVInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hoVaTenSVInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hoVaTenSVInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hoVaTenSVInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hoVaTenSVInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.user;
            this.hoVaTenSVInput.Location = new System.Drawing.Point(15, 340);
            this.hoVaTenSVInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.hoVaTenSVInput.Name = "hoVaTenSVInput";
            this.hoVaTenSVInput.PasswordChar = '\0';
            this.hoVaTenSVInput.PlaceholderText = "Họ và tên";
            this.hoVaTenSVInput.SelectedText = "";
            this.hoVaTenSVInput.Size = new System.Drawing.Size(382, 36);
            this.hoVaTenSVInput.TabIndex = 29;
            // 
            // maSoSVInput
            // 
            this.maSoSVInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maSoSVInput.DefaultText = "";
            this.maSoSVInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maSoSVInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maSoSVInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maSoSVInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maSoSVInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maSoSVInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maSoSVInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maSoSVInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.id;
            this.maSoSVInput.Location = new System.Drawing.Point(15, 299);
            this.maSoSVInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.maSoSVInput.Name = "maSoSVInput";
            this.maSoSVInput.PasswordChar = '\0';
            this.maSoSVInput.PlaceholderText = "Mã số sinh viên";
            this.maSoSVInput.SelectedText = "";
            this.maSoSVInput.Size = new System.Drawing.Size(382, 36);
            this.maSoSVInput.TabIndex = 28;
            // 
            // phongHocInput
            // 
            this.phongHocInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phongHocInput.DefaultText = "";
            this.phongHocInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phongHocInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phongHocInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongHocInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phongHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongHocInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phongHocInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phongHocInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.image__3_;
            this.phongHocInput.Location = new System.Drawing.Point(15, 161);
            this.phongHocInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.phongHocInput.Name = "phongHocInput";
            this.phongHocInput.PasswordChar = '\0';
            this.phongHocInput.PlaceholderText = "Phòng";
            this.phongHocInput.SelectedText = "";
            this.phongHocInput.Size = new System.Drawing.Size(185, 39);
            this.phongHocInput.TabIndex = 20;
            // 
            // toHocInput
            // 
            this.toHocInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toHocInput.DefaultText = "";
            this.toHocInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.toHocInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.toHocInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.toHocInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.toHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toHocInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toHocInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toHocInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.image__2_;
            this.toHocInput.Location = new System.Drawing.Point(410, 66);
            this.toHocInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toHocInput.Name = "toHocInput";
            this.toHocInput.PasswordChar = '\0';
            this.toHocInput.PlaceholderText = "Tổ";
            this.toHocInput.SelectedText = "";
            this.toHocInput.Size = new System.Drawing.Size(382, 36);
            this.toHocInput.TabIndex = 19;
            // 
            // nhomHocInput
            // 
            this.nhomHocInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nhomHocInput.DefaultText = "";
            this.nhomHocInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nhomHocInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nhomHocInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nhomHocInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nhomHocInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nhomHocInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nhomHocInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nhomHocInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.image__1_;
            this.nhomHocInput.Location = new System.Drawing.Point(15, 66);
            this.nhomHocInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.nhomHocInput.Name = "nhomHocInput";
            this.nhomHocInput.PasswordChar = '\0';
            this.nhomHocInput.PlaceholderText = "Nhóm";
            this.nhomHocInput.SelectedText = "";
            this.nhomHocInput.Size = new System.Drawing.Size(382, 36);
            this.nhomHocInput.TabIndex = 18;
            // 
            // soBuoiDayInput
            // 
            this.soBuoiDayInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soBuoiDayInput.DefaultText = "";
            this.soBuoiDayInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soBuoiDayInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soBuoiDayInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soBuoiDayInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soBuoiDayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soBuoiDayInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soBuoiDayInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soBuoiDayInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.image;
            this.soBuoiDayInput.Location = new System.Drawing.Point(410, 107);
            this.soBuoiDayInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.soBuoiDayInput.Name = "soBuoiDayInput";
            this.soBuoiDayInput.PasswordChar = '\0';
            this.soBuoiDayInput.PlaceholderText = "Số buổi dạy";
            this.soBuoiDayInput.SelectedText = "";
            this.soBuoiDayInput.Size = new System.Drawing.Size(382, 36);
            this.soBuoiDayInput.TabIndex = 17;
            // 
            // maLopDayInput
            // 
            this.maLopDayInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maLopDayInput.DefaultText = "";
            this.maLopDayInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.maLopDayInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.maLopDayInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maLopDayInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.maLopDayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maLopDayInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maLopDayInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maLopDayInput.IconLeft = global::TDTUAbsenceReportingManagement.Properties.Resources.id;
            this.maLopDayInput.Location = new System.Drawing.Point(15, 25);
            this.maLopDayInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.maLopDayInput.Name = "maLopDayInput";
            this.maLopDayInput.PasswordChar = '\0';
            this.maLopDayInput.PlaceholderText = "Mã lớp học";
            this.maLopDayInput.SelectedText = "";
            this.maLopDayInput.Size = new System.Drawing.Size(382, 36);
            this.maLopDayInput.TabIndex = 16;
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
            // questionDialog
            // 
            this.questionDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.questionDialog.Caption = "Confirm";
            this.questionDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.questionDialog.Parent = null;
            this.questionDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.questionDialog.Text = null;
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
            // NgayDayColumn
            // 
            this.NgayDayColumn.HeaderText = "Ngày dạy";
            this.NgayDayColumn.MinimumWidth = 6;
            this.NgayDayColumn.Name = "NgayDayColumn";
            // 
            // CaDay
            // 
            this.CaDay.HeaderText = "Ca Dạy";
            this.CaDay.MinimumWidth = 6;
            this.CaDay.Name = "CaDay";
            // 
            // Phong
            // 
            this.Phong.HeaderText = "Phòng";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            // 
            // ChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.giangVienPhuTrachInput);
            this.Controls.Add(this.luuChinhSuaButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.themLopHocButton);
            this.Controls.Add(this.danhSachSinhVien);
            this.Controls.Add(this.importCSVMaSoSinhVien);
            this.Controls.Add(this.xoaSVKhoiLop);
            this.Controls.Add(this.themSVVaoLop);
            this.Controls.Add(this.hoVaTenSVInput);
            this.Controls.Add(this.maSoSVInput);
            this.Controls.Add(this.xoaNgayDay);
            this.Controls.Add(this.themNgayDay);
            this.Controls.Add(this.danhSachNgayDay);
            this.Controls.Add(this.ngayDay);
            this.Controls.Add(this.monHocInput);
            this.Controls.Add(this.caDayInput);
            this.Controls.Add(this.phongHocInput);
            this.Controls.Add(this.toHocInput);
            this.Controls.Add(this.nhomHocInput);
            this.Controls.Add(this.soBuoiDayInput);
            this.Controls.Add(this.maLopDayInput);
            this.Name = "ChiTietLopHoc";
            this.Size = new System.Drawing.Size(808, 543);
            this.Load += new System.EventHandler(this.ThemLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNgayDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox maLopDayInput;
        private Guna.UI2.WinForms.Guna2TextBox soBuoiDayInput;
        private Guna.UI2.WinForms.Guna2TextBox nhomHocInput;
        private Guna.UI2.WinForms.Guna2TextBox toHocInput;
        private Guna.UI2.WinForms.Guna2TextBox phongHocInput;
        private Guna.UI2.WinForms.Guna2ComboBox caDayInput;
        private Guna.UI2.WinForms.Guna2ComboBox monHocInput;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngayDay;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachNgayDay;
        private Guna.UI2.WinForms.Guna2Button themNgayDay;
        private Guna.UI2.WinForms.Guna2Button xoaNgayDay;
        private Guna.UI2.WinForms.Guna2TextBox maSoSVInput;
        private Guna.UI2.WinForms.Guna2TextBox hoVaTenSVInput;
        private Guna.UI2.WinForms.Guna2Button themSVVaoLop;
        private Guna.UI2.WinForms.Guna2Button xoaSVKhoiLop;
        private Guna.UI2.WinForms.Guna2Button importCSVMaSoSinhVien;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachSinhVien;
        private Guna.UI2.WinForms.Guna2Button themLopHocButton;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button luuChinhSuaButton;
        private Guna.UI2.WinForms.Guna2TextBox giangVienPhuTrachInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog questionDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
    }
}
