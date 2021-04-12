using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class SearchHomeControl : UserControl
    {
        private string customerTipString = "Search by first and last name (Eg. James Bond)...";
        private string vehicleTipString = "Search by engine no. (Eg. CC43545)...";

        public SearchHomeControl()
        {
            InitializeComponent();

            // Set up page for default values
            Init();
        }

        private void Init()
        {
            customersRadio.Checked = true;
            searchTxt.Text = customerTipString;
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if (searchTxt.Text == customerTipString || searchTxt.Text == vehicleTipString)
            {
                searchTxt.Text = "";
                searchTxt.ForeColor = Color.Black;
            } 
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            {
                if (customersRadio.Checked)
                    searchTxt.Text = customerTipString;
                if (vehiclesRadio.Checked)
                    searchTxt.Text = vehicleTipString;

                searchTxt.ForeColor = Color.DarkGray;
            } 
        } 

        private void radioSelection()
        {
            if (customersRadio.Checked)
            {
                SearchPageLabel.Text = "Customers";

                if (searchTxt.Text == vehicleTipString || searchTxt.Text == "")
                {
                    searchTxt.Text = customerTipString;
                    searchTxt.ForeColor = Color.DarkGray;
                } 
            }
            else if (vehiclesRadio.Checked)
            {
                SearchPageLabel.Text = "Vehicles";

                if (searchTxt.Text == customerTipString || searchTxt.Text == "")
                {
                    searchTxt.Text = vehicleTipString;
                    searchTxt.ForeColor = Color.DarkGray;
                }
            }
        }

        private void customersRadio_Click(object sender, EventArgs e)
        {
            radioSelection();
        }

        private void vehiclesRadio_Click(object sender, EventArgs e)
        {
            radioSelection();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTxt.Text;

            string[] names = { "", "" };
            string lastname = "";

            names = searchQuery.Split(' ');

            if (names.Length <= 1)
            {
                lastname = "";
            }
            if (names.Length == 2)
            {
                lastname = names[1];
            }

            if (searchQuery == customerTipString || searchQuery == vehicleTipString)
            {
                MessageBox.Show("Please provide a first name, or both first name and last name to search!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //CALL SEARCH FUNCTION AND RETURN RESULTS 
            List<CustomerModel> listCResults;

            if (customersRadio.Checked == true)
            {
                listCResults = searchCustomers(names[0], lastname);

                int totalResults = 0; 

                foreach (var rec in listCResults)
                {
                    totalResults++; //Counts records returned
                }

                // Nothing found
                if (totalResults == 0)
                {
                    MessageBox.Show("No customers found by the name: " + names[0] + " " + lastname, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Refresh of controls
                main.Instance.PanelContainer.Controls.Clear();

                // If only one returned, go directly to Customer page
                if (totalResults == 1)
                {

                    if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
                    {
                        Customer uc = new Customer();
                        //Send data of Customer form 
                        uc.customerResult = listCResults[0];
                        //Refresh form
                        uc.RefreshInformation();

                        uc.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(uc);
                    }

                    main.Instance.PanelContainer.Controls["Customer"].BringToFront();

                    return;
                }

                //Else go to customer search results page 
                if (totalResults > 1)
                {
                    //Open search results form
                    if (!main.Instance.PanelContainer.Controls.ContainsKey("SearchResultsControl"))
                    {
                        SearchResultsControl uc = new SearchResultsControl();
                        //Send data of search results accross to Search Results form
                        uc.searchResults = listCResults;
                        uc.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(uc);
                    }

                    main.Instance.PanelContainer.Controls["SearchResultsControl"].BringToFront();
                }
            }
            else if (vehiclesRadio.Checked == true)
            {
                //listVResults = searchVehicles();
            }            

        }

        private List<CustomerModel> searchCustomers(string firstname, string lastname)
        {
            var recs = main.Instance.db.LoadCustomerByName<CustomerModel>("Customers", firstname, lastname);
            return recs;
        }

        private List<VehicleModel> searchVehicles()
        {
            return null;
        }
         
    }
}
