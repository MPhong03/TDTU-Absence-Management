using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Controller;
using TDTUAbsenceReportingManagement.View.Admin;

namespace TDTUAbsenceReportingManagement
{
    public partial class FormDangNhap : Form
    {
        // Lấy chuỗi kết nối từ App.config
        private readonly AuthController authController = new AuthController();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;
            string role = roleLogin.SelectedItem.ToString();

            if (role == null || email == string.Empty || password == string.Empty)
            {
                errorDialog.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // Gọi phương thức DangNhap trong AuthController
                bool success = authController.DangNhap(email, password, role);

                if (success)
                {
                    switch (role)
                    {
                        case "Quản trị viên":
                            successDialog.Show();
                            QuanTriVienForm form = new QuanTriVienForm();
                            form.Show();

                            this.Hide();
                            break;
                        case "Giảng viên":
                            successDialog.Show();
                            break;
                        case "Sinh viên":
                            successDialog.Show();
                            break;
                    }
                }
                else
                {
                    errorDialog.Show("Email hoặc mật khẩu không đúng.");
                }
            }
            catch (Exception ex)
            {
                errorDialog.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            roleLogin.SelectedIndex = 0;
        }
    }
}
