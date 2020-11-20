using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace HotelTransportSystem.Hire_and_Rent
{
    public partial class Rent : UserControl
    {
        public Rent()
        {
            InitializeComponent();
        }

        #region Main Vars

        TimeSpan TotalRentDays;
        SqlMoney RateDay;
        SqlMoney RateWeek;
        SqlMoney RateMonth;
        SqlMoney DriverCharge;
        SqlMoney TotalPayment;

        int TM; // Total Months
        int TW; // Weeks

        int RDay; // Remaining Days
        int RDay2; // Remaining Days

        string TotalDays;

        public static string PaymentTransfer; // Transfer anothor from
        public static string CustomerNICTransfer; // Transfer Customer Details
        public static string ImRent; // Sent this form identity
        public static string VehicleRegNo; // Vehicle Reg No

        string PassedValueCustomerNIC;

        #endregion

        #region Form Load

        private void Rent_Load(object sender, EventArgs e)
        {
            // Customer NIC pass from Return Form
            PassedValueCustomerNIC = Return.Return.CustomerNICPassValue;
            RentCustomerNIC_txt.Text = Return.Return.CustomerNICPassValue;

            // Get Drop Down Vehicle Types Data
            VehicleDataLoad();
            VehicleDataLoad2();

        }

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        #region Main Class [All Here]

        #region Driver Cost Count

        private void DriverCharge_Class()
        {
            string select_query = "SELECT Driver_Charge FROM Package WHERE Package_ID = 1000;";

            try
            {
                con.Open();
                SqlCommand DriverCommands = new SqlCommand(select_query, con);
                SqlDataReader DDR = DriverCommands.ExecuteReader();
                if (DDR.HasRows)
                {
                    while (DDR.Read())
                    {
                        DriverCharge = DDR.GetSqlMoney(0);
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

            //  Driver Cost
            if (WithDriver_checkbox.Checked == true)
            {
                TotalPayment += DriverCharge * (Convert.ToInt32(RentedDays_txt.Text));
            }
        }

        #endregion

        #region Time analyzing

        private void TimeCounting()
        {
            DateTime ReturnedDate = RetunDate_DateTimePicker.Value;
            DateTime RentedDate = StartDate_DateTimePicker.Value;

            TotalRentDays = ReturnedDate - RentedDate;
            // Sent Data in to textbox
            TotalDays = TotalRentDays.Days.ToString(); // Calculation Null error fix
            RentedDays_txt.Text = TotalRentDays.Days.ToString();
        }

        #endregion

        #region Calculate Payment Functions

        private void CalculatePayment()
        {
            #region Get Data StartDate_DateTimePicker RetunDate_DateTimePicker

            try
            {
                string select_query = "SELECT Rate_for_Day, Rate_for_Week, Rate_for_Month FROM Vehicles";

                con.Open();

                SqlCommand CPF = new SqlCommand(select_query, con);
                SqlDataReader CPFReader = CPF.ExecuteReader();

                if (CPFReader.HasRows)
                {
                    while (CPFReader.Read())
                    {
                        RateDay = CPFReader.GetSqlMoney(0);
                        RateWeek = CPFReader.GetSqlMoney(1);
                        RateMonth = CPFReader.GetSqlMoney(2);
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

            #region Calculation Part

            // RD = Rented Days
            TotalPayment = 0;

            int TDays = int.Parse(TotalDays);            
            
            if (TDays >= 30)
            {
                if (TDays % 30 == 0) // Get Months
                {
                    TM = TDays / 30; // Ex: TDays = 60   =>   TM = TDays / 30   =>   TM = 2

                    TotalPayment += (RateMonth * TM);


                }
                else
                {
                    TM = TDays / 30; // Get Months
                    TotalPayment += (RateMonth * TM); // TotalPayment += (MonthlyRateVehicle * Months)

                    RDay = TDays - (TM * 30); // Get Days => RemainingDays = TotalDays - ( Months * 30 ) || For Months

                    if (RDay >= 7)
                    {
                        if (RDay % 7 == 0)
                        {
                            TW = RDay / 7; // Get Weeks
                            TotalPayment += (RateWeek * TW); // TotalPayment += (WeeklyRateVehicle * Weeks)


                        }
                        else
                        {
                            TW = RDay / 7; // Get Weeks
                            RDay2 = RDay - (TW * 7); // Get Days => RemainingDays2 = RemainingDays - ( Weeks * 7 ) || For Weeks


                        }

                    }
                    else
                    {
                        TotalPayment += RateDay * RDay;


                    }
                    
                }

            }
            else
            {
                if (TDays % 7 == 0)
                {
                    TW = TDays / 7; // Get Weeks
                    TotalPayment += (RateWeek * TW);


                }
                else
                {
                    TW = TDays / 7; // Get Weeks
                    RDay = TDays - (TW * 7); // Get Days => RemainingDays
                    TotalPayment += (RateWeek * TW) + (RateDay * RDay);


                }


            }

            #endregion

            #region Total Charge Count with Driver fee

            DriverCharge_Class();
            RentTotalPayment_txt.Text = TotalPayment.ToString();
            TotalPayment = 0;

            #endregion
        }

        #endregion

        #region vehicle data load

        private void VehicleDataLoad()
        {
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
                        //if (DBR_1.GetValue(5).ToString() == "Rent")
                        //{
                        Vehicle_RegNo_txt.Text = DBR_1.GetValue(2).ToString();
                        StartDate_DateTimePicker.Value = Convert.ToDateTime(DBR_1.GetValue(3));

                        if (Convert.ToInt32(DBR_1.GetValue(5)) == 1)
                        {
                            WithDriver_checkbox.Checked = true;
                        }
                        else
                        {
                            WithDriver_checkbox.Checked = false;
                        }

                        //}
                        /*
                        else
                        {
                            MessageBox.Show("Something went wrong.");
                        }*/
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

        }

        private void VehicleDataLoad2()
        {

            try
            {
                con.Open();

                // Vehicle Data
                string query_select_2 = "SELECT * FROM Vehicles WHERE Vehicle_No = '" + Vehicle_RegNo_txt.Text + "'";
                SqlCommand cmd_Package_2 = new SqlCommand(query_select_2, con);
                SqlDataReader DBR_2 = cmd_Package_2.ExecuteReader();

                if (DBR_2.Read())
                {
                    VehicleTypes_txt.Text = DBR_2.GetValue(1).ToString();
                    Vehicle_txt.Text = DBR_2.GetValue(3).ToString();
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
        }
        #endregion

        #endregion

        #region Clear Button

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            // Bunifu UI not supported clear command

            // Text Boxes
            RentedDays_txt.Text = "";
            RentCharge_txt.Text = "";

            // Driver [ON/OFF] Button
            if (WithDriver_checkbox.Checked == true)
            {
                WithDriver_checkbox.Checked = false;
            }
        }

        #endregion

        #region Next Button

        private void Next_btn_Click(object sender, EventArgs e)
        {
            // Add transaction vars
            PaymentTransfer = RentTotalPayment_txt.Text;
            CustomerNICTransfer = RentCustomerNIC_txt.Text;
            ImRent = "Rent";
            VehicleRegNo = Vehicle_RegNo_txt.Text;

            PaymentDetails_groupbox.Visible = false;
            SelectTypes_groupBox.Visible = false;

            RentClear_btn.Visible = false;
            RentCancel_btn.Visible = false;
            RentNext_btn.Visible = false;
            RentCheckBill_btn.Visible = false;

            HotelTransportSystem.Hire_and_Rent.PayHire.PayHire uc = new HotelTransportSystem.Hire_and_Rent.PayHire.PayHire();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        #region Text Box Manager

        private void CustomerTelNo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        #endregion

        #region Check Bill Button

        private void CheckBill_btn_Click(object sender, EventArgs e)
        {
            TimeCounting();
            CalculatePayment();
        }


        #endregion

    }
}
