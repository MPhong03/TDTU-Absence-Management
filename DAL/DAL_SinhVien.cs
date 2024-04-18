using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SinhVien
    {
        public DataTable DanhSachSinhVien()
        {
            string cmd = "SELECT * FROM SinhVien";
            return Connection.selectQuery(cmd);
        }

        public DataTable ThongTinSinhVienTheoMa(string maSV)
        {
            string cmd = "SELECT * FROM SinhVien WHERE MaSoSinhVien = '" + maSV + "' ";
            return Connection.selectQuery(cmd);
        }

        public DTO_SinhVien HienThongTinSV(string maSV)
        {
            DataRow row = ThongTinSinhVienTheoMa(maSV).Rows[0];

            DTO_SinhVien dSV = new DTO_SinhVien(
                row["MaSoSinhVien"].ToString(),
                row["Email"].ToString(),
                row["MatKhau"].ToString(),
                row["HoVaTen"].ToString(),
                DateTime.Parse(row["NgaySinh"].ToString()),
                row["GioiTinh"].ToString(),
                row["SoDienThoai"].ToString(),
                row["CCCD"].ToString(),
                row["ChuyenNganh"].ToString(),
                row["KhoaTuyenSinh"].ToString());

            return dSV;
        }
    }
}
