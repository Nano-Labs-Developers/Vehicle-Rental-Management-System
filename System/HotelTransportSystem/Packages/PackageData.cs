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
using System.Data.SqlTypes;

namespace HotelTransportSystem.Packages
{
    public partial class PackageData : UserControl
    {
        public PackageData()
        {
            InitializeComponent();
        }

        // SQL Connection String

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion
        
        // this form variables

        #region Global Vars

        bool AlredyExists = false;
        bool AlredyExistIDs = false;
        string UserRole;

        #endregion

        // Form Load func

        #region Form Load

        private void PackageData_Load(object sender, EventArgs e)
        {
            
            tableLoad();
            
            DeleteBTNShow();
        }

        #endregion

        // Search Box func

        #region Search Box

        private void SearchBox_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Package WHERE Package_Name LIKE '" + SearchBox_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                PackageDataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        // Add button

        #region Add New Button

        private void AddNew_btn_Click(object sender, EventArgs e)
        {
            TextBoxEmptyCheck();

            try
            {
                AlredyExistName();

                if (AlredyExists)
                {
                    ErrorMessage.SetError(PackageName_txt, "This package has been exists.");
                }
                else
                {
                    InsertQuery();
                    tableLoad();
                    // Clear Auto Text Box Data
                    TextBoxClear();

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

        }

        #endregion

        // Edit Button

        #region Edit Button

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            TextBoxEmptyCheck();

            try
            {
                AlredyExistName();
                AlredyExistID();

                if (AlredyExistIDs)
                {
                    if (!AlredyExists)
                    {
                        UpdateQuery();
                        tableLoad();
                        TextBoxClear();
                    }
                    else
                    {
                        ErrorMessage.SetError(PackageName_txt, "This package has been exists.");
                    }
                }
                else
                {
                    ErrorMessage.SetError(PackageName_txt, "This package has been not exists.");
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

        // Clear Button Func

        #region Clear Button [Class]

        // Clear Button Class
        private void TextBoxClear()
        {
            // Bunifu UI not supported clear command
            PackageName_txt.Text = "";
            MaximumKm_txt.Text = "";

            MaximumHours_txt.Text = "";
            ExtraKmCharge_txt.Text = "";

            WaitingCharge_txt.Text = "";
            DriverOvernightCharge_txt.Text = "";

            VehicleParkCharge_txt.Text = "";
            DriverCharge_txt.Text = "";

            PackageIDShow_lbl.Text = "";
        }

        #endregion

        // Clear Button

        #region Clear Button

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        #endregion
        
        // table Load func

        #region Table Load Function

        private void tableLoad()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Package";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                PackageDataGrid.DataSource = dt;

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

        // Data grid view Cell click event

        #region Data Grid View Cell Click Event

        private void VehiclesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (PackageDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    PackageDataGrid.CurrentRow.Selected = true;

                    PackageIDShow_lbl.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Package_ID"].FormattedValue.ToString();
                    PackageName_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Package_Name"].FormattedValue.ToString();

                    MaximumKm_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Package_Maximum_Km"].FormattedValue.ToString();
                    MaximumHours_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Package_Maximum_Hours"].FormattedValue.ToString();

                    ExtraKmCharge_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Extra_Km_Charge"].FormattedValue.ToString();
                    WaitingCharge_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Waiting_Charge"].FormattedValue.ToString();

                    DriverOvernightCharge_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Driver_Overnight_Charge"].FormattedValue.ToString();
                    VehicleParkCharge_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Vehicle_Park_Charge"].FormattedValue.ToString();

                    DriverCharge_txt.Text = PackageDataGrid.Rows[e.RowIndex].Cells["Driver_Charge"].FormattedValue.ToString();

                }
            }
                
        }

        #endregion

        // Update SQL Query

        #region Insert SQL Queue

        private void InsertQuery()
        {
            long MaximumKm = Convert.ToInt64(MaximumKm_txt.Text);
            long MaximumHours = Convert.ToInt64(MaximumHours_txt.Text);

            SqlMoney ExtraKmCharge = SqlMoney.Parse(ExtraKmCharge_txt.Text);
            SqlMoney WaitingCharge = SqlMoney.Parse(WaitingCharge_txt.Text);

            SqlMoney DriverOvernightCharge = SqlMoney.Parse(DriverOvernightCharge_txt.Text);
            SqlMoney VehicleParkCharge = SqlMoney.Parse(VehicleParkCharge_txt.Text);

            SqlMoney DriverCharge = SqlMoney.Parse(DriverCharge_txt.Text);

            // ----------------------------------------------------------------------------------------------------------- //

            // SQL query
            string query_insert = "INSERT INTO Package VALUES('" + PackageName_txt.Text + "','" + MaximumKm + "','" + MaximumHours + "','" + ExtraKmCharge + "','" + WaitingCharge + "','" + DriverOvernightCharge + "','" + VehicleParkCharge + "','" + DriverCharge + "')";

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
        
        // Update SQL Query

        #region Update SQL Queue
        
        private void UpdateQuery()
        {
            long MaximumKm = Convert.ToInt64(MaximumKm_txt.Text);
            long MaximumHours = Convert.ToInt64(MaximumHours_txt.Text);

            SqlMoney ExtraKmCharge = SqlMoney.Parse(ExtraKmCharge_txt.Text);
            SqlMoney WaitingCharge = SqlMoney.Parse(WaitingCharge_txt.Text);

            SqlMoney DriverOvernightCharge = SqlMoney.Parse(DriverOvernightCharge_txt.Text);
            SqlMoney VehicleParkCharge = SqlMoney.Parse(VehicleParkCharge_txt.Text);

            SqlMoney DriverCharge = SqlMoney.Parse(DriverCharge_txt.Text);

            // ----------------------------------------------------------------------------------------- //

            // SQL query
            string query_insert = "UPDATE Package SET Package_Name=@Package_Name, Package_Maximum_Km=@Package_Maximum_Km, Package_Maximum_Hours=@Package_Maximum_Hours, Extra_Km_Charge=@Extra_Km_Charge, Waiting_Charge=@Waiting_Charge, Driver_Overnight_Charge=@Driver_Overnight_Charge, Vehicle_Park_Charge=@Vehicle_Park_Charge, Driver_Charge=@Driver_Charge WHERE Package_ID= '" + PackageIDShow_lbl.Text + "'";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);

            cmnd.Parameters.AddWithValue("@Package_Name", PackageName_txt.Text);
            cmnd.Parameters.AddWithValue("@Package_Maximum_Km", MaximumKm);

            cmnd.Parameters.AddWithValue("@Package_Maximum_Hours", MaximumHours);
            cmnd.Parameters.AddWithValue("@Extra_Km_Charge", ExtraKmCharge);

            cmnd.Parameters.AddWithValue("@Waiting_Charge", WaitingCharge);
            cmnd.Parameters.AddWithValue("@Driver_Overnight_Charge", DriverOvernightCharge);

            cmnd.Parameters.AddWithValue("@Vehicle_Park_Charge", VehicleParkCharge);
            cmnd.Parameters.AddWithValue("@Driver_Charge", DriverCharge);

            con.Open();
            // Execution of the command
            cmnd.ExecuteNonQuery();
            // Successfull Message after the execution
            con.Close();

            MessageBox.Show("Done");

        }
            
        #endregion
        
        // Check Package exist

        #region Check if the package exists
        
        private void AlredyExistName()
        {

            // Check exists
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Package] where Package_Name = @Package_Name", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Package_Name", PackageName_txt.Text);
                AlredyExists = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
            
        }

        private void AlredyExistID()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Package] where Package_ID = @Package_ID", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Package_ID", PackageIDShow_lbl.Text);
                AlredyExistIDs = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
        }
            
        #endregion
        
        // textbox empty check

        #region text box empty check
        
        private void TextBoxEmptyCheck()
        {

            if (String.IsNullOrEmpty(PackageName_txt.Text))
            {
                ErrorMessage.SetError(PackageName_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(MaximumKm_txt.Text))
            {
                ErrorMessage.SetError(MaximumKm_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(MaximumHours_txt.Text))
            {
                ErrorMessage.SetError(MaximumHours_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(ExtraKmCharge_txt.Text))
            {
                ErrorMessage.SetError(ExtraKmCharge_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(WaitingCharge_txt.Text))
            {
                ErrorMessage.SetError(WaitingCharge_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(DriverOvernightCharge_txt.Text))
            {
                ErrorMessage.SetError(DriverOvernightCharge_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(VehicleParkCharge_txt.Text))
            {
                ErrorMessage.SetError(VehicleParkCharge_txt, "This field cann't be empty.");
                return;
            }

            if (String.IsNullOrEmpty(DriverCharge_txt.Text))
            {
                ErrorMessage.SetError(DriverCharge_txt, "This field cann't be empty.");
                return;
            }

        }

        #endregion

        // List Button

        #region List Button

        private void VehiclesDataListView_btn_Click(object sender, EventArgs e)
        {
            Package_groupBox.Hide();
            VehiclesDataStandard_btn.Hide();
            VehiclesDataListView_btn.Hide();
            SearchBox_txt.Hide();
            PackageDataGrid.Hide();
            if (PackageDelete_btn.Visible == true)
            {
                PackageDelete_btn.Visible = false;
            }

            PackageDataList uc = new PackageDataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        // Delete Button Only Show admin

        #region Delete Button Show Event

        private void DeleteBTNShow()
        {
            UserRole = Login.Login.UserRole;

            if (UserRole == "Admin")
            {
                PackageDelete_btn.Visible = true;
            }

        }

        #endregion

        //Package Data Delete Button

        #region Package Delete button

        private void PackageDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query_delete = "DELETE FROM Package WHERE Package_ID = '" + PackageIDShow_lbl.Text + "'";

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
