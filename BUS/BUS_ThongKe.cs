﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ThongKe
    {
        DAL_GiangVien dal_GV;
        DAL_SinhVien dal_SV;
        DAL_BaoVang dal_BV;
        DAL_BaoBu dal_BB;
        public BUS_ThongKe()
        {
            dal_GV = new DAL_GiangVien();
            dal_SV = new DAL_SinhVien();
            dal_BV = new DAL_BaoVang();
            dal_BB = new DAL_BaoBu();
        }
        public int SoLuongSinhVien()
        {
            return dal_SV.DanhSachSinhVien().Rows.Count;
        }
        public int SoLuongGiangVien()
        {
            return dal_GV.DanhSachGiangVien().Rows.Count;
        }
        public int SoLuongBaoVangDaDuocGui()
        {
            return dal_BV.DanhSachBaoVang().Rows.Count;
        }
        public int SoLuongBaoBuDaDuocGui()
        {
            return dal_BB.DanhSachBaoBu().Rows.Count;
        }
        public Dictionary<string, int> DuLieuThongKeGiangVienBaoVang()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            DataTable gvList = dal_GV.DanhSachGiangVien();

            foreach (DataRow row in gvList.Rows)
            {
                DataTable bvList = dal_BV.DanhSachBaoVangDaDuyetTheoMaSoGiangVien(row["MaSoGiangVien"].ToString(), "CHẤP NHẬN");
                string key = row["HoVaTen"].ToString() + "(" + row["MaSoGiangVien"].ToString() + ")";
                int value = bvList.Rows.Count;

                result[key] = value;
            }

            return result;
        }
    }
}
