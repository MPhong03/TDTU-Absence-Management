using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Data;

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class DoiMatKhauGiangVien : Form
    {
        BUS_GiangVien bus_GV;
        private string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$";
        public DoiMatKhauGiangVien()
        {
            InitializeComponent();
            bus_GV = new BUS_GiangVien();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string passHienTai = matKhauHienTaiInput.Text;
            string passMoi = matKhauMoiInput.Text;
            string passXacNhan = xacNhanMatKhauInput.Text;

            if (string.IsNullOrEmpty(passHienTai) || string.IsNullOrEmpty(passMoi) || string.IsNullOrEmpty(passXacNhan))
            {
                warningDialog.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (!Regex.IsMatch(passMoi, pattern))
            {
                warningDialog.Show("Mật khẩu phải chứa ít nhất 1 ký tự viết hoa, 1 ký tự số và 1 ký tự đặc biệt");
                return;
            }

            if (!passMoi.Equals(passXacNhan))
            {
                warningDialog.Show("Mật khẩu không trùng khớp");
                return;
            }

            bool result = bus_GV.DoiMatKhau(Session.UserID, Session.Username, passHienTai, passMoi);

            if (result)
            {
                successDialog.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình đổi mật khẩu");
                this.Close();

            }
        }

    }
}
