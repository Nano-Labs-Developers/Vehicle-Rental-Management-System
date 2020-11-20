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

namespace HotelTransportSystem.Packages
{
    public partial class PackageDataList : UserControl
    {
        public PackageDataList()
        {
            InitializeComponent();
        }

        private void PackageDataList_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

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
                PackageDataGridList.DataSource = dt;
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

        #region SearchBox Txt

        private void SearchBoxList_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Package WHERE Package_Name LIKE '" + SearchBoxList_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                PackageDataGridList.DataSource = dt;
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

        #region Stanard Button

        private void VehiclesDataStandardList_btn_Click(object sender, EventArgs e)
        {
            VehiclesDataStandardList_btn.Hide();
            VehiclesDataListViewList_btn.Hide();
            SearchBoxList_txt.Hide();
            PackageDataGridList.Hide();

            PackageData uc = new PackageData();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion
    }
}
