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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PosSystem
{
    public partial class Return_Check : Form
    {
        int rowCount; //Row count in item datatable

        public Return_Check()
        {
            InitializeComponent();
        }

        private void Return_Check_Load(object sender, EventArgs e)
        {
            try
            {
                //Before Two Weeks
                DateTime lastday = DateTime.Now.AddDays(-14);
                string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

                //Today
                DateTime today = DateTime.Now;
                string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

                DateTime yesterday = DateTime.Now.AddDays(-1);
                string todayDate = yesterday.ToString("yyyy-MM-dd hh:mm:ss");
                dateTime.Text = todayDate;

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        protected void SearchMethod()
        {
            //Before Two Weeks
            DateTime lastday = DateTime.Now.AddDays(-14);
            string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

            //Today
            DateTime today = DateTime.Now;
            string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");


            try
            {
                string text = BillNumber.Text.Trim();
                string combo = itemNumber.Text.Trim();


                if (text != "" && combo == "")
                {
                    text = "%" + BillNumber.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE billitem.billnumber LIKE '" + text + "' AND time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;;";
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
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE billitem.itemid LIKE '" + combo + "' AND time BETWEEN '" + LastDay + "' AND '" + ToDay + "'  ORDER BY time DESC;;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    todaySalesView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text != "" && combo != "")
                {
                    text = "%" + BillNumber.Text.Trim() + "%";
                    combo = "%" + itemNumber.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE itemid LIKE '" + combo + "' AND billitem.billnumber LIKE '" + text + "' AND time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;;";
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
                    cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void todaySalesView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            int index;
            index = e.RowIndex;
            
            //Before Two Weeks
            DateTime lastday = DateTime.Now.AddDays(-14);
            string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

            //Today
            DateTime today = DateTime.Now;
            string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

            DateTime yesterday = DateTime.Now.AddDays(-1);
            string todayDate = yesterday.ToString("yyyy-MM-dd hh:mm:ss");
            dateTime.Text = todayDate;

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT COUNT(*) AS ROWS FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE bill.time BETWEEN '" + LastDay + "' AND '" + ToDay + "';";
            SqlDataReader read0 = cmd.ExecuteReader();
            while (read0.Read())
            {
                rowCount = read0.GetInt32(0);
            }
            read0.Close();

            if (index == -1 || index == rowCount)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                player.Play();
            }
            else
            {
                DataGridViewRow dataGridViewRowrow = todaySalesView.Rows[index];
                //string itemId = dataGridViewRowrow.Cells[1].Value.ToString();
                //string billId = dataGridViewRowrow.Cells[0].Value.ToString();

                ItemId.Text = dataGridViewRowrow.Cells[1].Value.ToString().Trim();
                SoldPrice.Text = dataGridViewRowrow.Cells[3].Value.ToString().Trim();

                /*
                
                //SQL command execute
                SqlCommand cmd0 = new SqlCommand(); //SQL command reader
                cmd0.Connection = Connection.con;
                cmd0.CommandText = "USE pos SELECT DISTINCT billitem.itemid, billitem.soldprice AS SoldPrices FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE bill.time BETWEEN '" + LastDay + "' AND '" + ToDay + "' AND billitem.itemid = '" + itemId + "' AND billitem.billnumber = '" + billId + "';";

                SqlDataReader read1 = cmd.ExecuteReader();
                if (read1.HasRows)
                {
                    ItemId.Text = read1["itemid"].ToString().Trim();

                    int prize = (int)Math.Floor(read1.GetDecimal(read1.GetOrdinal("SoldPrices")));
                    SoldPrice.Text = prize.ToString().Trim();
                }
                read0.Close();

                */
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Search Clear
            BillNumber.Clear();
            itemNumber.Clear();

            //Show Text Clear
            ItemId.Clear();
            SoldPrice.Clear();
            try
            {
                //Before Two Weeks
                DateTime lastday = DateTime.Now.AddDays(-14);
                string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

                //Today
                DateTime today = DateTime.Now;
                string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

                DateTime yesterday = DateTime.Now.AddDays(-1);
                string todayDate = yesterday.ToString("yyyy-MM-dd hh:mm:ss");
                dateTime.Text = todayDate;

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;";
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
    }
}
