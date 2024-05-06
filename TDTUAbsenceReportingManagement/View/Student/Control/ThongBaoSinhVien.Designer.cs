﻿namespace TDTUAbsenceReportingManagement.View.Student.Control
{
    partial class ThongBaoSinhVien
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
            this.noiDungFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.tieuDeFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.danhSachThongBao = new Guna.UI2.WinForms.Guna2DataGridView();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // noiDungFilter
            // 
            this.noiDungFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noiDungFilter.DefaultText = "";
            this.noiDungFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.noiDungFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.noiDungFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noiDungFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noiDungFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noiDungFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noiDungFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.noiDungFilter.Location = new System.Drawing.Point(372, 18);
            this.noiDungFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noiDungFilter.Name = "noiDungFilter";
            this.noiDungFilter.PasswordChar = '\0';
            this.noiDungFilter.PlaceholderText = "Nội dung";
            this.noiDungFilter.SelectedText = "";
            this.noiDungFilter.Size = new System.Drawing.Size(350, 36);
            this.noiDungFilter.TabIndex = 7;
            this.noiDungFilter.TextChanged += new System.EventHandler(this.noiDungFilter_TextChanged);
            // 
            // tieuDeFilter
            // 
            this.tieuDeFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tieuDeFilter.DefaultText = "";
            this.tieuDeFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tieuDeFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tieuDeFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tieuDeFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tieuDeFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tieuDeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tieuDeFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tieuDeFilter.Location = new System.Drawing.Point(16, 18);
            this.tieuDeFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tieuDeFilter.Name = "tieuDeFilter";
            this.tieuDeFilter.PasswordChar = '\0';
            this.tieuDeFilter.PlaceholderText = "Tiêu đề";
            this.tieuDeFilter.SelectedText = "";
            this.tieuDeFilter.Size = new System.Drawing.Size(350, 36);
            this.tieuDeFilter.TabIndex = 6;
            this.tieuDeFilter.TextChanged += new System.EventHandler(this.tieuDeFilter_TextChanged);
            // 
            // danhSachThongBao
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.danhSachThongBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.danhSachThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachThongBao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.danhSachThongBao.ColumnHeadersHeight = 18;
            this.danhSachThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachThongBao.DefaultCellStyle = dataGridViewCellStyle12;
            this.danhSachThongBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachThongBao.Location = new System.Drawing.Point(16, 78);
            this.danhSachThongBao.Name = "danhSachThongBao";
            this.danhSachThongBao.RowHeadersVisible = false;
            this.danhSachThongBao.RowHeadersWidth = 51;
            this.danhSachThongBao.RowTemplate.Height = 24;
            this.danhSachThongBao.Size = new System.Drawing.Size(777, 405);
            this.danhSachThongBao.TabIndex = 5;
            this.danhSachThongBao.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachThongBao.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.danhSachThongBao.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.danhSachThongBao.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.danhSachThongBao.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.danhSachThongBao.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.danhSachThongBao.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachThongBao.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.danhSachThongBao.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.danhSachThongBao.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachThongBao.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.danhSachThongBao.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.danhSachThongBao.ThemeStyle.HeaderStyle.Height = 18;
            this.danhSachThongBao.ThemeStyle.ReadOnly = false;
            this.danhSachThongBao.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.danhSachThongBao.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.danhSachThongBao.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachThongBao.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.danhSachThongBao.ThemeStyle.RowsStyle.Height = 24;
            this.danhSachThongBao.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.danhSachThongBao.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.resetButton.TabIndex = 8;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ThongBaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.noiDungFilter);
            this.Controls.Add(this.tieuDeFilter);
            this.Controls.Add(this.danhSachThongBao);
            this.Name = "ThongBaoSinhVien";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.ThongBaoSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2TextBox noiDungFilter;
        private Guna.UI2.WinForms.Guna2TextBox tieuDeFilter;
        private Guna.UI2.WinForms.Guna2DataGridView danhSachThongBao;
    }
}