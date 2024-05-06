namespace TDTUAbsenceReportingManagement.View.Lecturers.Control.Components
{
    partial class LopDayItem
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
            this.monHoc = new System.Windows.Forms.Label();
            this.ngayHoc = new System.Windows.Forms.Label();
            this.nhomToHoc = new System.Windows.Forms.Label();
            this.caHoc = new System.Windows.Forms.Label();
            this.trangThai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monHoc
            // 
            this.monHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.monHoc.Location = new System.Drawing.Point(8, 8);
            this.monHoc.Margin = new System.Windows.Forms.Padding(8);
            this.monHoc.Name = "monHoc";
            this.monHoc.Size = new System.Drawing.Size(639, 23);
            this.monHoc.TabIndex = 0;
            this.monHoc.Text = "Công nghệ phần mềm (502045)";
            // 
            // ngayHoc
            // 
            this.ngayHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayHoc.AutoSize = true;
            this.ngayHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayHoc.Location = new System.Drawing.Point(663, 8);
            this.ngayHoc.Margin = new System.Windows.Forms.Padding(8);
            this.ngayHoc.Name = "ngayHoc";
            this.ngayHoc.Size = new System.Drawing.Size(114, 25);
            this.ngayHoc.TabIndex = 1;
            this.ngayHoc.Text = "01-01-2024";
            // 
            // nhomToHoc
            // 
            this.nhomToHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nhomToHoc.AutoSize = true;
            this.nhomToHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhomToHoc.Location = new System.Drawing.Point(8, 90);
            this.nhomToHoc.Margin = new System.Windows.Forms.Padding(8);
            this.nhomToHoc.Name = "nhomToHoc";
            this.nhomToHoc.Size = new System.Drawing.Size(100, 25);
            this.nhomToHoc.TabIndex = 2;
            this.nhomToHoc.Text = "N03 - T02";
            // 
            // caHoc
            // 
            this.caHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.caHoc.AutoSize = true;
            this.caHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.caHoc.Location = new System.Drawing.Point(8, 49);
            this.caHoc.Margin = new System.Windows.Forms.Padding(8);
            this.caHoc.Name = "caHoc";
            this.caHoc.Size = new System.Drawing.Size(54, 25);
            this.caHoc.TabIndex = 3;
            this.caHoc.Text = "Ca 3";
            // 
            // trangThai
            // 
            this.trangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.trangThai.Location = new System.Drawing.Point(487, 90);
            this.trangThai.Margin = new System.Windows.Forms.Padding(8);
            this.trangThai.Name = "trangThai";
            this.trangThai.Size = new System.Drawing.Size(290, 25);
            this.trangThai.TabIndex = 4;
            this.trangThai.Text = "VẮNG";
            this.trangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LopDayItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.trangThai);
            this.Controls.Add(this.caHoc);
            this.Controls.Add(this.nhomToHoc);
            this.Controls.Add(this.ngayHoc);
            this.Controls.Add(this.monHoc);
            this.Name = "LopDayItem";
            this.Size = new System.Drawing.Size(785, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monHoc;
        private System.Windows.Forms.Label ngayHoc;
        private System.Windows.Forms.Label nhomToHoc;
        private System.Windows.Forms.Label caHoc;
        private System.Windows.Forms.Label trangThai;
    }
}
