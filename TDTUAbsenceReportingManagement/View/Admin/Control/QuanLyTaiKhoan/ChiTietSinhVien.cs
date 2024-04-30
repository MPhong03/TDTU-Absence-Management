using BUS;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class ChiTietSinhVien : UserControl
    {
        private string maSoSinhVien = string.Empty;
        BUS_SinhVien sv;
        DTO_SinhVien dSV;
        public ChiTietSinhVien(string maSoSinhVien)
        {
            InitializeComponent();
            this.maSoSinhVien = maSoSinhVien;
            sv = new BUS_SinhVien();
            messageDialogCTSV.Parent = this.FindForm();
            messageDialog_Xoa.Parent = this.FindForm();
        }

        private void ChiTietSinhVien_Load(object sender, EventArgs e)
        {
            dSV = sv.ChiTietSinhVien(this.maSoSinhVien);
            if (dSV != null)
            {
                maSV_sua.Enabled = false;
                courseSV_sua.Enabled = false;

                maSV_sua.Text = dSV.MaSoSinhVien;
                fullNameSV_sua.Text = dSV.HoVaTen;
                emailSV_sua.Text = dSV.Email;
                phoneSV_sua.Text = dSV.MatKhau;
                cccdSV_sua.Text = dSV.CCCD;
                phoneSV_sua.Text = dSV.SoDienThoai;
                birthDateSV_sua.Value = dSV.NgaySinh;
                genderSV_sua.SelectedItem = dSV.GioiTinh;
                academicRankSV_sua.SelectedItem = dSV.ChuyenNganh;
                courseSV_sua.Text = dSV.KhoaTuyenSinh;
                passwordSV_sua.Text = dSV.MatKhau;
            }
        }

        private void cccdSV_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDialogCTSV.Show("Vui lòng chỉ nhập ký tự số");
            }

            if (cccdSV_sua != null && cccdSV_sua.TextLength >= 12 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneSV_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDialogCTSV.Show("Vui lòng chỉ nhập ký tự số");
            }

            if (phoneSV_sua != null && phoneSV_sua.TextLength >= 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordSV_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDialogCTSV.Show("Mật khẩu không nhận ký tự đặc biệt");
            }

            if (passwordSV_sua != null && passwordSV_sua.TextLength >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDialogCTSV.Show("Mật khẩu có tối đa 6 ký tự");
                return;
            }

            if (char.IsUpper(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                passwordSV_sua.Tag = true;
            }

            // Kiểm tra điều kiện (ít nhất một ký tự in hoa và ít nhất một ký tự số)
            if (passwordSV_sua.Tag != null && (bool)passwordSV_sua.Tag)
            {
                // Nếu thỏa, thực hiện tiếp
                return;
            }
            else
            {
                // Chưa thỏa, hiện thông báo
                e.Handled = true;
                messageDialogCTSV.Show("Mật khẩu phải có ít nhất một ký tự in hoa và một ký tự số.");
            }
        }

        private bool ValidatePassword(string password)
        {
            bool hasUpperCase = false; // Biến để theo dõi việc có chữ hoa trong mật khẩu
            bool hasDigit = false; // Biến để theo dõi việc có số trong mật khẩu

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true; // Đánh dấu là đã tìm thấy chữ hoa
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true; // Đánh dấu là đã tìm thấy số
                }

                // Nếu đã tìm thấy cả chữ hoa và số, trả về true
                if (hasUpperCase && hasDigit)
                {
                    return true;
                }
            }

            // Nếu vòng lặp kết thúc mà vẫn chưa tìm thấy cả chữ hoa và số, trả về false
            return false;
        }

        private void luu_sua_SVbtn_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword(passwordSV_sua.Text))
            {
                messageDialogCTSV.Show("Mật khẩu không hợp lệ");
            }
            else
            {
                DateTime birthDate = birthDateSV_sua.Value;
                sv.SuaTaiKhoanSV(maSV_sua.Text, emailSV_sua.Text, passwordSV_sua.Text, fullNameSV_sua.Text, birthDate,
                                    genderSV_sua.Text, phoneSV_sua.Text, cccdSV_sua.Text, academicRankSV_sua.Text, courseSV_sua.Text);

                GoBack();
            }
        }

        private void xoaSVbtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = messageDialog_Xoa.Show("Bạn muốn xóa tài khoản sinh viên này ?");
            if(confirm == DialogResult.Yes)
            {
                sv.XoaTaiKhoanSV(maSV_sua.Text);
                GoBack();
            }
        }

        private void huy_sua_SVbtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            QuanLyTaiKhoanForm uc = new QuanLyTaiKhoanForm();
            QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }
    }
}
