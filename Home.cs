using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }
         
        public object GetHomeClockTxt()
        {
            return homeClockTxt;
        }

        public void SetHomeClockTxt(string value)
        {
            homeClockTxt.Text = value;
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            homeClockTxt.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
