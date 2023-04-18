using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PosSystem
{
    public partial class Add_Supplier : UserControl
    {
        string session;
        int rowCount;
        public Add_Supplier(string JRole)
        {
            InitializeComponent();
            session = JRole;
        }

        private void Add_Sipplier_Load(object sender, EventArgs e)
        {
            try
            {
                //Generate the User ID based on Database
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //Row count on employee
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //SQL command execute
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = (SELECT MAX(supplierid) FROM supplier);";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                if (read.Read() == false)
                {
                    supplierId.Text = "50001";
                }
                else
                {
                    int value = int.Parse(read["supplierid"].ToString().Trim()) + 1;
                    supplierId.Text = value.ToString();
                }
                read.Close();

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");
                todayD.Text = todayDate;

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate  FROM supplier ORDER BY supplierid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                supplierDataView.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close

            }
            catch (Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                supplier Supplier = new supplier(supplierId.Text.Trim(), supplierName.Text.Trim(), supplierMobile.Text.Trim(), supplierLandline.Text.Trim(), supplierEmail.Text.Trim(), supplierAddress.Text.Trim(), supplierStatus.Text.Trim());

                if (Supplier.SupplierId != "0" && Supplier.SupplierName != "0" && Supplier.MobileCon != "0" && Supplier.LandlineCon != "0" && Supplier.Email != "0" && Supplier.Address != "0" && Supplier.Status != "0") 
                {
                    //Check wether landline, mobile, email are already exist in the sysytem
                    string landContact = ""; //For landlineno data holding
                    string mobileContact = ""; //For mobileno data holding
                    string email = ""; //For email data holding
                    string suppId = ""; //For supplierid data hlding

                    //Get landlineno
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT landlineno FROM supplier WHERE landlineno = '" + Supplier.LandlineCon + "'; ";
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        landContact = read["landlineno"].ToString().Trim();
                    }
                    read.Close();

                    //Get mobileno
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT mobileno FROM supplier WHERE mobileno = '" + Supplier.MobileCon + "'; ";
                    SqlDataReader read1 = cmd.ExecuteReader();
                    if (read1.Read())
                    {
                        mobileContact = read1["mobileno"].ToString().Trim();
                    }
                    read1.Close();

                    //Get landlineno
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT email FROM supplier WHERE email = '" + Supplier.Email + "'; ";
                    SqlDataReader read2 = cmd.ExecuteReader();
                    if (read2.Read())
                    {
                        email = read2["email"].ToString().Trim();
                    }
                    read2.Close();

                    //Get supplierid
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = '" + Supplier.SupplierId + "'; ";
                    SqlDataReader read3 = cmd.ExecuteReader();
                    if (read3.Read())
                    {
                        suppId = read3["supplierid"].ToString().Trim();
                    }
                    read3.Close();

                    if (suppId != Supplier.SupplierId)
                    {
                        if (mobileContact != Supplier.MobileCon)
                        {
                            if (landContact != Supplier.LandlineCon)
                            {
                                if (email != Supplier.Email)
                                {
                                    //Insert the data into the Supplier
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos INSERT INTO supplier VALUES ('" + Supplier.SupplierId + "','" + Supplier.SupplierName + "','" + Supplier.MobileCon + "','" + Supplier.LandlineCon + "','" + Supplier.Email + "','" + Supplier.Address + "','" + session + "','" + todayD.Text.Trim() + "','" + Supplier.Status + "',NUll,NULL);";
                                    cmd.ExecuteNonQuery();

                                    //Successful Added Message
                                    string message = $"{Supplier.SupplierName} successfully added to the system!";
                                    string title = "Success";
                                    MessageBox.Show(message, title);

                                    //View in data grid view
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate  FROM supplier ORDER BY supplierid DESC;";
                                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                                    DataTable dataTable = new DataTable();
                                    dataAdap.SelectCommand = cmd;
                                    dataAdap.Fill(dataTable);
                                    supplierDataView.DataSource = dataTable;

                                    //SQL command execute
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = (SELECT MAX(supplierid) FROM supplier);";
                                    SqlDataReader read4 = cmd.ExecuteReader();

                                    //Set userId
                                    if (read4.Read() == false)
                                    {
                                        supplierId.Text = "50001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read4["supplierid"].ToString().Trim()) + 1;
                                        supplierId.Text = value.ToString();
                                    }
                                    read4.Close();

                                    //Reset the form
                                    supplierName.Clear();
                                    supplierMobile.Clear();
                                    supplierLandline.Clear();
                                    supplierEmail.Clear();
                                    supplierAddress.Clear();
                                    supplierStatus.SelectedIndex = -1;
                                }
                                else
                                {
                                    string warningMessage = "This E-mail alredy exist!";
                                    string warning = "Warning";
                                    MessageBox.Show(warningMessage, warning);
                                }
                            }
                            else
                            {
                                string warningMessage = "This Landline Number alredy exist!";
                                string warning = "Warning";
                                MessageBox.Show(warningMessage, warning);
                            }
                        }
                        else
                        {
                            string warningMessage = "This Mobile Number alredy exist!";
                            string warning = "Warning";
                            MessageBox.Show(warningMessage, warning);
                        }
                    }
                    else
                    {
                        string warningMessage = "This Supplier Id is alredy exist!";
                        string warning = "Warning";
                        MessageBox.Show(warningMessage, warning);

                        //Reset the form
                        supplierName.Clear();
                        supplierMobile.Clear();
                        supplierLandline.Clear();
                        supplierEmail.Clear();
                        supplierAddress.Clear();
                        supplierStatus.SelectedIndex = -1;

                        //SQL command execute
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = (SELECT MAX(supplierid) FROM supplier);";
                        SqlDataReader read5 = cmd.ExecuteReader();

                        //Set userId
                        if (read5.Read() == false)
                        {
                            supplierId.Text = "50001";
                        }
                        else
                        {
                            int value = int.Parse(read5["supplierid"].ToString().Trim()) + 1;
                            supplierId.Text = value.ToString();
                        }
                        read5.Close();
                    }
                }
                else
                {
                    string errorMessage = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
                    string error = "Warning";
                    MessageBox.Show(errorMessage, error);
                }

                //Database connection close
                conn.db_connect_close(); //Connection Close

            }
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void updateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure want to update?";
                string title = "Update";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    supplier Supplier = new supplier(supplierId.Text.Trim(), supplierName.Text.Trim(), supplierMobile.Text.Trim(), supplierLandline.Text.Trim(), supplierEmail.Text.Trim(), supplierAddress.Text.Trim(), supplierStatus.Text.Trim());

                    if (Supplier.SupplierId != "0" && Supplier.SupplierName != "0" && Supplier.MobileCon != "0" && Supplier.LandlineCon != "0" && Supplier.Email != "0" && Supplier.Address != "0" && Supplier.Status != "0")
                    {
                        //Check wether landline, mobile, email are already exist in the sysytem
                        string landContact = ""; //For landlineno data holding
                        string mobileContact = ""; //For mobileno data holding
                        string email = ""; //For email data holding
                        string SupplierID = ""; //For supplierid data hlding

                        //DB Connection
                        Connection conn = new Connection();
                        conn.db_connect();

                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        //Get landlineno
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = '" + Supplier.SupplierId + "';";
                        SqlDataReader read0 = cmd.ExecuteReader();
                        if (read0.Read())
                        {
                            SupplierID = read0["supplierid"].ToString().Trim();
                        }
                        read0.Close();

                        //Get landlineno
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT landlineno FROM supplier WHERE landlineno = '" + Supplier.LandlineCon + "' AND supplierid != '" + Supplier.SupplierId + "'; ";
                        SqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            landContact = read["landlineno"].ToString().Trim();
                        }
                        read.Close();

                        //Get mobileno
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT mobileno FROM supplier WHERE mobileno = '" + Supplier.MobileCon + "' AND supplierid != '" + Supplier.SupplierId + "'; ";
                        SqlDataReader read1 = cmd.ExecuteReader();
                        if (read1.Read())
                        {
                            mobileContact = read1["mobileno"].ToString().Trim();
                        }
                        read1.Close();  

                        //Get landlineno
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT email FROM supplier WHERE email = '" + Supplier.Email + "' AND supplierid != '" + Supplier.SupplierId + "'; ";
                        SqlDataReader read2 = cmd.ExecuteReader();
                        if (read2.Read())
                        {
                            email = read2["email"].ToString().Trim();
                        }
                        read2.Close();



                        //Updating Conditions
                        if (SupplierID == Supplier.SupplierId)
                        {
                            if (mobileContact != Supplier.MobileCon)
                            {
                                if (landContact != Supplier.LandlineCon)
                                {
                                    if (email != Supplier.Email)
                                    {
                                        //Update the data Supplier
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos UPDATE supplier SET suppliername = '" + Supplier.SupplierName + "', mobileno = '" + Supplier.MobileCon + "', landlineno = '" + Supplier.LandlineCon + "', email = '" + Supplier.Email + "', address = '" + Supplier.Address + "', updater = '" + session + "', updatedate = '" + todayD.Text.Trim() + "', status = '" + Supplier.Status + "' WHERE supplierid = '" + Supplier.SupplierId + "';";
                                        cmd.ExecuteNonQuery();

                                        //Successful Update Message
                                        string Message = $"{Supplier.SupplierName} successfully updated!";
                                        string success = "Success";
                                        MessageBox.Show(Message, success);

                                        //View in data grid view
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate  FROM supplier ORDER BY supplierid DESC;";
                                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                                        DataTable dataTable = new DataTable();
                                        dataAdap.SelectCommand = cmd;
                                        dataAdap.Fill(dataTable);
                                        supplierDataView.DataSource = dataTable;

                                        //SQL command execute
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = (SELECT MAX(supplierid) FROM supplier);";
                                        SqlDataReader read3 = cmd.ExecuteReader();

                                        //Set userId
                                        if (read3.Read() == false)
                                        {
                                            supplierId.Text = "50001";
                                        }
                                        else
                                        {
                                            int value = int.Parse(read3["supplierid"].ToString().Trim()) + 1;
                                            supplierId.Text = value.ToString();
                                        }
                                        read3.Close();

                                        //Reset the form
                                        supplierName.Clear();
                                        supplierMobile.Clear();
                                        supplierLandline.Clear();
                                        supplierEmail.Clear();
                                        supplierAddress.Clear();
                                        supplierStatus.SelectedIndex = -1;

                                        //Database connection close
                                        conn.db_connect_close(); //Connection Close
                                    }
                                    else
                                    {
                                        string warningMessage = "This Email alredy exist!";
                                        string warning = "Warning";
                                        MessageBox.Show(warningMessage, warning);
                                    }
                                }
                                else
                                {
                                    string warningMessage = "This Landline Number alredy exist!";
                                    string warning = "Warning";
                                    MessageBox.Show(warningMessage, warning);
                                }
                            }
                            else
                            {
                                string warningMessage = "This Mobile Number alredy exist!";
                                string warning = "Warning";
                                MessageBox.Show(warningMessage, warning);
                            }
                        }
                        else
                        {
                            string warningMessage = "This UserID not exist in the Database!";
                            string warning = "Warning";
                            MessageBox.Show(warningMessage, warning);

                            //Reset the form
                            supplierName.Clear();
                            supplierMobile.Clear();
                            supplierLandline.Clear();
                            supplierEmail.Clear();
                            supplierAddress.Clear();
                            supplierStatus.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        string Message = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void clearSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierIdValue = ""; //Database passed supplierid holder

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();
                
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //SQL command execute
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = '" + supplierId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                read.Read();
                if (read.HasRows)
                {
                    supplierIdValue = read["supplierid"].ToString().Trim();
                }
                read.Close();

                //inputs are available
                if (supplierIdValue == supplierId.Text.Trim() || supplierName.Text != "" || supplierMobile.Text != "" || supplierLandline.Text != "" || supplierEmail.Text != "" || supplierAddress.Text != "" || supplierStatus.Text != "")
                {
                    //YesNo Message box
                    string message = "Do you want to clear the inputs?";
                    string title = "Clear Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Reset the form
                        supplierName.Clear();
                        supplierMobile.Clear();
                        supplierLandline.Clear();
                        supplierEmail.Clear();
                        supplierAddress.Clear();
                        supplierStatus.SelectedIndex = -1;

                        //SQL command execute
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT supplierid FROM supplier WHERE supplierid = (SELECT MAX(supplierid) FROM supplier);";

                        //Set userId
                        int value = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                        supplierId.Text = value.ToString();

                        conn.db_connect_close();
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(ex.ToString(), error);
            }
        }

        private void supplierDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplierStatus.SelectedIndex = -1;

            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                int index;
                index = e.RowIndex;

                //Row count
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(supplierid) FROM supplier;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCount = read0.GetInt32(0);
                }
                read0.Close();

                //Condition
                if (index == -1 || index == rowCount)
                {
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = supplierDataView.Rows[index];
                    string supplierID = dataGridViewRowrow.Cells[0].Value.ToString();

                    //Select all data from particular row
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM supplier WHERE supplierid = '" + supplierID + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    read.Read();
                    if (read.HasRows)
                    {
                        supplierId.Text = read[0].ToString().Trim();
                        supplierName.Text = read[1].ToString().Trim();
                        supplierMobile.Text = read[2].ToString().Trim();
                        supplierLandline.Text = read[3].ToString().Trim();
                        supplierEmail.Text = read[4].ToString().Trim();
                        supplierAddress.Text = read[5].ToString().Trim();


                        //Status set
                        if (read[8].ToString().Trim() == "Active")
                        {
                            supplierStatus.SelectedIndex = 0;
                        }
                        else
                        {
                            supplierStatus.SelectedIndex = 1;
                        }

                    }
                    else
                    {
                        string errorMessage = "No data available!";
                        string error = "Error";
                        MessageBox.Show(errorMessage, error);

                    }
                }

                conn.db_connect_close(); //Connection Close

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            search.Clear(); //Clear search
            statusCombo.SelectedIndex = -1; //Combobox index

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate  FROM supplier ORDER BY supplierid DESC;";
            SqlDataAdapter dataAdap = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            dataAdap.SelectCommand = cmd;
            dataAdap.Fill(dataTable);
            supplierDataView.DataSource = dataTable;

            conn.db_connect_close(); //Connection Close
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SeachMethod();
        }

        private void statusCombo_TextChanged(object sender, EventArgs e)
        {
            SeachMethod();
        }

        //Search Method
        protected void SeachMethod()
        {
            try
            {
                string text = search.Text.Trim();
                string combo = statusCombo.Text.Trim();

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                if (text != "" && combo == "")
                {
                    text = "%" + search.Text.Trim() + "%"; //Set text

                    //SQL command execute
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate FROM supplier WHERE supplierid + suppliername + mobileno + landlineno + email + address LIKE '"+ text +"' ORDER BY supplierid DESC;";
                    
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    supplierDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (combo != "" && text == "")
                {
                    //DB Connection
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate FROM supplier WHERE status = '" + combo + "' ORDER BY supplierid DESC;";

                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    supplierDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text != "" && combo != "")
                {
                    text = "%" + search.Text.Trim() + "%";

                    //SQL command execute
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate FROM supplier WHERE supplierid + suppliername + mobileno + landlineno + email + address LIKE '" + text + "' AND status = '"+ combo +"' ORDER BY supplierid DESC;";

                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    supplierDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text == "" && combo == "")
                {
                    //SQL command execute
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplierid AS SupplierID, suppliername AS SupplierName, mobileno AS MobileNo, landlineno AS LandlineNo, email AS Email, address AS Address, status AS Status, adder AS Adder, addingdate as AddingDate  FROM supplier ORDER BY supplierid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    supplierDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }


            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

    }
}
