using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class ChiTietSinhVien : UserControl
    {
        private string maSoSinhVien = string.Empty;
        BUS_SinhVien sv;
        DTO_SinhVien dSV;
        public ChiTietSinhVien(string maSoSinhVien)
        {
            InitializeComponent();
            this.maSoSinhVien = maSoSinhVien;
            sv = new BUS_SinhVien(); 
        }

        private void ChiTietSinhVien_Load(object sender, EventArgs e)
        {
            dSV = sv.HienThongTinSV(this.maSoSinhVien);
            if (dSV != null)
            {
                maSV_sua.Enabled = false;
                maSV_sua.Text = dSV.MaSoSinhVien;
                fullNameSV_sua.Text = dSV.HoVaTen;
                emailSV_sua.Text = dSV.Email;
                phoneSV_sua.Text = dSV.MatKhau;
                cccdSV_sua.Text = dSV.CCCD;
                phoneSV_sua.Text = dSV.SoDienThoai;
                birthDateSV_sua.Value = dSV.NgaySinh;
                genderSV_sua.SelectedItem = dSV.GioiTinh;
                academicRankSV_sua.SelectedItem = dSV.ChuyenNganh;
                courseSV_sua.Text = dSV.KhoaTuyenSinh;
                passwordSV_sua.Text = dSV.MatKhau;
            }
        }
    }
}