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
    public partial class ThongBaoItem : UserControl
    {
        public ThongBaoItem()
        {
            InitializeComponent();
        }
        public void setTitle(string text)
        {
            title.Text = text;
        }
        public string getTitle()
        {
            return title.Text;
        }
        public void setDate(DateTime data)
        {
            date.Text = data.ToString("dd-MM-yyyy");
        }
        public void setDescription(string text)
        {
            description.Text = text;
        }
        public string getDescription()
        {
            return description.Text;
        }
        public void setID(int id)
        {
            notificationID.Text = "ID: " + id.ToString();
        }
        public void setSender(string text)
        {
            sender.Text = text;
        }
    }
}
