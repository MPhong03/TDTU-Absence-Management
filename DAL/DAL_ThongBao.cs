using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongBao
    {
        public DataTable DanhSachThongBaoCuaGiangVien(string email)
        {
            string query = @"SELECT tb.MaThongBao, tb.TenDangNhap, tb.TieuDe, tb.NoiDung, tb.ThoiGianGui
                    FROM ThongBao tb
                    INNER JOIN ThongBao_GiangVien tbgv ON tb.MaThongBao = tbgv.MaThongBao
                    INNER JOIN GiangVien gv ON tbgv.MaSoGiangVien = gv.MaSoGiangVien
                    WHERE gv.Email = '" + email + "'";

            return Connection.selectQuery(query);
        }
        public bool GuiThongBaoChoGiangVien(DTO_ThongBao thongBao, string[] idGiangVien)
        {
            string cmdThongBao = "INSERT INTO ThongBao (MaThongBao, TieuDe, NoiDung, ThoiGianGui, TenDangNhap) " +
                         "VALUES ('" + thongBao.MaThongBao + "', N'" + thongBao.TieuDe + "', N'" + thongBao.NoiDung + "', '" + thongBao.ThoiGianGui.ToString("yyyy-MM-dd") + "', '" + thongBao.TenDangNhap + "')";
            bool success1 = Connection.actionQuery(cmdThongBao);

            if (!success1)
            {
                return false;
            }

            foreach (string id in idGiangVien)
            {
                string cmdThongBao_GiangVien = "INSERT INTO ThongBao_GiangVien (MaThongBao, MaSoGiangVien) " +
                                               "VALUES (" + thongBao.MaThongBao + ", '" + id + "')";
                bool success2 = Connection.actionQuery(cmdThongBao_GiangVien);
                
                if (!success2)
                {
                    return false;
                }
            }

            return true;
        }

        public bool GuiThongBaoChoSinhVien(DTO_ThongBao thongBao, string[] idSinhVien)
        {
            string cmdThongBao = "INSERT INTO ThongBao (MaThongBao, TieuDe, NoiDung, ThoiGianGui, TenDangNhap) " +
                         "VALUES ('" + thongBao.MaThongBao + "', N'" + thongBao.TieuDe + "', N'" + thongBao.NoiDung + "', '" + thongBao.ThoiGianGui.ToString("yyyy-MM-dd") + "', '" + thongBao.TenDangNhap + "')";
            bool success1 = Connection.actionQuery(cmdThongBao);

            if (!success1)
            {
                return false;
            }

            foreach (string id in idSinhVien)
            {
                string cmdThongBao_SinhVien = "INSERT INTO ThongBao_SinhVien (MaThongBao, MaSoSinhVien) " +
                                               "VALUES (" + thongBao.MaThongBao + ", '" + id + "')";
                bool success2 = Connection.actionQuery(cmdThongBao_SinhVien);

                if (!success2)
                {
                    return false;
                }
            }

            return true;
        }

        public string LayMaThongBaoGanNhat()
        {
            string cmd = "SELECT TOP 1 MaThongBao FROM ThongBao ORDER BY MaThongBao DESC";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return row["MaThongBao"].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
