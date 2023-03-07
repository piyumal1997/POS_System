namespace PosSystem
{
    partial class Inventory_Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.selectSupplier = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantity = new System.Windows.Forms.MaskedTextBox();
            this.totalPrice = new System.Windows.Forms.MaskedTextBox();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.supplierSelection = new System.Windows.Forms.ComboBox();
            this.orderDescription = new System.Windows.Forms.RichTextBox();
            this.clearOrder = new System.Windows.Forms.Button();
            this.updateOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderIdConfirm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearCon = new System.Windows.Forms.Button();
            this.reProcessedOrder = new System.Windows.Forms.Button();
            this.confirmOrder = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectSupplier2 = new System.Windows.Forms.ComboBox();
            this.proceedingOrders = new System.Windows.Forms.DataGridView();
            this.completeOrders = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.orderDesConfirm = new System.Windows.Forms.RichTextBox();
            this.search2 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.reset2 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proceedingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.selectSupplier);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Supplier";
            // 
            // selectSupplier
            // 
            this.selectSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSupplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSupplier.FormattingEnabled = true;
            this.selectSupplier.Location = new System.Drawing.Point(93, 23);
            this.selectSupplier.Name = "selectSupplier";
            this.selectSupplier.Size = new System.Drawing.Size(170, 31);
            this.selectSupplier.TabIndex = 15;
            this.selectSupplier.SelectedValueChanged += new System.EventHandler(this.selectSupplier_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.totalPrice);
            this.groupBox1.Controls.Add(this.deleteOrder);
            this.groupBox1.Controls.Add(this.supplierSelection);
            this.groupBox1.Controls.Add(this.orderDescription);
            this.groupBox1.Controls.Add(this.clearOrder);
            this.groupBox1.Controls.Add(this.updateOrder);
            this.groupBox1.Controls.Add(this.addOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orderCode);
            this.groupBox1.Location = new System.Drawing.Point(679, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 350);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(163, 54);
            this.quantity.Mask = "00000";
            this.quantity.PromptChar = ' ';
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(240, 31);
            this.quantity.TabIndex = 26;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(163, 129);
            this.totalPrice.Mask = "0000000";
            this.totalPrice.PromptChar = ' ';
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(240, 31);
            this.totalPrice.TabIndex = 25;
            // 
            // deleteOrder
            // 
            this.deleteOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrder.Location = new System.Drawing.Point(334, 304);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(86, 31);
            this.deleteOrder.TabIndex = 24;
            this.deleteOrder.Text = "Delete";
            this.deleteOrder.UseVisualStyleBackColor = true;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // supplierSelection
            // 
            this.supplierSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierSelection.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierSelection.FormattingEnabled = true;
            this.supplierSelection.Location = new System.Drawing.Point(163, 91);
            this.supplierSelection.Name = "supplierSelection";
            this.supplierSelection.Size = new System.Drawing.Size(240, 31);
            this.supplierSelection.TabIndex = 22;
            // 
            // orderDescription
            // 
            this.orderDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDescription.Location = new System.Drawing.Point(163, 167);
            this.orderDescription.MaxLength = 250;
            this.orderDescription.Name = "orderDescription";
            this.orderDescription.Size = new System.Drawing.Size(240, 120);
            this.orderDescription.TabIndex = 21;
            this.orderDescription.Text = "";
            // 
            // clearOrder
            // 
            this.clearOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearOrder.Location = new System.Drawing.Point(243, 304);
            this.clearOrder.Name = "clearOrder";
            this.clearOrder.Size = new System.Drawing.Size(76, 31);
            this.clearOrder.TabIndex = 20;
            this.clearOrder.Text = "Clear";
            this.clearOrder.UseVisualStyleBackColor = true;
            this.clearOrder.Click += new System.EventHandler(this.clearOrder_Click);
            // 
            // updateOrder
            // 
            this.updateOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateOrder.Location = new System.Drawing.Point(151, 304);
            this.updateOrder.Name = "updateOrder";
            this.updateOrder.Size = new System.Drawing.Size(86, 31);
            this.updateOrder.TabIndex = 18;
            this.updateOrder.Text = "Update";
            this.updateOrder.UseVisualStyleBackColor = true;
            this.updateOrder.Click += new System.EventHandler(this.updateOrder_Click);
            // 
            // addOrder
            // 
            this.addOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.Location = new System.Drawing.Point(69, 304);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(76, 31);
            this.addOrder.TabIndex = 17;
            this.addOrder.Text = "Add";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Code";
            // 
            // orderCode
            // 
            this.orderCode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCode.Location = new System.Drawing.Point(163, 17);
            this.orderCode.MaxLength = 25;
            this.orderCode.Name = "orderCode";
            this.orderCode.ReadOnly = true;
            this.orderCode.Size = new System.Drawing.Size(240, 31);
            this.orderCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 60);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Order Code";
            // 
            // orderIdConfirm
            // 
            this.orderIdConfirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdConfirm.Location = new System.Drawing.Point(165, 24);
            this.orderIdConfirm.MaxLength = 30;
            this.orderIdConfirm.Name = "orderIdConfirm";
            this.orderIdConfirm.ReadOnly = true;
            this.orderIdConfirm.Size = new System.Drawing.Size(240, 31);
            this.orderIdConfirm.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.orderDesConfirm);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.clearCon);
            this.groupBox3.Controls.Add(this.reProcessedOrder);
            this.groupBox3.Controls.Add(this.confirmOrder);
            this.groupBox3.Controls.Add(this.orderIdConfirm);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(679, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 181);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmed Orders";
            // 
            // clearCon
            // 
            this.clearCon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCon.Location = new System.Drawing.Point(66, 139);
            this.clearCon.Name = "clearCon";
            this.clearCon.Size = new System.Drawing.Size(76, 31);
            this.clearCon.TabIndex = 27;
            this.clearCon.Text = "Clear";
            this.clearCon.UseVisualStyleBackColor = true;
            this.clearCon.Click += new System.EventHandler(this.clearCon_Click);
            // 
            // reProcessedOrder
            // 
            this.reProcessedOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reProcessedOrder.Location = new System.Drawing.Point(148, 139);
            this.reProcessedOrder.Name = "reProcessedOrder";
            this.reProcessedOrder.Size = new System.Drawing.Size(134, 31);
            this.reProcessedOrder.TabIndex = 27;
            this.reProcessedOrder.Text = "Re-Processed";
            this.reProcessedOrder.UseVisualStyleBackColor = true;
            this.reProcessedOrder.Click += new System.EventHandler(this.reProcessedOrder_Click);
            // 
            // confirmOrder
            // 
            this.confirmOrder.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrder.Location = new System.Drawing.Point(288, 139);
            this.confirmOrder.Name = "confirmOrder";
            this.confirmOrder.Size = new System.Drawing.Size(134, 31);
            this.confirmOrder.TabIndex = 26;
            this.confirmOrder.Text = "Confirm Order";
            this.confirmOrder.UseVisualStyleBackColor = true;
            this.confirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.reset2);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.search2);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.selectSupplier2);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(39, 377);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(600, 70);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Supplier";
            // 
            // selectSupplier2
            // 
            this.selectSupplier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSupplier2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSupplier2.FormattingEnabled = true;
            this.selectSupplier2.Location = new System.Drawing.Point(93, 24);
            this.selectSupplier2.Name = "selectSupplier2";
            this.selectSupplier2.Size = new System.Drawing.Size(170, 31);
            this.selectSupplier2.TabIndex = 15;
            this.selectSupplier2.SelectedValueChanged += new System.EventHandler(this.selectSupplier2_SelectedValueChanged);
            // 
            // proceedingOrders
            // 
            this.proceedingOrders.AllowUserToAddRows = false;
            this.proceedingOrders.AllowUserToDeleteRows = false;
            this.proceedingOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proceedingOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.proceedingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.proceedingOrders.DefaultCellStyle = dataGridViewCellStyle22;
            this.proceedingOrders.Location = new System.Drawing.Point(39, 184);
            this.proceedingOrders.MultiSelect = false;
            this.proceedingOrders.Name = "proceedingOrders";
            this.proceedingOrders.ReadOnly = true;
            this.proceedingOrders.RowHeadersVisible = false;
            this.proceedingOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proceedingOrders.Size = new System.Drawing.Size(600, 145);
            this.proceedingOrders.TabIndex = 31;
            this.proceedingOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proceedingOrders_CellClick);
            // 
            // completeOrders
            // 
            this.completeOrders.AllowUserToAddRows = false;
            this.completeOrders.AllowUserToDeleteRows = false;
            this.completeOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completeOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.completeOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.completeOrders.DefaultCellStyle = dataGridViewCellStyle24;
            this.completeOrders.Location = new System.Drawing.Point(39, 464);
            this.completeOrders.MultiSelect = false;
            this.completeOrders.Name = "completeOrders";
            this.completeOrders.ReadOnly = true;
            this.completeOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.completeOrders.RowHeadersVisible = false;
            this.completeOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.completeOrders.Size = new System.Drawing.Size(600, 149);
            this.completeOrders.TabIndex = 27;
            this.completeOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.completeOrders_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Proceeding Orders";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Complete Orders";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Description";
            // 
            // orderDesConfirm
            // 
            this.orderDesConfirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDesConfirm.Location = new System.Drawing.Point(165, 63);
            this.orderDesConfirm.MaxLength = 250;
            this.orderDesConfirm.Name = "orderDesConfirm";
            this.orderDesConfirm.ReadOnly = true;
            this.orderDesConfirm.Size = new System.Drawing.Size(240, 65);
            this.orderDesConfirm.TabIndex = 27;
            this.orderDesConfirm.Text = "";
            // 
            // search2
            // 
            this.search2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2.Location = new System.Drawing.Point(339, 24);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(170, 31);
            this.search2.TabIndex = 17;
            this.search2.TextChanged += new System.EventHandler(this.search2_TextChanged);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(339, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(170, 31);
            this.search.TabIndex = 18;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(274, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Search";
            // 
            // reset2
            // 
            this.reset2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset2.Location = new System.Drawing.Point(518, 23);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(65, 31);
            this.reset2.TabIndex = 27;
            this.reset2.Text = "Reset";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(518, 22);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(65, 31);
            this.reset.TabIndex = 28;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Inventory_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.proceedingOrders);
            this.Controls.Add(this.completeOrders);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventory_Order";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Inventory_Order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proceedingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completeOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox selectSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox orderDescription;
        private System.Windows.Forms.Button clearOrder;
        private System.Windows.Forms.Button updateOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox supplierSelection;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderIdConfirm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox totalPrice;
        private System.Windows.Forms.Button confirmOrder;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectSupplier2;
        private System.Windows.Forms.DataGridView proceedingOrders;
        private System.Windows.Forms.DataGridView completeOrders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox quantity;
        private System.Windows.Forms.Button reProcessedOrder;
        private System.Windows.Forms.Button clearCon;
        private System.Windows.Forms.RichTextBox orderDesConfirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox search2;
    }
}
