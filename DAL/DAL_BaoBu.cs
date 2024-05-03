using DTO;
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
            string cmd = "SELECT YeuCauBaoBu.* , GiangVien.HoVaTen " +
             "FROM YeuCauBaoBu " +
             "INNER JOIN GiangVien ON YeuCauBaoBu.MaSoGiangVien = GiangVien.MaSoGiangVien " +
             "WHERE GiangVien.Email = '" + email + "'";

            return Connection.selectQuery(cmd);
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
    }
}
