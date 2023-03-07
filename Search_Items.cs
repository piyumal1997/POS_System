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
    public partial class Search_Items : Form
    {
        public Search_Items()
        {
            InitializeComponent();
        }

        private void Search_Items_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

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

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                searchDataViwer.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
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
            if (minPrice.Text == string.Empty && maxPrice.Text == string.Empty && catSearchCombo.SelectedValue == null && branSearchCombo.SelectedValue == null)
            {
                this.Close();
                Enabled = true;
            }
            else
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
        }

        private void catSearchCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void branSearchCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void maxPrice_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        private void minPrice_TextChanged(object sender, EventArgs e)
        {
            SearchMethod();
        }

        protected void SearchMethod()
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                string MinPrice = minPrice.Text.Trim();
                string catCombo = "";
                string branCombo = "";
                string MaxPrice = maxPrice.Text.Trim();

                if (MinPrice == null)
                {
                    MessageBox.Show("Fuck");
                }
                //catCombo assignment
                if (catSearchCombo.SelectedValue == null)
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

                //Conditions for  search
                if (catCombo == "" && branCombo == "" && string.IsNullOrEmpty(MinPrice) && string.IsNullOrEmpty(MaxPrice))
                {
                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo != "" && branCombo == "" && string.IsNullOrEmpty(MinPrice) && string.IsNullOrEmpty(MaxPrice))
                {
                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo != "" && branCombo != "" && string.IsNullOrEmpty(MinPrice) && string.IsNullOrEmpty(MaxPrice))
                {
                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo != "" && branCombo != "" && !(string.IsNullOrEmpty(MinPrice)) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    if (decimal.Parse(minPrice.Text.Trim()) <= decimal.Parse(maxPrice.Text.Trim()))
                    {
                        decimal min = decimal.Parse(MinPrice);
                        decimal max = decimal.Parse(MaxPrice);

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.brandid = '" + branCombo + "' AND item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        searchDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }

                }
                else if (catCombo == "" && branCombo != "" && !(string.IsNullOrEmpty(MinPrice)) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    if (decimal.Parse(minPrice.Text.Trim()) <= decimal.Parse(maxPrice.Text.Trim()))
                    {
                        decimal min = decimal.Parse(MinPrice);
                        decimal max = decimal.Parse(MaxPrice);

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' AND item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        searchDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }

                }
                else if (catCombo == "" && branCombo == "" && !(string.IsNullOrEmpty(MinPrice)) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    if (decimal.Parse(minPrice.Text.Trim()) <= decimal.Parse(maxPrice.Text.Trim()))
                    {
                        decimal min = decimal.Parse(MinPrice);
                        decimal max = decimal.Parse(MaxPrice);

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        searchDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }
                }
                else if (catCombo == "" && branCombo == "" && string.IsNullOrEmpty(MinPrice) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    decimal min = 0;
                    decimal max = decimal.Parse(MaxPrice);

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo != "" && branCombo == "" && !(string.IsNullOrEmpty(MinPrice)) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    if (decimal.Parse(minPrice.Text.Trim()) <= decimal.Parse(maxPrice.Text.Trim()))
                    {
                        decimal min = decimal.Parse(MinPrice);
                        decimal max = decimal.Parse(MaxPrice);

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        searchDataViwer.DataSource = dataTable;

                        conn.db_connect_close(); //Connection Close
                    }

                }
                else if (catCombo != "" && branCombo == "" && string.IsNullOrEmpty(MinPrice) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    decimal min = 0;
                    decimal max = decimal.Parse(MaxPrice);

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.categoryid = '" + catCombo + "' AND item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo == "" && branCombo != "" && string.IsNullOrEmpty(MinPrice) && !(string.IsNullOrEmpty(MaxPrice)))
                {
                    decimal min = 0;
                    decimal max = decimal.Parse(MaxPrice);

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' AND item.mrprice BETWEEN '" + min + "' AND '" + max + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (catCombo == "" && branCombo != "" && string.IsNullOrEmpty(MinPrice) && string.IsNullOrEmpty(MaxPrice))
                {
                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE item.brandid = '" + branCombo + "' ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

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

        private void resetItemTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(minPrice.Text) && string.IsNullOrEmpty(maxPrice.Text) && catSearchCombo.SelectedValue == null && branSearchCombo.SelectedValue == null) 
            {
                //Do nothing
            }
            else 
            {
                string message = $"Are you sure want to reset the table?";
                string title = "Reset";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    branSearchCombo.SelectedIndex = -1;
                    catSearchCombo.SelectedIndex = -1;
                    minPrice.Clear();
                    maxPrice.Clear();

                    //View in data grud view
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.maxdiscount AS MaxDiscount, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    searchDataViwer.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else
                {
                    //Do nothing
                }
            }
        }
    }
}
