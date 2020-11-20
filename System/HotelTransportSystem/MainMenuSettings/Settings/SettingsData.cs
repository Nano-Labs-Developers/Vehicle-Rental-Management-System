using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HotelTransportSystem.MainMenuSettings.Settings
{
    public class SettingsData
    {
        public string DarkorLightMode { get; set; }

        public string UsernameJson {  get; set; }

        public List<string> Users { get; set; }
    }
}
