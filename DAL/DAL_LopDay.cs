using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LopDay
    {
        public DataTable DanhSachLopDayTheoMaSoGiangVien(string id)
        {
            string cmd = "SELECT LopDay.MaLopDay, LopDay.CaDay, LopDay.SoBuoiDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.Phong, LopDay.MaSoGiangVien, " +
                 "GiangVien.HoVaTen AS TenGiangVien, LopDay.MaSoMonHoc, MonHoc.TenMonHoc " +
                 "FROM LopDay " +
                 "INNER JOIN GiangVien ON LopDay.MaSoGiangVien = GiangVien.MaSoGiangVien " +
                 "INNER JOIN MonHoc ON LopDay.MaSoMonHoc = MonHoc.MaSoMonHoc " +
                 "WHERE LopDay.MaSoGiangVien = '" + id + "'";

            DataTable result =  Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return new DataTable();
            }
        }
        public DataTable DanhSachLopDayTheoEmailGiangVien(string email)
        {
            string cmd = "SELECT LopDay.MaLopDay, LopDay.CaDay, LopDay.SoBuoiDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.Phong, LopDay.MaSoGiangVien, " +
                 "GiangVien.HoVaTen AS TenGiangVien, LopDay.MaSoMonHoc, MonHoc.TenMonHoc " +
                 "FROM LopDay " +
                 "INNER JOIN GiangVien ON LopDay.MaSoGiangVien = GiangVien.MaSoGiangVien " +
                 "INNER JOIN MonHoc ON LopDay.MaSoMonHoc = MonHoc.MaSoMonHoc " +
                 "WHERE GiangVien.Email = '" + email + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                return result;
            }
            else
            {
                return new DataTable();
            }
        }
        public string LayMaLopDayGanNhat()
        {
            string cmd = "SELECT TOP 1 MaLopDay FROM LopDay ORDER BY MaLopDay DESC";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return row["MaLopDay"].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        public bool ThemLopDay(DTO_LopDay lopDay, string[] ngayDayList, string[] mssvList)
        {
            // Truy vấn để thêm thông tin lớp học vào bảng LopDay
            string cmd1 = "INSERT INTO LopDay " +
                          "(MaLopDay, CaDay, SoBuoiDay, Nhom, ToTH, Phong, MaSoGiangVien, MaSoMonHoc) " +
                          "VALUES (" +
                          "'" + lopDay.MaLopDay + "', " +
                          "'" + lopDay.CaDay + "', " +
                          "'" + lopDay.SoBuoiDay + "', " +
                          "'" + lopDay.Nhom + "', " +
                          "'" + lopDay.ToTH + "', " +
                          "'" + lopDay.Phong + "', " +
                          "'" + lopDay.MaSoGiangVien + "', " +
                          "'" + lopDay.MaSoMonHoc + "')";

            // Truy vấn để thêm danh sách các ngày dạy của lớp vào bảng LopDay_NgayDay
            string cmd2 = "";
            foreach (string ngayDay in ngayDayList)
            {
                cmd2 += "INSERT INTO LopDay_NgayDay (NgayDay, MaLopDay) " +
                        "VALUES ('" + DateTime.Parse(ngayDay).ToString("yyyy-MM-dd") + "', '" + lopDay.MaLopDay + "'); ";
            }

            // Truy vấn để thêm danh sách các sinh viên vào lớp vào bảng SinhVien_LopDay
            string cmd3 = "";
            foreach (string mssv in mssvList)
            {
                cmd3 += "INSERT INTO SinhVien_LopDay (MaSoSinhVien, MaLopDay) " +
                        "VALUES ('" + mssv + "', '" + lopDay.MaLopDay + "'); ";
            }

            return Connection.actionQuery(cmd1 + cmd2 + cmd3);
        }
        public bool XoaLopDay(int id)
        {
            try
            {
                // 1. Xóa các tham chiếu từ bảng LopDay_NgayDay
                string cmdDeleteLopDay_NgayDay = "DELETE FROM LopDay_NgayDay WHERE MaLopDay = '" + id + "'";
                Connection.actionQuery(cmdDeleteLopDay_NgayDay);

                // 2. Xóa các tham chiếu từ bảng SinhVien_LopDay
                string cmdDeleteSinhVien_LopDay = "DELETE FROM SinhVien_LopDay WHERE MaLopDay = '" + id + "'";
                Connection.actionQuery(cmdDeleteSinhVien_LopDay);

                // 3. Xóa dữ liệu từ bảng LopDay
                string cmdDeleteLopDay = "DELETE FROM LopDay WHERE MaLopDay = '" + id + "'";
                Connection.actionQuery(cmdDeleteLopDay);

                // Trả về true nếu không có lỗi xảy ra
                return true;
            }
            catch (Exception ex)
            {
                // Trả về false nếu có lỗi xảy ra
                Console.WriteLine("Lỗi xóa lớp học: " + ex.Message);
                return false;
            }
        }
        public Tuple<DTO_LopDay, string[], string[]> ChiTietLopDayTheoMaLopDay(int maLopDay)
        {
            DTO_LopDay lopDay = null;
            string[] ngayDayList = null;
            string[] mssvList = null;

            // Lấy thông tin từ bảng LopDay
            string cmdLopDay = "SELECT * FROM LopDay WHERE MaLopDay = '" + maLopDay + "'";
            DataTable dtLopDay = Connection.selectQuery(cmdLopDay);

            if (dtLopDay.Rows.Count > 0)
            {
                // Lấy thông tin từ bảng LopDay_NgayDay
                string cmdLopDay_NgayDay = "SELECT NgayDay FROM LopDay_NgayDay WHERE MaLopDay = '" + maLopDay + "'";
                DataTable dtLopDay_NgayDay = Connection.selectQuery(cmdLopDay_NgayDay);
                ngayDayList = dtLopDay_NgayDay.AsEnumerable().Select(row => (row.Field<DateTime>("NgayDay")).ToString()).ToArray();

                // Lấy thông tin từ bảng SinhVien_LopDay
                string cmdSinhVien_LopDay = "SELECT MaSoSinhVien FROM SinhVien_LopDay WHERE MaLopDay = '" + maLopDay + "'";
                DataTable dtSinhVien_LopDay = Connection.selectQuery(cmdSinhVien_LopDay);
                mssvList = dtSinhVien_LopDay.AsEnumerable().Select(row => row.Field<string>("MaSoSinhVien")).ToArray();

                DataRow rowLopDay = dtLopDay.Rows[0];
                lopDay = new DTO_LopDay(
                    int.Parse(rowLopDay["MaLopDay"].ToString()),
                    int.Parse(rowLopDay["CaDay"].ToString()),
                    int.Parse(rowLopDay["SoBuoiDay"].ToString()),
                    rowLopDay["Nhom"].ToString(),
                    rowLopDay["ToTH"].ToString(),
                    rowLopDay["Phong"].ToString(),
                    rowLopDay["MaSoGiangVien"].ToString(),
                    rowLopDay["MaSoMonHoc"].ToString()
                );
            }

            return Tuple.Create(lopDay, ngayDayList, mssvList);
        }
    }
}
