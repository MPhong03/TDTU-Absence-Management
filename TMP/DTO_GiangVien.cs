using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiangVien
    {
        public string MaSoGiangVien { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string HocHam { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public DTO_GiangVien(string MaSoGiangVien, string Email, string MatKhau, 
            string HoVaTen, DateTime NgaySinh, string GioiTinh, string HocHam, 
            string SoDienThoai, string CCCD, string DiaChi)
        {
            this.MaSoGiangVien = MaSoGiangVien;
            this.Email = Email;
            this.MatKhau = MatKhau;
            this.HoVaTen = HoVaTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.HocHam = HocHam;
            this.SoDienThoai = SoDienThoai;
            this.CCCD = CCCD;
            this.DiaChi = DiaChi;
        }

    }
}
