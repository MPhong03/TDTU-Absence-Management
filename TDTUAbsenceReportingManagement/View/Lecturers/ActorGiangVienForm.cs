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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public void OnMove()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OnMove();
            }
        }

        private void currentUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OnMove();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(dropdownMenuButton, new Point(8, dropdownMenuButton.Height));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhauGiangVien form = new DoiMatKhauGiangVien();

            form.ShowDialog();
        }
    }
}
