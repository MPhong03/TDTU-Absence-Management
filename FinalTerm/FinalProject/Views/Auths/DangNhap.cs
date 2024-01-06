using FinalProject.Config;
using FinalProject.DTO;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.Views.Admin;

namespace FinalProject.Views.Auths
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                guna2MessageDialog1.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = Connection.GetConnection())
                    {
                        string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            connection.Open();

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                string role = GetRoleForUser(username);
                                SessionManager.SetSession(username, role);

                                if (role.ToUpper().Equals("QUẢN LÝ"))
                                {
                                    TrangChuAdmin admin = new TrangChuAdmin();
                                    admin.Show();
                                }
                                else
                                {
                                    TrangChu trangChu = new TrangChu();
                                    trangChu.Show();
                                }
                                this.Hide();
                            }
                            else
                            {
                                guna2MessageDialog1.Show("Lỗi đăng nhập");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"An exception occurred: {ex.Message}");
                    guna2MessageDialog1.Show("Lỗi kết nối cơ sở dữ liệu");
                }
            }


        }

        private string GetRoleForUser(string username)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                string query = "SELECT ChucVu FROM TaiKhoan WHERE TenDangNhap = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    object result = command.ExecuteScalar();

                    return (result != null) ? result.ToString() : "";
                }
            }
        }
    }
}
