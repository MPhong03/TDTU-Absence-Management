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
using TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyBaoVang;

namespace TDTUAbsenceReportingManagement.View.Admin.Control
{
    public partial class QuanLyBaoVangForm : UserControl
    {
        BUS_BaoVang bus_BV;
        BUS_GiangVien bus_GV;
        private DataTable data;
        public QuanLyBaoVangForm()
        {
            InitializeComponent();
            bus_BV = new BUS_BaoVang();
            bus_GV = new BUS_GiangVien();
        }

        private void QuanLyBaoVangForm_Load(object sender, EventArgs e)
        {
            data = bus_BV.DanhSachBaoVang();
            DataTable lecturers = bus_GV.HienDanhSachGV();

            if (data != null )
            {
                danhSachBaoVang.DataSource = data;
            }

            if (lecturers != null)
            {
                giangVienFilter.Items.Clear();
                giangVienFilter.Items.Add("TẤT CẢ");

                foreach (DataRow row in lecturers.Rows)
                {
                    string maSoGiangVien = row["MaSoGiangVien"].ToString();
                    string hoVaTen = row["HoVaTen"].ToString();
                    string tenGiangVien = maSoGiangVien + " - " + hoVaTen;
                    giangVienFilter.Items.Add(tenGiangVien);
                }

            }

            giangVienFilter.SelectedIndex = 0;
            trangThaiFilter.SelectedIndex = 0;
        }

        // BUTTON RESET DANH SÁCH
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            giangVienFilter.SelectedIndex = 0;
            trangThaiFilter.SelectedIndex = 0;

            data.DefaultView.RowFilter = "";

            danhSachBaoVang.DataSource = data;
        }

        private void trangThaiFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void giangVienFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string trangThaiFilterValue = trangThaiFilter.SelectedItem != null ? trangThaiFilter.SelectedItem.ToString() : "";
            string giangVienFilterValue = giangVienFilter.SelectedItem != null ? giangVienFilter.SelectedItem.ToString() : "";

            // Lấy giá trị MaSoGiangVien từ giangVienFilter
            string maSoGiangVienFilter = giangVienFilterValue.Split('-')[0].Trim();

            // Áp dụng bộ lọc
            string filterExpression = "";

            if (trangThaiFilterValue != "TẤT CẢ")
            {
                filterExpression += $"TrangThai = '{trangThaiFilterValue}'";
            }

            if (giangVienFilterValue != "TẤT CẢ")
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += $"MaSoGiangVien = '{maSoGiangVienFilter}'";
            }

            data.DefaultView.RowFilter = filterExpression;
        }

        private void danhSachBaoVang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachBaoVang.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachBaoVang.SelectedRows[0];

                ChiTietBaoVang baoVang = new ChiTietBaoVang(selectedRow.Cells["MaBaoVang"].Value.ToString());

                baoVang.ShowDialog();

                QuanLyBaoVangForm_Load(null, null);
            }
        }
    }
}
