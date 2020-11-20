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

namespace HotelTransportSystem.Hire_and_Rent
{
    public partial class Hire : UserControl
    {
        public Hire()
        {
            InitializeComponent();
        }

        #region Main Variables

        public static string TotalPaymentLink; // for transfer data form anothor form
        public static string CustomerNICTransferHire; // for transfer data form anothor form NIC customer
        public static string ImHire; // Sent this form identity
        public static string VehicleRegNo; // Vehicle Reg No

        string PassedValueCustomerNIC;

        int MaximumKm;
        int MaximumHours;

        //double ReturnTime;
        //double ReturnKm;

        SqlMoney ExtraKmFee;
        SqlMoney WaitingFee;

        SqlMoney DriverFee;
        SqlMoney NightDriverFee;
        SqlMoney NightParkingFee;

        SqlMoney BaseCharge;
        SqlMoney TotalPayment;

        TimeSpan Total_Time;
        double Total_Km;

        #endregion

        #region Form Load || Drop Down Load

        private void Hire_Load(object sender, EventArgs e)
        {
            #region Form Load text box data

            BaseHireCharge_txt.Text = "0.00";
            HireWaitingCharge_txt.Text = "0.00";

            HireOverNightStayCharge_txt.Text = "0.00";
            HireExtraKmCharge_txt.Text = "0.00";

            HireTotalPayment_txt.Text = "0.00";

            #endregion

            // Check bill and auto enabled
            HireNext_btn.Enabled = false;

            // Customer NIC pass from Return Form
            PassedValueCustomerNIC = Return.Return.CustomerNICPassValue;
            BookedCustomerNIC_txt.Text = PassedValueCustomerNIC;

            TextBoxData();

            HireRetunDate_DateTimePicker.Value = DateTime.Now;

        }

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion
        
        #region Return_Calculation

        public void Return_Calculation()
        {
            #region Empty Check

            if (String.IsNullOrEmpty(CustomerName_txt.Text))
            {
                ErrorMessage.SetError(CustomerName_txt, "This field can't be empty.");
                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedTourType_txt.Text))
            {
                ErrorMessage.SetError(BookedTourType_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedPackage_txt.Text))
            {
                ErrorMessage.SetError(BookedPackage_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedVehicleTypes_txt.Text))
            {
                ErrorMessage.SetError(BookedVehicleTypes_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedVehicleModel_txt.Text))
            {
                ErrorMessage.SetError(BookedVehicleModel_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedVehicleRegNo_txt.Text))
            {
                ErrorMessage.SetError(BookedVehicleRegNo_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedStartingMilage_txt.Text))
            {
                ErrorMessage.SetError(BookedStartingMilage_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(HireEndingMilage_txt.Text))
            {
                ErrorMessage.SetError(HireEndingMilage_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BookedCustomerNIC_txt.Text))
            {
                ErrorMessage.SetError(BookedCustomerNIC_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(BaseHireCharge_txt.Text))
            {
                ErrorMessage.SetError(BaseHireCharge_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(HireWaitingCharge_txt.Text))
            {
                ErrorMessage.SetError(HireWaitingCharge_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(HireOverNightStayCharge_txt.Text))
            {
                ErrorMessage.SetError(HireOverNightStayCharge_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(HireExtraKmCharge_txt.Text))
            {
                ErrorMessage.SetError(HireExtraKmCharge_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            if (String.IsNullOrEmpty(HireTotalPayment_txt.Text))
            {
                ErrorMessage.SetError(HireTotalPayment_txt, "This field can't be empty.");

                return;
            }
            else
            {
                ErrorMessage.Clear();
            }

            #endregion

            Time_Calculation(); // Call Class Time

            int TotalTime = (int)Total_Time.TotalHours;
            Total_Km = double.Parse(HireEndingMilage_txt.Text) - double.Parse(BookedStartingMilage_txt.Text);

            PackageVehicleData();
                
            #region Main Algorithm

            TotalPayment = 0;


            // Count Total with base charge [Add base charge]
            TotalPayment = TotalPayment + BaseCharge;

            if (BookedTourType_txt.Text == "Day Tour")
            {
                if (TotalTime >= MaximumHours)
                {
                    TotalPayment += (WaitingFee * (TotalTime - MaximumHours));
                    HireTotalPayment_txt.Text = TotalPayment.ToString();
                }

            }

            else if (BookedTourType_txt.Text == "Long Tour")
            {
                HireWaitingCharge_txt.Enabled = false;

                TotalPayment += (NightDriverFee + NightParkingFee);
                HireTotalPayment_txt.Text = TotalPayment.ToString();

            }

            if (Total_Km > MaximumKm)
            {
                ExtraKmFee *= (int)(Total_Km - MaximumKm);
                HireExtraKmCharge_txt.Text = ExtraKmFee.ToString();
                TotalPayment = TotalPayment + ExtraKmFee;

                HireTotalPayment_txt.Text = TotalPayment.ToString();

            }


            #endregion
        }

        #endregion

        #region Check Bill Button

        private void CheckBill_btn_Click(object sender, EventArgs e)
        {
            Return_Calculation();

            HireNext_btn.Enabled = true;
        }

        #endregion

        #region Next Button

        private void Next_btn_Click(object sender, EventArgs e)
        {            
            TotalPaymentLink = HireTotalPayment_txt.Text; // Teleport Total Payments
            CustomerNICTransferHire = BookedCustomerNIC_txt.Text;
            ImHire = "Hire"; // Sent this form identity
            VehicleRegNo = BookedVehicleRegNo_txt.Text;

            ClearTextBox(); // Clear text box class

            // This user form items hide and show anothor user form
            SelectTypes_groupBox.Visible = false;
            SelectTypes_groupBox.Visible = false;

            HireClear_btn.Visible = false;
            HireCancel_btn.Visible = false;
            HireNext_btn.Visible = false;
            HireCheckBill_btn.Visible = false;

            PaymentDetails_groupbox.Visible = false;
            HiredDates_groupBox.Visible = false;

            PayHire.PayHire uc = new PayHire.PayHire();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        #region Clear Button

        private void ClearTextBox()
        {
            // Bunifu UI not support with Clear Command

            HireEndingMilage_txt.Text = "";

            BaseHireCharge_txt.Text = "0.00";
            HireWaitingCharge_txt.Text = "0.00";

            HireOverNightStayCharge_txt.Text = "0.00";
            HireExtraKmCharge_txt.Text = "0.00";

            HireTotalPayment_txt.Text = "0.00";
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            ClearTextBox();

            // Next button disable
            if (HireNext_btn.Enabled == true)
            {
                HireNext_btn.Enabled = false;
            }
        }

        #endregion

        #region Text Box Manager

        private void StartingMilage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && BookedStartingMilage_txt.Text.Contains("."))
            {
                // Stop more than one dot Char
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && BookedStartingMilage_txt.Text.Length == 0)
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

        private void EndingMilage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && HireEndingMilage_txt.Text.Contains("."))
            {
                // Stop more than one dot Char
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && HireEndingMilage_txt.Text.Length == 0)
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

        #region Textbox Fucntions

        private void TextBoxData()
        {
            #region Booked Data

            try
            {
                con.Open();

                // Booked Data
                string query_select_1 = "SELECT * FROM Booked WHERE Customer_NIC = '" + PassedValueCustomerNIC + "'";
                SqlCommand cmd_Package_1 = new SqlCommand(query_select_1, con);
                SqlDataReader DBR_1 = cmd_Package_1.ExecuteReader();

                if (DBR_1.HasRows)
                {
                    if (DBR_1.Read())
                    {                        
                        BookedTourType_txt.Text = DBR_1.GetValue(8).ToString();
                        BookedPackage_txt.Text = DBR_1.GetValue(1).ToString();
                                                
                        BookedStartingMilage_txt.Text = DBR_1.GetValue(4).ToString();                        
                        BookedStartDate_DateTimePicker.Value = Convert.ToDateTime(DBR_1.GetValue(3));
                        
                        BookedVehicleRegNo_txt.Text = DBR_1.GetValue(2).ToString();

                        if (Convert.ToInt32(DBR_1.GetValue(5)) == 1)
                        {
                            BookedWithDriver_checkbox.Checked = true;
                        }
                        else
                        {
                            BookedWithDriver_checkbox.Checked = false;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

            #endregion

            #region Customer Details

            try
            {
                con.Open();

                // Booked Data
                string query_select_1 = "SELECT * FROM Customers WHERE Customer_NIC = '" + PassedValueCustomerNIC + "'";
                SqlCommand cmd_Package_1 = new SqlCommand(query_select_1, con);
                SqlDataReader DBR_1 = cmd_Package_1.ExecuteReader();

                if (DBR_1.HasRows)
                {
                    if (DBR_1.Read())
                    {
                        CustomerName_txt.Text = DBR_1.GetValue(1).ToString();                       

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

            #endregion

            #region Vehicle Details

            try
            {
                con.Open();

                // Booked Data
                string query_select_1 = "SELECT * FROM Vehicles WHERE Vehicle_No = '" + BookedVehicleRegNo_txt.Text + "'";
                SqlCommand cmd_Package_1 = new SqlCommand(query_select_1, con);
                SqlDataReader DBR_1 = cmd_Package_1.ExecuteReader();

                if (DBR_1.HasRows)
                {
                    if (DBR_1.Read())
                    {
                        BookedVehicleTypes_txt.Text = DBR_1.GetValue(3).ToString();
                        BookedVehicleModel_txt.Text = DBR_1.GetValue(2).ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

            #endregion

        }

        #endregion

        #region Package and Vehicle Data

        private void PackageVehicleData()
        {
            #region Package

            try
            {
                con.Open();
                string query_select_Package = "SELECT Package_Maximum_Km, Package_Maximum_Hours, Extra_Km_Charge, Waiting_Charge, Driver_Overnight_Charge, Vehicle_Park_Charge, Driver_Charge FROM Package WHERE Package_Name = '" + BookedPackage_txt.Text + "'";
                SqlCommand cmd_Package = new SqlCommand(query_select_Package, con);
                cmd_Package.ExecuteNonQuery();

                SqlDataReader SDR;

                SDR = cmd_Package.ExecuteReader();
                if (SDR.HasRows)
                {
                    while (SDR.Read())
                    {
                        MaximumKm = SDR.GetInt32(0);
                        MaximumHours = SDR.GetInt32(1);

                        ExtraKmFee = SDR.GetSqlMoney(2);
                        WaitingFee = SDR.GetSqlMoney(3);

                        NightDriverFee = SDR.GetSqlMoney(4);
                        NightParkingFee = SDR.GetSqlMoney(5);

                        DriverFee = SDR.GetSqlMoney(6);

                        HireWaitingCharge_txt.Text = WaitingFee.ToString();
                        HireOverNightStayCharge_txt.Text = NightDriverFee.ToString();
                        HireExtraKmCharge_txt.Text = ExtraKmFee.ToString();

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

            #endregion

            #region Vehicle

            try
            {
                con.Open();

                string query_select_Vehicle = "SELECT Base_Charge FROM Vehicles WHERE Vehicle_Type = '" + BookedVehicleTypes_txt.Text + "'";
                SqlCommand cmd_Vehicle = new SqlCommand(query_select_Vehicle, con);
                cmd_Vehicle.ExecuteNonQuery();

                SqlDataReader SDR;

                SDR = cmd_Vehicle.ExecuteReader();
                if (SDR.HasRows)
                {
                    while (SDR.Read())
                    {
                        BaseCharge = SDR.GetSqlMoney(0);
                        BaseHireCharge_txt.Text = BaseCharge.ToString();

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

            #endregion

        }

        #endregion

        #region Class for Time Calculation

        public void Time_Calculation()
        {
            // Rented Date and Time
            DateTime TimeStartRent = BookedStartDate_DateTimePicker.Value.Date + BookedStartDate_DateTimePicker.Value.TimeOfDay;

            // Return Date and Time
            DateTime TimeReturnRent = HireRetunDate_DateTimePicker.Value.Date + HireRetunDate_DateTimePicker.Value.TimeOfDay;

            Total_Time = TimeReturnRent - TimeStartRent;
        }

        #endregion

    }

}
