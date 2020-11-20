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

namespace HotelTransportSystem.Admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        // This form Variable list

        #region main vars

        bool TopMostForm = false;
        string Role;
        string Username;

        #endregion

        // SQL Connection string

        #region SQL Conn String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        // This form Load event [Load after what I do]

        #region This Form Load Event

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Load Tables
            tableLoadVarified();
            tableLoadAwaiting();

            // Head panel Data Load Class Calling
            AllUserCount();
            WaitingUserCount();
            tableLoadBookedCount();
            tableLoadVehicleCount();
            tableLoadCustomerCount();
            tableLoadAvailableVehicleCount();
        }

        #endregion

        // This form Top menu strip Menu Items functions list

        #region Menu Strip

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TopMostForm == false)
            {
                this.TopMost = true;
                TopMostForm = true;
            }
            else
            {
                this.TopMost = false;
                TopMostForm = false;
            }
        }

        #endregion

        // Data Grid View Data Load functions

        #region table load

        // Verified User Data load [DB : Login]

        private void tableLoadVarified()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT ID, UserName, Email, Role FROM Login WHERE Role = 'Verified'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                VerifiedUser_datagrid.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        // Awating User Data load [DB : Login]

        private void tableLoadAwaiting()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT ID, UserName, Email, Role FROM Login WHERE Role != 'Admin' AND Role != 'Verified'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                NewUser_datagrid.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        // Main Head Data Load class

        #region Head Panel Classes

        // User Data read [DB : Login]

        #region Login Table

        private void AllUserCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Login WHERE Role = 'Verified'";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                VerifiedUserCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void WaitingUserCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Login WHERE Role = 'Not Set'";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                WaitingUsersCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Vehicle data load [ All vehicles, Avilable vehicles ]

        #region Vehicles

        private void tableLoadVehicleCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Vehicles";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                VehicleCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void tableLoadAvailableVehicleCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Vehicles WHERE Vehicle_Available = '1' ";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                AvailableVehicleCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Cutomer Count

        #region Cutomer Count

        private void tableLoadCustomerCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Customers";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                CustomerCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Booked vehicle count

        #region Booked Count

        private void tableLoadBookedCount()
        {
            try
            {
                con.Open();

                // SQL query
                string query_select = "SELECT COUNT (*) FROM Booked";
                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_select, con);
                // Execution of the command
                Int32 count = (Int32)cmnd.ExecuteScalar();
                AvailableBookedCount_lbl.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }


        #endregion

        #endregion

        // Verified User Control [ Revoke | Kick ]

        #region verified User Control

        private void UserRevoke_btn_Click(object sender, EventArgs e)
        {
            Username = VerifiedUsername_txt.Text;

            try
            {
                // UseNameText check class caller func
                // SQL query
                string query_update = "DELETE FROM Login WHERE Username = '" + Username + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Successfully");

                con.Close();

                TextBoxClear();
                tableLoadVarified();
                AllUserCount();
                WaitingUserCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void UserKick_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Username = VerifiedUsername_txt.Text;

                // UseNameText check class caller func
                // SQL query
                string query_update = "DELETE FROM Login WHERE Username = '" + Username + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Successfully");

                con.Close();

                TextBoxClear();
                tableLoadVarified();
                AllUserCount();
                WaitingUserCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // New User Control [ Accept | Reject ]

        #region New User Control

        private void NewUserAccept_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Role = "Verified";
                Username = NewUsername_txt.Text;

                // SQL query
                string query_update = "UPDATE Login SET Role = '" + Role + "' WHERE Username = '" + Username + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                if (Role != "Not Set")
                {
                    MessageBox.Show("User successfully accepted.");
                }
                else
                {
                    MessageBox.Show("Account successfully stoped.");
                }


                con.Close();

                tableLoadAwaiting();
                tableLoadVarified();
                AllUserCount();
                WaitingUserCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
        }

        private void NewUserReject_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Username = NewUsername_txt.Text;

                // UseNameText check class caller func
                // SQL query
                string query_update = "DELETE FROM Login WHERE Username = '" + Username + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_update, con);
                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();

                // Successfull Message after the execution
                MessageBox.Show("Successfully");

                con.Close();

                tableLoadAwaiting();
                AllUserCount();
                WaitingUserCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Table | DataGridView Data load in text Box

        #region Table | DataGridView Data load in textbox

        private void VerifiedUser_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (VerifiedUser_datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    VerifiedUser_datagrid.CurrentRow.Selected = true;

                    VerifiedUserID_lbl.Text = VerifiedUser_datagrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    VerifiedUsername_txt.Text = VerifiedUser_datagrid.Rows[e.RowIndex].Cells["UserName"].FormattedValue.ToString();

                    VerifiedEmail_txt.Text = VerifiedUser_datagrid.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    VerifiedRole_txt.Text = VerifiedUser_datagrid.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();

                }

            }

        }

        private void NewUser_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (NewUser_datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    NewUser_datagrid.CurrentRow.Selected = true;

                    NewUserID_lbl.Text = NewUser_datagrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    NewUsername_txt.Text = NewUser_datagrid.Rows[e.RowIndex].Cells["UserName"].FormattedValue.ToString();

                    NewEmail_txt.Text = NewUser_datagrid.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    NewRole_txt.Text = NewUser_datagrid.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();

                }

            }

        }

        #endregion

        // textbox clear function

        #region TextBox Clear

        private void TextBoxClear()
        {
            VerifiedUsername_txt.Text = "";
            VerifiedEmail_txt.Text = "";
            VerifiedRole_txt.Text = "";
            NewUsername_txt.Text = "";
            NewEmail_txt.Text = "";
            NewRole_txt.Text = "";
        }

        #endregion

        // Data Grid View Refresh Button

        #region Refresh Button

        private void NewDGVRefresh_btn_Click(object sender, EventArgs e)
        {
            tableLoadAwaiting();
        }

        private void VerifiedDGVRefresh_btn_Click(object sender, EventArgs e)
        {
            tableLoadVarified();
        }

        #endregion

    }
}
