using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTUAbsenceReportingManagement.Controller
{
    public class AuthController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyBaoVangBaoBuConnectionString"].ConnectionString;

        // Attributes
        private static string emailSession;
        private static string roleSession;

        public bool DangNhap(string email, string password, string role)
        {
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
                    default:
                        throw new Exception("Vai trò không hợp lệ");
                }

                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Lưu thông tin đăng nhập
                    emailSession = email;
                    roleSession = role;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void DangXuat()
        {
            emailSession = string.Empty; roleSession = string.Empty;
        }

        public bool KiemTraDangNhap()
        {
            if (emailSession == string.Empty || roleSession == string.Empty) return false;
            return true;
        }
    }
}
