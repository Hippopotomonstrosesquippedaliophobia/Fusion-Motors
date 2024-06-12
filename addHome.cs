using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class addHome : UserControl
    {
        public addHome()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            // Blank Customer Model
            CustomerFrame customer = new CustomerFrame
            {
                FirstName = "",
                LastName = "",
                Address = "",
                ContactNum1 = "",
                ContactNum2 = "",
                Emails = { },
                InterestedVehicles = new List<string> { "" },
                InProgressFlag = false,
                CallBackFlag = false
            };

            //Open Add Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
            {
                Customer uc = new Customer(true);
                uc.customerResult = customer;
                uc.addCustomer = true;
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }
            main.Instance.PanelContainer.Controls["Customer"].BringToFront();
        }

        private void addVehicle_Click(object sender, EventArgs e)
        {
            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            // Blank Customer Model
            VehicleModel vehicle = new VehicleModel
            {
                EngineNum = "",
                ChassisNum = "",
                Colour = "",
                InterestedCustomers = new List<string> { "" }
            };

            //Open Add Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
            {
                Vehicle uc = new Vehicle(true);
                uc.vehicleResult = vehicle;
                uc.addVehicle = true;
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }
            main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
        }
    }
}
