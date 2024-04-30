namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    partial class GuiBaoVangControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ngayDayInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.danhSachLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lyDoBaoVangInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.guiYeuCauBVButton = new Guna.UI2.WinForms.Guna2Button();
            this.maxLengthOfText = new System.Windows.Forms.Label();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.maLopDayInput = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayDayInput
            // 
            this.ngayDayInput.BackColor = System.Drawing.Color.Transparent;
            this.ngayDayInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ngayDayInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ngayDayInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ngayDayInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ngayDayInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ngayDayInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ngayDayInput.ItemHeight = 30;
            this.ngayDayInput.Location = new System.Drawing.Point(408, 17);
            this.ngayDayInput.Name = "ngayDayInput";
            this.ngayDayInput.Size = new System.Drawing.Size(387, 36);
            this.ngayDayInput.TabIndex = 18;
            // 
            // danhSachLopHoc
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.danhSachLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.danhSachLopHoc.ColumnHeadersHeight = 18;
            this.danhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachLopHoc.DefaultCellStyle = dataGridViewCellStyle6;
            this.danhSachLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachLopHoc.Location = new System.Drawing.Point(14, 65);
            this.danhSachLopHoc.Name = "danhSachLopHoc";
            this.danhSachLopHoc.RowHeadersVisible = false;
            this.danhSachLopHoc.RowHeadersWidth = 51;
            this.danhSachLopHoc.RowTemplate.Height = 24;
            this.danhSachLopHoc.Size = new System.Drawing.Size(781, 150);
            this.danhSachLopHoc.TabIndex = 19;
            this.danhSachLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachLopHoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachLopHoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachLopHoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachLopHoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachLopHoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachLopHoc.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachLopHoc.ThemeStyle.ReadOnly = false;
            this.danhSachLopHoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachLopHoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachLopHoc.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachLopHoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachLopHoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachLopHoc_CellClick);
            // 
            // lyDoBaoVangInput
            // 
            this.lyDoBaoVangInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lyDoBaoVangInput.DefaultText = "";
            this.lyDoBaoVangInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lyDoBaoVangInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lyDoBaoVangInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lyDoBaoVangInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lyDoBaoVangInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lyDoBaoVangInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lyDoBaoVangInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lyDoBaoVangInput.Location = new System.Drawing.Point(14, 231);
            this.lyDoBaoVangInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lyDoBaoVangInput.Multiline = true;
            this.lyDoBaoVangInput.Name = "lyDoBaoVangInput";
            this.lyDoBaoVangInput.PasswordChar = '\0';
            this.lyDoBaoVangInput.PlaceholderText = "Lý do vắng buổi dạy...";
            this.lyDoBaoVangInput.SelectedText = "";
            this.lyDoBaoVangInput.Size = new System.Drawing.Size(781, 203);
            this.lyDoBaoVangInput.TabIndex = 20;
            this.lyDoBaoVangInput.TextChanged += new System.EventHandler(this.lyDoBaoVangInput_TextChanged);
            this.lyDoBaoVangInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lyDoBaoVangInput_KeyPress);
            // 
            // cancelButton
            // 
            this.cancelButton.BorderRadius = 10;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(27)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(408, 450);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(387, 40);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Hủy";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // guiYeuCauBVButton
            // 
            this.guiYeuCauBVButton.BorderRadius = 10;
            this.guiYeuCauBVButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guiYeuCauBVButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guiYeuCauBVButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guiYeuCauBVButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guiYeuCauBVButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.guiYeuCauBVButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guiYeuCauBVButton.ForeColor = System.Drawing.Color.White;
            this.guiYeuCauBVButton.Location = new System.Drawing.Point(14, 450);
            this.guiYeuCauBVButton.Name = "guiYeuCauBVButton";
            this.guiYeuCauBVButton.Size = new System.Drawing.Size(382, 40);
            this.guiYeuCauBVButton.TabIndex = 26;
            this.guiYeuCauBVButton.Text = "Thêm";
            this.guiYeuCauBVButton.Click += new System.EventHandler(this.guiYeuCauBVButton_Click);
            // 
            // maxLengthOfText
            // 
            this.maxLengthOfText.AutoSize = true;
            this.maxLengthOfText.BackColor = System.Drawing.Color.White;
            this.maxLengthOfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maxLengthOfText.Location = new System.Drawing.Point(700, 404);
            this.maxLengthOfText.Name = "maxLengthOfText";
            this.maxLengthOfText.Size = new System.Drawing.Size(84, 25);
            this.maxLengthOfText.TabIndex = 28;
            this.maxLengthOfText.Text = "000/500";
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
            this.maLopDayInput.Location = new System.Drawing.Point(14, 17);
            this.maLopDayInput.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.maLopDayInput.Name = "maLopDayInput";
            this.maLopDayInput.PasswordChar = '\0';
            this.maLopDayInput.PlaceholderText = "Mã lớp học";
            this.maLopDayInput.SelectedText = "";
            this.maLopDayInput.Size = new System.Drawing.Size(382, 45);
            this.maLopDayInput.TabIndex = 17;
            // 
            // GuiBaoVangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxLengthOfText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.guiYeuCauBVButton);
            this.Controls.Add(this.lyDoBaoVangInput);
            this.Controls.Add(this.danhSachLopHoc);
            this.Controls.Add(this.ngayDayInput);
            this.Controls.Add(this.maLopDayInput);
            this.Name = "GuiBaoVangControl";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.GuiBaoVangControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox maLopDayInput;
        private Guna.UI2.WinForms.Guna2ComboBox ngayDayInput;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachLopHoc;
        private Guna.UI2.WinForms.Guna2TextBox lyDoBaoVangInput;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2Button guiYeuCauBVButton;
        private System.Windows.Forms.Label maxLengthOfText;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningDialog;
    }
}
