using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan;

namespace TDTUAbsenceReportingManagement.View.Admin
{
    public partial class QuanLyTaiKhoanForm : UserControl
    {
        public QuanLyTaiKhoanForm()
        {
            InitializeComponent();
            GiangVienForm uc = new GiangVienForm();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2ContainerControl1.Controls.Clear();
            guna2ContainerControl1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            GiangVienForm uc = new GiangVienForm();
            addUserControl(uc);

            // Cập nhật UI
            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 4);
            guna2Button1.CustomBorderColor = Color.FromArgb(214, 101, 98);
            guna2Button1.ForeColor = Color.FromArgb(214, 101, 98);

            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 0);
            guna2Button2.CustomBorderColor = Color.Black;
            guna2Button2.ForeColor = Color.Black;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            SinhVienForm uc = new SinhVienForm();
            addUserControl(uc);

            // Cập nhật UI
            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 4);
            guna2Button2.CustomBorderColor = Color.FromArgb(214, 101, 98);
            guna2Button2.ForeColor = Color.FromArgb(214, 101, 98);

            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 0);
            guna2Button1.CustomBorderColor = Color.Black;
            guna2Button1.ForeColor = Color.Black;
        }
    }
}
