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
    public partial class GiangVienForm : UserControl
    {
        private readonly GiangVienController controller = new GiangVienController();
        public GiangVienForm()
        {
            InitializeComponent();
        }

        private void GiangVienForm_Load(object sender, EventArgs e)
        {
            danhSachGiangVienDataGrid.DataSource = controller.danhSachGiangVien();
        }
    }
}
