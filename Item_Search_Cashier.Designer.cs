namespace PosSystem
{
    partial class Item_Search_Cashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.branSearchCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.catSearchCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.resetItemTable = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.MaskedTextBox();
            this.minPrice = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchDataViwer = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataViwer)).BeginInit();
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
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Search";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(440, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "To";
            // 
            // branSearchCombo
            // 
            this.branSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branSearchCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branSearchCombo.FormattingEnabled = true;
            this.branSearchCombo.Location = new System.Drawing.Point(223, 87);
            this.branSearchCombo.Name = "branSearchCombo";
            this.branSearchCombo.Size = new System.Drawing.Size(181, 31);
            this.branSearchCombo.TabIndex = 1;
            this.branSearchCombo.SelectedValueChanged += new System.EventHandler(this.branSearchCombo_SelectedValueChanged);
            this.branSearchCombo.TextChanged += new System.EventHandler(this.branSearchCombo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(106, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Brand";
            // 
            // catSearchCombo
            // 
            this.catSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catSearchCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catSearchCombo.FormattingEnabled = true;
            this.catSearchCombo.Location = new System.Drawing.Point(504, 87);
            this.catSearchCombo.Name = "catSearchCombo";
            this.catSearchCombo.Size = new System.Drawing.Size(181, 31);
            this.catSearchCombo.TabIndex = 2;
            this.catSearchCombo.SelectedValueChanged += new System.EventHandler(this.catSearchCombo_SelectedValueChanged);
            this.catSearchCombo.TextChanged += new System.EventHandler(this.catSearchCombo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(417, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "Category";
            // 
            // resetItemTable
            // 
            this.resetItemTable.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetItemTable.Location = new System.Drawing.Point(775, 44);
            this.resetItemTable.Name = "resetItemTable";
            this.resetItemTable.Size = new System.Drawing.Size(127, 64);
            this.resetItemTable.TabIndex = 3;
            this.resetItemTable.Text = "Reset Item Table";
            this.resetItemTable.UseVisualStyleBackColor = true;
            this.resetItemTable.Click += new System.EventHandler(this.resetItemTable_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(106, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 23);
            this.label16.TabIndex = 20;
            this.label16.Text = "Prices Range";
            // 
            // maxPrice
            // 
            this.maxPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPrice.Location = new System.Drawing.Point(504, 35);
            this.maxPrice.Mask = "00000";
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(181, 31);
            this.maxPrice.TabIndex = 25;
            this.maxPrice.TextChanged += new System.EventHandler(this.maxPrice_TextChanged);
            // 
            // minPrice
            // 
            this.minPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPrice.Location = new System.Drawing.Point(223, 35);
            this.minPrice.Mask = "00000";
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(181, 31);
            this.minPrice.TabIndex = 26;
            this.minPrice.TextChanged += new System.EventHandler(this.minPrice_TextChanged);
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
            this.groupBox2.Location = new System.Drawing.Point(94, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 150);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // searchDataViwer
            // 
            this.searchDataViwer.AllowUserToAddRows = false;
            this.searchDataViwer.AllowUserToDeleteRows = false;
            this.searchDataViwer.AllowUserToResizeRows = false;
            this.searchDataViwer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchDataViwer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDataViwer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.searchDataViwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDataViwer.DefaultCellStyle = dataGridViewCellStyle18;
            this.searchDataViwer.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataViwer.Location = new System.Drawing.Point(94, 242);
            this.searchDataViwer.MultiSelect = false;
            this.searchDataViwer.Name = "searchDataViwer";
            this.searchDataViwer.ReadOnly = true;
            this.searchDataViwer.RowHeadersVisible = false;
            this.searchDataViwer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataViwer.Size = new System.Drawing.Size(959, 367);
            this.searchDataViwer.TabIndex = 16;
            // 
            // Item_Search_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchDataViwer);
            this.Controls.Add(this.panel1);
            this.Name = "Item_Search_Cashier";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Item_Search_Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataViwer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox branSearchCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox catSearchCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button resetItemTable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox maxPrice;
        private System.Windows.Forms.MaskedTextBox minPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView searchDataViwer;
    }
}
