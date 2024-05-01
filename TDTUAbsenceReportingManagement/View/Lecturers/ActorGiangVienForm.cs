using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.View.Admin.Control;
using TDTUAbsenceReportingManagement.View.Admin;
using TDTUAbsenceReportingManagement.View.Lecturers.Control;
using TDTUAbsenceReportingManagement.Data;

namespace TDTUAbsenceReportingManagement.View.Lecturers
{
    public partial class ActorGiangVienForm : Form
    {
        public ActorGiangVienForm()
        {
            InitializeComponent();

            TrangChuGiangVien uc = new TrangChuGiangVien();
            addUserControl(uc);

            currentUser.Text = Session.Username;
        }

        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            lecturerContainerControl.Controls.Clear();
            lecturerContainerControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void homeTabButton_Click(object sender, EventArgs e)
        {
            TrangChuGiangVien uc = new TrangChuGiangVien();
            addUserControl(uc);
        }

        private void notificationTabButton_Click(object sender, EventArgs e)
        {
            ThongBaoGiangVien uc = new ThongBaoGiangVien();
            addUserControl(uc);
        }

        private void guiBaoVangTabButton_Click(object sender, EventArgs e)
        {
            YeuCauBaoVang uc = new YeuCauBaoVang();
            addUserControl(uc);
        }

        private void quanlyLopHocTabButton_Click(object sender, EventArgs e)
        {
            QuanLyLopDayPhuTrach uc = new QuanLyLopDayPhuTrach();
            addUserControl(uc);
        }

        private void dangXuatTabButton_Click(object sender, EventArgs e)
        {
            DialogResult result = warningDialog.Show("Xác nhận đăng xuất?");

            if (result == DialogResult.Yes)
            {
                Session.Logout();

                FormDangNhap login = new FormDangNhap();
                login.Show();

                this.Hide();
            }
        }

        private void ActorGiangVienForm_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                FormDangNhap login = new FormDangNhap();
                login.Show();

                this.Hide();
            }
        }
    }
}
