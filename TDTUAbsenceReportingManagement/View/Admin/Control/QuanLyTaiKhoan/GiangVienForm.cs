using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class GiangVienForm : UserControl
    {
        BUS_GiangVien gv;
        public GiangVienForm()
        {
            InitializeComponent();
            gv = new BUS_GiangVien();
        }

        private void GiangVienForm_Load(object sender, EventArgs e)
        {
             xoaGiangVienButton.Enabled = false;
             danhSachGiangVienDataGrid.DataSource = gv.HienDanhSachGV();
        }

        private void themGiangVienButton_Click(object sender, EventArgs e)
        {
            ThemGiangVien uc = new ThemGiangVien();
            QuanTriVienForm quanTriVienForm = this.ParentForm as QuanTriVienForm;

            if (quanTriVienForm != null)
            {
                quanTriVienForm.addUserControl(uc);
            }
        }

    }
}
