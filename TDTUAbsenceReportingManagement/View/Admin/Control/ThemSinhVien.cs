using BUS;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan;
using System.Globalization;

namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    public partial class ThemSinhVien : UserControl
    {
        private BUS_SinhVien sv;
        public ThemSinhVien()
        {
            InitializeComponent();
            sv = new BUS_SinhVien();
            messageDIalogSV.Parent = this.FindForm();
            genderSV.SelectedIndex = 0;
            academicRankSV.SelectedIndex = 0;
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            maSV.Text = sv.LayMaSV();
            maSV.Enabled = false;
            courseSV_TextChanged(this, new EventArgs());
        }

        private void courseSV_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra courseSV.Text nhập vào không rỗng và có độ dài là 4
            if (!string.IsNullOrEmpty(courseSV.Text) && courseSV.Text.Length == 4)
            {
                // Lấy giá trị mới của courseSV.Text
                string newCourse = courseSV.Text.Substring(2, 2);

                // Lấy giá trị hiện tại của maSV.Text
                string currentMaSV = maSV.Text;

                // Kiểm tra nếu maSV.Text không rỗng và có độ dài phù hợp
                if (!string.IsNullOrEmpty(currentMaSV) && currentMaSV.Length == 8)
                {
                    // Cập nhật lại maSV.Text với courseSV.Text
                    string newMaSV = currentMaSV.Substring(0, 1) + newCourse + currentMaSV.Substring(3);
                    maSV.Text = newMaSV;
                }
            }
        }

        private void themSVbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailSV.Text) || string.IsNullOrEmpty(cccdSV.Text) || string.IsNullOrEmpty(fullNameSV.Text) || string.IsNullOrEmpty(phoneSV.Text) 
                || string.IsNullOrEmpty(passwordSV.Text) || string.IsNullOrEmpty(courseSV.Text) 
                || string.IsNullOrEmpty(genderSV.Text) || string.IsNullOrEmpty(academicRankSV.Text))
            {
                messageDIalogSV.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (passwordSV.Text.Length < 6)
                {
                    messageDIalogSV.Show("Mật khẩu phải có ít nhất 6 ký tự");
                    return;
                }

                if (!ValidatePassword(passwordSV.Text))
                {
                    messageDIalogSV.Show("Mật khẩu không hợp lệ");
                }
                else
                {
                    if (!sv.KiemTraEmailTonTai(emailSV.Text))
                    {
                        DateTime birthDate = birthDateSV.Value;
                        sv.ThemTaiKhoanSV(maSV.Text, emailSV.Text, passwordSV.Text, fullNameSV.Text, birthDate,
                                            genderSV.Text, phoneSV.Text, cccdSV.Text, academicRankSV.Text, courseSV.Text);

                        GoBack();
                    }
                    else
                    {
                        messageDIalogSV.Show("Email đã tồn tại");
                    }
                   
                }
              
            }
           
        }

        private void huySVbtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void cccdSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDIalogSV.Show("Vui lòng chỉ nhập ký tự số");
            }

            if (cccdSV != null && cccdSV.TextLength >= 12 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDIalogSV.Show("Vui lòng chỉ nhập ký tự số");
            }

            if(phoneSV != null && phoneSV.TextLength >= 10 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void courseSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDIalogSV.Show("Vui lòng chỉ nhập ký tự số");
            }

            if (courseSV != null && courseSV.TextLength >= 4 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fullNameSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDIalogSV.Show("Vui lòng chỉ nhập ký tự alphabet");
            }

            if (fullNameSV != null && fullNameSV.TextLength >= 50 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageDIalogSV.Show("Mật khẩu không nhận ký tự đặc biệt");
            }

            //if (passwordSV != null && passwordSV.TextLength >= 6 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    messageDIalogSV.Show("Mật khẩu có tối đa 6 ký tự");
            //    return;
            //}

            if (char.IsUpper(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                passwordSV.Tag = true;
            }

            // Kiểm tra điều kiện (ít nhất một ký tự in hoa và ít nhất một ký tự số)
            if (passwordSV.Tag != null && (bool)passwordSV.Tag)
            {
                // Nếu thỏa, thực hiện tiếp
                return;
            }
            else
            {
                // Chưa thỏa, hiện thông báo
                e.Handled = true;
                messageDIalogSV.Show("Mật khẩu phải có ít nhất một ký tự in hoa và một ký tự số.");
            }
        }

        private bool ValidatePassword(string password)
        {
            bool hasUpperCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if(char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if(hasUpperCase && hasDigit)
                {
                    return true;
                }
            }
            return false;
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
