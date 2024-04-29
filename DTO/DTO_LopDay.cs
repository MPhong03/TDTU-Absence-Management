using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LopDay
    {
        public int MaLopDay { get; set; }
        public int CaDay { get; set; }
        public int SoBuoiDay { get; set; }
        public string Nhom { get; set; } = string.Empty;
        public string ToTH { get; set; } = string.Empty;
        public string Phong { get; set; } = string.Empty;
        public string MaSoGiangVien { get; set; } = string.Empty;
        public string MaSoMonHoc { get; set; } = string.Empty;
        public DTO_LopDay(int MaLopDay, int CaDay, int SoBuoiDay, string Nhom, string ToTH, 
            string Phong, string MaSoGiangVien, string MaSoMonHoc)
        {
            this.MaLopDay = MaLopDay;
            this.CaDay = CaDay;
            this.SoBuoiDay = SoBuoiDay;
            this.Nhom = Nhom;
            this.ToTH = ToTH;
            this.Phong = Phong;
            this.MaSoGiangVien = MaSoGiangVien;
            this.MaSoMonHoc = MaSoMonHoc;
        }
    }
}
