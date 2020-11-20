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
    public partial class PayRent : UserControl
    {
        public PayRent()
        {
            InitializeComponent();
        }

        #region Cancel Button

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            // Form Icons Hide
            Cancel_btn.Visible = false;
            Pay_btn.Visible = false;
            Clear_btn.Visible = false;
            PrintBill_btn.Visible = false;
            CheckBill_btn.Visible = false;
            Payment_groupBox.Visible = false;
            Bill_txt.Visible = false;


            HotelTransportSystem.Hire_and_Rent.Rent uc = new HotelTransportSystem.Hire_and_Rent.Rent();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion
    }
}
