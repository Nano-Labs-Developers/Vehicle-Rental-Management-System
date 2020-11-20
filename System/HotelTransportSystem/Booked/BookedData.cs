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
    public partial class BookedData : UserControl
    {
        public BookedData()
        {
            InitializeComponent();
        }

        // This Form Variables

        #region Main vars

        string UserRole;

        #endregion

        // This form load event

        #region Form Load

        private void BookedData_Load(object sender, EventArgs e)
        {
            tableload();
            DeleteBTNShow();
        }

        #endregion

        // SQL Connection String

        #region SQL Connection String

        SqlConnection con = new SqlConnection(@"Data Source=ASUS;Initial Catalog=Ayubo_Leisure;Integrated Security=True");
        //SqlConnection conloacal = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Ayubo_Leisure.mdf;Integrated Security=True;");

        #endregion

        // Table Data Load Class

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
                BookedDataGrid.DataSource = dt;
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

        // Booked table Data Search

        #region Booked Search Button

        private void BookedSearchBox_txt_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter("SELECT BookeVehicle_RegNo, Customer_NIC, Hire_or_Rent, StartTime from Booked WHERE Customer_NIC LIKE '" + BookedSearchBox_txt.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                BookedDataGrid.DataSource = dt;
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

        // Data Grid View Data Cell Click event and Vehicle Data DropDown box Data load

        #region Booked Data Grid

        private void BookedDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (BookedDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    BookedDataGrid.CurrentRow.Selected = true;

                    BookedVehicleRegNo_txt.Text = BookedDataGrid.Rows[e.RowIndex].Cells["BookeVehicle_RegNo"].FormattedValue.ToString();
                    CustomerNIC_txt.Text = BookedDataGrid.Rows[e.RowIndex].Cells["Customer_NIC"].FormattedValue.ToString();

                    HireorRent_txt.Text = BookedDataGrid.Rows[e.RowIndex].Cells["Hire_or_Rent"].FormattedValue.ToString();
                    BookedTimeDate_txt.Text = BookedDataGrid.Rows[e.RowIndex].Cells["StartTime"].FormattedValue.ToString();

                }
            }

            try
            {
                con.Open();

                // Vehicle Data DropDown box
                string query_select = "SELECT * FROM Booked WHERE BookeVehicle_RegNo = '" + BookedVehicleRegNo_txt.Text + "'";
                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader DBR = cmd.ExecuteReader();

                if (DBR.HasRows)
                {
                    while (DBR.Read())
                    {
                        PackageName_txt.Text = DBR.GetValue(1).ToString();
                        StartingMilage_txt.Text = DBR.GetValue(4).ToString();

                        TourType_txt.Text = DBR.GetValue(8).ToString();
                        BookedTimeDate_txt.Text = DBR.GetValue(3).ToString();

                        if (Convert.ToInt32(DBR.GetValue(6)) == 1)
                        {
                            WithDriver_checkbox.Checked = true;
                        }
                        else
                        {
                            WithDriver_checkbox.Checked = false;
                        }

                    }

                }

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

        // List view open Button

        #region List Button

        private void BookedDataListView_btn_Click(object sender, EventArgs e)
        {
            Booked_groupBox.Visible = false;
            BookedDataGrid.Visible = false;

            BookedSearchBox_txt.Visible = false;
            BookedDataStandard_btn.Visible = false;

            BookedDataListView_btn.Visible = false;
            if (BookedDelete_btn.Visible == true)
            {
                BookedDelete_btn.Visible = false;
            }

            BookedDataList uc = new BookedDataList();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        #endregion

        // Delete Button Only Show admin

        #region Delete Button Show Event

        private void DeleteBTNShow()
        {
            UserRole = Login.Login.UserRole;

            if (UserRole == "Admin")
            {
                BookedDelete_btn.Visible = true;
            }

        }

        #endregion

        // Booked Data Delete Button

        #region Booked Data Delete

        private void BookedDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query_delete = "DELETE FROM Booked WHERE BookeVehicle_RegNo = '" + BookedVehicleRegNo_txt.Text + "'";

                //SQL Command Set
                SqlCommand cmndD = new SqlCommand(query_delete, con);
                // Execution of the command
                cmndD.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Payment Sucesses.");

                tableload();
                TextBoxClear();

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

        // textbox Clear Event

        #region Textbox Clear

        private void TextBoxClear()
        {
            BookedVehicleRegNo_txt.Text = "";
            PackageName_txt.Text = "";
            CustomerNIC_txt.Text = "";
            StartingMilage_txt.Text = "";
            HireorRent_txt.Text = "";
            TourType_txt.Text = "";
            BookedTimeDate_txt.Text = "";
            WithDriver_checkbox.Checked = false;

        }

        #endregion

    }
}