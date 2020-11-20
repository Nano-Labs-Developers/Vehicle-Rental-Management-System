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

namespace HotelTransportSystem.Hire_and_Rent.PayHire
{
    public partial class PayHire : UserControl
    {
        public PayHire()
        {
            InitializeComponent();
        }

        // This form variables

        #region Vars

        string CustomerNIC;
        string PaymentMethord;
        string TotalCharge;
        string CustomerPayment;
        string Balance;
        string VehicleRegNo;
        string TotalPayemnt;

        #endregion

        // Form Load event

        #region Form Load

        private void PayHire_Load(object sender, EventArgs e)
        {
            #region Check Rent or Hire

            string hireORrentform = "";

            if (String.IsNullOrEmpty(Rent.ImRent))
            {
                hireORrentform = Hire.ImHire;
            }
            else if (String.IsNullOrEmpty(Hire_and_Rent.Hire.ImHire))
            {
                hireORrentform = Rent.ImRent;
            }

            if (hireORrentform == "Rent")
            {
                // Pass Total Bill value
                TotalPayemnt = Rent.PaymentTransfer;
                PaymentTotalCharge_Pay_txt.Text = Rent.PaymentTransfer;
                PaymentCustomerNIC_txt.Text = Rent.CustomerNICTransfer;
                CarRegNo_txt.Text = Rent.VehicleRegNo;
            }
            else if (hireORrentform == "Hire")
            {
                // Pass Total Bill value
                TotalPayemnt = Hire.TotalPaymentLink;
                PaymentTotalCharge_Pay_txt.Text = Hire.TotalPaymentLink;
                PaymentCustomerNIC_txt.Text = Hire.CustomerNICTransferHire;
                CarRegNo_txt.Text = Hire.VehicleRegNo;
            }

            #endregion

        }

        #endregion

        // SQL Connection string

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        // Cancel Button

        #region Cancel Button

        private void PackageCancel_btn_Click(object sender, EventArgs e)
        {
            PaymentCheckBill_btn.Visible = false;
            PaymentPrintBill_btn.Visible = false;
            PaymentCancel_btn.Visible = false;
            PaymentPay_btn.Visible = false;
            PaymentClear_btn.Visible = false;

            PaymentBill_txt.Visible = false;

            Payment_groupBox.Visible = false;


            HotelTransportSystem.Hire_and_Rent.Hire uc = new HotelTransportSystem.Hire_and_Rent.Hire();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        // Check Bill button

        #region Check Bill

        private void CheckBill_btn_Click(object sender, EventArgs e)
        {
            PaymentBill_txt.Clear();

            if (PaymentTour_DropDown.selectedIndex == -1)
            {
                MessageBox.Show("Payment Methord not select.");
                return;
            }

            // Add text fields in customer bill
            PaymentBill_txt.Clear();

            PaymentBill_txt.Text += "________________________________________________________\n\n";
            PaymentBill_txt.Text += "                                           Ayubo Leisure (Pvt) Ltd                  \n";
            PaymentBill_txt.Text += "________________________________________________________\n";
            PaymentBill_txt.Text += "     Date: " + DateTime.Now + "\n\n";



            PaymentBill_txt.Text += "________________________________________________________\n\n";

            PaymentBill_txt.Text += "     Total Charge: Rs." + "       " + PaymentTotalCharge_Pay_txt.Text + "\n\n";
            PaymentBill_txt.Text += "     Paied: Rs." + "       " + Payment_txt.Text + "\n\n";

            double TotalCharge = double.Parse(TotalPayemnt);
            double Payment = double.Parse(Payment_txt.Text);

            if (Payment > TotalCharge)
            {
                double Balance = Payment - TotalCharge;

                PaymentBill_txt.Text += "Balance: Rs." + "       " + Balance + "\n";
                PaymentBalance_txt.Text = Balance.ToString();
                PaymentBill_txt.Text += "     Payment Methord: " + "       " + PaymentTour_DropDown.selectedValue + "\n\n";

            }
            else
            {
                PaymentBalance_txt.Text = "0";
            }

            PaymentBill_txt.Text += "________________________________________________________\n\n";
            PaymentBill_txt.Text += "**                            Thank you                            **\n";
            PaymentBill_txt.Text += "________________________________________________________\n\n";
            PaymentBill_txt.Text += "**           Developed by: Pasan Kalhara              **\n";
        }

        #endregion

        // Print bill button

        #region Print

        private void Bill_print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PaymentBill_txt.Text, new Font("Yu Gothic", 9), Brushes.Black, new Point(10, 10));
        }

        private void PrintBill_btn_Click(object sender, EventArgs e)
        {
            Bill_printPreviewDialog.Document = Bill_print;
            Bill_printPreviewDialog.ShowDialog();
        }

        #endregion

        // Pay button

        #region Pay Button

        private void PaymentPay_btn_Click(object sender, EventArgs e)
        {
            CustomerNIC = PaymentCustomerNIC_txt.Text;
            PaymentMethord = PaymentTour_DropDown.selectedValue.ToString();
            TotalCharge = PaymentTotalCharge_Pay_txt.Text;
            CustomerPayment = Payment_txt.Text;
            Balance = PaymentBalance_txt.Text;
            VehicleRegNo = CarRegNo_txt.Text;

            try
            {
                con.Open();
                string query_insert = "INSERT INTO Payment VALUES('" + CustomerNIC + "', '" + PaymentMethord + "', '" + TotalCharge + "', '" + CustomerPayment + "', '" + Balance + "')";

                // SQL Command Set
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                // Execution of the command
                cmnd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error detected\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

            try
            {
                con.Open();

                string query_delete = "DELETE FROM Booked WHERE BookeVehicle_RegNo = '" + VehicleRegNo + "'";

                //SQL Command Set
                SqlCommand cmndD = new SqlCommand(query_delete, con);
                // Execution of the command
                cmndD.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Payment Sucesses.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error detected\n\n" + ex);
            }
            finally
            {
                con.Close();
            }

            try
            {
                // SQL query
                string query_insert = "UPDATE Vehicles SET Vehicle_Available=@Vehicle_Available WHERE Vehicle_No = '" + CarRegNo_txt.Text + "'";

                // SQL Command
                SqlCommand cmnd = new SqlCommand(query_insert, con);


                cmnd.Parameters.AddWithValue("@Vehicle_Available", 1);

                con.Open();
                // Execution of the command
                cmnd.ExecuteNonQuery();
                // Successfull Message after the execution
                MessageBox.Show("Done");
                con.Close();
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
