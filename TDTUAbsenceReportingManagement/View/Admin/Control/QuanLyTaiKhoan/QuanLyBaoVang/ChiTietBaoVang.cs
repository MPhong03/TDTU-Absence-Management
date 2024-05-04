using BUS;
using DTO;
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

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyBaoVang
{
    public partial class ChiTietBaoVang : Form
    {
        BUS_BaoVang bus_BV;
        BUS_GiangVien bus_GV;
        BUS_LopDay bus_LD;
        BUS_MonHoc bus_MH;
        BUS_ThongBao bus_TB;

        private string maBaoVang = string.Empty;
        private string maLopDay = string.Empty;
        private string maSoGiangVien = string.Empty;
        private string tenGiangVien = string.Empty;
        private DateTime date = DateTime.MinValue;
        private string reasonGV = string.Empty;
        private string caVang = string.Empty;
        private string monHocVang = string.Empty;
        private string nhomVang = string.Empty;
        private string toVang = string.Empty;
        private string[] dssv = null;

        public ChiTietBaoVang(string maBaoVang)
        {
            InitializeComponent();
            bus_BV = new BUS_BaoVang();
            bus_GV = new BUS_GiangVien();
            bus_LD = new BUS_LopDay();
            bus_MH = new BUS_MonHoc();
            bus_TB = new BUS_ThongBao();

            this.maBaoVang = maBaoVang;
        }

        private void ChiTietBaoVang_Load(object sender, EventArgs e)
        {
            DTO_BaoVang baoVang = bus_BV.ChiTietBaoVang(int.Parse(maBaoVang));

            if (baoVang == null)
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình tải dữ liệu");

                this.Close();
            }
            else
            {
                DTO_GiangVien giangVien = bus_GV.ChiTietGiangVien(baoVang.MaSoGiangVien);
                DataRow lopDay = bus_LD.ChiTietLopDayTheoNgay(baoVang.MaLopDay, baoVang.NgayBaoVang);

                if (lopDay != null)
                {
                    DTO_MonHoc monHoc = bus_MH.ChiTietMonHoc(lopDay["MaSoMonHoc"].ToString());

                    this.maLopDay = lopDay["MaLopDay"].ToString();
                    this.maSoGiangVien = giangVien.MaSoGiangVien;
                    this.date = baoVang.NgayBaoVang;
                    this.reasonGV = baoVang.LyDoBaoVang;
                    this.caVang = lopDay["CaDay"].ToString();
                    this.monHocVang = "(" + monHoc.MaSoMonHoc + ") " + monHoc.TenMonHoc;
                    this.tenGiangVien = giangVien.HoVaTen;
                    this.nhomVang = lopDay["Nhom"].ToString();
                    this.toVang = lopDay["ToTH"].ToString();

                    maBaoVangView.Text = "Mã phiếu:     " + maBaoVang;
                    maSoGiangVienView.Text = "Mã số giảng viên:     " + giangVien.MaSoGiangVien;
                    hoVaTenView.Text = "Họ và tên:      " + giangVien.HoVaTen;
                    monHocView.Text = "Môn học:     (" + monHoc.MaSoMonHoc + ") " + monHoc.TenMonHoc;
                    nhomView.Text = "Nhóm:      " + lopDay["Nhom"].ToString();
                    toView.Text = "Tổ:      " + lopDay["ToTH"].ToString();
                    caDayView.Text = "Ca dạy:      Ca " + lopDay["CaDay"].ToString();
                    ngayVangView.Text = "Ngày:      " + baoVang.NgayBaoVang;
                    lyDoText.Text = baoVang.LyDoBaoVang;
                    lyDoText.Enabled = false;

                    if (baoVang.TrangThai.Equals("CHƯA XỬ LÝ"))
                    {
                        acceptButton.Enabled = true;
                    }
                    else if (baoVang.TrangThai.Equals("CHẤP NHẬN"))
                    {
                        acceptButton.Enabled = false;
                        acceptButton.Text = "Đã được duyệt";
                    }
                    else if (baoVang.TrangThai.Equals("TỪ CHỐI"))
                    {
                        declineButton.Enabled = false;
                        declineButton.Text = "Đã từ chối";
                    }
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tieuDeChoGVInput.Text) || string.IsNullOrEmpty(noiDungChoGVInput.Text)
                || string.IsNullOrEmpty(tieuDeChoSVInput.Text) || string.IsNullOrEmpty(noiDungChoSVInput.Text))
            {
                warningMessage.Show("Vui lòng nhập đầy đủ nội dung thông báo");
                return;
            }

            DialogResult confirm = questionDialog.Show("Xác nhận duyệt yêu cầu");

            if (confirm == DialogResult.Yes)
            {
                bool result = bus_BV.CapNhatTrangThaiYeuCauBaoVang(int.Parse(maBaoVang), "CHẤP NHẬN");

                if (result)
                {
                    successDialog.Show("Cập nhật yêu cầu thành công");

                    bool notifyGV = GuiThongBaoChoGiangVien();
                    bool notifySV = GuiThongBaoChoSinhVien();
                    bool updateStatus = bus_LD.CapNhatTrangThaiNgayDay(int.Parse(maLopDay), this.date, "VẮNG");

                    if (!notifyGV)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình gửi thông báo cho giảng viên");
                    }

                    if (!notifySV)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình gửi thông báo cho sinh viên");
                    }

                    if (!updateStatus)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình cập nhật ngày dạy vắng");
                    }

                    this.Close();
                }
                else
                {
                    errorDialog.Show("Xảy ra lỗi trong quá trình duyệt yêu cầu");

                    this.Close();
                }
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tieuDeChoGVInput.Text) || string.IsNullOrEmpty(noiDungChoGVInput.Text))
            {
                warningMessage.Show("Vui lòng nhập đầy đủ nội dung thông báo");
                return;
            }

            DialogResult confirm = questionDialog.Show("Xác nhận từ chối yêu cầu");

            if (confirm == DialogResult.Yes)
            {
                bool result = bus_BV.CapNhatTrangThaiYeuCauBaoVang(int.Parse(maBaoVang), "TỪ CHỐI");

                if (result)
                {
                    successDialog.Show("Cập nhật yêu cầu thành công");

                    bool notifyGV = GuiThongBaoChoGiangVien();

                    if (!notifyGV)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình gửi thông báo cho giảng viên");
                    }

                    this.Close();
                }
                else
                {
                    errorDialog.Show("Xảy ra lỗi trong quá trình từ chối yêu cầu");

                    this.Close();
                }
            }
        }

        private bool GuiThongBaoChoGiangVien()
        {
            DTO_ThongBao tb = new DTO_ThongBao(
                    bus_TB.TaoMaTuDong(),
                    tieuDeChoGVInput.Text,
                    noiDungChoGVInput.Text,
                    DateTime.Now,
                    Session.Username
                );

            List<string> gvList = new List<string>();

            gvList.Add(maSoGiangVien);

            return bus_TB.GuiThongBaoChoGiangVien(tb, gvList.ToArray());
        }

        private bool GuiThongBaoChoSinhVien()
        {
            DTO_ThongBao tb = new DTO_ThongBao(
                    bus_TB.TaoMaTuDong(),
                    tieuDeChoSVInput.Text,
                    noiDungChoSVInput.Text,
                    DateTime.Now,
                    Session.Username
                );

            List<string> svList = new List<string>();

            dssv = bus_LD.DanhSachSVTrongLopDay(int.Parse(maLopDay));

            if (dssv.Length <= 0 || dssv == null)
            {
                return false;
            }

            foreach (string sv in dssv)
            {
                svList.Add(sv);
            }

            return bus_TB.GuiThongBaoChoSinhVien(tb, svList.ToArray());
        }

        private void applyTemplateButton_Click(object sender, EventArgs e)
        {
            string tilteTemplateGV = "DUYỆT YÊU CẦU BÁO VẮNG";
            string contentTemplateGV = "YÊU CẦU BÁO VẮNG ĐƯỢC CHẤP THUẬN" + Environment.NewLine +
                "Môn: " + this.monHocVang + Environment.NewLine +
                "Ngày: " + this.date + Environment.NewLine +
                "Ca: " + this.caVang + Environment.NewLine +
                "Nhóm: " + this.nhomVang + ", Tổ: " + this.toVang;

            tieuDeChoGVInput.Text = tilteTemplateGV;
            noiDungChoGVInput.Text = contentTemplateGV;

            string tilteTemplateSV = "THÔNG BÁO VẮNG BUỔI HỌC";
            string contentTemplateSV = "Giảng viên: " + this.tenGiangVien + Environment.NewLine +
                "Môn: " + this.monHocVang + Environment.NewLine +
                "Ngày: " + this.date + Environment.NewLine +
                "Ca: " + this.caVang + Environment.NewLine +
                "Nhóm: " + this.nhomVang + ", Tổ: " + this.toVang + Environment.NewLine +
                "Lý do: " + this.reasonGV;

            tieuDeChoSVInput.Text = tilteTemplateSV;
            noiDungChoSVInput.Text = contentTemplateSV;
        }
    }
}
