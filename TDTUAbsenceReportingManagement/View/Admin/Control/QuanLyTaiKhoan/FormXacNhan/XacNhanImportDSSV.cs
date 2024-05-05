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

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan
{
    public partial class XacNhanImportDSSV : Form
    {
        BUS_SinhVien bus_SV;
        private List<DTO_SinhVien> data;
        public XacNhanImportDSSV(List<DTO_SinhVien> data)
        {
            InitializeComponent();
            bus_SV = new BUS_SinhVien();
            this.data = data;
        }

        private void XacNhanImportDSSV_Load(object sender, EventArgs e)
        {
            danhSachSinhVienImport.DataSource = data;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult result = questionDialog.Show("Xác nhận thêm danh sách sinh viên này");

            if (result == DialogResult.Yes)
            {
                foreach (DTO_SinhVien sv in data)
                {
                    if (sv != null)
                    {
                        bus_SV.ThemTaiKhoanSV(sv.MaSoSinhVien, sv.Email, sv.MatKhau, sv.HoVaTen, sv.NgaySinh, sv.GioiTinh, sv.SoDienThoai, sv.CCCD, sv.ChuyenNganh, sv.KhoaTuyenSinh);
                    }
                }

                this.Close();
            }
        }
    }
}
