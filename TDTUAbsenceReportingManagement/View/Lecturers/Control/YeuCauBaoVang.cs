using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDTUAbsenceReportingManagement.View.Admin.Control;
using TDTUAbsenceReportingManagement.View.Admin;
using BUS;
using TDTUAbsenceReportingManagement.Data;
using DTO;

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control
{
    public partial class YeuCauBaoVang : UserControl
    {
        BUS_BaoVang bus_BV;
        BUS_BaoBu bus_BB;

        private string maBaoVangDangChon = string.Empty;
        public YeuCauBaoVang()
        {
            InitializeComponent();

            bus_BV = new BUS_BaoVang();
            bus_BB = new BUS_BaoBu();

            errorDialog.Parent = this.FindForm();
            successDialog.Parent = this.FindForm();
            warningDialog.Parent = this.FindForm();
        }

        private void themYeuCauBVButton_Click(object sender, EventArgs e)
        {
            GuiBaoVangControl uc = new GuiBaoVangControl();
            ActorGiangVienForm form = this.FindForm() as ActorGiangVienForm;

            if (form != null)
            {
                form.addUserControl(uc);

                this.Hide();
            }
        }

        private void YeuCauBaoVang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable dataBV = bus_BV.DanhSachYeuCauBaoVangCuaGiangVienBangEmail(Session.Username);

            if (dataBV != null)
            {
                danhSachYeuCauBaoVang.DataSource = dataBV;
            }

            DataTable dataBB = bus_BB.DanhSachYeuCauBaoBuCuaGiangVienBangEmail(Session.Username);

            if (dataBB != null)
            {
                danhSachYeuCauBaoBu.DataSource = dataBB;
            }

            xoaYeuCauButton.Enabled = false;

            baoBuButton.Enabled = false;
        }

        private void danhSachYeuCauBaoVang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachYeuCauBaoVang.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = danhSachYeuCauBaoVang.Rows[e.RowIndex];

                maBaoVangDangChon = selectedRow.Cells["MaBaoVang"].Value.ToString();

                xoaYeuCauButton.Enabled = true;

                baoBuButton.Enabled = true;
            }
        }

        private void xoaYeuCauButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maBaoVangDangChon))
            {
                warningDialog.Show("Vui lòng chọn một yêu cầu đã gửi");
                return;
            }

            DialogResult result = warningDialog.Show("Bạn có chắc muốn xóa yêu cầu đã gửi");

            if (result == DialogResult.Yes) 
            {
                bool del = bus_BV.XoaYeuCauBaoVang(int.Parse(maBaoVangDangChon));

                if (del)
                {
                    successDialog.Show("Đã xóa yêu cầu báo vắng");

                    LoadData();
                }
                else
                {
                    errorDialog.Show("Xảy ra lỗi trong quá trình xóa yêu cầu này");
                }
            }
        }

        private void baoBuButton_Click(object sender, EventArgs e)
        {
            DTO_BaoVang bv = bus_BV.ChiTietBaoVang(int.Parse(maBaoVangDangChon));

            if (bv == null)
            {
                errorDialog.Show("Có gì đó không đúng!");
                return;
            }

            if ((bv.TrangThai).ToUpper().Equals("CHƯA XỬ LÝ"))
            {
                errorDialog.Show("Yêu cầu chưa được xét duyệt!");
                return;
            }

            if ((bv.TrangThai).ToUpper().Equals("TỪ CHỐI"))
            {
                errorDialog.Show("Yêu cầu bị từ chối!");
                return;
            }

            GuiBaoBuControl uc = new GuiBaoBuControl(maBaoVangDangChon);
            ActorGiangVienForm form = this.FindForm() as ActorGiangVienForm;

            if (form != null)
            {
                form.addUserControl(uc);

                this.Hide();
            }
        }
    }
}
