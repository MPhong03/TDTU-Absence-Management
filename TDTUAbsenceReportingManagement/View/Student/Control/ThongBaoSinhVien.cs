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

namespace TDTUAbsenceReportingManagement.View.Student.Control
{
    public partial class ThongBaoSinhVien : UserControl
    {
        BUS_ThongBao bus_TB;
        public ThongBaoSinhVien()
        {
            InitializeComponent();

            bus_TB = new BUS_ThongBao();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tieuDeFilter.Clear();
            noiDungFilter.Clear();
            danhSachThongBao.DataSource = bus_TB.DanhSachThongBaoCuaSinhVien(Session.Username);
        }

        private void ThongBaoSinhVien_Load(object sender, EventArgs e)
        {
            DataTable data = bus_TB.DanhSachThongBaoCuaSinhVien(Session.Username);

            if (data != null)
            {
                danhSachThongBao.DataSource = data;
            }
            else
            {
                danhSachThongBao.DataSource = new DataTable();
            }
        }
        private string GetFilter()
        {
            string tieuDeFilterText = tieuDeFilter.Text.ToLower();
            string noiDungFilterText = noiDungFilter.Text.ToLower();

            // Xây dựng biểu thức lọc
            string filterExpression = "";

            if (!string.IsNullOrEmpty(tieuDeFilterText))
            {
                filterExpression += $"TieuDe LIKE '%{tieuDeFilterText}%'";
            }

            if (!string.IsNullOrEmpty(noiDungFilterText))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"NoiDung LIKE '%{noiDungFilterText}%'";
            }

            return filterExpression;
        }

        private void tieuDeFilter_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = GetFilter();
            ((DataTable)danhSachThongBao.DataSource).DefaultView.RowFilter = filterExpression;
        }

        private void noiDungFilter_TextChanged(object sender, EventArgs e)
        {
            string filterExpression = GetFilter();
            ((DataTable)danhSachThongBao.DataSource).DefaultView.RowFilter = filterExpression;

        }
    }
}
