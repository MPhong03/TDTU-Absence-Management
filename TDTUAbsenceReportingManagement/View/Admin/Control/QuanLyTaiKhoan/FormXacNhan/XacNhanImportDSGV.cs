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
    public partial class XacNhanImportDSGV : Form
    {
        BUS_GiangVien bus_GV;
        private List<DTO_GiangVien> data;
        public XacNhanImportDSGV(List<DTO_GiangVien> data)
        {
            InitializeComponent();
            bus_GV = new BUS_GiangVien();
            this.data = data;
        }

        private void XacNhanImportDSGV_Load(object sender, EventArgs e)
        {
            danhSachGiangVienImport.DataSource = data;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult result = questionDialog.Show("Xác nhận thêm danh sách giảng viên này");

            if (result == DialogResult.Yes)
            {
                foreach (DTO_GiangVien gv in data)
                {
                    if (gv != null)
                    {
                        bool chk = bus_GV.ThemGiangVien(gv);

                        if (!chk)
                        {
                            errorDialog.Show("Lỗi khi thêm " + gv.Email + " vào cơ sở dữ liệu");
                        }
                    }
                }

                this.Close();
            }
        }
    }
}
