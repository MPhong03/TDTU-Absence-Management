using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TDTUAbsenceReportingManagement.View.Admin.Control.Report;

namespace TDTUAbsenceReportingManagement.View.Admin
{
    public partial class AdminTrangChuForm : UserControl
    {
        BUS_ThongKe bus_TK;
        public AdminTrangChuForm()
        {
            InitializeComponent();

            bus_TK = new BUS_ThongKe();

            successMessage.Parent = this.FindForm();
            warningMessage.Parent = this.FindForm();

            startDate.Value = DateTime.Now.AddMonths(-1);
            endDate.Value = DateTime.Now;
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
            Dictionary<string, int> data = bus_TK.DuLieuThongKeGiangVienBaoVang(startDate.Value, endDate.Value);

            bieuDo.Title.Text = "Số lượng yêu cầu báo vắng được duyệt của giảng viên";

            bieuDo.YAxes.GridLines.Display = false;

            bieuDo.Datasets.Clear();

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();

            foreach (var row in data)
            {
                dataset.DataPoints.Add(row.Key, row.Value);
            }

            bieuDo.Datasets.Add(dataset);

            bieuDo.Update();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Image chartImage = bieuDo.ToImage();

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            string imagePath = Path.Combine(appDataPath, "TDTUAbsenceLoginData", "bieuDo.png");

            Directory.CreateDirectory(Path.GetDirectoryName(imagePath));

            chartImage.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);

            BaoCaoThongKe myReport = new BaoCaoThongKe();

            myReport.DataDefinition.FormulaFields["Location"].Text = "\"" + imagePath + "\"";
            myReport.DataDefinition.FormulaFields["dateReport"].Text = "\"Từ ngày: " + startDate.Value.ToString("dd-MM-yyyy") + "\t  Đến ngày: " + endDate.Value.ToString("dd-MM-yyyy") + "\"";
            myReport.DataDefinition.FormulaFields["studentCount"].Text = "\"" + soLuongSinhVien.Text + " sinh viên\"";
            myReport.DataDefinition.FormulaFields["lecturerCount"].Text = "\"" + soLuongGiangVien.Text + " giảng viên\"";
            myReport.DataDefinition.FormulaFields["baoVangCount"].Text = "\"" + soLuongYCBaoVang.Text + " báo vắng đã được gửi\"";
            myReport.DataDefinition.FormulaFields["baoBuCount"].Text = "\"" + soLuongYCBaoBu.Text + " báo bù đã được gửi\"";

            Debug.WriteLine(myReport.DataDefinition.FormulaFields["Location"].Text);

            ReportViewer reportViewerForm = new ReportViewer();

            reportViewerForm.setReport(myReport);

            reportViewerForm.ShowDialog();


        }

        // XEM DỮ LIỆU THỐNG KÊ THEO NGÀY
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;

            if (end < start)
            {
                warningMessage.Show("Ngày kết thúc không được trước ngày bắt đầu");
            }
            else
            {
                // LỌC DỮ LIỆU CỦA BIỂU ĐỒ
                LoadData();
            }
        }
    }
}
