﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTUAbsenceReportingManagement.Model
{
    public class SinhVien
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
    }

}
