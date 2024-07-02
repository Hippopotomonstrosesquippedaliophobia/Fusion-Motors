using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public class Settings
    { 
        public static string mongoBinPath; //@"C:\Program Files\MongoDB\Server\4.4\bin"; // @ stops escape
        public static string storeDBLocation = @"Database"; //@"C:\Program Files\MongoDB\Server\4.4\bin"; // @ stops escape

        public Settings()
        {
            //string path = "";

            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            //// Key exists so continue
            //string s = ConfigurationManager.AppSettings["mongoPath"];

            //if (!String.IsNullOrEmpty(s))
            //{ 
            //    path = config.AppSettings.Settings["mongoPath"].Value.ToString();
            //}
            //else
            //{
            //    if (Directory.Exists(path))
            //    {
            //        mongoBinPath = path;

            //        try
            //        {
            //            SetPath(mongoBinPath, 0);
            //        }
            //        catch (Exception err)
            //        {
            //            MessageBox.Show(err.Message, "");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mongo file location is invalid!\nPlease select the location of your mongoDB installation", "Mongo File Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //} 
        }

        //public void SetPath(string path, int type)
        //{ 
        //    Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        //    // Key exists so continue
        //    string patherino = ConfigurationManager.AppSettings["mongoPath"];

        //    if (!String.IsNullOrEmpty(patherino))
        //    {
        //        if (Directory.Exists(path))
        //        {

        //        }
        //    }else
        //    {
        //        config.AppSettings.Settings.Add("mongoPath", path);
        //        config.Save(ConfigurationSaveMode.Minimal);
        //    }
                         

        //    if (type == 1)
        //    {
        //        MessageBox.Show("Mongo Path set to: " + path, "Mongo File Path Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //} 

        public static readonly IDictionary<string, string> commands = new Dictionary<string, string>()
        { 
            {"mongoServiceStart", "mongod.exe --dbpath \"" + AppDomain.CurrentDomain.BaseDirectory + @"\Database" + "\""},
            {"mongoServiceEnd", "taskkill /F /IM mongod.exe"},
            {"makeDirDB", @"mkdir Database"},
            {"importMongoCustomers", "mongoimport --upsert --db FusionMotors --collection Customers --drop --file \""},
            {"importMongoVehicles", "mongoimport --upsert --db FusionMotors --collection Vehicles --drop --file \""}
        };

        public readonly IDictionary<string, string> commandsInfo = new Dictionary<string, string>()
        { 
            {"mongoServiceStart", "Starts the mongo database background service, allowing you to connect"},
            {"mongoServiceEnd", "Stops the mongo database background service to free up resources"},
            {"makeDirDB", "Creating directory for MongoDB"},
            {"importMongoCustomers", "Imports provided file into mongo database"},
            {"importMongoVehicles", "Imports provided file into mongo database"}
        };

       
    }
}
