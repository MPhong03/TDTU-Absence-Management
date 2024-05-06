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

namespace TDTUAbsenceReportingManagement.View.Student.Control
{
    public partial class DoiMatKhauSinhVien : Form
    {
        BUS_SinhVien bus_SV;
        private string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$";
        public DoiMatKhauSinhVien()
        {
            InitializeComponent();
            bus_SV = new BUS_SinhVien();
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

            bool result = bus_SV.DoiMatKhau(Session.UserID, Session.Username, passHienTai, passMoi);

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
