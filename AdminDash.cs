﻿using System;
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
    public partial class AdminDash : Form
    {
        string Username;
        string Firstname;
        string JRole;
        public AdminDash(String UN, String FN, String Role)
        {
            InitializeComponent();
            Dash_Admins au = new Dash_Admins();
            posUserControl(au);

            user.Text = FN;

            //Assign Passed Values
            Username = UN;
            Firstname = FN;
            JRole = Role;
        }

        private void posUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront(); 
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Add_Items au = new Add_Items();
            posUserControl(au);
        }

        private void summaryStatus_Click(object sender, EventArgs e)
        {
            Summary au = new Summary();
            posUserControl(au);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Add_User au = new Add_User(JRole);
            posUserControl(au);
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dash_Admins au = new Dash_Admins();
            posUserControl(au);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dash_Admins au = new Dash_Admins();
            posUserControl(au);
        }

        private void pos_Click(object sender, EventArgs e)
        {
            Admin_Pos f3 = new Admin_Pos(Username,JRole);
            f3.ShowDialog();
            Visible = true;
        }

        private void addCandB_Click(object sender, EventArgs e)
        {
            Add_BandC au = new Add_BandC();
            posUserControl(au);
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            Add_Supplier au = new Add_Supplier(JRole);
            posUserControl(au);
        }

        private void barcodePrint_Click(object sender, EventArgs e)
        {
            Barcode_Generator au = new Barcode_Generator();
            posUserControl(au);
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Inventory_Order au = new Inventory_Order(JRole);
            posUserControl(au);
        }

        private void viewInventory_Click(object sender, EventArgs e)
        {
            View_Inventory au = new View_Inventory();
            posUserControl(au);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportGen_Click(object sender, EventArgs e)
        {
            ReportGen au = new ReportGen();
            posUserControl(au);
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
    }
}
