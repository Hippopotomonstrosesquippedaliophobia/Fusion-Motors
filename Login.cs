using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class Login : Form
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

        public bool showingPassword = false;

        // Update Stuff
        private static string pasteBin = "https://pastebin.com/raw/LiahpQJq";
        private static string version = "0.0";

        public Login()
        {
            InitializeComponent();
            this.Text = "Fusion Motors: Login";
        }



        /*
         *  Form Functions
         */

        //Minimizes form
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Closes form
        private void close_Click(object sender, EventArgs e)
        {
            //Closes application
            System.Windows.Forms.Application.Exit();
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
         *  Button Functions
         */

        private void viewPasswordBtn_Click(object sender, EventArgs e)
        {
            if (!showingPassword) // Was not showing password, now show it
            {
                passwordTxt.UseSystemPasswordChar = false;
                viewPasswordBtn.BackColor = SystemColors.Control;
                showingPassword = true;
            }
            else // Was showing it now hide it
            {
                passwordTxt.UseSystemPasswordChar = true;
                viewPasswordBtn.BackColor = Color.White;
                showingPassword = false;
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            // If user hits enter, run login button function
            if (e.KeyData == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            // If user hits enter, run login button function
            if (e.KeyData == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = Utilities.HashPassword(passwordTxt.Text.Trim());

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            //config.AppSettings.Settings.Add("owner", username);
            //config.AppSettings.Settings.Add("application", password);
            //MessageBox.Show(config.AppSettings.Settings["application"].Value.ToString());

            //config.Save(ConfigurationSaveMode.Minimal);

            string obtainedUsername = config.AppSettings.Settings["owner"].Value.ToString();
            string obtainedHashedPassword = config.AppSettings.Settings["application"].Value.ToString();

            if (username == obtainedUsername && password == obtainedHashedPassword)
            {
                main form = new main();
                form.Show();
                this.Hide();
            }
            else
            {
                if (username != obtainedUsername)
                {
                    MessageBox.Show("Username not found!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (username == obtainedUsername)
                {
                    MessageBox.Show("Incorrect password!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            // Set username focus
            usernameTxt.BackColor = Color.White;
            usernamePanel.BackColor = Color.White;

            // Set password button greyed out
            passwordTxt.BackColor = SystemColors.Control;
            viewPasswordBtn.BackColor = SystemColors.Control;
            passwordPanel.BackColor = SystemColors.Control;
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            //Set Password focus
            passwordTxt.BackColor = Color.White;

            if (!showingPassword)
            {
                viewPasswordBtn.BackColor = Color.White;
            }

            passwordPanel.BackColor = Color.White;

            //Grey out username
            usernameTxt.BackColor = SystemColors.Control;
            usernamePanel.BackColor = SystemColors.Control;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            versionLbl.Text = "v" + version;

            //Check for updates
            GetUpdate();
        }

        // UPDATE STUFF
        void GetUpdate()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //string ver = config.AppSettings.Settings["version"].Value.ToString();
            //string verIteration = config.AppSettings.Settings["versionIteration"].Value.ToString();

            WebClient webClient = new WebClient();

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            try
            {
                var web = webClient.DownloadString(pasteBin);

                string[] link = web.Split("Download: ");
                string downloadLink = "";


                if (link.Length > 1 & link.Length <= 2)
                {
                    downloadLink = link[1];
                }
                else
                {
                    throw new Exception("Download link not found or corrupted");
                }

                if (!web.Contains(version)) // Version is not the same as pastebin version
                {
                    DialogResult dialogResult = MessageBox.Show("A new version of Fusion Motors has been found! \nDo you want to download it?", "Fusion Motors Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        GoToSite(downloadLink);
                    }
                    else // User doesnt wish to update - proceed to launch
                    {
                        return;
                    }
                }
                else // Version is correct - proceeed to launch
                {
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Update Check Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // opens update link
        public void GoToSite(string url)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // Command to execute
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start " + url;

            // Run process
            process.StartInfo = startInfo;
            process.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            //Send user to email app and insert my email here
        }
    }
}
