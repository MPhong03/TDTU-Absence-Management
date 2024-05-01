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
        private string maBaoVang = string.Empty;
        public GuiBaoBuControl(string id)
        {
            InitializeComponent();

            this.maBaoVang = id;

            label1.Text = "Gửi báo bù cho báo vắng: " + maBaoVang;
        }

    }
}
