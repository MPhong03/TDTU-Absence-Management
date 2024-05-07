namespace TDTUAbsenceReportingManagement.View.Student.Control
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
            this.noiDungFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.tieuDeFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 437);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // ThongBaoSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.noiDungFilter);
            this.Controls.Add(this.tieuDeFilter);
            this.Name = "ThongBaoSinhVien";
            this.Size = new System.Drawing.Size(808, 501);
            this.Load += new System.EventHandler(this.ThongBaoSinhVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2TextBox noiDungFilter;
        private Guna.UI2.WinForms.Guna2TextBox tieuDeFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
