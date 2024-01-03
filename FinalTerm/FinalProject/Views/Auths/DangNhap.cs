using FinalProject.Config;
using FinalProject.DTO;
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = Connection.GetConnection())
                    {
                        string query = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @Username AND MatKhau = @Password";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);

                            connection.Open();

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                SessionManager.SetSession(username, GetRoleForUser(username));

                                TrangChu trangChu = new TrangChu();
                                trangChu.Show();

                                this.Hide();
                            } else
                            {
                                MessageBox.Show("Lỗi đăng nhập");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
                }
            }
            
            
        }

        private string GetRoleForUser(string username)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                string query = "SELECT ChucVu FROM NhanVien WHERE TenDangNhap = @Username";

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
