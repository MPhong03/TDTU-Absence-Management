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
        private string maBaoVangDangChon = string.Empty;
        public YeuCauBaoVang()
        {
            InitializeComponent();

            bus_BV = new BUS_BaoVang();

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
            DataTable data = bus_BV.DanhSachYeuCauBaoVangCuaGiangVienBangEmail(Session.Username);

            if (data != null)
            {
                danhSachYeuCauBaoVang.DataSource = data;
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
