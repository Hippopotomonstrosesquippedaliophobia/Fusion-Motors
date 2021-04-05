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

        public Customer()
        {
            InitializeComponent();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {

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

        }
    }
}
