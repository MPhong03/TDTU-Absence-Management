using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Data;
using TDTUAbsenceReportingManagement.View.Lecturers.Control;
using TDTUAbsenceReportingManagement.View.Student.Control;

namespace TDTUAbsenceReportingManagement.View.Student
{
    public partial class ActorSinhVienForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public ActorSinhVienForm()
        {
            InitializeComponent();

            TrangChuSinhVien uc = new TrangChuSinhVien();
            addUserControl(uc);

            currentUser.Text = Session.Username;
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

        private void ActorSinhVienForm_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                FormDangNhap login = new FormDangNhap();
                login.Show();

                this.Hide();
            }
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
            TrangChuSinhVien uc = new TrangChuSinhVien();
            addUserControl(uc);
        }

        private void notificationTabButton_Click(object sender, EventArgs e)
        {
            ThongBaoSinhVien uc = new ThongBaoSinhVien();
            addUserControl(uc);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2ContextMenuStrip1.Show(guna2CirclePictureBox1, new Point(8, guna2CirclePictureBox1.Height));
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhauSinhVien form = new DoiMatKhauSinhVien();

            form.ShowDialog();
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
    }
}
