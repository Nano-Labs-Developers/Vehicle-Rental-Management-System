using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.Return
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        #region Form Load Event || Table Load

        private void Return_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        #region Main Variables

        bool AlredyExists = false;

        string Customer_NIC_Search;

        string HireorRentRadioBTN;

        public static string Hire_or_Rent; // For value passing next form

        public static string CustomerNICPassValue; // For value passing next form

        #endregion

        #region Form Controller

        private void MainMenuClose_btn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
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

        #region Add new Button

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            #region text box empty check
            /*
            if (String.IsNullOrEmpty(CustomerName_txt.Text))
            {
                ErrorMessage.SetError(CustomerName_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerNIC_txt.Text))
            {
                ErrorMessage.SetError(CustomerNIC_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerAddress_txt.Text))
            {
                ErrorMessage.SetError(CustomerAddress_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerTelNo_txt.Text))
            {
                ErrorMessage.SetError(CustomerTelNo_txt, "This field cann't be empty.");
                return;
            }
            */
            #endregion

            #region Main Function
            /*
            long CustomerNIC = Convert.ToInt64(CustomerNIC_txt.Text);
            long Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            try
            {
                #region Check if the Customer exists

                // Check if the Customer_NIC exists
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Customers] where Customer_NIC = @Customer_NIC", con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("Customer_NIC", CustomerNIC_txt.Text);
                    AlredyExists = (int)cmd.ExecuteScalar() > 0;
                    con.Close();
                }

                #endregion

                if (AlredyExists)
                {
                    AlredyExistError.SetError(CustomerNIC_txt,"This NIC numbers is already exist.");

                    DialogResult dialogResult = MessageBox.Show("Are you sure", "Update Customer Details", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        #region Update SQL Queue

                        // SQL query
                        string query_update = "UPDATE Customers SET Customer_Name=@Customer_Name, Customer_NIC=@Customer_NIC, Customer_Address=@Customer_Address, Customer_TelNo=@Customer_TelNo";
                        // SQL Command
                        SqlCommand cmnd = new SqlCommand(query_update, con);

                        cmnd.Parameters.AddWithValue("@Customer_Name", CustomerName_txt.Text);
                        cmnd.Parameters.AddWithValue("@Customer_NIC", CustomerNIC);
                        cmnd.Parameters.AddWithValue("@Customer_Address", CustomerAddress_txt.Text);
                        cmnd.Parameters.AddWithValue("@Customer_TelNo", Customer_TelNo);

                        con.Open();
                        // Execution of the command
                        cmnd.ExecuteNonQuery();
                        // Successfull Message after the execution
                        MessageBox.Show("Done");

                        #endregion

                        ErrorMessage.Clear();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    
                }
                else
                {
                    #region Insert SQL Queue

                    // SQL query
                    string query_insert = "INSERT INTO Customers VALUES('" + CustomerName_txt.Text + "','" + CustomerNIC + "','" + CustomerAddress_txt.Text + "','" + Customer_TelNo + "')";

                    // SQL Command
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    con.Open();
                    // Execution of the command
                    cmnd.ExecuteNonQuery();
                    // Successfull Message after the execution
                    MessageBox.Show("Done");

                    #endregion
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
            */
            #endregion
        }

        #endregion

        #region Form Forward to Next Form [Class]

        public void ValuePass()
        {
            // else not used
            if (Hire_btn.Checked == true)
            {
                Hire_or_Rent = "Hire";
                CustomerNICPassValue = (CustomerNIC_txt.Text).ToString();

                ReturnPayUserController RPUC = new ReturnPayUserController();
                this.Hide();
                RPUC.Show();
            }

            else if (Rent_btn.Checked == true)
            {
                Hire_or_Rent = "Rent";
                CustomerNICPassValue = (CustomerNIC_txt.Text).ToString();

                ReturnPayUserController RPUC = new ReturnPayUserController();
                this.Hide();
                RPUC.Show();
            }
        }          

        #endregion

        #region Next Button

        private void Next_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            try
            {
                CustomerExist();

                if (AlredyExists)
                {                    
                    AlredyExistError.SetError(CustomerNIC_txt, "This NIC numbers is already exist.");

                    DialogResult dialogResult = MessageBox.Show("Are you sure", "Update Customer Details", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateQuery();
                        ErrorMessage.Clear();                        
                        ValuePass();
                        //ClearTextBox();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Search_txt.Text = CustomerNIC_txt.Text;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Customer Not found.");
                    return;

                    //InsertQuery();                    
                    //ClearTextBox();
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

        #region Text Box Manager [Text box can be insert only numbers]

        private void CustomerTelNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Clear Button

        private void ClearTextBox()
        {
            // Bunifu UI not supported clear command

            // Text Boxes
            CustomerName_txt.Text = "";
            CustomerNIC_txt.Text = "";
            CustomerAddress_txt.Text = "";
            CustomerTelNo_txt.Text = "";
        }

        private void Clear_btn_Click_1(object sender, EventArgs e)
        {
            // Bunifu UI not support Clear command
            ClearTextBox();
        }

        #endregion

        #region Textbox Empty Check

        private void TextboxEmptyCheck()
        {
            if (String.IsNullOrEmpty(CustomerName_txt.Text))
            {
                ErrorMessage.SetError(CustomerName_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerNIC_txt.Text))
            {
                ErrorMessage.SetError(CustomerNIC_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerAddress_txt.Text))
            {
                ErrorMessage.SetError(CustomerAddress_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(CustomerTelNo_txt.Text))
            {
                ErrorMessage.SetError(CustomerTelNo_txt, "This field cann't be empty.");
                return;
            }

        }

        #endregion

        #region Check Customer Exist

        private void CustomerExist()
        {
            // Check if the Customer_NIC exists
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Customers] where Customer_NIC = @Customer_NIC", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Customer_NIC", CustomerNIC_txt.Text);
                AlredyExists = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }

        }


        #endregion

        #region Insert Query

        private void InsertQuery()
        {
            long CustomerNIC = Convert.ToInt64(CustomerNIC_txt.Text);
            long Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            // SQL query
            string query_insert = "INSERT INTO Customers VALUES('" + CustomerName_txt.Text + "','" + CustomerNIC + "','" + CustomerAddress_txt.Text + "','" + Customer_TelNo + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            MessageBox.Show("Done");

        }

        #endregion

        #region Update Query

        private void UpdateQuery()
        {
            long CustomerNIC = Convert.ToInt64(CustomerNIC_txt.Text);
            long Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            // SQL query
            string query_update = "UPDATE Customers SET Customer_Name=@Customer_Name, Customer_NIC=@Customer_NIC, Customer_Address=@Customer_Address, Customer_TelNo=@Customer_TelNo";
            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_update, con);

            cmnd.Parameters.AddWithValue("@Customer_Name", CustomerName_txt.Text);
            cmnd.Parameters.AddWithValue("@Customer_NIC", CustomerNIC);
            cmnd.Parameters.AddWithValue("@Customer_Address", CustomerAddress_txt.Text);
            cmnd.Parameters.AddWithValue("@Customer_TelNo", Customer_TelNo);

            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            MessageBox.Show("Done");

        }

        #endregion

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Customer_NIC, Hire_or_Rent, BookeVehicle_RegNo FROM Booked";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Cell Click and Fill TextBox Event

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;

                    Customer_NIC_Search = dataGridView1.Rows[e.RowIndex].Cells["Customer_NIC"].FormattedValue.ToString();
                    HireorRentRadioBTN = dataGridView1.Rows[e.RowIndex].Cells["Hire_or_Rent"].FormattedValue.ToString();

                    CustomerNIC_txt.Text = Customer_NIC_Search;

                    if (HireorRentRadioBTN == "Hire")
                    {
                        Hire_btn.Checked = true;
                    }
                    else if (HireorRentRadioBTN == "Rent")
                    {
                        Rent_btn.Checked = true;
                    }


                    try
                    {
                        con.Open();

                        // Package Data DropDown Box
                        string query_select_2 = "SELECT * FROM Customers WHERE Customer_NIC = '" + Customer_NIC_Search + "'";
                        SqlCommand cmd_Package = new SqlCommand(query_select_2, con);
                        SqlDataReader DBR = cmd_Package.ExecuteReader();

                        if (DBR.Read())
                        {
                            CustomerName_txt.Text = DBR.GetValue(1).ToString();
                            CustomerAddress_txt.Text = DBR.GetValue(3).ToString();
                            CustomerTelNo_txt.Text = DBR.GetValue(4).ToString();
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Something went wrong.\n\n" + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
                
        }

        #endregion

        #region Search TextBox Function

        private void Search_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("select Customer_NIC, Hire_or_Rent, BookeVehicle_RegNo from Booked where Customer_NIC like '" + Search_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }            
        }

        #endregion

        #region Select Booking Tabel



        #endregion

        // Not working yet
        #region Fucntion for Next button Already Exist AI handler
        /*
        public void NextBtn_AlreadyExist_AIhandler()
        {
            string CustomerName = CustomerName_txt.Text;
            string CustomerNIC = CustomerNIC_txt.Text;
            string CustomerAddress = CustomerAddress_txt.Text;
            string CustomerTelNo = CustomerTelNo_txt.Text;

            string CustomerNameDT;
            long CustomerNICDT;
            string Customer_AddressDT;
            long Customer_TelNoDT;

            try
            {
                con.Open();
                string query_select = "SELECT Customer_Name, Customer_NIC, Customer_Address, Customer_TelNo FROM Customers WHERE Package_Name = '" + CustomerNIC + "'";
                SqlCommand cmd_Package = new SqlCommand(query_select, con);
                cmd_Package.ExecuteNonQuery();

                SqlDataReader SDR;

                SDR = cmd_Package.ExecuteReader();
                if (SDR.HasRows)
                {
                    while (SDR.Read())
                    {
                        CustomerNameDT = SDR.GetString(0);
                        CustomerNICDT = SDR.GetInt32(1);

                        Customer_AddressDT = SDR.GetString(2);
                        Customer_TelNoDT = SDR.GetInt32(3);
                    }
                }

                if (CustomerNameDT == CustomerName)
                {

                }

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
        */
        #endregion
        //want to fix
    }
}