using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PosSystem
{
    public partial class Cashier_Form : Form
    {
        string Username;
        string Firstname;
        string JRole;

        public Cashier_Form(String UN, String FN, String Role)
        {
            InitializeComponent();
            Dash_Cashier au = new Dash_Cashier();
            posUserControl(au);

            user.Text = FN;

            //Assign Passed Values
            Username = UN;
            Firstname = FN;
            JRole = Role;
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

        private void pos_Click(object sender, EventArgs e)
        {
            Admin_Pos f3 = new Admin_Pos(Username, JRole);
            f3.ShowDialog();
            Visible = true;
        }

        private void Cashier_Form_Load(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure want logout the system?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                loginForm f = new loginForm();
                f.Show();
                Visible = false;
            }
            else
            {
                //Do nothing
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
