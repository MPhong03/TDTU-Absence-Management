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

        public bool DoiMatKhau(string id, string email, string password, string newPassword)
        {
            string cmd = "UPDATE SinhVien SET MatKhau = '" + newPassword + "' WHERE MaSoSinhVien = '" + id + "' AND Email = '" + email + "' AND MatKhau = '" + password + "'";

            return Connection.actionQuery(cmd);
        }

        public DTO_SinhVien HienThongTinSV(string maSV)
        {
            string cmd = "SELECT * FROM SinhVien WHERE MaSoSinhVien = '" + maSV + "'";

            DataTable result = Connection.selectQuery(cmd);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
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
            else 
            { 
                return null; 
            }

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
            String cmd = "INSERT INTO SinhVien VALUES ('" +maSV+ "','" +email+ "','" +pass+ "',N'" +fname+ "','" +dateBirth.ToString("yyyy-MM-dd") + "'," +
                                                        "N'" + gender+ "','" +phone+ "','" +cccd+ "',N'" + academic+ "','" +course+ "')";
            Connection.actionQuery(cmd);
        }

        public void SuaSinhVien(string maSV, string email, string pass, string fname, DateTime dateBirth,
                                        string gender, string phone, string cccd, string academic, string course)
        {
            String cmd = "UPDATE SinhVien SET Email = '" + email + "', MatKhau = '" + pass + "', HoVaTen = N'" + fname + "', NgaySinh = '" + dateBirth.ToString("yyyy-MM-dd") + "'," +
                                                        "GioiTinh = N'" + gender + "', SoDienThoai = '" + phone + "', CCCD = '" + cccd + "', " +
                                                        "ChuyenNganh = N'" + academic + "' WHERE MaSoSinhVien = '" +maSV+ "' AND KhoaTuyenSinh = '" + course + "'";
            Connection.actionQuery(cmd);
        }

        public void XoaSinhVien(string maSV)
        {
            // Kiểm tra xem có dữ liệu liên quan trong bảng SinhVien_LopDay không
            DataTable dtSinhVienLopDay = Connection.selectQuery("SELECT * FROM SinhVien_LopDay WHERE MaSoSinhVien = '" + maSV + "'");
            if (dtSinhVienLopDay.Rows.Count > 0)
            {
                Connection.actionQuery("DELETE FROM SinhVien_LopDay WHERE MaSoSinhVien = '" + maSV + "'");
            }

            // Kiểm tra xem có dữ liệu liên quan trong bảng ThongBao_SinhVien không
            DataTable dtThongBaoSinhVien = Connection.selectQuery("SELECT * FROM ThongBao_SinhVien WHERE MaSoSinhVien = '" + maSV + "'");
            if (dtThongBaoSinhVien.Rows.Count > 0)
            {
                Connection.actionQuery("DELETE FROM ThongBao_SinhVien WHERE MaSoSinhVien = '" + maSV + "'");
            }

            // Sau khi xóa dữ liệu liên quan, tiến hành xóa sinh viên
            string cmd = "DELETE FROM SinhVien WHERE MaSoSinhVien = '" + maSV + "'";
            Connection.actionQuery(cmd);
        }

        // TEST
        public string GenerateNewStudentID(string khoaTuyenSinh)
        {
            string lastStudentID = GetLastStudentID(khoaTuyenSinh);
            int lastSequenceNumber = GetLastSequenceNumber(lastStudentID);

            // Tạo mã số sinh viên mới
            string newStudentID = $"5{khoaTuyenSinh.Substring(khoaTuyenSinh.Length - 2)}0{lastSequenceNumber + 1:D4}";

            return newStudentID;
        }

        public string GetLastStudentID(string khoaTuyenSinh)
        {
            // Truy vấn để lấy mã số sinh viên cuối cùng của khóa tuyển sinh
            string cmd = $"SELECT TOP 1 MaSoSinhVien FROM SinhVien WHERE KhoaTuyenSinh = '{khoaTuyenSinh}' ORDER BY MaSoSinhVien DESC";
            DataTable result = Connection.selectQuery(cmd);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["MaSoSinhVien"].ToString();
            }
            else
            {
                // Nếu không có sinh viên nào trong khóa tuyển sinh, trả về mã mặc định
                return $"5{khoaTuyenSinh.Substring(khoaTuyenSinh.Length - 2)}0000";
            }
        }

        public int GetLastSequenceNumber(string studentID)
        {
            // Trích xuất số thứ tự từ mã số sinh viên
            return int.Parse(studentID.Substring(5));
        }
    }
}
