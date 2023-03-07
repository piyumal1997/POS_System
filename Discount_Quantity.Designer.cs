namespace PosSystem
{
    partial class Discount_Quantity
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
            this.text = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.MaskedTextBox();
            this.discount = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvailableQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AvailableDiscount = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.action = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BillAvailableD = new System.Windows.Forms.TextBox();
            this.BillAvailableQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(227, 66);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 29);
            this.text.TabIndex = 0;
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantity.HidePromptOnLeave = true;
            this.quantity.Location = new System.Drawing.Point(138, 107);
            this.quantity.Mask = "00000";
            this.quantity.Name = "quantity";
            this.quantity.PromptChar = ' ';
            this.quantity.Size = new System.Drawing.Size(140, 66);
            this.quantity.TabIndex = 1;
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.discount.HidePromptOnLeave = true;
            this.discount.Location = new System.Drawing.Point(143, 107);
            this.discount.Mask = "00000";
            this.discount.Name = "discount";
            this.discount.PromptChar = ' ';
            this.discount.Size = new System.Drawing.Size(140, 66);
            this.discount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Code";
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.Color.Indigo;
            this.code.Location = new System.Drawing.Point(148, 26);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(150, 33);
            this.code.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Per Item\r\nDiscount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory \r\nAvailable Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Discount";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailableQuantity);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantity.Location = new System.Drawing.Point(183, 33);
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            this.AvailableQuantity.Size = new System.Drawing.Size(100, 33);
            this.AvailableQuantity.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AvailableDiscount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.discount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(343, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 194);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // AvailableDiscount
            // 
            this.AvailableDiscount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDiscount.Location = new System.Drawing.Point(185, 33);
            this.AvailableDiscount.Name = "AvailableDiscount";
            this.AvailableDiscount.ReadOnly = true;
            this.AvailableDiscount.Size = new System.Drawing.Size(100, 33);
            this.AvailableDiscount.TabIndex = 12;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(610, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 11;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // action
            // 
            this.action.BackColor = System.Drawing.Color.SeaGreen;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.action.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.action.Location = new System.Drawing.Point(538, 425);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(110, 60);
            this.action.TabIndex = 17;
            this.action.Text = "Button";
            this.action.UseVisualStyleBackColor = false;
            this.action.Click += new System.EventHandler(this.addToBill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BillAvailableD);
            this.groupBox3.Controls.Add(this.BillAvailableQ);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(21, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 112);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bill Available Details";
            // 
            // BillAvailableD
            // 
            this.BillAvailableD.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillAvailableD.Location = new System.Drawing.Point(441, 55);
            this.BillAvailableD.Name = "BillAvailableD";
            this.BillAvailableD.ReadOnly = true;
            this.BillAvailableD.Size = new System.Drawing.Size(125, 33);
            this.BillAvailableD.TabIndex = 12;
            // 
            // BillAvailableQ
            // 
            this.BillAvailableQ.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillAvailableQ.Location = new System.Drawing.Point(162, 56);
            this.BillAvailableQ.Name = "BillAvailableQ";
            this.BillAvailableQ.ReadOnly = true;
            this.BillAvailableQ.Size = new System.Drawing.Size(125, 33);
            this.BillAvailableQ.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity";
            // 
            // Discount_Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 504);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.action);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 520);
            this.MinimumSize = new System.Drawing.Size(687, 520);
            this.Name = "Discount_Quantity";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Discount_Quantity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.MaskedTextBox quantity;
        private System.Windows.Forms.MaskedTextBox discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AvailableQuantity;
        private System.Windows.Forms.TextBox AvailableDiscount;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BillAvailableD;
        private System.Windows.Forms.TextBox BillAvailableQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}