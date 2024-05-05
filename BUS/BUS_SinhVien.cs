using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien sv;
        public DTO_SinhVien dSV { get; set; }
        public BUS_SinhVien()
        {
            sv = new DAL_SinhVien();
            dSV = new DTO_SinhVien("","","","",DateTime.Now,"","","","",DateTime.Now.Year.ToString());
        }
        public DataTable HienDanhSachSV()
        {
            return sv.DanhSachSinhVien();
        }

        public DTO_SinhVien ChiTietSinhVien(string maSV)
        {
            return sv.HienThongTinSV(maSV);
        }

        public string getCourse()
        {
            string courseYear = dSV.KhoaTuyenSinh;
            if (courseYear.Length >= 4)
            {
                string course = courseYear.Substring(2, 2);
                return course;
            }
            else
            {
                return "00";
            }

        }

        public string LayMaSV()
        {
            DataTable dt = sv.getSVDesc();
            if(dt.Rows.Count > 0) { 
                string res = dt.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(5, 3)) + 1;
                if (stt < 10)
                    res = "5" + getCourse() + "0000" +  stt.ToString();
                else if (stt < 100)
                    res = "5" + getCourse() + "000"+ stt.ToString();
                else
                    res = "5" + getCourse() + "00" + stt.ToString();
                return res;
            }
            return "5" + getCourse() + "00001"; 
        }

        public void ThemTaiKhoanSV(string maSV, string email, string pass, string fname, DateTime dateBirth,
                                        string gender, string phone, string cccd, string academic, string course)
        {
            sv.ThemSinhVienMoi(maSV, email, pass, fname, dateBirth, gender, phone, cccd, academic, course);   
        }

        public bool KiemTraEmailTonTai(string email)
        {
            return sv.checkEmail(email);
        } 

        public void SuaTaiKhoanSV(string maSV, string email, string pass, string fname, DateTime dateBirth,
                                  string gender, string phone, string cccd, string academic, string course)
        {
            sv.SuaSinhVien(maSV,email,pass, fname, dateBirth, gender,phone, cccd, academic,course);
        }

        public void XoaTaiKhoanSV(string maSV)
        {
            sv.XoaSinhVien(maSV);
        }

        // TEST
        public string TaoMaTuDong()
        {
            return sv.GenerateNewStudentID(dSV.KhoaTuyenSinh);
        }
    }
}
