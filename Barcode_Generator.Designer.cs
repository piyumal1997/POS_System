namespace PosSystem
{
    partial class Barcode_Generator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categorySearchCom = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.brandSearchCom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.itemQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemBrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.printBarcode = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BarcodePreview = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode Print";
            // 
            // barcodeItems
            // 
            this.barcodeItems.AllowUserToAddRows = false;
            this.barcodeItems.AllowUserToDeleteRows = false;
            this.barcodeItems.AllowUserToResizeRows = false;
            this.barcodeItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.barcodeItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.barcodeItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.barcodeItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.barcodeItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.barcodeItems.Location = new System.Drawing.Point(30, 188);
            this.barcodeItems.MultiSelect = false;
            this.barcodeItems.Name = "barcodeItems";
            this.barcodeItems.ReadOnly = true;
            this.barcodeItems.RowHeadersVisible = false;
            this.barcodeItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.barcodeItems.RowTemplate.Height = 26;
            this.barcodeItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.barcodeItems.Size = new System.Drawing.Size(600, 425);
            this.barcodeItems.TabIndex = 1;
            this.barcodeItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barcodeItems_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.categorySearchCom);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.brandSearchCom);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 96);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Category";
            // 
            // categorySearchCom
            // 
            this.categorySearchCom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearchCom.FormattingEnabled = true;
            this.categorySearchCom.Location = new System.Drawing.Point(106, 34);
            this.categorySearchCom.Name = "categorySearchCom";
            this.categorySearchCom.Size = new System.Drawing.Size(180, 31);
            this.categorySearchCom.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(325, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Brand";
            // 
            // brandSearchCom
            // 
            this.brandSearchCom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandSearchCom.FormattingEnabled = true;
            this.brandSearchCom.Location = new System.Drawing.Point(388, 34);
            this.brandSearchCom.Name = "brandSearchCom";
            this.brandSearchCom.Size = new System.Drawing.Size(180, 31);
            this.brandSearchCom.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Controls.Add(this.itemQuantity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.itemBrand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemCode);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(667, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode Details";
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(154, 178);
            this.itemPrice.MaxLength = 25;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            this.itemPrice.Size = new System.Drawing.Size(200, 31);
            this.itemPrice.TabIndex = 25;
            // 
            // itemQuantity
            // 
            this.itemQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantity.Location = new System.Drawing.Point(154, 143);
            this.itemQuantity.MaxLength = 25;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            this.itemQuantity.Size = new System.Drawing.Size(200, 31);
            this.itemQuantity.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Item Quantity";
            // 
            // itemBrand
            // 
            this.itemBrand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBrand.Location = new System.Drawing.Point(154, 106);
            this.itemBrand.MaxLength = 30;
            this.itemBrand.Name = "itemBrand";
            this.itemBrand.ReadOnly = true;
            this.itemBrand.Size = new System.Drawing.Size(200, 31);
            this.itemBrand.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Category";
            // 
            // itemCategory
            // 
            this.itemCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategory.Location = new System.Drawing.Point(154, 69);
            this.itemCategory.MaxLength = 30;
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.ReadOnly = true;
            this.itemCategory.Size = new System.Drawing.Size(200, 31);
            this.itemCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Code";
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.Location = new System.Drawing.Point(154, 32);
            this.itemCode.MaxLength = 25;
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            this.itemCode.Size = new System.Drawing.Size(200, 31);
            this.itemCode.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.BarcodePreview);
            this.groupBox3.Controls.Add(this.printBarcode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(667, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 293);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // printBarcode
            // 
            this.printBarcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.printBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBarcode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBarcode.Location = new System.Drawing.Point(148, 249);
            this.printBarcode.Name = "printBarcode";
            this.printBarcode.Size = new System.Drawing.Size(159, 36);
            this.printBarcode.TabIndex = 32;
            this.printBarcode.Text = "Print Sticker";
            this.printBarcode.UseVisualStyleBackColor = false;
            this.printBarcode.Click += new System.EventHandler(this.printBarcode_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(130, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 33);
            this.label12.TabIndex = 1;
            this.label12.Text = "Barcode Sticker";
            // 
            // BarcodePreview
            // 
            this.BarcodePreview.Location = new System.Drawing.Point(83, 46);
            this.BarcodePreview.Name = "BarcodePreview";
            this.BarcodePreview.Size = new System.Drawing.Size(300, 197);
            this.BarcodePreview.TabIndex = 33;
            this.BarcodePreview.TabStop = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(370, 30);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(79, 33);
            this.clear.TabIndex = 34;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Barcode_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barcodeItems);
            this.Controls.Add(this.panel1);
            this.Name = "Barcode_Generator";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Barcode_Generator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView barcodeItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox brandSearchCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.TextBox itemQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemBrand;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categorySearchCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button printBarcode;
        private System.Windows.Forms.PictureBox BarcodePreview;
        private System.Windows.Forms.Button clear;
    }
}
