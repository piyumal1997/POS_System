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
    public partial class Admin_Pos : Form
    {
        int rowCount; //bollingItem row count
        int rowCountBill;
        Timer timer = null;

        public Admin_Pos()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (billNumber.Text.Trim() == "")
            {
                AdminDash f3 = new AdminDash();
                f3.Show();
                Visible = false;
            }
            else
            {
                string message = $"Are you sure want to back to the Home?";
                string title = "Home";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    AdminDash f3 = new AdminDash();
                    f3.Show();
                    Visible = false;
                }
                else
                {
                    //Do nothing
                }
            }
            
        }

        private void serachItem_Click(object sender, EventArgs e)
        {
            Search_Items f4 = new Search_Items();
            f4.ShowDialog();
            Visible = true;
        }

        private void Admin_Pos_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                int returnPrice = 0;
                int netPrice = 0;
                //Get ALL from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT SUM(price) AS PRICE FROM temp_return;";
                SqlDataReader readSUM = cmd.ExecuteReader();
                readSUM.Read();
                if (readSUM.HasRows)
                {
                    string val = readSUM["PRICE"].ToString().Trim();
                    if (val != "")
                    {
                        //Total Price
                        int prices = (int)Math.Floor(readSUM.GetDecimal(readSUM.GetOrdinal("PRICE")));
                        returnPrice = prices;
                    }
                }
                readSUM.Close();

                //Get ALL from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT price, pricebd, quantity, discount FROM temp_bill;";
                SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
                DataTable dataTableOfBill = new DataTable();
                dataAdapOfBill.SelectCommand = cmd;
                dataAdapOfBill.Fill(dataTableOfBill);

                //Total Price, Discount and Quantity
                decimal PRICE = 0;
                decimal DISCOUNT = 0;
                decimal PRICEBD = 0;
                int QUANTITY = 0;

                foreach (DataRow row in dataTableOfBill.Rows)
                {
                    decimal PRI = decimal.Parse(row["price"].ToString().Trim());
                    decimal PRIBD = decimal.Parse(row["pricebd"].ToString().Trim());
                    int QUN = int.Parse(row["quantity"].ToString().Trim());
                    decimal DSC = decimal.Parse(row["discount"].ToString().Trim());
                    PRICE = PRICE + PRI * QUN;
                    DISCOUNT = DISCOUNT + DSC * QUN;
                    PRICEBD = PRICEBD + PRIBD * QUN;
                    QUANTITY = QUANTITY + QUN;
                }

                //Grand Summary
                TotalBill.Text = PRICE.ToString().Trim();
                total.Text = PRICE.ToString().Trim();
                totalBeforeDiscount.Text = PRICEBD.ToString().Trim();
                totalDiscount.Text = DISCOUNT.ToString().Trim();
                noUnits.Text = QUANTITY.ToString().Trim();

                //Delete From temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos DELETE FROM temp_bill;";
                cmd.ExecuteNonQuery();

                //Delete From temp_return
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos DELETE FROM temp_return;";
                cmd.ExecuteNonQuery();

                //View in data grid view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity AS Quantity, discount AS Discount FROM temp_bill ORDER BY itemid DESC;";
                SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                DataTable dataTableBill = new DataTable();
                dataAdapBill.SelectCommand = cmd;
                dataAdapBill.Fill(dataTableBill);
                billingItem.DataSource = dataTableBill;

                //User
                user.Text = "Priyanga";
                designation.Text = "Cashier";

                //Clear Up Text
                total.Clear();
                totalDiscount.Clear();
                totalBeforeDiscount.Clear();
                noUnits.Clear();
                returnItemsPrice.Clear();
                TotalBill.Text = "0.00";

                //Clear bill number
                billNumber.Clear();

                //Set Dissable the buttons
                cancelBill.Enabled = false;
                addItemsToBill.Enabled = false;
                returning.Enabled = false;
                payment.Enabled = false;

                conn.db_connect_close();

                //Load Timer
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(timer_Tick);
                timer.Enabled = true;
            }
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        private void newBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (billNumber.Text != "")
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
                }
                else
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    //Select Max itemcode
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT billnumber FROM bill WHERE billnumber = (SELECT MAX(billnumber) FROM bill);";
                    SqlDataReader read0 = cmd.ExecuteReader();

                    //Set userId
                    if (read0.Read() == false)
                    {
                        billNumber.Text = "1000000001";
                    }
                    else
                    {
                        int value = int.Parse(read0["billnumber"].ToString().Trim()) + 1;
                        billNumber.Text = value.ToString();
                    }
                    read0.Close();

                    cancelBill.Enabled = true;
                    addItemsToBill.Enabled = true;
                    returning.Enabled = true;
                    payment.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void addItemsToBill_Click(object sender, EventArgs e)
        {
            Add_Items_To_Bill f5 = new Add_Items_To_Bill();
            f5.ShowDialog();
            Visible = true;
        }

        private void Admin_Pos_Activated(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity AS Quantity, discount AS Discount FROM temp_bill ORDER BY itemid DESC;";
                SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                DataTable dataTableBill = new DataTable();
                dataAdapBill.SelectCommand = cmd;
                dataAdapBill.Fill(dataTableBill);
                billingItem.DataSource = dataTableBill;

                int returnPrice = 0;
                int netPrice = 0;
                //Get ALL from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT SUM(price) AS PRICE FROM temp_return;";
                SqlDataReader readSUM = cmd.ExecuteReader();
                readSUM.Read();
                if (readSUM.HasRows)
                {
                    string val = readSUM["PRICE"].ToString().Trim();
                    if(val != ""){
                        //Total Price
                        int prices = (int)Math.Floor(readSUM.GetDecimal(readSUM.GetOrdinal("PRICE")));
                        returnPrice = prices;
                    }
                }
                readSUM.Close();


                //Get ALL from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT price, pricebd, quantity, discount FROM temp_bill;";
                SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
                DataTable dataTableOfBill = new DataTable();
                dataAdapOfBill.SelectCommand = cmd;
                dataAdapOfBill.Fill(dataTableOfBill);

                //Total Price, Discount and Quantity
                decimal PRICE = 0;
                decimal DISCOUNT = 0;
                decimal PRICEBD = 0;
                int QUANTITY = 0;

                foreach (DataRow row in dataTableOfBill.Rows)
                {
                    decimal PRI  = decimal.Parse(row["price"].ToString().Trim());
                    decimal PRIBD = decimal.Parse(row["pricebd"].ToString().Trim());
                    int QUN = int.Parse(row["quantity"].ToString().Trim());
                    decimal DSC = decimal.Parse(row["discount"].ToString().Trim());
                    PRICE = PRICE + PRI * QUN;
                    DISCOUNT = DISCOUNT + DSC * QUN;
                    PRICEBD = PRICEBD + PRIBD * QUN;
                    QUANTITY = QUANTITY + QUN;
                }

                //Grand Summary
                TotalBill.Text = PRICE.ToString().Trim();
                total.Text = PRICE.ToString().Trim();
                totalBeforeDiscount.Text = PRICEBD.ToString().Trim();
                totalDiscount.Text = DISCOUNT.ToString().Trim();
                noUnits.Text = QUANTITY.ToString().Trim();

                //Clear Readable Inputs
                itemCode.Clear();
                quantity.Clear();
                brand.Clear();
                category.Clear();
                size.Clear();
                price.Clear();
                barcode.Clear(); //Barcode Viewer Clear

                conn.db_connect_close();
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(ex.ToString(), error);
            }
            
        }

        private void todaySales_Click(object sender, EventArgs e)
        {
            DailySalesItem f6 = new DailySalesItem();
            f6.ShowDialog();
            Visible = true;
        }

        private void billingItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                int index;
                index = e.RowIndex;

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(itemid) FROM temp_bill;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCountBill = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == rowCountBill)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = billingItem.Rows[index];
                    string itemId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM temp_bill WHERE itemid = '" + itemId + "';";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        //Discount
                        int discount = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("price")));
                        price.Text = discount.ToString().Trim();

                        quantity.Text = read["quantity"].ToString().Trim();
                        itemCode.Text = read["itemid"].ToString().Trim();
                        brand.Text = read["brand"].ToString().Trim();
                        category.Text = read["category"].ToString().Trim();
                        size.Text = read["size"].ToString().Trim();
                    }
                    read.Close();

                }

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void changeDandQ_Click(object sender, EventArgs e)
        {
            bool available = false; //Select Item is Available in item_bill
            int billAvailableQuantity = 0; //If available What is the Quantity
            decimal billAvailableDiscount = 0; //If available What is the Discount
            int availableQuantity = 0; //avalable quantity in the item table
            decimal availableDiscount = 0; //avalable discount in the item table
            int availableQuanItem = 0; //Item table available Items

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            if (itemCode.Text.ToString() == "")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                player.Play();
            }
            else
            {
                //Search item Available in the Bill
                String searchValue = itemCode.Text.Trim();

                //Get Quantity and MaxDiscount
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM temp_bill WHERE itemid = '" + searchValue + "';";
                SqlDataReader readAV = cmd.ExecuteReader();
                readAV.Read();
                if (readAV.HasRows)
                {
                    available = true;
                }
                readAV.Close();

                if (available)
                {
                    //Get Quantity and MaxDiscount
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT quantity, discount FROM temp_bill WHERE itemid = '" + searchValue + "';";
                    SqlDataReader read0 = cmd.ExecuteReader();
                    read0.Read();
                    if (read0.HasRows)
                    {
                        billAvailableQuantity = int.Parse(read0["quantity"].ToString().Trim());
                        billAvailableDiscount = read0.GetDecimal(read0.GetOrdinal("discount"));
                    }
                    read0.Close();


                    //Get Quantity and MaxDiscount
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT quantity, maxdiscount  FROM item WHERE itemid = '" + itemCode.Text.ToString().Trim() + "';";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        //Discount
                        availableDiscount = read.GetDecimal(read.GetOrdinal("maxdiscount"));
                        availableQuanItem = int.Parse(read["quantity"].ToString().Trim());
                    }
                    else
                    {
                        //Do nothing
                    }
                    read.Close();

                    availableQuantity = availableQuanItem - billAvailableQuantity; //Show Remain Quantity

                    if (availableQuantity < 1)
                    {
                        Discount f7 = new Discount(availableDiscount, billAvailableDiscount, itemCode.Text.Trim(), "Update");
                        f7.ShowDialog();
                        Visible = true;
                    }
                    else
                    {
                        Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, itemCode.Text.Trim(), "Update");
                        f6.ShowDialog();
                        Visible = true;
                    }
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
                }
            }
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                
                bool available = false; //Available in the temp_bill
                int billAvailableQuantity = 0; //If available What is the Quantity
                decimal billAvailableDiscount = 0; //If available What is the Discount
                int availableQuantity = 0; //avalable quantity in the item table
                decimal availableDiscount = 0; //avalable discount in the item table
                int availableQuanItem = 0; //Item table available Items
                

                if (barcode.Text != "")
                {
                    string itemIDAV = "";//Store Checked Barcode

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT itemid FROM item WHERE itemid = '" + barcode.Text.Trim() + "';";
                    SqlDataReader readAV = cmd.ExecuteReader();

                    readAV.Read();
                    if (readAV.HasRows)
                    {
                        itemIDAV = readAV["itemid"].ToString().Trim(); ;
                    }
                    readAV.Close();


                    if (itemIDAV != "")
                    {
                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid, brand.brandname, category.categoryname, item.size, item.mrprice, item.maxdiscount, item.quantity FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + barcode.Text.Trim() + "';";
                        SqlDataReader read0 = cmd.ExecuteReader();

                        read0.Read();
                        if (read0.HasRows)
                        {
                            itemCode.Text = read0["itemid"].ToString().Trim();
                            brand.Text = read0["brandname"].ToString();
                            category.Text = read0["categoryname"].ToString();
                            size.Text = read0["size"].ToString().Trim();
                            //Prize
                            int prize = (int)Math.Floor(read0.GetDecimal(read0.GetOrdinal("mrprice")));
                            price.Text = prize.ToString().Trim();

                            quantity.Text = read0["quantity"].ToString().Trim();

                        }
                        read0.Close();

                        //Check Temp Bill already availble that Item
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT quantity, discount  FROM temp_bill WHERE itemid = '" + barcode.Text.ToString().Trim() + "';";
                        SqlDataReader read1 = cmd.ExecuteReader();
                        read1.Read();
                        if (read1.HasRows)
                        {
                            available = true;
                            //Discount
                            billAvailableDiscount = read1.GetDecimal(read1.GetOrdinal("discount"));
                            billAvailableQuantity = int.Parse(read1["quantity"].ToString().Trim());
                        }
                        read1.Close();

                        //If that Item already available that temp bill
                        if (available)
                        {
                            //Get Quantity and MaxDiscount
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT quantity, maxdiscount FROM item WHERE itemid = '" + barcode.Text.ToString().Trim() + "';";
                            SqlDataReader read = cmd.ExecuteReader();
                            read.Read();
                            if (read.HasRows)
                            {
                                //Max Discount
                                availableDiscount = read.GetDecimal(read.GetOrdinal("maxdiscount"));
                                availableQuanItem = int.Parse(read["quantity"].ToString().Trim());
                            }
                            read.Close();

                            availableQuantity = availableQuanItem - billAvailableQuantity; //Show Remain Quantity

                            if (availableQuantity >= 1)
                            {
                                Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, barcode.Text.Trim(), "Add");
                                f6.ShowDialog();
                                Visible = true;
                            }
                            else
                            {
                                string warningMessage = "There is no any item available in the store!";
                                string error = "Warning";
                                MessageBox.Show(warningMessage, error);
                            }


                        }
                        else
                        {
                            //Get Quantity and MaxDiscount
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT quantity, maxdiscount  FROM item WHERE itemid = '" + barcode.Text.ToString().Trim() + "';";
                            SqlDataReader read = cmd.ExecuteReader();
                            read.Read();
                            if (read.HasRows)
                            {
                                //Discount
                                availableDiscount = read.GetDecimal(read.GetOrdinal("maxdiscount"));
                                availableQuantity = int.Parse(read["quantity"].ToString().Trim());
                            }
                            else
                            {
                                //Do nothing
                            }
                            read.Close();

                            Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, barcode.Text.Trim(), "Add");
                            f6.ShowDialog();
                            Visible = true;
                        }
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                        player.Play();
                    }
                    
                }

                conn.db_connect_close();
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool available = false; //Is that itemid available in the temp_bill

                if (itemCode.Text.Trim() != "")
                {
                    //DB connaection
                    Connection connect = new Connection();
                    connect.db_connect();
                    SqlCommand cmds = new SqlCommand(); //SQL command reader

                    //Get Quantity and MaxDiscount
                    cmds.Connection = Connection.con;
                    cmds.CommandText = "USE pos SELECT * FROM temp_bill WHERE itemid = '" + itemCode.Text.Trim() + "';";
                    SqlDataReader readAV = cmds.ExecuteReader();
                    readAV.Read();
                    if (readAV.HasRows)
                    {
                        available = true;
                    }
                    readAV.Close();

                    connect.db_connect_close();//Connection Close

                    string ITEMS = itemCode.Text.Trim(); // Get Item Code

                    if (available)
                    {
                        string message = $"Do you want to Delete {ITEMS}?";
                        string title = "Delete Window";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            //DB connaection
                            Connection conn = new Connection();
                            conn.db_connect();
                            SqlCommand cmd = new SqlCommand(); //SQL command reader

                            //Delete a item from temp_bill
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos DELETE FROM temp_bill WHERE itemid = '" + ITEMS + "';";
                            cmd.ExecuteNonQuery();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity as Quantity, discount as Discount FROM temp_bill ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                            DataTable dataTableBill = new DataTable();
                            dataAdapBill.SelectCommand = cmd;
                            dataAdapBill.Fill(dataTableBill);
                            billingItem.DataSource = dataTableBill;

                            int returnPrice = 0;
                            int netPrice = 0;
                            //Get ALL from temp_bill
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT SUM(price) AS PRICE FROM temp_return;";
                            SqlDataReader readSUM = cmd.ExecuteReader();
                            readSUM.Read();
                            if (readSUM.HasRows)
                            {
                                string val = readSUM["PRICE"].ToString().Trim();
                                if (val != "")
                                {
                                    //Total Price
                                    int prices = (int)Math.Floor(readSUM.GetDecimal(readSUM.GetOrdinal("PRICE")));
                                    returnPrice = prices;
                                }
                            }
                            readSUM.Close();


                            //Get ALL from temp_bill
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT SUM(price) AS PRICE, SUM(pricebd) AS PRICEBD, SUM(quantity) AS QUANTITY, SUM(discount) AS DISCOUNT FROM temp_bill;";
                            SqlDataReader read = cmd.ExecuteReader();
                            read.Read();
                            if (read.HasRows)
                            {
                                string val = read["PRICE"].ToString().Trim();
                                if (val != "")
                                {
                                    //Total Price
                                    int prices = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("PRICE")));
                                    netPrice = prices - returnPrice;
                                    TotalBill.Text = netPrice.ToString().Trim();
                                    total.Text = netPrice.ToString().Trim();

                                    //Total Before Discount
                                    int pricebd = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("PRICEBD")));
                                    totalBeforeDiscount.Text = pricebd.ToString().Trim();
                                    //Total Dscount
                                    int discounts = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("DISCOUNT")));
                                    totalDiscount.Text = discounts.ToString().Trim();
                                    //No. Units
                                    noUnits.Text = read["QUANTITY"].ToString().Trim();
                                }
                            }
                            read.Close();

                            //Clear Readable Inputs
                            itemCode.Clear();
                            quantity.Clear();
                            brand.Clear();
                            category.Clear();
                            size.Clear();
                            price.Clear();
                            barcode.Clear(); //Barcode Viewer Clear

                            conn.db_connect_close();//Connection Close
                        }
                    }
                    else
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                        player.Play();
                    }
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
                MessageBox.Show(ex.ToString(), error);
            }
        }

        private void payment_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                bool avilable = false;

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM temp_bill;";
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {
                    avilable = true;
                }
                read.Close();

                if (avilable)
                {
                    Payment_Method f6 = new Payment_Method(billNumber.Text.Trim(), TotalBill.Text.Trim());
                    f6.ShowDialog();
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
                MessageBox.Show(ex.ToString(), error);
            }
        }

        private void returnCheck_Click(object sender, EventArgs e)
        {
            Return_Check f7 = new Return_Check();
            f7.ShowDialog();
            Visible = true;
        }

        private void returning_Click(object sender, EventArgs e)
        {
            Return_Pros f7 = new Return_Pros();
            f7.ShowDialog();
            Visible = true;
        }

        private void cancelBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (billNumber.Text != "")
                {
                    string message = $"Are you sure want to cancel the bill";
                    string title = "POS";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //DB Connection
                        Connection conn = new Connection();
                        conn.db_connect();

                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        //Delete From temp_bill
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM temp_bill;";
                        cmd.ExecuteNonQuery();

                        //Delete From temp_return
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM temp_return;";
                        cmd.ExecuteNonQuery();

                        //View in data grid view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity as Quantity, discount as Discount FROM temp_bill ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                        DataTable dataTableBill = new DataTable();
                        dataAdapBill.SelectCommand = cmd;
                        dataAdapBill.Fill(dataTableBill);
                        billingItem.DataSource = dataTableBill;

                        //Clear Up Text
                        total.Clear();
                        totalDiscount.Clear();
                        totalBeforeDiscount.Clear();
                        noUnits.Clear();
                        returnItemsPrice.Clear();
                        TotalBill.Text = "0.00";

                        //Clear bill number
                        billNumber.Clear();

                        //Set Dissable the buttons
                        cancelBill.Enabled = false;
                        addItemsToBill.Enabled = false;
                        returning.Enabled = false;
                        payment.Enabled = false;

                        conn.db_connect_close(); ///DB connection close
                    }
                    else
                    {
                        //Do nothing
                    }

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
