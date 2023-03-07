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
    public partial class Cashier_Form : Form
    {
        public Cashier_Form()
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

        private void ItemSearch_Click(object sender, EventArgs e)
        {
            Item_Search_Cashier au = new Item_Search_Cashier();
            posUserControl(au);
        }
    }
}
