using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class SinhVienForm : UserControl
    {
        BUS_SinhVien sv;
        public SinhVienForm()
        {
            InitializeComponent();
            sv = new BUS_SinhVien();
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            danhSachSinhVienDataGrid.DataSource = sv.HienDanhSachSV();
        }

        private void themSinhVienButton_Click(object sender, EventArgs e)
        {
            ThemSinhVien uc = new ThemSinhVien();
            QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }

        private void danhSachSinhVienDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = danhSachSinhVienDataGrid.Rows[e.RowIndex];
                string maSoSinhVien = row.Cells["MaSoSinhVien"].Value.ToString();

                ChiTietSinhVien uc = new ChiTietSinhVien(maSoSinhVien);
                QuanTriVienForm quanTriVienForm = this.FindForm() as QuanTriVienForm;

                if (quanTriVienForm != null)
                {
                    quanTriVienForm.addUserControl(uc);
                }
            }
        }
    }
}
