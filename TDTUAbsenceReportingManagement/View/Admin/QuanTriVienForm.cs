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

namespace TDTUAbsenceReportingManagement.View.Admin
{
    public partial class QuanTriVienForm : Form
    {
        public QuanTriVienForm()
        {
            InitializeComponent();
            AdminTrangChuForm uc = new AdminTrangChuForm();
            addUserControl(uc);
        }

        internal void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminContainerControl.Controls.Clear();
            adminContainerControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void homeTabButton_Click(object sender, EventArgs e)
        {
            AdminTrangChuForm uc = new AdminTrangChuForm();
            addUserControl(uc);
            //homeTabButton.HoverState
        }

        private void accountManageTabButton_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanForm uc = new QuanLyTaiKhoanForm();
            addUserControl(uc);
        }

        private void baoVangTabButton_Click(object sender, EventArgs e)
        {
            QuanLyBaoVangForm uc = new QuanLyBaoVangForm();
            addUserControl(uc);
        }

        private void baoBuTabButton_Click(object sender, EventArgs e)
        {
            QuanLyBaoBuForm uc = new QuanLyBaoBuForm();
            addUserControl(uc);
        }

        private void courseTabButton_Click(object sender, EventArgs e)
        {
            QuanLyMonHocForm uc = new QuanLyMonHocForm();
            addUserControl(uc);
        }


    }
}
