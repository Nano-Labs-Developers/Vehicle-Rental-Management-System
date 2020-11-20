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

namespace HotelTransportSystem.Customer
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        #region Global Vars

        bool AlredyExists = false;
        string UserRole;
        int CustomerID;
        string Customer_TelNo;

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion       

        #region Form Load

        private void Customer_Load(object sender, EventArgs e)
        {            
            tableLoad();
            DeleteBTNShow();
        }

        #endregion

        #region Data List Button (Change Form Mode)

        private void CustomerDataListView_btn_Click(object sender, EventArgs e)
        {
            CustomerDataGrid.Visible = false;
            CustomerDataStandard_btn.Visible = false;
            CustomerDataListView_btn.Visible = false;
            Customer_groupBox.Visible = false;

            HotelTransportSystem.Customer.CustomerDataList uc = new CustomerDataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion
        
        #region Add New Button

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            try
            {
                AlredayExistNIC();

                if (AlredyExists)
                {
                    ErrorMessage.SetError(CustomerNIC_txt, "This customer has been exists.");
                }
                else
                {
                    InsertQuery();
                    tableLoad();
                }
            }
            catch (Exception ex)
            {
                // Error send
                MessageBox.Show("Error While Save" + ex);
            }
            finally
            {
                con.Close();
            }

            // Clear Auto Text Box Data
            //TextBoxClear();

        }

        #endregion

        #region Edit Button        

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            try
            {
                AlredayExistNIC();

                if (CustomerIDShow_lbl.Text != "")
                {
                    if (AlredyExists)
                    {
                        UpdateQuery();
                        tableLoad();
                    }
                    else
                    {
                        ErrorMessage.SetError(CustomerNIC_txt, "This customer has been not exists.");
                    }
                }
                else
                {
                    ErrorMessage.SetError(CustomerNIC_txt, "Invalied ID detected.");
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

        #region Clear Button

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearButton();
        }

        #endregion        

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Customers";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                CustomerDataGrid.DataSource = dt;
                con.Close();
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

        #region Search Button

        private void SearchBox_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("select * from Customers where Customer_NIC like '" + SearchBox_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                CustomerDataGrid.DataSource = dt;
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

        #region Update SQL Queue

        private void UpdateQuery()
        {
            CustomerID = int.Parse(CustomerIDShow_lbl.Text);
            Customer_TelNo = CustomerTelNo_txt.Text;

            // SQL query
            string query_insert = "UPDATE Customers SET Customer_Name=@Customer_Name, Customer_Address=@Customer_Address, Customer_TelNo=@Customer_TelNo WHERE Customer_ID = '" + CustomerID + "'";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);


            cmnd.Parameters.AddWithValue("@Customer_Name", CustomerName_txt.Text);
            cmnd.Parameters.AddWithValue("@Customer_Address", CustomerAddress_txt.Text);

            cmnd.Parameters.AddWithValue("@Customer_TelNo", Customer_TelNo);

            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            con.Close();
            MessageBox.Show("Done");
        }

        #endregion

        #region Insert SQL Queue

        private void InsertQuery()
        {
            string CustomerNIC = CustomerNIC_txt.Text;
            string Customer_TelNo = CustomerTelNo_txt.Text;

            // SQL query
            string query_insert = "INSERT INTO Customers VALUES('" + CustomerName_txt.Text + "','" + CustomerNIC + "','" + CustomerAddress_txt.Text + "','" + Customer_TelNo + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            con.Close();
            MessageBox.Show("Done");

        }
        
        #endregion

        #region Check if the Customer exists

        private void AlredayExistNIC()
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

        #region Data Grid View Clcik Event 

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (CustomerDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    CustomerDataGrid.CurrentRow.Selected = true;

                    //textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();

                    CustomerIDShow_lbl.Text = CustomerDataGrid.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();

                    CustomerName_txt.Text = CustomerDataGrid.Rows[e.RowIndex].Cells["Customer_Name"].FormattedValue.ToString();
                    CustomerNIC_txt.Text = CustomerDataGrid.Rows[e.RowIndex].Cells["Customer_NIC"].FormattedValue.ToString();

                    CustomerAddress_txt.Text = CustomerDataGrid.Rows[e.RowIndex].Cells["Customer_Address"].FormattedValue.ToString();
                    CustomerTelNo_txt.Text = CustomerDataGrid.Rows[e.RowIndex].Cells["Customer_TelNo"].FormattedValue.ToString();

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
                CustomerDelete_btn.Visible = true;
            }

        }

        #endregion

        #region Customer Data

        private void CustomerDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query_delete = "DELETE FROM Customers WHERE Customer_ID = '" + CustomerIDShow_lbl.Text + "'";

                //SQL Command Set
                SqlCommand cmndD = new SqlCommand(query_delete, con);
                // Execution of the command
                cmndD.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Payment Sucesses.");

                tableLoad();
                ClearButton();

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

        #region Clear Button

        private void ClearButton()
        {
            // Bunifu Text Boxes not support Clear Command

            CustomerName_txt.Text = "";
            CustomerNIC_txt.Text = "";
            CustomerAddress_txt.Text = "";
            CustomerTelNo_txt.Text = "";
        }

        #endregion

    }
}
