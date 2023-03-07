namespace PosSystem
{
    partial class Return_Pros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.MaskedTextBox();
            this.billNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todaySalesView = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.SoldPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.returnTempView = new System.Windows.Forms.DataGridView();
            this.addReturn = new System.Windows.Forms.Button();
            this.removeReturn = new System.Windows.Forms.Button();
            this.returnItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editReturn = new System.Windows.Forms.Button();
            this.billNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.returnBill = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTempView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.itemNumber);
            this.groupBox1.Controls.Add(this.billNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 76);
            this.groupBox1.TabIndex = 31;
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
            // billNumber
            // 
            this.billNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumber.Location = new System.Drawing.Point(120, 23);
            this.billNumber.Mask = "0000000000";
            this.billNumber.Name = "billNumber";
            this.billNumber.PromptChar = ' ';
            this.billNumber.Size = new System.Drawing.Size(145, 31);
            this.billNumber.TabIndex = 17;
            this.billNumber.TextChanged += new System.EventHandler(this.billNumber_TextChanged);
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
            this.todaySalesView.Location = new System.Drawing.Point(21, 104);
            this.todaySalesView.MultiSelect = false;
            this.todaySalesView.Name = "todaySalesView";
            this.todaySalesView.ReadOnly = true;
            this.todaySalesView.RowHeadersVisible = false;
            this.todaySalesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todaySalesView.Size = new System.Drawing.Size(704, 250);
            this.todaySalesView.TabIndex = 30;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(867, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 29;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SoldPrice
            // 
            this.SoldPrice.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldPrice.Location = new System.Drawing.Point(756, 258);
            this.SoldPrice.Name = "SoldPrice";
            this.SoldPrice.ReadOnly = true;
            this.SoldPrice.Size = new System.Drawing.Size(144, 40);
            this.SoldPrice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sold Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemId
            // 
            this.ItemId.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemId.Location = new System.Drawing.Point(755, 123);
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Size = new System.Drawing.Size(144, 40);
            this.ItemId.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(768, 97);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 23);
            this.label.TabIndex = 33;
            this.label.Text = "Item Number";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnTempView
            // 
            this.returnTempView.AllowUserToAddRows = false;
            this.returnTempView.AllowUserToDeleteRows = false;
            this.returnTempView.AllowUserToResizeRows = false;
            this.returnTempView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnTempView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnTempView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.returnTempView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnTempView.DefaultCellStyle = dataGridViewCellStyle4;
            this.returnTempView.Location = new System.Drawing.Point(21, 422);
            this.returnTempView.MultiSelect = false;
            this.returnTempView.Name = "returnTempView";
            this.returnTempView.ReadOnly = true;
            this.returnTempView.RowHeadersVisible = false;
            this.returnTempView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnTempView.Size = new System.Drawing.Size(704, 235);
            this.returnTempView.TabIndex = 38;
            // 
            // addReturn
            // 
            this.addReturn.BackColor = System.Drawing.Color.SeaGreen;
            this.addReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addReturn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addReturn.Location = new System.Drawing.Point(755, 310);
            this.addReturn.Name = "addReturn";
            this.addReturn.Size = new System.Drawing.Size(144, 43);
            this.addReturn.TabIndex = 39;
            this.addReturn.Text = "Add Item";
            this.addReturn.UseVisualStyleBackColor = false;
            this.addReturn.Click += new System.EventHandler(this.addReturn_Click);
            // 
            // removeReturn
            // 
            this.removeReturn.BackColor = System.Drawing.Color.DarkRed;
            this.removeReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeReturn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeReturn.Location = new System.Drawing.Point(755, 613);
            this.removeReturn.Name = "removeReturn";
            this.removeReturn.Size = new System.Drawing.Size(144, 43);
            this.removeReturn.TabIndex = 40;
            this.removeReturn.Text = "Remove";
            this.removeReturn.UseVisualStyleBackColor = false;
            // 
            // returnItem
            // 
            this.returnItem.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnItem.Location = new System.Drawing.Point(755, 444);
            this.returnItem.Name = "returnItem";
            this.returnItem.ReadOnly = true;
            this.returnItem.Size = new System.Drawing.Size(144, 40);
            this.returnItem.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(767, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Item Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Return Items";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editReturn
            // 
            this.editReturn.BackColor = System.Drawing.Color.SeaGreen;
            this.editReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editReturn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editReturn.Location = new System.Drawing.Point(755, 564);
            this.editReturn.Name = "editReturn";
            this.editReturn.Size = new System.Drawing.Size(144, 43);
            this.editReturn.TabIndex = 44;
            this.editReturn.Text = "Edit Item";
            this.editReturn.UseVisualStyleBackColor = false;
            this.editReturn.Click += new System.EventHandler(this.editReturn_Click);
            // 
            // billNum
            // 
            this.billNum.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNum.Location = new System.Drawing.Point(756, 191);
            this.billNum.Name = "billNum";
            this.billNum.ReadOnly = true;
            this.billNum.Size = new System.Drawing.Size(144, 40);
            this.billNum.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(779, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Bill Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnBill
            // 
            this.returnBill.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBill.Location = new System.Drawing.Point(756, 513);
            this.returnBill.Name = "returnBill";
            this.returnBill.ReadOnly = true;
            this.returnBill.Size = new System.Drawing.Size(144, 40);
            this.returnBill.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Bill Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return_Pros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 679);
            this.ControlBox = false;
            this.Controls.Add(this.returnBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.billNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.returnItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeReturn);
            this.Controls.Add(this.addReturn);
            this.Controls.Add(this.returnTempView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.todaySalesView);
            this.Controls.Add(this.close);
            this.Controls.Add(this.SoldPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.label);
            this.Name = "Return_Pros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.Return_Pros_Activated);
            this.Load += new System.EventHandler(this.Return_Pros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTempView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MaskedTextBox itemNumber;
        private System.Windows.Forms.MaskedTextBox billNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView todaySalesView;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox SoldPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView returnTempView;
        private System.Windows.Forms.Button addReturn;
        private System.Windows.Forms.Button removeReturn;
        private System.Windows.Forms.TextBox returnItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editReturn;
        private System.Windows.Forms.TextBox billNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox returnBill;
        private System.Windows.Forms.Label label7;
    }
}