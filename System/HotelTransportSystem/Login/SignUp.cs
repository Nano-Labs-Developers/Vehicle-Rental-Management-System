using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.Login
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        // This form Main Variables

        #region Main Vars

        int Result;
        string Role;
        string Email;
        bool UserSure; // user sure I'm sign up in admin
        string Username;
        string Password;
        bool ExistsEmail;
        bool ExistsUsername;
        bool AdminAlreadySingUp;

        #endregion

        // SQL Connection String

        #region SQL Connection String

        static string ConnectionString = ConfigurationManager.ConnectionStrings["Ayubo_Leisure"].ConnectionString;
        SqlConnection con = new SqlConnection(ConnectionString);

        #endregion

        // Appliction Exit 

        #region Application Handlers

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        // Sign up Button

        #region SignUp Button

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            SignUpFunc();

        }

        #endregion

        // Back Sign in form

        #region Back to SignIn Form

        private void Signin_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        #endregion

        // Leave textbox && chack Username && Email already exist? [ Class call ]

        #region Username and Email textbox leave message

        private void LoginUsername_txt_Leave(object sender, EventArgs e)
        {
            // Check if the Username exists
            UsernameExist();

            if (ExistsUsername)
            {
                ErrorMessage.SetError(LoginUsername_txt, "This username has been using by another user.");
            }

        }

        private void LoginEmail_txt_Leave(object sender, EventArgs e)
        {
            // Check if the Email exists
            EmailExist();

            if (ExistsEmail)
            {
                ErrorMessage.SetError(LoginEmail_txt, "This email has been using by another user.");
            }

        }

        #endregion

        // This form main classes

        #region Classes

        // Sign Up func

        #region Signup func

        private void SignUpFunc()
        {
            // Admin Login Chack
            AdminLoginCheck();

            // Check if the Username exists
            UsernameExist();

            // Check if the Email exists
            EmailExist();

            // Textbox Empty Check Class call
            TextboxEmptychack();

            // Ask are you sure message box? [ Only admin signup | First login only ]
            if (AdminAlreadySingUp == false)
            {
                DialogResult dialogResult = MessageBox.Show("Admin Login", "You are trying to signup admin account are you sure", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) // User know I'm signup in admin
                {
                    UserSure = true;

                }
                else if (dialogResult == DialogResult.No) // User not sure 
                {
                    UserSure = false;
                    return;

                }
            }
            else if (AdminAlreadySingUp == true)
            {
                Signupmainfunc();

            }

            // User Sure or Not
            if (UserSure == true)
            {
                Signupmainfunc();

            }
            else if ((UserSure == false))
            {
                return;

            }
            

        }

        // this main func for sign up [ DB handle and more ]

        #region Sign Up main Func

        private void Signupmainfunc()
        {
            // if Email exists, show a message error
            if (ExistsUsername)
            {
                ErrorMessage.SetError(LoginUsername_txt, "This username has been using by another user.");

            }

            else
            {
                // if Username exists, show a message error
                if (ExistsEmail)
                {
                    ErrorMessage.SetError(LoginEmail_txt, "This email has been using by another user.");

                }
                else
                {

                    try
                    {
                        // Variables
                        Username = LoginUsername_txt.Text;
                        Password = LoginPassword_txt.Text;
                        Email = LoginEmail_txt.Text;

                        if (AdminAlreadySingUp == true)
                        {
                            Role = "Not Set";

                        }
                        else
                        {
                            Role = "Admin";

                        }

                        // SQL query
                        string query_insert = "INSERT INTO Login VALUES('" + Username + "','" + Password + "','" + Email + "','" + Role + "')";

                        // SQL Command
                        SqlCommand cmnd = new SqlCommand(query_insert, con);
                        con.Open();
                        // Execution of the command
                        cmnd.ExecuteNonQuery();

                        // Successfull Message after the execution
                        if (AdminAlreadySingUp == true)
                        {
                            MessageBox.Show("Wating for accept");

                        }
                        else
                        {
                            MessageBox.Show("Admin login Successfuly");

                        }

                        this.Hide();
                        Login obj = new Login();
                        obj.Show();

                    }

                    catch (Exception ex)
                    {
                        // Error send
                        MessageBox.Show("Error While Singup" + ex);

                    }

                    finally
                    {
                        // Closing the connection
                        con.Close();
                    }

                }

            }
        }

        #endregion

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

        // Email && password Check [ Class ]

        #region Email && Username already Exist

        private void EmailExist()
        {
            ExistsEmail = false;

            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Login] where Email = @Email", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Email", LoginEmail_txt.Text);
                ExistsEmail = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
        }

        private void UsernameExist()
        {
            ExistsUsername = false;

            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Login] where UserName = @UserName", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("UserName", LoginUsername_txt.Text);
                ExistsUsername = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
        }

        #endregion

        // textbox empty check

        #region text box empty check

        private void TextboxEmptychack()
        {

            if (String.IsNullOrEmpty(LoginUsername_txt.Text))
            {
                ErrorMessage.SetError(LoginEmail_txt, "Please Provide Username");
                return;
            }

            if (String.IsNullOrEmpty(LoginEmail_txt.Text))
            {
                ErrorMessage.SetError(LoginEmail_txt, "Please Provide Email");
                return;
            }

            if (String.IsNullOrEmpty(LoginPassword_txt.Text))
            {
                ErrorMessage.SetError(LoginEmail_txt, "Please Provide Password");
                return;
            }

        }
        
        #endregion

        #endregion

    }
}
