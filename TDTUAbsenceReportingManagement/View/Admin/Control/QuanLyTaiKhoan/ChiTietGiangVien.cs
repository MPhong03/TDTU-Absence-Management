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
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyLopHoc;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.ChiTietTaiKhoan
{
    public partial class ChiTietGiangVien : UserControl
    {
        BUS_GiangVien bus_GiangVien;
        BUS_LopDay bus_LopDay;
        private string maSoGiangVien = string.Empty;
        private string maLopDayDangChon = string.Empty;
        private static string pattern = @"^\w+([.-]?\w+)*@\w+([.-]?\w+)*(\.\w{2,3})+$";
        public ChiTietGiangVien(string maSoGiangVien)
        {
            InitializeComponent();

            this.maSoGiangVien = maSoGiangVien;

            bus_GiangVien = new BUS_GiangVien();
            bus_LopDay = new BUS_LopDay();

            questionDialog.Parent = this.ParentForm;
            errorDialog.Parent = this.ParentForm;
            successDialog.Parent = this.ParentForm;
            warningMessage.Parent = this.ParentForm;
        }

        private void ChiTietGiangVien_Load(object sender, EventArgs e)
        {
            DTO_GiangVien gv = bus_GiangVien.ChiTietGiangVien(maSoGiangVien);

            if (gv != null)
            {
                maGV.Enabled = false;
                maGV.Text = gv.MaSoGiangVien;
                fullNameGV.Text = gv.HoVaTen;
                emailGV.Text = gv.Email;
                passwordGV.Text = gv.MatKhau;
                cccdGV.Text = gv.CCCD;
                addressGV.Text = gv.DiaChi;
                phoneGV.Text = gv.SoDienThoai;
                ngaySinhGV.Value = gv.NgaySinh;
                genderGV.SelectedItem = gv.GioiTinh;
                academicRankGV.SelectedItem = gv.HocHam;

                var gvClasses = bus_LopDay.DanhSachLopDayTheoMaSoGiangVien(gv.MaSoGiangVien);
                if (gvClasses != null)
                {
                    danhSachLopDay.DataSource = gvClasses;
                }

                xoaLopHocButton.Enabled = false;
            }
        }

        private void deleteGVButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = questionDialog.Show("Xác nhận xóa tài khoản này");
            if (confirm == DialogResult.Yes)
            {
                var result = bus_GiangVien.XoaGiangVien(maGV.Text);

                if (result)
                {
                    DialogResult goBack = successDialog.Show("Xóa tài khoản thành công");

                    if (goBack == DialogResult.OK)
                    {
                        GoBack();
                    }
                }
                else
                {
                    errorDialog.Show("Xảy ra lỗi khi xóa tài khoản");
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            var id = maGV.Text;
            var email = emailGV.Text;
            var cccd = cccdGV.Text;
            var password = passwordGV.Text;
            var fullname = fullNameGV.Text;
            var phone = phoneGV.Text;
            var address = addressGV.Text;
            var birth = ngaySinhGV.Value;
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

            DialogResult confirm = questionDialog.Show("Xác nhận thay đổi thông tin tài khoản này");
            if (confirm == DialogResult.Yes)
            {

                var result = bus_GiangVien.SuaGiangVien(giangVien);

                if (result)
                {
                    successDialog.Show("Sửa tài khoản thành công");

                    ChiTietGiangVien_Load(sender, e);
                }
                else
                {
                    errorDialog.Show("Xảy ra lỗi khi xóa tài khoản");
                }
            }
        }
        private void GoBack()
        {
            QuanLyTaiKhoanForm uc = new QuanLyTaiKhoanForm();
            QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);

                this.Hide();
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

        private void themLopHocButton_Click(object sender, EventArgs e)
        {
            ChiTietLopHoc uc = new ChiTietLopHoc(maSoGiangVien, 0, false);
            QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);

                this.Hide();
            }
        }

        private void danhSachLopDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachLopDay.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachLopDay.SelectedRows[0];

                maLopDayDangChon = selectedRow.Cells["MaLopDay"].Value.ToString();

                xoaLopHocButton.Enabled = true;
            }
        }

        private void xoaLopHocButton_Click(object sender, EventArgs e)
        {
            if (danhSachLopDay.SelectedRows.Count > 0)
            {
                DialogResult confirm = questionDialog.Show("Xác nhận xóa lớp dạy này");
                if (confirm == DialogResult.Yes)
                {
                    var result = bus_LopDay.XoaLopDay(int.Parse(maLopDayDangChon));

                    if (result)
                    {
                        DialogResult goBack = successDialog.Show("Xóa lớp dạy thành công");

                        if (goBack == DialogResult.OK)
                        {
                            ChiTietGiangVien_Load(sender, e);
                        }
                    }
                    else
                    {
                        errorDialog.Show("Xảy ra lỗi khi xóa lớp dạy");
                    }
                }
            }
        }

        private void danhSachLopDay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachLopDay.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachLopDay.SelectedRows[0];

                maLopDayDangChon = selectedRow.Cells["MaLopDay"].Value.ToString();

                ChiTietLopHoc uc = new ChiTietLopHoc(maSoGiangVien, int.Parse(maLopDayDangChon), true);
                QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

                if (quanTriVienForm != null)
                {
                    quanTriVienForm.addUserControl(uc);

                    this.Hide();
                }
            }
        }
    }
}
