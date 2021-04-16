using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class SettingsPage : UserControl
    {
        public string filePath1, filePath2;

        public SettingsPage()
        {
            InitializeComponent();
            pagePanel.Height = importBtn.Height;
            pagePanel.Top = importBtn.Top;
        }

        private void DatabaseCollections()
        {

            string list = "";
            try
            {
                List<string> listList = main.Instance.db.GetCollections();

                foreach (var item in listList)
                {
                    if (list == "")
                    {
                        list = item;
                    }
                    else
                    {
                        list += " | " + item;
                    }
                }

                listTables.Text = list;
            }
            catch (Exception err)
            {

            }
        }

        private void SelectFile(int which)
        {
            if (which == 1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";

                if (file1TextBox.Text.Trim() != file1Txt.Text)
                {
                    if (File.Exists(file1TextBox.Text.Trim()))
                    {
                        ofd.InitialDirectory = file1TextBox.Text.Trim();
                    }

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExt = Path.GetExtension(ofd.FileName);

                        if (fileExt == ".json")
                        {
                            //Get the path of specified file
                            filePath1 = ofd.FileName;
                            file1Txt.Text = ofd.SafeFileName;
                            file1TextBox.Text = filePath1;
                            toolTip.SetToolTip(this.file1Txt, file1Txt.Text);
                            toolTip.SetToolTip(this.file1TextBox, file1TextBox.Text);
                            EnableClear(1);
                        }
                        else
                        {
                            MessageBox.Show("Invalid file type!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExt = Path.GetExtension(ofd.FileName);

                        if (fileExt == ".json")
                        {
                            //Get the path of specified file
                            filePath1 = ofd.FileName;
                            file1Txt.Text = ofd.SafeFileName;
                            file1TextBox.Text = filePath1;
                            toolTip.SetToolTip(this.file1Txt, file1Txt.Text);
                            toolTip.SetToolTip(this.file1TextBox, file1TextBox.Text);
                            EnableClear(1);
                        }
                        else
                        {
                            MessageBox.Show("Invalid file type!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (which == 2)
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*";

                if (file2TextBox.Text.Trim() != file2Txt.Text)
                {
                    if (File.Exists(file2TextBox.Text.Trim()))
                    {
                        ofd.InitialDirectory = file2TextBox.Text.Trim();
                    }

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExt = Path.GetExtension(ofd.FileName);

                        if (fileExt == ".json")
                        {
                            //Get the path of specified file
                            filePath2 = ofd.FileName;
                            file2Txt.Text = ofd.SafeFileName;
                            file2TextBox.Text = filePath2;
                            toolTip.SetToolTip(this.file2Txt, file2Txt.Text);
                            toolTip.SetToolTip(this.file2TextBox, file2TextBox.Text);
                            EnableClear(2);
                        }
                        else
                        {
                            MessageBox.Show("Invalid file type!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExt = Path.GetExtension(ofd.FileName);

                        if (fileExt == ".json")
                        {
                            //Get the path of specified file
                            filePath2 = ofd.FileName;
                            file2Txt.Text = ofd.SafeFileName;
                            file2TextBox.Text = filePath2;
                            toolTip.SetToolTip(this.file2Txt, file2Txt.Text);
                            toolTip.SetToolTip(this.file2TextBox, file2TextBox.Text);
                            EnableClear(2);
                        }
                        else
                        {
                            MessageBox.Show("Invalid file type!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void EnableClear(int which)
        {
            if (which == 1)
            {
                clear1.Enabled = true;
                clear1.Visible = true;
            }
            else if (which == 2)
            {
                clear2.Enabled = true;
                clear2.Visible = true;
            }
        }

        private void DisableClear(int which)
        {
            if (which == 1)
            {
                clear1.Enabled = false;
                clear1.Visible = false;
            }
            else if (which == 2)
            {
                clear2.Enabled = false;
                clear2.Visible = false;
            }
        }

        private void selectFile1Btn_Click(object sender, EventArgs e)
        {
            SelectFile(1);
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            filePath1 = null;
            file1TextBox.Text = "";
            file1Txt.Text = "No file selected.";
            toolTip.SetToolTip(this.file1Txt, file1Txt.Text);
            DisableClear(1);
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            filePath2 = null;
            file2TextBox.Text = "";
            file2Txt.Text = "No file selected.";
            toolTip.SetToolTip(this.file2Txt, file2Txt.Text);
            DisableClear(2);
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            pagePanel.Height = importBtn.Height;
            pagePanel.Top = importBtn.Top;

            ImportPanel.Enabled = true;
            ImportPanel.Visible = true;

            exportPanel.Enabled = false;
            exportPanel.Visible = false;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            pagePanel.Height = exportBtn.Height;
            pagePanel.Top = exportBtn.Top;

            exportPanel.Enabled = true;
            exportPanel.Visible = true;

            ImportPanel.Enabled = false;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            pagePanel.Height = aboutBtn.Height;
            pagePanel.Top = aboutBtn.Top;
        }

        private void importTablesBtn_Click(object sender, EventArgs e)
        {
            List<string> err = new List<string>();
            List<string> success = new List<string>();
            Settings settings = new Settings();

            if (file1Txt.Text == "Customers.json" || file1Txt.Text == "Vehicles.json")
            {
                try
                {
                    // Import this file as table
                    if (file1Txt.Text == "Customers.json")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite existing table data with this file's data?", "Import Inquiry", MessageBoxButtons.YesNo);
                       
                        if (dialogResult == DialogResult.Yes)
                        {
                            main.Instance.RunCmd(Settings.commands["importMongoCustomers"] + file1TextBox.Text + " --jsonArray", settings.commandsInfo["importMongoCustomers"]);
                        }
                        else
                        {
                            MessageBox.Show("Action aborted for first file", "Command Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } 
                    }
                    if (file1Txt.Text == "Vehicles.json")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite existing table data with this file's data?", "Import Inquiry", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            main.Instance.RunCmd(Settings.commands["importMongoVehicles"] + file1TextBox.Text + " --jsonArray", settings.commandsInfo["importMongoVehicles"]);
                        }
                        else
                        {
                            MessageBox.Show("Action aborted for first file", "Command Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                success.Add("File 1: " + file1Txt.Text + " has been successfully imported");

            } else
            {
                if (file1TextBox.Text.Length == 0)
                {
                    // Do nothing
                }
                else
                {
                    err.Add("First file: Invalid");
                } 
            }

            
            if (file2Txt.Text == "Customers.json" || file2Txt.Text == "Vehicles.json" )
            {
                try
                {
                    // Import this file as table
                    if (file2Txt.Text == "Customers.json")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite existing table data with this file's data?", "Import Inquiry", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            main.Instance.RunCmd(Settings.commands["importMongoCustomers"] + file2TextBox.Text + " --jsonArray", settings.commandsInfo["importMongoCustomers"]);
                        }
                        else
                        {
                            MessageBox.Show("Action aborted for first file", "Command Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (file2Txt.Text == "Vehicles.json")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to overwrite existing table data with this file's data?", "Import Inquiry", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            main.Instance.RunCmd(Settings.commands["importMongoVehicles"] + file2TextBox.Text + " --jsonArray", settings.commandsInfo["importMongoVehicles"]);
                        }
                        else
                        {
                            MessageBox.Show("Action aborted for first file", "Command Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                success.Add("File 2: " + file2Txt.Text + " has been successfully imported");
            }
            else
            {
                if (file2TextBox.Text.Length == 0 )
                {
                    // Do nothing
                }
                else
                {
                    err.Add("Second file: Invalid");
                }
            }

            // Output success
            if (err.Count == 0)
            {
                if (success.Count != 0)
                {
                    string successMessage = "";

                    foreach (var s in success)
                    {
                        successMessage += "\n" + s;
                    }

                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string errorMessage = "";

                foreach (var error in err)
                {
                    errorMessage += "\n" + error;
                }

                string successMessage = "";

                foreach (var s in success)
                {
                    successMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (success.Count > 0)
                {
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Update Current tables list
            DatabaseCollections();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            DatabaseCollections();
        }

        private void selectFile2Btn_Click(object sender, EventArgs e)
        {
            SelectFile(2);
        }
    }
}
