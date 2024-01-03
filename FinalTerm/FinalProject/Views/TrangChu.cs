using FinalProject.DTO;
using FinalProject.Views.Auths;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Views
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SessionManager.Username))
            {
                DangNhap dangNhapForm = new DangNhap();
                dangNhapForm.Show();
                this.Hide();
            }
            else
            {
                textTest.Text = SessionManager.Username + SessionManager.Role;

                this.Show();
            }
        }
    }
}
