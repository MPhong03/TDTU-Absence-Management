using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDTUAbsenceReportingManagement.Model;

namespace TDTUAbsenceReportingManagement.Controller
{
    public class GiangVienController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["QuanLyBaoVangBaoBuConnectionString"].ConnectionString;

        public List<GiangVien> danhSachGiangVien()
        {
            List<GiangVien> danhSach = new List<GiangVien>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM GiangVien";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GiangVien giangVien = new GiangVien
                    {
                        MaSoGiangVien = reader["MaSoGiangVien"].ToString(),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        HoVaTen = reader["HoVaTen"].ToString(),
                        NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        HocHam = reader["HocHam"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        CCCD = reader["CCCD"].ToString(),
                        DiaChi = reader["DiaChi"].ToString()
                    };

                    danhSach.Add(giangVien);
                }

                reader.Close();
            }

            return danhSach;
        }
    }
}
