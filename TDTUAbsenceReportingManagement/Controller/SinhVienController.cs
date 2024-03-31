using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTUAbsenceReportingManagement.Model;

namespace TDTUAbsenceReportingManagement.Controller
{
    public class SinhVienController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyBaoVangBaoBuConnectionString"].ConnectionString;

        public List<SinhVien> danhSachSinhVien()
        {
            List<SinhVien> danhSach = new List<SinhVien>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SinhVien";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SinhVien sinhVien = new SinhVien
                    {
                        MaSoSinhVien = reader["MaSoSinhVien"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        HoVaTen = reader["HoVaTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        CCCD = reader["CCCD"].ToString(),
                        ChuyenNganh = reader["ChuyenNganh"].ToString(),
                        KhoaTuyenSinh = reader["KhoaTuyenSinh"].ToString()
                    };

                    danhSach.Add(sinhVien);
                }

                reader.Close();
            }

            return danhSach;
        }
    }
}
