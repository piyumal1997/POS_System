using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PosSystem
{
    public partial class Add_Items : UserControl
    {
        int rowCount; //Row count in item datatable

        public Add_Items()
        {
            InitializeComponent();
        }

        private void Add_Items_Load(object sender, EventArgs e)
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
                todayDateView.Text = todayDate;

                //Brandname set to combobox
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM brand ORDER BY brandname ASC;";
                SqlDataAdapter brandAdap = new SqlDataAdapter();
                DataTable brandTable = new DataTable();
                brandAdap.SelectCommand = cmd;
                brandAdap.Fill(brandTable);
                itemBrand.DataSource = brandTable;
                itemBrand.DisplayMember = "brandname";
                itemBrand.ValueMember = "brandid";
                itemBrand.SelectedIndex = -1;

                //Brand Search 
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM brand ORDER BY brandname ASC;";
                SqlDataAdapter brandSearch = new SqlDataAdapter();
                DataTable brandSearchTable = new DataTable();
                brandSearch.SelectCommand = cmd;
                brandSearch.Fill(brandSearchTable);
                branSearchCombo.DataSource = brandSearchTable;
                branSearchCombo.DisplayMember = "brandname";
                branSearchCombo.ValueMember = "brandid";
                branSearchCombo.SelectedIndex = -1;

                //Categoryname set to combobox
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category ORDER BY categoryname ASC;";
                SqlDataAdapter categoryAdap = new SqlDataAdapter();
                DataTable categoryTable = new DataTable();
                categoryAdap.SelectCommand = cmd;
                categoryAdap.Fill(categoryTable);
                itemCategory.DataSource = categoryTable;
                itemCategory.DisplayMember = "categoryname";
                itemCategory.ValueMember = "categoryid";
                itemCategory.SelectedIndex = -1;

                //Category Search 
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category ORDER BY categoryname ASC;";
                SqlDataAdapter categorySearch = new SqlDataAdapter();
                DataTable categorySearchTable = new DataTable();
                categorySearch.SelectCommand = cmd;
                categorySearch.Fill(categorySearchTable);
                catSearchCombo.DataSource = categorySearchTable;
                catSearchCombo.DisplayMember = "categoryname";
                catSearchCombo.ValueMember = "categoryid";
                catSearchCombo.SelectedIndex = -1;

                //Select Max itemcode
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                if (read.Read() == false)
                {
                    itemCode.Text = "1000001";
                }
                else
                {
                    int value = int.Parse(read["itemid"].ToString().Trim()) + 1;
                    itemCode.Text = value.ToString();
                }
                read.Close();

                //Serach Price clear
                searchPrice.Clear();

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                itemDataViwer.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                string availableItem = ""; //Selected itemid holder

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get itemid form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = '" + itemCode.Text.Trim() + "'; ";
                SqlDataReader read2 = cmd.ExecuteReader();
                if (read2.Read())
                {
                    availableItem = read2["itemid"].ToString().Trim();
                }
                read2.Close();

                if (availableItem != itemCode.Text.Trim())
                {
                    if (unitCost.Text.Trim() != "" && mrPrice.Text.Trim() != "" && maxDiscount.Text.Trim() != "" && itemQuantity.Text.Trim() != "")
                    {
                        if (decimal.Parse(unitCost.Text.Trim()) >= 50 && decimal.Parse(mrPrice.Text.Trim()) >= 100 && decimal.Parse(maxDiscount.Text.Trim()) > 0 && int.Parse(itemQuantity.Text.Trim()) >= 1)
                        {
                            item Item = new item(itemCode.Text.Trim(), itemBrand.SelectedValue.ToString().Trim(), itemCategory.SelectedValue.ToString().Trim(), itemSize.Text.Trim(), itemDescription.Text.Trim(), decimal.Parse(unitCost.Text.Trim()), decimal.Parse(mrPrice.Text.Trim()), decimal.Parse(maxDiscount.Text.Trim()), int.Parse(itemQuantity.Text.Trim()));

                            if (Item.ItemSize != "0" && Item.ItemDescription != "0" && Item.MaxDiscount != 0 && Item.ItemCost != 0 && Item.ItemPrice != 0 && Item.Quantity != 0)
                            {
                                //Get NIC form Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = '" + Item.ItemCode + "'; ";
                                SqlDataReader read = cmd.ExecuteReader();
                                if (read.Read())
                                {
                                    availableItem = read["itemid"].ToString().Trim();
                                }
                                read.Close();

                                if (availableItem == Item.ItemCode)
                                {
                                    //Successful Added Message
                                    string Message = $"This Item Code is already exist in the system!";
                                    string warning = "Warning";
                                    MessageBox.Show(Message, warning);

                                    //Select Max itemcode
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                                    SqlDataReader read0 = cmd.ExecuteReader();

                                    //Set userId
                                    if (read0.Read() == false)
                                    {
                                        itemCode.Text = "1000001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read0["itemid"].ToString().Trim()) + 1;
                                        itemCode.Text = value.ToString();
                                    }
                                    read0.Close();

                                    //Clear all the Inputs
                                    itemCategory.SelectedIndex = -1;
                                    itemBrand.SelectedIndex = -1;
                                    itemSize.Text = "";
                                    itemSize.SelectedIndex = -1;
                                    itemDescription.Clear();
                                    unitCost.Clear();
                                    mrPrice.Clear();
                                    maxDiscount.Clear();
                                    itemQuantity.Clear();
                                }
                                else
                                {
                                    if (Item.ItemSize == "")
                                    {
                                        //Input to the Database
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos INSERT INTO item VALUES ('" + Item.ItemCode + "','" + Item.Quantity + "','" + Item.ItemPrice + "','" + Item.ItemCost + "','" + Item.ItemBrand + "','" + Item.ItemCategory + "',NULL,'" + Item.MaxDiscount + "','" + DateTime.Parse(todayDateView.Text.Trim()) + "','" + Item.ItemDescription + "');";
                                        cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        //Input to the Database
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos INSERT INTO item VALUES ('" + Item.ItemCode + "','" + Item.Quantity + "','" + Item.ItemPrice + "','" + Item.ItemCost + "','" + Item.ItemBrand + "','" + Item.ItemCategory + "','" + Item.ItemSize + "','" + Item.MaxDiscount + "','" + DateTime.Parse(todayDateView.Text.Trim()) + "','" + Item.ItemDescription + "');";
                                        cmd.ExecuteNonQuery();
                                    }

                                    //Successful Added Message
                                    string Message = $"{itemBrand.Text.Trim()} {itemCategory.Text.Trim()} successfully added to the system!";
                                    string success = "Success";
                                    MessageBox.Show(Message, success);

                                    //View in data grud view
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                                    DataTable dataTable = new DataTable();
                                    dataAdap.SelectCommand = cmd;
                                    dataAdap.Fill(dataTable);
                                    itemDataViwer.DataSource = dataTable;

                                    //Select Max itemcode
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                                    SqlDataReader read1 = cmd.ExecuteReader();

                                    //Set userId
                                    if (read1.Read() == false)
                                    {
                                        itemCode.Text = "1000001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read1["itemid"].ToString().Trim()) + 1;
                                        itemCode.Text = value.ToString();
                                    }
                                    read1.Close();

                                    //Clear all the Inputs
                                    itemCategory.SelectedIndex = -1;
                                    itemBrand.SelectedIndex = -1;
                                    itemSize.Text = "";
                                    itemSize.SelectedIndex = -1;
                                    itemDescription.Clear();
                                    unitCost.Clear();
                                    mrPrice.Clear();
                                    maxDiscount.Clear();
                                    itemQuantity.Clear();
                                }

                            }
                            else
                            {
                                string Message = "Input feild(s) are Not Valid, \nPlease checked the fields!";
                                string warning = "Warning";
                                MessageBox.Show(Message, warning);
                            }
                        }
                        else
                        {
                            string Message = "Input feild(s) are Not in Range, \nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }
                    }
                    else
                    {
                        string Message = "Input feild(s) are Not Valid, \nPlease checked the fields!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
                }
                else
                {
                    string Message = "This Item Code already exsist in the database!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
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

        private void updateItem_Click(object sender, EventArgs e)
        {
            try
            {
                string availableItem = ""; //Selected itemid holder

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                string message = $"Are you sure want to update {itemCode.Text.Trim()}?";
                string title = "Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //Get itemid form Database
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = '" + itemCode.Text.Trim() + "'; ";
                    SqlDataReader read0 = cmd.ExecuteReader();
                    if (read0.Read())
                    {
                        availableItem = read0["itemid"].ToString().Trim();
                    }
                    read0.Close();


                    if (availableItem == itemCode.Text.Trim())
                    {
                        if (unitCost.Text.Trim() != "" && mrPrice.Text.Trim() != "" && maxDiscount.Text.Trim() != "" && itemQuantity.Text.Trim() != "")
                        {
                            if (decimal.Parse(unitCost.Text.Trim()) >= 50 && decimal.Parse(mrPrice.Text.Trim()) >= 100 && decimal.Parse(maxDiscount.Text.Trim()) > 0 && int.Parse(itemQuantity.Text.Trim()) >= 1)
                            {
                                item Item = new item(itemCode.Text.Trim(), itemBrand.SelectedValue.ToString().Trim(), itemCategory.SelectedValue.ToString().Trim(), itemSize.Text.Trim(), itemDescription.Text.Trim(), decimal.Parse(unitCost.Text.Trim()), decimal.Parse(mrPrice.Text.Trim()), decimal.Parse(maxDiscount.Text.Trim()), int.Parse(itemQuantity.Text.Trim()));

                                if (Item.ItemSize != "0" && Item.ItemDescription != "0" && Item.MaxDiscount != 0 && Item.ItemCost != 0 && Item.ItemPrice != 0 && Item.Quantity != 0)
                                {
                                    if (Item.ItemSize == "")
                                    {
                                        //Input to the Database
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos UPDATE item SET quantity = '" + Item.Quantity + "', mrprice = '" + Item.ItemPrice + "', unitcost = '" + Item.ItemCost + "', brandid = '" + Item.ItemBrand + "', categoryid = '" + Item.ItemCategory + "', size = NULL , maxdiscount = '" + Item.MaxDiscount + "' WHERE itemid = '" + Item.ItemCode + "';";
                                        cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        //Input to the Database
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos UPDATE item SET quantity = '" + Item.Quantity + "', mrprice = '" + Item.ItemPrice + "', unitcost = '" + Item.ItemCost + "', brandid = '" + Item.ItemBrand + "', categoryid = '" + Item.ItemCategory + "', size = '" + Item.ItemSize + "', maxdiscount = '" + Item.MaxDiscount + "' WHERE itemid = '" + Item.ItemCode + "';";
                                        cmd.ExecuteNonQuery();
                                    }
                                    

                                    //Successful Added Message
                                    string Message = $"{itemBrand.Text.Trim()} {itemCategory.Text.Trim()} successfully updated!";
                                    string success = "Success";
                                    MessageBox.Show(Message, success);

                                    //View in data grud view
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                                    DataTable dataTable = new DataTable();
                                    dataAdap.SelectCommand = cmd;
                                    dataAdap.Fill(dataTable);
                                    itemDataViwer.DataSource = dataTable;

                                    //Select Max itemcode
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                                    SqlDataReader read = cmd.ExecuteReader();

                                    //Set userId
                                    if (read.Read() == false)
                                    {
                                        itemCode.Text = "1000001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read["itemid"].ToString().Trim()) + 1;
                                        itemCode.Text = value.ToString();
                                    }
                                    read.Close();

                                    //Clear all the Inputs
                                    itemCategory.SelectedIndex = -1;
                                    itemBrand.SelectedIndex = -1;
                                    itemSize.Text = "";
                                    itemSize.SelectedIndex = -1;
                                    itemDescription.Clear();
                                    unitCost.Clear();
                                    mrPrice.Clear();
                                    maxDiscount.Clear();
                                    itemQuantity.Clear();
                                }
                                else
                                {
                                    string Message = "Input feild(s) are Not Valid, \nPlease checked the fields!";
                                    string warning = "Warning";
                                    MessageBox.Show(Message, warning);
                                }
                            }
                            else
                            {
                                string Message = "Input feild(s) are Not in Range, \nPlease checked the fields!";
                                string warning = "Warning";
                                MessageBox.Show(Message, warning);
                            }
                        }
                        else
                        {
                            string Message = "Input feild(s) are Not Valid, \nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }
                    }
                    else
                    {
                        string Message = "This Item Code is not in the database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
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

        private void deleteUpate_Click(object sender, EventArgs e)
        {
            try
            {
                string availableItem = ""; //Selected itemid holder
                string availableItemBrand = "";
                string availableItemCategory = "";

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                string message = "Are you sure want to delete this item?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //Get itemid form Database
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = '" + itemCode.Text.Trim() + "'; ";
                    SqlDataReader read0 = cmd.ExecuteReader();
                    if (read0.Read())
                    {
                        availableItem = read0["itemid"].ToString().Trim();
                    }
                    read0.Close();

                    if (availableItem == itemCode.Text.Trim())
                    {
                        //Get itemid form Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brand.brandname, category.categoryname FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + itemCode.Text.Trim() + "' ; ";
                        SqlDataReader read1 = cmd.ExecuteReader();
                        if (read1.Read())
                        {
                            availableItemBrand = read1["brandname"].ToString().Trim();
                            availableItemCategory = read1["categoryname"].ToString().Trim();
                        }
                        read1.Close();

                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM item WHERE itemid= '" + itemCode.Text.Trim() + "';";
                        cmd.ExecuteNonQuery();

                        string Message = $"Item Code : {availableItem}, {availableItemBrand} {availableItemCategory} is successfully deleted!";
                        string Success = "Success";
                        MessageBox.Show(Message, Success);

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        //Select Max itemcode
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                        SqlDataReader read = cmd.ExecuteReader();

                        //Set userId
                        if (read.Read() == false)
                        {
                            itemCode.Text = "1000001";
                        }
                        else
                        {
                            int value = int.Parse(read["itemid"].ToString().Trim()) + 1;
                            itemCode.Text = value.ToString();
                        }
                        read.Close();

                        //Clear all the Inputs
                        itemCategory.SelectedIndex = -1;
                        itemBrand.SelectedIndex = -1;
                        itemSize.Text = "";
                        itemSize.SelectedIndex = -1;
                        itemDescription.Clear();
                        unitCost.Clear();
                        mrPrice.Clear();
                        maxDiscount.Clear();
                        itemQuantity.Clear();
                    }
                    else
                    {
                        string Message = "This Item Code is not in the database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
                }
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
                string availableItem = ""; //Selected itemid holder

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get itemid form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = '" + itemCode.Text.Trim() + "'; ";
                SqlDataReader read1 = cmd.ExecuteReader();
                if (read1.Read())
                {
                    availableItem = read1["itemid"].ToString().Trim();
                }
                read1.Close();

                if ( availableItem == itemCode.Text.Trim() || itemBrand.Text.Trim() != "" || itemCategory.Text.Trim() != "" || itemDescription.Text != "" || unitCost.Text != "" || mrPrice.Text != "" || maxDiscount.Text != "" || itemQuantity.Text != "") 
                {
                    string message = $"Are you sure want to clear the inputs?";
                    string title = "Clear";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Select Max itemcode
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT itemid FROM item WHERE itemid = (SELECT MAX(itemid) FROM item);";
                        SqlDataReader read = cmd.ExecuteReader();

                        //Set userId
                        if (read.Read() == false)
                        {
                            itemCode.Text = "1000001";
                        }
                        else
                        {
                            int value = int.Parse(read["itemid"].ToString().Trim()) + 1;
                            itemCode.Text = value.ToString();
                        }
                        read.Close();

                        //Clear all the Inputs
                        itemCategory.SelectedIndex = -1;
                        itemBrand.SelectedIndex = -1;
                        itemSize.Text = "";
                        itemSize.SelectedIndex = -1;
                        itemDescription.Clear();
                        unitCost.Clear();
                        mrPrice.Clear();
                        maxDiscount.Clear();
                        itemQuantity.Clear();
                    }
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

        private void itemDataViwer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                int index;
                index = e.RowIndex;

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(itemid) FROM item;";
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
                    DataGridViewRow dataGridViewRowrow = itemDataViwer.Rows[index];
                    string itemId = dataGridViewRowrow.Cells[0].Value.ToString();

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT item.itemid, brand.brandname, category.categoryname, item.size, item.mrprice, item.unitcost, item.maxdiscount, item.quantity, item.description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + itemId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    read.Read();
                    if (read.HasRows)
                    {
                        itemCode.Text = read["itemid"].ToString().Trim();
                        itemBrand.Text = read["brandname"].ToString();
                        itemCategory.Text = read["categoryname"].ToString();
                        itemSize.Text = read["size"].ToString().Trim();
                        itemDescription.Text = read["description"].ToString().Trim();
                        //Discount
                        int discount = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("maxdiscount")));
                        maxDiscount.Text =  discount.ToString().Trim();
                        //Prize
                        int prize = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("mrprice")));
                        mrPrice.Text = prize.ToString().Trim();
                        //Unit Cost
                        int cost = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("unitcost")));
                        unitCost.Text = cost.ToString().Trim();

                        itemQuantity.Text = read["quantity"].ToString().Trim();
                    }
                    else
                    {
                        string errorMessage = "No data available!";
                        string error = "Warningr";
                        MessageBox.Show(errorMessage, error);
                    }
                    read.Close();

                    conn.db_connect_close(); //Connection Close
                }
            }
            catch(Exception ex ) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void resetItemTable_Click(object sender, EventArgs e)
        {
            try
            {
                branSearchCombo.SelectedIndex = -1; //Reset
                catSearchCombo.SelectedIndex = -1; //Reset
                search.SelectedIndex = -1; //Text Reset
                //Serach Price clear
                searchPrice.Clear();
                price.Checked = false;
                quantity.Checked = false;
                searchPrice.Enabled = false;
                search.ResetText();

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                itemDataViwer.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        private void branSearchCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void catSearchCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void searchPrice_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void price_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabled();
        }

        private void quantity_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabled();
        }

        private void UpdateEnabled()
        {
            searchPrice.Enabled = price.Checked || quantity.Checked;
        }

        protected void SearchMethod()
        {
            try
            {
                string text = search.Text.Trim();
                string catCombo = "";
                string branCombo = "";
                string textNum = searchPrice.Text.Trim();

                //catCombo assignment
                if(catSearchCombo.SelectedValue == null)
                {
                    catCombo = "";
                }
                else
                {
                    catCombo = catSearchCombo.SelectedValue.ToString().Trim();
                }

                //brandCombo assignment
                if (branSearchCombo.SelectedValue == null)
                {
                    branCombo = "";
                }
                else
                {
                    branCombo = branSearchCombo.SelectedValue.ToString().Trim();
                }

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                if (searchPrice.Enabled == true) {
                    if (price.Checked == true)
                    {
                        if (text != "" && catCombo == "" && branCombo == "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo == "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo != "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo != "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' AND mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo != "" && branCombo != "" && textNum != "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' AND mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo != "" && textNum != "")
                        {
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' AND mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo == "" && textNum != "")
                        {
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                        else if (text == "" && catCombo != "" && branCombo == "" && textNum == "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE  item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo != "" && textNum == "")
                        {
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                        else if (text != "" && catCombo == "" && branCombo != "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size  LIKE '" + text + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo == "" && branCombo != "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.brandid = '" + branCombo + "' AND mrprice LIKE '" + textNum + "' unitcost LIKE '" + textNum + "'  ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo == "" && branCombo == "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo != "" && branCombo == "" && textNum != "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            textNum = "%" + searchPrice.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE mrprice LIKE '" + textNum + "' OR unitcost LIKE '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo == "" && textNum == "")
                        {
                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                    }
                    else if(quantity.Checked == true)
                    {
                        if (text != "" && catCombo == "" && branCombo == "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo == "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo != "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo != "" && branCombo != "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' AND quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo != "" && branCombo != "" && textNum != "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' AND quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo != "" && textNum != "")
                        {
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' AND quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo == "" && textNum != "")
                        {
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                        else if (text == "" && catCombo != "" && branCombo == "" && textNum == "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE  item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo != "" && textNum == "")
                        {
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                        else if (text != "" && catCombo == "" && branCombo != "" && textNum == "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            branCombo = branSearchCombo.SelectedValue.ToString();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size  LIKE '" + text + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo == "" && branCombo != "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            branCombo = branSearchCombo.SelectedValue.ToString();
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.brandid = '" + branCombo + "' AND quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text != "" && catCombo == "" && branCombo == "" && textNum != "")
                        {
                            text = "%" + search.Text.Trim() + "%";
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo != "" && branCombo == "" && textNum != "")
                        {
                            catCombo = catSearchCombo.SelectedValue.ToString();
                            textNum = searchPrice.Text.Trim();

                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE quantity = '" + textNum + "' ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;

                            conn.db_connect_close(); //Connection Close
                        }
                        else if (text == "" && catCombo == "" && branCombo == "" && textNum == "")
                        {
                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                            SqlDataAdapter dataAdap = new SqlDataAdapter();
                            DataTable dataTable = new DataTable();
                            dataAdap.SelectCommand = cmd;
                            dataAdap.Fill(dataTable);
                            itemDataViwer.DataSource = dataTable;
                        }
                    }
                    
                }
                else
                {
                    if (text != "" && catCombo == "" && branCombo == "")
                    {
                        text = "%" + search.Text.Trim() + "%";

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text != "" && catCombo != "" && branCombo == "")
                    {
                        text = "%" + search.Text.Trim() + "%";
                        catCombo = catSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text != "" && catCombo != "" && branCombo != "")
                    {
                        text = "%" + search.Text.Trim() + "%";
                        catCombo = catSearchCombo.SelectedValue.ToString();
                        branCombo = branSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size LIKE '" + text + "' AND item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text == "" && catCombo != "" && branCombo != "")
                    {
                        catCombo = catSearchCombo.SelectedValue.ToString();
                        branCombo = branSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text == "" && catCombo == "" && branCombo != "")
                    {
                        branCombo = branSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text == "" && catCombo != "" && branCombo == "")
                    {
                        catCombo = catSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE  item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                    else if (text != "" && catCombo == "" && branCombo != "")
                    {
                        text = "%" + search.Text.Trim() + "%";
                        branCombo = branSearchCombo.SelectedValue.ToString();

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.unitcost AS Cost, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE size  LIKE '" + text + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        itemDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
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
