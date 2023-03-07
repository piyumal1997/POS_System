namespace PosSystem
{
    partial class Add_BandC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.categoryTableReset = new System.Windows.Forms.Button();
            this.categorySearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryDataView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryId = new System.Windows.Forms.TextBox();
            this.clearCategory = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.updateCategory = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.brandTableReset = new System.Windows.Forms.Button();
            this.brandSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brandDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brandId = new System.Windows.Forms.TextBox();
            this.clearBrand = new System.Windows.Forms.Button();
            this.deleteBrand = new System.Windows.Forms.Button();
            this.updateBrand = new System.Windows.Forms.Button();
            this.addBrand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.brandName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Brand and Category";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.categoryDataView);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(26, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1100, 267);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Category";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.categoryTableReset);
            this.groupBox4.Controls.Add(this.categorySearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(29, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 75);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Box";
            // 
            // categoryTableReset
            // 
            this.categoryTableReset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTableReset.Location = new System.Drawing.Point(299, 27);
            this.categoryTableReset.Name = "categoryTableReset";
            this.categoryTableReset.Size = new System.Drawing.Size(189, 32);
            this.categoryTableReset.TabIndex = 3;
            this.categoryTableReset.Text = "Category Table Reset";
            this.categoryTableReset.UseVisualStyleBackColor = true;
            this.categoryTableReset.Click += new System.EventHandler(this.categoryTableReset_Click);
            // 
            // categorySearch
            // 
            this.categorySearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySearch.Location = new System.Drawing.Point(99, 28);
            this.categorySearch.MaxLength = 200;
            this.categorySearch.Name = "categorySearch";
            this.categorySearch.Size = new System.Drawing.Size(180, 31);
            this.categorySearch.TabIndex = 2;
            this.categorySearch.TextChanged += new System.EventHandler(this.categorySearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search";
            // 
            // categoryDataView
            // 
            this.categoryDataView.AllowUserToAddRows = false;
            this.categoryDataView.AllowUserToDeleteRows = false;
            this.categoryDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoryDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.categoryDataView.Location = new System.Drawing.Point(29, 122);
            this.categoryDataView.MultiSelect = false;
            this.categoryDataView.Name = "categoryDataView";
            this.categoryDataView.ReadOnly = true;
            this.categoryDataView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataView.Size = new System.Drawing.Size(511, 125);
            this.categoryDataView.TabIndex = 19;
            this.categoryDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categoryId);
            this.groupBox1.Controls.Add(this.clearCategory);
            this.groupBox1.Controls.Add(this.deleteCategory);
            this.groupBox1.Controls.Add(this.updateCategory);
            this.groupBox1.Controls.Add(this.addCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.categoryName);
            this.groupBox1.Location = new System.Drawing.Point(631, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Category Id";
            // 
            // categoryId
            // 
            this.categoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryId.Location = new System.Drawing.Point(173, 43);
            this.categoryId.MaxLength = 40;
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            this.categoryId.Size = new System.Drawing.Size(200, 31);
            this.categoryId.TabIndex = 6;
            // 
            // clearCategory
            // 
            this.clearCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCategory.Location = new System.Drawing.Point(316, 144);
            this.clearCategory.Name = "clearCategory";
            this.clearCategory.Size = new System.Drawing.Size(80, 32);
            this.clearCategory.TabIndex = 5;
            this.clearCategory.Text = "Clear";
            this.clearCategory.UseVisualStyleBackColor = true;
            this.clearCategory.Click += new System.EventHandler(this.clearCategory_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategory.Location = new System.Drawing.Point(224, 144);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(80, 32);
            this.deleteCategory.TabIndex = 4;
            this.deleteCategory.Text = "Delete";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // updateCategory
            // 
            this.updateCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategory.Location = new System.Drawing.Point(128, 144);
            this.updateCategory.Name = "updateCategory";
            this.updateCategory.Size = new System.Drawing.Size(80, 32);
            this.updateCategory.TabIndex = 3;
            this.updateCategory.Text = "Update";
            this.updateCategory.UseVisualStyleBackColor = true;
            this.updateCategory.Click += new System.EventHandler(this.updateCategory_Click);
            // 
            // addCategory
            // 
            this.addCategory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.Location = new System.Drawing.Point(38, 144);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(74, 32);
            this.addCategory.TabIndex = 2;
            this.addCategory.Text = "Add";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // categoryName
            // 
            this.categoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(173, 88);
            this.categoryName.MaxLength = 40;
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(200, 31);
            this.categoryName.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.brandDataView);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(25, 342);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1101, 263);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Brand";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.brandTableReset);
            this.groupBox3.Controls.Add(this.brandSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 75);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Box";
            // 
            // brandTableReset
            // 
            this.brandTableReset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTableReset.Location = new System.Drawing.Point(299, 27);
            this.brandTableReset.Name = "brandTableReset";
            this.brandTableReset.Size = new System.Drawing.Size(189, 32);
            this.brandTableReset.TabIndex = 4;
            this.brandTableReset.Text = "Brand Table Reset";
            this.brandTableReset.UseVisualStyleBackColor = true;
            this.brandTableReset.Click += new System.EventHandler(this.brandTableReset_Click);
            // 
            // brandSearch
            // 
            this.brandSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandSearch.Location = new System.Drawing.Point(102, 28);
            this.brandSearch.MaxLength = 200;
            this.brandSearch.Name = "brandSearch";
            this.brandSearch.Size = new System.Drawing.Size(180, 31);
            this.brandSearch.TabIndex = 2;
            this.brandSearch.TextChanged += new System.EventHandler(this.brandSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search";
            // 
            // brandDataView
            // 
            this.brandDataView.AllowUserToAddRows = false;
            this.brandDataView.AllowUserToDeleteRows = false;
            this.brandDataView.AllowUserToResizeRows = false;
            this.brandDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brandDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.brandDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.brandDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.brandDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.brandDataView.Location = new System.Drawing.Point(30, 119);
            this.brandDataView.MultiSelect = false;
            this.brandDataView.Name = "brandDataView";
            this.brandDataView.ReadOnly = true;
            this.brandDataView.RowHeadersVisible = false;
            this.brandDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandDataView.Size = new System.Drawing.Size(511, 125);
            this.brandDataView.TabIndex = 20;
            this.brandDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brandDataView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.brandId);
            this.groupBox2.Controls.Add(this.clearBrand);
            this.groupBox2.Controls.Add(this.deleteBrand);
            this.groupBox2.Controls.Add(this.updateBrand);
            this.groupBox2.Controls.Add(this.addBrand);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.brandName);
            this.groupBox2.Location = new System.Drawing.Point(633, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 195);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Brand Id";
            // 
            // brandId
            // 
            this.brandId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandId.Location = new System.Drawing.Point(171, 45);
            this.brandId.MaxLength = 50;
            this.brandId.Name = "brandId";
            this.brandId.ReadOnly = true;
            this.brandId.Size = new System.Drawing.Size(200, 31);
            this.brandId.TabIndex = 6;
            // 
            // clearBrand
            // 
            this.clearBrand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBrand.Location = new System.Drawing.Point(330, 139);
            this.clearBrand.Name = "clearBrand";
            this.clearBrand.Size = new System.Drawing.Size(80, 32);
            this.clearBrand.TabIndex = 5;
            this.clearBrand.Text = "Clear";
            this.clearBrand.UseVisualStyleBackColor = true;
            this.clearBrand.Click += new System.EventHandler(this.clearBrand_Click);
            // 
            // deleteBrand
            // 
            this.deleteBrand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBrand.Location = new System.Drawing.Point(238, 139);
            this.deleteBrand.Name = "deleteBrand";
            this.deleteBrand.Size = new System.Drawing.Size(80, 32);
            this.deleteBrand.TabIndex = 4;
            this.deleteBrand.Text = "Delete";
            this.deleteBrand.UseVisualStyleBackColor = true;
            this.deleteBrand.Click += new System.EventHandler(this.deleteBrand_Click);
            // 
            // updateBrand
            // 
            this.updateBrand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBrand.Location = new System.Drawing.Point(142, 139);
            this.updateBrand.Name = "updateBrand";
            this.updateBrand.Size = new System.Drawing.Size(80, 32);
            this.updateBrand.TabIndex = 3;
            this.updateBrand.Text = "Update";
            this.updateBrand.UseVisualStyleBackColor = true;
            this.updateBrand.Click += new System.EventHandler(this.updateBrand_Click);
            // 
            // addBrand
            // 
            this.addBrand.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBrand.Location = new System.Drawing.Point(52, 139);
            this.addBrand.Name = "addBrand";
            this.addBrand.Size = new System.Drawing.Size(74, 32);
            this.addBrand.TabIndex = 2;
            this.addBrand.Text = "Add";
            this.addBrand.UseVisualStyleBackColor = true;
            this.addBrand.Click += new System.EventHandler(this.addBrand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand Name";
            // 
            // brandName
            // 
            this.brandName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandName.Location = new System.Drawing.Point(171, 91);
            this.brandName.MaxLength = 50;
            this.brandName.Name = "brandName";
            this.brandName.Size = new System.Drawing.Size(200, 31);
            this.brandName.TabIndex = 0;
            // 
            // Add_BandC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Name = "Add_BandC";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Add_BandC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox categorySearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView categoryDataView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearCategory;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Button updateCategory;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox brandSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView brandDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearBrand;
        private System.Windows.Forms.Button deleteBrand;
        private System.Windows.Forms.Button updateBrand;
        private System.Windows.Forms.Button addBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brandName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox categoryId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox brandId;
        private System.Windows.Forms.Button categoryTableReset;
        private System.Windows.Forms.Button brandTableReset;
    }
}
