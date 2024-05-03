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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xoaYeuCauButton = new Guna.UI2.WinForms.Guna2Button();
            this.themYeuCauBVButton = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachYeuCauBaoVang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.successDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.warningDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.baoBuButton = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachYeuCauBaoBu = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoVang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoBu)).BeginInit();
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
            this.xoaYeuCauButton.Location = new System.Drawing.Point(539, 17);
            this.xoaYeuCauButton.Name = "xoaYeuCauButton";
            this.xoaYeuCauButton.Size = new System.Drawing.Size(252, 31);
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
            this.themYeuCauBVButton.Size = new System.Drawing.Size(257, 31);
            this.themYeuCauBVButton.TabIndex = 47;
            this.themYeuCauBVButton.Text = "Báo vắng";
            this.themYeuCauBVButton.Click += new System.EventHandler(this.themYeuCauBVButton_Click);
            // 
            // danhSachYeuCauBaoVang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoVang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.danhSachYeuCauBaoVang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachYeuCauBaoVang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachYeuCauBaoVang.ColumnHeadersHeight = 18;
            this.danhSachYeuCauBaoVang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachYeuCauBaoVang.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachYeuCauBaoVang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoVang.Location = new System.Drawing.Point(13, 54);
            this.danhSachYeuCauBaoVang.Name = "danhSachYeuCauBaoVang";
            this.danhSachYeuCauBaoVang.RowHeadersVisible = false;
            this.danhSachYeuCauBaoVang.RowHeadersWidth = 51;
            this.danhSachYeuCauBaoVang.RowTemplate.Height = 24;
            this.danhSachYeuCauBaoVang.Size = new System.Drawing.Size(778, 209);
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
            // baoBuButton
            // 
            this.baoBuButton.BorderRadius = 10;
            this.baoBuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baoBuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baoBuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baoBuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baoBuButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.baoBuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baoBuButton.ForeColor = System.Drawing.Color.White;
            this.baoBuButton.Location = new System.Drawing.Point(276, 17);
            this.baoBuButton.Name = "baoBuButton";
            this.baoBuButton.Size = new System.Drawing.Size(257, 31);
            this.baoBuButton.TabIndex = 50;
            this.baoBuButton.Text = "Báo bù";
            this.baoBuButton.Click += new System.EventHandler(this.baoBuButton_Click);
            // 
            // danhSachYeuCauBaoBu
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoBu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.danhSachYeuCauBaoBu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachYeuCauBaoBu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.danhSachYeuCauBaoBu.ColumnHeadersHeight = 18;
            this.danhSachYeuCauBaoBu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachYeuCauBaoBu.DefaultCellStyle = dataGridViewCellStyle6;
            this.danhSachYeuCauBaoBu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoBu.Location = new System.Drawing.Point(13, 269);
            this.danhSachYeuCauBaoBu.Name = "danhSachYeuCauBaoBu";
            this.danhSachYeuCauBaoBu.RowHeadersVisible = false;
            this.danhSachYeuCauBaoBu.RowHeadersWidth = 51;
            this.danhSachYeuCauBaoBu.RowTemplate.Height = 24;
            this.danhSachYeuCauBaoBu.Size = new System.Drawing.Size(778, 209);
            this.danhSachYeuCauBaoBu.TabIndex = 51;
            this.danhSachYeuCauBaoBu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoBu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachYeuCauBaoBu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoBu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoBu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachYeuCauBaoBu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoBu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachYeuCauBaoBu.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachYeuCauBaoBu.ThemeStyle.ReadOnly = false;
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachYeuCauBaoBu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // YeuCauBaoVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.danhSachYeuCauBaoBu);
            this.Controls.Add(this.baoBuButton);
            this.Controls.Add(this.danhSachYeuCauBaoVang);
            this.Controls.Add(this.xoaYeuCauButton);
            this.Controls.Add(this.themYeuCauBVButton);
            this.Name = "YeuCauBaoVang";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.YeuCauBaoVang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoVang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachYeuCauBaoBu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button xoaYeuCauButton;
        private Guna.UI2.WinForms.Guna2Button themYeuCauBVButton;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachYeuCauBaoVang;
        private Guna.UI2.WinForms.Guna2MessageDialog successDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog errorDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog warningDialog;
        private Guna.UI2.WinForms.Guna2Button baoBuButton;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachYeuCauBaoBu;
    }
}
