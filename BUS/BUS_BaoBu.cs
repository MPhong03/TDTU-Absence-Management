using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BaoBu
    {
        DAL_BaoBu dal_BB;
        public BUS_BaoBu()
        {
            dal_BB = new DAL_BaoBu();
        }
        public DataTable DanhSachBaoBu()
        {
            return dal_BB.DanhSachBaoBu();
        }
        public bool ThemYeuCauBaoBu(DTO_BaoBu bb)
        {
            return dal_BB.ThemYeuCauBaoBu(bb);
        }
        public DataTable DanhSachYeuCauBaoBuCuaGiangVienBangEmail(string email)
        {
            return dal_BB.DanhSachYeuCauBaoBuCuaGiangVienBangEmail(email);
        }
        public bool XoaYeuCauBaoBu(int id)
        {
            return dal_BB.XoaYeuCauBaoBu(id);
        }
        public DTO_BaoBu ChiTietBaoBu(int id)
        {
            return dal_BB.ChiTietBaoBu(id);
        }
        public bool CapNhatTrangThaiYeuCauBaoBu(int id, string trangThai)
        {
            return dal_BB.CapNhatTrangThaiYeuCauBaoBu(id, trangThai);
        }
        public int TaoMaTuDong()
        {
            string currentID = dal_BB.LayMaBaoBuGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return 1; }

            return int.Parse(currentID) + 1;
        }
    }
}
