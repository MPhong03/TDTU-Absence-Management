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
using TDTUAbsenceReportingManagement.View.Lecturers.Control.Components;

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class ThongBaoGiangVien : UserControl
    {
        BUS_ThongBao bus_TB;
        private List<ThongBaoItem> thongBaoItems;
        public ThongBaoGiangVien()
        {
            InitializeComponent();

            bus_TB = new BUS_ThongBao();
            thongBaoItems = new List<ThongBaoItem>();
        }

        private void ThongBaoGiangVien_Load(object sender, EventArgs e)
        {
            DataTable data = bus_TB.DanhSachThongBaoCuaGiangVien(Session.Username);

            if (data != null)
            {
                //danhSachThongBao.DataSource = data;

                // Sử dụng FlowPanelLayout

                foreach (DataRow row in data.Rows)
                {
                    ThongBaoItem item = new ThongBaoItem();
                    item.setID(int.Parse(row["MaThongBao"].ToString()));
                    item.setTitle(row["TieuDe"].ToString());
                    item.setDescription(row["NoiDung"].ToString());
                    item.setDate(DateTime.Parse(row["ThoiGianGui"].ToString()));
                    item.setSender(row["TenDangNhap"].ToString());

                    flowLayoutPanel1.Controls.Add(item);
                    thongBaoItems.Add(item);
                }
            }
            else
            {
                //danhSachThongBao.DataSource = new DataTable();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tieuDeFilter.Clear();
            noiDungFilter.Clear();
            
            foreach (ThongBaoItem thongBaoItem in thongBaoItems)
            {
                thongBaoItem.Visible = true;
            }
        }

        private void tieuDeFilter_TextChanged(object sender, EventArgs e)
        {
            //string filterExpression = GetFilter();
            //((DataTable)danhSachThongBao.DataSource).DefaultView.RowFilter = filterExpression;
            FilterThongBaoItems();
        }

        private void noiDungFilter_TextChanged(object sender, EventArgs e)
        {
            //string filterExpression = GetFilter();
            //((DataTable)danhSachThongBao.DataSource).DefaultView.RowFilter = filterExpression;
            FilterThongBaoItems();
        }

        private void FilterThongBaoItems()
        {
            string tieuDeFilterText = tieuDeFilter.Text.ToLower();
            string noiDungFilterText = noiDungFilter.Text.ToLower();

            foreach (ThongBaoItem thongBaoItem in thongBaoItems)
            {
                bool tieuDeMatch = thongBaoItem.getTitle().ToLower().Contains(tieuDeFilterText);
                bool noiDungMatch = thongBaoItem.getDescription().ToLower().Contains(noiDungFilterText);
                
                thongBaoItem.Visible = tieuDeMatch && noiDungMatch;
            }
        }
    }
}
