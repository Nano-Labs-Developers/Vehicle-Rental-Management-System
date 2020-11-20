using HotelTransportSystem.Admin;
using HotelTransportSystem.Login;
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

namespace HotelTransportSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();            
        }

        // This Form Main variables

        #region Main Vars

        int Panel_Size;
        bool Side_Panel_Hided;
        string UserRole;

        #endregion

        // This form Load Event

        #region Form Load

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Startup details load

            #region StartUp

            SideMenuSideColor_pnl.Height = Hire_btn.Height;
            SideMenuSideColor_pnl.Top = Hire_btn.Top;
            boocking1.BringToFront();

            Panel_Size = MainSide_pnl.Width;
            Side_Panel_Hided = false;


            #endregion

            // Admin Panel Access Check Class Calling
            IfAdmin();

            // Load Setting Details

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

        // Application Headline and Button Handler Func

        #region Application Header Hadeling and Buttons

        private void MainMenuClose_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void MainMenuClose_btn_MouseHover(object sender, EventArgs e)
        {
            MainMenuClose_btn.BackColor = Color.Transparent;
        }

        private void MainMenuMaximize_btn_MouseHover(object sender, EventArgs e)
        {
            MainMenuMaximize_btn.BackColor = Color.Transparent;
        }

        private void MainMenuMinimize_btn_MouseHover(object sender, EventArgs e)
        {
            MainMenuMinimize_btn.BackColor = Color.Transparent;
        }


        #endregion

        // Side menu Handler [ Hide and Show ]

        #region SideMenu Setup (Hide and Show)
        
        private void SidePanelHide_btn_Click(object sender, EventArgs e)
        {
            SideMenuTimer.Start();
        }

        private void SideMenuTimer_Tick(object sender, EventArgs e)
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
                    MainMenuMain_pnl.Refresh();

                    Rent_btn.Text = "    Rent";
                    Hire_btn.Text = "    Hire";
                    Return_btn.Text = "    Customer";
                    Data_btn.Text = "    Data";
                    Settings_btn.Text = "    Settings";

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
                    SideMenuTimer.Stop();
                    Side_Panel_Hided = true;
                    this.Refresh();
                    MainMenuMain_pnl.Refresh();

                    Rent_btn.Text = "";
                    Hire_btn.Text = "";
                    Return_btn.Text = "";
                    Data_btn.Text = "";
                    Settings_btn.Text = "";

                    NameTag_btn.Visible = false;
                }
            }
        }

        #endregion

        // Side menu fuc

        #region SideMenu Setup(Main Algorithm)

        private void Data_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data.DataView obj = new Data.DataView();
            obj.Show();
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Settings_btn.Height;
            SideMenuSideColor_pnl.Top = Settings_btn.Top;

            settings1.BringToFront();
        }        

        private void Rent_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Rent_btn.Height;
            SideMenuSideColor_pnl.Top = Rent_btn.Top;

            boocking1.BringToFront();
        }

        private void Hire_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;

            SideMenuSideColor_pnl.Height = Hire_btn.Height;
            SideMenuSideColor_pnl.Top = Hire_btn.Top;

            boocking1.BringToFront();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            SideMenuSideColor_pnl.Visible = true;
            /*
            SideMenuSideColor_pnl.Height = Customer_btn.Height;
            SideMenuSideColor_pnl.Top = Customer_btn.Top;
            */

            HotelTransportSystem.Return.Return RTN = new Return.Return();
            RTN.Show();

        }

        private void DataPopUp_btn_Click(object sender, EventArgs e)
        {
            Data.DataView obj = new Data.DataView();
            obj.Show();
        }

        private void AdminPanel_btn_Click(object sender, EventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            obj.Show();
        }

        #endregion

        // Admin Panel Access handler

        #region ifAdmin sign in

        private void IfAdmin()
        {
            UserRole = Login.Login.UserRole;

            if (UserRole == "Admin")
            {
                AdminPanel_btn.Visible = true;
            }
            else
            {
                if (AdminPanel_btn.Visible == true)
                {
                    AdminPanel_btn.Visible = false;
                }
            }

        }

        #endregion

    }
}
