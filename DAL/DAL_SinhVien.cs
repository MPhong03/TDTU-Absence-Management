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

        public DTO_SinhVien HienThongTinSV(string maSV)
        {
            string cmd = "SELECT * FROM SinhVien WHERE MaSoSinhVien = '" + maSV + "'";
            DataRow row = Connection.selectQuery(cmd).Rows[0];
            DTO_SinhVien sinhvien = new DTO_SinhVien(
                row["MaSoSinhVien"].ToString(),
                row["Email"].ToString(),
                row["MatKhau"].ToString(),
                row["HoVaTen"].ToString(),
                DateTime.Parse(row["NgaySinh"].ToString()),
                row["GioiTinh"].ToString(),
                row["SoDienThoai"].ToString(),
                row["CCCD"].ToString(),
                row["ChuyenNganh"].ToString(),
                row["KhoaTuyenSinh"].ToString()
            );

            return sinhvien;
        }

        public DataTable getSVDesc()
        {
            string cmd = "SELECT TOP 1 MaSoSinhVien FROM SinhVien ORDER BY MaSoSinhVien DESC";
            return Connection.selectQuery(cmd);
        }

        public bool checkEmail(string email)
        {
            string cmd = "SELECT * FROM SinhVien WHERE Email = '" +email+ "' ";
            int row = Connection.selectQuery(cmd).Rows.Count;

            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public void ThemSinhVienMoi(string maSV,string email,string pass,string fname, DateTime dateBirth,
                                         string gender,string phone,string cccd, string academic,string course)
        {
            String cmd = "INSERT INTO SinhVien VALUES ('" +maSV+ "','" +email+ "','" +pass+ "',N'" +fname+ "','" +dateBirth+ "'," +
                                                        "N'" + gender+ "','" +phone+ "','" +cccd+ "',N'" + academic+ "','" +course+ "')";
            Connection.actionQuery(cmd);
        }

        public void SuaSinhVien(string maSV, string email, string pass, string fname, DateTime dateBirth,
                                        string gender, string phone, string cccd, string academic, string course)
        {
            String cmd = "UPDATE SinhVien SET Email = '" + email + "', MatKhau = '" + pass + "', HoVaTen = N'" + fname + "', NgaySinh = '" + dateBirth + "'," +
                                                        "GioiTinh = N'" + gender + "', SoDienThoai = '" + phone + "', CCCD = '" + cccd + "', " +
                                                        "ChuyenNganh = N'" + academic + "' WHERE MaSoSinhVien = '" +maSV+ "' AND KhoaTuyenSinh = '" + course + "'";
            Connection.actionQuery(cmd);
        }

        public void XoaSinhVien(string maSV)
        {
            String cmd = "DELETE FROM SinhVien WHERE MaSoSinhVien = '" +maSV+ "'";
            Connection.actionQuery(cmd);
        }
    }
}
