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

namespace HotelTransportSystem.Vehicles
{
    public partial class VehicleDataList : UserControl
    {
        public VehicleDataList()
        {
            InitializeComponent();
        }

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        #region Form Load

        private void VehicleDataList_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #endregion

        #region Open anothor form [Vehicles Data Standard]

        private void VehiclesDataStandard_btn_Click(object sender, EventArgs e)
        {
            VehiclesDataGrid.Visible = false;
            VehiclesDataStandard_btn.Visible = false;
            VehiclesDataListView_btn.Visible = false;

            HotelTransportSystem.Vehicles.VehicleData uc = new VehicleData();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
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

        #region Search Button

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
    }
}
