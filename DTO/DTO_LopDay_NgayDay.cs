using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LopDay_NgayDay
    {
        public int MaLopDay { get; set; }
        public DateTime NgayDay { get; set; }
        public int CaDay { get; set; }
        public string Phong { get; set; } = string.Empty;
        public string TrangThai { get; set; } = string.Empty;
        // Có 3 trạng thái "ĐANG HIỆU LỰC", "VẮNG" và "BÙ"
        public DTO_LopDay_NgayDay(int MaLopDay, DateTime NgayDay, int CaDay, string Phong, string TrangThai)
        {
            this.MaLopDay = MaLopDay;
            this.NgayDay = NgayDay;
            this.CaDay = CaDay;
            this.Phong = Phong;
            this.TrangThai = TrangThai;
        }
    }
}
