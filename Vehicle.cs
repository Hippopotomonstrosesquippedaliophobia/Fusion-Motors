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
    public partial class Vehicle : UserControl
    {
        public VehicleModel vehicleResult;
        public bool engineNumEdited = false;
        public bool addVehicle = false;

        public Vehicle()
        {
            InitializeComponent();
            SetTabIndex();
            addThisVehicle.Visible = false;
            addThisVehicle.Enabled = false;

            deleteCustomerBtn.Visible = true;
            deleteCustomerBtn.Enabled = true;
        }
        
        public Vehicle(bool addVehicle)
        {
            InitializeComponent();
            SetTabIndex();

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
            }
        }

        /*
         * Button Functions
         */

        public void SetTabIndex()
        {
            int index = 0;
            panel1.TabIndex = ++index;
            engineNumLbl.TabIndex = ++index;
            chassisNumLbl.TabIndex = ++index;
            colourLbl.TabIndex = ++index;
            addCustomer.TabIndex = ++index;
            addCustomerBtn.TabIndex = ++index;
            deleteCustomerBtn.TabIndex = ++index;
            addThisVehicle.TabIndex = ++index;
        }

        private async void addThisVehicle_Click(object sender, EventArgs e)
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

        private async void updateVehicleBtn_Click(object sender, EventArgs e)
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
            DisableUpdateBtn();
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
                EnableUpdateBtn();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (addCustomer.Text.Length != 0)
            {
                // Add vehicles to listbox 
                interestedCustomersListBox.Items.Add(addCustomer.Text);
                addCustomer.Text = ""; // Clear field
                EnableUpdateBtn();
            }
        }

        /*
         * Data Update Functions
         */

        public void RefreshInformation()
        {
            engineNumLbl.Text = vehicleResult.EngineNum;
            chassisNumLbl.Text = vehicleResult.ChassisNum;
            colourLbl.Text = vehicleResult.Colour;

            // Add vehicles to listbox
            interestedCustomersListBox.Items.Clear();

            foreach (var vehicle in vehicleResult.InterestedCustomers)
            {
                if (vehicleResult.InterestedCustomers[0] != "") // This is from add page setting this to ""
                {
                    interestedCustomersListBox.Items.Add(vehicle);
                }
            }

            DisableUpdateBtn();
        }

        private void UpdateVehicleList()
        {
            vehicleResult.EngineNum = engineNumLbl.Text.Trim();
            vehicleResult.ChassisNum = chassisNumLbl.Text.Trim();
            vehicleResult.Colour = colourLbl.Text.Trim();
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
                EnableUpdateBtn();
            }
            else if (err.Count > 0)
            {
                field.ForeColor = Color.Red;
                DisableUpdateBtn(); // Only enable updates if all checks are correct

                string compileErrors = "";

                foreach (var item in err)
                {
                    compileErrors += "\n" + item;
                }

                MessageBox.Show(compileErrors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }
}
