using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDTUAbsenceReportingManagement.View.Lecturers.Control.Components
{
    public partial class LopDayItem : UserControl
    {
        public LopDayItem()
        {
            InitializeComponent();
        }

        public void setMonHoc(string text)
        {
            monHoc.Text = text;
        }

        public void setNgay(string text)
        {
            ngayHoc.Text = text;
        }

        public void setCa(string text)
        {
            caHoc.Text = text;
        }

        public void setNhomTo(string text)
        {
            nhomToHoc.Text = text;
        }

        public void setTrangThai(string text)
        {
            trangThai.Text = text;
        }

        public void setItemColor(Color color)
        {
            this.BackColor = color;
        }

        public void setItemFontColor(Color color)
        {
            this.ForeColor = color;
        }
    }
}
