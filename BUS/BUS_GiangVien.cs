using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_GiangVien
    {
        DAL_GiangVien gv;
        public BUS_GiangVien()
        {
            gv = new DAL_GiangVien();
        }
        public DataTable HienDanhSachGV()
        {
            return gv.DanhSachGiangVien();
        }
        public DTO_GiangVien ChiTietGiangVien(string maSoGiangVien)
        {
            return gv.ChiTietGiangVien(maSoGiangVien);
        }
    }
}
