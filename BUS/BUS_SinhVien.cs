using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien sv;
        public BUS_SinhVien()
        {
            sv = new DAL_SinhVien();
        }
        public DataTable HienDanhSachSV()
        {
            return sv.DanhSachSinhVien();
        }
    }
}
