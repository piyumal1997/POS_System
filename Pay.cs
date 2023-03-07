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
    public partial class Pay : Form
    {
        public static SqlConnection con = new SqlConnection("Data source=DESKTOP-8LCK4KI;initial catalog=pos;Integrated Security=true");

        string Bill = "";
        public Pay(string BILL)
        {
            InitializeComponent();
             Bill = BILL;
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

                //Total Price, Discount and Quantity
                decimal PRICE = 0;

                foreach (DataRow row in dataTableOfBill.Rows)
                {
                    decimal PRI = decimal.Parse(row["price"].ToString().Trim());
                    int QUN = int.Parse(row["quantity"].ToString().Trim());
                    PRICE = PRICE + PRI * QUN;
                }

                //Amount
                Amount.Text = PRICE.ToString().Trim();

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
            try
            {
                //Get All Data From temp_biil and temp_return
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get Price from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM temp_bill;";
                SqlDataAdapter dataAdapOfBill = new SqlDataAdapter();
                DataTable dataTableOfBill = new DataTable();
                dataAdapOfBill.SelectCommand = cmd;
                dataAdapOfBill.Fill(dataTableOfBill);

                //Get Price from temp_bill
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM temp_return;";
                SqlDataAdapter dataAdapOfReturn = new SqlDataAdapter();
                DataTable dataTableOfReturn = new DataTable();
                dataAdapOfReturn.SelectCommand = cmd;
                dataAdapOfReturn.Fill(dataTableOfReturn);

                conn.db_connect_close();

                //DB Connection
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                

                
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
