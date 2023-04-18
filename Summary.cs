using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Summary : UserControl
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            try
            {
                // DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in brands in brandDataView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, totalprice AS Price, items AS Items, totalbeforediscount as NetTotal, discount AS Discount, time as Time, processor AS Processor FROM bill ORDER BY billnumber DESC ;";
                SqlDataAdapter brandAdap = new SqlDataAdapter();
                DataTable brandTable = new DataTable();
                brandAdap.SelectCommand = cmd;
                brandAdap.Fill(brandTable);
                billsDataView.DataSource = brandTable;

                //Quntity 0 has How many?
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(itemid) AS count FROM item WHERE quantity = '0' ;";
                SqlDataReader read1 = cmd.ExecuteReader();
                read1.Read();
                if (read1.HasRows)
                {
                    ZeroCount.Text = read1["count"].ToString().Trim();
                }
                read1.Close();

                //Quntity 1 has How many?
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(itemid) AS count FROM item WHERE quantity = '1' ;";
                SqlDataReader read2 = cmd.ExecuteReader();
                read2.Read();
                if (read2.HasRows)
                {
                    OneCount.Text = read2["count"].ToString().Trim();
                }
                read2.Close();

                //Sales Quantity
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT SUM(quantity) AS total FROM billitem;";
                SqlDataReader read3 = cmd.ExecuteReader();
                read3.Read();
                if (read3.HasRows)
                {
                    TotalItems.Text = read3["total"].ToString().Trim();
                }
                read3.Close();

                //Bill Count
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(billnumber) AS totbill FROM bill;";
                SqlDataReader read4 = cmd.ExecuteReader();
                read4.Read();
                if (read4.HasRows)
                {
                    TotalBill.Text = read4["totbill"].ToString().Trim();
                }
                read4.Close();


                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }

        }

        private void billNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        protected void SearchMethod()
        {
            try
            {
                // DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader


                if (billNumber.Text.Trim() != "")
                {
                    string BillNum = "%" + billNumber.Text.Trim() + "%";//Bill Number

                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, totalprice AS Price, items AS Items, totalbeforediscount as NetTotal, discount AS Discount, time as Time, processor AS Processor FROM bill WHERE billnumber LIKE '" + BillNum + "' ORDER BY billnumber DESC ;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    billsDataView.DataSource = brandTable;
                }
                else
                {
                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, totalprice AS Price, items AS Items, totalbeforediscount as NetTotal, discount AS Discount, time as Time, processor AS Processor FROM bill ORDER BY billnumber DESC ;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    billsDataView.DataSource = brandTable;
                }
                
            }
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                // DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader


                if (billNumber.Text.Trim() != "")
                {
                    billNumber.Clear(); //Clear Text

                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, totalprice AS Price, items AS Items, totalbeforediscount as NetTotal, discount AS Discount, time as Time, processor AS Processor FROM bill ORDER BY billnumber DESC ;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    billsDataView.DataSource = brandTable;
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
                }

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }
    }
}
