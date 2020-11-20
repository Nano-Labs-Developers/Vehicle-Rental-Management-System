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

namespace HotelTransportSystem.Booked
{
    public partial class BookedDataList : UserControl
    {
        public BookedDataList()
        {
            InitializeComponent();
        }

        #region Form Load

        private void BookedDataList_Load(object sender, EventArgs e)
        {
            tableload();
        }

        #endregion

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        #region Form Search

        private void BookedSearchBoxList_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * from Booked WHERE Customer_NIC LIKE '" + BookedSearchBoxList_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                BookedDataGridList.DataSource = dt;
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

        #region Standard Button

        private void BookedDataStandardList_btn_Click(object sender, EventArgs e)
        {
            BookedDataGridList.Visible = false;
            BookedSearchBoxList_txt.Visible = false;

            BookedDataStandardList_btn.Visible = false;
            BookedDataListViewList_btn.Visible = false;

            BookedDataListViewList_btn.Visible = false;

            BookedData uc = new BookedData();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        #region Table Load Class

        private void tableload()
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT BookeVehicle_RegNo, Customer_NIC, Hire_or_Rent, StartTime FROM Booked";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                BookedDataGridList.DataSource = dt;
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

    }
}
