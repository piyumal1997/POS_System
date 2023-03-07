namespace PosSystem
{
    partial class Search_Items
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
            this.searchDataViwer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minPrice = new System.Windows.Forms.MaskedTextBox();
            this.maxPrice = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.catSearchCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.branSearchCombo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.resetItemTable = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataViwer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchDataViwer
            // 
            this.searchDataViwer.AllowUserToAddRows = false;
            this.searchDataViwer.AllowUserToDeleteRows = false;
            this.searchDataViwer.AllowUserToResizeRows = false;
            this.searchDataViwer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataViwer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataViwer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.searchDataViwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataViwer.DefaultCellStyle = dataGridViewCellStyle6;
            this.searchDataViwer.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataViwer.Location = new System.Drawing.Point(37, 202);
            this.searchDataViwer.MultiSelect = false;
            this.searchDataViwer.Name = "searchDataViwer";
            this.searchDataViwer.ReadOnly = true;
            this.searchDataViwer.RowHeadersVisible = false;
            this.searchDataViwer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataViwer.Size = new System.Drawing.Size(905, 367);
            this.searchDataViwer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.minPrice);
            this.groupBox2.Controls.Add(this.maxPrice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.resetItemTable);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.catSearchCombo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.branSearchCombo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 150);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // minPrice
            // 
            this.minPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPrice.Location = new System.Drawing.Point(171, 38);
            this.minPrice.Mask = "00000";
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(181, 31);
            this.minPrice.TabIndex = 26;
            this.minPrice.TextChanged += new System.EventHandler(this.minPrice_TextChanged);
            // 
            // maxPrice
            // 
            this.maxPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPrice.Location = new System.Drawing.Point(452, 38);
            this.maxPrice.Mask = "00000";
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(181, 31);
            this.maxPrice.TabIndex = 25;
            this.maxPrice.TextChanged += new System.EventHandler(this.maxPrice_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Prices Range";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(365, 93);
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
            this.catSearchCombo.Location = new System.Drawing.Point(452, 90);
            this.catSearchCombo.Name = "catSearchCombo";
            this.catSearchCombo.Size = new System.Drawing.Size(181, 31);
            this.catSearchCombo.TabIndex = 2;
            this.catSearchCombo.SelectedValueChanged += new System.EventHandler(this.catSearchCombo_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 93);
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
            this.branSearchCombo.Location = new System.Drawing.Point(171, 90);
            this.branSearchCombo.Name = "branSearchCombo";
            this.branSearchCombo.Size = new System.Drawing.Size(181, 31);
            this.branSearchCombo.TabIndex = 1;
            this.branSearchCombo.SelectedValueChanged += new System.EventHandler(this.branSearchCombo_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(388, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "To";
            // 
            // resetItemTable
            // 
            this.resetItemTable.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetItemTable.Location = new System.Drawing.Point(682, 45);
            this.resetItemTable.Name = "resetItemTable";
            this.resetItemTable.Size = new System.Drawing.Size(127, 64);
            this.resetItemTable.TabIndex = 3;
            this.resetItemTable.Text = "Reset Item Table";
            this.resetItemTable.UseVisualStyleBackColor = true;
            this.resetItemTable.Click += new System.EventHandler(this.resetItemTable_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Location = new System.Drawing.Point(932, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 5;
            this.close.Text = "✖";
            this.close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Search_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchDataViwer);
            this.MaximizeBox = false;
            this.Name = "Search_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Search_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataViwer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView searchDataViwer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox minPrice;
        private System.Windows.Forms.MaskedTextBox maxPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox catSearchCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox branSearchCombo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button resetItemTable;
        private System.Windows.Forms.Button close;
    }
}