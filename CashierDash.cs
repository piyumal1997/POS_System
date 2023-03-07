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
    public partial class CashierDash : Form
    {
        public CashierDash()
        {
            InitializeComponent();
            Dash_Cashier au = new Dash_Cashier();
            posUserControl(au);
        }
        private void posUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dash_Cashier au = new Dash_Cashier();
            posUserControl(au);
        }

        private void pos_Click(object sender, EventArgs e)
        {
            Admin_Pos f3 = new Admin_Pos();
            f3.Show();
            Visible = false;
        }

        private void logOut_Click(object sender, EventArgs e)
        {

        }
    }
}
