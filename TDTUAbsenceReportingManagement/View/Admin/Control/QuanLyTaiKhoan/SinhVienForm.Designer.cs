﻿namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    partial class SinhVienForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nhapDanhSachSinhVienButton = new Guna.UI2.WinForms.Guna2Button();
            this.themSinhVienButton = new Guna.UI2.WinForms.Guna2Button();
            this.danhSachSinhVienDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVienDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nhapDanhSachSinhVienButton
            // 
            this.nhapDanhSachSinhVienButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nhapDanhSachSinhVienButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nhapDanhSachSinhVienButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nhapDanhSachSinhVienButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nhapDanhSachSinhVienButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.nhapDanhSachSinhVienButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nhapDanhSachSinhVienButton.ForeColor = System.Drawing.Color.White;
            this.nhapDanhSachSinhVienButton.Location = new System.Drawing.Point(405, 3);
            this.nhapDanhSachSinhVienButton.Name = "nhapDanhSachSinhVienButton";
            this.nhapDanhSachSinhVienButton.Size = new System.Drawing.Size(405, 31);
            this.nhapDanhSachSinhVienButton.TabIndex = 6;
            this.nhapDanhSachSinhVienButton.Text = "Import CSV";
            // 
            // themSinhVienButton
            // 
            this.themSinhVienButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.themSinhVienButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.themSinhVienButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.themSinhVienButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.themSinhVienButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.themSinhVienButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.themSinhVienButton.ForeColor = System.Drawing.Color.White;
            this.themSinhVienButton.Location = new System.Drawing.Point(3, 3);
            this.themSinhVienButton.Name = "themSinhVienButton";
            this.themSinhVienButton.Size = new System.Drawing.Size(400, 31);
            this.themSinhVienButton.TabIndex = 5;
            this.themSinhVienButton.Text = "Thêm tài khoản";
            this.themSinhVienButton.Click += new System.EventHandler(this.themSinhVienButton_Click);
            // 
            // danhSachSinhVienDataGrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVienDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.danhSachSinhVienDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachSinhVienDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.danhSachSinhVienDataGrid.ColumnHeadersHeight = 18;
            this.danhSachSinhVienDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachSinhVienDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.danhSachSinhVienDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVienDataGrid.Location = new System.Drawing.Point(3, 40);
            this.danhSachSinhVienDataGrid.Name = "danhSachSinhVienDataGrid";
            this.danhSachSinhVienDataGrid.RowHeadersVisible = false;
            this.danhSachSinhVienDataGrid.RowHeadersWidth = 51;
            this.danhSachSinhVienDataGrid.RowTemplate.Height = 24;
            this.danhSachSinhVienDataGrid.Size = new System.Drawing.Size(802, 405);
            this.danhSachSinhVienDataGrid.TabIndex = 4;
            this.danhSachSinhVienDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVienDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachSinhVienDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachSinhVienDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachSinhVienDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachSinhVienDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVienDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachSinhVienDataGrid.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachSinhVienDataGrid.ThemeStyle.ReadOnly = false;
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachSinhVienDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachSinhVienDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachSinhVienDataGrid_CellDoubleClick);
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nhapDanhSachSinhVienButton);
            this.Controls.Add(this.themSinhVienButton);
            this.Controls.Add(this.danhSachSinhVienDataGrid);
            this.Name = "SinhVienForm";
            this.Size = new System.Drawing.Size(808, 448);
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSinhVienDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button nhapDanhSachSinhVienButton;
        private Guna.UI2.WinForms.Guna2Button themSinhVienButton;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachSinhVienDataGrid;
    }
}
