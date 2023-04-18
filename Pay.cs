using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PosSystem
{
    public partial class Pay : Form
    {
        string Bill = "";
        string Time = "";
        decimal PRI = 0;
        string Username;

        private PrintDocument printDocument; //Document 

        public Pay(string BILL, string UN)
        {
            InitializeComponent();
            Bill = BILL; //Bill Number

            Username = UN; //Set Username

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            BillNum.Text = Bill;

            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get Price from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT price, pricebd, quantity, discount FROM temp_bill;";
                SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
                DataTable dataTableOfBill = new DataTable();
                dataAdapOfBill.SelectCommand = cmd;
                dataAdapOfBill.Fill(dataTableOfBill);

                int returnPrice = 0;//Return Full Amount

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

                //Total Price, Discount and Quantity
                decimal PRICE = 0;

                foreach (DataRow row in dataTableOfBill.Rows)
                {
                    PRI = decimal.Parse(row["price"].ToString().Trim());
                    int QUN = int.Parse(row["quantity"].ToString().Trim());
                    PRICE = PRICE + PRI * QUN;
                }

                //Amount
                Amount.Text = (PRICE - returnPrice).ToString().Trim();

                conn.db_connect_close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessBill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CashReceived.Text.Trim()))
            {
                if (decimal.Parse(CashReceived.Text) >= decimal.Parse(Amount.Text)) //Check if the input
                {
                    //Today
                    DateTime today = DateTime.Now;
                    Time = today.ToString("yyyy-MM-dd hh:mm:ss");

                    int ReturnPrice = 0; //Return Price Total

                    //Total Price, Discount and Quantity
                    decimal PRICE = 0;
                    decimal DISCOUNT = 0;
                    decimal PRICEBD = 0;
                    int QUANTITY = 0;

                    //Get All Data From temp_biil and temp_return

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();
                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    //Get All from temp_bill
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM temp_bill;";
                    SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
                    DataTable dataTableOfBill = new DataTable();
                    dataAdapOfBill.SelectCommand = cmd;
                    dataAdapOfBill.Fill(dataTableOfBill);

                    //Get All from temp_return
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM temp_return;";
                    SqlDataAdapter dataAdapOfReturn = new SqlDataAdapter();
                    DataTable dataTableOfReturn = new DataTable();
                    dataAdapOfReturn.SelectCommand = cmd;
                    dataAdapOfReturn.Fill(dataTableOfReturn);

                    //Get ALL from temp_return
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
                            ReturnPrice = prices;
                        }
                    }
                    readSUM.Close();

                    //Get ALL from temp_bill
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT price, pricebd, quantity, discount FROM temp_bill;";
                    SqlDataAdapter dataAdapOfBills = new SqlDataAdapter();
                    DataTable dataTableOfBills = new DataTable();
                    dataAdapOfBills.SelectCommand = cmd;
                    dataAdapOfBills.Fill(dataTableOfBills);

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

                    PRICE = PRICE - ReturnPrice; //Net Price After the Deducting the Returns

                    //Connection Close
                    conn.db_connect_close();

                    //SQL Connection Establish Variable
                    SqlConnection con = null;

                    //Begin Transaction
                    SqlTransaction transaction = null;

                    SqlCommand CMD = null; //SQL Command

                    try
                    {
                        //SQL Connection Established 
                        con = new SqlConnection("Data source=DESKTOP-8LCK4KI;initial catalog=pos;Integrated Security=true");
                        con.Open();

                        //SQL Statments
                        string deductItem = "UPDATE item SET item.quantity = item.quantity - temp_bill.quantity FROM temp_bill WHERE item.itemid = temp_bill.itemid;";
                        string addItem = "UPDATE item SET item.quantity = item.quantity + temp_return.quantity FROM temp_return WHERE item.itemid = temp_return.itemid;";
                        string deductBillItem = "UPDATE billitem SET billitem.quantity = billitem.quantity - temp_return.quantity FROM temp_return WHERE billitem.itemid = temp_return.itemid AND billitem.billnumber = temp_return.billnumber;";
                        string insertBillItem = "INSERT INTO billitem (billnumber,itemid,quantity,soldprice,discount) VALUES ";
                        string insertBill = "INSERT INTO bill (billnumber,totalprice,items,totalbeforediscount,discount,time,returnprice,processor) VALUES ";
                        string insertReturn = "INSERT INTO returns (itemid,quantity,billnumber,beforebillnumber,time,username) VALUES ";

                        //Count of Datatabels Rows 
                        int countBill = dataTableOfBill.Rows.Count;
                        int countReturn = dataTableOfBill.Rows.Count;

                        //Counters
                        int i = 0;
                        int j = 0;

                        //Find temp_return has Data Rows
                        if (dataTableOfReturn.Rows.Count > 0)
                        {
                            //Read one by one line 
                            foreach (DataRow row in dataTableOfReturn.Rows)
                            {
                                if (i + 1 == countBill)
                                {
                                    insertReturn = insertReturn + "('" + row["itemid"].ToString() + "','" + row["quantity"].ToString() + "','" + Bill + "','" + row["billnumber"].ToString() + "','" + Time + "','" + Username + "');";
                                }
                                else
                                {
                                    insertReturn = insertReturn + "('" + row["itemid"].ToString() + "','" + row["quantity"].ToString() + "','" + Bill + "','" + row["billnumber"].ToString() + "','" + Time + "','" + Username + "'),";
                                }

                                //COunting Happen
                                i++;
                            }
                        }

                        //Find temp_bill has Data Rows
                        foreach (DataRow row in dataTableOfBill.Rows)
                        {
                            if (j + 1 == countBill)
                            {
                                insertBillItem = insertBillItem + "('" + Bill.Trim() + "','" + row["itemid"].ToString() + "','" + int.Parse(row["quantity"].ToString()) + "','" + decimal.Parse(row["price"].ToString()) + "','" + decimal.Parse(row["discount"].ToString()) + "');";
                            }
                            else
                            {
                                insertBillItem = insertBillItem + "('" + Bill.Trim() + "','" + row["itemid"].ToString() + "','" + int.Parse(row["quantity"].ToString()) + "','" + decimal.Parse(row["price"].ToString()) + "','" + decimal.Parse(row["discount"].ToString()) + "'),";
                            }

                            //COunting Happen
                            j++;
                        }

                        //Set Bill Data Insertions
                        insertBill = insertBill + "('" + Bill.Trim() + "','" + PRICE + "','" + QUANTITY + "','" + PRICEBD + "','" + DISCOUNT + "','" + Time + "','" + ReturnPrice + "','" + Username + "');";


                        //Begin Transaction
                        transaction = con.BeginTransaction();

                        CMD = new SqlCommand(insertBill, con); //Bill Tabel Insert
                        CMD.Transaction = transaction;
                        CMD.ExecuteNonQuery();

                        CMD = new SqlCommand(deductItem, con); //Deduct from Items
                        CMD.Transaction = transaction;
                        CMD.ExecuteNonQuery();

                        CMD = new SqlCommand(insertBillItem, con); //InsertBillItem
                        CMD.Transaction = transaction;
                        CMD.ExecuteNonQuery();

                        if (dataTableOfReturn.Rows.Count > 0)
                        {
                            CMD = new SqlCommand(insertReturn, con); //Insert Return
                            CMD.Transaction = transaction;
                            CMD.ExecuteNonQuery();

                            CMD = new SqlCommand(deductBillItem, con); //Deduct from BillItem
                            CMD.Transaction = transaction;
                            CMD.ExecuteNonQuery();

                            CMD = new SqlCommand(addItem, con); //Item Tabel Plus
                            CMD.Transaction = transaction;
                            CMD.ExecuteNonQuery();
                        };


                        transaction.Commit(); //Commit The Transaction

                        //Transaction Of All Part
                        //Bill Table Update *
                        //Item Table Update (Deduct Item Quantity) *
                        //Bill_Item Table Update *

                        /*

                        Update The Item Tabel(Deduct Items)
                        UPDATE item SET item.quantity = item.quantity - temp_bill.quantity FROM temp_bill WHERE item.itemid = temp_bill.itemid;

                        Update The Item Tabel(Add Items)
                        UPDATE item SET item.quantity = item.quantity + temp_return.quantity FROM temp_return WHERE item.itemid = temp_return.itemid;

                        //Insert to the billitem
                        INSERT INTO billitem (billnumber,itemid,quantity,soldprice,discount)
                        VALUES 

                        //Insert to the bill
                        INSERT INTO bill (billnumber,totalprice,items,totalbeforediscount,discount,time,returnprice,processor)
                        VALUES 

                        //Insert to the return
                        INSERT INTO return (itemid,quntity,billnumber,beforebillnumber,time,username)
                        VALUES 

                         */
                        //con.Close();

                        string Message = "Your Balance is " + (decimal.Parse(CashReceived.Text) - decimal.Parse(Amount.Text)).ToString();
                        string good = "Balance Window";
                        MessageBox.Show(Message, good, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                        printPreviewDialog.Document = printDocument;
                        printPreviewDialog.ShowDialog();

                        con.Close();

                        this.Close(); //Window Close

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        string errorMessage = ex.ToString();
                        string error = "Error";
                        MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int ReturnPrice = 0; //Return Price Total

            //Total Price, Discount and Quantity
            decimal PRICE = 0;
            decimal DISCOUNT = 0;
            decimal PRICEBD = 0;
            int QUANTITY = 0;

            //Get All Data From temp_biil and temp_return

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();
            SqlCommand cmd = new SqlCommand(); //SQL command reader

            //Get All from temp_bill
            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT * FROM temp_bill;";
            SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
            DataTable dataTableOfBill = new DataTable();
            dataAdapOfBill.SelectCommand = cmd;
            dataAdapOfBill.Fill(dataTableOfBill);

            //Get ALL from temp_return
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
                    ReturnPrice = prices;
                }
            }
            readSUM.Close();

            //Get ALL from temp_bill
            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT price, pricebd, quantity, discount FROM temp_bill;";
            SqlDataAdapter dataAdapOfBills = new SqlDataAdapter();
            DataTable dataTableOfBills = new DataTable();
            dataAdapOfBills.SelectCommand = cmd;
            dataAdapOfBills.Fill(dataTableOfBills);

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

            PRICE = PRICE - ReturnPrice; //Net Full Amount of a Bill

            //Connection Close
            conn.db_connect_close();

            e.PageSettings.PaperSize = new PaperSize("Custom", 800, 1100);
            e.PageSettings.Margins = new Margins(0, 0, 0, 0);

            // Create a graphics object
            Graphics g = e.Graphics;
            

            /*List<string[]> tableData = new List<string[]>{
                new string[] { "Aramani Excahnge T-Shirt", "1000004", "20", "1000.00", "200.00", "5222.00"},
                new string[] { "Product Piyumal Priyanga senarathna", "1000004", "10", "5222.00", "500.00", "5222.00" },
                new string[] { "Product Piyumal Priyanga senarathna", "1000004", "30", "8222.00", "240.00", "52222.00" },
            };*/

            // Set up the bill template
            string header = "Style NewAge BFO";
            string dividerSLine = new string('-', 34);
            string dividerDLine = new string('=', 34);
            string footer = String.Format("{0,0}", "Thank you for your purchase!");

            // Format the table data
            string headings = String.Format("{0,-7} {1,-2} {2,-7} {3,-7} {4,-6}",
                    "Item", "Q", "UnitP.", "Disc", "Amount");

            List<string> lines = new List<string>();
            /*foreach (string[] row in tableData)
            {
                string line1 = String.Format("{0,-15}", row[0].PadRight(30));
                string line2 = String.Format("{0,-5} {1,2} {2,5} {3,4} {4,8}",
                    row[1], row[2], row[3], row[4], row[5]);
                lines.Add(line1);
                lines.Add(line2);
            }*/

            foreach (DataRow row in dataTableOfBill.Rows)
            {
                string line1 = String.Format("{0,-15}", row["brand"].ToString().Trim() + " " + row["category"].ToString().Trim() +" "+ row["size"].ToString().Trim().PadRight(30));
                string line2 = String.Format("{0,-5} {1,2} {2,5} {3,4} {4,8}",
                    row["itemid"].ToString().Trim(), row["quantity"].ToString().Trim(), row["pricebd"].ToString().Trim(), row["discount"].ToString().Trim(), decimal.Parse(row["price"].ToString().Trim())* int.Parse(row["quantity"].ToString().Trim()));
                lines.Add(line1);
                lines.Add(line2);
            }

            // Generate the bill
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine(header);
            sb.AppendLine(String.Format("{0}", "Address"));
            sb.AppendLine(String.Format("{0}", "Tell: 0779142408"));
            sb.AppendLine(dividerSLine);
            sb.AppendLine(String.Format("{0,-6} {1,12}", "Date & Time", Time));
            sb.AppendLine(String.Format("{0,4} {1,8}", "Salesman", Username));
            sb.AppendLine(dividerSLine);
            sb.AppendLine(String.Format("{0,-12} {1,20}", "Bill Number", Bill));;
            sb.AppendLine(dividerDLine);
            sb.AppendLine(headings);
            sb.AppendLine(dividerDLine);
            foreach (string line in lines)
            {
                sb.AppendLine(line);
            }
            sb.AppendLine(dividerSLine);
            sb.AppendLine(String.Format("{0,-15} {1,11}", "Total (Befor Discount)", PRICEBD));
            sb.AppendLine(String.Format("{0,-16} {1,17}", "Discount", DISCOUNT));
            sb.AppendLine(String.Format("{0,-16} {1,17}", "Return", ReturnPrice));
            sb.AppendLine(String.Format("{0,-16} {1,17}", "Total", PRICE));
            sb.AppendLine(dividerDLine);
            sb.AppendLine(String.Format("{0,-16} {1,17}", "Number of Units", QUANTITY));
            sb.AppendLine(dividerSLine);
            sb.AppendLine(footer);
            sb.AppendLine(dividerSLine);
            sb.AppendLine(String.Format("{0}", "If you want to return items,"));
            sb.AppendLine(String.Format("{0}", "Return the item(s) & Bill"));
            sb.AppendLine(String.Format("{0}", "Within 7 days."));
            sb.AppendLine(String.Format("{0}", "- Thank You! -"));
            sb.AppendLine(dividerSLine);
            sb.AppendLine("");
            sb.AppendLine(dividerDLine);
            sb.AppendLine("");
            sb.AppendLine("");


            // Print the bill
            g.DrawString(sb.ToString(), new Font("Courier New", 14), Brushes.Black, new PointF(0, 0));
            //g.DrawString(sb.ToString(), new Font("Courier New", 24), Brushes.Black, new PointF(0, 0));

        }

    }
}
