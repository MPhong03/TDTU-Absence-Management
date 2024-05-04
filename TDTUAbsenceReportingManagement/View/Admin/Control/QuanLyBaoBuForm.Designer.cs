namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    partial class QuanLyBaoBuForm
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
            this.giangVienFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.trangThaiFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.danhSachBaoBu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBaoBu)).BeginInit();
            this.SuspendLayout();
            // 
            // giangVienFilter
            // 
            this.giangVienFilter.BackColor = System.Drawing.Color.Transparent;
            this.giangVienFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.giangVienFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.giangVienFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giangVienFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giangVienFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.giangVienFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.giangVienFilter.ItemHeight = 30;
            this.giangVienFilter.Location = new System.Drawing.Point(372, 18);
            this.giangVienFilter.Name = "giangVienFilter";
            this.giangVienFilter.Size = new System.Drawing.Size(350, 36);
            this.giangVienFilter.TabIndex = 6;
            this.giangVienFilter.SelectedIndexChanged += new System.EventHandler(this.giangVienFilter_SelectedIndexChanged);
            // 
            // trangThaiFilter
            // 
            this.trangThaiFilter.BackColor = System.Drawing.Color.Transparent;
            this.trangThaiFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.trangThaiFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trangThaiFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trangThaiFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trangThaiFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.trangThaiFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.trangThaiFilter.ItemHeight = 30;
            this.trangThaiFilter.Items.AddRange(new object[] {
            "TẤT CẢ",
            "CHƯA XỬ LÝ",
            "ĐỒNG Ý",
            "TỪ CHỐI"});
            this.trangThaiFilter.Location = new System.Drawing.Point(16, 18);
            this.trangThaiFilter.Name = "trangThaiFilter";
            this.trangThaiFilter.Size = new System.Drawing.Size(350, 36);
            this.trangThaiFilter.TabIndex = 5;
            this.trangThaiFilter.SelectedIndexChanged += new System.EventHandler(this.trangThaiFilter_SelectedIndexChanged);
            // 
            // danhSachBaoBu
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.danhSachBaoBu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.danhSachBaoBu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachBaoBu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachBaoBu.ColumnHeadersHeight = 18;
            this.danhSachBaoBu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachBaoBu.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachBaoBu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachBaoBu.Location = new System.Drawing.Point(16, 78);
            this.danhSachBaoBu.Name = "danhSachBaoBu";
            this.danhSachBaoBu.RowHeadersVisible = false;
            this.danhSachBaoBu.RowHeadersWidth = 51;
            this.danhSachBaoBu.RowTemplate.Height = 24;
            this.danhSachBaoBu.Size = new System.Drawing.Size(777, 405);
            this.danhSachBaoBu.TabIndex = 4;
            this.danhSachBaoBu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachBaoBu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachBaoBu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachBaoBu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachBaoBu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachBaoBu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachBaoBu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachBaoBu.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachBaoBu.ThemeStyle.ReadOnly = false;
            this.danhSachBaoBu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachBaoBu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachBaoBu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachBaoBu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachBaoBu.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachBaoBu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachBaoBu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachBaoBu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachBaoBu_CellDoubleClick);
            // 
            // resetButton
            // 
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.SystemColors.Control;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Image = global::TDTUAbsenceReportingManagement.Properties.Resources.circular;
            this.resetButton.Location = new System.Drawing.Point(728, 18);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(65, 36);
            this.resetButton.TabIndex = 7;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // QuanLyBaoBuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.giangVienFilter);
            this.Controls.Add(this.trangThaiFilter);
            this.Controls.Add(this.danhSachBaoBu);
            this.Name = "QuanLyBaoBuForm";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.QuanLyBaoBuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBaoBu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2ComboBox giangVienFilter;
        private Guna.UI2.WinForms.Guna2ComboBox trangThaiFilter;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachBaoBu;
    }
}
