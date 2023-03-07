using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosSystem
{
    internal class Connection
    {
        public static SqlConnection con = null;

        public void db_connect() 
        {
            con = new SqlConnection("Data source=DESKTOP-8LCK4KI;initial catalog=pos;Integrated Security=true");
            con.Open();
        }

        public void db_connect_close()
        {
            con.Close();
        }
    }
}
