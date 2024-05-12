using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDTUAbsenceReportingManagement.View.Admin.Control.Report
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        public void setReport(object data)
        {
            crystalReportViewer1.ReportSource = data;
        }
    }
}
