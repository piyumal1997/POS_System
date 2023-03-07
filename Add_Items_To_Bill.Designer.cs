namespace PosSystem
{
    partial class Add_Items_To_Bill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items_To_Bill));
            this.close = new System.Windows.Forms.Button();
            this.itemDataViewer = new System.Windows.Forms.DataGridView();
            this.manualBillItems = new System.Windows.Forms.DataGridView();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addToBill = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.maxDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.billingItemCode = new System.Windows.Forms.TextBox();
            this.billingItemQuantity = new System.Windows.Forms.TextBox();
            this.billingItemDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.changeDandQ = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualBillItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(967, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 6;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // itemDataViewer
            // 
            this.itemDataViewer.AllowUserToAddRows = false;
            this.itemDataViewer.AllowUserToDeleteRows = false;
            this.itemDataViewer.AllowUserToResizeColumns = false;
            this.itemDataViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataViewer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.itemDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataViewer.DefaultCellStyle = dataGridViewCellStyle6;
            this.itemDataViewer.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemDataViewer.Location = new System.Drawing.Point(49, 175);
            this.itemDataViewer.MultiSelect = false;
            this.itemDataViewer.Name = "itemDataViewer";
            this.itemDataViewer.ReadOnly = true;
            this.itemDataViewer.RowHeadersVisible = false;
            this.itemDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataViewer.ShowEditingIcon = false;
            this.itemDataViewer.Size = new System.Drawing.Size(915, 175);
            this.itemDataViewer.TabIndex = 7;
            this.itemDataViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemDataViewer_CellClick);
            // 
            // manualBillItems
            // 
            this.manualBillItems.AllowUserToAddRows = false;
            this.manualBillItems.AllowUserToDeleteRows = false;
            this.manualBillItems.AllowUserToResizeColumns = false;
            this.manualBillItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manualBillItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manualBillItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.manualBillItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manualBillItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.manualBillItems.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.manualBillItems.Location = new System.Drawing.Point(49, 489);
            this.manualBillItems.MultiSelect = false;
            this.manualBillItems.Name = "manualBillItems";
            this.manualBillItems.ReadOnly = true;
            this.manualBillItems.RowHeadersVisible = false;
            this.manualBillItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manualBillItems.ShowEditingIcon = false;
            this.manualBillItems.Size = new System.Drawing.Size(915, 186);
            this.manualBillItems.TabIndex = 8;
            this.manualBillItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.manualBillItems_CellClick);
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.ForeColor = System.Drawing.Color.Indigo;
            this.itemCode.Location = new System.Drawing.Point(81, 21);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(145, 33);
            this.itemCode.TabIndex = 9;
            this.itemCode.TextChanged += new System.EventHandler(this.itemCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bill Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Code";
            // 
            // addToBill
            // 
            this.addToBill.BackColor = System.Drawing.Color.DarkGreen;
            this.addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToBill.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addToBill.Location = new System.Drawing.Point(854, 67);
            this.addToBill.Name = "addToBill";
            this.addToBill.Size = new System.Drawing.Size(78, 65);
            this.addToBill.TabIndex = 16;
            this.addToBill.Text = "Add";
            this.addToBill.UseVisualStyleBackColor = false;
            this.addToBill.Click += new System.EventHandler(this.addToBill_Click);
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(413, 49);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(150, 31);
            this.code.TabIndex = 17;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(81, 71);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(145, 35);
            this.clear.TabIndex = 18;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.itemCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(51, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 120);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Size";
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(413, 86);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(150, 31);
            this.brand.TabIndex = 25;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(413, 123);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(150, 31);
            this.category.TabIndex = 26;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(663, 49);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(150, 31);
            this.price.TabIndex = 27;
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(663, 86);
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Size = new System.Drawing.Size(150, 31);
            this.size.TabIndex = 29;
            // 
            // maxDiscount
            // 
            this.maxDiscount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDiscount.Location = new System.Drawing.Point(663, 123);
            this.maxDiscount.Name = "maxDiscount";
            this.maxDiscount.ReadOnly = true;
            this.maxDiscount.Size = new System.Drawing.Size(150, 31);
            this.maxDiscount.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Max Dsc";
            // 
            // billingItemCode
            // 
            this.billingItemCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingItemCode.Location = new System.Drawing.Point(117, 415);
            this.billingItemCode.Name = "billingItemCode";
            this.billingItemCode.ReadOnly = true;
            this.billingItemCode.Size = new System.Drawing.Size(150, 31);
            this.billingItemCode.TabIndex = 32;
            // 
            // billingItemQuantity
            // 
            this.billingItemQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingItemQuantity.Location = new System.Drawing.Point(368, 393);
            this.billingItemQuantity.Name = "billingItemQuantity";
            this.billingItemQuantity.ReadOnly = true;
            this.billingItemQuantity.Size = new System.Drawing.Size(150, 31);
            this.billingItemQuantity.TabIndex = 33;
            // 
            // billingItemDiscount
            // 
            this.billingItemDiscount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingItemDiscount.Location = new System.Drawing.Point(368, 434);
            this.billingItemDiscount.Name = "billingItemDiscount";
            this.billingItemDiscount.ReadOnly = true;
            this.billingItemDiscount.Size = new System.Drawing.Size(150, 31);
            this.billingItemDiscount.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(283, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Quantity";
            // 
            // changeDandQ
            // 
            this.changeDandQ.BackColor = System.Drawing.Color.SaddleBrown;
            this.changeDandQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeDandQ.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDandQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeDandQ.Location = new System.Drawing.Point(803, 395);
            this.changeDandQ.Name = "changeDandQ";
            this.changeDandQ.Size = new System.Drawing.Size(78, 65);
            this.changeDandQ.TabIndex = 38;
            this.changeDandQ.Text = "Edit";
            this.changeDandQ.UseVisualStyleBackColor = false;
            this.changeDandQ.Click += new System.EventHandler(this.changeDandQ_Click);
            // 
            // removeItem
            // 
            this.removeItem.BackColor = System.Drawing.Color.Red;
            this.removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeItem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeItem.Image = ((System.Drawing.Image)(resources.GetObject("removeItem.Image")));
            this.removeItem.Location = new System.Drawing.Point(899, 395);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(65, 65);
            this.removeItem.TabIndex = 39;
            this.removeItem.UseVisualStyleBackColor = false;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // Add_Items_To_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 709);
            this.ControlBox = false;
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.changeDandQ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.billingItemDiscount);
            this.Controls.Add(this.billingItemQuantity);
            this.Controls.Add(this.billingItemCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxDiscount);
            this.Controls.Add(this.size);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.code);
            this.Controls.Add(this.addToBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualBillItems);
            this.Controls.Add(this.itemDataViewer);
            this.Controls.Add(this.close);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1035, 725);
            this.MinimumSize = new System.Drawing.Size(1035, 708);
            this.Name = "Add_Items_To_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Add_Items_To_Bill_Activated);
            this.Load += new System.EventHandler(this.Add_Items_To_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualBillItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView itemDataViewer;
        private System.Windows.Forms.DataGridView manualBillItems;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addToBill;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox maxDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox billingItemCode;
        private System.Windows.Forms.TextBox billingItemQuantity;
        private System.Windows.Forms.TextBox billingItemDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeDandQ;
        private System.Windows.Forms.Button removeItem;
    }
}