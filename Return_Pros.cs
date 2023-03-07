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
    public partial class Return_Pros : Form
    {
        public Return_Pros()
        {
            InitializeComponent();
        }

        private void Return_Pros_Load(object sender, EventArgs e)
        {
            try
            {
                //Before Two Weeks
                DateTime lastday = DateTime.Now.AddDays(-14);
                string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

                //Today
                DateTime today = DateTime.Now;
                string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //2 Weeks Sales
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT bill.billnumber AS Bill, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                //returnTempView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT temp_return.billnumber AS BillNumber, temp_return.itemid AS ItemID, temp_return.quantity AS Quantity, temp_return.price AS SoldPrice FROM  (temp_return INNER JOIN billitem ON temp_return.billnumber = billitem.billnumber) INNER JOIN item ON temp_return.itemid = item.itemid";
                SqlDataAdapter dataAdapTemp = new SqlDataAdapter();
                DataTable dataTableTemp = new DataTable();
                dataAdapTemp.SelectCommand = cmd;
                dataAdapTemp.Fill(dataTableTemp);
                returnTempView.DataSource = dataTableTemp;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
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

        private void billNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addReturn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand();

                bool available = false; //Available in the temp_bill
                int tempAvailableQuantity = 0; //If available in temp_billWhat is the Quantity
                int availableQuantity = 0; //avalable quantity in the item table
                //int availableQuanItem = 0; //Item table available Items

                if (ItemId.Text.Trim() != "")
                {
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM temp_return WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber ='" + billNum.Text.Trim() + "'";
                    SqlDataReader read0 = cmd.ExecuteReader();
                    read0.Read();
                    if (read0.HasRows)
                    {
                        available = true;
                        tempAvailableQuantity = int.Parse(read0["quantity"].ToString().Trim());
                    }
                    read0.Close();

                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM billitem WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber = '" + billNum.Text.Trim() + "';";
                    SqlDataReader read1 = cmd.ExecuteReader();
                    read1.Read();
                    if (read1.HasRows)
                    {
                        availableQuantity = int.Parse(read1["quantity"].ToString().Trim());
                    }
                    read1.Close();

                    if (available)
                    {
                        if (tempAvailableQuantity < availableQuantity)
                        {
                            //Quantity Changer Dialog
                            Qunatity_Changer f1 = new Qunatity_Changer((availableQuantity - tempAvailableQuantity), tempAvailableQuantity, ItemId.Text.Trim(), billNum.Text.Trim(), "Add");
                            f1.ShowDialog();
                            Visible = true;
                        }
                        else
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                            player.Play();
                        }
                    }
                    else
                    {
                        if (availableQuantity > 1)
                        {
                            //Quantity Changer Dialog
                            Qunatity_Changer f1 = new Qunatity_Changer(availableQuantity, tempAvailableQuantity, ItemId.Text.Trim(), billNum.Text.Trim(), "Add");
                            f1.ShowDialog();
                            Visible = true;
                        }
                        else
                        {
                            //Insert the temp_bill
                            string brand = "";
                            string category = "";
                            decimal price = 0;

                            //Get data from item Table
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT brand.brandname, category.categoryname FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + ItemId.Text.Trim() + "';";
                            SqlDataReader read2 = cmd.ExecuteReader();

                            read2.Read();
                            if (read2.HasRows)
                            {
                                brand = read2["brandname"].ToString().Trim();
                                category = read2["categoryname"].ToString().Trim();
                            }
                            read2.Close();

                            //Get data from item Table
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT soldprice FROM billitem WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber = '" + billNum.Text.Trim() + "';";
                            SqlDataReader read3 = cmd.ExecuteReader();

                            read3.Read();
                            if (read3.HasRows)
                            {
                                price = read3.GetDecimal(read3.GetOrdinal("soldprice"));
                            }
                            read3.Close();

                            //input to the Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos INSERT INTO temp_return VALUES  ('" + ItemId.Text.Trim() + "','" + billNum.Text.Trim() + "','" + availableQuantity + "', '" + brand + "','" + category + "', '" + price + "');";
                            cmd.ExecuteNonQuery();
                        }
                    }

                }


                /*cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;*/

                conn.db_connect_close(); //Connection Close

            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void Return_Pros_Activated(object sender, EventArgs e)
        {
            try
            {
                //Before Two Weeks
                DateTime lastday = DateTime.Now.AddDays(-14);
                string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

                //Today
                DateTime today = DateTime.Now;
                string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //2 Weeks Sales
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT bill.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON bill.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + ToDay + "' AND '" + LastDay + "' ORDER BY time DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                //returnTempView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT temp_return.billnumber AS BillNumber, temp_return.itemid AS ItemID, temp_return.quantity AS Quantity, temp_return.price AS SoldPrice FROM  (temp_return INNER JOIN billitem ON temp_return.billnumber = billitem.billnumber) INNER JOIN item ON temp_return.itemid = item.itemid;";
                SqlDataAdapter dataAdapTemp = new SqlDataAdapter();
                DataTable dataTableTemp = new DataTable();
                dataAdapTemp.SelectCommand = cmd;
                dataAdapTemp.Fill(dataTableTemp);
                returnTempView.DataSource = dataTableTemp;


                //Clear Fields
                ItemId.Clear();
                SoldPrice.Clear();
                returnItem.Clear();
                billNumber.Clear();
                itemNumber.Clear();

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void editReturn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand();


                int tempAvailableQuantity = 0; //If available in temp_billWhat is the Quantity
                int availableQuantity = 0; //avalable quantity in the item table

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM temp_return WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber ='" + billNum.Text.Trim() + "'";
                SqlDataReader read0 = cmd.ExecuteReader();
                read0.Read();
                if (read0.HasRows)
                {
                    tempAvailableQuantity = int.Parse(read0["quantity"].ToString().Trim());
                }
                read0.Close();

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM billitem WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber = '" + billNum.Text.Trim() + "';";
                SqlDataReader read1 = cmd.ExecuteReader();
                read1.Read();
                if (read1.HasRows)
                {
                    availableQuantity = int.Parse(read1["quantity"].ToString().Trim());
                }
                read1.Close();

                if (availableQuantity > 1)
                {
                    //Quantity Changer Dialog
                    Qunatity_Changer f1 = new Qunatity_Changer((availableQuantity - tempAvailableQuantity), tempAvailableQuantity, ItemId.Text.Trim(), billNum.Text.Trim(), "Add");
                    f1.ShowDialog();
                    Visible = true;
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
