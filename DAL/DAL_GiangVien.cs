using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiangVien
    {
        public DataTable DanhSachGiangVien()
        {
            string cmd = "SELECT * FROM GiangVien";
            return Connection.selectQuery(cmd);
        }

        public DTO_GiangVien ChiTietGiangVien(string maSoGiangVien)
        {
            string cmd = "SELECT * FROM GiangVien WHERE MaSoGiangVien = '" + maSoGiangVien + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0 )
            {
                DataRow row = result.Rows[0];

                DTO_GiangVien giangVien = new DTO_GiangVien(
                    row["MaSoGiangVien"].ToString(),
                    row["Email"].ToString(),
                    row["MatKhau"].ToString(),
                    row["HoVaTen"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["GioiTinh"].ToString(),
                    row["HocHam"].ToString(),
                    row["SoDienThoai"].ToString(),
                    row["CCCD"].ToString(),
                    row["DiaChi"].ToString()
                );

                return giangVien;

            }
            else
            {
                return null;
            }

        }

        public string LayMaGiangVienGanNhat()
        {
            string cmd = "SELECT TOP 1 MaSoGiangVien FROM GiangVien ORDER BY MaSoGiangVien DESC";

            DataRow row = Connection.selectQuery(cmd).Rows[0];

            return row["MaSoGiangVien"].ToString();
        }

        public string KiemTraEmail(string email)
        {
            string cmd = "SELECT MaSoGiangVien FROM GiangVien WHERE Email = '" + email +"'";

            DataRow row = Connection.selectQuery(cmd).Rows[0];

            return row["MaSoGiangVien"].ToString();
        }

        public bool ThemGiangVien(DTO_GiangVien giangVien)
        {
            string cmd = "INSERT INTO GiangVien" +
                "(MaSoGiangVien, Email, MatKhau, HoVaTen, NgaySinh, GioiTinh, HocHam, SoDienThoai, CCCD, DiaChi) " +
                "VALUES (" 
                + "'" + giangVien.MaSoGiangVien +  "'" + "," 
                + "'" + giangVien.Email + "'" + ","
                + "'" + giangVien.MatKhau + "'" + ","
                + "N'" + giangVien.HoVaTen + "'" + ","
                + "'" + giangVien.NgaySinh.ToString("yyyy-MM-dd") + "'" + ","
                + "N'" + giangVien.GioiTinh + "'" + ","
                + "N'" + giangVien.HocHam + "'" + ","
                + "'" + giangVien.SoDienThoai + "'" + ","
                + "'" + giangVien.CCCD + "'" + ","
                + "N'" + giangVien.DiaChi +  "'" + ")";

            return Connection.actionQuery(cmd);
        }

        public bool XoaGiangVien(string id)
        {
            string cmd = "DELETE FROM GiangVien WHERE MaSoGiangVien = '" + id + "'";

            return Connection.actionQuery(cmd);
        }

        public bool SuaGiangVien(DTO_GiangVien giangVien)
        {
            string cmd = "UPDATE GiangVien SET " +
                "Email = '" + giangVien.Email + "', " +
                "MatKhau = '" + giangVien.MatKhau + "', " +
                "HoVaTen = N'" + giangVien.HoVaTen + "', " +
                "NgaySinh = '" + giangVien.NgaySinh.ToString("yyyy-MM-dd") + "', " +
                "GioiTinh = N'" + giangVien.GioiTinh + "', " +
                "HocHam = N'" + giangVien.HocHam + "', " +
                "SoDienThoai = '" + giangVien.SoDienThoai + "', " +
                "CCCD = '" + giangVien.CCCD + "', " +
                "DiaChi = N'" + giangVien.DiaChi + "' " +
                "WHERE MaSoGiangVien = '" + giangVien.MaSoGiangVien + "'";

            return Connection.actionQuery(cmd);
        }

    }
}
