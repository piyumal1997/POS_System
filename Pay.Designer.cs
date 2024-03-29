﻿namespace PosSystem
{
    partial class Pay
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.BillNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessBill = new System.Windows.Forms.Button();
            this.CashReceived = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(464, 12);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 12;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bill Number";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(247, 141);
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Size = new System.Drawing.Size(180, 33);
            this.Amount.TabIndex = 16;
            // 
            // BillNum
            // 
            this.BillNum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNum.Location = new System.Drawing.Point(247, 93);
            this.BillNum.Name = "BillNum";
            this.BillNum.ReadOnly = true;
            this.BillNum.Size = new System.Drawing.Size(180, 33);
            this.BillNum.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(93, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cash Given";
            // 
            // ProcessBill
            // 
            this.ProcessBill.BackColor = System.Drawing.Color.DarkGreen;
            this.ProcessBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProcessBill.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProcessBill.Location = new System.Drawing.Point(142, 292);
            this.ProcessBill.Name = "ProcessBill";
            this.ProcessBill.Size = new System.Drawing.Size(239, 89);
            this.ProcessBill.TabIndex = 22;
            this.ProcessBill.Text = "Proceed Bill";
            this.ProcessBill.UseVisualStyleBackColor = false;
            this.ProcessBill.Click += new System.EventHandler(this.ProcessBill_Click);
            // 
            // CashReceived
            // 
            this.CashReceived.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashReceived.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CashReceived.HidePromptOnLeave = true;
            this.CashReceived.Location = new System.Drawing.Point(247, 205);
            this.CashReceived.Mask = "000000";
            this.CashReceived.Name = "CashReceived";
            this.CashReceived.PromptChar = ' ';
            this.CashReceived.Size = new System.Drawing.Size(180, 50);
            this.CashReceived.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Payment and Proccess";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashReceived);
            this.Controls.Add(this.ProcessBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.BillNum);
            this.Controls.Add(this.close);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox BillNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ProcessBill;
        private System.Windows.Forms.MaskedTextBox CashReceived;
        private System.Windows.Forms.Label label1;
    }
}