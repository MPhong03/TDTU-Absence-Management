using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.Data;

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class ThongBaoGiangVien : UserControl
    {
        BUS_ThongBao bus_TB;
        public ThongBaoGiangVien()
        {
            InitializeComponent();

            bus_TB = new BUS_ThongBao();
        }

        private void ThongBaoGiangVien_Load(object sender, EventArgs e)
        {
            DataTable data = bus_TB.DanhSachThongBaoCuaGiangVien(Session.Username);

            if (data != null)
            {
                danhSachThongBao.DataSource = data;
            }
            else
            {
                danhSachThongBao.DataSource = new DataTable();
            }
        }
    }
}
