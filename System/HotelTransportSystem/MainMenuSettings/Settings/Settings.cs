using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace HotelTransportSystem.MainMenuSettings.Settings
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        SettingsData data = new SettingsData();

        string StrResultJson;

        private void Settings_Load(object sender, EventArgs e)
        {
            #region DarkandLight Mode

            try
            {
                if (File.Exists("SettingsData.json"))
                {
                    StrResultJson = string.Empty;
                    StrResultJson = File.ReadAllText(@"SettingsData.json");
                    SettingsData StrResult = JsonConvert.DeserializeObject<SettingsData>(StrResultJson);

                    if (StrResult.DarkorLightMode == "Dark")
                    {
                        DarkTheme_btn.Checked = true;
                    }
                    else if (StrResult.DarkorLightMode == "Light")
                    {
                        LightTheme_btn.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }

            #endregion
        }

        #region Save Button

        private void SaveChangers_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DarkTheme_btn.Checked == true)
                {
                    data.DarkorLightMode = "Dark";
                }
                else if (LightTheme_btn.Checked == true)
                {
                    data.DarkorLightMode = "Light";
                }

                if (File.Exists("SettingsData.json"))
                {
                    StrResultJson = string.Empty;
                    StrResultJson = File.ReadAllText(@"SettingsData.json");
                    SettingsData StrResult = JsonConvert.DeserializeObject<SettingsData>(StrResultJson);
                    string Username = StrResult.UsernameJson;

                    data.UsernameJson = Username;
                }

                StrResultJson = JsonConvert.SerializeObject(data);
                File.WriteAllText(@"SettingsData.json", StrResultJson);
                MessageBox.Show("data successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }


        #endregion
        
    }
}
