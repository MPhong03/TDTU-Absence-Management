using FinalProject.DTO;
using FinalProject.Views.Auths;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Views.Admin
{
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            adminTitleWelcome.Text = "Welcome, " + SessionManager.Username + ", Role: " + SessionManager.Role + "";
        }

        private void tabPageAdminHome_Click(object sender, EventArgs e)
        {

        }

    }
}
