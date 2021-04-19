﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class Customer : UserControl
    {
        public CustomerModel customerResult;
        public string name;
        public bool nameEdited = false; 
        public bool addCustomer = false; 
        public int errorsInForm = 0; 

        public Customer()
        {
            InitializeComponent();

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
                customerResult = new CustomerModel(); 

                addThisCustomer.Visible = true;
                addThisCustomer.Enabled = true;

                deleteCustomerBtn.Visible = false;
                deleteCustomerBtn.Enabled = false;
                
                updateCustomerBtn.Visible = false;
                updateCustomerBtn.Enabled = false;
            }
            else
            {
                addThisCustomer.Visible = false;
                addThisCustomer.Enabled = false;

                deleteCustomerBtn.Visible = true;
                deleteCustomerBtn.Enabled = true;

                updateCustomerBtn.Visible = true;
                updateCustomerBtn.Enabled = true;
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        /*
         * Data Update Functions
         */

        public void RefreshInformation()
        {
            nameLbl.Text = customerResult.FirstName + " "+ customerResult.LastName;
            name = nameLbl.Text;

            if (customerResult.PrimaryAddress.StreetAddress != "")
            {
                addressLbl.Text = customerResult.PrimaryAddress.StreetAddress + ", "
                                + customerResult.PrimaryAddress.Parish + ", "
                                + customerResult.PrimaryAddress.Country;
            }
            else
            {
                addressLbl.Text = customerResult.PrimaryAddress.StreetAddress + " "
                                + customerResult.PrimaryAddress.Parish + " "
                                + customerResult.PrimaryAddress.Country;
            }

            BeautifulPhoneText(customerResult.ContactNums.ContactNum1.ToString(), num1Lbl);
            BeautifulPhoneText(customerResult.ContactNums.ContactNum2.ToString(), num2Lbl);
            email1Lbl.Text = customerResult.Emails.Email1;
            email2Lbl.Text = customerResult.Emails.Email2;

            // Add vehicles to listbox
            interestedVehiclesListBox.Items.Clear();
            
            foreach (var vehicle in customerResult.InterestedVehicles)
            {
                if (customerResult.InterestedVehicles[0] != "") // This is from add page setting this to ""
                {
                    interestedVehiclesListBox.Items.Add(vehicle);
                }
            }

            inProgressCheckbox.Checked = customerResult.InProgressFlag;
            callBackCheckbox.Checked = customerResult.CallBackFlag;
            additionalCommentsLbl.Text = customerResult.Notes;

            nameEdited = false;
            //DisableUpdateBtn();
        }

        private void UpdateCustomerList()
        {
            string[] names;
            names = nameLbl.Text.Trim().Split(' ');

            try
            {
                customerResult.FirstName = names[0].Trim();
                customerResult.LastName = names[1].Trim();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string[] address;
            address = addressLbl.Text.Split(',');

            try
            {
                customerResult.PrimaryAddress.StreetAddress = address[0].Trim();
                customerResult.PrimaryAddress.Parish = address[1].Trim();
                customerResult.PrimaryAddress.Country = address[2].Trim();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Address error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            customerResult.ContactNums.ContactNum1 = ConvertTelToInt(num1Lbl.Text.Trim());
            customerResult.ContactNums.ContactNum2 = ConvertTelToInt(num2Lbl.Text.Trim());
            customerResult.Emails.Email1 = email1Lbl.Text.Trim();
            customerResult.Emails.Email2 = email2Lbl.Text.Trim();
            customerResult.InterestedVehicles = interestedVehiclesListBox.Items.Cast<string>().ToList();
            customerResult.InProgressFlag = inProgressCheckbox.Checked;
            customerResult.CallBackFlag = callBackCheckbox.Checked;
            customerResult.Notes = additionalCommentsLbl.Text;
        }

        private void UpdateListToSend()
        {
            string[] names;
            names = nameLbl.Text.Trim().Split(' ');

            try
            {
                customerResult.FirstName = names[0].Trim();
                customerResult.LastName = names[1].Trim();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string[] address;
            address = addressLbl.Text.Split(',');

            try
            {
                customerResult.PrimaryAddress.StreetAddress = address[0].Trim();
                customerResult.PrimaryAddress.Parish = address[1].Trim();
                customerResult.PrimaryAddress.Country = address[2].Trim();
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Address error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            customerResult.ContactNums.ContactNum1 = ConvertTelToInt(num1Lbl.Text.Trim());
            customerResult.ContactNums.ContactNum2 = ConvertTelToInt(num2Lbl.Text.Trim());
            customerResult.Emails.Email1 = email1Lbl.Text.Trim();
            customerResult.Emails.Email2 = email2Lbl.Text.Trim();
            customerResult.InterestedVehicles = interestedVehiclesListBox.Items.Cast<string>().ToList();
            customerResult.InProgressFlag = inProgressCheckbox.Checked;
            customerResult.CallBackFlag = callBackCheckbox.Checked;
            customerResult.Notes = additionalCommentsLbl.Text;
        }

        /*
         * Button Functions
         */

        private async void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + customerResult.FirstName + " " + customerResult.LastName + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Try to delete
                try
                {
                    await Task.Run(() => main.Instance.db.DeleteRecord<CustomerModel>("Customers", customerResult.Id));
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

        private async void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            bool confirmedName = false;

            ValidationProcess(null); // Check all fields

            if ( errorsInForm == 0)
            { 
                if (nameEdited)
                {
                    DialogResult dialogResult = MessageBox.Show("You are editing the user's name, is this correct?", "Customer Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Do something
                        confirmedName = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                //Get info from fields
                UpdateCustomerList();

                DialogResult dialogResult2 = MessageBox.Show("Are you sure you wish to update this customer?", "Customer Information Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        await Task.Run(() => main.Instance.db.UpsertRecord<CustomerModel>("Customers", customerResult.Id, customerResult));

                        int i = 0;
                        foreach (var iv in customerResult.InterestedVehicles)
                        {                            
                            main.Instance.db.UpdateVehicleInterestedList<VehicleModel>("Vehicles", customerResult.InterestedVehicles[i], customerResult.Id);
                            i++;
                        }
                        //var lol = main.Instance.db.CheckVehicleInterestedList<VehicleModel>("Vehicles", customerResult.Id);
                        //MessageBox.Show(customerResult.Id.ToString() + ": " +lol.ToString());
                        //main.Instance.db.VehiclesListInterest<VehicleModel>("Vehicles", customerResult.Id);
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

                RefreshInformation();
                //DisableUpdateBtn();
            }
            else
            {
                MessageBox.Show("There are " + errorsInForm + " errors in the form. \nPlease fix them to continue", "Update Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addThisCustomer_Click(object sender, EventArgs e)
        {
            ValidationProcess(null); // Check all fields

            if (errorsInForm == 0)
            {
                UpdateCustomerList();


                DialogResult dialogResult3 = MessageBox.Show("Are you sure you wish to add this customer?", "Add Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult3 == DialogResult.Yes)
                {
                    //Try to update
                    try
                    {
                        await Task.Run(() => main.Instance.db.InsertRecord<CustomerModel>("Customers", customerResult));
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

                RefreshInformation();
            }
            else
            {
                MessageBox.Show("There are " + errorsInForm + " errors in the form. \nPlease fix them to continue", "Add Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            FormatNum(num1Lbl);
        }
         
        private void num2Lbl_Leave(object sender, EventArgs e)
        {
            ValidationProcess(num2Lbl);
            FormatNum(num2Lbl);
        }

        private void email1Lbl_Leave(object sender, EventArgs e)
        { 
            ValidationProcess(email1Lbl); 
        }

        private void email2Lbl_Leave(object sender, EventArgs e)
        { 
            ValidationProcess(email2Lbl); 
        }

        private void interestedVehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //EnableUpdateBtn();
        }

        private void callBackCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //EnableUpdateBtn();
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
                MessageBox.Show("Error converting telephone number to integer \n" + err, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ValidationProcess(TextBox field)
        {
            validation validate = new validation();

            List<string> err = new List<string>();

            int counter = 0;

            if (field == null)
            {
                // Means check all
                err.AddRange(validate.CheckName(nameLbl.Text.Trim()));
                err.AddRange(validate.CheckAddress(addressLbl.Text.Trim()));
                err.AddRange(validate.CheckNum(num1Lbl.Text.Trim()));
                err.AddRange(validate.CheckNum(num2Lbl.Text.Trim()));
                err.AddRange(validate.CheckEmail(email1Lbl.Text.Trim()));
                err.AddRange(validate.CheckEmail(email2Lbl.Text.Trim()));
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

        private void Customer_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void addVehicleInterest_Click(object sender, EventArgs e)
        {
            UpdateListToSend();
            SearchForm search = new SearchForm(true, true, customerResult);
            search.sentFromAddPage = addCustomer;
            search.Text = "Fusion Motors: Select a Vehicle";
            search.titleLbl.Text = "Select a vehicle to add to list";
            search.Show();

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
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this vehicle : " + interestedVehiclesListBox.SelectedItem + " from the customers interested list?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                interestedVehiclesListBox.Items.Remove(interestedVehiclesListBox.SelectedItem);
                //EnableUpdateBtn();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
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
    }
}
