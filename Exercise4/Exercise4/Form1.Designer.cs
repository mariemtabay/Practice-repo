namespace Exercise4
{
    partial class OrderingSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.company_discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.company_contact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customer_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.individual_licence = new System.Windows.Forms.TextBox();
            this.selected_listview = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.product_listview = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_orderno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.company_discount);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.customer_id);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.company_contact);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.customer_phone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customer_address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.customer_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.individual_licence);
            this.panel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(17, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 274);
            this.panel1.TabIndex = 0;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.DarkRed;
            this.cancel_button.Location = new System.Drawing.Point(138, 240);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Visible = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.DarkRed;
            this.save.Location = new System.Drawing.Point(48, 240);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 18;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.saveCustomer);
            // 
            // company_discount
            // 
            this.company_discount.Enabled = false;
            this.company_discount.Location = new System.Drawing.Point(124, 205);
            this.company_discount.Name = "company_discount";
            this.company_discount.Size = new System.Drawing.Size(100, 20);
            this.company_discount.TabIndex = 6;
            this.company_discount.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Discount :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "Customer ID :";
            // 
            // customer_id
            // 
            this.customer_id.Enabled = false;
            this.customer_id.Location = new System.Drawing.Point(124, 177);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(100, 20);
            this.customer_id.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SlateGray;
            this.label11.Location = new System.Drawing.Point(112, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "For Company Customers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SlateGray;
            this.label10.Location = new System.Drawing.Point(112, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "For Individual Customers";
            // 
            // company_contact
            // 
            this.company_contact.Location = new System.Drawing.Point(124, 55);
            this.company_contact.Name = "company_contact";
            this.company_contact.Size = new System.Drawing.Size(100, 20);
            this.company_contact.TabIndex = 1;
            this.company_contact.Tag = "";
            this.company_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchCompanyContact);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contact Person:";
            // 
            // customer_phone
            // 
            this.customer_phone.Enabled = false;
            this.customer_phone.Location = new System.Drawing.Point(124, 151);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(100, 20);
            this.customer_phone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone # : ";
            // 
            // customer_address
            // 
            this.customer_address.Enabled = false;
            this.customer_address.Location = new System.Drawing.Point(124, 125);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(100, 20);
            this.customer_address.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name : ";
            // 
            // customer_name
            // 
            this.customer_name.Enabled = false;
            this.customer_name.Location = new System.Drawing.Point(124, 98);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(100, 20);
            this.customer_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Licence # : ";
            // 
            // individual_licence
            // 
            this.individual_licence.Location = new System.Drawing.Point(124, 11);
            this.individual_licence.Name = "individual_licence";
            this.individual_licence.Size = new System.Drawing.Size(100, 20);
            this.individual_licence.TabIndex = 0;
            this.individual_licence.Tag = "";
            this.individual_licence.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchIndividualLicence);
            // 
            // selected_listview
            // 
            this.selected_listview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selected_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.selected_listview.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_listview.Location = new System.Drawing.Point(17, 357);
            this.selected_listview.MultiSelect = false;
            this.selected_listview.Name = "selected_listview";
            this.selected_listview.Size = new System.Drawing.Size(866, 254);
            this.selected_listview.TabIndex = 1;
            this.selected_listview.UseCompatibleStateImageBehavior = false;
            this.selected_listview.View = System.Windows.Forms.View.Details;
            this.selected_listview.DoubleClick += new System.EventHandler(this.delete_selected);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Line#";
            this.columnHeader6.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Total";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.Width = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order#:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.product_listview);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.category_combobox);
            this.panel2.Location = new System.Drawing.Point(293, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 274);
            this.panel2.TabIndex = 13;
            // 
            // product_listview
            // 
            this.product_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.product_listview.Location = new System.Drawing.Point(8, 41);
            this.product_listview.MultiSelect = false;
            this.product_listview.Name = "product_listview";
            this.product_listview.Size = new System.Drawing.Size(564, 193);
            this.product_listview.TabIndex = 13;
            this.product_listview.UseCompatibleStateImageBehavior = false;
            this.product_listview.View = System.Windows.Forms.View.Details;
            this.product_listview.DoubleClick += new System.EventHandler(this.pickProduct);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Product Name";
            this.columnHeader8.Width = 158;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Description";
            this.columnHeader9.Width = 117;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Price";
            this.columnHeader10.Width = 104;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Warranty";
            this.columnHeader11.Width = 95;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "License No";
            this.columnHeader12.Width = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categories : ";
            // 
            // category_combobox
            // 
            this.category_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.category_combobox.Location = new System.Drawing.Point(96, 12);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(139, 21);
            this.category_combobox.TabIndex = 0;
            this.category_combobox.SelectedIndexChanged += new System.EventHandler(this.selectCategory);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Order Items";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.createNewCustomer);
            // 
            // label_orderno
            // 
            this.label_orderno.AutoSize = true;
            this.label_orderno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_orderno.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderno.Location = new System.Drawing.Point(89, 336);
            this.label_orderno.Name = "label_orderno";
            this.label_orderno.Size = new System.Drawing.Size(68, 18);
            this.label_orderno.TabIndex = 16;
            this.label_orderno.Text = "______";
            // 
            // OrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(890, 686);
            this.Controls.Add(this.label_orderno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selected_listview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderingSystem";
            this.Text = "Ordering System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox individual_licence;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_phone;
        private System.Windows.Forms.ListView selected_listview;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView product_listview;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox company_contact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.TextBox company_discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label_orderno;
    }
}

