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

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class GuiBaoVangControl : UserControl
    {
        BUS_LopDay bus_LD;
        BUS_GiangVien bus_GV;
        BUS_BaoVang bus_BV;
        public GuiBaoVangControl()
        {
            InitializeComponent();

            bus_LD = new BUS_LopDay();
            bus_GV = new BUS_GiangVien();
            bus_BV = new BUS_BaoVang();

            errorDialog.Parent = this.FindForm();
            successDialog.Parent = this.FindForm();
            warningDialog.Parent = this.FindForm();
        }

        private void lyDoBaoVangInput_TextChanged(object sender, EventArgs e)
        {
            int currentLength = lyDoBaoVangInput.Text.Length;

            maxLengthOfText.Text = currentLength.ToString("000") + "/500";

            if (currentLength > 500)
            {
                warningDialog.Show("Không được quá 500 ký tự!");

            }
        }

        private void lyDoBaoVangInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lyDoBaoVangInput.Text.Length >= 500 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void GuiBaoVangControl_Load(object sender, EventArgs e)
        {
            var dsLopDay = bus_LD.DanhSachLopDayTheoEmailGiangVien(Session.Username);

            if (dsLopDay == null)
            {
                errorDialog.Show("Giảng viên chưa phụ trách bất kỳ lớp nào!");

                GoBackToMain();
            }
            else
            {
                danhSachLopHoc.DataSource = dsLopDay;

                ngayDayInput.Enabled = false;

                maLopDayInput.Enabled = false;
            }
        }
        private void GoBackToMain()
        {
            TrangChuGiangVien uc = new TrangChuGiangVien();
            ActorGiangVienForm form = this.FindForm() as ActorGiangVienForm;

            if (form != null)
            {
                form.addUserControl(uc);

                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = warningDialog.Show("Hủy tạo yêu cầu báo vắng?");

            if (result == DialogResult.Yes)
            {
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

        private void danhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachLopHoc.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachLopHoc.Rows[e.RowIndex];

                string maLopDay = selectedRow.Cells["MaLopDay"].Value.ToString();

                Tuple<DTO_LopDay, string[], string[]> tuple = bus_LD.ChiTietLopDayTheoMaLopDay(int.Parse(maLopDay));

                string[] ngayDayDaCo = tuple.Item2;

                ngayDayInput.Items.Clear();

                foreach (var item in ngayDayDaCo)
                {
                    ngayDayInput.Items.Add(item);
                }

                ngayDayInput.SelectedIndex = 0;
                maLopDayInput.Text = maLopDay;
                ngayDayInput.Enabled = true;
            }
        }

        private void guiYeuCauBVButton_Click(object sender, EventArgs e)
        {
            string maSoGV = bus_GV.ChiTietGiangVienBangEmail(Session.Username).MaSoGiangVien;
            string maLopDay = maLopDayInput.Text.ToString().Trim();
            string lyDo = lyDoBaoVangInput.Text.ToString().Trim();
            string ngayVang = ngayDayInput.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maSoGV) )
            {
                errorDialog.Show("Không thể nhận ra người dùng! Hãy thử đăng nhập lại");
                return;
            }

            if (string.IsNullOrEmpty(maLopDay))
            {
                errorDialog.Show("Vui lòng chọn một lớp");
                return;
            }

            if (string.IsNullOrEmpty(lyDo))
            {
                errorDialog.Show("Vui lòng nhập lý do");
                return;
            }

            if (string.IsNullOrEmpty(ngayVang))
            {
                errorDialog.Show("Vui lòng chọn một ngày");
                return;
            }

            DTO_BaoVang dto = new DTO_BaoVang();
            dto.MaBaoVang = bus_BV.TaoMaTuDong();
            dto.NgayBaoVang = DateTime.Parse(ngayVang);
            dto.LyDoBaoVang = lyDo;
            dto.MaLopDay = int.Parse(maLopDay);
            dto.MaSoGiangVien = maSoGV;

            bool result = bus_BV.ThemYeuCauBaoVang(dto);

            if (result)
            {
                successDialog.Show("Đã gửi yêu cầu báo vắng đến cho quản trị viên");

                GoBack();
            }
            else
            {
                errorDialog.Show("Xảy ra lỗi trong quá trình gửi yêu cầu báo vắng");
            }
        }
    }
}
