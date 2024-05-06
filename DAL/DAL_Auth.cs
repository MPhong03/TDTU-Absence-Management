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

        public bool DangNhapQuanTriVien(string email, string password, string role)
        {
            string cmd = "SELECT * FROM QuanTriVien WHERE TenDangNhap = '" + email + "' AND MatKhau = '" + password + "'";

            DataTable data = Connection.selectQuery(cmd);

            if (data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DangNhapGiangVien(string email, string password, out string id)
        {
            string cmd = "SELECT * FROM GiangVien WHERE Email = '" + email + "' AND MatKhau = '" + password + "'";

            DataTable data = Connection.selectQuery(cmd);

            if (data.Rows.Count > 0)
            {
                id = (data.Rows[0])["MaSoGiangVien"].ToString();

                return true;
            }
            else
            {
                id = null;
                return false;
            }
        }

        public bool DangNhapSinhVien(string email, string password, out string id)
        {
            string cmd = "SELECT * FROM SinhVien WHERE Email = '" + email + "' AND MatKhau = '" + password + "'";

            DataTable data = Connection.selectQuery(cmd);

            if (data.Rows.Count > 0)
            {
                id = (data.Rows[0])["MaSoSinhVien"].ToString();

                return true;
            }
            else
            {
                id = null;
                return false;
            }
        }
    }
}
