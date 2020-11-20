using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HotelTransportSystem.Vehicles
{
    public partial class VehicleData : UserControl
    {
        public VehicleData()
        {
            InitializeComponent();
        }

        #region Global Vars

        bool AlredyExistsID = false;
        bool AlredyExistsRegNo = false;
        string UserRole;

        #endregion

        #region Form Load

        private void VehicleData_Load(object sender, EventArgs e)
        {
            tableLoad();
            DeleteBTNShow();
        }

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        #region Vehicle Data List Button (Change Form Mode)

        private void VehicleDataList_btn_Click(object sender, EventArgs e)
        {
            VehiclesDataGrid.Visible = false;
            VehiclesDataStandard_btn.Visible = false;
            VehiclesDataListView_btn.Visible = false;
            Vehicle_groupBox.Visible = false;
            SearchBox_txt.Visible = false;

            HotelTransportSystem.Vehicles.VehicleDataList uc = new VehicleDataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        #region Add New Button

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            #region Main Function

            try
            {
                AlredayExistID();
                AlredyExistRegNo();

                if (AlredyExistsRegNo)
                {
                    ErrorMessage.SetError(VehicleNo_txt, "This vehicle has been exists.");
                    return;
                }
                else
                {
                    InsertQuery();
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

            #endregion
        }

        #endregion

        #region Edit Button

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            TextboxEmptyCheck();

            #region Main Function

            try
            {
                AlredayExistID();
                AlredyExistRegNo();

                if (VehicleIDShow_lbl.Text != "")
                {
                    if (!AlredyExistsID)
                    {
                        UpdateQuery();
                    }
                    else
                    {
                        ErrorMessage.SetError(VehicleNo_txt, "This vehicle has been not exists.");
                        return;
                    }
                }
                else
                {
                    ErrorMessage.SetError(VehicleNo_txt, "Ivalied ID detected.");
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

            #endregion
        }

        #endregion

        #region Clear Button

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearButtonClass();
        }

        #endregion

        #region Data Grid View Search

        private void SearchBox_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("select * from Vehicles where Vehicle_Type like '" + SearchBox_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                VehiclesDataGrid.DataSource = dt;
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

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Vehicles";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                VehiclesDataGrid.DataSource = dt;
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

        #region Data Grid View Clcik Event 

        private void VehiclesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (VehiclesDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    VehiclesDataGrid.CurrentRow.Selected = true;

                    //textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells["Customer_ID"].FormattedValue.ToString();

                    VehicleIDShow_lbl.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Vehicle_ID"].FormattedValue.ToString();

                    VehicleNo_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Vehicle_No"].FormattedValue.ToString();
                    VehicleModel_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Vehicle_Model"].FormattedValue.ToString();

                    VehicleType_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Vehicle_Type"].FormattedValue.ToString();
                    BaseCharge_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Base_Charge"].FormattedValue.ToString();

                    RateforDay_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Rate_for_Day"].FormattedValue.ToString();
                    RateforWeek_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Rate_for_Week"].FormattedValue.ToString();

                    RateforMonth_txt.Text = VehiclesDataGrid.Rows[e.RowIndex].Cells["Rate_for_Month"].FormattedValue.ToString();
                    string VehicleAvailable = VehiclesDataGrid.Rows[e.RowIndex].Cells["Vehicle_Available"].FormattedValue.ToString();

                    int VehicleAvailableInt = Convert.ToInt32(VehicleAvailable);

                    if (VehicleAvailableInt == 0)
                    {
                        if (VehicleAvailable_CheckBox.Checked == true)
                        {
                            VehicleAvailable_CheckBox.Checked = false;
                        }
                    }
                    else if (VehicleAvailableInt == 1)
                    {
                        if (VehicleAvailable_CheckBox.Checked == false)
                        {
                            VehicleAvailable_CheckBox.Checked = true;
                        }
                    }
                }
            }
                
        }

        #endregion

        #region Check if the Vehicle exists

        // Vehicle_ID
        private void AlredayExistID()
        {
            // Check if the Vehicle Reg.No exists
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Vehicles] where Vehicle_ID = @Vehicle_ID", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Vehicle_ID", VehicleIDShow_lbl.Text);
                AlredyExistsID = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }

        }

        // Vehicle_No
        private void AlredyExistRegNo()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Vehicles] where Vehicle_No = @Vehicle_No", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Vehicle_No", VehicleNo_txt.Text);
                AlredyExistsRegNo = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }

        }

        #endregion

        #region Update SQL Query

        private void UpdateQuery()
        {
            int VehicleAvailable;

            if (VehicleAvailable_CheckBox.Checked == true)
            {
                VehicleAvailable = 1;
            }
            else
            {
                VehicleAvailable = 0;
            }

            long BaseCharge = Convert.ToInt64(BaseCharge_txt.Text);
            long RateforDay = Convert.ToInt64(RateforDay_txt.Text);
            long RateforWeek = Convert.ToInt64(RateforWeek_txt.Text);
            long RateforMonth = Convert.ToInt64(RateforMonth_txt.Text);

            // SQL query
            string query_update = "INSERT INTO Vehicles VALUES('" + VehicleNo_txt.Text + "','" + VehicleModel_txt.Text + "','" + VehicleType_txt.Text + "','" + BaseCharge + "','" + RateforDay + "','" + RateforWeek + "','" + RateforMonth + "','" + VehicleAvailable + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_update, con);
            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            con.Close();
            // Successfull Message after the execution
            MessageBox.Show("Done");
        }

        #endregion

        #region Insert SQL Queue
        
        private void InsertQuery()
        {
            int VehicleAvailable;

            if (VehicleAvailable_CheckBox.Checked == true)
            {
                VehicleAvailable = 1;
            }
            else
            {
                VehicleAvailable = 0;
            }

            long BaseCharge = Convert.ToInt64(BaseCharge_txt.Text);
            long RateforDay = Convert.ToInt64(RateforDay_txt.Text);
            long RateforWeek = Convert.ToInt64(RateforWeek_txt.Text);
            long RateforMonth = Convert.ToInt64(RateforMonth_txt.Text);

            // SQL query
            string query_insert = "INSERT INTO Vehicles VALUES('" + VehicleNo_txt.Text + "','" + VehicleModel_txt.Text + "','" + VehicleType_txt.Text + "','" + BaseCharge + "','" + RateforDay + "','" + RateforWeek + "','" + RateforMonth + "','" + VehicleAvailable + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            con.Close();
            // Successfull Message after the execution
            MessageBox.Show("Done");

        }

        #endregion

        #region Textbox Empty Check

        private void TextboxEmptyCheck()
        {
            if (String.IsNullOrEmpty(VehicleNo_txt.Text))
            {
                ErrorMessage.SetError(VehicleNo_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(VehicleModel_txt.Text))
            {
                ErrorMessage.SetError(VehicleModel_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(VehicleType_txt.Text))
            {
                ErrorMessage.SetError(VehicleType_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(BaseCharge_txt.Text))
            {
                ErrorMessage.SetError(BaseCharge_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(RateforDay_txt.Text))
            {
                ErrorMessage.SetError(RateforDay_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(RateforWeek_txt.Text))
            {
                ErrorMessage.SetError(RateforWeek_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(RateforMonth_txt.Text))
            {
                ErrorMessage.SetError(RateforMonth_txt, "This field cann't be empty.");
                return;
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
                VehicleDelete_btn.Visible = true;
            }

        }

        #endregion

        #region Delete Button Func

        private void VehicleDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query_delete = "DELETE FROM Vehicles WHERE Vehicle_ID = '" + VehicleNo_txt.Text + "'";

                //SQL Command Set
                SqlCommand cmndD = new SqlCommand(query_delete, con);
                // Execution of the command
                cmndD.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Payment Sucesses.");

                tableLoad();
                ClearButtonClass();

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

        #region Clear button

        private void ClearButtonClass()
        {
            // Bunifu Text Boxes not support Clear Command

            VehicleNo_txt.Text = "";
            VehicleModel_txt.Text = "";
            VehicleType_txt.Text = "";
            BaseCharge_txt.Text = "";
            RateforDay_txt.Text = "";
            RateforWeek_txt.Text = "";
            RateforMonth_txt.Text = "";
            VehicleIDShow_lbl.Text = "";

            // Check Box Reset Defalt
            if (VehicleAvailable_CheckBox.Checked == true)
            {
                VehicleAvailable_CheckBox.Checked = false;
            }

        }

        #endregion

    }
}
