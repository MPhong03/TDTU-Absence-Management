using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        public string MaSoSinhVien { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string CCCD { get; set; }
        public string ChuyenNganh { get; set; }
        public string KhoaTuyenSinh { get; set; }
        public DTO_SinhVien(string MaSoSinhVien, string Email, string MatKhau,
            string HoVaTen, DateTime NgaySinh, string GioiTinh, string SoDienThoai, 
            string CCCD, string ChuyenNganh, string khoaTuyenSinh)
        {
            this.MaSoSinhVien = MaSoSinhVien;
            this.Email = Email;
            this.MatKhau = MatKhau;
            this.HoVaTen = HoVaTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SoDienThoai = SoDienThoai;
            this.CCCD = CCCD;
            this.ChuyenNganh = ChuyenNganh;
            this.KhoaTuyenSinh = khoaTuyenSinh;
        }
    }
}
