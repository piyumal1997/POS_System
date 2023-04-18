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
        int rowCount; //Row count in item datatable

        public Return_Pros()
        {
            InitializeComponent();
        }

        private void Return_Pros_Load(object sender, EventArgs e)
        {
            try
            {
                //Yesterday Date
                DateTime yesterday = DateTime.Now.AddDays(-1);
                string todayDate = yesterday.ToString("yyyy-MM-dd hh:mm:ss");

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
                cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                //returnTempView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, brand AS Brand, category AS Category, price AS SoldPrice FROM temp_return ORDER BY itemid ASC";
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
                    cmd.CommandText = "USE pos SELECT * FROM temp_return WHERE itemid = '" + ItemId.Text.Trim() + "' AND billnumber = '" + billNum.Text.Trim() + "';";
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
                            //Quantity Changer Dialog
                            Qunatity_Changer f1 = new Qunatity_Changer(availableQuantity, tempAvailableQuantity, ItemId.Text.Trim(), billNum.Text.Trim(), "Add");
                            f1.ShowDialog();
                            Visible = true;

                            /*//Insert the temp_bill
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
                            cmd.ExecuteNonQuery();*/
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
                cmd.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.quantity AS Quantity, billitem.soldprice AS SoldPrice, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                todaySalesView.DataSource = dataTable;

                //returnTempView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT billnumber AS BillNumber, itemid AS ItemID, quantity AS Quantity, brand AS Brand, category AS Category, price AS SoldPrice FROM temp_return ORDER BY itemid ASC;";
                SqlDataAdapter dataAdapTemp = new SqlDataAdapter();
                DataTable dataTableTemp = new DataTable();
                dataAdapTemp.SelectCommand = cmd;
                dataAdapTemp.Fill(dataTableTemp);
                returnTempView.DataSource = dataTableTemp;

                //Clear Fields
                ItemId.Clear();
                SoldPrice.Clear();
                billNum.Clear();
                returnItem.Clear();
                BillNumber.Clear();
                itemNumber.Clear();
                returnBill.Clear();

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

           /* DateTime yesterday = DateTime.Now.AddDays(-1);
            string todayDate = yesterday.ToString("yyyy-MM-dd hh:mm:ss");*/

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
                string itemId = dataGridViewRowrow.Cells[1].Value.ToString().Trim();
                string billId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                /*
                ItemId.Text = dataGridViewRowrow.Cells[1].Value.ToString().Trim();
                SoldPrice.Text = dataGridViewRowrow.Cells[3].Value.ToString().Trim();
                */

                /*
                 
                USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.soldprice AS SoldPrice FROM  (bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;
                 
                 */

                //SQL command execute
                SqlCommand cmd0 = new SqlCommand(); //SQL command reader
                cmd0.Connection = Connection.con;
                cmd0.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.soldprice AS SoldPrices FROM  (bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' AND billitem.itemid = '" + itemId + "' AND billitem.billnumber = '" + billId + "';";
                //cmd0.CommandText = "USE pos SELECT DISTINCT billitem.itemid, billitem.soldprice AS SoldPrices FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE bill.time BETWEEN '" + LastDay + "' AND '" + ToDay + "' AND billitem.itemid = '" + itemId + "' AND billitem.billnumber = '" + billId + "';";

                SqlDataReader read1 = cmd0.ExecuteReader();
                read1.Read();
                if (read1.HasRows)
                {
                    ItemId.Text = read1["ItemID"].ToString().Trim();
                    billNum.Text = read1["BillNumber"].ToString().Trim();
                    int prize = (int)Math.Floor(read1.GetDecimal(read1.GetOrdinal("SoldPrices")));
                    SoldPrice.Text = prize.ToString().Trim();
                }
                read0.Close();
            }
        }

        private void removeReturn_Click(object sender, EventArgs e)
        {
            if (returnItem.Text.Trim() != "")
            {

                string message = $"Are you sure want remove this?";
                string title = "Item Remove";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        //DB Connection
                        Connection conn = new Connection();
                        conn.db_connect();

                        //SQL command execute
                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        string ItemIDS = "%" + returnItem.Text.Trim() + "%";

                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM temp_return WHERE itemid LIKE '" + ItemIDS + "' AND billnumber = '" + returnBill.Text.Trim() + "';";
                        cmd.ExecuteNonQuery();

                        conn.db_connect_close();
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = ex.ToString();
                        string error = "Error";
                        MessageBox.Show(errorMessage, error);
                    }
                    //conn.db_connect_close();
                }
                else
                {
                    //Do nothing
                }
            }
            else
            {

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                //Before Two Weeks
                DateTime lastday = DateTime.Now.AddDays(-14);
                string LastDay = lastday.ToString("yyyy-MM-dd hh:mm:ss");

                //Today
                DateTime today = DateTime.Now;
                string ToDay = today.ToString("yyyy-MM-dd hh:mm:ss");

                //Search Text Clear
                itemNumber.Clear();
                BillNumber.Clear();

                //Data Preview Text Clear
                ItemId.Clear();
                billNum.Clear();
                SoldPrice.Clear();

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

        private void returnTempView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            int index;
            index = e.RowIndex;

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT COUNT(*) AS ROWS FROM temp_return;";
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
                DataGridViewRow dataGridViewRowrow = returnTempView.Rows[index];
                string itemId = dataGridViewRowrow.Cells[1].Value.ToString().Trim();
                string billId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                //Set Selected Row Data To Text boxes
                returnItem.Text = itemId;
                returnBill.Text = billId;


                /*
                 
                USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.soldprice AS SoldPrice FROM  (bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' ORDER BY time DESC;
                 
                 */

                //SQL command execute
                /*SqlCommand cmd0 = new SqlCommand(); //SQL command reader
                cmd0.Connection = Connection.con;
                cmd0.CommandText = "USE pos SELECT billitem.billnumber AS BillNumber, billitem.itemid AS ItemID, billitem.soldprice AS SoldPrices FROM  (bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid WHERE time BETWEEN '" + LastDay + "' AND '" + ToDay + "' AND billitem.itemid = '" + itemId + "' AND billitem.billnumber = '" + billId + "';";
                //cmd0.CommandText = "USE pos SELECT DISTINCT billitem.itemid, billitem.soldprice AS SoldPrices FROM  (((bill INNER JOIN billitem ON billitem.billnumber = bill.billnumber) INNER JOIN item ON billitem.itemid = item.itemid) INNER JOIN brand ON item.brandid = brand.brandid) INNER JOIN category ON item.categoryid = category.categoryid WHERE bill.time BETWEEN '" + LastDay + "' AND '" + ToDay + "' AND billitem.itemid = '" + itemId + "' AND billitem.billnumber = '" + billId + "';";

                SqlDataReader read1 = cmd0.ExecuteReader();
                read1.Read();
                if (read1.HasRows)
                {
                    ItemId.Text = read1["ItemID"].ToString().Trim();
                    billNum.Text = read1["BillNumber"].ToString().Trim();
                    int prize = (int)Math.Floor(read1.GetDecimal(read1.GetOrdinal("SoldPrices")));
                    SoldPrice.Text = prize.ToString().Trim();
                }
                read0.Close();*/
            }
        }
    }
}
