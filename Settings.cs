using System.Collections.Generic;

namespace Database_Application_Chris
{
    public class Settings
    {
        public readonly IDictionary<string, string> commands = new Dictionary<string, string>()
        {
            {"mongoServiceStart", "mongod"},
            {"mongoServiceEnd", "taskkill /F /IM mongod.exe"}
        };

        public readonly IDictionary<string, string> commandsInfo = new Dictionary<string, string>()
        {
            {"mongoServiceStart", "Starts the mongo database background service, allowing you to connect"},
            {"mongoServiceEnd", "Stops the mongo database background service to free up resources"}
        };

        //Version information about the application
        public int version = 1; // Large update
        public int versionIteration = 0; // Incremental change

        public string database = "FusionMotors";
    }
}
