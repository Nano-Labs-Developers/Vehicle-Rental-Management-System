using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HotelTransportSystem.MainMenuSettings.Settings;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace HotelTransportSystem.Login
{
    public partial class Login : Form
    {
        // This form main variables

        #region Main vars

        int Result;
        string Useraname;
        string Password;
        string SetedRole;
        bool AdminAlreadySingUp;

        public static string UserRole;

        #endregion

        // Loading Screen Functions

        #region Loading Screen

        public Login()
        {
            // Loading Screen

            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            trd.Abort();
            
        }

        private void formRun()
        {
            // Form Loading Screen run Command
            Application.Run(new StartUp.StartUp());            
        }

        #endregion

        // SQL Connection String

        #region SQL Connection String

        static string ConnectionString = ConfigurationManager.ConnectionStrings["Ayubo_Leisure"].ConnectionString;
        SqlConnection con = new SqlConnection(ConnectionString);

        #endregion

        // Form Controller

        #region Form Controllers

        private void LoginExit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // Sign in Button Functions

        #region SignIn Button

        protected void Signin_btn_Click(object sender, EventArgs e)
        {
            SignIn();

        }

        #endregion

        // Sign Up Button [ Open Sign Up form ]

        #region SignUp Button

        protected void Signup_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp obj = new SignUp();
            obj.Show();
        }

        #endregion

        // Forgot Button [ Open Forgot Form ]

        #region Forgot Button

        protected void ForgotPassword_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgot_Password obj = new Forgot_Password();
            obj.Show();
        }

        #endregion

        // This form main Classes

        #region Classes       

        // Sign in Class

        #region Sign In Func

        private void SignIn()
        {
            Useraname = LoginUsername_txt.Text;
            Password = LoginPassword_txt.Text;

            if (String.IsNullOrEmpty(Useraname))
            {
                ErrorMessage.SetError(Signin_btn, "Please Provide Username.");
                return;
            }

            if (String.IsNullOrEmpty(Password))
            {
                ErrorMessage.SetError(Signin_btn, "Please Provide Password.");
                return;
            }

            SqlDataAdapter sqa = new SqlDataAdapter("SELECT COUNT(*) FROM Login WHERE UserName = '" + Useraname + "' and Password = '" + Password + "' ", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            AdminLoginCheck();

            if (AdminAlreadySingUp == true)
            {
                // Check valied
                if (dt.Rows[0][0].ToString() == "1")
                {
                    using (var command = con.CreateCommand())
                    {
                        command.CommandText = "SELECT Role FROM Login WHERE Username = '" + Useraname + "' ";
                        con.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                SetedRole = reader["Role"].ToString();
                        }
                    }
                    con.Close();

                    if (SetedRole != "Not Set")
                    {
                        UserRole = SetedRole;

                        // Save Data from json

                        #region Save data json [Username]

                        // Save Username temp => Write line Json file  [ Pass value signin successfully and my username is Ex: "Admin" ]
                        SettingsData data = new SettingsData();
                        string StrResultJson;

                        if (File.Exists("SettingsData.json"))
                        {
                            StrResultJson = string.Empty;
                            StrResultJson = File.ReadAllText(@"SettingsData.json");
                            SettingsData StrResult = JsonConvert.DeserializeObject<SettingsData>(StrResultJson);
                            string DarkorLightMode = StrResult.DarkorLightMode;
                            data.DarkorLightMode = DarkorLightMode;
                        }

                        data.UsernameJson = Useraname;

                        StrResultJson = JsonConvert.SerializeObject(data);
                        File.WriteAllText(@"SettingsData.json", StrResultJson);

                        #endregion

                        // Open main menu if password  && username is true

                        this.Hide();
                        MainMenu obj = new MainMenu();
                        obj.Show();
                    }
                    else
                    {
                        // Not approvel yet

                        MessageBox.Show("Wait for aprovel");

                        LoginUsername_txt.Text = "";
                        LoginPassword_txt.Text = "";

                    }

                }
                else
                {
                    ErrorMessage.SetError(Signin_btn, "Check your username and password.");
                }

            }
            else
            {
                MessageBox.Show("First Sign up admin.");
            }

        }

        #endregion

        // Admin Login Check

        #region Admin Login Check

        protected void AdminLoginCheck()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM Login";

                Result = int.Parse(cmd.ExecuteScalar().ToString());

                if (Result == 0)
                {
                    AdminAlreadySingUp = false;
                }
                else
                {
                    AdminAlreadySingUp = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        #endregion

    }
}