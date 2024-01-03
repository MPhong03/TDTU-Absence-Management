namespace FinalProject.Views
{
    partial class TrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textTest = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // textTest
            // 
            textTest.BackColor = Color.Transparent;
            textTest.Location = new Point(379, 204);
            textTest.Name = "textTest";
            textTest.Size = new Size(37, 22);
            textTest.TabIndex = 0;
            textTest.Text = "UWU";
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textTest);
            Name = "TrangChu";
            Text = "TrangChu";
            Load += TrangChu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel textTest;
    }
}