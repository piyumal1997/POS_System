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
                cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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
                string text = billNumber.Text.Trim();
                string combo = itemNumber.Text.Trim();


                if (text != "" && combo == "")
                {
                    text = "%" + billNumber.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE billnumber LIKE '" + text + "' AND time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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
                    cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE itemid LIKE '" + combo + "' AND time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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
                    cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE itemid LIKE '" + combo + "' AND billnumber LIKE '" + text + "' AND time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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
                    cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
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
    }
}
