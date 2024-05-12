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

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class GuiBaoBuControl : UserControl
    {
        BUS_BaoVang bus_BV;
        BUS_LopDay bus_LD;
        BUS_MonHoc bus_MH;
        BUS_BaoBu bus_BB;

        private string maBaoVang = string.Empty;
        private int maLopDay = 0;
        private string maSoGiangVien = string.Empty;
        private DateTime ngayBaoVang;

        public GuiBaoBuControl(string id)
        {
            InitializeComponent();

            bus_BV = new BUS_BaoVang();
            bus_LD = new BUS_LopDay();
            bus_MH = new BUS_MonHoc();
            bus_BB = new BUS_BaoBu();

            this.maBaoVang = id;

            errorDialog.Parent = this.FindForm();
            successDialog.Parent = this.FindForm();
            warningDialog.Parent = this.FindForm();

            caBuInput.SelectedIndex = 0;
        }

        private void loiNhanInput_TextChanged(object sender, EventArgs e)
        {
            int currentLength = loiNhanInput.Text.Length;

            maxLengthOfText.Text = currentLength.ToString("000") + "/500";

            if (currentLength > 500)
            {
                warningDialog.Show("Không được quá 500 ký tự!");

            }
        }

        private void loiNhanInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (loiNhanInput.Text.Length >= 500 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void GuiBaoBuControl_Load(object sender, EventArgs e)
        {
            DTO_BaoVang baoVang = bus_BV.ChiTietBaoVang(int.Parse(this.maBaoVang));

            if (baoVang != null)
            {
                maBaoVangInput.Text = maBaoVang;
                maLopDayInput.Text = baoVang.MaLopDay.ToString();
                this.ngayBaoVang = baoVang.NgayBaoVang;

                DataRow lopDay = bus_LD.ChiTietLopDayTheoNgay(baoVang.MaLopDay, baoVang.NgayBaoVang);

                if (lopDay != null)
                {
                    this.maLopDay = baoVang.MaLopDay;
                    this.maSoGiangVien = lopDay["MaSoGiangVien"].ToString();

                    nhomInput.Text = lopDay["Nhom"].ToString();
                    toInput.Text = lopDay["ToTH"].ToString();

                    DTO_MonHoc monHoc = bus_MH.ChiTietMonHoc(lopDay["MaSoMonHoc"].ToString());

                    if (monHoc != null)
                    {
                        tenMonHocInput.Text = "(" + monHoc.MaSoMonHoc + ") " + monHoc.TenMonHoc;
                    }
                    else
                    {

                    }
                }
                else
                {

                }

                maBaoVangInput.Enabled = false;
                maLopDayInput.Enabled = false;
                tenMonHocInput.Enabled = false;
                nhomInput.Enabled = false;
                toInput.Enabled = false;
            }
            else
            {
                errorDialog.Show("Có gì đó không đúng!");

                GoBack();
            }
        }

        private void GoBack()
        {
            YeuCauBaoVang uc = new YeuCauBaoVang();
            ActorGiangVienForm form = this.FindForm() as ActorGiangVienForm;

            if (form != null)
            {
                form.addUserControl(uc);

                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void guiYeuCauBaoBuButton_Click(object sender, EventArgs e)
        {
            var phongBu = phongBuInput.Text.ToString().Trim();
            var loiNhan = loiNhanInput.Text.ToString().Trim();
            var caBu = int.Parse(caBuInput.Text.ToString().Substring(3));
            var ngayBu = DateTime.Parse(ngayBuInput.Text.ToString().Trim());

            if (string.IsNullOrEmpty(phongBu))
            {
                warningDialog.Show("Vui lòng nhập vào phòng muốn dạy bù");
                return;
            }

            if (string.IsNullOrEmpty(loiNhan))
            {
                warningDialog.Show("Vui lòng để lại lời nhắn");
                return;
            }

            if (bus_LD.KiemTraDaCoCaDayTrongNgayDayTaiPhong(ngayBu, caBu, phongBu))
            {
                warningDialog.Show("Đã có lớp khác sử dụng phòng " + phongBu + " vào ca " + caBu + " vào ngày " + ngayBu);
                return;
            }

            if (ngayBu < DateTime.Today)
            {
                warningDialog.Show("Không thể chọn ngày quá khứ làm ngày bù");
                return;
            }

            DTO_BaoBu dto = new DTO_BaoBu();
            dto.MaBaoBu = bus_BB.TaoMaTuDong();
            dto.NgayBaoBu = ngayBu;
            dto.CaBu = caBu;
            dto.PhongBu = phongBu;
            dto.LoiNhan = loiNhan;
            dto.MaBaoVang = int.Parse(this.maBaoVang);
            dto.MaLopDay = this.maLopDay;
            dto.MaSoGiangVien = this.maSoGiangVien;

            bool result = bus_BB.ThemYeuCauBaoBu(dto);

            if (result)
            {
                successDialog.Show("Đã gửi yêu cầu báo bù đến cho quản trị viên");

                GoBack();
            }
            else
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình gửi yêu cầu báo bù");
            }
        }
    }
}
