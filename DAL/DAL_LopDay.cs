﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
        public DataTable DanhSachLopDayTheoMaSoGiangVienHomNay(string id, DateTime date)
        {
            string cmd = "SELECT LopDay.MaLopDay, LopDay_NgayDay.NgayDay, LopDay_NgayDay.TrangThai, LopDay_NgayDay.CaDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.MaSoGiangVien, " +
                 "LopDay.MaSoMonHoc, MonHoc.TenMonHoc, MonHoc.MaSoMonHoc " +
                 "FROM LopDay " +
                 "INNER JOIN GiangVien ON LopDay.MaSoGiangVien = GiangVien.MaSoGiangVien " +
                 "INNER JOIN MonHoc ON LopDay.MaSoMonHoc = MonHoc.MaSoMonHoc " +
                 "INNER JOIN LopDay_NgayDay ON LopDay_NgayDay.MaLopDay = LopDay.MaLopDay " +
                 "WHERE LopDay.MaSoGiangVien = '" + id + "' AND LopDay_NgayDay.NgayDay = '" + date.ToString("yyyy-MM-dd") + "' " +
                 "ORDER BY CaDay ASC";

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
        public DataTable DanhSachLopDayTheoMaSoSinhVienHomNay(string id, DateTime date)
        {
            string cmd = "SELECT LopDay.MaLopDay, LopDay_NgayDay.NgayDay, LopDay_NgayDay.TrangThai, LopDay_NgayDay.CaDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.MaSoGiangVien, " +
                 "LopDay.MaSoMonHoc, MonHoc.TenMonHoc, MonHoc.MaSoMonHoc " +
                 "FROM LopDay " +
                 "INNER JOIN GiangVien ON LopDay.MaSoGiangVien = GiangVien.MaSoGiangVien " +
                 "INNER JOIN MonHoc ON LopDay.MaSoMonHoc = MonHoc.MaSoMonHoc " +
                 "INNER JOIN LopDay_NgayDay ON LopDay_NgayDay.MaLopDay = LopDay.MaLopDay " +
                 "INNER JOIN SinhVien_LopDay ON SinhVien_LopDay.MaLopDay = LopDay.MaLopDay " +
                 "WHERE SinhVien_LopDay.MaSoSinhVien = '" + id + "' AND LopDay_NgayDay.NgayDay = '" + date.ToString("yyyy-MM-dd") + "' " +
                 "ORDER BY CaDay ASC";

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
        public DataTable DanhSachLopDayTheoMaSoSinhVien(string id)
        {
            string cmd = "SELECT LopDay.MaLopDay, LopDay.SoBuoiDay, " +
                 "LopDay.Nhom, LopDay.ToTH, LopDay.MaSoGiangVien, " +
                 "GiangVien.HoVaTen AS TenGiangVien, LopDay.MaSoMonHoc, MonHoc.TenMonHoc " +
                 "FROM LopDay " +
                 "INNER JOIN GiangVien ON LopDay.MaSoGiangVien = GiangVien.MaSoGiangVien " +
                 "INNER JOIN MonHoc ON LopDay.MaSoMonHoc = MonHoc.MaSoMonHoc " +
                 "INNER JOIN SinhVien_LopDay ON LopDay.MaLopDay = SinhVien_LopDay.MaLopDay " +
                 "WHERE SinhVien_LopDay.MaSoSinhVien = '" + id + "'";

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
                        "VALUES ('" + ngayDay.NgayDay.ToString("yyyy-MM-dd") + "', '" + lopDay.MaLopDay + "', '" + ngayDay.CaDay + "', '" + ngayDay.Phong + "', N'" + ngayDay.TrangThai + "'); ";
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

                string cmdDeleteBaoBu = "DELETE FROM YeuCauBaoBu WHERE MaLopDay = '" + id + "'";
                Connection.actionQuery(cmdDeleteBaoBu);
                string cmdDeleteBaoVang = "DELETE FROM YeuCauBaoVang WHERE MaLopDay = '" + id + "'";
                Connection.actionQuery(cmdDeleteBaoVang);

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

        public DataRow ChiTietLopDayTheoNgay(int maLopDay, DateTime ngayDay)
        {
            string cmd = "SELECT ld.MaLopDay, ld.SoBuoiDay, ld.Nhom, ld.ToTH, ld.MaSoGiangVien, ld.MaSoMonHoc, ldn.NgayDay, ldn.CaDay, ldn.Phong, ldn.TrangThai " +
                "FROM LopDay ld INNER JOIN LopDay_NgayDay ldn ON ld.MaLopDay = ldn.MaLopDay " +
                "WHERE ld.MaLopDay = '" + maLopDay + "' AND ldn.NgayDay = '" + ngayDay.ToString("yyyy-MM-dd") + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public bool CapNhatLopDay(DTO_LopDay lopDay, DTO_LopDay_NgayDay[] ngayDayList, string[] mssvList)
        {
            // Cập nhật thông tin lớp học
            string cmdUpdateLopDay = "UPDATE LopDay SET SoBuoiDay = '" + lopDay.SoBuoiDay + "', Nhom = '" + lopDay.Nhom + "', ToTH = '" + lopDay.ToTH + "', MaSoGiangVien = '" + lopDay.MaSoGiangVien + "', MaSoMonHoc = '" + lopDay.MaSoMonHoc + "' WHERE MaLopDay = '" + lopDay.MaLopDay + "'";

            // Xóa các ngày dạy của lớp cũ
            string cmdDeleteLopDay_NgayDay = "DELETE FROM LopDay_NgayDay WHERE MaLopDay = '" + lopDay.MaLopDay + "'";

            // Thêm lại các ngày dạy mới
            string cmdInsertLopDay_NgayDay = "";
            foreach (DTO_LopDay_NgayDay ngayDay in ngayDayList)
            {
                cmdInsertLopDay_NgayDay += "INSERT INTO LopDay_NgayDay (NgayDay, MaLopDay, CaDay, Phong, TrangThai) " +
                                        "VALUES ('" + ngayDay.NgayDay.ToString("yyyy-MM-dd") + "', '" + lopDay.MaLopDay + "', '" + ngayDay.CaDay + "', '" + ngayDay.Phong + "', N'" + ngayDay.TrangThai + "'); ";
            }

            // Xóa các sinh viên khỏi lớp cũ
            string cmdDeleteSinhVien_LopDay = "DELETE FROM SinhVien_LopDay WHERE MaLopDay = '" + lopDay.MaLopDay + "'";

            // Thêm lại các sinh viên vào lớp mới
            string cmdInsertSinhVien_LopDay = "";
            foreach (string mssv in mssvList)
            {
                cmdInsertSinhVien_LopDay += "INSERT INTO SinhVien_LopDay (MaSoSinhVien, MaLopDay) " +
                                        "VALUES ('" + mssv + "', '" + lopDay.MaLopDay + "'); ";
            }

            // Thực hiện các truy vấn cập nhật
            return Connection.actionQuery(cmdUpdateLopDay + cmdDeleteLopDay_NgayDay + cmdInsertLopDay_NgayDay + cmdDeleteSinhVien_LopDay + cmdInsertSinhVien_LopDay);
        }

        public string[] DanhSachSVTrongLopDay(int id)
        {
            string cmd = "SELECT MaSoSinhVien FROM SinhVien_LopDay WHERE MaLopDay = '" + id + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                List<string> maSoSinhVienList = new List<string>();

                foreach (DataRow row in result.Rows)
                {
                    string maSoSinhVien = row["MaSoSinhVien"].ToString();
                    maSoSinhVienList.Add(maSoSinhVien);
                }

                return maSoSinhVienList.ToArray();
            }
            else
            {
                return null;
            }
        }

        public bool CapNhatTrangThaiNgayDay(int id, DateTime date, string status) 
        {
            string cmdUpdate = $"UPDATE LopDay_NgayDay SET TrangThai = N'{status}' WHERE MaLopDay = {id} AND NgayDay = '{date.ToString("yyyy-MM-dd")}'";

            return Connection.actionQuery(cmdUpdate);
        }

        public bool CapNhatNgayDay(DTO_LopDay_NgayDay dto)
        {
            string cmdUpdate = $"UPDATE LopDay_NgayDay SET TrangThai = N'{dto.TrangThai}' AND CaDay = '{dto.CaDay}' AND Phong = '{dto.Phong}' WHERE MaLopDay = {dto.MaLopDay} AND NgayDay = '{dto.NgayDay.ToString("yyyy-MM-dd")}'";

            return Connection.actionQuery(cmdUpdate);
        }

        public bool KiemTraDaCoCaDayTrongNgayDayTaiPhong(DateTime ngayDay, int caDay, string phongDay)
        {
            string cmd = "SELECT * FROM LopDay_NgayDay WHERE (NgayDay = '" + ngayDay.ToString("yyyy-MM-dd") + "' AND CaDay = " + caDay + " AND Phong = '" + phongDay + "' AND TrangThai <> N'VẮNG')";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ThemNgayDay(DTO_LopDay_NgayDay data)
        {
            string cmd = "INSERT INTO LopDay_NgayDay (NgayDay, MaLopDay, CaDay, Phong, TrangThai) " +
                        "VALUES ('" + 
                        data.NgayDay.ToString("yyyy-MM-dd") + "', '" + 
                        data.MaLopDay + "', '" + 
                        data.CaDay + "', '" + 
                        data.Phong + "', N'" + 
                        data.TrangThai + "'); ";

            return Connection.actionQuery(cmd);
        }
    }
}
