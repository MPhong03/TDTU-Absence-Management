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
            xoaSinhVienButton.Enabled = false;
            danhSachSinhVienDataGrid.DataSource = sv.HienDanhSachSV();
        }

        private void themSinhVienButton_Click(object sender, EventArgs e)
        {
            ThemSinhVien uc = new ThemSinhVien();
            QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }
    }
}
