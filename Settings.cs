using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Database_Application_Chris
{
    public class Settings
    {
        //Version information about the application
        //public int version = 1; // Large update
        //public int versionIteration = 0; // Incremental change

        ///public string database = "FusionMotors";
        public static string mongoBinPath; //@"C:\Program Files\MongoDB\Server\4.4\bin"; // @ stops escape
        public static string storeDBLocation = @"Database"; //@"C:\Program Files\MongoDB\Server\4.4\bin"; // @ stops escape

        public Settings()
        {
            string path = @"Mongo.txt"; 

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                { 
                    //while (!sr.EndOfStream)
                    //{
                        var line = sr.ReadLine();

                        if (line.StartsWith("MongoPath"))
                        {
                            string temp = line;
                            string[] pathReconstruction = temp.Split("=");

                            //Check if theres a path provided
                            if (pathReconstruction.Length > 1)
                            {
                                temp = pathReconstruction[1].Trim();
                            }else
                            {
                                temp = "";
                            }

                            if (Directory.Exists(temp))
                            {
                                mongoBinPath = temp;

                                //Allow Stream Write to access file - Can Only access first line
                                sr.Close();

                                try
                                {
                                    SetPath(mongoBinPath, 0);
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.Message, "");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Mongo file location is invalid!\nPlease select the location of your mongoDB installation", "Mongo File Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }          
                        }
                    //}
                } 
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(@"MongoPath: ");
                    //C:\Program Files\MongoDB\Server\4.4\bin
                }

                MessageBox.Show("Mongo file location is invalid!\nPlease select the location of your mongoDB installation", "Mongo File Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void SetPath(string path, int type)
        {
            using (StreamWriter sw = (File.Exists("Mongo.txt")) ? File.CreateText("Mongo.txt") : File.CreateText("Mongo.txt"))
            {
                sw.Write(@"MongoPath = " + path);
                sw.Close();
            }

            if (type == 1)
            {
                MessageBox.Show("Mongo Path set to: " + path, "Mongo File Path Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //static void lineChanger(string newText, string fileName, int line_to_edit)
        //{
        //    string[] arrLine = File.ReadAllLines(fileName);
        //    arrLine[line_to_edit - 1] = newText;
        //    File.WriteAllLines(fileName, arrLine);
        //}

        public static readonly IDictionary<string, string> commands = new Dictionary<string, string>()
        { 
            {"mongoServiceStart", "mongod.exe --dbpath \"" + AppDomain.CurrentDomain.BaseDirectory + @"\Database" + "\""},
            {"mongoServiceEnd", "taskkill /F /IM mongod.exe"},
            {"makeDirDB", @"mkdir Database"},
            {"importMongoCustomers", @"mongoimport --db FusionMotors --collection Customers --file "},
            {"importMongoVehicles", @"mongoimport --db FusionMotors --collection Vehicles --file "}
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
