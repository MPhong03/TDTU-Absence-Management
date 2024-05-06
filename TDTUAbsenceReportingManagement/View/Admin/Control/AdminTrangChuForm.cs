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
using System.Windows.Forms.DataVisualization.Charting;

namespace TDTUAbsenceReportingManagement.View.Admin
{
    public partial class AdminTrangChuForm : UserControl
    {
        BUS_ThongKe bus_TK;
        public AdminTrangChuForm()
        {
            InitializeComponent();

            bus_TK = new BUS_ThongKe();
        }

        private void AdminTrangChuForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Thống kê số lượng
            int countGV = bus_TK.SoLuongGiangVien();
            int countSV = bus_TK.SoLuongSinhVien();
            int countBV = bus_TK.SoLuongBaoVangDaDuocGui();
            int countBB = bus_TK.SoLuongBaoBuDaDuocGui();

            soLuongGiangVien.Text = countGV.ToString();
            soLuongSinhVien.Text = countSV.ToString();
            soLuongYCBaoVang.Text = countBV.ToString();
            soLuongYCBaoBu.Text = countBB.ToString();

            // Thống kê giảng viên báo vắng
            Dictionary<string, int> data = bus_TK.DuLieuThongKeGiangVienBaoVang();

            bieuDo.Title.Text = "Số lượng yêu cầu báo vắng được duyệt của giảng viên";

            bieuDo.YAxes.GridLines.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();

            foreach (var row in data)
            {
                dataset.DataPoints.Add(row.Key, row.Value);
            }

            bieuDo.Datasets.Add(dataset);

            bieuDo.Update();
        }
    }
}
