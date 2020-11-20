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

namespace HotelTransportSystem.Hire_and_Rent
{
    public partial class Boocking : UserControl
    {
        public Boocking()
        {
            InitializeComponent();
        }

        // Form Load Event

        #region Form Loading

        private void Boocking_Load(object sender, EventArgs e)
        {
            VehicleType();
            PackageData();

            BookingStartDate_DateTimePicker.Value = DateTime.Now;
        }

        #endregion

        // SQL Connection String

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion
        
        // This form variables

        #region Vars

        string TourType;
        string Package;
        string Vehicle_RegNo;

        DateTime Starting_Time;
        long Starting_Milage;

        string Customer_Name;
        string Customer_NIC;
        string Customer_Address;
        long Customer_TelNo;

        string Hire_or_RentData; // Not detected

        int WithDriver; // Not detected

        bool AlredyExists = false;

        int Vehicle_AVailableChange;

        #endregion

        // Radio Button Functions

        #region Radio Button Functions [Hire or Rent]

        private void BookingRent_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (BookingRent_btn.Checked == true)
            {
                if (WithDriver_checkbox.Enabled == false)
                {
                    WithDriver_checkbox.Enabled = true;
                    WithDriver_checkbox.Checked = true;
                }

                if (BookingTourType_DropDown.Enabled == true)
                {
                    BookingTourType_DropDown.Enabled = false;
                }

                if (BookingPackages_DropDown.Enabled == true)
                {
                    BookingPackages_DropDown.Enabled = false;
                }
            }

        }

        private void BookingHire_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (BookingHire_btn.Checked == true)
            {
                if (WithDriver_checkbox.Enabled == true)
                {
                    WithDriver_checkbox.Enabled = false;
                    WithDriver_checkbox.Checked = true;
                }

                if (BookingTourType_DropDown.Enabled == true)
                {
                    BookingTourType_DropDown.Enabled = true;
                }

                if (BookingPackages_DropDown.Enabled == true)
                {
                    BookingPackages_DropDown.Enabled = true;
                }
            }
        }

        #endregion

        // Vehicle Drop Box [ Vehicle Modle | vehcile Available Drop Down Boxes ]

        #region Vehicle Drop Boxes Connecting to DB

        private void BookingVehicleTypes_DropDown_onItemSelected(object sender, EventArgs e)
        {
            BookingAvailableVehicles_txt.selectedIndex = -1;
            BookingVehicle_DropDown.selectedIndex = -1;

            BookingVehicle_DropDown.Items.Clear();
            BookingAvailableVehicles_txt.Items.Clear();

            string SVT; // SelectedVehicleType
            SVT = BookingVehicleTypes_DropDown.selectedValue;

            try
            {
                #region Select Query

                string query_select = "SELECT Vehicle_Model FROM Vehicles WHERE Vehicle_Type = '" + SVT + "'";

                con.Open();

                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader DBReader = cmd.ExecuteReader();

                if (DBReader.HasRows)
                {
                    while (DBReader.Read())
                    {
                        string Vehicle_Types = DBReader.GetString(0).ToString();
                        BookingVehicle_DropDown.Items.Add(Vehicle_Types);
                    }
                }

                #endregion

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

        private void BookingVehicle_DropDown_onItemSelected(object sender, EventArgs e)
        {
            BookingAvailableVehicles_txt.Items.Clear();

            string SVM; // SelectedVehicleModel
            SVM = BookingVehicle_DropDown.selectedValue;

            try
            {
                #region Select Query

                string query_select = "SELECT Vehicle_No FROM Vehicles WHERE Vehicle_Model = '" + SVM + "' AND  Vehicle_Available = '1' ";

                con.Open();

                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader DBReader = cmd.ExecuteReader();

                if (DBReader.HasRows)
                {
                    while (DBReader.Read())
                    {
                        string Vehicle_RegNos = DBReader.GetString(0).ToString();
                        BookingAvailableVehicles_txt.Items.Add(Vehicle_RegNos);
                    }
                }

                #endregion

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

        // Vehicle Drop Box [ Vehicle Type Drop Down Box ]

        #region Vehicle Data DropDown box [Vehicle_Type]

        private void VehicleType()
        {

            try
            {
                con.Open();

                // Vehicle Data DropDown box
                string query_select = "SELECT DISTINCT Vehicle_Type FROM Vehicles";
                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader DBReader = cmd.ExecuteReader();

                if (DBReader.HasRows)
                {
                    while (DBReader.Read())
                    {
                        string Vehicle_Types = DBReader.GetString(0).ToString();
                        BookingVehicleTypes_DropDown.Items.Add(Vehicle_Types);
                    }
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


        #endregion

        // Package Drop Down Box Data load

        #region Package Data DropDown

        private void PackageData()
        {

            try
            {
                con.Open();

                // Package Data DropDown Box
                string query_select_2 = "SELECT DISTINCT Package_Name FROM Package";
                SqlCommand cmd_Package = new SqlCommand(query_select_2, con);
                SqlDataReader DBReader2 = cmd_Package.ExecuteReader();

                if (DBReader2.HasRows)
                {
                    while (DBReader2.Read())
                    {
                        string Package_Types = DBReader2.GetString(0).ToString();
                        BookingPackages_DropDown.Items.Add(Package_Types);
                    }
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

        #endregion

        // Booking button func

        #region Booking Button

        private void Book_btn_Click(object sender, EventArgs e)
        {
            #region Empty Check [Class sometime get buged]

            // Customer NIC
            if (String.IsNullOrEmpty(CustomerNIC_txt.Text))
            {
                ErrorMessage.SetError(CustomerNIC_txt, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            // Customer Name
            if (String.IsNullOrEmpty(CustomerName_txt.Text))
            {
                ErrorMessage.SetError(CustomerName_txt, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            // Date and time
            if (String.IsNullOrEmpty(BookingStartDate_DateTimePicker.Value.ToString()))
            {
                ErrorMessage.SetError(CustomerTelNo_txt, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            // Starting Milage
            if (String.IsNullOrEmpty(BookingStartingMilage_txt.Text))
            {
                ErrorMessage.SetError(BookingStartingMilage_txt, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (BookingRent_btn.Checked == false)
            {
                // Tour DropDown
                if (BookingTourType_DropDown.selectedIndex == -1)
                {
                    ErrorMessage.SetError(BookingTourType_DropDown, "This field cann't be empty.");
                    return;
                }
                else
                {
                    ErrorMessage.Clear();
                }
                                    
                // Package DropDown
                if (BookingPackages_DropDown.selectedIndex == -1)
                {
                    ErrorMessage.SetError(BookingPackages_DropDown, "This field cann't be empty.");
                    return;
                }
                else
                {
                    ErrorMessage.Clear();
                }

            }

            // Vehicle Type
            if (BookingVehicleTypes_DropDown.selectedIndex == -1)
            {
                ErrorMessage.SetError(BookingVehicleTypes_DropDown, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            // Vehicle Model
            if (BookingVehicle_DropDown.selectedIndex == -1)
            {
                ErrorMessage.SetError(BookingVehicle_DropDown, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            // Vehicle Reg No || Available
            if (BookingAvailableVehicles_txt.selectedIndex == -1)
            {
                ErrorMessage.SetError(BookingAvailableVehicles_txt, "This field cann't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            #endregion

            // For Easy to find and Data entry
            #region Var Defined

            if (BookingRent_btn.Checked == false)
            {
                TourType = BookingTourType_DropDown.selectedValue;
                Package = BookingPackages_DropDown.selectedValue;
            }
            else
            {
                TourType = "";
                Package = "";
            }

            Vehicle_RegNo = BookingAvailableVehicles_txt.selectedValue;

            Starting_Time = BookingStartDate_DateTimePicker.Value.Date;
            Starting_Milage = Convert.ToInt64(BookingStartingMilage_txt.Text);

            Customer_Name = CustomerName_txt.Text;
            Customer_NIC = CustomerNIC_txt.Text;
            Customer_Address = CustomerAddress_txt.Text;
            Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            #endregion

            #region Main Function

            try
            {
                AlredayExistNIC();

                con.Open();
                
                InsertQueryBooking(); // Insert Booking data in to DB
                UpadateQueryVehicleAvailable(); // Change vehicle now not available

                if (!AlredyExists) // Alredy Exist
                {
                    InsertQueryCustomer(); // Insert Customer

                }
                else
                {
                    UpadateQueryCustomer(); // Update Customer
                }

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }

            #endregion

        }

        #endregion



        // ------------------- SQL Querys ---------------------------- //

        // Booking (Table) Insert Query

        #region Insert SQL Query [Booking]

        private void InsertQueryBooking()
        {
            #region Data Build

            if (BookingRent_btn.Checked == false)
            {
                TourType = BookingTourType_DropDown.selectedValue;
                Package = BookingPackages_DropDown.selectedValue;
            }
            else
            {
                TourType = "";
                Package = "";
            }

            Vehicle_RegNo = BookingAvailableVehicles_txt.selectedValue;

            Starting_Time = BookingStartDate_DateTimePicker.Value.Date;
            Starting_Milage = Convert.ToInt64(BookingStartingMilage_txt.Text);

            Customer_NIC = CustomerNIC_txt.Text;

            if (BookingHire_btn.Checked == true)
            {
                Hire_or_RentData = "Hire";
            }
            else
            {
                Hire_or_RentData = "Rent";
            }

            if (BookingHire_btn.Checked == true)
            {
                WithDriver = 1; // With Driver = 1
            }
            else
            {
                WithDriver = 0; // WithOut Driver = 0
            }

            #endregion

            // SQL query
            string query_insert = "INSERT INTO Booked VALUES('" + Package + "','" + Vehicle_RegNo + "','" + Starting_Time + "','" + Starting_Milage + "','" + WithDriver + "','" + Hire_or_RentData + "','" + Customer_NIC + "','" + TourType + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            // Execution of the command
            cmnd.ExecuteNonQuery();     

        }

        #endregion

        // Customer Data Insert Query

        #region Insert SQL Query [Customer]

        private void InsertQueryCustomer()
        {
            // Easy to find and data entriy
            Customer_Name = CustomerName_txt.Text;
            Customer_NIC = CustomerNIC_txt.Text;
            Customer_Address = CustomerAddress_txt.Text;
            Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            // SQL query
            string query_insert = "INSERT INTO Customers VALUES('" + Customer_Name + "','" + Customer_NIC + "','" + Customer_Address + "','" + Customer_TelNo + "')";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);
            // Execution of the command
            cmnd.ExecuteNonQuery();

        }

        #endregion

        // Customer Data Update Query

        #region Update SQL Queue [Customer]

        private void UpadateQueryCustomer()
        {
            // Easy to find and data entriy
            Customer_Name = CustomerName_txt.Text;
            Customer_NIC = CustomerNIC_txt.Text;
            Customer_Address = CustomerAddress_txt.Text;
            Customer_TelNo = Convert.ToInt64(CustomerTelNo_txt.Text);

            // SQL query
            string query_insert = "UPDATE Customers SET Customer_Name=@Customer_Name, Customer_Address=@Customer_Address, Customer_TelNo=@Customer_TelNo WHERE Customer_NIC = '" + Customer_NIC + "'";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);


            cmnd.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            cmnd.Parameters.AddWithValue("@Customer_Address", Customer_Address);

            cmnd.Parameters.AddWithValue("@Customer_TelNo", Customer_TelNo);

            // Execution of the command
            cmnd.ExecuteNonQuery();
        }

        #endregion

        // Set vehicle is not available SQL QUERY

        #region Change Available Vehicle

        private void UpadateQueryVehicleAvailable()
        {
            // Easy to find and data entriy
            Vehicle_RegNo = BookingAvailableVehicles_txt.selectedValue.ToString();
            Vehicle_AVailableChange = 0;

            // SQL query
            string query_insert = "UPDATE Vehicles SET Vehicle_Available=@Vehicle_Available WHERE Vehicle_No = '" + Vehicle_RegNo + "'";

            // SQL Command
            SqlCommand cmnd = new SqlCommand(query_insert, con);


            cmnd.Parameters.AddWithValue("@Vehicle_Available", Vehicle_AVailableChange);

            // Execution of the command
            cmnd.ExecuteNonQuery();
        }

        #endregion


        // ------------------- SQL Querys ---------------------------- //



        // Check customer is already exist

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

        // Text Box handler (Numbers only)

        // [ Milage textbox ]

        #region Milage TextBox Numbers only Handler

        private void BookingStartingMilage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && BookingStartingMilage_txt.Text.Contains("."))
            {
                // Stop more than one dot Char
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && BookingStartingMilage_txt.Text.Length == 0)
            {
                // Stop first char as a dot input
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Stop allow other than digit and control
                e.Handled = true;
            }
        }

        #endregion

        // [Customer telno textbox]

        #region Customer Tel No number handler

        private void CustomerTelNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

    }

}