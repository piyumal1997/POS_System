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
    public partial class Inventory_Order : UserControl
    {
        string session;
        int rowCount = 0; 
        public Inventory_Order(string JRole)
        {
            InitializeComponent();
            session = JRole;
        }

        private void Inventory_Order_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                //Select Max itemcode
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                if (read.Read() == false)
                {
                    orderCode.Text = "100001";
                }
                else
                {
                    int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                    orderCode.Text = value.ToString();
                }
                read.Close();

                //Supplier set to combobox
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM supplier ORDER BY suppliername ASC;";
                SqlDataAdapter supplierAdap = new SqlDataAdapter();
                DataTable supplierTable = new DataTable();
                supplierAdap.SelectCommand = cmd;
                supplierAdap.Fill(supplierTable);
                supplierSelection.DataSource = supplierTable;
                supplierSelection.DisplayMember = "suppliername";
                supplierSelection.ValueMember = "supplierid";
                supplierSelection.SelectedIndex = -1;

                //Supplier set to searchCombo - 1
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM supplier ORDER BY suppliername ASC;";
                SqlDataAdapter supplierAdap1 = new SqlDataAdapter();
                DataTable supplierTable1 = new DataTable();
                supplierAdap1.SelectCommand = cmd;
                supplierAdap1.Fill(supplierTable1);
                selectSupplier.DataSource = supplierTable1;
                selectSupplier.DisplayMember = "suppliername";
                selectSupplier.ValueMember = "supplierid";
                selectSupplier.SelectedIndex = -1;

                //Supplier set to searchCombo - 2
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM supplier ORDER BY suppliername ASC;";
                SqlDataAdapter supplierAdap2 = new SqlDataAdapter();
                DataTable supplierTable2 = new DataTable();
                supplierAdap2.SelectCommand = cmd;
                supplierAdap2.Fill(supplierTable2);
                selectSupplier2.DataSource = supplierTable2;
                selectSupplier2.DisplayMember = "suppliername";
                selectSupplier2.ValueMember = "supplierid";
                selectSupplier2.SelectedIndex = -1;

                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS SupplierName, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                proceedingOrders.DataSource = dataTable;

                //View in complete table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS SupplierName, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                DataTable dataTableComlete = new DataTable();
                dataAdapComlete.SelectCommand = cmd;
                dataAdapComlete.Fill(dataTableComlete);
                completeOrders.DataSource = dataTableComlete;

                conn.db_connect_close(); //DB Connection close
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //WhatsApp WA = new WhatsApp(orderDescription.Text.Trim(), "0000", "Style NewAge Narammala", true);
                string availableOrder = ""; //OrderId store for condition

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                //Get orderid form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = '" + orderCode.Text.Trim() + "'; ";
                SqlDataReader read2 = cmd.ExecuteReader();
                if (read2.Read())
                {
                    availableOrder = read2["orderid"].ToString().Trim();
                }
                read2.Close();
                
                if (totalPrice.Text.Trim() != "" && quantity.Text.Trim() != "")
                {
                    if (decimal.Parse(totalPrice.Text.Trim()) >= 100 && int.Parse(quantity.Text.Trim()) > 1)
                    {
                        order Order = new order(orderCode.Text.Trim(), decimal.Parse(totalPrice.Text.Trim()), int.Parse(quantity.Text.Trim()), orderDescription.Text.Trim(), supplierSelection.SelectedValue.ToString().Trim());

                        if (Order.OrderID != "0" && Order.TotalPrice != 0 && Order.Quantity != 0 && Order.Description != "0" && Order.SupplierId != "0")
                        {
                            if (orderCode.Text.Trim() != availableOrder)
                            {
                                string message = $"Are you sure want to update Order Code : {orderCode.Text.Trim()}?";
                                string title = "Update";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.Yes)
                                {
                                    //Input to the Database
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos INSERT INTO supplyorder VALUES ('" + Order.OrderID + "','" + Order.TotalPrice + "','" + Order.Quantity + "','" + Order.Description + "','" + DateTime.Parse(todayDate) + "','" + Order.SupplierId + "','NO','" + session + "',NULL,NULL,NULL,NULL);";
                                    cmd.ExecuteNonQuery();

                                    //Successful Added Message
                                    string Message = $"{Order.OrderID} successfully added to the system!";
                                    string success = "Success";
                                    MessageBox.Show(Message, success);

                                    //View in proceedingOrders table
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                                    DataTable dataTable = new DataTable();
                                    dataAdap.SelectCommand = cmd;
                                    dataAdap.Fill(dataTable);
                                    proceedingOrders.DataSource = dataTable;

                                    //View in complete table
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                                    SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                                    DataTable dataTableComlete = new DataTable();
                                    dataAdapComlete.SelectCommand = cmd;
                                    dataAdapComlete.Fill(dataTableComlete);
                                    completeOrders.DataSource = dataTableComlete;

                                    //Select Max itemcode
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                                    SqlDataReader read = cmd.ExecuteReader();

                                    //Set userId
                                    if (read.Read() == false)
                                    {
                                        orderCode.Text = "100001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                                        orderCode.Text = value.ToString();
                                    }
                                    read.Close();

                                    //Clear Text boxes
                                    quantity.Clear();
                                    supplierSelection.SelectedIndex = -1;
                                    totalPrice.Clear();
                                    orderDescription.Clear();
                                }

                            }
                            else
                            {
                                string Message = "This Order Code already exsist in the database!";
                                string warning = "Warning";
                                MessageBox.Show(Message, warning);
                            }
                        }
                        else
                        {
                            string Message = "Input feild(s) are Not Valid or Empty, \nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }
                    }
                    else
                    {
                        string Message = "Input feild(s) are Not in Range, \nPlease checked the fields!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
                }
                else
                {
                    string Message = "Input feild(s) are Not Valid or Empty, \nPlease checked the fields!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }
                conn.db_connect_close(); //Close connection 
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void updateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string availableOrder = ""; //OrderId store for condition

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                //Get orderid form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = '" + orderCode.Text.Trim() + "'; ";
                SqlDataReader read2 = cmd.ExecuteReader();
                if (read2.Read())
                {
                    availableOrder = read2["orderid"].ToString().Trim();
                }
                read2.Close();

                //Conditions and Update
                if (orderCode.Text.Trim() == availableOrder)
                {
                    string message = $"Are you sure want to update Order Code : {orderCode.Text.Trim()}?";
                    string title = "Update";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        if (totalPrice.Text.Trim() != "" && quantity.Text.Trim() != "")
                        {
                            if (decimal.Parse(totalPrice.Text.Trim()) >= 100 && int.Parse(quantity.Text.Trim()) > 1)
                            {
                                order Order = new order(orderCode.Text.Trim(), decimal.Parse(totalPrice.Text.Trim()), int.Parse(quantity.Text.Trim()), orderDescription.Text.Trim(), supplierSelection.SelectedValue.ToString().Trim());

                                if (Order.OrderID != "0" && Order.TotalPrice != 0 && Order.Quantity != 0 && Order.Description != "0" && Order.SupplierId != "0")
                                {

                                    //Input to the Database
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos UPDATE supplyorder SET totalprice = '" + Order.TotalPrice + "', quantity = '" + Order.Quantity + "', description = '" + Order.Description + "', updatedate = '" + DateTime.Parse(todayDate) + "', supplierid = '" + Order.SupplierId + "', updator = '" + session + "' WHERE orderid = '" + Order.OrderID + "';";
                                    cmd.ExecuteNonQuery();

                                    //Successful Added Message
                                    string Message = $"Order Code : {Order.OrderID} successfully updated!";
                                    string success = "Success";
                                    MessageBox.Show(Message, success);

                                    //View in proceedingOrders table
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                                    DataTable dataTable = new DataTable();
                                    dataAdap.SelectCommand = cmd;
                                    dataAdap.Fill(dataTable);
                                    proceedingOrders.DataSource = dataTable;

                                    //View in complete table
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                                    SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                                    DataTable dataTableComlete = new DataTable();
                                    dataAdapComlete.SelectCommand = cmd;
                                    dataAdapComlete.Fill(dataTableComlete);
                                    completeOrders.DataSource = dataTableComlete;

                                    //Select Max itemcode
                                    cmd.Connection = Connection.con;
                                    cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                                    SqlDataReader read = cmd.ExecuteReader();

                                    //Set userId
                                    if (read.Read() == false)
                                    {
                                        orderCode.Text = "100001";
                                    }
                                    else
                                    {
                                        int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                                        orderCode.Text = value.ToString();
                                    }
                                    read.Close();

                                    //Clear Text boxes
                                    quantity.Clear();
                                    supplierSelection.SelectedIndex = -1;
                                    totalPrice.Clear();
                                    orderDescription.Clear();

                                    conn.db_connect_close(); //DB Connection close
                                }
                                else
                                {
                                    string Message = "Input feild(s) are Not Valid or Empty, \nPlease checked the fields!";
                                    string warning = "Warning";
                                    MessageBox.Show(Message, warning);
                                }
                            }
                            else
                            {
                                string Message = "Input feild(s) are Not in Range, \nPlease checked the fields!";
                                string warning = "Warning";
                                MessageBox.Show(Message, warning);
                            }
                        }
                        else
                        {
                            string Message = "Input feild(s) are Not Valid or Empty, \nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }
                    }
                }
                else
                {
                    string Message = "This Order Code doesnot exsist in the database!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }
                
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void clearOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string availableOrder = ""; //OrderId store for condition

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get orderid form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = '" + orderCode.Text.Trim() + "'; ";
                SqlDataReader read2 = cmd.ExecuteReader();
                if (read2.Read())
                {
                    availableOrder = read2["orderid"].ToString().Trim();
                }
                read2.Close();

                //Conditions for Clear
                if (orderCode.Text.Trim() == availableOrder && quantity.Text != "" && totalPrice.Text != "" && supplierSelection.Text.Trim() != "" && orderDescription.Text != "")
                {
                    string message = $"Are you sure want to clear the inputs?";
                    string title = "Clear";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Select Max itemcode
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                        SqlDataReader read = cmd.ExecuteReader();

                        //Set userId
                        if (read.Read() == false)
                        {
                            orderCode.Text = "100001";
                        }
                        else
                        {
                            int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                            orderCode.Text = value.ToString();
                        }
                        read.Close();

                        //Clear Text boxes
                        quantity.Clear();
                        supplierSelection.SelectedIndex = -1;
                        totalPrice.Clear();
                        orderDescription.Clear();
                    }
                    
                }
                else
                {
                    //Nothing to do
                }
                

                conn.db_connect_close();//Close connection 
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            string availableOrder = ""; //OrderId store for condition

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            SqlCommand cmd = new SqlCommand(); //SQL command reader

            //Get orderid form Database
            cmd.Connection = Connection.con;
            cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = '" + orderCode.Text.Trim() + "'; ";
            SqlDataReader read2 = cmd.ExecuteReader();
            if (read2.Read())
            {
                availableOrder = read2["orderid"].ToString().Trim();
            }
            read2.Close();

            //Condition for delete
            if (orderCode.Text.Trim() == availableOrder)
            {
                string message = $"Are you sure want to delete the order id : {availableOrder}?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //Execute command
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos DELETE FROM supplorder WHERE orderid= '" + orderCode.Text + "';";
                    cmd.ExecuteNonQuery();

                    string Message = $"Item Code : {availableOrder} is successfully deleted!";
                    string Success = "Success";
                    MessageBox.Show(Message, Success);

                    //View in proceedingOrders table
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    proceedingOrders.DataSource = dataTable;

                    //Select Max itemcode
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                    SqlDataReader read = cmd.ExecuteReader();

                    //Set userId
                    if (read.Read() == false)
                    {
                        orderCode.Text = "100001";
                    }
                    else
                    {
                        int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                        orderCode.Text = value.ToString();
                    }
                    read.Close();

                    //Clear Text boxes
                    quantity.Clear();
                    supplierSelection.SelectedIndex = -1;
                    totalPrice.Clear();
                    orderDescription.Clear();
                    orderIdConfirm.Clear();
                    orderDesConfirm.Clear();
                }
            }
        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                if (orderIdConfirm.Text.Trim() == "")
                {
                    //Do nothing
                }
                else
                {
                    string message = $"Are you sure want to confirm Order Code : {orderIdConfirm.Text.Trim()}?";
                    string title = "Confirm";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Input to the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos UPDATE supplyorder SET completeorder = 'YES', confirmor = '" + session + "', confirmdate = '" + DateTime.Parse(todayDate) + "' WHERE orderid = '" + orderIdConfirm.Text.ToString() + "';";
                        cmd.ExecuteNonQuery();

                        //Successful Confirm
                        string Message = $"Order Code : {orderIdConfirm.Text.Trim()} Confirmed!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        //View in proceedingOrders table
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        proceedingOrders.DataSource = dataTable;

                        //View in complete table
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                        SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                        DataTable dataTableComlete = new DataTable();
                        dataAdapComlete.SelectCommand = cmd;
                        dataAdapComlete.Fill(dataTableComlete);
                        completeOrders.DataSource = dataTableComlete;

                        //Select Max itemcode
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                        SqlDataReader read = cmd.ExecuteReader();

                        //Set userId
                        if (read.Read() == false)
                        {
                            orderCode.Text = "100001";
                        }
                        else
                        {
                            int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                            orderCode.Text = value.ToString();
                        }
                        read.Close();

                        //Clear Text boxes
                        orderIdConfirm.Clear();
                        orderDesConfirm.Clear();
                        quantity.Clear();
                        supplierSelection.SelectedIndex = -1;
                        totalPrice.Clear();
                        orderDescription.Clear();

                        conn.db_connect_close();
                    }
                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void proceedingOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                int index;
                index = e.RowIndex;

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(orderid) FROM supplyorder WHERE completeorder = 'NO';";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCount = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == rowCount)
                {
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = proceedingOrders.Rows[index];
                    string OrderId = dataGridViewRowrow.Cells[0].Value.ToString();

                    //Commad Executer
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT supplyorder.orderid, supplyorder.quantity, supplier.suppliername, supplyorder.totalprice, supplyorder.description FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE supplyorder.orderid = '" + OrderId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    read.Read();
                    if (read.HasRows)
                    {
                        orderCode.Text = read["orderid"].ToString().Trim();
                        //quantity
                        quantity.Text = read["quantity"].ToString().Trim();
                        //Supplier Selection
                        supplierSelection.Text = read["suppliername"].ToString();
                        //Total price
                        int total = (int)Math.Floor(read.GetDecimal(read.GetOrdinal("totalprice")));
                        totalPrice.Text = total.ToString().Trim();

                        orderDescription.Text = read["description"].ToString().Trim();
                    }
                    else
                    {
                        string errorMessage = "No data available!";
                        string error = "Warningr";
                        MessageBox.Show(errorMessage, error);
                    }
                    read.Close();

                    conn.db_connect_close(); //DB Connection close
                }

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void reProcessedOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                if (orderIdConfirm.Text.Trim() == "")
                {
                    //Do nothing
                }
                else
                {
                    string message = $"Are you sure want to Re-Process the Order Code : {orderIdConfirm.Text.Trim()}?";
                    string title = "Re-Process";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Input to the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos UPDATE supplyorder SET completeorder = 'NO', confirmor = NULL , confirmdate = NULL WHERE orderid = '" + orderIdConfirm.Text.ToString() + "';";
                        cmd.ExecuteNonQuery();

                        //Successful Confirm
                        string Message = $"Order Code : {orderIdConfirm.Text.Trim()} is directed to the Re-Process!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        //View in proceedingOrders table
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                        DataTable dataTable = new DataTable();
                        dataAdap.SelectCommand = cmd;
                        dataAdap.Fill(dataTable);
                        proceedingOrders.DataSource = dataTable;

                        //View in complete table
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                        SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                        DataTable dataTableComlete = new DataTable();
                        dataAdapComlete.SelectCommand = cmd;
                        dataAdapComlete.Fill(dataTableComlete);
                        completeOrders.DataSource = dataTableComlete;

                        //Select Max itemcode
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT orderid FROM supplyorder WHERE orderid = (SELECT MAX(orderid) FROM supplyorder);";
                        SqlDataReader read = cmd.ExecuteReader();

                        //Set userId
                        if (read.Read() == false)
                        {
                            orderCode.Text = "100001";
                        }
                        else
                        {
                            int value = int.Parse(read["orderid"].ToString().Trim()) + 1;
                            orderCode.Text = value.ToString();
                        }
                        read.Close();

                        //Clear Text boxes
                        orderIdConfirm.Clear();
                        orderDesConfirm.Clear();
                        quantity.Clear();
                        supplierSelection.SelectedIndex = -1;
                        totalPrice.Clear();
                        orderDescription.Clear();

                        conn.db_connect_close();
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

        private void clearCon_Click(object sender, EventArgs e)
        {
            if (orderIdConfirm.Text.Trim() == "")
            {
                //Do nothing
            }
            else
            {
                string message = $"Are you sure want to clear the Order ID?";
                string title = "Clear";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    orderIdConfirm.Clear(); //Clear Input
                    orderDesConfirm.Clear();
                }
            }
        }
        
        private void completeOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                int index;
                index = e.RowIndex;

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(orderid) FROM supplyorder WHERE completeorder = 'YES';";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCount = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == rowCount)
                {
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = completeOrders.Rows[index];
                    string OrderId = dataGridViewRowrow.Cells[0].Value.ToString();

                    //Commad Executer
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "SELECT orderid, description FROM supplyorder WHERE supplyorder.orderid = '" + OrderId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    read.Read();
                    if (read.HasRows)
                    {
                        orderIdConfirm.Text = read["orderid"].ToString().Trim();
                        orderDesConfirm.Text = read["description"].ToString().Trim();
                    }
                    else
                    {
                        string errorMessage = "No data available!";
                        string error = "Warningr";
                        MessageBox.Show(errorMessage, error);
                    }
                    read.Close();

                    conn.db_connect_close(); //DB Connection close
                }

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
            try
            {
                if (search.Text == "" && selectSupplier.SelectedValue == null)
                {
                    //DO nothing
                }
                else
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    search.Clear(); //Text clear
                    selectSupplier.SelectedIndex = -1; //selection value empty

                    //View in proceedingOrders table
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    proceedingOrders.DataSource = dataTable;

                    conn.db_connect_close();//DB Connection Close
                }
            }
            catch (Exception ex)
            {

                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            try
            {
                if (search2.Text == "" && selectSupplier2.SelectedValue == null)
                {
                    //DO nothing
                }
                else
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    search2.Clear(); //Text clear
                    selectSupplier2.SelectedIndex = -1; //selection value empty

                    //View in complete table
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                    SqlDataAdapter dataAdapComlete = new SqlDataAdapter();
                    DataTable dataTableComlete = new DataTable();
                    dataAdapComlete.SelectCommand = cmd;
                    dataAdapComlete.Fill(dataTableComlete);
                    completeOrders.DataSource = dataTableComlete;

                    conn.db_connect_close();//DB Connection Close
                }
            }
            catch (Exception ex)
            {

                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }
        
        private void selectSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            Preocess_SearchMethod();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Preocess_SearchMethod();
        }

        private void selectSupplier2_SelectedValueChanged(object sender, EventArgs e)
        {
            Complete_SearchMethod();
        }

        private void search2_TextChanged(object sender, EventArgs e)
        {
            Complete_SearchMethod();
        }

        protected void Preocess_SearchMethod()
        {
            string text = search.Text.Trim();
            string suppliers = "";

            // supplierCombo assignment
            if (selectSupplier.SelectedValue == null)
            {
                suppliers = "";
            }
            else
            {
                suppliers = selectSupplier.SelectedValue.ToString().Trim();
            }

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            //SQL command execute
            SqlCommand cmd = new SqlCommand(); //SQL command reader

            if (text == "" && suppliers == "")
            {
                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                proceedingOrders.DataSource = dataTable;
            }
            else if (text != "" && suppliers == "")
            {
                string Text = "%" + text + "%";

                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' AND description LIKE '" + Text + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                proceedingOrders.DataSource = dataTable;
            }
            else if (text == "" && suppliers != "")
            {
                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' AND supplyorder.supplierid = '" + suppliers + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                proceedingOrders.DataSource = dataTable;
            }
            else if (text != "" && suppliers != "")
            {
                string Text = "%" + text + "%";

                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.updator AS Updator, supplyorder.updatedate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'NO' AND supplyorder.supplierid = '" + suppliers + "' AND description LIKE '" + Text + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                proceedingOrders.DataSource = dataTable;
            }
        }

        protected void Complete_SearchMethod()
        {
            string text = search2.Text.Trim();
            string suppliers = "";

            // supplierCombo assignment
            if (selectSupplier2.SelectedValue == null)
            {
                suppliers = "";
            }
            else
            {
                suppliers = selectSupplier2.SelectedValue.ToString().Trim();
            }

            //DB Connection
            Connection conn = new Connection();
            conn.db_connect();

            //SQL command execute
            SqlCommand cmd = new SqlCommand(); //SQL command reader

            if (text == "" && suppliers == "")
            {
                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                completeOrders.DataSource = dataTable;
            }
            else if (text != "" && suppliers == "")
            {
                string Text = "%" + text + "%";

                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' AND description LIKE '" + Text + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                completeOrders.DataSource = dataTable;
            }
            else if (text == "" && suppliers != "")
            {
                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.adder AS Adder, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' AND supplyorder.supplierid = '" + suppliers + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                completeOrders.DataSource = dataTable;
            }
            else if (text != "" && suppliers != "")
            {
                string Text = "%" + text + "%";

                //View in proceedingOrders table
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT supplyorder.orderid AS OrderID, supplier.suppliername AS Supplier, supplyorder.quantity AS Quantity, supplyorder.totalprice AS TotalPrice, supplyorder.date AS Date, supplyorder.description AS Description, supplyorder.confirmor AS Confirmor, supplyorder.confirmdate AS ConfirmDate AS UpdateDate FROM supplyorder INNER JOIN supplier ON supplyorder.supplierid = supplier.supplierid WHERE completeorder = 'YES' AND supplyorder.supplierid = '" + suppliers + "' AND description LIKE '" + Text + "' ORDER BY orderid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                completeOrders.DataSource = dataTable;
            }
        }
    }
}
