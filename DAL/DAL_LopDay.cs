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
            string cmd = "SELECT LopDay.MaLopDay, LopDay.SoBuoiDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.MaSoGiangVien, " +
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
            string cmd = "SELECT LopDay.MaLopDay, LopDay.SoBuoiDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.MaSoGiangVien, " +
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
        public bool ThemLopDay(DTO_LopDay lopDay, DTO_LopDay_NgayDay[] ngayDayList, string[] mssvList)
        {
            // Truy vấn để thêm thông tin lớp học vào bảng LopDay
            string cmd1 = "INSERT INTO LopDay " +
                          "(MaLopDay, SoBuoiDay, Nhom, ToTH, MaSoGiangVien, MaSoMonHoc) " +
                          "VALUES (" +
                          "'" + lopDay.MaLopDay + "', " +
                          "'" + lopDay.SoBuoiDay + "', " +
                          "'" + lopDay.Nhom + "', " +
                          "'" + lopDay.ToTH + "', " +
                          "'" + lopDay.MaSoGiangVien + "', " +
                          "'" + lopDay.MaSoMonHoc + "')";

            // Truy vấn để thêm danh sách các ngày dạy của lớp vào bảng LopDay_NgayDay
            string cmd2 = "";
            foreach (DTO_LopDay_NgayDay ngayDay in ngayDayList)
            {
                cmd2 += "INSERT INTO LopDay_NgayDay (NgayDay, MaLopDay, CaDay, Phong, TrangThai) " +
                        "VALUES ('" + ngayDay.NgayDay.ToString("yyyy-MM-dd") + "', '" + lopDay.MaLopDay + "', '" + ngayDay.CaDay + "', '" + ngayDay.Phong + "', '" + ngayDay.TrangThai + "'); ";
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
        public Tuple<DTO_LopDay, DTO_LopDay_NgayDay[], string[]> ChiTietLopDayTheoMaLopDay(int maLopDay)
        {
            DTO_LopDay lopDay = null;
            DTO_LopDay_NgayDay[] ngayDayList = null;
            string[] mssvList = null;

            // Lấy thông tin từ bảng LopDay
            string cmdLopDay = "SELECT * FROM LopDay WHERE MaLopDay = '" + maLopDay + "'";
            DataTable dtLopDay = Connection.selectQuery(cmdLopDay);

            if (dtLopDay.Rows.Count > 0)
            {
                string cmdLopDay_NgayDay = "SELECT * FROM LopDay_NgayDay WHERE MaLopDay = '" + maLopDay + "'";
                DataTable dtLopDay_NgayDay = Connection.selectQuery(cmdLopDay_NgayDay);

                // Khởi tạo mảng DTO_LopDay_NgayDay
                ngayDayList = new DTO_LopDay_NgayDay[dtLopDay_NgayDay.Rows.Count];

                for (int i = 0; i < dtLopDay_NgayDay.Rows.Count; i++)
                {
                    DataRow rowLopDay_NgayDay = dtLopDay_NgayDay.Rows[i];
                    ngayDayList[i] = new DTO_LopDay_NgayDay(
                        int.Parse(rowLopDay_NgayDay["MaLopDay"].ToString()),
                        DateTime.Parse(rowLopDay_NgayDay["NgayDay"].ToString()),
                        int.Parse(rowLopDay_NgayDay["CaDay"].ToString()),
                        rowLopDay_NgayDay["Phong"].ToString(),
                        rowLopDay_NgayDay["TrangThai"].ToString()
                    );
                }

                // Lấy thông tin từ bảng SinhVien_LopDay
                string cmdSinhVien_LopDay = "SELECT MaSoSinhVien FROM SinhVien_LopDay WHERE MaLopDay = '" + maLopDay + "'";
                DataTable dtSinhVien_LopDay = Connection.selectQuery(cmdSinhVien_LopDay);
                mssvList = dtSinhVien_LopDay.AsEnumerable().Select(row => row.Field<string>("MaSoSinhVien")).ToArray();

                DataRow rowLopDay = dtLopDay.Rows[0];
                lopDay = new DTO_LopDay(
                    int.Parse(rowLopDay["MaLopDay"].ToString()),
                    int.Parse(rowLopDay["SoBuoiDay"].ToString()),
                    rowLopDay["Nhom"].ToString(),
                    rowLopDay["ToTH"].ToString(),
                    rowLopDay["MaSoGiangVien"].ToString(),
                    rowLopDay["MaSoMonHoc"].ToString()
                );
            }

            return Tuple.Create(lopDay, ngayDayList, mssvList);
        }
    }
}
