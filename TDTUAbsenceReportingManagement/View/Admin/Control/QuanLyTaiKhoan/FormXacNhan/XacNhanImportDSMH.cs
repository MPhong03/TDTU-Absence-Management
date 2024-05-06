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

namespace TDTUAbsenceReportingManagement.View.Admin.Control.QuanLyTaiKhoan.FormXacNhan
{
    public partial class XacNhanImportDSMH : Form
    {
        BUS_MonHoc bus_MH;
        private List<DTO_MonHoc> data;
        public XacNhanImportDSMH(List<DTO_MonHoc> data)
        {
            InitializeComponent();
            bus_MH = new BUS_MonHoc();
            this.data = data;
        }

        private void XacNhanImportDSMH_Load(object sender, EventArgs e)
        {
            danhSachMonHocImport.DataSource = data;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult result = questionDialog.Show("Xác nhận thêm danh sách môn học này");

            if (result == DialogResult.Yes)
            {
                foreach (DTO_MonHoc mh in data)
                {
                    if (mh != null)
                    {
                        bool chk = bus_MH.ThemMonHoc(mh);

                        if (!chk)
                        {
                            errorDialog.Show("Lỗi khi thêm " + mh.TenMonHoc + " vào cơ sở dữ liệu");
                        }
                    }
                }

                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
