using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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
                }else if (username == obtainedUsername)
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

        }
    }
}
