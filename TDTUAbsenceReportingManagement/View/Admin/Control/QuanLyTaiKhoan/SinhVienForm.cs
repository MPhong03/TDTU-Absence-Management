using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Controller;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan
{
    public partial class SinhVienForm : UserControl
    {
        private readonly SinhVienController controller = new SinhVienController();
        public SinhVienForm()
        {
            InitializeComponent();
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            danhSachSinhVienDataGrid.DataSource = controller.danhSachSinhVien();
        }
    }
}
