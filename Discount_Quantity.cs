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
    public partial class Discount_Quantity : Form
    {
        string item = "";
        int Quantity = 0;
        decimal Discount = 0;
        int BillQuantity = 0;
        decimal BillDiscount = 0;
        string ButtonText = "";
        int getQuantity = 0;
        int setItemDiscount = 0;
        string available = "";

        public Discount_Quantity(int Q, decimal D, int AQ, decimal AD, string CODE, string BT)
        {
            InitializeComponent();
            item = CODE;
            Quantity = Q;
            Discount = D; 
            BillQuantity = AQ; 
            BillDiscount = AD;
            ButtonText = BT;

        }

        private void Discount_Quantity_Load(object sender, EventArgs e)
        {
            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            action.Text = ButtonText;
            code.Text = item;
            AvailableQuantity.Text = Quantity.ToString();
            AvailableDiscount.Text = Discount.ToString();

            //Quantity and Discount Showing Condition
            if (ButtonText == "Add")
            {
                quantity.Text = "1"; //Set quantity text box value defaulty

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT quantity, discount FROM temp_bill WHERE itemid = '" + code.Text.Trim() + "';";
                SqlDataReader read0 = cmd.ExecuteReader();

                read0.Read();
                if (read0.HasRows)
                {
                    BillAvailableQ.Text = read0["quantity"].ToString().Trim();
                    BillAvailableD.Text = ((int)Math.Floor(read0.GetDecimal(read0.GetOrdinal("discount")))).ToString();
                    discount.Text = Decimal.ToInt32(BillDiscount).ToString(); //If Discount available, It set
                }
                else
                {
                    BillAvailableD.Text = "0";
                    BillAvailableQ.Text = "0";
                    discount.Text = "0";
                }
                read0.Close();

            }
            else
            {
                quantity.Text = BillQuantity.ToString(); ;
                BillAvailableQ.Text = BillQuantity.ToString();
                discount.Text = Decimal.ToInt32(BillDiscount).ToString();
                BillAvailableD.Text = Decimal.ToInt32(BillDiscount).ToString();
            }
            
            /*if (BillQuantity == 0)
            {
                quantity.Text = "1";
            }
            else
            {
                quantity.Text = BillQuantity.ToString();
            }*/

            //Discount Condition
            /*if (BillDiscount == 0)
            {
                discount.Text = "0";
                BillAvailableD.Text = "0";
            }
            else
            {
                discount.Text = Decimal.ToInt32(BillDiscount).ToString();
                BillAvailableD.Text = Decimal.ToInt32(BillDiscount).ToString();
            }*/
        }
        
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            /*string message = $"Are you sure want to back to the List?";
            string title = "List";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Do nothing
            }*/
        }

        private void addToBill_Click(object sender, EventArgs e)
        {
            try
            {
                int MRPrice = 0; //MRPrice Holder For Updation

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //View in data grid view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT quantity, maxdiscount FROM item WHERE itemid = '" + code.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();

                read.Read();
                if (read.HasRows)
                {
                    getQuantity = int.Parse(read["quantity"].ToString().Trim());
                    setItemDiscount = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("maxdiscount")));
                }
                else
                {
                    string errorMessage = "No data available!";
                    string error = "Warning";
                    MessageBox.Show(errorMessage, error);
                }
                read.Close();

                //Quantity Validation
                if (getQuantity >= int.Parse(quantity.Text) && int.Parse(quantity.Text) > 0)
                {
                    //Discount Validation
                    if (setItemDiscount >= int.Parse(discount.Text) && int.Parse(discount.Text) >= 0)
                    {
                        int quantityExist = 0; //Existng Quantity

                        //View in data grud view
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT itemid, quantity FROM temp_bill WHERE itemid = '" + code.Text.Trim() + "';";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        read1.Read();
                        if (read1.HasRows)
                        {
                            available = read1["itemid"].ToString().Trim();
                            quantityExist = int.Parse(read1["quantity"].ToString().Trim());
                        }
                        read1.Close();
                        
                        //ItemId available in the temp_bill condition
                        if (code.Text.Trim() == available)
                        {
                            //View in data grud view
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT mrprice FROM item WHERE itemid = '" + code.Text.Trim() + "';";
                            SqlDataReader read3 = cmd.ExecuteReader();

                            read3.Read();
                            if (read3.HasRows)
                            {
                                //Total Price
                                int prices = (int)Math.Floor(read3.GetDecimal(read3.GetOrdinal("mrprice")));
                                MRPrice = prices - int.Parse(discount.Text.Trim());
                            }
                            read3.Close();

                            //Update the Quantity in the 
                            int updateCurrentQuantity = quantityExist + int.Parse(quantity.Text.Trim());

                            if (ButtonText == "Add")
                            {
                                //Update the Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos UPDATE temp_bill SET price = '" + MRPrice + "', quantity = '" + updateCurrentQuantity + "', discount = '" + discount.Text.Trim() + "' WHERE itemid = '" + code.Text.Trim() + "';";
                                cmd.ExecuteNonQuery();
                            }
                            else if(ButtonText == "Update")
                            {
                                //Update the Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos UPDATE temp_bill SET price = '" + MRPrice + "', quantity = '" + quantity.Text.Trim() + "', discount = '" + discount.Text.Trim() + "' WHERE itemid = '" + code.Text.Trim() + "';";
                                cmd.ExecuteNonQuery();
                            }

                           

                            this.Close(); //Close Window
                        }
                        else
                        {
                            string brand = "";
                            string category = "";
                            string size = "";
                            decimal markedPrice = 0;
                            decimal price = 0;

                            //Get data from item Table
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "SELECT brand.brandname, category.categoryname, item.size, item.mrprice FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid WHERE itemid = '" + code.Text.Trim() + "';";
                            SqlDataReader read2 = cmd.ExecuteReader();

                            read2.Read();
                            if (read2.HasRows)
                            {
                                brand = read2["brandname"].ToString().Trim();
                                category = read2["categoryname"].ToString().Trim();
                                size = read2["size"].ToString().Trim();
                                markedPrice = read2.GetDecimal(read2.GetOrdinal("mrprice"));
                            }
                            read2.Close();

                            price = markedPrice - decimal.Parse(discount.Text);

                            //input to the Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos INSERT INTO temp_bill VALUES  ('" + code.Text.Trim() + "','" + brand + "','" + category + "', '" + size + "','" + markedPrice + "', '" + price + "', '" + decimal.Parse(discount.Text) + "', '" + int.Parse(quantity.Text) + "');";
                            cmd.ExecuteNonQuery();
                            this.Close();
                        }
                    }
                    else
                    {
                        string Message = "Discount is Not in Range!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
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
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
