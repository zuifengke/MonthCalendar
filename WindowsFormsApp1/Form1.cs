using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void monthCalendar1_DayClick(object sender, DayClickEventArgs e)
        {
           



        }

        private void monthCalendar1_DayDoubleClick(object sender, DayClickEventArgs e)
        {
            DateItem dateItem = new DateItem();
            dateItem.Date = DateTime.Parse(e.Date);
            dateItem.DateColor = Color.Red;
            dateItem.ImageListIndex = 1;
            foreach (DateItem item in this.monthCalendar1.Dates)
            {
                if (item.Date == dateItem.Date)
                {
                    this.monthCalendar1.Dates.Remove(item);
                    return;
                }
            }
            this.monthCalendar1.Dates.Add(dateItem);
        }
    }
}
