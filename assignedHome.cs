using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Networking;

namespace Database_Application_Chris
{
    public partial class assignedHome : UserControl
    {

        Firestore conn; // global reference to firestore database

        public assignedHome()
        {
            InitializeComponent();
        }

        private void assignedHome_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private async void LoadItems()
        {
            try
            {
                // Clear out both list views for data population
                listView.Items.Clear();
                listViewVehicles.Items.Clear();

                // Query Records
                Query allCustomersQuery;

                // Fetch all customers where AGENT is the same agent
                //Getting logged in user first and last names
                var getNames = main.Instance.userNameLbl.Text.Trim().Split(" ");

                conn = new Firestore();

                allCustomersQuery = conn.db.Collection("Customers").WhereEqualTo("Agent", getNames[0]);

                QuerySnapshot allCustomersQuerySnapshot = await allCustomersQuery.GetSnapshotAsync();

                int x = 1;
                foreach (DocumentSnapshot documentSnapshot in allCustomersQuerySnapshot.Documents)
                {
                    CustomerFrame custModel = documentSnapshot.ConvertTo<CustomerFrame>();


                    var row = new string[] {
                                                x.ToString(),
                                                custModel.FirstName,
                                                custModel.LastName,
                                                custModel.ContactNum1,
                                                custModel.Address
                                            };

                    var item = new ListViewItem(row);
                    x++;
                    item.Tag = documentSnapshot.Id;
                    listView.Items.Add(item);
                }

                // VEHICLES STUFF -------------------------------------------------------------------
                // Load Records 
                Query allVehiclesQuery = conn.db.Collection("Vehicles").WhereEqualTo("Agent", getNames[0]);
                QuerySnapshot allVehiclesQuerySnapshot = await allVehiclesQuery.GetSnapshotAsync();

                int y = 1;
                foreach (DocumentSnapshot documentSnapshot in allVehiclesQuerySnapshot.Documents)
                {
                    VehicleFrame vehicleModel = documentSnapshot.ConvertTo<VehicleFrame>();

                    var row = new string[] {
                                                y.ToString(),
                                                vehicleModel.EngineNumber,
                                                vehicleModel.Make,
                                                vehicleModel.Model,
                                                vehicleModel.Year.ToString(),
                                                vehicleModel.Valuation.ToString(),
                                                vehicleModel.AskingPrice.ToString(),
                                                vehicleModel.Colour
                                            };

                    var item = new ListViewItem(row);
                    y++;
                    item.Tag = documentSnapshot.Id;
                    listViewVehicles.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        { 
                try
                {
                    string documentID = listView.SelectedItems[0].Tag.ToString();


                    // OPEN CUSTOMER
                    //Refresh of controls
                    main.Instance.PanelContainer.Controls.Clear();

                    //Open Customer
                    if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
                    {
                        Customer uc = new Customer();
                        uc.Dock = DockStyle.Fill;

                        CustomerFrame cust = new CustomerFrame();

                        uc.reference = documentID;  // Reset page variable with new information

                        //Refresh form
                        uc.RefreshInformation();
                        main.Instance.PanelContainer.Controls.Add(uc);
                    }

                    main.Instance.PanelContainer.Controls["Customer"].BringToFront();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Index Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
        }

        private void listViewVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string documentID = listViewVehicles.SelectedItems[0].Tag.ToString();


                // OPEN VEHICLE
                //Refresh of controls
                main.Instance.PanelContainer.Controls.Clear();

                //Open Vehicle
                if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
                {
                    Vehicle uc = new Vehicle();
                    uc.Dock = DockStyle.Fill;

                    VehicleFrame vehicle = new VehicleFrame();

                    uc.reference = documentID;  // Reset page variable with new information

                    //Refresh form
                    uc.RefreshInformation();
                    main.Instance.PanelContainer.Controls.Add(uc);
                }

                main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Index Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
