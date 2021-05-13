using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Configuration;

namespace DMBient_Player
{
    public class SettingsManager
    {
        // Lista apo Scenarios

        public Theme selectedTheme { get; set; }
        
        public List<Scenario> Scenarios { get; set; } = new List<Scenario>();

        public static void Save(SettingsManager settings) 
        {
            
            //Ta Tasks xrisimevoun gia na mporei na ginei parallili ektelesi kwdika.
            //*Na psaksw gia Lamda expressions =>*
            Task saveTask = new Task(() => {
                    string settingsFilePath = Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["SettingsFilePath"];
                    var settingsStr = Newtonsoft.Json.JsonConvert.SerializeObject(settings);
                    System.IO.File.WriteAllText(settingsFilePath, settingsStr);
            });

            saveTask.Start();
        }

        public static SettingsManager Load() 
        {
            //Na proseksw gia exceptions
            //an uparxei arxeio , an ginetai deserialize. 
            //na kanw to *txt se *json
            //try { }
            //catch { }

            string settingsFilepath = ConfigurationManager.AppSettings["SettingsFilePath"];
            string settingsStr = File.ReadAllText(Directory.GetCurrentDirectory() + settingsFilepath);
            var result = JsonConvert.DeserializeObject<SettingsManager>(settingsStr);
            return result;
        }
    }
}
