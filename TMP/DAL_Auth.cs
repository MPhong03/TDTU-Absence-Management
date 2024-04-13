using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Auth
    {
        // Attributes
        private static string emailSession;
        private static string roleSession;

        public bool DangNhap(string email, string password, string role)
        {
            string cmd = "";

            switch (role)
            {
                case "Quản trị viên":
                    cmd = "SELECT * FROM QuanTriVien WHERE TenDangNhap = " + email + " AND MatKhau = " + password;
                    break;
                case "Giảng viên":
                    cmd = "SELECT * FROM GiangVien WHERE Email = " + email + " AND MatKhau = " + password;
                    break;
                case "Sinh viên":
                    cmd = "SELECT * FROM SinhVien WHERE Email = " + email + " AND MatKhau = " + password;
                    break;
                default:
                    throw new Exception("Vai trò không hợp lệ");
            }

            if (Connection.selectQuery(cmd).Rows.Count > 0)
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
