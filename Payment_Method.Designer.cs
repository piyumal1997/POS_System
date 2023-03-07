namespace PosSystem
{
    partial class Payment_Method
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
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.BillNum = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(437, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 7;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment Method";
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.DarkGreen;
            this.card.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.card.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.card.Location = new System.Drawing.Point(79, 209);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(148, 87);
            this.card.TabIndex = 9;
            this.card.Text = "Card";
            this.card.UseVisualStyleBackColor = false;
            // 
            // cash
            // 
            this.cash.BackColor = System.Drawing.Color.DarkGreen;
            this.cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cash.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cash.Location = new System.Drawing.Point(279, 209);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(148, 87);
            this.cash.TabIndex = 10;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = false;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // BillNum
            // 
            this.BillNum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNum.Location = new System.Drawing.Point(230, 95);
            this.BillNum.Name = "BillNum";
            this.BillNum.ReadOnly = true;
            this.BillNum.Size = new System.Drawing.Size(175, 33);
            this.BillNum.TabIndex = 11;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(230, 148);
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Size = new System.Drawing.Size(175, 33);
            this.Amount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bill Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // Payment_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 319);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.BillNum);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.MaximumSize = new System.Drawing.Size(505, 335);
            this.MinimumSize = new System.Drawing.Size(505, 335);
            this.Name = "Payment_Method";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Payment_Method_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.TextBox BillNum;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}