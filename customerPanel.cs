using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Database_Application_Chris
{
    public partial class customerPanel : UserControl
    {
        public CustomerFrame customer;

        public customerPanel()
        {
            InitializeComponent();
        }

        private void customerPanel_Load(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        public void RefreshInformation()
        {
            name.Text = customer.FirstName + " " + customer.LastName;
            num.Text = customer.ContactNums[1].ToString();
            address.Text = customer.Address;
            //parish.Text = customer.Address.Parish;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            //Open Customer
            if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
            {
                Customer uc = new Customer();
                uc.Dock = DockStyle.Fill;

                //Send data of Customer form 
                uc.customerResult = customer;
                //Refresh form
                uc.RefreshInformation();

                uc.customerResult = customer; // Reset page variable with new information
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["Customer"].BringToFront();
        }
    }
}
