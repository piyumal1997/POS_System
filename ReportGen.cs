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
    public partial class ReportGen : UserControl
    {
        public ReportGen()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string searchDate = DateSelector.Text;
            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader
            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT bill.billnumber, billitem.itemid, billitem.quantity, billitem.soldprice, billitem.discount, bill.totalbeforediscount, bill.discount, bill.totalprice, bill.returnprice, bill.time FROM billitem INNER JOIN bill ON bill.billnumber = billitem.billnumber WHERE datediff(day,time, '" + searchDate + "') = 0;";
            SqlDataAdapter dataAdap = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            dataAdap.SelectCommand = cmd;
            dataAdap.Fill(dataTable);

            //Crystal Report Data Loader
            CrystalReport rpt = new CrystalReport();
            rpt.SetDataSource(dataTable);
            crystalReportViewer.ReportSource = rpt;
            crystalReportViewer.RefreshReport();

            conn.db_connect_close();
        }
    }
}
