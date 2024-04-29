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
    public class BUS_MonHoc
    {
        DAL_MonHoc dal_MonHoc;
        public BUS_MonHoc()
        {
            dal_MonHoc = new DAL_MonHoc();
        }
        public DataTable DanhSachMonHoc()
        {
            return dal_MonHoc.DanhSachMonHoc();
        }
        public bool ThemMonHoc(DTO_MonHoc monHoc)
        {
            return dal_MonHoc.ThemMonHoc(monHoc);
        }
        public bool XoaMonHoc(string id)
        {
            return dal_MonHoc.XoaMonHoc(id);
        }
        public bool ChinhSuaMonHoc(DTO_MonHoc monHoc)
        {
            return dal_MonHoc.ChinhSuaMonHoc(monHoc);
        }
        public DTO_MonHoc ChiTietMonHoc(string id)
        {
            return dal_MonHoc.ChiTietMonHoc(id);
        }
        public string TaoMaTuDong()
        {
            string currentID = dal_MonHoc.LayMaMonHocGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return "501001"; }

            int number = int.Parse(currentID.Substring(3, 3)) + 1;
            // Tạo mã mới với số thứ tự tăng lên
            if (number < 10)
                return "50000" + number.ToString();
            else if (number < 100)
                return "5000" + number.ToString();
            else
                return "500" + number.ToString();
        }
    }
}
