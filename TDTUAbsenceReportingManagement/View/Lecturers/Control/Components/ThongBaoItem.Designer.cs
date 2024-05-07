namespace TDTUAbsenceReportingManagement.View.Lecturers.Control.Components
{
    partial class ThongBaoItem
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
            this.sender = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.description = new Guna.UI2.WinForms.Guna2TextBox();
            this.notificationID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sender
            // 
            this.sender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sender.ForeColor = System.Drawing.Color.White;
            this.sender.Location = new System.Drawing.Point(483, 259);
            this.sender.Margin = new System.Windows.Forms.Padding(8);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(109, 25);
            this.sender.TabIndex = 9;
            this.sender.Text = "admin";
            this.sender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(478, 8);
            this.date.Margin = new System.Windows.Forms.Padding(8);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(114, 25);
            this.date.TabIndex = 6;
            this.date.Text = "01-01-2024";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(8, 8);
            this.title.Margin = new System.Windows.Forms.Padding(8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(427, 23);
            this.title.TabIndex = 5;
            this.title.Text = "DUYỆT YÊU CẦU BÁO BÙ";
            // 
            // description
            // 
            this.description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description.DefaultText = "";
            this.description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description.Location = new System.Drawing.Point(13, 43);
            this.description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.PlaceholderText = "";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.description.SelectedText = "";
            this.description.Size = new System.Drawing.Size(579, 204);
            this.description.TabIndex = 10;
            // 
            // notificationID
            // 
            this.notificationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.notificationID.ForeColor = System.Drawing.Color.White;
            this.notificationID.Location = new System.Drawing.Point(8, 259);
            this.notificationID.Margin = new System.Windows.Forms.Padding(8);
            this.notificationID.Name = "notificationID";
            this.notificationID.Size = new System.Drawing.Size(427, 23);
            this.notificationID.TabIndex = 11;
            this.notificationID.Text = "ID: 123456";
            // 
            // ThongBaoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.notificationID);
            this.Controls.Add(this.description);
            this.Controls.Add(this.sender);
            this.Controls.Add(this.date);
            this.Controls.Add(this.title);
            this.Name = "ThongBaoItem";
            this.Size = new System.Drawing.Size(600, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sender;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label title;
        private Guna.UI2.WinForms.Guna2TextBox description;
        private System.Windows.Forms.Label notificationID;
    }
}
