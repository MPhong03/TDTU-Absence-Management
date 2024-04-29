using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LopDay_NgayDay
    {
        public string MaSoSinhVien { get; set; }
        public DateTime NgayDay { get; set; }
        public DTO_LopDay_NgayDay(string MaSoSinhVien, DateTime NgayDay)
        {
            this.MaSoSinhVien = MaSoSinhVien;
            this.NgayDay = NgayDay;
        }
    }
}
