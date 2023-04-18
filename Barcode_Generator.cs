using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.OneD;

namespace PosSystem
{
    public partial class Barcode_Generator : UserControl
    {
        int rowCount; //Row count in item datatable

        public Barcode_Generator()
        {
            InitializeComponent();
        }

        private void printBarcode_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                BarcodePreview.Image.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Barcode_Generator_Load(object sender, EventArgs e)
        {
            try
            {
                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                //Brand Search 
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM brand ORDER BY brandname ASC;";
                SqlDataAdapter brandSearch = new SqlDataAdapter();
                DataTable brandSearchTable = new DataTable();
                brandSearch.SelectCommand = cmd;
                brandSearch.Fill(brandSearchTable);
                brandSearchCom.DataSource = brandSearchTable;
                brandSearchCom.DisplayMember = "brandname";
                brandSearchCom.ValueMember = "brandid";
                brandSearchCom.SelectedIndex = -1;

                //Category Search 
                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT * FROM category ORDER BY categoryname ASC;";
                SqlDataAdapter categorySearch = new SqlDataAdapter();
                DataTable categorySearchTable = new DataTable();
                categorySearch.SelectCommand = cmd;
                categorySearch.Fill(categorySearchTable);
                categorySearchCom.DataSource = categorySearchTable;
                categorySearchCom.DisplayMember = "categoryname";
                categorySearchCom.ValueMember = "categoryid";
                categorySearchCom.SelectedIndex = -1;

                //Serach Price clear
                //searchPrice.Clear();

                //View in data grud view
                cmd.Connection = Connection.con;
                cmd.CommandText = "SELECT item.itemid AS ItemID, brand.brandname AS Brand, category.categoryname AS Category, item.size AS Size, item.mrprice AS Price, item.quantity AS Quantity, item.description as Description FROM item INNER JOIN category ON item.categoryid = category.categoryid INNER JOIN brand ON item.brandid = brand.brandid ORDER BY itemid DESC;";
                SqlDataAdapter dataAdap = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                dataAdap.SelectCommand = cmd;
                dataAdap.Fill(dataTable);
                barcodeItems.DataSource = dataTable;

                conn.db_connect_close(); //Connection Close
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void barcodeItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ItemSize = ""; //Item Size Holder

                //DB Connection
                Connection conn = new Connection();
                conn.db_connect();

                int index;
                index = e.RowIndex;

                SqlCommand cmd = new SqlCommand(); //SQL command reader

                cmd.Connection = Connection.con;
                cmd.CommandText = "USE pos SELECT COUNT(itemid) FROM item;";
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
                    DataGridViewRow dataGridViewRowrow = barcodeItems.Rows[index];
                    string ItemId = dataGridViewRowrow.Cells[0].Value.ToString();
                    string ItemBrand = dataGridViewRowrow.Cells[1].Value.ToString();
                    string ItemCategory = dataGridViewRowrow.Cells[2].Value.ToString();
                    string Size = dataGridViewRowrow.Cells[3].Value.ToString();
                    string Price = dataGridViewRowrow.Cells[4].Value.ToString();
                    string Quantity = dataGridViewRowrow.Cells[5].Value.ToString();

                    //View in data grud view
                    itemCode.Text = ItemId.Trim();
                    itemBrand.Text = ItemBrand.Trim();
                    itemCategory.Text = ItemCategory.Trim();
                    itemQuantity.Text = Quantity.Trim();
                    itemPrice.Text = Price.Trim();
                    ItemSize = Size;

                    conn.db_connect_close(); //Connection Close
                }

                if (itemCode.Text.Length > 0)
                {
                    var headerHeight = 50;
                    var footerHeight = 50;
                    var barcodeWidth = 300;
                    var barcodeHeight = 100;
                    var totalWidth = barcodeWidth;
                    var totalHeight = headerHeight + barcodeHeight + footerHeight;
                    var totalBitmap = new Bitmap(totalWidth, totalHeight);
                    var graphics = Graphics.FromImage(totalBitmap);
                    graphics.FillRectangle(Brushes.White, 0, 0, totalWidth, totalHeight);

                    var writer = new BarcodeWriter();
                    writer.Format = BarcodeFormat.CODE_128;
                    writer.Options.Width = barcodeWidth;
                    writer.Options.Height = barcodeHeight;
                    var barcodeBitmap = writer.Write(itemCode.Text.Trim());

                    graphics.DrawImage(barcodeBitmap, (totalWidth - barcodeWidth) / 2, headerHeight);
                    var headerText = itemBrand.Text.Trim() + " - " + itemCategory.Text.Trim() + " | " + ItemSize;
                    var headerFont = new Font("Arial", 12);
                    var headerSize = graphics.MeasureString(headerText, headerFont);
                    graphics.DrawString(headerText, headerFont, Brushes.Black, new PointF((totalWidth - headerSize.Width) / 2, (headerHeight - headerSize.Height) / 2));
                    var footerText = "Rs." + itemPrice.Text.Trim();
                    var footerFont = new Font("Arial", 12);
                    var footerSize = graphics.MeasureString(footerText, footerFont);
                    graphics.DrawString(footerText, footerFont, Brushes.Black, new PointF((totalWidth - footerSize.Width) / 2, totalHeight - footerHeight + (footerHeight - footerSize.Height) / 2));

                    //View in Picture Box
                    BarcodePreview.Image = totalBitmap;



                    //Thermal Barcode Label Printer

                    //Printer = BIXOLON  Thermal Barcode Label Printer SLP-220 
                    //Instal BIXOLON SDK and Connect to the printer

                    /*
                    var printer = new bxl_ftp();
                    printer.OpenPrinter("SLP-220");

                    //Barcode Writer
                    var writer = new BarcodeWriter
                    {
                        Format = BarcodeFormat.CODE_128,
                        Options = new EncodingOptions
                        {
                            Height = 50,
                            Width = 200
                        },
                        Encoder = new Code128Writer()
                    };
                    var barcode = writer.Write(itemCode.Text.Trim());

                    var bitmap = new Bitmap(300, 100);
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.White);
                        graphics.DrawImage(barcode, new Point(50, 10));
                        graphics.DrawString("Header Text", new Font("Arial", 12), Brushes.Black, new PointF(50, 60));
                        graphics.DrawString("Footer Text", new Font("Arial", 12), Brushes.Black, new PointF(50, 80));

                        var headerText = itemBrand.Text.Trim() + " - " + itemCategory.Text.Trim() + " | " + ItemSize;
                        var headerFont = new Font("Arial", 12);
                        var headerSize = graphics.MeasureString(headerText, headerFont);
                        graphics.DrawString(headerText, headerFont, Brushes.Black, new PointF(50,60));
                        var footerText = "Rs." + itemPrice.Text.Trim();
                        var footerFont = new Font("Arial", 12);
                        var footerSize = graphics.MeasureString(footerText, footerFont);
                        graphics.DrawString(footerText, footerFont, Brushes.Black, new PointF(50, 60));
                    }

                    var data = new byte[320 * 150];
                    var size = bxl_common.GetBitmapData(bitmap, data, 320, 150);
                    printer.SendData(data, size);
                    printer.ClosePrinter();
                    */
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                string error = "Error";
                MessageBox.Show(errorMessage, error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Clear all TextBoxes
            itemCode.Clear();
            itemBrand.Clear();
            itemCategory.Clear();
            itemQuantity.Clear();
            itemPrice.Clear();

            //Picture Box Clear
            BarcodePreview.Image = null;
        }
    }
}
