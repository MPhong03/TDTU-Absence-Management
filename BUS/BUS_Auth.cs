using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Auth
    {
        DAL_Auth auth;
        public BUS_Auth()
        {
            auth = new DAL_Auth();
        }
        public bool DangNhap(string email, string password, string role)
        {
            if (role.Equals("Quản trị viên"))
            {
                return auth.DangNhapQuanTriVien(email, password, role);
            }
            else if (role.Equals("Giảng viên"))
            {
                return auth.DangNhapGiangVien(email, password, role);

            }
            else if (role.Equals("Sinh viên"))
            {
                return auth.DangNhapSinhVien(email, password, role);

            }
            else
            {

                return false;
            }
        }
    }
}
