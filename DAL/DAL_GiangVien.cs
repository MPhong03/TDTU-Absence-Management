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
            string cmd = "SELECT * FROM GiangVien WHERE MaSoGiangVien = " + maSoGiangVien;

            DataRow row = Connection.selectQuery(cmd).Rows[0];

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
    }
}
