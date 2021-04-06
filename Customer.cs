using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class Customer : UserControl
    {
        public CustomerModel customerResult;
        public bool nameEdited = false;

        public Customer()
        {
            InitializeComponent();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete "+customerResult.FirstName+ " " +customerResult.LastName+ "?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Try to delete
                try
                {
                    main.Instance.db.DeleteRecord<CustomerModel>("Customers", customerResult.Id);
                    MessageBox.Show("Successfully deleted " + customerResult.FirstName + " " + customerResult.LastName, "Success");
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

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            if (nameEdited)
            {
                DialogResult dialogResult = MessageBox.Show("You are editing the user's name, is this correct?", "Customer Information Edit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Do something
                    nameEdited = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            //Get info from fields
            UpdateCustomerList();

            //Try to update
            try
            {
                main.Instance.db.UpsertRecord<CustomerModel>("Customers", customerResult.Id, customerResult);
                MessageBox.Show("Successfully updated " + customerResult.FirstName + " " + customerResult.LastName, "Success");
            }catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
            }

            DisableUpdateBtn();
        }

        private void UpdateCustomerList()
        {
            string[] names;
            names = nameLbl.Text.Split(' ');

            customerResult.FirstName = names[0].Trim();
            customerResult.LastName = names[1].Trim();

            string[] address;
            address = addressLbl.Text.Split(',');

            customerResult.PrimaryAddress.StreetAddress = address[0].Trim();
            customerResult.PrimaryAddress.Parish = address[1].Trim();
            customerResult.PrimaryAddress.Country = address[2].Trim();
            customerResult.ContactNums.ContactNum1 = int.Parse(num1Lbl.Text.Trim());
            customerResult.ContactNums.ContactNum2 = int.Parse(num2Lbl.Text.Trim());
            customerResult.Emails.Email1 = email1Lbl.Text.Trim();
            customerResult.Emails.Email2 = email2Lbl.Text.Trim();
            customerResult.InProgressFlag = inProgressCheckbox.Checked;
            customerResult.CallBackFlag = callBackCheckbox.Checked;
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

        private void Customer_Load(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        public void RefreshInformation()
        {
            nameLbl.Text = customerResult.FirstName + " "+ customerResult.LastName;
            addressLbl.Text = customerResult.PrimaryAddress.StreetAddress + ", " 
                            + customerResult.PrimaryAddress.Parish + ", " 
                            + customerResult.PrimaryAddress.Country;
            num1Lbl.Text = customerResult.ContactNums.ContactNum1.ToString();
            num2Lbl.Text = customerResult.ContactNums.ContactNum2.ToString();
            email1Lbl.Text = customerResult.Emails.Email1;
            email2Lbl.Text = customerResult.Emails.Email2;
            inProgressCheckbox.Checked = customerResult.InProgressFlag;
            callBackCheckbox.Checked = customerResult.CallBackFlag;

            nameEdited = false;
            DisableUpdateBtn();
        }

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

        private void nameLbl_TextChanged(object sender, EventArgs e)
        {
            nameEdited = true;
            EnableUpdateBtn();
        }

        private void addressLbl_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void num1Lbl_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void num2Lbl_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void email1Lbl_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void email2Lbl_TextChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void interestedVehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }

        private void callBackCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            EnableUpdateBtn();
        }
    }
}
