using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien_LopDay
    {
        public string MaSoSinhVien { get; set; }
        public int MaLopDay { get; set; }
        public DTO_SinhVien_LopDay(string MaSoSinhVien, int MaLopDay)
        {
            this.MaSoSinhVien = MaSoSinhVien;
            this.MaLopDay = MaLopDay;
        }
    }
}
