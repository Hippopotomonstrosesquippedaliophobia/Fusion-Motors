using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            }else
            {
                addThisVehicle.Visible = false;
                addThisVehicle.Enabled = false;

                deleteVehicleBtn.Visible = true;
                deleteVehicleBtn.Enabled = true;

                updateVehicleBtn.Visible = true;
                updateVehicleBtn.Enabled = true;
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

                RefreshInformation();
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
        }

        // List Box Stuff
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this person from interested customers list: " + interestedCustomersListBox.SelectedItem + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        public void RefreshInformation()
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

            // Add vehicles to listbox
            interestedCustomersListBox.Items.Clear();

            foreach (var vehicle in vehicleResult.InterestedCustomers)
            {
                if (vehicleResult.InterestedCustomers[0] != "") // This is from add page setting this to ""
                {
                    interestedCustomersListBox.Items.Add(vehicle);
                }
            }

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

            vehicleResult.InterestedCustomers = interestedCustomersListBox.Items.Cast<string>().ToList();
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

            vehicleResult.InterestedCustomers = interestedCustomersListBox.Items.Cast<string>().ToList();
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

        private void ValidationProcess(TextBox field)
        {
            validation validate = new validation();

            List<string> err = new List<string>();

            int counter = 0;

            if (field == null)
            {
                // Means check all relevant fields
                err.AddRange(validate.CheckEngineNum(engineNumLbl.Text.Trim()));
                err.AddRange(validate.CheckChassisNum(chassisNumLbl.Text.Trim()));
                err.AddRange(validate.CheckColour(colourLbl.Text.Trim()));

                err.AddRange(validate.CheckMake(makeLbl.Text.Trim()));
                err.AddRange(validate.CheckModel(modelLbl.Text.Trim()));

                err.AddRange(validate.CheckPrices(valuationLbl.Text.Trim())); 
                err.AddRange(validate.CheckPrices(askingPriceLbl.Text.Trim())); 

                if (err.Count != 0)
                {
                    errorsInForm = err.Count;
                }
                else if (err.Count == 0)
                {
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

                MessageBox.Show(compileErrors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void askingPriceLbl_Leave(object sender, EventArgs e)
        {
            string askingprice = askingPriceLbl.Text.Trim();
            Regex rg = new Regex(@"^[0-9\.]$");

            string newAskingPrice = Regex.Replace(askingprice, @"[^0-9\.]+", String.Empty);
            askingPriceLbl.Text = newAskingPrice;
        }
    }
}
