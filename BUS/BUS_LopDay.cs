using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LopDay
    {
        DAL_LopDay dal_LopDay;
        public BUS_LopDay()
        {
            dal_LopDay = new DAL_LopDay();
        }
        public DataTable DanhSachLopDayTheoMaSoGiangVien(string id)
        {
            return dal_LopDay.DanhSachLopDayTheoMaSoGiangVien(id);
        }
        public DataTable DanhSachLopDayTheoEmailGiangVien(string email)
        {
            return dal_LopDay.DanhSachLopDayTheoEmailGiangVien(email);
        }
        public bool ThemLopDay(DTO_LopDay lopDay, DTO_LopDay_NgayDay[] ngayDayList, string[] mssvList)
        {
            return dal_LopDay.ThemLopDay(lopDay, ngayDayList, mssvList);
        }
        public Tuple<DTO_LopDay, DTO_LopDay_NgayDay[], string[]> ChiTietLopDayTheoMaLopDay(int maLopDay)
        {
            return dal_LopDay.ChiTietLopDayTheoMaLopDay(maLopDay);
        }
        public bool XoaLopDay(int id)
        {
            return dal_LopDay.XoaLopDay(id);
        }
        public bool ChinhSuaLopHoc(DTO_LopDay lopDay, DTO_LopDay_NgayDay[] ngayDayList, string[] mssvList)
        {
            try
            {
                if (!dal_LopDay.XoaLopDay(lopDay.MaLopDay))
                {
                    return false;
                }

                return dal_LopDay.ThemLopDay(lopDay, ngayDayList, mssvList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi chỉnh sửa lớp học: " + ex.Message);
                return false;
            }
        }
        public DataRow ChiTietLopDayTheoNgay(int id, DateTime ngay)
        {
            return dal_LopDay.ChiTietLopDayTheoNgay(id, ngay);
        }
        public string[] DanhSachSVTrongLopDay(int id)
        {
            return dal_LopDay.DanhSachSVTrongLopDay(id);
        }
        public bool CapNhatTrangThaiNgayDay(int id, DateTime date, string status)
        {
            return dal_LopDay.CapNhatTrangThaiNgayDay(id, date, status);
        }
        public bool KiemTraDaCoCaDayTrongNgayDayTaiPhong(DateTime ngayDay, int caDay, string phongDay)
        {
            return dal_LopDay.KiemTraDaCoCaDayTrongNgayDayTaiPhong(ngayDay, caDay, phongDay);
        }
        public bool ThemNgayDay(DTO_LopDay_NgayDay data)
        {
            return dal_LopDay.ThemNgayDay(data);
        }
        public int TaoMaTuDong()
        {
            string currentID = dal_LopDay.LayMaLopDayGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return 1; }

            return int.Parse(currentID) + 1;
        }
    }
}
