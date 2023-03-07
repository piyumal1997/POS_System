namespace PosSystem
{
    partial class Add_Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemSize = new System.Windows.Forms.ComboBox();
            this.maxDiscount = new System.Windows.Forms.MaskedTextBox();
            this.mrPrice = new System.Windows.Forms.MaskedTextBox();
            this.unitCost = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.deleteUpate = new System.Windows.Forms.Button();
            this.updateItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.todayDateView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.itemQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCategory = new System.Windows.Forms.ComboBox();
            this.itemBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.itemDataViwer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetItemTable = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.catSearchCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.branSearchCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.price = new System.Windows.Forms.RadioButton();
            this.quantity = new System.Windows.Forms.RadioButton();
            this.searchPrice = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViwer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 60);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.itemSize);
            this.groupBox1.Controls.Add(this.maxDiscount);
            this.groupBox1.Controls.Add(this.mrPrice);
            this.groupBox1.Controls.Add(this.unitCost);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.deleteUpate);
            this.groupBox1.Controls.Add(this.updateItem);
            this.groupBox1.Controls.Add(this.addItem);
            this.groupBox1.Controls.Add(this.todayDateView);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.itemQuantity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.itemDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemCategory);
            this.groupBox1.Controls.Add(this.itemBrand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.itemCode);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(668, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // itemSize
            // 
            this.itemSize.FormattingEnabled = true;
            this.itemSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL",
            "XXXXL"});
            this.itemSize.Location = new System.Drawing.Point(163, 150);
            this.itemSize.Name = "itemSize";
            this.itemSize.Size = new System.Drawing.Size(200, 31);
            this.itemSize.TabIndex = 3;
            // 
            // maxDiscount
            // 
            this.maxDiscount.Location = new System.Drawing.Point(163, 348);
            this.maxDiscount.Mask = "0000";
            this.maxDiscount.PromptChar = ' ';
            this.maxDiscount.Name = "maxDiscount";
            this.maxDiscount.Size = new System.Drawing.Size(200, 31);
            this.maxDiscount.TabIndex = 7;
            // 
            // mrPrice
            // 
            this.mrPrice.Location = new System.Drawing.Point(163, 311);
            this.mrPrice.Mask = "0000";
            this.mrPrice.PromptChar = ' ';
            this.mrPrice.Name = "mrPrice";
            this.mrPrice.Size = new System.Drawing.Size(200, 31);
            this.mrPrice.TabIndex = 6;
            // 
            // unitCost
            // 
            this.unitCost.Location = new System.Drawing.Point(163, 274);
            this.unitCost.Mask = "0000";
            this.unitCost.PromptChar = ' ';
            this.unitCost.Name = "unitCost";
            this.unitCost.Size = new System.Drawing.Size(200, 31);
            this.unitCost.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(369, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 38);
            this.label13.TabIndex = 15;
            this.label13.Text = "Barcode\r\nCode";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(366, 476);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 31);
            this.clear.TabIndex = 13;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // deleteUpate
            // 
            this.deleteUpate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUpate.Location = new System.Drawing.Point(258, 476);
            this.deleteUpate.Name = "deleteUpate";
            this.deleteUpate.Size = new System.Drawing.Size(87, 31);
            this.deleteUpate.TabIndex = 12;
            this.deleteUpate.Text = "Delete";
            this.deleteUpate.UseVisualStyleBackColor = true;
            this.deleteUpate.Click += new System.EventHandler(this.deleteUpate_Click);
            // 
            // updateItem
            // 
            this.updateItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItem.Location = new System.Drawing.Point(147, 476);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(91, 31);
            this.updateItem.TabIndex = 11;
            this.updateItem.Text = "Update";
            this.updateItem.UseVisualStyleBackColor = true;
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(53, 476);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(78, 31);
            this.addItem.TabIndex = 10;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // todayDateView
            // 
            this.todayDateView.Location = new System.Drawing.Point(163, 422);
            this.todayDateView.MaxLength = 35;
            this.todayDateView.Name = "todayDateView";
            this.todayDateView.ReadOnly = true;
            this.todayDateView.Size = new System.Drawing.Size(200, 31);
            this.todayDateView.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "No. of Units";
            // 
            // itemQuantity
            // 
            this.itemQuantity.Location = new System.Drawing.Point(163, 385);
            this.itemQuantity.MaxLength = 10;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(200, 31);
            this.itemQuantity.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Max Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "MR Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Unit Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description";
            // 
            // itemDescription
            // 
            this.itemDescription.Location = new System.Drawing.Point(163, 187);
            this.itemDescription.MaxLength = 200;
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(200, 81);
            this.itemDescription.TabIndex = 4;
            this.itemDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Item Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item Brand";
            // 
            // itemCategory
            // 
            this.itemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCategory.FormattingEnabled = true;
            this.itemCategory.Location = new System.Drawing.Point(163, 76);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(200, 31);
            this.itemCategory.TabIndex = 2;
            // 
            // itemBrand
            // 
            this.itemBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemBrand.FormattingEnabled = true;
            this.itemBrand.Location = new System.Drawing.Point(163, 113);
            this.itemBrand.Name = "itemBrand";
            this.itemBrand.Size = new System.Drawing.Size(200, 31);
            this.itemBrand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item Code";
            // 
            // itemCode
            // 
            this.itemCode.Location = new System.Drawing.Point(163, 39);
            this.itemCode.MaxLength = 20;
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            this.itemCode.Size = new System.Drawing.Size(200, 31);
            this.itemCode.TabIndex = 0;
            // 
            // itemDataViwer
            // 
            this.itemDataViwer.AllowUserToAddRows = false;
            this.itemDataViwer.AllowUserToDeleteRows = false;
            this.itemDataViwer.AllowUserToResizeRows = false;
            this.itemDataViwer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataViwer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemDataViwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataViwer.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemDataViwer.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataViwer.Location = new System.Drawing.Point(25, 253);
            this.itemDataViwer.MultiSelect = false;
            this.itemDataViwer.Name = "itemDataViwer";
            this.itemDataViwer.ReadOnly = true;
            this.itemDataViwer.RowHeadersVisible = false;
            this.itemDataViwer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataViwer.Size = new System.Drawing.Size(620, 361);
            this.itemDataViwer.TabIndex = 2;
            this.itemDataViwer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataViwer_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.resetItemTable);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.catSearchCombo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.branSearchCombo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // resetItemTable
            // 
            this.resetItemTable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetItemTable.Location = new System.Drawing.Point(223, 115);
            this.resetItemTable.Name = "resetItemTable";
            this.resetItemTable.Size = new System.Drawing.Size(181, 35);
            this.resetItemTable.TabIndex = 3;
            this.resetItemTable.Text = "Reset Item Table";
            this.resetItemTable.UseVisualStyleBackColor = true;
            this.resetItemTable.Click += new System.EventHandler(this.resetItemTable_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(268, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Category";
            // 
            // catSearchCombo
            // 
            this.catSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catSearchCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catSearchCombo.FormattingEnabled = true;
            this.catSearchCombo.Location = new System.Drawing.Point(436, 73);
            this.catSearchCombo.Name = "catSearchCombo";
            this.catSearchCombo.Size = new System.Drawing.Size(160, 31);
            this.catSearchCombo.TabIndex = 2;
            this.catSearchCombo.SelectedValueChanged += new System.EventHandler(this.catSearchCombo_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Brand";
            // 
            // branSearchCombo
            // 
            this.branSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branSearchCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branSearchCombo.FormattingEnabled = true;
            this.branSearchCombo.Location = new System.Drawing.Point(88, 73);
            this.branSearchCombo.Name = "branSearchCombo";
            this.branSearchCombo.Size = new System.Drawing.Size(160, 31);
            this.branSearchCombo.TabIndex = 1;
            this.branSearchCombo.SelectedValueChanged += new System.EventHandler(this.branSearchCombo_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Size";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.FormattingEnabled = true;
            this.search.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL",
            "XXXXL"});
            this.search.Location = new System.Drawing.Point(88, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(160, 31);
            this.search.TabIndex = 25;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quantity);
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Controls.Add(this.searchPrice);
            this.groupBox3.Location = new System.Drawing.Point(266, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 56);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(6, 22);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(61, 23);
            this.price.TabIndex = 0;
            this.price.TabStop = true;
            this.price.Text = "Price";
            this.price.UseVisualStyleBackColor = true;
            this.price.CheckedChanged += new System.EventHandler(this.price_CheckedChanged);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(77, 22);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(87, 23);
            this.quantity.TabIndex = 1;
            this.quantity.TabStop = true;
            this.quantity.Text = "Quantity";
            this.quantity.UseVisualStyleBackColor = true;
            this.quantity.CheckedChanged += new System.EventHandler(this.quantity_CheckedChanged);
            // 
            // searchPrice
            // 
            this.searchPrice.Enabled = false;
            this.searchPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPrice.Location = new System.Drawing.Point(170, 18);
            this.searchPrice.Mask = "00000";
            this.searchPrice.PromptChar = ' ';
            this.searchPrice.Name = "searchPrice";
            this.searchPrice.Size = new System.Drawing.Size(160, 31);
            this.searchPrice.TabIndex = 25;
            this.searchPrice.TextChanged += new System.EventHandler(this.searchPrice_TextChanged);
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.itemDataViwer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Items";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Add_Items_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViwer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button deleteUpate;
        private System.Windows.Forms.Button updateItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.TextBox todayDateView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox itemDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox itemCategory;
        private System.Windows.Forms.ComboBox itemBrand;
        private System.Windows.Forms.DataGridView itemDataViwer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox branSearchCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button resetItemTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox catSearchCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox unitCost;
        private System.Windows.Forms.MaskedTextBox maxDiscount;
        private System.Windows.Forms.MaskedTextBox mrPrice;
        private System.Windows.Forms.ComboBox itemSize;
        private System.Windows.Forms.TextBox itemQuantity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton quantity;
        private System.Windows.Forms.RadioButton price;
        private System.Windows.Forms.MaskedTextBox searchPrice;
        private System.Windows.Forms.ComboBox search;
    }
}
