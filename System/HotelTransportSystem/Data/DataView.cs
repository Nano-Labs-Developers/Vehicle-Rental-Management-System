using HotelTransportSystem.MainMenuSettings.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.Data
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        #region Main Vars

        int Panel_Size;
        bool Side_Panel_Hided;

        #endregion

        #region Form load and User Profile Manager Algorithm

        private void DataView_Load(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Packages_btn.Height;
            SideMenuSideColor_pnl.Top = Packages_btn.Top;

            packageData1.BringToFront();

            // StartUp
            Panel_Size = MainSide_pnl.Width;
            Side_Panel_Hided = false;

            SettingsData data = new SettingsData();
            string StrResultJson;

            if (File.Exists("SettingsData.json"))
            {
                StrResultJson = string.Empty;
                StrResultJson = File.ReadAllText(@"SettingsData.json");
                SettingsData StrResult = JsonConvert.DeserializeObject<SettingsData>(StrResultJson);
                string Username = StrResult.UsernameJson;

                NameTag_btn.LabelText = Username;
            }
        }

        #endregion
        
        #region Form Controller

        private void MainMenuClose_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainMenuMaximize_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MainMenuMinimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Side Menu Button

        private void Packages_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Packages_btn.Height;
            SideMenuSideColor_pnl.Top = Packages_btn.Top;

            packageData1.BringToFront();
        }

        private void Driver_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Driver_btn.Height;
            SideMenuSideColor_pnl.Top = Driver_btn.Top;

            driversData1.BringToFront();
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Customer_btn.Height;
            SideMenuSideColor_pnl.Top = Customer_btn.Top;

            customer1.BringToFront();
        }

        private void Vehicles_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Vehicles_btn.Height;
            SideMenuSideColor_pnl.Top = Vehicles_btn.Top;

            vehicleData1.BringToFront();
        }


        private void Booked_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Booked_btn.Height;
            SideMenuSideColor_pnl.Top = Booked_btn.Top;

            bookedData1.BringToFront();
        }

        private void BackHome_btn_Click(object sender, EventArgs e)
        {/*
            bool IsOpen = false;
            foreach (Form obj in Application.OpenForms)
            {
                if(obj.Text == "MainMenu")
                {
                    IsOpen = true;
                    obj.Focus();
                    this.Hide();
                    break;
                }
            }

            if (IsOpen == false)
            {
                MainMenu obj2 = new MainMenu();
                obj2.Show();
                this.Hide();
            }*/
            MainMenu obj2 = new MainMenu();
            obj2.Show();
            this.Hide();

        }

        private void MainMenusettings_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = MainMenusettings_btn.Height;
            SideMenuSideColor_pnl.Top = MainMenusettings_btn.Top;

            settings1.BringToFront();
        }

        #endregion

        #region Side Menu Form Hide and Show

        private void SideMenuTimer_Tick(object sender, EventArgs e)
        {
            SideMenuTimer.Start();
        }

        private void SidePanelHide_btn_Click(object sender, EventArgs e)
        {
            if (Side_Panel_Hided)
            {
                MainSide_pnl.Width = 280;
                SideMenu_pnl.Width = 280;
                SidePanelHadler_pnl.Width = 280;

                //MainMenMain_pnl.Width = MainMenMain_pnl.Width - 146;
                if (MainSide_pnl.Width >= 71)
                {
                    SideMenuTimer.Stop();
                    Side_Panel_Hided = false;
                    this.Refresh();
                    //MainMenuMain_pnl.Refresh();

                    Vehicles_btn.Text = "    Vehicles";
                    Driver_btn.Text = "    Drivers";
                    Customer_btn.Text = "    Customer";
                    BackHome_btn.Text = "    Home";
                    MainMenusettings_btn.Text = "    Settings";
                    Packages_btn.Text = "    Packages";

                    NameTag_btn.Visible = true;
                }
            }
            else
            {
                MainSide_pnl.Width = 94;
                SideMenu_pnl.Width = 94;
                SidePanelHadler_pnl.Width = 83;

                //MainMenMain_pnl.Width = MainMenMain_pnl.Width + 146;
                if (MainSide_pnl.Width <= Panel_Size)
                {
                    Vehicles_btn.Text = "";
                    Driver_btn.Text = "";
                    Customer_btn.Text = "";
                    BackHome_btn.Text = "";
                    MainMenusettings_btn.Text = "";
                    Packages_btn.Text = "";

                    NameTag_btn.Visible = false;
                    SideMenuTimer.Stop();
                    Side_Panel_Hided = true;
                    this.Refresh();
                    //MainMenuMain_pnl.Refresh();                    
                }
            }

            #endregion

        }

    }
}
