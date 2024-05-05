using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BaoVang
    {
        public DataTable DanhSachBaoVang()
        {
            string cmd = "SELECT YeuCauBaoVang.MaBaoVang, YeuCauBaoVang.NgayBaoVang, YeuCauBaoVang.LyDoBaoVang, YeuCauBaoVang.TrangThai, YeuCauBaoVang.MaLopDay, GiangVien.MaSoGiangVien, GiangVien.HoVaTen " +
             "FROM YeuCauBaoVang " +
             "INNER JOIN GiangVien ON YeuCauBaoVang.MaSoGiangVien = GiangVien.MaSoGiangVien";

            return Connection.selectQuery(cmd);
        }
        public bool ThemYeuCauBaoVang(DTO_BaoVang bv)
        {
            string cmd = "INSERT INTO YeuCauBaoVang" +
                "(MaBaoVang, NgayBaoVang, LyDoBaoVang, TrangThai, MaLopDay, MaSoGiangVien) " +
                "VALUES (" +
                "'" + bv.MaBaoVang + "', " +
                "'" + bv.NgayBaoVang.ToString("yyyy-MM-dd") + "', " +
                "N'" + bv.LyDoBaoVang + "', " +
                "N'" + bv.TrangThai + "', " +
                "'" + bv.MaLopDay + "', " +
                "'" + bv.MaSoGiangVien + "'" + ")";

            return Connection.actionQuery(cmd);
        }
        public string LayMaBaoVangGanNhat()
        {
            string cmd = "SELECT TOP 1 MaBaoVang FROM YeuCauBaoVang ORDER BY MaBaoVang DESC";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return row["MaBaoVang"].ToString();
            }
            else
            {
                return null;
            }
        }
        public DataTable DanhSachYeuCauBaoVangCuaGiangVienBangEmail(string email)
        {
            string cmd = "SELECT YeuCauBaoVang.MaBaoVang, YeuCauBaoVang.NgayBaoVang, YeuCauBaoVang.LyDoBaoVang, YeuCauBaoVang.TrangThai, YeuCauBaoVang.MaLopDay, GiangVien.MaSoGiangVien, GiangVien.HoVaTen " +
             "FROM YeuCauBaoVang " +
             "INNER JOIN GiangVien ON YeuCauBaoVang.MaSoGiangVien = GiangVien.MaSoGiangVien " +
             "WHERE GiangVien.Email = '" + email + "'";

            return Connection.selectQuery(cmd);
        }
        public bool XoaYeuCauBaoVang(int id)
        {
            string deleteBaoBu = "DELETE FROM YeuCauBaoBu WHERE MaBaoVang = '" + id + "'";
            string deleteBaoVang = "DELETE FROM YeuCauBaoVang WHERE MaBaoVang = '" + id + "'";
            string deleteQuery = deleteBaoBu + "; " + deleteBaoVang;
            return Connection.actionQuery(deleteQuery);
        }
        public DTO_BaoVang ChiTietBaoVang(int id)
        {
            string cmd = "SELECT * FROM YeuCauBaoVang WHERE MaBaoVang = '" + id + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                return new DTO_BaoVang(
                        int.Parse(row["MaBaoVang"].ToString()),
                        DateTime.Parse(row["NgayBaoVang"].ToString()),
                        row["LyDoBaoVang"].ToString(),
                        row["TrangThai"].ToString(),
                        int.Parse(row["MaLopDay"].ToString()),
                        row["MaSoGiangVien"].ToString()
                    );
            }
            else
            {
                return null;
            }
        }
        public bool CapNhatTrangThaiYeuCauBaoVang(int id, string trangThai)
        {
            string cmd = "UPDATE YeuCauBaoVang SET TrangThai = N'" + trangThai + "' WHERE MaBaoVang = '" + id + "'";
            return Connection.actionQuery(cmd);
        }
    }
}
