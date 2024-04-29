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
        public bool ThemLopDay(DTO_LopDay lopDay, string[] ngayDayList, string[] mssvList)
        {
            return dal_LopDay.ThemLopDay(lopDay, ngayDayList, mssvList);
        }
        public Tuple<DTO_LopDay, string[], string[]> ChiTietLopDayTheoMaLopDay(int maLopDay)
        {
            return dal_LopDay.ChiTietLopDayTheoMaLopDay(maLopDay);
        }
        public bool XoaLopDay(int id)
        {
            return dal_LopDay.XoaLopDay(id);
        }
        public bool ChinhSuaLopHoc(DTO_LopDay lopDay, string[] ngayDayList, string[] mssvList)
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
        public int TaoMaTuDong()
        {
            string currentID = dal_LopDay.LayMaLopDayGanNhat();

            if (string.IsNullOrEmpty(currentID)) { return 1; }

            return int.Parse(currentID) + 1;
        }
    }
}
