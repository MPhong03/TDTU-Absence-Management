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
    public class BUS_ThongBao
    {
        DAL_ThongBao dal_ThongBao;
        public BUS_ThongBao()
        {
            dal_ThongBao = new DAL_ThongBao();
        }
        public DataTable DanhSachThongBaoCuaGiangVien(string email)
        {
            return dal_ThongBao.DanhSachThongBaoCuaGiangVien(email);
        }
        public DataTable DanhSachThongBaoCuaSinhVien(string email)
        {
            return dal_ThongBao.DanhSachThongBaoCuaSinhVien(email);
        }
        public bool GuiThongBaoChoGiangVien(DTO_ThongBao thongBao, string[] idGiangVien)
        {
            return dal_ThongBao.GuiThongBaoChoGiangVien(thongBao, idGiangVien);
        }
        public bool GuiThongBaoChoSinhVien(DTO_ThongBao thongBao, string[] idSinhVien)
        {
            return dal_ThongBao.GuiThongBaoChoSinhVien(thongBao, idSinhVien);
        }
        public int TaoMaTuDong()
        {
            string currentID = dal_ThongBao.LayMaThongBaoGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return 1; }

            return int.Parse(currentID) + 1;
        }
    }
}
