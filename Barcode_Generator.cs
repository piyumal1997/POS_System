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
    public partial class Barcode_Generator : UserControl
    {
        int rowCount; //Row count in item datatable

        public Barcode_Generator()
        {
            InitializeComponent();
        }

        private void printBarcode_Click(object sender, EventArgs e)
        {

        }

        private void Barcode_Generator_Load(object sender, EventArgs e)
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
                brandSearchCom.DataSource = brandSearchTable;
                brandSearchCom.DisplayMember = "brandname";
                brandSearchCom.ValueMember = "brandid";
                brandSearchCom.SelectedIndex = -1;

                //Category Search 
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category ORDER BY categoryname ASC;";
                SqlDataAdapter categorySearch = new SqlDataAdapter();
                DataTable categorySearchTable = new DataTable();
                categorySearch.SelectCommand = cmd;
                categorySearch.Fill(categorySearchTable);
                categorySearchCom.DataSource = categorySearchTable;
                categorySearchCom.DisplayMember = "categoryname";
                categorySearchCom.ValueMember = "categoryid";
                categorySearchCom.SelectedIndex = -1;

                //Serach Price clear
                //searchPrice.Clear();

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                barcodeItems.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void barcodeItems_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = barcodeItems.Rows[index];
                    string ItemId = dataGridViewRowrow.Cells[0].Value.ToString();
                    string ItemBrand = dataGridViewRowrow.Cells[1].Value.ToString();
                    string ItemCategory = dataGridViewRowrow.Cells[2].Value.ToString();
                    string Size = dataGridViewRowrow.Cells[3].Value.ToString();
                    string Price = dataGridViewRowrow.Cells[4].Value.ToString();
                    string Quantity = dataGridViewRowrow.Cells[5].Value.ToString();

                    //View in data grud view
                    itemCode.Text = ItemId.Trim();
                    itemBrand.Text = ItemBrand.Trim();
                    itemCategory.Text = ItemCategory.Trim();
                    itemQuantity.Text = Quantity.Trim();
                    itemPrice.Text = Price.Trim();

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
