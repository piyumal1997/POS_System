using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Add_Items_To_Bill : Form
    {
        int rowCount;
        int rowCountBill;

        public Add_Items_To_Bill()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure want to back to the POS?";
            string title = "POS";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Do nothing
            }
        }

        private void itemDataViewer_CellClick(object sender, DataGridViewCellEventArgs e)
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
                cmd.CommandText = "USE pos SELECT COUNT(itemid) FROM item WHERE quantity > 0;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCount = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == rowCount)
                {
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = itemDataViewer.Rows[index];
                    string itemId = dataGridViewRowrow.Cells[0].Value.ToString();

                    code.Text = dataGridViewRowrow.Cells[0].Value.ToString();
                    brand.Text = dataGridViewRowrow.Cells[1].Value.ToString();
                    category.Text = dataGridViewRowrow.Cells[2].Value.ToString();
                    price.Text = dataGridViewRowrow.Cells[4].Value.ToString();
                    size.Text = dataGridViewRowrow.Cells[3].Value.ToString();
                    maxDiscount.Text = dataGridViewRowrow.Cells[5].Value.ToString();

                }

                conn.db_connect_close(); //Connection Close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void Add_Items_To_Bill_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity > 0 ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                itemDataViewer.DataSource = dataTable;

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity AS Quantity, discount AS Discount FROM temp_bill ORDER BY itemid DESC;";
                SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                DataTable dataTableBill = new DataTable();
                dataAdapBill.SelectCommand = cmd;
                dataAdapBill.Fill(dataTableBill);
                manualBillItems.DataSource = dataTableBill;

                conn.db_connect_close(); //Connection Close

            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void itemCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                if (itemCode.Text.Trim() != "")
                {
                    string code = "%" + itemCode.Text.Trim() + "%";

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity > 0 AND itemid LIKE '" + code + "'  ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    itemDataViewer.DataSource = dataTable;
                }
                else
                {
                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity > 0 ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    itemDataViewer.DataSource = dataTable;
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

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                itemCode.Clear();

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity > 0 ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                itemDataViewer.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void addToBill_Click(object sender, EventArgs e)
        {
            try
            {
                bool available = false; //Available in the temp_bill
                int billAvailableQuantity = 0; //If available What is the Quantity
                decimal billAvailableDiscount = 0; //If available What is the Discount
                int availableQuantity = 0; //avalable quantity in the item table
                decimal availableDiscount = 0; //avalable discount in the item table
                int availableQuanItem = 0; //Item table available Items

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader


                if (code.Text.ToString() == "")
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
                }
                else
                {
                    //Search item Available in the Bill
                    String searchValue = code.Text;


                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT quantity, discount  FROM temp_bill WHERE itemid = '" + code.Text.ToString().Trim() + "';";
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


                    if (available)
                    {
                        //Get Quantity and MaxDiscount
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT quantity, maxdiscount  FROM item WHERE itemid = '" + code.Text.ToString().Trim() + "';";
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

                        if (availableQuantity >= 1)
                        {
                            Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, code.Text.Trim(), "Add");
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
                        cmd.CommandText = "SELECT quantity, maxdiscount  FROM item WHERE itemid = '" + code.Text.ToString().Trim() + "';";
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

                        Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, code.Text.Trim(), "Add");
                        f6.ShowDialog();
                        Visible = true;
                    }


                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(ex.ToString(), error);
            }
            
            
        }

        private void manualBillItems_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow dataGridViewRowrow = manualBillItems.Rows[index];
                    string itemId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT itemid, quantity, discount FROM temp_bill WHERE itemid = '" + itemId + "';";
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read.HasRows)
                    {
                        //Discount
                        int discount = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("discount")));
                        billingItemDiscount.Text = discount.ToString().Trim();
                        
                        billingItemQuantity.Text = read["quantity"].ToString().Trim();
                        billingItemCode.Text = read["itemid"].ToString().Trim();
                    }
                    read.Close();

                }

                conn.db_connect_close(); //Connection Close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void changeDandQ_Click(object sender, EventArgs e)
        {
            int billAvailableQuantity = 0; //If available What is the Quantity
            decimal billAvailableDiscount = 0; //If available What is the Discount
            int availableQuantity = 0; //avalable quantity in the item table
            decimal availableDiscount = 0; //avalable discount in the item table
            int availableQuanItem = 0; //Item table available Items

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            if (billingItemCode.Text.ToString() == "")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                player.Play();
            }
            else
            {
                //Search item Available in the Bill
                String searchValue = billingItemCode.Text.Trim();

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
                cmd.CommandText = "SELECT quantity, maxdiscount  FROM item WHERE itemid = '" + billingItemCode.Text.ToString().Trim() + "';";
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
                    Discount f7 = new Discount(availableDiscount, billAvailableDiscount, billingItemCode.Text.Trim(), "Update");
                    f7.ShowDialog();
                    Visible= true;
                }
                else
                {
                    Discount_Quantity f6 = new Discount_Quantity(availableQuantity, availableDiscount, billAvailableQuantity, billAvailableDiscount, billingItemCode.Text.Trim(), "Update");
                    f6.ShowDialog();
                    Visible = true;
                }
                
            }
        }

        private void Add_Items_To_Bill_Activated(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity > 0 ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                itemDataViewer.DataSource = dataTable;

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, pricebd AS LabelPrice, quantity AS Quantity, discount AS ItemDiscount FROM temp_bill ORDER BY itemid DESC;";
                SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                DataTable dataTableBill = new DataTable();
                dataAdapBill.SelectCommand = cmd;
                dataAdapBill.Fill(dataTableBill);
                manualBillItems.DataSource = dataTableBill;

                //Manual Add Deatails Clear
                code.Clear();
                brand.Clear();
                category.Clear();
                size.Clear();
                price.Clear();
                maxDiscount.Clear();
                itemCode.Clear();

                //Billing Item Readable Inputs Clear
                billingItemCode.Clear();
                billingItemQuantity.Clear();
                billingItemDiscount.Clear();

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (billingItemCode.Text.Trim() != "")
                {
                    string ITEMS = billingItemCode.Text.Trim(); // Get Item Code

                    string message = $"Do you want to Delete {ITEMS}?";
                    string title = "Delete Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Connection conn = new Connection();
                        conn.db_connect();
                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        //Delete a item from temp_bill
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM temp_bill WHERE itemid = '" + ITEMS + "';";
                        cmd.ExecuteNonQuery();

                        //View in data grid view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT itemid AS Code, brand AS Brand, category AS Category, size AS Size, price AS Price, quantity as Quantity, discount as Discount FROM temp_bill ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdapBill = new SqlDataAdapter();
                        DataTable dataTableBill = new DataTable();
                        dataAdapBill.SelectCommand = cmd;
                        dataAdapBill.Fill(dataTableBill);
                        manualBillItems.DataSource = dataTableBill;

                        //Clear texts
                        billingItemCode.Clear();
                        billingItemQuantity.Clear();
                        billingItemDiscount.Clear(); 

                        conn.db_connect_close();//Connection Close3
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
    }
}
