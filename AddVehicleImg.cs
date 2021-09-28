using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class AddVehicleImg : Form
    {
        public AddVehicleImg()
        {
            InitializeComponent();
        } 

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addImgBtn_Click(object sender, EventArgs e)
        {
            if (locationLbl.Text == "-")
            {
                // open file dialog   
                OpenFileDialog open = new OpenFileDialog();

                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    vehicleImg.Image = new Bitmap(open.FileName);

                    // image file path  
                    locationLbl.Text = open.FileName;
                }
            }
            else
            {
                this.Close();
            }            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            vehicleImg.Image = null;
            locationLbl.Text = "-";
        }
    }
}
