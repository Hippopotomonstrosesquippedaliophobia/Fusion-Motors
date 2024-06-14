using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Database_Application_Chris
{
    public partial class Customer : UserControl
    {
        Firestore conn; // global reference to firestore database
        public String reference; //global document reference for firebase document search

        public CustomerFrame customerResult;
        public string name = "";
        public bool nameEdited = false; 
        public bool addCustomer = false; 
        public int errorsInForm = 0;

        List<string> allErrors = new List<string>();
        List<string> RemovedInterestedVehicles = new List<string>();
        public BindingList<VehicleModel> vehicles = new BindingList<VehicleModel>();

        public Customer()
        {
            InitializeComponent();

            EnableInterests();

            addThisCustomer.Visible = false;
            addThisCustomer.Enabled = false;

            deleteCustomerBtn.Visible = true;
            deleteCustomerBtn.Enabled = true;

            updateCustomerBtn.Visible = true;
            updateCustomerBtn.Enabled = true;
        }
        
        public Customer(bool addCustomer)
        {
            InitializeComponent();

            // Switched to add mode
            if (addCustomer)
            {
                customerResult = new CustomerFrame();

                DisableInterests();

                addThisCustomer.Visible = true;
                addThisCustomer.Enabled = true;

                deleteCustomerBtn.Visible = false;
                deleteCustomerBtn.Enabled = false;
                
                updateCustomerBtn.Visible = false;
                updateCustomerBtn.Enabled = false; 
            }
            else
            {
                EnableInterests();
                addThisCustomer.Visible = false;
                addThisCustomer.Enabled = false;

                deleteCustomerBtn.Visible = true;
                deleteCustomerBtn.Enabled = true;

                updateCustomerBtn.Visible = true;
                updateCustomerBtn.Enabled = true;
            }
        }

        private void DisableInterests()
        {
            addVehicleBtn.Enabled = false;
            removeVehicleBtn.Enabled = false;

            addVehicleBtn.Visible = false;
            removeVehicleBtn.Visible = false;
        }
        
        private void EnableInterests()
        {
            addVehicleBtn.Enabled = true;
            removeVehicleBtn.Enabled = true;

            addVehicleBtn.Visible = true;
            removeVehicleBtn.Visible = true;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            //RefreshInformation();

            //Load firestore
            conn = new Firestore();
        }

        /*
         * Data Update Functions
         */

        public async void RefreshInformation()
        {
            conn = new Firestore(); //reconnect to firestore db
            UpdateCustomerList(); //update values and refresh info

        }

        async void UpdateCustomerList()
        {
            DocumentReference docref = conn.db.Collection("Customers").Document(reference);

            DocumentSnapshot snap = await docref.GetSnapshotAsync();

            if (snap.Exists)
            {
                CustomerFrame cust = snap.ConvertTo<CustomerFrame>();

                EnableInterests();
                addThisCustomer.Visible = false;
                addThisCustomer.Enabled = false;

                deleteCustomerBtn.Visible = true;
                deleteCustomerBtn.Enabled = true;

                updateCustomerBtn.Visible = true;
                updateCustomerBtn.Enabled = true;

                //Update all fields
                nameLbl.Text = cust.FirstName + " " + cust.LastName;
                addressLbl.Text = cust.Address;
                num1Lbl.Text = cust.ContactNum1;
                num2Lbl.Text = cust.ContactNum2;
                email1Lbl.Text = cust.Emails[0];
                email2Lbl.Text = cust.Emails[1];
                additionalCommentsLbl.Text = cust.Notes;
                inProgressCheckbox.Checked = cust.InProgressFlag;
                callBackCheckbox.Checked = cust.CallBackFlag;

            }
            else
            {
                MessageBox.Show("Customer not found!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListToSend()
        {
             
        }

        /*
         * Button Functions
         */

        private async void deleteCustomerBtn_Click(object sender, EventArgs e)
        { 
            DialogResult dialogResult2 = MessageBox.Show("Are you sure you wish to delete this customer?", "Customer Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult2 == DialogResult.Yes)
            {
                //Try to update
                try
                { 
                    //removing customer on firebase
                    DocumentReference doc = conn.db.Collection("Customers").Document(reference);
                    await doc.DeleteAsync();

                    //Refresh all fields back to empty
                    //reference = "";
                    //nameLbl.Text = "";
                    //addressLbl.Text = "";
                    //num1Lbl.Text = "";
                    //num2Lbl.Text = "";
                    //email1Lbl.Text = "";
                    //email2Lbl.Text = "";
                    //additionalCommentsLbl.Text = "";

                    //Send back Home
                    main.Instance.GoToHomepage();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Delete Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult2 == DialogResult.No)
            {
                return;
            }

            //RefreshInformation();  
        }

        private async void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            bool confirmedName = false;

            ValidationProcess(null); // Check all fields

            if (errorsInForm == 0)
            {
                //if (nameEdited)
                //{
                //    DialogResult dialogResult = MessageBox.Show("You are editing the user's name, is this correct?", "Customer Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //    if (dialogResult == DialogResult.Yes)
                //    {
                //        //Do something
                //        confirmedName = true;
                //    }
                //    else if (dialogResult == DialogResult.No)
                //    {
                //        return;
                //    }
                //} 

                DialogResult dialogResult2 = MessageBox.Show("Are you sure you wish to update this customer?", "Customer Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        string[] name = nameLbl.Text.Split(' ');
                        string[] emails = { email1Lbl.Text, email2Lbl.Text };

                        Dictionary<string, object> dict = new Dictionary<string, object>()
                        {
                            {"FirstName", name[0]  },
                            {"LastName",name[1]  },
                            {"Address", addressLbl.Text },
                            {"ContactNum1", num1Lbl.Text },
                            {"ContactNum2", num2Lbl.Text },
                            {"InProgressFlag", inProgressCheckbox.Checked },
                            {"CallBackFlag", callBackCheckbox.Checked },
                            {"Notes", additionalCommentsLbl.Text.ToString()}
                        };

                        ArrayList array = new ArrayList();
                        array.Add(email1Lbl.Text);
                        array.Add(email2Lbl.Text);
                        dict.Add("Emails", array);
                         
                        //Updating customer on firebase
                        DocumentReference doc = conn.db.Collection("Customers").Document(reference);
                        await doc.UpdateAsync(dict);

                        reference = doc.Id; 
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Update Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    return;
                }

                //RefreshInformation(); 
            }
            else
            {
                MessageBox.Show("There are " + errorsInForm + " errors in the form. \nPlease fix them to continue", "Update Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private async void addThisCustomer_Click(object sender, EventArgs e)
        {
            ////activate the form to cause validation to go off
            nameLbl.Select();
            addressLbl.Select();

            ////Ensure all errors cleared
            //if (allErrors.Count > 0)
            //{ 
            //    MessageBox.Show("Please clear all errors to add customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}else
            //{
            //    //Customer can be added now
            //    AddCustomerFirebase(); 
            //}

            ValidationProcess(null); // Check all fields

            if (errorsInForm == 0)
            {
                DialogResult dialogResult3 = MessageBox.Show("Are you sure you wish to add this Customer?", "Add Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult3 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        AddCustomerFirebase();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Add Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult3 == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please clear all errors to add customer!", "Add Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void AddCustomerFirebase()
        {
            string[] name = nameLbl.Text.Split(' ');
            string[] emails = { email1Lbl.Text, email2Lbl.Text };

            Dictionary<string, object> dict = new Dictionary<string, object>()
            { 
                {"FirstName", name[0]  },
                {"LastName",name[1]  },
                {"Address", addressLbl.Text },
                {"ContactNum1", num1Lbl.Text },
                {"ContactNum2", num2Lbl.Text }, 
                {"InProgressFlag", inProgressCheckbox.Checked },
                {"CallBackFlag", callBackCheckbox.Checked },
                {"Notes", additionalCommentsLbl.Text.ToString()}
            };

            ArrayList array = new ArrayList();
            array.Add(email1Lbl.Text);
            array.Add(email2Lbl.Text); 
            dict.Add("Emails", array);

            try
            {

                //Adding customer to firebase
                DocumentReference doc = await conn.db.Collection("Customers").AddAsync(dict);
                //cll.AddAsync(customerResult); 

                reference = doc.Id; 
            }catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
             

            //Enable the buttons to change to update mode and not add mode
            EnableInterests();
            addThisCustomer.Visible = false;
            addThisCustomer.Enabled = false;

            deleteCustomerBtn.Visible = true;
            deleteCustomerBtn.Enabled = true;

            updateCustomerBtn.Visible = true;
            updateCustomerBtn.Enabled = true;
        }

        /*
         * Field Functions
         */

        private void nameLbl_Leave(object sender, EventArgs e)
        {
            int counter = 0;
            if (name.Length == nameLbl.Text.Length)
            {
                foreach (var letter in name)
                {
                    if (letter != nameLbl.Text[counter])
                    { 
                        nameEdited = true;
                        return;
                    }
                    counter++;
                }
            }
            else
            {
                nameEdited = true;
            }

            ValidationProcess(nameLbl);
        }

        private void addressLbl_Leave(object sender, EventArgs e)
        { 
            ValidationProcess(addressLbl); 
        }

        private void num1Lbl_Leave(object sender, EventArgs e)
        {
            ValidationProcess(num1Lbl);

            if (num1Lbl.Text.Trim().Length != 0)
            {
                FormatNum(num1Lbl);
            }
        }
         
        private void num2Lbl_Leave(object sender, EventArgs e)
        {
            if (num2Lbl.Text.Trim().Length != 0)
            {
                ValidationProcess(num2Lbl);
                FormatNum(num2Lbl);
            }else
            {
                label3.ForeColor = Color.Black;
                num2Lbl.ForeColor = Color.Black;
            }
        }

        private void email1Lbl_Leave(object sender, EventArgs e)
        { 
            ValidationProcess(email1Lbl); 
        }

        private void email2Lbl_Leave(object sender, EventArgs e)
        {
            if (email2Lbl.Text.Trim().Length != 0)
            {
                ValidationProcess(email2Lbl);
            }
            else
            {
                label5.ForeColor = Color.Black;
                email2Lbl.ForeColor = Color.Black;
            }
        }

        private void interestedVehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void callBackCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void inProgressCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (inProgressCheckbox.Checked == true)
            {
                callBackCheckbox.Enabled = true;
            }
            else if (inProgressCheckbox.Checked == false)
            {
                callBackCheckbox.Checked = false;
                callBackCheckbox.Enabled = false;
            }

            EnableUpdateBtn() ;
        }

        /*
         *  Aesthetic Functions
         */

        private void FormatNum(TextBox field)
        {
            //Once number is validated to be of correct length - Format it in the field
            string extractedNum = "";
            string reconstructedNum = "";
            string number = field.Text.Trim();

            long extractedNumInt = ConvertTelToInt(number);
            extractedNum = extractedNumInt.ToString();

            BeautifulPhoneText(extractedNum, field);
        }

        private long ConvertTelToInt(string number)
        {
            string extractedNum = "";
            long returnVal = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (Char.IsDigit(number[i]))
                {
                    extractedNum += number[i];
                }
            }
            try
            {

                returnVal = Int64.Parse(extractedNum);
            }
            catch (Exception err)
            {
                //MessageBox.Show("Error converting telephone number to integer! \n" + err, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error converting telephone number to integer!", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return returnVal;
        }

        private void BeautifulPhoneText(string extractedNum, TextBox field)
        {
            string reconstructedNum = "";

            if (extractedNum.Length == 7)
            {
                // No Area Code
                reconstructedNum = extractedNum.Insert(3, "-");
                reconstructedNum = "+ 1 (246) " + reconstructedNum;

                field.Text = reconstructedNum;
            }
            else if (extractedNum.Length == 10)
            {
                // No 1 in front area code
                reconstructedNum = extractedNum.Insert(0, "(");
                reconstructedNum = reconstructedNum.Insert(4, ")");
                reconstructedNum = reconstructedNum.Insert(5, " ");
                reconstructedNum = reconstructedNum.Insert(9, "-");
                reconstructedNum = "+ 1 " + reconstructedNum;

                num1Lbl.Text = reconstructedNum;
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

                field.Text = reconstructedNum;
            }
        }

        /*
         *  Assisting Functions
         */

        private void EnableUpdateBtn()
        {
            updateCustomerBtn.Enabled = true;
            updateCustomerBtn.Visible = true;
        }

        private void DisableUpdateBtn()
        {
            updateCustomerBtn.Enabled = false;
            updateCustomerBtn.Visible = false;
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

                // Means check all
                err.AddRange(validate.CheckName(nameLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(nameLbl, checker);
                    lastCheck = checker;
                }

                err.AddRange(validate.CheckAddress(addressLbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(addressLbl, checker);
                    lastCheck = checker;
                }
                err.AddRange(validate.CheckNum(num1Lbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(num1Lbl, checker);
                    lastCheck = checker;
                }

                //If empty allow it, as not all customers have both
                if (num2Lbl.Text.Trim().Length != 0)
                {
                    err.AddRange(validate.CheckNum(num2Lbl.Text.Trim()));
                    checker = err.Count;
                    if (checker != lastCheck)
                    {
                        ChangeFieldColourValidate(num2Lbl, checker);
                        lastCheck = checker;
                    }
                }

                err.AddRange(validate.CheckEmail(email1Lbl.Text.Trim()));
                checker = err.Count;
                if (checker != lastCheck)
                {
                    ChangeFieldColourValidate(email1Lbl, checker);
                    lastCheck = checker;
                }

                //If empty allow it, as not all customers have both
                if (email2Lbl.Text.Trim().Length != 0)
                {
                    err.AddRange(validate.CheckEmail(email2Lbl.Text.Trim()));
                    checker = err.Count;
                    if (checker != lastCheck)
                    {
                        ChangeFieldColourValidate(email2Lbl, checker);
                        lastCheck = checker;
                    }
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
                case "nameLbl":
                    err = validate.CheckName(nameLbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err); 
                    break;
                case "addressLbl":
                    err = validate.CheckAddress(addressLbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err);
                    break;
                case "num1Lbl":
                    err = validate.CheckNum(num1Lbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err);
                    break;
                case "num2Lbl": 
                    err = validate.CheckNum(num2Lbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err);
                    break;
                case "email1Lbl":
                    err = validate.CheckEmail(email1Lbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err);
                    break;
                case "email2Lbl":
                    err = validate.CheckEmail(email2Lbl.Text.Trim());
                    counter += err.Count;
                    OutputErrors(field, err);
                    break;
                default:
                    err.Add("Cannot resolve validation query - Error occurred");
                    counter += err.Count;
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
                //CompileErrors(err);
                //MessageBox.Show(compileErrors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompileErrors(List<string> err)
        {
            int i = 0;

            if (allErrors.Count != 0)
            {
                allErrors.Add("---");
            }

            foreach (var error in err)
            {
                allErrors.Add(err[i]);
                i++;
            }
        }

        private void Customer_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void addVehicleInterest_Click(object sender, EventArgs e)
        {
            UpdateListToSend();
            //SearchForm search = new SearchForm(true, true, customerResult);
            //search.sentFromAddPage = addCustomer;
            //search.Text = "Fusion Motors: Select a Vehicle";
            //search.titleLbl.Text = "Select a vehicle to add to list";
            //search.Show();

            //if (addVehicle.Text.Length != 0)
            //{
            //    // Add vehicles to listbox 
            //    interestedVehiclesListBox.Items.Add(addVehicle.Text);
            //    addVehicle.Text = ""; // Clear field
            //    //EnableUpdateBtn();
            //}
        }

        private void removeVehicle_Click(object sender, EventArgs e)
        {
            //// Get List of removed vehicles for update reasons
            //int selectedIndex = interestedVehiclesListBox.SelectedIndex;

            //if (interestedVehiclesListBox.Items.Count != 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this vehicle : " + vehicles[selectedIndex].EngineNum + " from the customers interested list?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {

            //        RemovedInterestedVehicles.Add(vehicles[selectedIndex].EngineNum);

            //        vehicles.RemoveAt(selectedIndex); 
            //        interestedVehiclesListBox.DataSource = vehicles;
            //        UpdateCustomerList();
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        return;
            //    }

            //}
        }


        /*
         * Aesthetic error warnings
         */
        private void addressLbl_ForeColorChanged(object sender, EventArgs e)
        {
            label1.ForeColor = addressLbl.ForeColor;
        }

        private void num1Lbl_ForeColorChanged(object sender, EventArgs e)
        {
            label2.ForeColor = num1Lbl.ForeColor;
        }

        private void num2Lbl_ForeColorChanged(object sender, EventArgs e)
        {
            label3.ForeColor = num2Lbl.ForeColor;
        }

        private void email1Lbl_ForeColorChanged(object sender, EventArgs e)
        {
            label4.ForeColor = email1Lbl.ForeColor;
        }

        private void email2Lbl_ForeColorChanged(object sender, EventArgs e)
        {
            label5.ForeColor = email2Lbl.ForeColor;
        }

        private void interestedVehiclesListBox_DoubleClick(object sender, EventArgs e)
        { 
            int selectedIndex = interestedVehiclesListBox.SelectedIndex;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            if (!main.Instance.PanelContainer.Controls.ContainsKey("Vehicle"))
            {
                Vehicle uc = new Vehicle();
                //Send data of Customer form 
                uc.reference = interestedVehiclesListBox.Tag.ToString();
                //Refresh form
                uc.RefreshInformation();

                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["Vehicle"].BringToFront();
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
                }else
                {
                    errs += "\n" + allErrors[i];
                }
                i++;
            }

            if (allErrors.Count != 0)
            {
                MessageBox.Show(errs, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("All errors cleared!", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
