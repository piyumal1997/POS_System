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
    public partial class Qunatity_Changer : Form
    {
        string item = "";
        string bill = "";
        int AvQuantity = 0;
        string ButtonText = "";
        int AddQuantity = 0;
        string available = "";
        int getQuantity = 0;

        public Qunatity_Changer(int AQ, int Q,  string CODE, string NUM, string BT)
        {
            InitializeComponent();
            item = CODE;
            bill = NUM;
            AvQuantity = AQ;
            ButtonText = BT;
            AddQuantity = Q;
        }

        private void Qunatity_Changer_Load(object sender, EventArgs e)
        {
            action.Text = ButtonText;
            code.Text = item;
            AvailableQuantity.Text = AvQuantity.ToString();
            quantity.Text = AddQuantity.ToString();

            //Quantity Condition
            if (AddQuantity == 0)
            {
                quantity.Text = "1";
            }
            /*else
            {
                quantity.Text = AddQuantity.ToString();
            }*/

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();
                
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get Data From billitem
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT quantity FROM billitem WHERE itemid = '" + code.Text.Trim() + "' AND billnumber = '" + bill + "';";
                SqlDataReader read = cmd.ExecuteReader();

                read.Read();
                if (read.HasRows)
                {
                    getQuantity = int.Parse(read["quantity"].ToString().Trim());
                }
                else
                {
                    string errorMessage = "No data available!";
                    string error = "Warning";
                    MessageBox.Show(errorMessage, error);
                }
                read.Close();

                if (getQuantity >= int.Parse(quantity.Text.Trim()) && int.Parse(quantity.Text.Trim()) > 0)
                {
                    string available = "";

                    //Get Data From temp_return
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT itemid FROM temp_return WHERE itemid = '" + code.Text.Trim() + "' AND billnumber = '" + bill + "';";
                    SqlDataReader read1 = cmd.ExecuteReader();

                    read1.Read();
                    if (read1.HasRows)
                    {
                        available = read1["itemid"].ToString().Trim();
                    }
                    read1.Close();

                    if (available.Trim() == code.Text.Trim())
                    {
                        //Update the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos UPDATE temp_return SET quantity = '" + quantity.Text.Trim() + "' WHERE itemid = '" + code.Text.Trim() + "' AND billnumber = '" + bill + "';";
                        cmd.ExecuteNonQuery();

                        this.Close(); //Close Window
                    }
                    else
                    {
                        string brand = "";
                        string category = "";
                        decimal price = 0;

                        //Get data from item Table
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT brand.brandname, category.categoryname FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + code.Text.Trim() + "';";
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
                        cmd.CommandText = "SELECT soldprice FROM billitem WHERE itemid = '" + code.Text.Trim() + "' AND billnumber = '" + bill + "';";
                        SqlDataReader read3 = cmd.ExecuteReader();

                        read3.Read();
                        if (read3.HasRows)
                        {
                            price = read3.GetDecimal(read3.GetOrdinal("soldprice"));
                        }
                        read3.Close();

                        //input to the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos INSERT INTO temp_return VALUES  ('" + code.Text.Trim() + "','" + bill + "','" + int.Parse(quantity.Text.Trim()) + "', '" + brand + "','" + category + "', '" + price + "');";
                        cmd.ExecuteNonQuery();

                        this.Close(); //Close Window
                    }
                }
                else
                {
                    string Message = "Quantity is Not in Range!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Warning";
                MessageBox.Show(errorMessage, error);
            }
        }
    }
}
