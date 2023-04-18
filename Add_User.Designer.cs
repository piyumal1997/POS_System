using System.Drawing;

namespace PosSystem
{
    partial class Add_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateSet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.imgUpload = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.MaskedTextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.gender = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imagePreviwer = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.re_password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.nic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDataView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviwer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.head.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add User";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dateSet);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.UpdateEmployee);
            this.groupBox1.Controls.Add(this.addEmployee);
            this.groupBox1.Controls.Add(this.imgUpload);
            this.groupBox1.Controls.Add(this.contact);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.imagePreviwer);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.role);
            this.groupBox1.Controls.Add(this.re_password);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.fullName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.nic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(582, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 551);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dateSet
            // 
            this.dateSet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSet.Location = new System.Drawing.Point(385, 454);
            this.dateSet.Name = "dateSet";
            this.dateSet.ReadOnly = true;
            this.dateSet.Size = new System.Drawing.Size(158, 31);
            this.dateSet.TabIndex = 37;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.userId);
            this.groupBox3.Location = new System.Drawing.Point(376, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 83);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 23);
            this.label16.TabIndex = 35;
            this.label16.Text = "Emplyee Id";
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(8, 42);
            this.userId.MaxLength = 12;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Size = new System.Drawing.Size(160, 31);
            this.userId.TabIndex = 34;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(300, 501);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 33;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEmployee.Location = new System.Drawing.Point(198, 501);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(82, 36);
            this.UpdateEmployee.TabIndex = 31;
            this.UpdateEmployee.Text = "Update";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.Location = new System.Drawing.Point(96, 501);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(80, 36);
            this.addEmployee.TabIndex = 30;
            this.addEmployee.Text = "Add";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // imgUpload
            // 
            this.imgUpload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgUpload.Location = new System.Drawing.Point(438, 284);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(105, 33);
            this.imgUpload.TabIndex = 29;
            this.imgUpload.Text = "Upload Image";
            this.imgUpload.UseVisualStyleBackColor = true;
            this.imgUpload.Click += new System.EventHandler(this.imgUpload_Click);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(155, 267);
            this.contact.Mask = "0000000000";
            this.contact.Name = "contact";
            this.contact.PromptChar = ' ';
            this.contact.Size = new System.Drawing.Size(200, 31);
            this.contact.TabIndex = 28;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(155, 165);
            this.address.MaxLength = 250;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 96);
            this.address.TabIndex = 27;
            this.address.Text = "";
            // 
            // gender
            // 
            this.gender.Controls.Add(this.female);
            this.gender.Controls.Add(this.male);
            this.gender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(383, 335);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(160, 106);
            this.gender.TabIndex = 26;
            this.gender.TabStop = false;
            this.gender.Text = "Gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(41, 59);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(83, 27);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(41, 30);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(66, 27);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(379, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "Image";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Re-type Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Full Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last Name";
            // 
            // imagePreviwer
            // 
            this.imagePreviwer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagePreviwer.Location = new System.Drawing.Point(383, 99);
            this.imagePreviwer.Name = "imagePreviwer";
            this.imagePreviwer.Size = new System.Drawing.Size(160, 176);
            this.imagePreviwer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePreviwer.TabIndex = 15;
            this.imagePreviwer.TabStop = false;
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Dissable"});
            this.status.Location = new System.Drawing.Point(155, 453);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(200, 31);
            this.status.TabIndex = 14;
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Owner",
            "Cashier"});
            this.role.Location = new System.Drawing.Point(155, 416);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(200, 31);
            this.role.TabIndex = 13;
            // 
            // re_password
            // 
            this.re_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_password.Location = new System.Drawing.Point(155, 378);
            this.re_password.MaxLength = 10;
            this.re_password.Name = "re_password";
            this.re_password.PasswordChar = '●';
            this.re_password.Size = new System.Drawing.Size(200, 31);
            this.re_password.TabIndex = 12;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(155, 341);
            this.password.MaxLength = 10;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(200, 31);
            this.password.TabIndex = 11;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(154, 304);
            this.username.MaxLength = 8;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(200, 31);
            this.username.TabIndex = 10;
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(155, 128);
            this.fullName.MaxLength = 150;
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(200, 31);
            this.fullName.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(155, 91);
            this.lastName.MaxLength = 25;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 31);
            this.lastName.TabIndex = 6;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(155, 54);
            this.firstName.MaxLength = 25;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 31);
            this.firstName.TabIndex = 5;
            // 
            // nic
            // 
            this.nic.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nic.Location = new System.Drawing.Point(155, 17);
            this.nic.MaxLength = 12;
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(200, 31);
            this.nic.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIC";
            // 
            // employeeDataView
            // 
            this.employeeDataView.AllowUserToDeleteRows = false;
            this.employeeDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employeeDataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.employeeDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeDataView.DefaultCellStyle = dataGridViewCellStyle6;
            this.employeeDataView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeDataView.Location = new System.Drawing.Point(26, 226);
            this.employeeDataView.MultiSelect = false;
            this.employeeDataView.Name = "employeeDataView";
            this.employeeDataView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 4, 4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.employeeDataView.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.employeeDataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.employeeDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataView.Size = new System.Drawing.Size(532, 381);
            this.employeeDataView.TabIndex = 7;
            this.employeeDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.searchCombo);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Box";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(334, 82);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(157, 36);
            this.reset.TabIndex = 31;
            this.reset.Text = "Reset Data Table";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Status";
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Active",
            "Dissable"});
            this.searchCombo.Location = new System.Drawing.Point(108, 86);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(180, 31);
            this.searchCombo.TabIndex = 15;
            this.searchCombo.TextChanged += new System.EventHandler(this.searchCombo_TextChanged);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(108, 32);
            this.search.MaxLength = 200;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 31);
            this.search.TabIndex = 2;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Text";
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeDataView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.head);
            this.Name = "Add_User";
            this.Size = new System.Drawing.Size(1156, 632);
            this.Load += new System.EventHandler(this.Add_User_Load);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviwer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imagePreviwer;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox re_password;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.MaskedTextBox contact;
        private System.Windows.Forms.Button imgUpload;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.DataGridView employeeDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox dateSet;
        private System.Windows.Forms.Button reset;
    }
}
