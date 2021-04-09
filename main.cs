using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public partial class main : Form
    {
        public MongoCRUD db;
        HomeControl hc;
        static main _obj;
        
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

        public main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _obj = this;
            hc = new HomeControl();

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
            versionLbl.Text = "v" + settings.version.ToString() + "." + settings.versionIteration.ToString();
        }

        // Sets up the clock
        private void InitializeClock()
        {
            // Set up clock and get it ticking
            System.Timers.Timer clock = new System.Timers.Timer();
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
            }));
        }

        private void main_Load(object sender, EventArgs e)
        {
            // Try to Start Mongo Database
            try
            {
                StartMongod();
                MongoConnect();
            }
            catch (Exception err)
            {
                mongoStatusLbl.Text = "Mongo: Not Connected";
                mongoDBLbl.Text = "No Database"; 
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        // Used to execute hidden command prompt controls
        private void RunCmd(string command, string info)
        {
            bool commandSecurityBypass = false;

            // If command is part of commands dictionary, it is allowed to bypass dialog box confirmation of command running 
            // Command is safe
            foreach (KeyValuePair<string, string> entry in settings.commands)
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
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                    // Configuring to hide Command prompt
                    //startInfo.RedirectStandardError = true;
                    //startInfo.RedirectStandardOutput = true;
                    //startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;

                    // Command to execute
                    startInfo.FileName = "cmd.exe";
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
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

                // Configuring to hide Command prompt
                //startInfo.RedirectStandardError = true;
                //startInfo.RedirectStandardOutput = true;
                //startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                // Command to execute
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C " + command;

                // Run process
                process.StartInfo = startInfo;
                process.Start();
            } 
        }

        // Sends user to homepage
        private void GoToHomepage()
        {
            Title.Text = "Homepage";
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;

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
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "Search";
            sidePanel.Height = searchBtn.Height;
            sidePanel.Top = searchBtn.Top;

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
            //Title.Text = "Add";
            //sidePanel.Height = AddBtn.Height;
            //sidePanel.Top = AddBtn.Top;

            ////Open Add Home
            //if (!main.Instance.PanelContainer.Controls.ContainsKey("SearchResultsControl"))
            //{
            //    SearchResultsControl uc = new SearchResultsControl();
            //    uc.Dock = DockStyle.Fill;
            //    main.Instance.PanelContainer.Controls.Add(uc);
            //}

            //main.Instance.PanelContainer.Controls["SearchResultsControl"].BringToFront();
        }

        /* =============================================
         *  MONGO CONTROLS
         * =============================================
         */

        // Starts Mongo via command prompt
        private void StartMongod()
        {
            RunCmd(settings.commands["mongoServiceStart"], settings.commandsInfo["mongoServiceStart"]);
        }

        // Closes Mongo via command prompt
        private void StopMongod()
        {
            RunCmd(settings.commands["mongoServiceEnd"], settings.commandsInfo["mongoServiceEnd"]);
        }

        private void MongoConnect()
        {
            db = new MongoCRUD(settings.database);

            //If program has reached here, update connection label
            if (db.GetConnection() != null)
            {
                mongoStatusLbl.Text = "Mongo: Connected";
                mongoDBLbl.Text = settings.database;
            }
            else if (db.GetConnection() == null)
            {
                mongoStatusLbl.Text = "Mongo: Not Connected";
                mongoDBLbl.Text = "No Database";
            }


            //ADD RECORD
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
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //Closes application
            System.Windows.Forms.Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
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
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        private void mongoReconnect_Click(object sender, EventArgs e)
        {
            try
            {
                StartMongod();
                MongoConnect();
            }
            catch (Exception err)
            {
                mongoStatusLbl.Text = "Mongo: Not Connected";
                mongoDBLbl.Text = "No Database";
                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

    }
}
