using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
    }
}
