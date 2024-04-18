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

namespace TDTUAbsenceReportingManagement.View.Admin.Control.ChiTietTaiKhoan
{
    public partial class ChiTietGiangVien : UserControl
    {
        BUS_GiangVien BUS_GV;
        private string maSoGiangVien = string.Empty;
        public ChiTietGiangVien(string maSoGiangVien)
        {
            InitializeComponent();

            this.maSoGiangVien = maSoGiangVien;

            BUS_GV = new BUS_GiangVien();
        }

        private void ChiTietGiangVien_Load(object sender, EventArgs e)
        {
            DTO_GiangVien gv = BUS_GV.ChiTietGiangVien(maSoGiangVien);

            if (gv != null)
            {
                maGV.Enabled = false;
                maGV.Text = gv.MaSoGiangVien;
                fullNameGV.Text = gv.HoVaTen;
                emailGV.Text = gv.Email;
                passwordGV.Text = gv.MatKhau;
                cccdGV.Text = gv.CCCD;
                addressGV.Text = gv.DiaChi;
                phoneGV.Text = gv.SoDienThoai;
                ngaySinhGV.Value = gv.NgaySinh;
                genderGV.SelectedItem = gv.GioiTinh;
                academicRankGV.SelectedItem = gv.HocHam;
            }
        }
    }
}
