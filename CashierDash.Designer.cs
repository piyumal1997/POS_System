namespace PosSystem
{
    partial class CashierDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Button();
            this.pos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchItem = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 84);
            this.panel1.TabIndex = 3;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOut.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.Location = new System.Drawing.Point(1223, 11);
            this.logOut.Name = "logOut";
            this.logOut.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.logOut.Size = new System.Drawing.Size(137, 64);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "LogOut";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Style NewAge BFO";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.MidnightBlue;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(929, 11);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(180, 64);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pos
            // 
            this.pos.BackColor = System.Drawing.Color.MidnightBlue;
            this.pos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pos.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pos.Image = ((System.Drawing.Image)(resources.GetObject("pos.Image")));
            this.pos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pos.Location = new System.Drawing.Point(1115, 11);
            this.pos.Name = "pos";
            this.pos.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pos.Size = new System.Drawing.Size(102, 64);
            this.pos.TabIndex = 2;
            this.pos.Text = "POS";
            this.pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pos.UseVisualStyleBackColor = false;
            this.pos.Click += new System.EventHandler(this.pos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1156, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 632);
            this.panel2.TabIndex = 4;
            // 
            // SearchItem
            // 
            this.SearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchItem.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchItem.Image")));
            this.SearchItem.Location = new System.Drawing.Point(5, 6);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SearchItem.Size = new System.Drawing.Size(200, 81);
            this.SearchItem.TabIndex = 2;
            this.SearchItem.Text = "Items Search";
            this.SearchItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SearchItem.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 84);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1156, 632);
            this.panelContainer.TabIndex = 5;
            // 
            // CashierDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 716);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1382, 755);
            this.MinimumSize = new System.Drawing.Size(1364, 708);
            this.Name = "CashierDash";
            this.Text = "CashierDash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button pos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchItem;
        private System.Windows.Forms.Panel panelContainer;
    }
}