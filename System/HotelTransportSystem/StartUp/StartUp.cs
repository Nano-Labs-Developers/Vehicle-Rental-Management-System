using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelTransportSystem.StartUp
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        int move;

        private void StartUp_Load(object sender, EventArgs e)
        {
            SidePanel_timer.Start();
        }

        private void SidePanel_timer_Tick(object sender, EventArgs e)
        {
            SideScroll_panel.Width += 2;

            if (SideScroll_panel.Width > 372)
            {
                SideScroll_panel.Width = 0;
            }

            if (SideScroll_panel.Width > 0)
            {
                move = 2;
            }
        }        
    }
}
