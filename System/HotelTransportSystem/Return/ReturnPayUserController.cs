using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.Return
{
    public partial class ReturnPayUserController : Form
    {
        public ReturnPayUserController()
        {
            InitializeComponent();
        }

        #region Form Controller

        private void MainMenuMinimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void MainMenuClose_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure cancel payment", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }            
        }

        #endregion

        #region Form Load and Hire / Rent Controller

        private void ReturnPayUserController_Load(object sender, EventArgs e)
        {
            if (Return.Hire_or_Rent == "Hire")
            {
                hire1.BringToFront();
            }
            else if (Return.Hire_or_Rent == "Rent")
            {
                rent1.BringToFront();
            }
        }

        #endregion
    }
}
