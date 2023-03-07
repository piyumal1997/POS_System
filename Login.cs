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
    public partial class loginForm : Form
    {
        Timer timer = null;

        public loginForm()
        {
            InitializeComponent();
            Connection conn = new Connection();
            conn.db_connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set date to the text box
            /*var date = DateTime.Now;
            string todayDate = date.ToString("yyyy-MM-dd hh:mm:ss");
            todayDateView.Text = todayDate;*/
            StartTimer();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" && password.Text == "")
            {
                //Do nothing
            }
            else
            {
                string message = "Are you sure want clear the inputs?";
                string title = "Clear";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    userName.Clear();
                    password.Clear();
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want close the application?";
            string title = "Close";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
                
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader
                
                string Username = userName.Text.Trim();
                string Password = password.Text.Trim();

                AdminDash f2 = new AdminDash();
                f2.Show();
                Visible = false;

                conn.db_connect_close();//DB Connection Close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }
        
        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            todayDateView.Text = DateTime.Now.ToString();
        }

    }
}
