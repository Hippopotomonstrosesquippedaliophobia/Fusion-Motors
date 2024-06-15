using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Networking;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Database_Application_Chris
{
    public partial class SearchHomeControl : UserControl
    {
        Firestore conn; // global reference to firestore database
        String reference; //global document reference for firebase document search

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

            conn = new Firestore();
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

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTxt.Text;

            // If search field is empty
            if (searchQuery == customerTipString)
            {
                MessageBox.Show("Please provide a first name, or both first name and last name to search!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchQuery == vehicleTipString)
            {
                MessageBox.Show("Please provide an engine no. to search!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //CALL SEARCH FUNCTION AND RETURN RESULTS 

            // Search for customer
            if (customersRadio.Checked == true)
            {
                List<CustomerFrame> listResults = new List<CustomerFrame>();

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

                //QUERY customers 
                Query allCustomersQuery;

                if (lastname.Length > 0)
                {
                    allCustomersQuery = conn.db.Collection("Customers").WhereEqualTo("FirstName", names[0].Trim())
                                                                     .WhereEqualTo("LastName", lastname.Trim());
                }
                else
                {
                    allCustomersQuery = conn.db.Collection("Customers").WhereGreaterThanOrEqualTo("FirstName", names[0].Trim())
                                                                       .OrderBy("FirstName");
                }

                QuerySnapshot allCustomersQuerySnapshot = await allCustomersQuery.GetSnapshotAsync();

                //Set up to pass reference to customer page
                Customer uc = new Customer();
                Boolean checkFail = false;

                foreach (DocumentSnapshot documentSnapshot in allCustomersQuerySnapshot.Documents)
                {
                    CustomerFrame custModel = documentSnapshot.ConvertTo<CustomerFrame>();

                    if (lastname.Length <= 0)
                    {
                        for (int i = 0; i < searchQuery.Length; i++)
                        {
                            if (searchQuery[i] == custModel.FirstName[i])
                            {
                                //
                            }
                            else
                            {
                                checkFail = true;
                                break;
                            }

                        }
                    }

                    if (!checkFail)
                    {
                        custModel.Id = documentSnapshot.Id;
                        listResults.Add(custModel);
                    } 
                }
                 
                // Nothing found
                if (allCustomersQuerySnapshot.Count() == 0)
                {
                    MessageBox.Show("No customers found by the name: " + names[0] + " " + lastname, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Refresh of controls
                main.Instance.PanelContainer.Controls.Clear();

                // If only one returned, go directly to Customer page
                if (listResults.Count() == 1)
                {

                    if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
                    {

                        uc.reference = listResults[0].Id;
                        //Refresh form
                        uc.RefreshInformation();

                        uc.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(uc);
                    }

                    main.Instance.PanelContainer.Controls["Customer"].BringToFront();

                    return;
                }

                //Else go to customer search results page 
                if (allCustomersQuerySnapshot.Count() > 1)
                {
                    //Open search results form
                    if (!main.Instance.PanelContainer.Controls.ContainsKey("SearchResultsControl"))
                    {
                        SearchResultsControl src = new SearchResultsControl();
                        //Send data of search results accross to Search Results form
                        src.searchResults = listResults;
                        src.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(src);
                    }

                    main.Instance.PanelContainer.Controls["SearchResultsControl"].BringToFront();
                }
            }


            ////Search for vehicle
            else if (vehiclesRadio.Checked == true)
            {
                List<VehicleFrame> listResults = new List<VehicleFrame>();

                Query allVehiclesQuery = conn.db.Collection("Vehicles").WhereEqualTo("EngineNumber", searchQuery.Trim());

                QuerySnapshot allVehiclesQuerySnapshot = await allVehiclesQuery.GetSnapshotAsync();

                //Set up to pass reference to customer page
                Vehicle vc = new Vehicle();
                Boolean checkFail = false;

                foreach (DocumentSnapshot documentSnapshot in allVehiclesQuerySnapshot.Documents)
                {
                    VehicleFrame vehicleModel = documentSnapshot.ConvertTo<VehicleFrame>();
                     
                    vehicleModel.Id = documentSnapshot.Id;
                    listResults.Add(vehicleModel); 
                }

                // Nothing found
                if (listResults.Count() == 0)
                {
                    MessageBox.Show("No vehicles found with the Engine No: " + searchQuery, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Refresh of controls
                main.Instance.PanelContainer.Controls.Clear(); 

                // If only one returned, go directly to Vehicle page
                if (listResults.Count() >= 1)
                { 
                    if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
                    {
                        //Send data of Vehicle form 
                        vc.reference = listResults[0].Id;

                        //Refresh form
                        vc.RefreshInformation();

                        vc.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(vc);
                    }

                    main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();

                    return;
                } 
            }

        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            // Start Search
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }
    }
}
