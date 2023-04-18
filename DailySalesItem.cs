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
    public partial class DailySalesItem : Form
    {
        string today = "";
        public DailySalesItem()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DailySalesItem_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");
                today = todayDate;

                decimal totalPrice = 0; //Sum of bill of today
                string items = "0"; //TotalItems of bill of today
                string bills = "0"; //Total Billsa today
                string totals = "0";

                string searchDate = today;

                //Get data from item Table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT COUNT(billnumber) AS Bills, SUM(totalprice) AS total, SUM(items) AS items FROM bill WHERE datediff(day,time, '" + searchDate + "') = 0;";
                SqlDataReader read1 = cmd.ExecuteReader();

                read1.Read();
                if (read1.HasRows)
                {
                    //Is there any data available
                    if (read1["total"].ToString().Trim() != "" && read1["items"].ToString() != "")
                    {
                        bills = read1["Bills"].ToString();
                        totals = read1["total"].ToString();
                        totalPrice = read1.GetDecimal(read1.GetOrdinal("total"));
                        items = read1["items"].ToString().Trim();
                    }
                }
                read1.Close();

                //Set to the Textboxes
                todaySales.Text = totals.ToString();
                todaySellsQuantity.Text = items;
                todayReturns.Text = bills;

                //View in data grid view of today sales
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + searchDate + "') = 0  ORDER BY billnumber DESC, itemid ASC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                todaySales.Text = Decimal.ToInt32(totalPrice).ToString();
                todaySellsQuantity.Text = items;

                conn.db_connect_close();
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (billNumber.Text != "" || itemNumber.Text != "")
            {
                try
                {
                    //Set date to the text box
                    var date = DateTime.Now;
                    string todayDate = date.ToString("yyyy-MM-dd");

                    billNumber.Clear();
                    itemNumber.Clear();

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + todayDate + "') = 0  ORDER BY billnumber DESC, itemid ASC";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                catch (Exception ex)
                {
                    string errorMessage = ex.Message;
                    string error = "Error";
                    MessageBox.Show(errorMessage, error);
                }
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                player.Play();
            }
        }

        private void billNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        protected void SearchMethod()
        {
            try
            {
                string text = billNumber.Text.Trim();
                string combo = itemNumber.Text.Trim();

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");


                if (text != "" && combo == "")
                {
                    text = "%" + billNumber.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    // USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + searchDate + "') = 0 AND itemid LIKE '" + combo + "' AND billnumber LIKE '" + text + "'  ORDER BY billnumber DESC, itemid ASC;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + todayDate + "') = 0 AND billitem.billnumber LIKE '" + text + "'  ORDER BY billnumber DESC, itemid ASC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (combo != "" && text == "")
                {
                    combo = "%" + itemNumber.Text.Trim() + "%";
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + todayDate + "') = 0 AND billitem.itemid LIKE '" + combo + "' ORDER BY billnumber DESC, itemid ASC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text != "" && combo != "")
                {
                    text = "%" + billNumber.Text.Trim() + "%";
                    combo = "%" + itemNumber.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + todayDate + "') = 0 AND billitem.itemid LIKE '" + combo + "' AND billitem.billnumber LIKE '" + text + "'  ORDER BY billnumber DESC, itemid ASC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text == "" && combo == "")
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, soldprice AS Price, billitem.discount AS Discount FROM billitem INNER JOIN bill ON billitem.billnumber = bill.billnumber WHERE datediff(day, time, '" + todayDate + "') = 0  ORDER BY billnumber DESC, itemid ASC";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
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
