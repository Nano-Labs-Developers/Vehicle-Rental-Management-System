using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.Login
{
    public partial class Forgot_Password : Form
    {
        protected string OTPCode;
        public static string to;

        public Forgot_Password()
        {
            InitializeComponent();
        }

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        protected void OPTSend_btn_Click(object sender, EventArgs e)
        {
            String from;
            String pass;
            String messageBody;
            bool AlredyExists;

            if (String.IsNullOrEmpty(ForgotEmail_txt.Text))
            {
                ErrorMessage.SetError(ForgotEmail_txt, "Enter Email First.");
                return;
            }
            #region Editor S
            from = "example@gmail.com";
            pass = "example";
            #endregion
            // Check exists
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Login] WHERE Email = @Email", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("Email", ForgotEmail_txt.Text);
                AlredyExists = (int)cmd.ExecuteScalar() > 0;
                con.Close();
            }
            if (AlredyExists)
            {
                ErrorMessage.SetError(Verify_btn, "Email not found.");
                return;
            }
            Random random = new Random();
            OTPCode = (random.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (ForgotEmail_txt.Text).ToString();
            
            messageBody = "Your Reset OTP code is " + OTPCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "No Reply";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                SuccessMessage.SetError(Verify_btn, "Code Send Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        protected void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        protected void Verify_btn_Click(object sender, EventArgs e)
        {
            if (OTPCode == (OTPCode_txt.Text).ToString())
            {
                to = ForgotEmail_txt.Text;
                this.Hide();
                ResetPassword obj = new ResetPassword();
                obj.Show();
            }
            else
            {
                ErrorMessage.SetError(Verify_btn, "Invalid Code.");
            }

        }
    }
}
