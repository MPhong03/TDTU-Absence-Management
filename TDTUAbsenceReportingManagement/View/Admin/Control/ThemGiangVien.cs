using BUS;
using DTO;
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
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan;

namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    public partial class ThemGiangVien : UserControl
    {
        BUS_GiangVien bus_GiangVien;

        private static string pattern = @"^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$";

        public ThemGiangVien()
        {
            InitializeComponent();

            bus_GiangVien = new BUS_GiangVien();

            successMessage.Parent = this.ParentForm;
            warningMessage.Parent = this.ParentForm;

            genderGV.SelectedIndex = 0;
            academicRankGV.SelectedIndex = 0;
        }

        private void ThemGiangVien_Load(object sender, EventArgs e)
        {
            maGV.Text = bus_GiangVien.TaoMaTuDong();
            maGV.Enabled = false;
        }

        private void huyGVbtn_Click(object sender, EventArgs e)
        {
            GiangVienForm uc = new GiangVienForm();
            QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }

        private void cccdGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Căn cước cần phải là số
            numberValidating(sender, e);
        }

        private void phoneGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Số điện thoại cần phải là số
            numberValidating(sender, e);
        }

        private void numberValidating(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isValidPassword(string password)
        {
            // Độ dài lớn hơn bằng 6
            if (password.Length < 7) return false;

            // Phải có số
            if (!Regex.IsMatch(password, @"\d")) return false;

            // Phải có ký tự viết hoa
            if (!Regex.IsMatch(password, @"[A-Z]")) return false;

            return true;
        }

        private void themGVbtn_Click(object sender, EventArgs e)
        {
            var id = maGV.Text;
            var email = emailGV.Text;
            var cccd = cccdGV.Text;
            var password = passwordGV.Text;
            var fullname = fullNameGV.Text;
            var phone = phoneGV.Text;
            var address = addressGV.Text;
            var birth = birthDateGV.Value;
            var gender = genderGV.Text;
            var academic = academicRankGV.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(cccd) || string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(phone) ||
            string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(gender) ||
            string.IsNullOrWhiteSpace(academic))
            {
                warningMessage.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!isValidPassword(password))
            {
                warningMessage.Show("Mật khẩu cần phải dài hơn 6 ký tự, có ít nhất 1 chữ số và 1 chữ cái in hoa.");
                return;
            }

            if (!Regex.IsMatch(email, pattern))
            {
                warningMessage.Show("Email cần phải được nhập đúng.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(bus_GiangVien.KiemTraEmail(email)))
            {
                warningMessage.Show("Email đã tồn tại.");
                return;
            }

            DTO_GiangVien giangVien = new DTO_GiangVien(
                id,
                email,
                password,
                fullname,
                birth,
                gender,
                academic,
                phone,
                cccd,
                address
                );

            bool result = bus_GiangVien.ThemGiangVien(giangVien);

            if (result) {
                successMessage.Show("Thêm giảng viên thành công!");
            }
            else
            {
                warningMessage.Show("Xảy ra lỗi trong quá trình thêm!");
            }
        }
    }
}
