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

namespace TDTUAbsenceReportingManagement
{
    public partial class FormDangNhap : Form
    {
        // Lấy chuỗi kết nối từ App.config
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyBaoVangBaoBuConnectionString"].ConnectionString;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;
            string role = roleLogin.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                switch (role)
                {
                    case "Quản trị viên":
                        cmd.CommandText = "SELECT * FROM QuanTriVien WHERE TenDangNhap = @Email AND MatKhau = @Password";
                        break;
                    case "Giảng viên":
                        cmd.CommandText = "SELECT * FROM GiangVien WHERE Email = @Email AND MatKhau = @Password";
                        break;
                    case "Sinh viên":
                        cmd.CommandText = "SELECT * FROM SinhVien WHERE Email = @Email AND MatKhau = @Password";
                        break;
                }

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Chuyển đến form tương ứng với vai trò
                    switch (role)
                    {
                        case "Quản trị viên":
                            successDialog.Show();
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
                    MessageBox.Show("Email hoặc mật khẩu không đúng.");
                }

                conn.Close();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            roleLogin.SelectedIndex = 0;
        }
    }
}
