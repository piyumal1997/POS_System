using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PosSystem
{
    public partial class Add_User : UserControl
    {
        string imageLocation;
        string session;
        int rowCount;

        public Add_User(string JRole)
        {
            InitializeComponent();
            session = JRole;
        }

        private void imgUpload_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                open.Title = "Select Employee Picture";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = open.FileName.ToString();
                    // display image in picture box
                    imagePreviwer.ImageLocation = imageLocation;
                    //imagePreviwer.Image = Image.FromFile(open.FileName);
                }

                //Set to the picture
                byte[] picture = null;
                FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                picture = binaryReader.ReadBytes((int)fileStream.Length);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //Gender selection
                string Gender = "";
                bool maleChecked = male.Checked;
                bool femaleChecked = female.Checked;
                if (maleChecked)
                    Gender = male.Text;
                else if (femaleChecked)
                {
                    Gender = female.Text;
                }

                //Validate the inputs
                user User = new user(userId.Text.Trim(), nic.Text.Trim(), firstName.Text.Trim(), lastName.Text.Trim(), fullName.Text.Trim(), address.Text.Trim(), contact.Text.Trim(), username.Text.Trim(), role.Text, password.Text.Trim(), status.Text, Gender);

                //Set today date 'yyyy-MM-dd' format
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");

                //Retype Password
                string RePassword = re_password.Text.Trim();

                if (User.Nic != "0" && User.FirstName != "0" && User.LastName != "0" && User.FullName != "0" && User.Address != "0" && User.Contact != "0" && User.Username != "0" && User.Password != "0" && RePassword != null && User.Role != "0" && User.Status != "0" && User.Gender != "0" && imagePreviwer.Image != null)
                {
                    if (User.Password == RePassword)
                    {
                        //Find out username and NIC is available 
                        string availableNic = ""; //store database passing nic
                        string availableUsername = ""; //store database passing username
                        string availableContact = ""; //store database passing contactno
                        string availableUserId = ""; //store database passing employeeid

                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        //Get NIC form Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT nic FROM employee WHERE nic = '"+User.Nic+"'; ";
                        SqlDataReader read = cmd.ExecuteReader();
                        if (read.Read()) 
                        {
                            availableNic = read["nic"].ToString().Trim();
                        }
                        read.Close();

                        //Get Username form Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT username FROM employee WHERE username = '" + User.Username + "'; ";
                        SqlDataReader read1 = cmd.ExecuteReader();
                        if (read1.Read())
                        {
                            availableUsername = read1["username"].ToString().Trim();
                        }
                        read1.Close();

                        //Get contact form Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT contactno FROM employee WHERE contactno = '" + User.Contact + "'; ";
                        SqlDataReader read2 = cmd.ExecuteReader();
                        if (read2.Read())
                        {
                            availableContact = read2["contactno"].ToString().Trim();
                        }
                        read2.Close();

                        //Get employeeid form Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = '" + User.UserId + "'; ";
                        SqlDataReader read3 = cmd.ExecuteReader();
                        if (read3.Read())
                        {
                            availableUserId = read3["employeeid"].ToString().Trim();
                        }
                        read3.Close();

                        //Condition for employeeID
                        if (availableUserId != User.UserId)
                        {
                            //Condition for NIC
                            if (availableNic != User.Nic)
                            {
                                //Condition for Username
                                if (availableUsername != User.Username)
                                {
                                    //Condition for Contact
                                    if (availableContact != User.Contact)
                                    {
                                        //Image setting
                                        byte[] picture = null;
                                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                                        BinaryReader binaryReader = new BinaryReader(fileStream);
                                        picture = binaryReader.ReadBytes((int)fileStream.Length);

                                        //Input to the Database
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos INSERT INTO employee VALUES ('" + User.UserId + "','" + User.Nic + "','" + User.FirstName + "','" + User.LastName + "','" + User.FullName + "','" + User.Username + "','" + User.Password + "','" + User.Address + "','" + User.Contact + "','" + DateTime.Parse(dateSet.Text) + "','" + User.Status + "','" + User.Role + "','" + User.Gender + "', @pic ,'" + session + "',NUll,NULL);";
                                        cmd.Parameters.Add(new SqlParameter("@pic", picture));
                                        cmd.ExecuteNonQuery();

                                        //Successful Added Message
                                        string Message = $"{User.FirstName} {User.LastName} successfully added to the system!";
                                        string success = "Success";
                                        MessageBox.Show(Message, success);

                                        // View in data grid view
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate  FROM employee ORDER BY employeeid DESC;";
                                        SqlDataAdapter dataAdap = new SqlDataAdapter();
                                        DataTable dataTable = new DataTable();
                                        dataAdap.SelectCommand = cmd;
                                        dataAdap.Fill(dataTable);
                                        employeeDataView.DataSource = dataTable;

                                        //Set the UserID Values
                                        cmd.Connection = Connection.con;
                                        cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = (SELECT MAX(employeeid) FROM employee);";
                                        SqlDataReader read4 = cmd.ExecuteReader();

                                        //Set userId
                                        if (read4.Read() == false)
                                        {
                                            userId.Text = "10001";
                                        }
                                        else
                                        {
                                            int value = int.Parse(read4["employeeid"].ToString().Trim()) + 1;
                                            userId.Text = value.ToString();
                                        }
                                        read4.Close();

                                        //Reset the form
                                        nic.Clear();
                                        firstName.Clear();
                                        lastName.Clear();
                                        fullName.Clear();
                                        address.Clear();
                                        contact.Clear();
                                        username.Clear();
                                        password.Clear();
                                        re_password.Clear();
                                        status.SelectedIndex = -1;
                                        role.SelectedIndex = -1;
                                        male.Checked = false;
                                        female.Checked = false;
                                        imagePreviwer.Image = null;
                                    }
                                    else
                                    {
                                        string errorMessage = "This Contact already exist in the system!";
                                        string error = "Warning";
                                        MessageBox.Show(errorMessage, error);
                                    }

                                }
                                else
                                {
                                    string errorMessage = "This Username already exist in the system!";
                                    string error = "Warning";
                                    MessageBox.Show(errorMessage, error);
                                }
                            }
                            else
                            {
                                string Message = "This NIC already exist in the system!";
                                string warning = "Warning";
                                MessageBox.Show(Message, warning);
                            }
                        }
                        else
                        {
                            string Message = "This Employee Id already exist!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);

                            //Reset the form
                            nic.Clear();
                            firstName.Clear();
                            lastName.Clear();
                            fullName.Clear();
                            address.Clear();
                            contact.Clear();
                            username.Clear();
                            password.Clear();
                            re_password.Clear();
                            status.SelectedIndex = -1;
                            role.SelectedIndex = -1;
                            male.Checked = false;
                            female.Checked = false;
                            imagePreviwer.Image = null;


                            //Set the UserID Values
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = (SELECT MAX(employeeid) FROM employee);";
                            SqlDataReader read5 = cmd.ExecuteReader();

                            //Set userId
                            if (read5.Read() == false)
                            {
                                userId.Text = "10001";
                            }
                            else
                            {
                                int value = int.Parse(read5["employeeid"].ToString().Trim()) + 1;
                                userId.Text = value.ToString();
                            }
                            read5.Close();
                        }
                    }
                    else
                    {
                        string Message = "Passwords are not matched!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);
                    }
                }
                else
                {
                    string Message = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }

                //Database connection close
                conn.db_connect_close();

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }

        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            if ("10001" != userId.Text.Trim())
            {
                try
                {
                    //YesNo Message box
                    string message = "Are you sure want to update?";
                    string title = "Update";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //DB Connection
                        Connection conn = new Connection();
                        conn.db_connect();
                        SqlCommand cmd = new SqlCommand(); //SQL command reader

                        //Gender selection
                        string Gender = "";
                        bool maleChecked = male.Checked;
                        bool femaleChecked = female.Checked;
                        if (maleChecked)
                            Gender = male.Text;
                        else if (femaleChecked)
                        {
                            Gender = female.Text;
                        }

                        //Validate the inputs
                        user User = new user(userId.Text.Trim(), nic.Text.Trim(), firstName.Text.Trim(), lastName.Text.Trim(), fullName.Text.Trim(), address.Text.Trim(), contact.Text.Trim(), username.Text.Trim(), role.Text, password.Text.Trim(), status.Text, Gender);

                        //Set today date 'yyyy-MM-dd' format
                        var date = DateTime.Now;
                        string todayDate = date.ToString("yyyy-MM-dd");

                        //Retype Password
                        string RePassword = re_password.Text.Trim();


                        if (User.Nic != "0" && User.FirstName != "0" && User.LastName != "0" && User.FullName != "0" && User.Address != "0" && User.Contact != "0" && User.Username != "0" && User.Password != "0" && RePassword != null && User.Role != "0" && User.Status != "0" && User.Gender != "0" && imagePreviwer.Image != null)
                        {
                            if (User.Password == RePassword)
                            {
                                //Find out username and NIC is available 
                                string availableNic = ""; //database passing nic
                                string availableUsername = ""; //database passing username
                                string availableContact = ""; //database passing contactno
                                string employeeID = ""; //database passing employeeid

                                //Get EmployeeID  from Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = '" + User.UserId + "';";
                                SqlDataReader read0 = cmd.ExecuteReader();
                                if (read0.Read())
                                {
                                    employeeID = read0["employeeid"].ToString().Trim();
                                }
                                read0.Close();

                                //Get NIC form Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos SELECT nic FROM employee WHERE nic = '" + User.UserId + "' AND employeeid != '" + User.UserId + "'; ";
                                SqlDataReader read = cmd.ExecuteReader();
                                if (read.Read())
                                {
                                    availableNic = read["nic"].ToString().Trim();
                                }
                                read.Close();

                                //Get Username form Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos SELECT username FROM employee WHERE username = '" + User.Username + "'AND employeeid != '" + User.UserId + "'; ";
                                SqlDataReader read1 = cmd.ExecuteReader();
                                if (read1.Read())
                                {
                                    availableUsername = read1["username"].ToString().Trim();
                                }
                                read1.Close();

                                //Get contact form Database
                                cmd.Connection = Connection.con;
                                cmd.CommandText = "USE pos SELECT contactno FROM employee WHERE contactno = '" + User.Contact + "' AND employeeid != '" + User.UserId + "'; ";
                                SqlDataReader read2 = cmd.ExecuteReader();
                                if (read2.Read())
                                {
                                    availableContact = read2["contactno"].ToString().Trim();
                                }
                                read2.Close();

                                //Condition for EmployeeID
                                if (employeeID == User.UserId)
                                {
                                    //Condition for NIC
                                    if (availableNic != User.Nic)
                                    {
                                        //Condition for Username
                                        if (availableUsername != User.Username)
                                        {
                                            //Condition for Contact
                                            if (availableContact != User.Contact)
                                            {


                                                if (imageLocation == null)
                                                {
                                                    //Input to the Database 
                                                    cmd.Connection = Connection.con;
                                                    cmd.CommandText = "USE pos UPDATE employee SET nic = '" + User.Nic + "', firstname = '" + User.FirstName + "', lastname = '" + User.LastName + "', fullname = '" + User.FullName + "', username = '" + User.Username + "', password = '" + User.Password + "', address = '" + User.Address + "', contactno = '" + User.Contact + "', status = '" + User.Status + "', role = '" + User.Role + "', gender = '" + User.Gender + "', updateddate = '" + DateTime.Parse(dateSet.Text) + "', updator = '" + session + "' WHERE employeeid = '" + User.UserId + "';";
                                                    cmd.ExecuteNonQuery();
                                                }
                                                else
                                                {
                                                    //Image setting
                                                    byte[] picture = null;
                                                    FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                                                    BinaryReader binaryReader = new BinaryReader(fileStream);
                                                    picture = binaryReader.ReadBytes((int)fileStream.Length);

                                                    //Input to the Database 
                                                    cmd.Connection = Connection.con;
                                                    cmd.CommandText = "USE pos UPDATE employee SET nic = '" + User.Nic + "', firstname = '" + User.FirstName + "', lastname = '" + User.LastName + "', fullname = '" + User.FullName + "', username = '" + User.Username + "', password = '" + User.Password + "', address = '" + User.Address + "', contactno = '" + User.Contact + "', status = '" + User.Status + "', role = '" + User.Role + "', gender = '" + User.Gender + "', picture = @pic , updateddate = '" + DateTime.Parse(dateSet.Text) + "', updator = '" + session + "' WHERE employeeid = '" + User.UserId + "';";
                                                    cmd.Parameters.Add(new SqlParameter("@pic", picture));
                                                    cmd.ExecuteNonQuery();
                                                }

                                                // View in data grud view
                                                cmd.Connection = Connection.con;
                                                cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate  FROM employee ORDER BY employeeid DESC;";
                                                SqlDataAdapter dataAdap = new SqlDataAdapter();
                                                DataTable dataTable = new DataTable();
                                                dataAdap.SelectCommand = cmd;
                                                dataAdap.Fill(dataTable);
                                                employeeDataView.DataSource = dataTable;

                                                //Successful Added Message
                                                MessageBox.Show($"{User.FirstName} {User.LastName} successfully Updated!");

                                                //Set the UserID Values
                                                cmd.Connection = Connection.con;
                                                cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = (SELECT MAX(employeeid) FROM employee);";
                                                SqlDataReader read3 = cmd.ExecuteReader();

                                                //Set userId
                                                if (read3.Read() == false)
                                                {
                                                    userId.Text = "10001";
                                                }
                                                else
                                                {
                                                    int value = int.Parse(read3["employeeid"].ToString().Trim()) + 1;
                                                    userId.Text = value.ToString();
                                                }
                                                read3.Close();

                                                //Reset the form
                                                nic.Clear();
                                                firstName.Clear();
                                                lastName.Clear();
                                                fullName.Clear();
                                                address.Clear();
                                                contact.Clear();
                                                username.Clear();
                                                password.Clear();
                                                re_password.Clear();
                                                status.SelectedIndex = -1;
                                                role.SelectedIndex = -1;
                                                male.Checked = false;
                                                female.Checked = false;
                                                imagePreviwer.Image = null;

                                                //Database connection close
                                                conn.db_connect_close();
                                            }
                                            else
                                            {
                                                string errorMessage = "This Contact already exist in the system!";
                                                string error = "Warning";
                                                MessageBox.Show(errorMessage, error);
                                            }
                                        }
                                        else
                                        {
                                            string errorMessage = "This Username already exist in the system!";
                                            string error = "Warning";
                                            MessageBox.Show(errorMessage, error);
                                        }
                                    }
                                    else
                                    {
                                        string errorMessage = "This NIC already exist in the system!";
                                        string error = "Warning";
                                        MessageBox.Show(errorMessage, error);
                                    }
                                }
                                else
                                {
                                    string warningMessage = "This User ID is not available in Database!";
                                    string warning = "Warning";
                                    MessageBox.Show(warningMessage, warning);

                                    //Reset the form
                                    nic.Clear();
                                    firstName.Clear();
                                    lastName.Clear();
                                    fullName.Clear();
                                    address.Clear();
                                    contact.Clear();
                                    username.Clear();
                                    password.Clear();
                                    re_password.Clear();
                                    status.SelectedIndex = -1;
                                    role.SelectedIndex = -1;
                                    male.Checked = false;
                                    female.Checked = false;
                                    imagePreviwer.Image = null;
                                }

                            }
                            else
                            {
                                string errorMessage = "Passwords are not matched!";
                                string error = "Warning";
                                MessageBox.Show(errorMessage, error);
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
            else
            {
                string Message = "Cannot Change UserID '10001'";
                string warning = "Warning!";
                MessageBox.Show(Message, warning);
            }
            
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception error)
            {
                MessageBox.Show($"Error : {error.Message}");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader

                string userIdValue = ""; //database passing usrId value holder

                //Select Max employeeid
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = '" + userId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                if (read.Read() == true)
                {
                    userIdValue = read["employeeid"].ToString().Trim();
                }
                read.Close();

                //Gender selection
                string Gender = "";
                bool maleChecked = male.Checked;
                bool femaleChecked = female.Checked;
                if (maleChecked)
                    Gender = male.Text;
                else if (femaleChecked)
                {
                    Gender = female.Text;
                }

                //inputs are available
                if (userIdValue == userId.Text || nic.Text != "" || firstName.Text != "" || lastName.Text != "" || fullName.Text != "" || address.Text != "" || contact.Text != "" || username.Text != "" || role.Text != "" || password.Text != "" || status.Text != "" || Gender != "")
                {
                    //YesNo Message box
                    string message = "Do you want to clear the inputs?";
                    string title = "Clear Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Reset the form
                        nic.Clear();
                        firstName.Clear();
                        lastName.Clear();
                        fullName.Clear();
                        address.Clear();
                        contact.Clear();
                        username.Clear();
                        password.Clear();
                        re_password.Clear();
                        status.SelectedIndex = -1;
                        role.SelectedIndex = -1;
                        male.Checked = false;
                        female.Checked = false;
                        imagePreviwer.Image = null;

                        
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = (SELECT MAX(employeeid) FROM employee);";

                        //Set userId
                        if (cmd.ExecuteScalar() == null)
                        {
                            userId.Text = "10001";
                        }
                        else
                        {
                            int value = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                            userId.Text = value.ToString();
                        }

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

        private void Add_User_Load(object sender, EventArgs e)
        {

            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //Row count on employee
                SqlCommand cmd = new SqlCommand(); //SQL command reader
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(employeeid) FROM employee;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    rowCount = read0.GetInt32(0);
                }
                read0.Close();

                //Select Max employeeid
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT employeeid FROM employee WHERE employeeid = (SELECT MAX(employeeid) FROM employee);";
                SqlDataReader read = cmd.ExecuteReader();

                //Set userId
                if (read.Read() == false)
                {
                    userId.Text = "10001";
                }
                else
                {
                    int value = int.Parse(read["employeeid"].ToString().Trim()) + 1;
                    userId.Text = value.ToString();
                }
                read.Close();
                

                //Set date to the text box
                var date = DateTime.Now;
                string todayDate = date.ToString("yyyy-MM-dd");
                dateSet.Text = todayDate;

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate  FROM employee ORDER BY employeeid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                employeeDataView.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void employeeDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Reset Status combobox and Role combobox
            status.SelectedIndex = -1;
            role.SelectedIndex = -1;

            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                int index;
                index = e.RowIndex;

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(employeeid) FROM employee;";
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
                    DataGridViewRow dataGridViewRowrow = employeeDataView.Rows[index];
                    string employeeId = dataGridViewRowrow.Cells[0].Value.ToString();

                    //Get particular data row from employee
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM employee WHERE employeeid = '" + employeeId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    read.Read();
                    if (read.HasRows)
                    {
                        userId.Text = read[0].ToString().Trim();
                        nic.Text = read[1].ToString().Trim();
                        firstName.Text = read[2].ToString().Trim();
                        lastName.Text = read[3].ToString().Trim();
                        fullName.Text = read[4].ToString().Trim();
                        username.Text = read[5].ToString().Trim();
                        password.Text = read[6].ToString().Trim();
                        re_password.Text = read[6].ToString().Trim();
                        address.Text = read[7].ToString().Trim();
                        contact.Text = read[8].ToString().Trim();

                        //Gender Set
                        if (read[12].ToString().Trim() == "Male")
                        {
                            male.Checked = true;
                        }

                        if (read[12].ToString().Trim() == "Female")
                        {
                            female.Checked = true;
                        }

                        //Status set
                        if (read[10].ToString().Trim() == "Active")
                        {
                            status.SelectedIndex = 0;
                        }
                        else
                        {
                            status.SelectedIndex = 1;
                        }

                        //Role set
                        if (read[11].ToString().Trim() == "Owner")
                        {
                            role.SelectedIndex = 0;
                        }
                        else
                        {
                            role.SelectedIndex = 1;
                        }

                        //Set Picture
                        byte[] image = (byte[])(read[13]);
                        try
                        {
                            MemoryStream memory = new MemoryStream(image);
                            imagePreviwer.Image = Image.FromStream(memory);
                        }
                        catch (Exception ex)
                        {
                            string errorMessage = ex.Message;
                            string error = "Error";
                            MessageBox.Show(errorMessage, error);
                        }
                    }
                    else
                    {
                        string errorMessage = "No data available!";
                        string error = "Warningr";
                        MessageBox.Show(errorMessage, error);
                    }
                    read.Close();
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

        private void search_TextChanged(object sender, EventArgs e)
        {
            SeachMethod();
        }

        private void searchCombo_TextChanged(object sender, EventArgs e)
        {
            SeachMethod();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            try
            {
                search.Clear();
                searchCombo.SelectedIndex = -1;

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                //SQL command execute
                SqlCommand cmd = new SqlCommand(); //SQL command reader
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate  FROM employee ORDER BY employeeid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                employeeDataView.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }

        }

        //Search Method
        protected void SeachMethod()
        {
            try
            {
                string text = search.Text.Trim();
                string combo = searchCombo.Text.Trim();


                if (text != "" && combo == "")
                {
                    text = "%" + search.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE (employeeid + nic + firstname + lastname + fullname + username + address + contactno) LIKE '" + text + "' ORDER BY employeeid DESC;";


                    //cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE employeeid = '" + text + "' OR nic = '" + text + "' OR firstname = '" + text + "' OR lastname = '" + text + "' OR fullname = '" + text + "' OR username = '" + text + "' OR address = '" + text + "' OR contactno = '" + text + "' OR status = '" + combo + "' ORDER BY employeeid DESC;";

                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    employeeDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (combo != "" && text == "") 
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE status = '" + combo + "' ORDER BY employeeid DESC;";


                    //cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE employeeid = '" + text + "' OR nic = '" + text + "' OR firstname = '" + text + "' OR lastname = '" + text + "' OR fullname = '" + text + "' OR username = '" + text + "' OR address = '" + text + "' OR contactno = '" + text + "' OR status = '" + combo + "' ORDER BY employeeid DESC;";

                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    employeeDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text != "" && combo != "")
                {
                    text = "%" + search.Text.Trim() + "%";

                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE employeeid + nic + firstname + lastname + fullname + username + address + contactno LIKE '" + text + "' AND status = '" + combo + "' ORDER BY employeeid DESC;";


                    //cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee WHERE employeeid = '" + text + "' OR nic = '" + text + "' OR firstname = '" + text + "' OR lastname = '" + text + "' OR fullname = '" + text + "' OR username = '" + text + "' OR address = '" + text + "' OR contactno = '" + text + "' OR status = '" + combo + "' ORDER BY employeeid DESC;";

                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    employeeDataView.DataSource = dataTable;

                    conn.db_connect_close(); //Connection Close
                }
                else if (text == "" && combo == "")
                {
                    //DB Connection
                    Connection conn = new Connection();
                    conn.db_connect();

                    //SQL command execute
                    SqlCommand cmd = new SqlCommand(); //SQL command reader
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT employeeid AS EmployeeID, firstname AS FirstName, lastname AS LastName, fullname AS FullName, nic AS NIC, address AS Address, contactno AS Contact, gender AS Gender, role AS Role, status AS Status, date as AddingDate FROM employee ORDER BY employeeid DESC;";
                    SqlDataAdapter dataAdap = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    dataAdap.SelectCommand = cmd;
                    dataAdap.Fill(dataTable);
                    employeeDataView.DataSource = dataTable;

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
