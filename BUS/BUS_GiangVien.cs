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
        public bool ThemGiangVien(DTO_GiangVien giangVien)
        {
            return gv.ThemGiangVien(giangVien);
        }
        public bool XoaGiangVien(string id)
        {
            return gv.XoaGiangVien(id);
        }
        public bool SuaGiangVien(DTO_GiangVien giangVien)
        {
            return gv.SuaGiangVien(giangVien);
        }
        public string KiemTraEmail(string email)
        {
            return gv.KiemTraEmail(email);
        }
        public string TaoMaTuDong()
        {
            string currentID = gv.LayMaGiangVienGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return "FIT001"; }

            int number = int.Parse(currentID.Substring(3, 3)) + 1;
            // Tạo mã mới với số thứ tự tăng lên
            if (number < 10)
                return "FIT00" + number.ToString();
            else if (number < 100)
                return "FIT0" + number.ToString();
            else
                return "FIT" + number.ToString();
        }
    }
}
