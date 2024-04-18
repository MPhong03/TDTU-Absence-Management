using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

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

        public DTO_SinhVien HienThongTinSV(string maSV)
        {
            return sv.HienThongTinSV(maSV);
        }

    }
}
