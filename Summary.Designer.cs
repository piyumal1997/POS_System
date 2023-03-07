namespace PosSystem
{
    partial class Summary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.billsDataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TotalItems = new System.Windows.Forms.Label();
            this.OneCount = new System.Windows.Forms.Label();
            this.ZeroCount = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.billNumber = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.head.Controls.Add(this.label1);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1156, 60);
            this.head.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summary";
            // 
            // billsDataView
            // 
            this.billsDataView.AllowUserToAddRows = false;
            this.billsDataView.AllowUserToDeleteRows = false;
            this.billsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billsDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.billsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billsDataView.DefaultCellStyle = dataGridViewCellStyle10;
            this.billsDataView.Location = new System.Drawing.Point(38, 168);
            this.billsDataView.Name = "billsDataView";
            this.billsDataView.ReadOnly = true;
            this.billsDataView.RowHeadersVisible = false;
            this.billsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billsDataView.Size = new System.Drawing.Size(816, 428);
            this.billsDataView.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.ZeroCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(902, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 95);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.OneCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(902, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 95);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.TotalItems);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(902, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 95);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item in Zero Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item in One Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Items Sales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Bill Proceed";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.TotalBill);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(902, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 95);
            this.panel4.TabIndex = 7;
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSize = true;
            this.TotalItems.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.Location = new System.Drawing.Point(31, 35);
            this.TotalItems.MaximumSize = new System.Drawing.Size(169, 59);
            this.TotalItems.MinimumSize = new System.Drawing.Size(169, 59);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(169, 59);
            this.TotalItems.TabIndex = 8;
            this.TotalItems.Text = "0";
            this.TotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneCount
            // 
            this.OneCount.AutoSize = true;
            this.OneCount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneCount.Location = new System.Drawing.Point(28, 34);
            this.OneCount.MaximumSize = new System.Drawing.Size(169, 59);
            this.OneCount.MinimumSize = new System.Drawing.Size(169, 59);
            this.OneCount.Name = "OneCount";
            this.OneCount.Size = new System.Drawing.Size(169, 59);
            this.OneCount.TabIndex = 9;
            this.OneCount.Text = "0";
            this.OneCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZeroCount
            // 
            this.ZeroCount.AutoSize = true;
            this.ZeroCount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroCount.Location = new System.Drawing.Point(28, 33);
            this.ZeroCount.MaximumSize = new System.Drawing.Size(169, 59);
            this.ZeroCount.MinimumSize = new System.Drawing.Size(169, 59);
            this.ZeroCount.Name = "ZeroCount";
            this.ZeroCount.Size = new System.Drawing.Size(169, 59);
            this.ZeroCount.TabIndex = 10;
            this.ZeroCount.Text = "0";
            this.ZeroCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBill.Location = new System.Drawing.Point(28, 35);
            this.TotalBill.MaximumSize = new System.Drawing.Size(169, 59);
            this.TotalBill.MinimumSize = new System.Drawing.Size(169, 59);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(169, 59);
            this.TotalBill.TabIndex = 10;
            this.TotalBill.Text = "0";
            this.TotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.billNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(227, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 77);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(359, 22);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 21;
            this.clear.Text = "Reset";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // billNumber
            // 
            this.billNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billNumber.Location = new System.Drawing.Point(120, 23);
            this.billNumber.Mask = "0000000000";
            this.billNumber.Name = "billNumber";
            this.billNumber.PromptChar = ' ';
            this.billNumber.Size = new System.Drawing.Size(165, 31);
            this.billNumber.TabIndex = 17;
            this.billNumber.TextChanged += new System.EventHandler(this.billNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bill Number";
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.billsDataView);
            this.Controls.Add(this.head);
            this.Name = "Summary";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Summary_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView billsDataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ZeroCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label OneCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MaskedTextBox billNumber;
        private System.Windows.Forms.Label label7;
    }
}
