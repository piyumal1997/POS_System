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
    public partial class Dash_Admins : UserControl
    {
        public Dash_Admins()
        {
            InitializeComponent();
        }

        private void Dash_Admins_Load(object sender, EventArgs e)
        {
            try
            {
                //Set date to the text box
                var date = DateTime.Today.AddDays(-7);
                string todayDate = date.ToString("yyyy-MM-dd");
                string dates = todayDate;

                // DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Active Users
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(employeeid) AS total FROM employee WHERE status = 'Active';";
                SqlDataReader read1 = cmd.ExecuteReader();
                read1.Read();
                if (read1.HasRows)
                {
                    ActiveUsers.Text = read1["total"].ToString().Trim();
                }
                read1.Close();

                //Active Users
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(brandid) AS count FROM brand;";
                SqlDataReader read2 = cmd.ExecuteReader();
                read2.Read();
                if (read2.HasRows)
                {
                    Brands.Text = read2["count"].ToString().Trim();
                }
                read2.Close();

                //Active Users
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(categoryid) AS count FROM category;";
                SqlDataReader read3 = cmd.ExecuteReader();
                read3.Read();
                if (read3.HasRows)
                {
                    Categories.Text = read3["count"].ToString().Trim();
                }
                read3.Close();

                //Active Users
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT SUM(quantity) AS quantity FROM item WHERE quantity > 0;";
                SqlDataReader read4 = cmd.ExecuteReader();
                read4.Read();
                if (read4.HasRows)
                {
                    Items.Text = read4["quantity"].ToString().Trim();
                }
                read4.Close();

                conn.db_connect_close();
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
