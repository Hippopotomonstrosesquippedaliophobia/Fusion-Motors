using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class main : Form
    {
        public MongoCRUD db = null;
        HomeControl hc;
        static main _obj;

        // Function running every x seconds 
        public double milliseconds = 2000; //2 seconds - 32 seconds wait in total due to mongo 30 sec timeout
        public double millisecondsNotify = 10000; //10 seconds - 10 seconds to make button shake

        public double elapsedMilliseconds = 0;  
        public double elapsedMilliseconds2 = 0;  

        public System.Timers.Timer clock;
        public bool alertDisconnect = false;

        public string mongoStatusLblTxt = "Mongo: Not Connected";
        public string mongoDBLblTxt = "No Database";

        private int playOnce = 1;


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

        public static main Instance 
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new main();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return UC; }
            set { UC = value; }
        }

        // Access to read settings across application
        private Settings settings = new Settings();

        // Call back peeps 
        List<CustomerModel> callBackList = new List<CustomerModel>(); 

        public main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _obj = this;
            hc = new HomeControl();
            clock = new System.Timers.Timer();

            //// Disables horizontal scroll on side panel  
            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;

            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = false;
            panel1.AutoScroll = true;

            // Start the clock
            InitializeClock();

            //Display version information
            SetVersion();

            // Initialize Starting page
            GoToHomepage();

            // Set up search Control for reference across main
            //sc = searchResultsControl1;
        }

        private void SetVersion()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string version = config.AppSettings.Settings["version"].Value.ToString();
            string versionIteration = config.AppSettings.Settings["versionIteration"].Value.ToString();

            versionLbl.Text = "v" + version + "." + versionIteration;
        }

        // Sets up the clock
        private void InitializeClock()
        {
            // Set up clock and get it ticking
            clock.Interval = 1000;
            clock.Elapsed += Timer_Elapsed;
            clock.Start();
        }

        // Keeps count as clock runs
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                hc.SetHomeClockTxt(DateTime.Now.ToString("hh:mm:ss tt"));
                elapsedMilliseconds += clock.Interval;
                elapsedMilliseconds2 += clock.Interval;

                if (elapsedMilliseconds >= milliseconds)
                {
                    elapsedMilliseconds = 0; //Reset checker varaiable
                    IsOnlineAsync();
                }

                if (elapsedMilliseconds2 >= millisecondsNotify)
                {
                    var originalLocation = notificationBtn.Location;
                    var rnd = new Random(1337);
                    const int shake_amplitude = 3;

                    if (contextMenuStrip.Items.Count != 0)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            notificationBtn.Location = new Point(originalLocation.X + rnd.Next(-shake_amplitude, shake_amplitude), originalLocation.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                            System.Threading.Thread.Sleep(5);
                            notificationBtn.Location = originalLocation;
                        }
                    }
                    

                    elapsedMilliseconds2 = 0; //Reset checker varaiable 
                }
            }));
        }

        private async void main_Load(object sender, EventArgs e)
        {
            // Try to Start Mongo Database
            try
            {
                RunCmd(Settings.commands["makeDirDB"], settings.commandsInfo["makeDirDB"]);
                StartMongod();
                await Task.Run(() => MongoConnect());
            }
            catch (Exception err)
            {
                mongoStatusLbl.Text = mongoStatusLblTxt;
                mongoDBLbl.Text = mongoDBLblTxt;  
                Message(err.Message, "Mongo Connection Warning", 2);
            }
        }

        // Used to execute hidden command prompt controls
        public void RunCmd(string command, string info)
        {
            bool commandSecurityBypass = false;

            // If command is part of commands dictionary, it is allowed to bypass dialog box confirmation of command running 
            // Command is safe
            foreach (KeyValuePair<string, string> entry in Settings.commands)
            {
                if (command == entry.Value)
                    commandSecurityBypass = true;
            }

            // Prompt user if command is okay to run
            if (!commandSecurityBypass)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to run the command [" + command + "]? \n\nCommand Information:\n" + info, "Security Notice:", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();

                    // Configuring to hide Command prompt
                    //startInfo.RedirectStandardError = true;
                    //startInfo.RedirectStandardOutput = true;
                    //startInfo.WorkingDirectory = directory;
                    startInfo.CreateNoWindow = true;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // Command to execute
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C " + command;

                    // Run process
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Action aborted", "Command Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Command can run without prompt
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                // Configuring to hide Command prompt
                //startInfo.RedirectStandardError = true;
                //startInfo.RedirectStandardOutput = true;
                //startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                // Command to execute
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C " + command;

                // Run process
                process.StartInfo = startInfo;
                process.Start();
            } 
        }

        private void RunCmd(string command, string info, string directory)
        {
            bool commandSecurityBypass = false;

            // If command is part of commands dictionary, it is allowed to bypass dialog box confirmation of command running 
            // Command is safe
            foreach (KeyValuePair<string, string> entry in Settings.commands)
            {
                if (command == entry.Value)
                    commandSecurityBypass = true;
            }

            // Prompt user if command is okay to run
            if (!commandSecurityBypass)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to run the command [" + command + "]? \n\nCommand Information:\n" + info, "Security Notice:", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();

                    // Configuring to hide Command prompt
                    //startInfo.RedirectStandardError = true;
                    //startInfo.RedirectStandardOutput = true;
                    //startInfo.UseShellExecute = false;
                    startInfo.WorkingDirectory = directory;
                    startInfo.CreateNoWindow = true;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    // Command to execute
                    startInfo.UseShellExecute = true;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Verb = "runas";
                    startInfo.Arguments = "/C " + command;

                    // Run process
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Do nothing?
                }
            }
            // Command can run without prompt
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                // Configuring to hide Command prompt
                //startInfo.RedirectStandardError = true;
                //startInfo.RedirectStandardOutput = true;
                //startInfo.UseShellExecute = false;
                startInfo.WorkingDirectory = directory;
                startInfo.CreateNoWindow = true;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                // Command to execute
                startInfo.UseShellExecute = true;
                startInfo.FileName = "cmd.exe";
                startInfo.Verb = "runas";
                startInfo.Arguments = "/C " + command;

                // Run process
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        // Sends user to homepage
        public void GoToHomepage()
        {
            Title.Text = "Homepage";
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            //Open Search Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("Home"))
            {
                hc = new HomeControl();
                hc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(hc);
            }

            main.Instance.PanelContainer.Controls["HomeControl"].BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            GoToHomepage(); 
            LoadCustomersToCall();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "Search Database";
            sidePanel.Height = searchBtn.Height;
            sidePanel.Top = searchBtn.Top;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            //Open Search Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("SearchHomeControl"))
            {
                SearchHomeControl uc = new SearchHomeControl();
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["SearchHomeControl"].BringToFront();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "Add to Database";
            sidePanel.Height = AddBtn.Height;
            sidePanel.Top = AddBtn.Top;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear(); 

            //Open Add Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("addHome"))
            {
                addHome uc = new addHome(); 
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }
            main.Instance.PanelContainer.Controls["addHome"].BringToFront();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "Settings";
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            //Open Add Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("SettingsPage"))
            {
                SettingsPage uc = new SettingsPage();
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }
            main.Instance.PanelContainer.Controls["SettingsPage"].BringToFront();
        }


        private void DatabaseBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "View Database";
            sidePanel.Height = DatabaseBtn.Height;
            sidePanel.Top = DatabaseBtn.Top;             

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            //Open Add Home
            if (!main.Instance.PanelContainer.Controls.ContainsKey("DatabaseHome"))
            {
                DatabaseHome uc = new DatabaseHome();
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["DatabaseHome"].BringToFront();
        }

        /* =============================================
         *  MONGO CONTROLS
         * =============================================
         */

        // Get mongo path
        public string GetPath()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // Key exists so continue
            string path = ConfigurationManager.AppSettings["mongoPath"];

            if (!String.IsNullOrEmpty(path))
            {
                path = 0 + config.AppSettings.Settings["mongoPath"].Value.ToString();
            }
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        path = fbd.SelectedPath;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        //Closes application - Cannot run without path
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }

            //if (path is null || path == "")
            //{
            //    // MAKE USER ENTER PATH
            //    using (var fbd = new FolderBrowserDialog())
            //    {
            //        // tries to set selected Path to a default, if not..proceed as normal
            //        try 
            //        { 
            //            fbd.SelectedPath = @"C:\Program Files\MongoDB\Server\4.4\bin";
            //        }
            //        catch
            //        {

            //        }

            //        DialogResult result = fbd.ShowDialog();

            //        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            //        {
            //            path = fbd.SelectedPath;
            //        }
            //        else if (result == DialogResult.Cancel)
            //        {
            //            //Closes application - Cannot run without path
            //            System.Windows.Forms.Application.Exit();
            //        }
            //    }
            //}
            //else
            //{
            //    path = 0 + path;
            //}

            return path;
        }
        //
        public void SetMongoPath()
        {
            string path = GetPath();

            if (path[0] == '0')
            {
                path = path.Substring(1);
                Settings.mongoBinPath = path; // Set the path
                settings.SetPath(Settings.mongoBinPath, 0);
            }
            else
            {
                Settings.mongoBinPath = path; // Set the path
                settings.SetPath(Settings.mongoBinPath, 1);
            }
        }

        // Starts Mongo via command prompt
        private void StartMongod()
        { 
            RunCmd(Settings.commands["mongoServiceStart"], settings.commandsInfo["mongoServiceStart"], Settings.mongoBinPath);
        }

        // Closes Mongo via command prompt
        private void StopMongod()
        {
            //Chose to keep mongo running in background to avoid forceful shutdown causing dataloss
            RunCmd(Settings.commands["mongoServiceEnd"], settings.commandsInfo["mongoServiceEnd"]);

        }

        private async Task IsOnlineAsync()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string database = config.AppSettings.Settings["database"].Value.ToString();

            if (db != null)
            { 
                await Task.Run(() => db.GetConnection()); 
                mongoStatusLbl.Text = mongoStatusLblTxt;
                mongoDBLbl.Text = mongoDBLblTxt;
            }
        }

        private void MongoConnect()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string database = config.AppSettings.Settings["database"].Value.ToString();

            db = new MongoCRUD(database);

            //If program has reached here, update connection label
            IsOnlineAsync();


            LoadCustomersToCall();

            //ADD CUSTOMER RECORD
            //CustomerModel customer = new CustomerModel
            //{
            //    FirstName = "Petra",
            //    LastName = "Testerino",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "New Hill",
            //        Parish = "St.TEST",
            //        Country = "Barbados"
            //    },
            //    ContactNums = new ContactModel
            //    {
            //        ContactNum1 = 12464235323, //must be like this so database makes it into a long
            //        ContactNum2 = 12464235323,
            //    },
            //    Emails = new EmailModel
            //    {
            //        Email1 = "tester@hotmail.com",
            //        Email2 = "TEST@gmail.com",
            //    },
            //    //InterestedVehicles = {"", ""},
            //    InProgressFlag = false,
            //    CallBackFlag = true
            //};

            //db.InsertRecord("Customers", customer); 

            //ADD VEHICLE RECORD
            //VehicleModel vehicle = new VehicleModel
            //{
            //    EngineNum = "HR12-111111B",
            //    ChassisNum = "ZC72S-338292",
            //    Colour = "Black"
            //    InterestedCustomers = { "", "" }
            //};

            //db.InsertRecord("Vehicles", vehicle);

            // READ ALL
            //var recs = db.LoadRecords<CustomerModel>("Customers");

            //foreach(var rec in recs)
            //{
            //   Title.Text = ($"{rec.Id}: {rec.FirstName} {rec.LastName}");

            //    if (rec.InterestedVehicles != null)
            //    {
            //        Title.Text = ($"{rec.InterestedVehicles}");
            //    }
            //}


            // Search for a name
            //var oneRec = db.LoadCustomerById<CustomerModel>("Customers", "Debronni", "Ifill"); 
        }


        /* =============================================
         *  Form state controls
         * =============================================
         */
        /*
         * if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
            {
                Customer uc = new Customer();
                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["Customer"].BringToFront(); 
         */

        //Closes application
        private void close_Click(object sender, EventArgs e)
        {
            //Closes application
            System.Windows.Forms.Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } 

        //Occurs when form is closed
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Try to Stop Mongo Database
            try
            {
                StopMongod();
            }
            catch (Exception err)
            {
                Message(err.Message, "Mongo Shutdown Error", 3);
            }
        }

        private async void mongoReconnect_Click(object sender, EventArgs e)
        {
            elapsedMilliseconds = 0; // Reset this just in case

            try
            {
                StartMongod();
                await Task.Run(() => MongoConnect());
            }
            catch (Exception err)
            {
                mongoStatusLbl.Text = "Mongo: Not Connected";
                mongoDBLbl.Text = "No Database"; 
                Message(err.Message, "Mongo Connection Error", 3);
            }

            alertDisconnect = false; // Reset Error
        }

        private void main_Shown(object sender, EventArgs e)
        {
            SetMongoPath();
        }

        private async void LoadCustomersToCall()
        {
            if (db != null)
                callBackList = await Task.Run(() => main.Instance.db.LoadCustomersToCallback<CustomerModel>("Customers"));

            if (callBackList.Count > 0)
            {
                int i = 0;

                main.Instance.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread 
                    contextMenuStrip.DropShadowEnabled = true;
                    contextMenuStrip.Items.Clear();

                    //Play sound to alert of callback
                    if (playOnce > 0)
                    {
                        SoundPlayer splayer = new SoundPlayer(@"sound\notification_bell_sound.wav");
                        splayer.Play();
                        playOnce--;
                    }

                    // Change icon for notification bell
                    notificationBtn.Image = Properties.Resources.notification_bell_alert;


                    foreach (var cus in callBackList)
                    { 
                        contextMenuStrip.Items.Add(callBackList[i].FirstName + " " + callBackList[i].LastName);
                        i++;
                    }
                });
            }else if (callBackList.Count == 0)
            {
                // Clear list and change notification icon to reflect change
                contextMenuStrip.Items.Clear();
                notificationBtn.Image = Properties.Resources.notification_bell;

                //Reset notification sound play
                playOnce = 1;
            }
        }

        public void Message(string msg, string title, int type)
        {
            if (type == 1)
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (type ==2)
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (type == 3)
            {
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //Closes application
            System.Windows.Forms.Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private async void notificationBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(notificationBtn, -contextMenuStrip.Width + notificationBtn.Width, notificationBtn.Height);
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int index = contextMenuStrip.Items.IndexOf(e.ClickedItem);

            //Refresh of controls
            main.Instance.PanelContainer.Controls.Clear();

            if (!main.Instance.PanelContainer.Controls.ContainsKey("Customer"))
            {
                Customer uc = new Customer();
                //Send data of Customer form 
                uc.customerResult = callBackList[index];

                //Refresh form
                uc.RefreshInformation();

                uc.Dock = DockStyle.Fill;
                main.Instance.PanelContainer.Controls.Add(uc);
            }

            main.Instance.PanelContainer.Controls["Customer"].BringToFront();
        }     
    }
}
