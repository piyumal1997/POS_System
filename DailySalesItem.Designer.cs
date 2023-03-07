namespace PosSystem
{
    partial class DailySalesItem
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
            this.close = new System.Windows.Forms.Button();
            this.todaySalesView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.itemNumber = new System.Windows.Forms.MaskedTextBox();
            this.billNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.todaySales = new System.Windows.Forms.TextBox();
            this.todaySellsQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(866, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 7;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.todaySalesView.Location = new System.Drawing.Point(25, 123);
            this.todaySalesView.MultiSelect = false;
            this.todaySalesView.Name = "todaySalesView";
            this.todaySalesView.ReadOnly = true;
            this.todaySalesView.RowHeadersVisible = false;
            this.todaySalesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todaySalesView.Size = new System.Drawing.Size(696, 435);
            this.todaySalesView.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.itemNumber);
            this.groupBox1.Controls.Add(this.billNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(588, 23);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "Today Sales\r\nTotal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todaySales
            // 
            this.todaySales.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaySales.Location = new System.Drawing.Point(753, 178);
            this.todaySales.Name = "todaySales";
            this.todaySales.ReadOnly = true;
            this.todaySales.Size = new System.Drawing.Size(144, 40);
            this.todaySales.TabIndex = 17;
            this.todaySales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // todaySellsQuantity
            // 
            this.todaySellsQuantity.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaySellsQuantity.Location = new System.Drawing.Point(753, 289);
            this.todaySellsQuantity.Name = "todaySellsQuantity";
            this.todaySellsQuantity.ReadOnly = true;
            this.todaySellsQuantity.Size = new System.Drawing.Size(144, 40);
            this.todaySellsQuantity.TabIndex = 18;
            this.todaySellsQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "Today Sells\r\nQuantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DailySalesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 584);
            this.ControlBox = false;
            this.Controls.Add(this.todaySellsQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.todaySales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.todaySalesView);
            this.Controls.Add(this.close);
            this.Name = "DailySalesItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DailySalesItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todaySalesView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView todaySalesView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox todaySales;
        private System.Windows.Forms.TextBox todaySellsQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox billNumber;
        private System.Windows.Forms.MaskedTextBox itemNumber;
        private System.Windows.Forms.Button clear;
    }
}