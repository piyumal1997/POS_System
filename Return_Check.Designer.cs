namespace PosSystem
{
    partial class Return_Check
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.MaskedTextBox();
            this.BillNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todaySalesView = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SoldPrice = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.itemNumber);
            this.groupBox1.Controls.Add(this.BillNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 76);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(595, 23);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 21;
            this.clear.Text = "Reset";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // itemNumber
            // 
            this.itemNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumber.Location = new System.Drawing.Point(411, 23);
            this.itemNumber.Mask = "0000000000";
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.PromptChar = ' ';
            this.itemNumber.Size = new System.Drawing.Size(145, 31);
            this.itemNumber.TabIndex = 20;
            this.itemNumber.TextChanged += new System.EventHandler(this.itemNumber_TextChanged);
            // 
            // BillNumber
            // 
            this.BillNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumber.Location = new System.Drawing.Point(120, 23);
            this.BillNumber.Mask = "0000000000";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.PromptChar = ' ';
            this.BillNumber.Size = new System.Drawing.Size(145, 31);
            this.BillNumber.TabIndex = 17;
            this.BillNumber.TextChanged += new System.EventHandler(this.billNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Item Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bill Number";
            // 
            // todaySalesView
            // 
            this.todaySalesView.AllowUserToAddRows = false;
            this.todaySalesView.AllowUserToDeleteRows = false;
            this.todaySalesView.AllowUserToResizeRows = false;
            this.todaySalesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todaySalesView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.todaySalesView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todaySalesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.todaySalesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todaySalesView.DefaultCellStyle = dataGridViewCellStyle2;
            this.todaySalesView.Location = new System.Drawing.Point(23, 130);
            this.todaySalesView.MultiSelect = false;
            this.todaySalesView.Name = "todaySalesView";
            this.todaySalesView.ReadOnly = true;
            this.todaySalesView.RowHeadersVisible = false;
            this.todaySalesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todaySalesView.Size = new System.Drawing.Size(704, 435);
            this.todaySalesView.TabIndex = 21;
            this.todaySalesView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todaySalesView_CellClick);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(864, 19);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 20;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(771, 157);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 23);
            this.label.TabIndex = 24;
            this.label.Text = "Item Number";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemId
            // 
            this.ItemId.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemId.Location = new System.Drawing.Point(759, 183);
            this.ItemId.MaxLength = 20;
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Size = new System.Drawing.Size(144, 40);
            this.ItemId.TabIndex = 23;
            this.ItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(785, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sold Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoldPrice
            // 
            this.SoldPrice.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldPrice.Location = new System.Drawing.Point(759, 271);
            this.SoldPrice.MaxLength = 20;
            this.SoldPrice.Name = "SoldPrice";
            this.SoldPrice.ReadOnly = true;
            this.SoldPrice.Size = new System.Drawing.Size(144, 40);
            this.SoldPrice.TabIndex = 25;
            this.SoldPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(734, 404);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(192, 23);
            this.dateTime.TabIndex = 27;
            this.dateTime.Text = "yyyy-MM-dd hh:mm:ss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 46);
            this.label3.TabIndex = 28;
            this.label3.Text = "Reurning Lasting \r\nDate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 584);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.todaySalesView);
            this.Controls.Add(this.close);
            this.Controls.Add(this.SoldPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(942, 600);
            this.MinimumSize = new System.Drawing.Size(942, 600);
            this.Name = "Return_Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Return_Check_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MaskedTextBox itemNumber;
        private System.Windows.Forms.MaskedTextBox BillNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView todaySalesView;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SoldPrice;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Label label3;
    }
}