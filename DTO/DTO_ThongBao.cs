using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThongBao
    {
        public int MaThongBao { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGianGui { get; set; }
        public string TenDangNhap { get; set; }
        public DTO_ThongBao(int MaThongBao, string TieuDe, string NoiDung, DateTime ThoiGianGui, string TenDangNhap)
        {
            this.MaThongBao = MaThongBao;
            this.TieuDe = TieuDe;
            this.NoiDung = NoiDung;
            this.ThoiGianGui = ThoiGianGui;
            this.TenDangNhap = TenDangNhap;

        }
    }
}
