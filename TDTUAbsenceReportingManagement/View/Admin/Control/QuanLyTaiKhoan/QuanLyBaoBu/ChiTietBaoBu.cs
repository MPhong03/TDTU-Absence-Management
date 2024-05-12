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

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.QuanLyBaoBu
{
    public partial class ChiTietBaoBu : Form
    {
        BUS_BaoBu bus_BB;
        BUS_BaoVang bus_BV;
        BUS_GiangVien bus_GV;
        BUS_LopDay bus_LD;
        BUS_MonHoc bus_MH;
        BUS_ThongBao bus_TB;

        private string maBaoBu = string.Empty;
        private string maLopDay = string.Empty;
        private string maSoGiangVien = string.Empty;
        private string tenGiangVien = string.Empty;
        private DateTime ngayVang = DateTime.MinValue;
        private DateTime ngayBu = DateTime.MinValue;
        private string message = string.Empty;
        private string caBu = string.Empty;
        private string monHocBu = string.Empty;
        private string nhomBu = string.Empty;
        private string toBu = string.Empty;
        private string phongBu = string.Empty;
        private string[] dssv = null;

        public ChiTietBaoBu(string id)
        {
            InitializeComponent();

            bus_BB = new BUS_BaoBu();
            bus_BV = new BUS_BaoVang();
            bus_GV = new BUS_GiangVien();
            bus_LD = new BUS_LopDay();
            bus_MH = new BUS_MonHoc();
            bus_TB = new BUS_ThongBao();

            maBaoBu = id;
        }

        private void ChiTietBaoBu_Load(object sender, EventArgs e)
        {
            DTO_BaoBu baoBu = bus_BB.ChiTietBaoBu(int.Parse(maBaoBu));

            if (baoBu == null)
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình tải dữ liệu");

                this.Close();
            }
            else
            {
                DTO_BaoVang baoVang = bus_BV.ChiTietBaoVang(baoBu.MaBaoVang);
                DTO_GiangVien giangVien = bus_GV.ChiTietGiangVien(baoBu.MaSoGiangVien);
                DataRow lopDay = bus_LD.ChiTietLopDayTheoNgay(baoBu.MaLopDay, baoVang.NgayBaoVang);

                if (lopDay != null)
                {
                    DTO_MonHoc monHoc = bus_MH.ChiTietMonHoc(lopDay["MaSoMonHoc"].ToString());

                    this.maLopDay = lopDay["MaLopDay"].ToString();
                    this.maSoGiangVien = giangVien.MaSoGiangVien;
                    this.ngayBu = baoBu.NgayBaoBu;
                    this.ngayVang = baoVang.NgayBaoVang;
                    this.message = baoBu.LoiNhan;
                    this.caBu = baoBu.CaBu.ToString();
                    this.monHocBu = "(" + monHoc.MaSoMonHoc + ") " + monHoc.TenMonHoc;
                    this.tenGiangVien = giangVien.HoVaTen;
                    this.nhomBu = lopDay["Nhom"].ToString();
                    this.toBu = lopDay["ToTH"].ToString();
                    this.phongBu = baoBu.PhongBu.ToString();

                    maBaoVangView.Text = "Mã phiếu:     " + maBaoBu;
                    maSoGiangVienView.Text = "Mã số giảng viên:     " + giangVien.MaSoGiangVien;
                    hoVaTenView.Text = "Họ và tên:      " + giangVien.HoVaTen;
                    monHocView.Text = "Môn học:     (" + monHoc.MaSoMonHoc + ") " + monHoc.TenMonHoc;
                    nhomView.Text = "Nhóm:      " + lopDay["Nhom"].ToString();
                    toView.Text = "Tổ:      " + lopDay["ToTH"].ToString();
                    caBuView.Text = "Ca dạy:    Ca " + baoBu.CaBu.ToString();
                    ngayVangView.Text = "Ngày vắng:     " + baoVang.NgayBaoVang;
                    ngayBuView.Text = "Ngày bù:      " + baoBu.NgayBaoBu;
                    phongBuView.Text = "Phòng bù:    " + baoBu.PhongBu.ToString();
                    loiNhanText.Text = baoBu.LoiNhan;
                    loiNhanText.Enabled = false;

                    if (baoBu.TrangThai.Equals("CHƯA XỬ LÝ"))
                    {
                        acceptButton.Enabled = true;
                    }
                    else if (baoBu.TrangThai.Equals("CHẤP NHẬN"))
                    {
                        acceptButton.Enabled = false;
                        acceptButton.Text = "Đã được duyệt";
                    }
                    else if (baoBu.TrangThai.Equals("TỪ CHỐI"))
                    {
                        declineButton.Enabled = false;
                        declineButton.Text = "Đã từ chối";
                    }
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
            string tilteTemplateGV = "DUYỆT YÊU CẦU BÁO BÙ";
            string contentTemplateGV = "YÊU CẦU BÁO BÙ ĐƯỢC CHẤP THUẬN" + Environment.NewLine +
                "Môn: " + this.monHocBu + Environment.NewLine +
                "Ngày bù: " + this.ngayBu + Environment.NewLine +
                "Ca bù: " + this.caBu + Environment.NewLine +
                "Nhóm: " + this.nhomBu + ", Tổ: " + this.toBu;

            tieuDeChoGVInput.Text = tilteTemplateGV;
            noiDungChoGVInput.Text = contentTemplateGV;

            string tilteTemplateSV = "THÔNG BÁO LỊCH HỌC BÙ";
            string contentTemplateSV = "Giảng viên: " + this.tenGiangVien + Environment.NewLine +
                "Môn: " + this.monHocBu + Environment.NewLine +
                "Ngày vắng: " + this.ngayVang + Environment.NewLine +
                "Ngày bù: " + this.ngayBu + Environment.NewLine +
                "Ca bù: " + this.caBu + Environment.NewLine +
                "Nhóm: " + this.nhomBu + ", Tổ: " + this.toBu + Environment.NewLine +
                "Lời nhắn từ giảng viên: " + this.message;

            tieuDeChoSVInput.Text = tilteTemplateSV;
            noiDungChoSVInput.Text = contentTemplateSV;
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
                bool result = bus_BB.CapNhatTrangThaiYeuCauBaoBu(int.Parse(maBaoBu), "CHẤP NHẬN");

                if (result)
                {
                    successDialog.Show("Cập nhật yêu cầu thành công");

                    bool notifyGV = GuiThongBaoChoGiangVien();
                    bool notifySV = GuiThongBaoChoSinhVien();

                    DTO_LopDay_NgayDay newDate = new DTO_LopDay_NgayDay(
                            int.Parse(maLopDay),
                            ngayBu,
                            int.Parse(caBu),
                            phongBu,
                            "BÙ"
                        );
                    if (ngayBu.Equals(ngayVang))
                    {
                        bool updateDate = bus_LD.CapNhatNgayDay(newDate);

                        if (!updateDate)
                        {
                            errorDialog.Show("Xảy ra lỗi trong quá trình cập nhật ngày bú");

                        }
                    }
                    else
                    {
                        bool newDateCheck = bus_LD.ThemNgayDay(newDate);

                        if (!newDateCheck)
                        {
                            errorDialog.Show("Xảy ra lỗi trong quá trình cập nhật ngày bú");

                        }

                    }

                    if (!notifyGV)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình gửi thông báo cho giảng viên");
                    }

                    if (!notifySV)
                    {
                        errorDialog.Show("Xảy ra lỗi trong quá trình gửi thông báo cho sinh viên");
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
                bool result = bus_BB.CapNhatTrangThaiYeuCauBaoBu(int.Parse(maBaoBu), "TỪ CHỐI");

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
    }
}
