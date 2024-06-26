﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BaoVang
    {
        DAL_BaoVang dal_BV;
        public BUS_BaoVang()
        {
            dal_BV = new DAL_BaoVang();
        }
        public DataTable DanhSachBaoVang()
        {
            return dal_BV.DanhSachBaoVang();
        }
        public bool ThemYeuCauBaoVang(DTO_BaoVang bv)
        {
            return dal_BV.ThemYeuCauBaoVang(bv);
        }
        public DataTable DanhSachYeuCauBaoVangCuaGiangVienBangEmail(string email)
        {
            return dal_BV.DanhSachYeuCauBaoVangCuaGiangVienBangEmail(email);
        }
        public bool XoaYeuCauBaoVang(int id)
        {
            return dal_BV.XoaYeuCauBaoVang(id);
        }
        public DTO_BaoVang ChiTietBaoVang(int id)
        {
            return dal_BV.ChiTietBaoVang(id);
        }
        public bool CapNhatTrangThaiYeuCauBaoVang(int id, string trangThai)
        {
            return dal_BV.CapNhatTrangThaiYeuCauBaoVang(id, trangThai);
        }
        public int TaoMaTuDong()
        {
            string currentID = dal_BV.LayMaBaoVangGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return 1; }

            return int.Parse(currentID) + 1;
        }
    }
}
