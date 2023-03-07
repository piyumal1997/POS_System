namespace PosSystem
{
    partial class Discount
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AvailableDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDiscount = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.Location = new System.Drawing.Point(451, 20);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.close.Size = new System.Drawing.Size(40, 40);
            this.close.TabIndex = 8;
            this.close.Text = "✖";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AvailableDiscount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addDiscount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(41, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 183);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // AvailableDiscount
            // 
            this.AvailableDiscount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDiscount.Location = new System.Drawing.Point(182, 26);
            this.AvailableDiscount.Name = "AvailableDiscount";
            this.AvailableDiscount.ReadOnly = true;
            this.AvailableDiscount.Size = new System.Drawing.Size(100, 33);
            this.AvailableDiscount.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Per Item\r\nDiscount";
            // 
            // addDiscount
            // 
            this.addDiscount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addDiscount.HidePromptOnLeave = true;
            this.addDiscount.Location = new System.Drawing.Point(143, 93);
            this.addDiscount.Mask = "00000";
            this.addDiscount.Name = "addDiscount";
            this.addDiscount.PromptChar = ' ';
            this.addDiscount.Size = new System.Drawing.Size(140, 66);
            this.addDiscount.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max Discount";
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(145, 31);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(148, 33);
            this.code.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Item Code";
            // 
            // action
            // 
            this.action.BackColor = System.Drawing.Color.SeaGreen;
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.action.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.action.Location = new System.Drawing.Point(381, 201);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(110, 62);
            this.action.TabIndex = 18;
            this.action.Text = "Button";
            this.action.UseVisualStyleBackColor = false;
            this.action.Click += new System.EventHandler(this.action_Click);
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 301);
            this.ControlBox = false;
            this.Controls.Add(this.action);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.close);
            this.Name = "Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Discount_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AvailableDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox addDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button action;
    }
}