using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BarCodeTyper
{
    public class Settings
    {
        public string StartSearchString { get; set; }
        public string EndSearchString { get; set; }
        public string BeforeReadCommand { get; set; }
        public string AfterReadCommand { get; set; }
        public bool InvertCameraX { get; set; }
        public bool InvertCameraY { get; set; }

        public  void Save()
        {
            File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),"BarCodeTyper","config.dat"),JsonConvert.SerializeObject(this));
        }

        public  void Load()
        {
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "BarCodeTyper","config.dat")))
             return;
            
            var info = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BarCodeTyper\\config.dat")));

            StartSearchString = info.StartSearchString;
            EndSearchString = info.EndSearchString;
            BeforeReadCommand = info.BeforeReadCommand;
            AfterReadCommand = info.AfterReadCommand;
            InvertCameraX = info.InvertCameraX;
            InvertCameraY = info.InvertCameraY;

        }
    }
}
