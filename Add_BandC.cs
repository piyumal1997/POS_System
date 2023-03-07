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
using static System.Collections.Specialized.BitVector32;

namespace PosSystem
{
    public partial class Add_BandC : UserControl
    {
        int brandCount;
        int categoryCount;

        public Add_BandC()
        {
            InitializeComponent();
        }

        private void Add_BandC_Load(object sender, EventArgs e)
        {
            try
            {
                // DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader
                
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(categoryid) FROM category;";
                SqlDataReader read1 = cmd.ExecuteReader();
                while (read1.Read())
                {
                    categoryCount = read1.GetInt32(0);
                }
                read1.Close();

                //Get brandid from Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                SqlDataReader read2 = cmd.ExecuteReader();

                //Set brandId
                if (read2.Read() == false)
                {
                    brandId.Text = "1001";
                }
                else
                {
                    int value = int.Parse(read2["brandid"].ToString().Trim()) + 1;
                    brandId.Text = value.ToString();
                }
                read2.Close();

                //Get categoryid from Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                SqlDataReader read3 = cmd.ExecuteReader();

                //Set categoryId
                if (read3.Read() == false)
                {
                    categoryId.Text = "100";
                }
                else
                {
                    int value = int.Parse(read3["categoryid"].ToString().Trim()) + 1;
                    categoryId.Text = value.ToString();
                }
                read3.Close();

                //View in brands in brandDataView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                SqlDataAdapter brandAdap = new SqlDataAdapter();
                DataTable brandTable = new DataTable();
                brandAdap.SelectCommand = cmd;
                brandAdap.Fill(brandTable);
                brandDataView.DataSource = brandTable;

                //View in categories in categoryDataView
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                SqlDataAdapter categoryAdap = new SqlDataAdapter();
                DataTable categoryTable = new DataTable();
                categoryAdap.SelectCommand = cmd;
                categoryAdap.Fill(categoryTable);
                categoryDataView.DataSource = categoryTable;

                conn.db_connect_close(); //Connection Close
            }
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                category Category = new category(categoryId.Text.Trim(), categoryName.Text.Trim());

                if (Category.CategoryName != "0")
                {
                    string availableCategoryName = ""; //store database brandname

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    string CategoryName = "%" + Category.CategoryName + "%";

                    //Get categoryname form Database
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT categoryname FROM category WHERE categoryname LIKE '" + CategoryName + "'; ";
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        availableCategoryName = read["categoryname"].ToString().Trim();
                    }
                    read.Close();

                    //Condition for Brand Name
                    if (availableCategoryName != Category.CategoryName)
                    {
                        //Input to the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos INSERT INTO category VALUES ('" + Category.CategoryId + "','" + Category.CategoryName + "');";
                        cmd.ExecuteNonQuery();

                        //Successful Added Message
                        string Message = $"{Category.CategoryName} successfully added to the system!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        //View in categories in categoryDataView
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                        SqlDataAdapter categoryAdap = new SqlDataAdapter();
                        DataTable categoryTable = new DataTable();
                        categoryAdap.SelectCommand = cmd;
                        categoryAdap.Fill(categoryTable);
                        categoryDataView.DataSource = categoryTable;

                        //Reset Text Boxes
                        categoryName.Clear();

                        //Get categoryid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set categoryId
                        if (read1.Read() == false)
                        {
                            categoryId.Text = "100";
                        }
                        else
                        {
                            int value = int.Parse(read1["categoryid"].ToString().Trim()) + 1;
                            categoryId.Text = value.ToString();
                        }
                        read1.Close();

                        //Database connection close
                        conn.db_connect_close();

                    }
                    else
                    {
                        string Message = $"{Category.categoryName} already exist in the Database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);

                        //Get categoryid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set categoryId
                        if (read1.Read() == false)
                        {
                            categoryId.Text = "100";
                        }
                        else
                        {
                            int value = int.Parse(read1["categoryid"].ToString().Trim()) + 1;
                            categoryId.Text = value.ToString();
                        }
                        read1.Close();

                        categoryName.Clear();
                    }
                }
                else
                {
                    string Message = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
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

        private void updateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string catName = ""; //read categoryname holder
                string catNamePrev = ""; //Previous categoryname holding
                string catId = ""; //read categoryid holder

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get categoryname form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category WHERE categoryid = '" + categoryId.Text.Trim() + "'; ";
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    catId = read["categoryid"].ToString().Trim();
                    catNamePrev = read["categoryname"].ToString().Trim();
                }
                read.Close();

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT categoryname FROM category WHERE categoryname LIKE '" + categoryName.Text.Trim() + "'; ";
                SqlDataReader read1 = cmd.ExecuteReader();
                if (read1.Read())
                {
                    catName = read1["categoryname"].ToString().Trim();
                }
                read1.Close();

                if (categoryId.Text.Trim() == catId)
                {
                    if (categoryName.Text.Trim() != catName)
                    {
                        category Category = new category(categoryId.Text.Trim(), categoryName.Text.Trim());

                        if (Category.CategoryName != "0")
                        {
                            //Input to the Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos UPDATE category SET categoryname = '" + Category.CategoryName + "' WHERE categoryid = '" + Category.CategoryId + "'; ";
                            cmd.ExecuteNonQuery();

                            //Successful Added Message
                            string Message = $"{catNamePrev} is successfully updated to {categoryName.Text.Trim()}!";
                            string success = "Success";
                            MessageBox.Show(Message, success);

                            //View in categories in categoryDataView
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                            SqlDataAdapter categoryAdap = new SqlDataAdapter();
                            DataTable categoryTable = new DataTable();
                            categoryAdap.SelectCommand = cmd;
                            categoryAdap.Fill(categoryTable);
                            categoryDataView.DataSource = categoryTable;

                            //Reset Text Boxes
                            categoryName.Clear();

                            //Get categoryid from Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                            SqlDataReader read2 = cmd.ExecuteReader();

                            //Set categoryId
                            if (read2.Read() == false)
                            {
                                categoryId.Text = "100";
                            }
                            else
                            {
                                int value = int.Parse(read2["categoryid"].ToString().Trim()) + 1;
                                categoryId.Text = value.ToString();
                            }
                            read2.Close();

                            //Database connection close
                            conn.db_connect_close();
                        }
                        else
                        {
                            string Message = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }
                        
                    }
                    else
                    {
                        string Message = $"{categoryName.Text.Trim()} is alredy exist in the Database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);

                    }
                }
                else
                {
                    string Message = $"{categoryId.Text.Trim()} is not exist in the Database!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);

                    categoryName.Clear();
                }

                conn.db_connect_close();

            }
            catch(Exception ex) 
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string catIdValue = ""; //categoryid value holding
                string catNameValue = ""; //categoryname value holding

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category WHERE categoryid = '" + categoryId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();
                //Set categoryId
                if (read.Read() == true)
                {
                    catIdValue = read["categoryid"].ToString().Trim();
                    catNameValue = read["categoryname"].ToString().Trim();
                }
                read.Close();

                if (catIdValue == categoryId.Text.Trim())
                {
                    string message = $"Do you want to Delete {catNameValue}?";
                    string title = "Delete Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM category WHERE categoryid = '" + categoryId.Text.Trim() + "';";
                        cmd.ExecuteNonQuery();

                        //View in categories in categoryDataView
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                        SqlDataAdapter categoryAdap = new SqlDataAdapter();
                        DataTable categoryTable = new DataTable();
                        categoryAdap.SelectCommand = cmd;
                        categoryAdap.Fill(categoryTable);
                        categoryDataView.DataSource = categoryTable;

                        //Get categoryid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set categoryId
                        if (read1.Read() == false)
                        {
                            categoryId.Text = "100";
                        }
                        else
                        {
                            int value = int.Parse(read1["categoryid"].ToString().Trim()) + 1;
                            categoryId.Text = value.ToString();
                        }
                        read1.Close();

                        categoryName.Clear(); //Brandname clear

                        //Successful Added Message
                        string Message = $"{catNameValue} successfully delete from the system!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        conn.db_connect_close(); //DB connection close
                    }
                }
                else
                {
                    string Message = "Cannot delete the Category from database, \nCategory Id is not available in the Database!";
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

        private void addBrand_Click(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                brand Brand = new brand(brandId.Text.Trim(), brandName.Text.Trim());

                if (Brand.BrandName != "0")
                {
                    string availableBrandName = ""; //store database brandname

                    SqlCommand cmd = new SqlCommand(); //SQL command reader

                    string BrandName = "%" + Brand.BrandName + "%";

                    //Get brandname form Database
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT brandname FROM brand WHERE brandname LIKE '" + BrandName + "'; ";
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        availableBrandName = read["brandname"].ToString().Trim();
                    }
                    read.Close();

                    //Condition for Brand Name
                    if (availableBrandName != Brand.BrandName)
                    {
                        //Input to the Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos INSERT INTO brand VALUES ('" + Brand.BrandId + "','" + Brand.BrandName + "');";
                        cmd.ExecuteNonQuery();

                        //Successful Added Message
                        string Message = $"{Brand.BrandName} successfully added to the system!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        //View in brands in brandDataView
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                        SqlDataAdapter brandAdap = new SqlDataAdapter();
                        DataTable brandTable = new DataTable();
                        brandAdap.SelectCommand = cmd;
                        brandAdap.Fill(brandTable);
                        brandDataView.DataSource = brandTable;

                        //Reset Text Boxes
                        brandName.Clear();

                        //Get brandid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set brandId
                        if (read1.Read() == false)
                        {
                            brandId.Text = "1001";
                        }
                        else
                        {
                            int value = int.Parse(read1["brandid"].ToString().Trim()) + 1;
                            brandId.Text = value.ToString();
                        }
                        read1.Close();

                        //Database connection close
                        conn.db_connect_close();

                    }
                    else
                    {
                        string Message = $"{Brand.BrandName} already exist in the Database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);

                        //Get brandid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set brandId
                        if (read1.Read() == false)
                        {
                            brandId.Text = "1001";
                        }
                        else
                        {
                            int value = int.Parse(read1["brandid"].ToString().Trim()) + 1;
                            brandId.Text = value.ToString();
                        }
                        read1.Close();

                        brandName.Clear();
                    }
                }
                else
                {
                    string Message = "Input feild(s) are Empty or Not Valid, \nPlease checked the fields!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
            
        }

        private void updateBrand_Click(object sender, EventArgs e)
        {
            try
            {
                string branName = ""; //read brandname holder
                string branNamePrev = ""; //Previous brandname holding
                string branId = ""; //read brandidid holder

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Get categoryname form Database
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM brand WHERE brandid = '" + brandId.Text.Trim() + "'; ";
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    branId = read["brandid"].ToString().Trim();
                    branNamePrev = read["brandname"].ToString().Trim();
                }
                read.Close();

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT brandname FROM brand WHERE brandname LIKE '" + brandName.Text.Trim() + "'; ";
                SqlDataReader read1 = cmd.ExecuteReader();
                if (read1.Read())
                {
                    branName = read1["categoryname"].ToString().Trim();
                }
                read1.Close();

                if (brandId.Text.Trim() == branId)
                {
                    if (brandName.Text.Trim() != branName)
                    {
                        brand Brand = new brand(brandId.Text.Trim(), brandName.Text.Trim());

                        if (Brand.BrandName != "0")
                        {
                            //Input to the Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos UPDATE brand SET brandname = '" + Brand.BrandName + "' WHERE brandid = '" + Brand.BrandId + "'; ";
                            cmd.ExecuteNonQuery();

                            //Successful Added Message
                            string Message = $"{branNamePrev} is successfully updated to {brandName.Text.Trim()}!";
                            string success = "Success";
                            MessageBox.Show(Message, success);

                            //View in brands in brandDataView
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                            SqlDataAdapter brandAdap = new SqlDataAdapter();
                            DataTable brandTable = new DataTable();
                            brandAdap.SelectCommand = cmd;
                            brandAdap.Fill(brandTable);
                            brandDataView.DataSource = brandTable;

                            //Reset Text Boxes
                            brandName.Clear();

                            //Get brandid from Database
                            cmd.Connection = Connection.con;
                            cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                            SqlDataReader read2 = cmd.ExecuteReader();

                            //Set brandId
                            if (read2.Read() == false)
                            {
                                brandId.Text = "1001";
                            }
                            else
                            {
                                int value = int.Parse(read2["brandid"].ToString().Trim()) + 1;
                                brandId.Text = value.ToString();
                            }
                            read2.Close();

                            //Database connection close
                            conn.db_connect_close();
                        }
                        else
                        {
                            string Message = "Input feild(s) are Empty or Not Valid,\nPlease checked the fields!";
                            string warning = "Warning";
                            MessageBox.Show(Message, warning);
                        }

                    }
                    else
                    {
                        string Message = $"{brandName.Text.Trim()} is alredy exist in the Database!";
                        string warning = "Warning";
                        MessageBox.Show(Message, warning);

                    }
                }
                else
                {
                    string Message = $"{brandId.Text.Trim()} is not exist in the Database!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);

                    categoryName.Clear();
                }

                conn.db_connect_close();

            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void deleteBrand_Click(object sender, EventArgs e)
        {
            try
            {
                string branIdValue = ""; //brandid value holding
                string branNameValue = ""; //brandname value holding

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM brand WHERE brandid = '" + brandId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();
                //Set categoryId
                if (read.Read() == true)
                {
                    branIdValue = read["brandid"].ToString().Trim();
                    branNameValue = read["brandname"].ToString().Trim();
                }
                read.Close();

                if (branIdValue == brandId.Text.Trim())
                {
                    string message = $"Do you want to Delete {branNameValue}?";
                    string title = "Delete Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos DELETE FROM brand WHERE brandid = '" + brandId.Text.Trim() + "';";
                        cmd.ExecuteNonQuery();

                        //View in brands in brandDataView
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                        SqlDataAdapter brandAdap = new SqlDataAdapter();
                        DataTable brandTable = new DataTable();
                        brandAdap.SelectCommand = cmd;
                        brandAdap.Fill(brandTable);
                        brandDataView.DataSource = brandTable;

                        //Get brandid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                        SqlDataReader read2 = cmd.ExecuteReader();

                        //Set brandId
                        if (read2.Read() == false)
                        {
                            brandId.Text = "1001";
                        }
                        else
                        {
                            int value = int.Parse(read2["brandid"].ToString().Trim()) + 1;
                            brandId.Text = value.ToString();
                        }
                        read2.Close();

                        brandName.Clear(); //Brandname clear

                        //Successful Added Message
                        string Message = $"{branNameValue} successfully delete from the system!";
                        string success = "Success";
                        MessageBox.Show(Message, success);

                        conn.db_connect_close(); //DB connection close
                    }
                }
                else
                {
                    string Message = "Cannot delete the Brand from database,\nBrand Id is not available in the Database!";
                    string warning = "Warning";
                    MessageBox.Show(Message, warning);
                }
            }
            catch(Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void categoryDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;

                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set categoryCount
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(categoryid) FROM category;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    categoryCount = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == categoryCount)
                {
                    //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = categoryDataView.Rows[index];
                    string selectCategoryId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM category WHERE categoryid = '" + selectCategoryId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        categoryId.Text = read.GetString(0).Trim();
                        categoryName.Text = read.GetString(1).Trim();
                    }
                    read.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void brandDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;

                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Set brandCount
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(brandid) FROM brand;";
                SqlDataReader read0 = cmd.ExecuteReader();
                while (read0.Read())
                {
                    brandCount = read0.GetInt32(0);
                }
                read0.Close();

                if (index == -1 || index == brandCount)
                {
                   //Nothing any action
                }
                else
                {
                    DataGridViewRow dataGridViewRowrow = brandDataView.Rows[index];
                    string selectBrandId = dataGridViewRowrow.Cells[0].Value.ToString().Trim();

                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT * FROM brand WHERE brandid = '" + selectBrandId + "';";
                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        brandId.Text = read.GetString(0).Trim();
                        brandName.Text = read.GetString(1).Trim();
                    }
                    read.Close();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void clearCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string catIdValue = ""; //Categoryid value holding

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = '" + categoryId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();
                //Set categoryId
                if (read.Read() == true)
                {
                    catIdValue = read["categoryid"].ToString().Trim();
                }
                read.Close();

                if (categoryName.Text != "" || categoryId.Text == catIdValue)
                {
                    string message = "Do you want to clear the inputs?";
                    string title = "Clear Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Clear categoryName text
                        categoryName.Clear();

                        //Get categoryid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT categoryid FROM category WHERE categoryid = (SELECT MAX(categoryid) FROM category);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set categoryId
                        if (read1.Read() == false)
                        {
                            categoryId.Text = "100";
                        }
                        else
                        {
                            int value = int.Parse(read1["categoryid"].ToString().Trim()) + 1;
                            categoryId.Text = value.ToString();
                        }
                        read1.Close();

                        //Database connection close
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

        private void clearBrand_Click(object sender, EventArgs e)
        {
            try
            {
                string branIdValue = ""; //Categoryid value holding

                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = '" + brandId.Text.Trim() + "';";
                SqlDataReader read = cmd.ExecuteReader();
                //Set categoryId
                if (read.Read() == true)
                {
                    branIdValue = read["brandid"].ToString().Trim();
                }
                read.Close();

                if (brandName.Text != "" || brandId.Text == branIdValue)
                {
                    string message = "Do you want to clear the inputs?";
                    string title = "Clear Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //Clear brandName text
                        brandName.Clear();

                        //Get brandid from Database
                        cmd.Connection = Connection.con;
                        cmd.CommandText = "USE pos SELECT brandid FROM brand WHERE brandid = (SELECT MAX(brandid) FROM brand);";
                        SqlDataReader read1 = cmd.ExecuteReader();

                        //Set brandId
                        if (read1.Read() == false)
                        {
                            brandId.Text = "1001";
                        }
                        else
                        {
                            int value = int.Parse(read1["brandid"].ToString().Trim()) + 1;
                            brandId.Text = value.ToString();
                        }
                        read1.Close();

                        //Database connection close
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

        private void brandSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = ""; //searchBox typings holder

                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                if (brandSearch.Text.Trim() != "")
                {
                    text = "%" + brandSearch.Text.Trim() + "%";

                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand WHERE (brandid + brandname) LIKE '" + text + "' ORDER BY brandid DESC;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    brandDataView.DataSource = brandTable;
                }
                else
                {
                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    brandDataView.DataSource = brandTable;
                }

                conn.db_connect_close(); //DB connection close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void categorySearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = ""; //searchBox typings holder

                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader


                if (categorySearch.Text.Trim() != "")
                {
                    text = "%" + categorySearch.Text.Trim() + "%";

                    //View in categories in categoryDataView based on Search
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category WHERE (categoryid + categoryname) LIKE '" + text + "' ORDER BY categoryid DESC;";
                    SqlDataAdapter categoryAdap = new SqlDataAdapter();
                    DataTable categoryTable = new DataTable();
                    categoryAdap.SelectCommand = cmd;
                    categoryAdap.Fill(categoryTable);
                    categoryDataView.DataSource = categoryTable;
                }
                else
                {
                    //View in categories in categoryDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                    SqlDataAdapter categoryAdap = new SqlDataAdapter();
                    DataTable categoryTable = new DataTable();
                    categoryAdap.SelectCommand = cmd;
                    categoryAdap.Fill(categoryTable);
                    categoryDataView.DataSource = categoryTable;
                }

                conn.db_connect_close(); //DB connection close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void brandTableReset_Click(object sender, EventArgs e)
        {
            try
            {
                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Reset the brandTable
                string message = "Do you want to reset the Category table?";
                string title = "Reset Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //View in brands in brandDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT brandid AS BrandID, brandname AS Brand FROM brand ORDER BY brandid DESC;";
                    SqlDataAdapter brandAdap = new SqlDataAdapter();
                    DataTable brandTable = new DataTable();
                    brandAdap.SelectCommand = cmd;
                    brandAdap.Fill(brandTable);
                    brandDataView.DataSource = brandTable;

                    brandSearch.Clear(); // Clear brandSearch Text box
                }
                conn.db_connect_close(); //DB connection close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void categoryTableReset_Click(object sender, EventArgs e)
        {
            try
            {
                //DB connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Reset the CategoryTable
                string message = "Do you want to reset the Category table?";
                string title = "Reset Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //View in categories in categoryDataView
                    cmd.Connection = Connection.con;
                    cmd.CommandText = "USE pos SELECT categoryid AS CategoryID, categoryname AS Category FROM category ORDER BY categoryid DESC;";
                    SqlDataAdapter categoryAdap = new SqlDataAdapter();
                    DataTable categoryTable = new DataTable();
                    categoryAdap.SelectCommand = cmd;
                    categoryAdap.Fill(categoryTable);
                    categoryDataView.DataSource = categoryTable;

                    categorySearch.Clear(); //Clear categorySearch Text box
                }

                conn.db_connect_close(); //DB connection close
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
