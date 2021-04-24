using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class SearchForm : Form
    {
        //Mouse drag of window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Minimize from taskbar behaviour
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        bool isVehicleSearch = false;
        bool selectForList = false;
        public bool sentFromAddPage = false;

        public CustomerModel selectForListCModel = new CustomerModel();
        public VehicleModel selectForListVModel = new VehicleModel();

        public List<CustomerModel> listCustomers;
        public List<VehicleModel> listVehicles;

        public IDictionary<long, Guid> matchList = new Dictionary<long, Guid>();

        public SearchForm(bool selection, VehicleModel model)
        {
            InitializeComponent();
            listCustomers = new List<CustomerModel>();

            // Tells if this is going to open the customer or send back the information to open customer page
            selectForList = selection;

            if (selection)
            {
                selectForListVModel = model;
            }

            titleLbl.Text = "Customers";
            searchBtn.Text = "Find a Customer";

            listViewVehicles.Enabled = false;
            listViewVehicles.Visible = false;

            listView.Enabled = true;
            listView.Visible = true;
        }
        
        public SearchForm(bool vehicle, bool selection, CustomerModel model)
        {
            InitializeComponent();
            listVehicles = new List<VehicleModel>();

            // Tells if this is going to open the customer or send back the information to open customer page
            selectForList = selection;

            if (selection)
            {
                selectForListCModel = model;
            }

            if (vehicle)
            {
                titleLbl.Text = "Vehicles";
                isVehicleSearch = true;
                searchBtn.Text = "Find a Vehicle";

                listViewVehicles.Enabled = true;
                listViewVehicles.Visible = true;
                
                listView.Enabled = false;
                listView.Visible = false;
            }
        }

        /*
         * Button Functions
         */

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTxt.Text.Trim(); 

            string name = searchQuery;
            string[] names = name.Split(' ');
            string lastname = "";

            try
            {
                lastname = names[1];
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // This is a search for customers
            if (!isVehicleSearch)
            {
                try
                {
                    if (searchQuery.Length == 0)
                    {
                        listCustomers = await Task.Run(() => main.Instance.db.LoadRecords<CustomerModel>("Customers"));
                    }
                    else
                    {
                        listCustomers = await Task.Run(() => main.Instance.db.LoadCustomerByName<CustomerModel>("Customers", names[0], lastname));
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateListView<CustomerModel>(listCustomers);
            }
            // This is a search for vehicles
            if (isVehicleSearch)
            {
                try
                {
                    if (searchQuery.Length == 0)
                    {
                        listVehicles = await Task.Run(() => main.Instance.db.LoadRecords<VehicleModel>("Vehicles"));
                    }
                    else
                    {
                        string[] safeSearch = searchQuery.Split(' ');

                        listVehicles = await Task.Run(() => main.Instance.db.LoadVehicleByEngine<VehicleModel>("Vehicles", safeSearch[0]));
                    } 
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateListView<VehicleModel>(listVehicles);
            }            
        }

        private void UpdateListView<T>(List<T> list)
        {
            //Clear out list view and matchList
            listView.Items.Clear();
            listViewVehicles.Items.Clear();
            matchList.Clear();

            if (isVehicleSearch)
            {
                int counter = 0;
                int ID = 1;

                if (list != null)
                {
                    foreach (var record in list)
                    {
                        var row = new string[] {
                                                ID.ToString(),
                                                listVehicles[counter].EngineNum,
                                                listVehicles[counter].Make,
                                                listVehicles[counter].Model,
                                                listVehicles[counter].Year.ToString(),
                                                "$ " + listVehicles[counter].Valuation.ToString(),
                                                "$ " + listVehicles[counter].AskingPrice.ToString(), 
                                                listVehicles[counter].Colour
                                            };

                        var item = new ListViewItem(row);

                        item.Tag = record;
                        listViewVehicles.Items.Add(item);

                        // Set List Equivalent to this id
                        matchList.Add(ID, listVehicles[counter].Id);

                        counter++;
                        ID++;
                    }

                    // Update with number of records found
                    countLbl.Text = list.Count() + " Vehicle(s) found";
                }
                else
                {
                    countLbl.Text = 0 + " Vehicle(s) found";
                }
            }
            else 
            {
                int counter = 0;
                int ID = 1;

                if (list != null)
                {
                    foreach (var record in list)
                    {
                        var row = new string[] {
                                                ID.ToString(),
                                                listCustomers[counter].FirstName, listCustomers[counter].LastName,
                                                BeautifulPhoneText(listCustomers[counter].ContactNums.ContactNum1.ToString()),
                                                listCustomers[counter].PrimaryAddress.StreetAddress + ", "
                                                    + listCustomers[counter].PrimaryAddress.Parish + ", "
                                                    + listCustomers[counter].PrimaryAddress.Country
                                            };

                        var item = new ListViewItem(row);

                        item.Tag = record;
                        listView.Items.Add(item);

                        // Set List Equivalent to this id
                        matchList.Add(ID, listCustomers[counter].Id);

                        counter++;
                        ID++;
                    }

                    // Update with number of records found
                    countLbl.Text = list.Count() + " Customer(s) found";
                }else
                {
                    countLbl.Text = 0 + " Customer(s) found";
                }
            }            
        }

        /*
         *  Utility Functions
         */
        //Minimizes form
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Closes form
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Allows window to be dragged 
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Minimize behaviour for window
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }


        /*
         *  Useful functions
         */
        // Loads records after form shown
        private async void SearchForm_Shown(object sender, EventArgs e)
        {
            if (isVehicleSearch)
            {
                // Load records
                listCustomers = null;
                listVehicles = await Task.Run(() => main.Instance.db.LoadRecords<VehicleModel>("Vehicles"));
                UpdateListView<VehicleModel>(listVehicles);
            }
            else
            {
                // Load Records
                listVehicles = null;
                listCustomers = await Task.Run(() => main.Instance.db.LoadRecords<CustomerModel>("Customers"));
                UpdateListView<CustomerModel>(listCustomers);
            }
        }

        private async void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            long selectedIndex = 1;

            if (!isVehicleSearch) // Customer 
            {
                try
                {
                    selectedIndex = Int64.Parse(listView.SelectedItems[0].SubItems[0].Text);

                    Guid id = matchList[selectedIndex];

                    // OPEN Vehicle
                    if (!selectForList)
                    {
                        // OPEN CUSTOMER
                        //Refresh of controls
                        main.Instance.PanelContainer.Controls.Clear();

                        //Open Customer
                        if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
                        {
                            Customer uc = new Customer();
                            uc.Dock = DockStyle.Fill;

                            CustomerModel cust = new CustomerModel();

                            try
                            {
                                List<CustomerModel> tempList = await Task.Run(() => main.Instance.db.LoadCustomerById<CustomerModel>("Customers", id));

                                if (tempList.Count == 0)
                                {
                                    throw new Exception("No record found");
                                }
                                else
                                {
                                    cust = tempList[0];
                                }
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            uc.customerResult = cust; // Reset page variable with new information

                            //Refresh form
                            uc.RefreshInformation();
                            main.Instance.PanelContainer.Controls.Add(uc);
                        }

                        main.Instance.PanelContainer.Controls["Customer"].BringToFront(); 
                    }
                    else // Selected to pass thru for list from Customer
                    { 
                        //Refresh of controls
                        main.Instance.PanelContainer.Controls.Clear();
                        //selectForListCModel
                        //Open Customer
                        if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
                        {
                            Vehicle uc = new Vehicle(sentFromAddPage);
                            uc.Dock = DockStyle.Fill;

                            try
                            { 
                                List<CustomerModel> tempList = await Task.Run(() => main.Instance.db.LoadCustomerById<CustomerModel>("Customers", id));

                                if (tempList.Count == 0)
                                {
                                    throw new Exception("No record found");
                                }
                                else
                                {
                                    selectForListVModel.InterestedCustomers.Add(tempList[0].Id.ToString());
                                }
                            }
                            catch (Exception err)
                            {
                                //MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            uc.vehicleResult = selectForListVModel; // Reset page variable with new information

                            //Refresh form
                            uc.RefreshInformation();
                            main.Instance.PanelContainer.Controls.Add(uc);

                            main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
                        }
                    }
                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message, "Index Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Vehicle Search
            {
                try
                {
                    selectedIndex = Int64.Parse(listViewVehicles.SelectedItems[0].SubItems[0].Text);

                    Guid id = matchList[selectedIndex];

                    // OPEN Vehicle
                    if (!selectForList)
                    {
                        //Refresh of controls
                        main.Instance.PanelContainer.Controls.Clear();

                        //Open Customer
                        if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
                        { 
                            Vehicle uc = new Vehicle();
                            uc.Dock = DockStyle.Fill;

                            VehicleModel vehic = new VehicleModel();

                            try
                            {
                                var engineNumber = listViewVehicles.SelectedItems[0].SubItems[1].Text;
                                List<VehicleModel> tempList = await Task.Run(() => main.Instance.db.LoadVehicleByEngine<VehicleModel>("Vehicles", engineNumber));

                                if (tempList.Count == 0)
                                {
                                    throw new Exception("No record found");
                                }
                                else
                                {
                                    vehic = tempList[0];
                                }
                            }
                            catch (Exception err)
                            {
                                //MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            uc.vehicleResult = vehic; // Reset page variable with new information

                            //Refresh form
                            uc.RefreshInformation();
                            main.Instance.PanelContainer.Controls.Add(uc);

                            main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
                        }
                    }
                    else // Selected to pass thru for list from Customer
                    { 
                        //Refresh of controls
                        main.Instance.PanelContainer.Controls.Clear();
                         
                        //selectForListCModel
                        //Open Customer
                        if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
                        {
                            Customer uc = new Customer(sentFromAddPage);
                            uc.Dock = DockStyle.Fill; 

                            try
                            {
                                var engineNumber = listViewVehicles.SelectedItems[0].SubItems[1].Text;
                                List<VehicleModel> tempList = await Task.Run(() => main.Instance.db.LoadVehicleByEngine<VehicleModel>("Vehicles", engineNumber));

                                if (tempList.Count == 0)
                                {
                                    throw new Exception("No record found");
                                }
                                else
                                {
                                    bool alreadyAdded = false;
                                    int i = 0;

                                    uc.customerResult = selectForListCModel;

                                    foreach (var veh in uc.customerResult.InterestedVehicles)
                                    {
                                        if (tempList[0].EngineNum == uc.customerResult.InterestedVehicles[i])
                                        {
                                            alreadyAdded = true;
                                        }
                                        i++;
                                    }

                                    if (!alreadyAdded)
                                    {
                                        uc.customerResult.InterestedVehicles.Add(tempList[0].EngineNum);
                                    }else
                                    {
                                        //await Task.Run(() => MessageBox.Show("Already added this vehicle", "Vehicle Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
                                    }

                                    //selectForListCModel.InterestedVehicles.Add(tempList[0].EngineNum);
                                } 
                            }
                            catch (Exception err)
                            {
                                //MessageBox.Show(err.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                           // uc.customerResult = selectForListCModel; // Reset page variable with new information
                            

                            //Refresh form
                            uc.RefreshInformation();

                            main.Instance.PanelContainer.Controls.Add(uc);

                            main.Instance.PanelContainer.Controls["Customer"].BringToFront();
                        }
                    }

                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message, "Index Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string BeautifulPhoneText(string extractedNum)
        {
            string reconstructedNum = "";

            if (extractedNum.Length == 7)
            {
                // No Area Code
                reconstructedNum = extractedNum.Insert(3, "-");
                reconstructedNum = "+ 1 (246) " + reconstructedNum; 
            }
            else if (extractedNum.Length == 10)
            {
                // No 1 in front area code
                reconstructedNum = extractedNum.Insert(0, "(");
                reconstructedNum = reconstructedNum.Insert(4, ")");
                reconstructedNum = reconstructedNum.Insert(5, " ");
                reconstructedNum = reconstructedNum.Insert(9, "-");
                reconstructedNum = "+ 1 " + reconstructedNum; 
            }
            else if (extractedNum.Length == 11)
            {
                // Full number
                reconstructedNum = extractedNum.Insert(0, "+");
                reconstructedNum = reconstructedNum.Insert(1, " ");
                reconstructedNum = reconstructedNum.Insert(3, " ");
                reconstructedNum = reconstructedNum.Insert(4, "(");
                reconstructedNum = reconstructedNum.Insert(8, ")");
                reconstructedNum = reconstructedNum.Insert(9, " ");
                reconstructedNum = reconstructedNum.Insert(13, "-"); 
            }

            return reconstructedNum;
        }

    }
}
