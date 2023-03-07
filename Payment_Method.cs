using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Payment_Method : Form
    {
        string Bill = "";
        string Price = "";
        public Payment_Method(string BILL, string PRICE)
        {
            InitializeComponent();
            Bill = BILL;
            Price = PRICE;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            try
            {
                Pay fn = new Pay(Bill);
                fn.ShowDialog();
                Visible = true;
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Method_Load(object sender, EventArgs e)
        {
            BillNum.Text = Bill.Trim();
            Amount.Text = Price.Trim();
        }

    }
}
