﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BaoBu
    {
        public DataTable DanhSachBaoBu()
        {
            string cmd = "SELECT YeuCauBaoBu.MaBaoBu, YeuCauBaoBu.NgayBaoBu, YeuCauBaoBu.TrangThai, YeuCauBaoBu.CaBu, YeuCauBaoBu.PhongBu, YeuCauBaoBu.LoiNhan, YeuCauBaoBu.MaBaoVang, YeuCauBaoBu.MaLopDay, YeuCauBaoBu.MaSoGiangVien, GiangVien.HoVaTen " +
             "FROM YeuCauBaoBu " +
             "INNER JOIN GiangVien ON YeuCauBaoBu.MaSoGiangVien = GiangVien.MaSoGiangVien";

            return Connection.selectQuery(cmd);
        }
        public bool ThemYeuCauBaoBu(DTO_BaoBu bb)
        {
            string cmd = "INSERT INTO YeuCauBaoBu" +
                "(MaBaoBu, NgayBaoBu, TrangThai, CaBu, PhongBu, LoiNhan, MaBaoVang, MaLopDay, MaSoGiangVien) " +
                "VALUES (" +
                "'" + bb.MaBaoBu + "', " +
                "'" + bb.NgayBaoBu.ToString("yyyy-MM-dd") + "', " +
                "N'" + bb.TrangThai + "', " +
                "'" + bb.CaBu + "', " +
                "'" + bb.PhongBu + "', " +
                "N'" + bb.LoiNhan + "', " +
                "'" + bb.MaBaoVang + "', " +
                "'" + bb.MaLopDay + "', " +
                "'" + bb.MaSoGiangVien + "'" + ")";

            return Connection.actionQuery(cmd);
        }
        public DataTable DanhSachYeuCauBaoBuCuaGiangVienBangEmail(string email)
        {
            string cmd = "SELECT YeuCauBaoBu.MaBaoBu, YeuCauBaoBu.NgayBaoBu, YeuCauBaoBu.TrangThai, YeuCauBaoBu.CaBu, YeuCauBaoBu.PhongBu, YeuCauBaoBu.LoiNhan, YeuCauBaoBu.MaBaoVang, YeuCauBaoBu.MaLopDay, YeuCauBaoBu.MaSoGiangVien, GiangVien.HoVaTen " +
             "FROM YeuCauBaoBu " +
             "INNER JOIN GiangVien ON YeuCauBaoBu.MaSoGiangVien = GiangVien.MaSoGiangVien " +
             "WHERE GiangVien.Email = '" + email + "'";

            return Connection.selectQuery(cmd);
        }
        public bool XoaYeuCauBaoBu(int id)
        {
            string deleteQuery = "DELETE FROM YeuCauBaoBu WHERE MaBaoBu = '" + id + "'";
            return Connection.actionQuery(deleteQuery);
        }
        public string LayMaBaoBuGanNhat()
        {
            string cmd = "SELECT TOP 1 MaBaoBu FROM YeuCauBaoBu ORDER BY MaBaoBu DESC";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return row["MaBaoBu"].ToString();
            }
            else
            {
                return null;
            }
        }
        public DTO_BaoBu ChiTietBaoBu(int id)
        {
            string cmd = "SELECT * FROM YeuCauBaoBu WHERE MaBaoBu = '" + id + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                return new DTO_BaoBu(
                        int.Parse(row["MaBaoBu"].ToString()),
                        DateTime.Parse(row["NgayBaoBu"].ToString()),
                        row["TrangThai"].ToString(),
                        int.Parse(row["CaBu"].ToString()),
                        row["PhongBu"].ToString(),
                        row["LoiNhan"].ToString(),
                        int.Parse(row["MaBaoVang"].ToString()),
                        int.Parse(row["MaLopDay"].ToString()),
                        row["MaSoGiangVien"].ToString()
                    );
            }
            else
            {
                return null;
            }
        }
        public bool CapNhatTrangThaiYeuCauBaoBu(int id, string trangThai)
        {
            string cmd = "UPDATE YeuCauBaoBu SET TrangThai = N'" + trangThai + "' WHERE MaBaoBu = '" + id + "'";
            return Connection.actionQuery(cmd);
        }
    }
}
