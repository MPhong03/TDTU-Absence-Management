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
    public partial class TrangChuGiangVien : UserControl
    {
        BUS_LopDay bus_LD;
        public TrangChuGiangVien()
        {
            InitializeComponent();
            bus_LD = new BUS_LopDay();
            timer1.Start();

            questionDialog.Parent = this.FindForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void TrangChuGiangVien_Load(object sender, EventArgs e)
        {
            DataTable data = bus_LD.DanhSachLopDayTheoMaSoGiangVienHomNay(Session.UserID, DateTime.Now);

            if (data != null)
            {

                foreach (DataRow row in data.Rows)
                {
                    LopDayItem item = new LopDayItem();
                    item.setMonHoc(row["TenMonHoc"].ToString() + " (" + row["MaSoMonHoc"].ToString() + ")");
                    item.setNgay(DateTime.Parse(row["NgayDay"].ToString()).ToString("dd-MM-yyyy"));
                    item.setCa("Ca " + row["CaDay"].ToString());
                    item.setNhomTo(row["Nhom"].ToString() + row["ToTH"].ToString());
                
                    string status = row["TrangThai"].ToString();
                    if (status.Equals("VẮNG"))
                    {
                        item.setItemColor(Color.FromArgb(220, 76, 100)); // DANGER
                        item.setItemFontColor(Color.White);
                    }
                    else if (status.Equals("BÙ"))
                    {
                        item.setItemColor(Color.FromArgb(228, 161, 27)); // WARNING
                        item.setItemFontColor(Color.White);
                    }
                    else
                    {
                        item.setItemColor(Color.FromArgb(59, 113, 202)); // PRIMARY
                        item.setItemFontColor(Color.White);
                    }
                    item.setTrangThai(status);

                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            else
            {
                questionDialog.Show("Hôm nay không có hoạt động nào cả!");
            }
        }
    }
}
