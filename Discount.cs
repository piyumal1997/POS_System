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
    public partial class Discount : Form
    {
        string item = "";
        decimal Discounts = 0;
        decimal BillDiscount = 0;
        string ButtonText = "";
        public Discount(decimal D, decimal BD, string CODE, string BT)
        {
            InitializeComponent();
            item = CODE;
            Discounts = D;
            BillDiscount = BD;
            ButtonText = BT;
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

                if (Convert.ToInt32(Discounts) >= int.Parse(addDiscount.Text.Trim()))
                {
                    //Input to the Database
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos UPDATE temp_bill SET discount = '" + decimal.Parse(addDiscount.Text.Trim()) + "' WHERE itemid = '" + code.Text.Trim() + "';";
                    cmd.ExecuteNonQuery();

                    this.Close();//Close Windo
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Windows\Media\Windows Ding.wav");
                    player.Play();
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

        private void Discount_Load(object sender, EventArgs e)
        {
            action.Text = ButtonText;
            code.Text = item.Trim();
            addDiscount.Text = BillDiscount.ToString();
            AvailableDiscount.Text = Discounts.ToString();
        }
    }
}
