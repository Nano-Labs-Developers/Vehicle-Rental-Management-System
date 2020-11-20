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
    public partial class ResetPassword : Form
    {
        #region SQL Connection Create

        static string ConnectionString = ConfigurationManager.ConnectionStrings["Ayubo_Leisure"].ConnectionString;
        SqlConnection con = new SqlConnection(ConnectionString);

        #endregion

        string Email = Forgot_Password.to;
        
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_btn_Click(object sender, EventArgs e)
        {
            #region Vars

            string NewPassword = NewPassword_txt.Text;
            string ConfirmPassword = ConfirmPassword_txt.Text;

            #endregion

            #region Empty Text Box check

            if (String.IsNullOrEmpty(NewPassword_txt.Text))
            {
                //Error_lbl.Text = "Please Provide Username";
                //Error_lbl.ForeColor = Color.Red;
                return;
            }

            if (String.IsNullOrEmpty(ConfirmPassword_txt.Text))
            {
                //Error_lbl.Text = "Please Provide Username";
                //Error_lbl.ForeColor = Color.Red;
                return;
            }

            #endregion

            if (NewPassword == ConfirmPassword)
            {
                string query_update = "UPDATE Login SET Password= '" + ConfirmPassword+"' WHERE Email= '"+ Email + "' ";

                con.Open();
                SqlCommand cmnd = new SqlCommand(query_update, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset Successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }
    }
}
