using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class Vehicle : UserControl
    {
        public VehicleModel vehicleResult;
        public bool engineNumEdited = false;
        public bool addVehicle = false;
        public int errorsInForm = 0;

        private List<string> allErrors = new List<string>();

        public BindingList<CustomerModel> customers = new BindingList<CustomerModel>();

        public Vehicle()
        {
            InitializeComponent();
            FixDate();

            addThisVehicle.Visible = false;
            addThisVehicle.Enabled = false;

            deleteVehicleBtn.Visible = true;
            deleteVehicleBtn.Enabled = true;

            updateVehicleBtn.Visible = true;
            updateVehicleBtn.Enabled = true;

            location.Text = "";
        }
        
        public Vehicle(bool addVehicle)
        {
            InitializeComponent();
            FixDate();

            // Switched to add mode
            if (addVehicle)
            {
                vehicleResult = new VehicleModel(); 

                addThisVehicle.Visible = true;
                addThisVehicle.Enabled = true;

                deleteVehicleBtn.Visible = false;
                deleteVehicleBtn.Enabled = false;

                updateVehicleBtn.Visible = false;
                updateVehicleBtn.Enabled = false;

                location.Text = "-";
            }
            else
            {
                addThisVehicle.Visible = false;
                addThisVehicle.Enabled = false;

                deleteVehicleBtn.Visible = true;
                deleteVehicleBtn.Enabled = true;

                updateVehicleBtn.Visible = true;
                updateVehicleBtn.Enabled = true;

                location.Text = "";
            }
        }

        /*
         * Button Functions
         */

        public void FixDate()
        {
            //Format date time picker to just year
            yearLbl.Format = DateTimePickerFormat.Custom;
            yearLbl.CustomFormat = "yyyy";
            yearLbl.ShowUpDown = true; 
        }

        private async void addThisVehicle_Click(object sender, EventArgs e)
        {
            ValidationProcess(null); // Check all fields

            if (errorsInForm == 0)
            {
                //Get info from fields
                UpdateVehicleList();

                DialogResult dialogResult3 = MessageBox.Show("Are you sure you wish to add this Vehicle?", "Add Vehicle Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult3 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        await Task.Run(() => main.Instance.db.InsertRecord<VehicleModel>("Vehicles", vehicleResult));
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Add Vehicle Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult3 == DialogResult.No)
                {
                    return;
                }

                //Open view version of the Customer page

                //Refresh of controls
                main.Instance.PanelContainer.Controls.Clear();

                // If only one returned, go directly to Customer page 

                    if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
                    {
                        Vehicle uc = new Vehicle();
                        //Send data of Customer form 
                        uc.vehicleResult = vehicleResult;

                        //Refresh form
                        uc.RefreshInformation();

                        uc.Dock = DockStyle.Fill;
                        main.Instance.PanelContainer.Controls.Add(uc);
                    }

                    main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
            }
            else
            {
                MessageBox.Show("There are " + errorsInForm + " errors in the form. \nPlease fix them to continue", "Add Vehicle Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updateVehicleBtn_Click(object sender, EventArgs e)
        {
            ValidationProcess(null); // Check all fields

            if (errorsInForm == 0)
            {
                //Get info from fields
                UpdateVehicleList();

                if (engineNumEdited)
                {
                    DialogResult dialogResult = MessageBox.Show("You are editing the vehicle's engine number, is this correct?", "Vehicle Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Do something - Does nothing here but allows function to continue
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return; // Stops function
                    }
                }

                DialogResult dialogResult2 = MessageBox.Show("Are you sure you wish to update this vehicle?", "Vehicle Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        await Task.Run(() => main.Instance.db.UpsertRecord<VehicleModel>("Vehicles", vehicleResult.Id, vehicleResult));

                        engineNumEdited = false; // resets this variable for future
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Update Vehicle Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    return;
                }

                RefreshInformation();
                //DisableUpdateBtn();
            }
            else
            {
                MessageBox.Show("There are " + errorsInForm + " errors in the form. \nPlease fix them to continue", "Update Vehicle Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteVehicleBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + vehicleResult.EngineNum + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Try to delete
                try
                {
                    // update removed vehicles first
                    int i = 0;
                    foreach (var rem in vehicleResult.InterestedCustomers)
                    {
                        Guid newGuid = Guid.Parse(vehicleResult.InterestedCustomers[i]);
                        main.Instance.db.RemoveCustomersListInterest<CustomerModel>("Customers", vehicleResult.EngineNum, newGuid);
                        i++;
                    }
                     
                    await Task.Run(() => main.Instance.db.DeleteRecord<VehicleModel>("Vehicles", vehicleResult.Id));
                }
                catch (Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message);
                }

                //RETURN TO SEARCH
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            //Send back Home
            main.Instance.GoToHomepage();
        }

        // List Box Stuff
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            var clicked =  interestedCustomersListBox.SelectedIndex;

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this person from interested customers list: " + customers[clicked].FirstName + " " + customers[clicked].LastName + " ? ", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                interestedCustomersListBox.Items.Remove(interestedCustomersListBox.SelectedItem);
                //EnableUpdateBtn();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        { 
            UpdateListToSend();
            SearchForm search = new SearchForm(true, vehicleResult);
            search.sentFromAddPage = addVehicle;
            search.Text = "Fusion Motors: Select a Customer";
            search.titleLbl.Text = "Select a customer to add to list";
            search.Show();
            //if (addCustomer.Text.Length != 0)
            //{
            //    // Add vehicles to listbox 
            //    interestedCustomersListBox.Items.Add(addCustomer.Text);
            //    addCustomer.Text = ""; // Clear field
            //    //EnableUpdateBtn();
            //}
        }

        /*
         * Data Update Functions
         */

        public async void RefreshInformation()
        {
            ownerLbl.Text = vehicleResult.Owner;

            engineNumLbl.Text = vehicleResult.EngineNum;
            chassisNumLbl.Text = vehicleResult.ChassisNum;
            colourLbl.Text = vehicleResult.Colour;

            makeLbl.Text = vehicleResult.Make;
            modelLbl.Text = vehicleResult.Model;
            yearLbl.Text = DateTime.ParseExact(vehicleResult.Year.ToString(), "yyyy", null).ToString(); 

            valuationLbl.Text = vehicleResult.Valuation.ToString();
            askingPriceLbl.Text = vehicleResult.AskingPrice.ToString();
            additionalCommentsLbl.Text = vehicleResult.Notes;
            imageOfCar.Image = ByteToImage(vehicleResult.Image);

            // Add vehicles to listbox 

            customers = new BindingList<CustomerModel>();
            int index = 0;

            foreach (var cust in vehicleResult.InterestedCustomers)
            {
                if (vehicleResult.InterestedCustomers[0] != "") // This is from add page setting this to ""
                {
                    try
                    {
                        Guid newGuid = Guid.Parse(cust);
                        List<CustomerModel> temp = await Task.Run(() => main.Instance.db.LoadCustomerById<CustomerModel>("Customers", newGuid));
                        customers.Add(temp[0]); 
                        index++;

                    } 
                    catch (Exception err)
                    {

                    }
                }
            }

            // Attach the list of customers to the ListBox:
            interestedCustomersListBox.DataSource = customers;
            interestedCustomersListBox.DisplayMember = "FirstName";

            //DisableUpdateBtn();
        }

        private void UpdateVehicleList()
        {
            vehicleResult.Owner = ownerLbl.Text.Trim();

            vehicleResult.EngineNum = engineNumLbl.Text.Trim();
            vehicleResult.ChassisNum = chassisNumLbl.Text.Trim();
            vehicleResult.Colour = colourLbl.Text.Trim();

            int year = 2021;
            double valuation = 0;
            double askingprice = 0;

            try
            {
                year = Int32.Parse(yearLbl.Text.Trim());
                valuation = double.Parse(valuationLbl.Text, CultureInfo.InvariantCulture);
                askingprice = double.Parse(askingPriceLbl.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error converting values from textboxes into numbers \n" + err, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            vehicleResult.Make = makeLbl.Text.Trim();
            vehicleResult.Model = modelLbl.Text.Trim();
            vehicleResult.Year = year;

            vehicleResult.Valuation = valuation;
            vehicleResult.AskingPrice = askingprice;

            //vehicleResult.InterestedCustomers = interestedCustomersListBox.Items.Cast<string>().ToList();

            int x = 0;
            vehicleResult.InterestedCustomers.Clear();

            foreach (var id in customers)
            {
                vehicleResult.InterestedCustomers.Add(customers[x].Id.ToString());
                x++;
            }

            vehicleResult.Notes = additionalCommentsLbl.Text;

            if (location.Text != "-")
            {
                vehicleResult.Image = ImageToByte(imageOfCar.Image);
            }
            else
            {
                vehicleResult.Image = null;
            }

        }
        
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void UpdateListToSend()
        {
            vehicleResult.Owner = ownerLbl.Text.Trim();

            vehicleResult.EngineNum = engineNumLbl.Text.Trim();
            vehicleResult.ChassisNum = chassisNumLbl.Text.Trim();
            vehicleResult.Colour = colourLbl.Text.Trim();

            int year = 2021;
            double valuation = 0;
            double askingprice = 0;

            try
            {
                year = Int32.Parse(yearLbl.Text.Trim());
                valuation = double.Parse(valuationLbl.Text, CultureInfo.InvariantCulture);
                askingprice = double.Parse(askingPriceLbl.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception err)
            {
                //MessageBox.Show("Error converting values from textboxes into numbers \n" + err, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            vehicleResult.Make = makeLbl.Text.Trim();
            vehicleResult.Model = modelLbl.Text.Trim();
            vehicleResult.Year = year;

            vehicleResult.Valuation = valuation;
            vehicleResult.AskingPrice = askingprice;

            //vehicleResult.InterestedCustomers = interestedCustomersListBox.Items.Cast<string>().ToList();
        }

        /*
        * Field Functions
        */

        private void Vehicle_Click(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void engineNumLbl_Leave(object sender, EventArgs e)
        {
            ValidationProcess(engineNumLbl);

            //Sets engine num edited variable based on if it has been edited for update purposes
            if (!engineNumLbl.Text.Trim().Equals(vehicleResult.EngineNum))
            {
                engineNumEdited = true;
            }else
            {
                engineNumEdited = false;
            }
        }

        private void chassisNumLbl_Leave(object sender, EventArgs e)
        {
            ValidationProcess(chassisNumLbl);
        }

        private void colourLbl_Leave(object sender, EventArgs e)
        {
            ValidationProcess(colourLbl);
        }

        /*
         *  Assisting Functions
         */

        private void EnableUpdateBtn()
        {
            updateVehicleBtn.Enabled = true;
            updateVehicleBtn.Visible = true;
        }

        private void DisableUpdateBtn()
        {
            updateVehicleBtn.Enabled = false;
            updateVehicleBtn.Visible = false;
        }

        private void ChangeFieldColourValidate(TextBox field, int checker)
        {
            field.ForeColor = Color.Red;
        }

        private void ValidationProcess(TextBox field)
        {
            validation validate = new validation();

            List<string> err = new List<string>();

            int counter = 0;

            if (field == null)
            {
                int lastCheck = 0;
                int checker = 0;

                // Means check all relevant fields
                err.AddRange(validate.CheckEngineNum(engineNumLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(engineNumLbl, checker);
                    lastCheck = checker;
                }

                err.AddRange(validate.CheckChassisNum(chassisNumLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(chassisNumLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckColour(colourLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(colourLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckMake(makeLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(makeLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckModel(modelLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(modelLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckPrices(valuationLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(valuationLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckPrices(askingPriceLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(askingPriceLbl, checker);
                    lastCheck = checker;
                }

                if (err.Count != 0)
                {
                    allErrors.Clear();
                    allErrors.AddRange(err);
                    errorsInForm = err.Count;
                }
                else if (err.Count == 0)
                {
                    allErrors.Clear();
                    viewErrors.Enabled = false;
                    viewErrors.Visible = false;
                    errorsInForm = 0;
                }

                return;
            }

            switch (field.Name)
            {
                case "engineNumLbl":
                    err = validate.CheckEngineNum(engineNumLbl.Text.Trim());
                    OutputErrors(field, err);
                    break;
                case "chassisNumLbl":
                    err = validate.CheckChassisNum(chassisNumLbl.Text.Trim());
                    OutputErrors(field, err);
                    break;
                case "colourLbl":
                    err = validate.CheckColour(colourLbl.Text.Trim());
                    OutputErrors(field, err);
                    break; 
                default:
                    err.Add("Cannot resolve validation query - Error occurred");
                    OutputErrors(field, err);
                    break;
            }

            if (allErrors.Count == 0)
            {
                viewErrors.Enabled = false;
                viewErrors.Visible = false;
            }
            else
            {
                viewErrors.Enabled = true;
                viewErrors.Visible = true;
            }
        }

        private void OutputErrors(TextBox field, List<string> err)
        {
            if (err.Count == 0) // No Errors returned
            {
                field.ForeColor = Color.Black;
                //EnableUpdateBtn();
            }
            else if (err.Count > 0)
            {
                field.ForeColor = Color.Red;
                //DisableUpdateBtn(); // Only enable updates if all checks are correct

                string compileErrors = "";

                foreach (var item in err)
                {
                    compileErrors += "\n" + item;
                }

                if (allErrors.Count == 0)
                {
                    allErrors.Add("Error List:");
                }

                //MessageBox.Show(compileErrors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chassisNumLbl_ForeColorChanged(object sender, EventArgs e)
        {
            L1.ForeColor = chassisNumLbl.ForeColor;
        }

        private void valuationLbl_Leave(object sender, EventArgs e)
        {
            string valuation = valuationLbl.Text.Trim();
            Regex rg = new Regex(@"^[0-9\.]$");
             
            string newValuation = Regex.Replace(valuation, @"[^0-9\.]+", String.Empty);
            valuationLbl.Text = newValuation;

            if (valuationLbl.Text.Length > 0)
            {
                valuationLbl.ForeColor = Color.Black;
            }
        }

        private void askingPriceLbl_Leave(object sender, EventArgs e)
        {
            string askingprice = askingPriceLbl.Text.Trim();
            Regex rg = new Regex(@"^[0-9\.]$");

            string newAskingPrice = Regex.Replace(askingprice, @"[^0-9\.]+", String.Empty);
            askingPriceLbl.Text = newAskingPrice;

            if (askingPriceLbl.Text.Length > 0)
            {
                askingPriceLbl.ForeColor = Color.Black;
            }
        }

        private void interestedCustomersListBox_DoubleClick(object sender, EventArgs e)
        { 
            int selectedIndex = interestedCustomersListBox.SelectedIndex;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear(); 

            if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
            {
                Customer uc = new Customer();
                //Send data of Customer form 
                uc.customerResult = customers[selectedIndex];
                //Refresh form
                uc.RefreshInformation();

                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["Customer"].BringToFront();
        }

        private void viewErrors_Click(object sender, EventArgs e)
        {
            string errs = "";
            int i = 0;

            ValidationProcess(null);

            foreach (var error in allErrors)
            {
                if (i == 0)
                {
                    errs = allErrors[i];
                }
                else
                {
                    errs += "\n" + allErrors[i];
                }
                i++;
            }

            if (allErrors.Count != 0)
            {
                MessageBox.Show(errs, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All errors cleared!", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void makeLbl_Leave(object sender, EventArgs e)
        {
            if (makeLbl.Text.Length > 0)
            {
                makeLbl.ForeColor = Color.Black;
            }
        }

        private void modelLbl_Leave(object sender, EventArgs e)
        {
            if (modelLbl.Text.Length > 0)
            {
                modelLbl.ForeColor = Color.Black;
            }
        }

        private void colourLbl_Leave_1(object sender, EventArgs e)
        {
            if (colourLbl.Text.Length > 0)
            {
                colourLbl.ForeColor = Color.Black;
            }
        }

        private void imageOfCar_DoubleClick(object sender, EventArgs e)
        {
            //AddVehicleImg vehic = new AddVehicleImg();
            //vehic.Show();

            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imageOfCar.Image = new Bitmap(open.FileName);

                // image file path  
                location.Text = open.FileName;
                toolTip.SetToolTip(location, location.Text);
            }
        }

        private void imageOfCar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //Right Click event. Clear stuff
                imageOfCar.Image = null;

                location.Text = "-";
                toolTip.SetToolTip(location, location.Text);
            }
        }
    }
}
