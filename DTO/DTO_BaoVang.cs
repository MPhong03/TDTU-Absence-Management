using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoVang
    {
        public int MaBaoVang { get; set; }
        public DateTime NgayBaoVang { get; set; }
        public string LyDoBaoVang { get; set; }
        public string TrangThai { get; set; } = "CHƯA XỬ LÝ";
        public int MaLopDay { get; set; }
        public string MaSoGiangVien { get; set; }
        public DTO_BaoVang()
        {
            
        }
        public DTO_BaoVang(int MaBaoVang, DateTime NgayBaoVang, string LyDoBaoVang, string TrangThai, int MaLopDay, string MaSoGiangVien)
        {
            this.MaBaoVang = MaBaoVang;
            this.NgayBaoVang = NgayBaoVang;
            this.LyDoBaoVang = LyDoBaoVang;
            this.TrangThai = TrangThai;
            this.MaLopDay = MaLopDay;
            this.MaSoGiangVien = MaSoGiangVien;
        }
    }                      
}                          
