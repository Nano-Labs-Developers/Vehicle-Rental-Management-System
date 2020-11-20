using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelTransportSystem.Drivers
{
    public partial class DriversData : UserControl
    {
        public DriversData()
        {
            InitializeComponent();
        }

        // This form and public variables

        #region Global Vars

        bool AlredyExists = false;
        string UserRole;

        #endregion

        // SQL Connection String 

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        // From Load Event

        #region Form Load

        private void DriversData_Load(object sender, EventArgs e)
        {
            tableLoad();
            DeleteBTNShow();
        }

        #endregion

        // Data list button and Anothor form open button

        #region Data List Button (Open anothor user form) [Driver Data List]

        private void DriverDataListView_btn_Click(object sender, EventArgs e)
        {
            Driver_groupBox.Visible = false;
            DriverDataGrid.Visible = false;
            DriversDataStandard_btn.Visible = false;
            DriverDataListView_btn.Visible = false;
            if (DriverDelete_btn.Visible == true)
            {
                DriverDelete_btn.Visible = false;
            }

            Drivers.DriversDataList uc = new DriversDataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        // Add new driver buttton

        #region Add New Button

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            try
            {
                AlredyExist();

                if (AlredyExists)
                {
                    ErrorMessage.SetError(DriverNIC_txt, "This customer has been exists.");
                    return;
                }
                else
                {
                    InsertQuery();
                    tableLoad();
                    TextBoxClear();
                }
            }
            catch (Exception ex)
            {
                // Error send
                MessageBox.Show("Error While Save.\n" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // Edit driver data button

        #region Edit Button

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();
            
            try
            {
                AlredyExist();

                if (AlredyExists)
                {
                    UpdateQuery();
                    tableLoad();
                    TextBoxClear();
                }
                else
                {
                    ErrorMessage.SetError(DriverNIC_txt, "This driver has been not exists.");
                    return;
                }
            }
            catch (Exception ex)
            {
                // Error send
                MessageBox.Show("Error While Edit" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

        // textbox Clear button Class

        #region Clear Button [Class]

        private void TextBoxClear()
        {
            // Bunifu Text Boxes not support Clear Command

            DriverNIC_txt.Text = "";
            DriverName_txt.Text = "";
            DriverTelNo_txt.Text = "";
            DriverIDShow_lbl.Text = "";

            if (DriverAvailable_checkbox.Checked == true)
            {
                DriverAvailable_checkbox.Checked = false;
            }
        }

        #endregion

        // textbox Clear button

        #region Clear Button

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        #endregion

        // Table data load button | datagridview

        #region Table Load Function
        
        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Drivers";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DriverDataGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        #endregion

        // Search button

        #region Search Button

        private void SearchBox_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("select * from Drivers where Driver_Name like '" + SearchBox_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                DriverDataGrid.DataSource = dt;
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

        // Datagridview Cell Click event

        #region Data Grid Clcik Event

        private void DriverDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DriverDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DriverDataGrid.CurrentRow.Selected = true;

                    DriverIDShow_lbl.Text = DriverDataGrid.Rows[e.RowIndex].Cells["Driver_ID"].FormattedValue.ToString();
                    DriverNIC_txt.Text = DriverDataGrid.Rows[e.RowIndex].Cells["Driver_NIC"].FormattedValue.ToString();

                    DriverName_txt.Text = DriverDataGrid.Rows[e.RowIndex].Cells["Driver_Name"].FormattedValue.ToString();
                    DriverTelNo_txt.Text = DriverDataGrid.Rows[e.RowIndex].Cells["Driver_TelNo"].FormattedValue.ToString();

                    string DriverAvailable = DriverDataGrid.Rows[e.RowIndex].Cells["Driver_Available"].FormattedValue.ToString();

                    int DriverAvailableInt = Convert.ToInt32(DriverAvailable);

                    if (DriverAvailableInt == 1)
                    {
                        DriverAvailable_checkbox.Checked = true;
                    }
                    else if (DriverAvailableInt == 0)
                    {
                        DriverAvailable_checkbox.Checked = false;
                    }

                }
            }
                
        }

        #endregion

        // textbox empty check func

        #region Textbox empty check

        private void TextboxEmptyCheck()
        {
            if (String.IsNullOrEmpty(DriverNIC_txt.Text))
            {
                ErrorMessage.SetError(DriverNIC_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(DriverName_txt.Text))
            {
                ErrorMessage.SetError(DriverName_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(DriverTelNo_txt.Text))
            {
                ErrorMessage.SetError(DriverTelNo_txt, "This field cann't be empty.");
                return;
            }

        }

        #endregion

        // SQL Update Query

        #region Update Query

        private void UpdateQuery()
        {
            int DriverID = Convert.ToInt32(DriverIDShow_lbl.Text);
            int DriverAvailable;
            string DriverTelNo = DriverTelNo_txt.Text;

            if (DriverAvailable_checkbox.Checked == true)
            {
                DriverAvailable = 1;
            }
            else
            {
                DriverAvailable = 0;
            }

            // SQL query
            string query_insert = "UPDATE Drivers SET Driver_NIC=@Driver_NIC, Driver_Name=@Driver_Name, Driver_TelNo=@Driver_TelNo, Driver_Available=@Driver_Available WHERE Driver_ID = '" + DriverID + "'";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);


            cmnd.Parameters.AddWithValue("@Driver_NIC", DriverNIC_txt.Text);
            cmnd.Parameters.AddWithValue("@Driver_Name", DriverName_txt.Text);

            cmnd.Parameters.AddWithValue("@Driver_TelNo", DriverTelNo);
            cmnd.Parameters.AddWithValue("@Driver_Available", DriverAvailable);

            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            MessageBox.Show("Done");
            con.Close();

        }

        #endregion

        // SQL Insert Query

        #region Insert Query

        private void InsertQuery()
        {
            int DriverAvailable;
            string DriverTelNo = DriverTelNo_txt.Text;

            if (DriverAvailable_checkbox.Checked == true)
            {
                DriverAvailable = 1;
            }
            else
            {
                DriverAvailable = 0;
            }

            // SQL query
            string query_insert = "INSERT INTO Drivers VALUES('" + DriverNIC_txt.Text + "','" + DriverName_txt.Text + "','" + DriverAvailable + "','" + DriverTelNo + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            MessageBox.Show("Done");
            con.Close();

        }

        #endregion

        // Check Driver is already exist

        #region Check if the Driver exists

        private void AlredyExist()
        {
            if (DriverIDShow_lbl.Text != "")
            {

                // Check if the Customer_NIC exists
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Drivers] WHERE Driver_ID = @Driver_ID", con))
                {
                    int DriverID = Convert.ToInt32(DriverIDShow_lbl.Text);

                    con.Open();
                    cmd.Parameters.AddWithValue("Driver_ID", DriverID);
                    AlredyExists = (int)cmd.ExecuteScalar() > 0;
                    con.Close();
                }

            }
            else
            {

                // Check if the Customer_NIC exists
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Drivers] WHERE Driver_ID = @Driver_ID", con))
                {
                    string DriverNIC2 = DriverIDShow_lbl.Text;

                    con.Open();
                    cmd.Parameters.AddWithValue("Driver_ID", DriverNIC2);
                    AlredyExists = (int)cmd.ExecuteScalar() > 0;
                    con.Close();
                }
            }
        }

        #endregion

        // Delete Button Only Show admin

        #region Delete Button Show Event

        private void DeleteBTNShow()
        {
            UserRole = Login.Login.UserRole;

            if (UserRole == "Admin")
            {
                DriverDelete_btn.Visible = true;
            }

        }

        #endregion

        // Driver Data Delete Button

        #region Driver Data

        private void BookedDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query_delete = "DELETE FROM Drivers WHERE Driver_ID = '" + DriverNIC_txt.Text + "'";

                //SQL Command Set
                SqlCommand cmndD = new SqlCommand(query_delete, con);
                // Execution of the command
                cmndD.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Payment Sucesses.");

                tableLoad();
                TextBoxClear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error detected\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        #endregion

    }
}
