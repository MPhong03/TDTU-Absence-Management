﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoBu
    {
        public int MaBaoBu { get; set; }
        public DateTime NgayBaoBu { get; set; }
        public string TrangThai { get; set; } = "CHƯA XỬ LÝ";
        public int CaBu { get; set; }
        public string PhongBu { get; set; }
        public string LoiNhan { get; set; }
        public int MaBaoVang { get; set; }
        public int MaLopDay { get; set; }
        public string MaSoGiangVien { get; set; }
        public DTO_BaoBu()
        {
            
        }
        public DTO_BaoBu(
                int MaBaoBu,
                DateTime NgayBaoBu,
                string TrangThai,
                int CaBu,
                string PhongBu,
                string LoiNhan,
                int MaBaoVang,
                int MaLopDay,
                string MaSoGiangVien
            )
        {
            this.MaBaoBu = MaBaoBu;
            this.NgayBaoBu = NgayBaoBu;
            this.TrangThai = TrangThai;
            this.CaBu = CaBu;
            this.PhongBu = PhongBu;
            this.LoiNhan = LoiNhan;
            this.MaBaoVang = MaBaoVang;
            this.MaLopDay = MaLopDay;
            this.MaSoGiangVien = MaSoGiangVien;
        }
    }
}
