using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class DatabaseHome : UserControl
    {
        public DatabaseHome()
        {
            InitializeComponent();
        }

        private void viewVehicles_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm(true, false, null);
            search.Text = "Fusion Motors: Vehicles";
            search.Show();
        }

        private void viewCustomers_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm(false, null);
            search.Text = "Fusion Motors: Customers";
            search.Show();
        }
    }
}
