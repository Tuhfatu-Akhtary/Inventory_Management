﻿
namespace Inventory_Mangaement
{
    partial class Manage_Stock
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.ItemCode = new System.Windows.Forms.TextBox();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemname = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.ItemCode);
            this.panel1.Controls.Add(this.PhoneNo);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.itemname);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Location = new System.Drawing.Point(87, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 594);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(394, 22);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 22);
            this.textBox1.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(169, 266);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(394, 22);
            this.Price.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 58);
            this.label6.TabIndex = 17;
            this.label6.Text = "Purchase \r\nDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 58);
            this.label5.TabIndex = 16;
            this.label5.Text = "Entry \r\nDate";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(169, 207);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(394, 22);
            this.Quantity.TabIndex = 12;
            // 
            // ItemCode
            // 
            this.ItemCode.Location = new System.Drawing.Point(169, 151);
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Size = new System.Drawing.Size(394, 22);
            this.ItemCode.TabIndex = 11;
            this.ItemCode.TextChanged += new System.EventHandler(this.ItemCode_TextChanged);
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(22, 207);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(100, 29);
            this.PhoneNo.TabIndex = 10;
            this.PhoneNo.Text = "Quantity";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(22, 266);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(69, 29);
            this.Address.TabIndex = 9;
            this.Address.Text = "Price";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(22, 151);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(124, 29);
            this.Email.TabIndex = 8;
            this.Email.Text = "Item Code";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(22, 94);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(130, 29);
            this.Username.TabIndex = 7;
            this.Username.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Stock";
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(169, 94);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(394, 22);
            this.itemname.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(231, 490);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(209, 57);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(783, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 400);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(982, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(796, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(990, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1183, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 57);
            this.button4.TabIndex = 8;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Manage_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 656);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Manage_Stock";
            this.Text = "Manage_Stock";
            this.Load += new System.EventHandler(this.Manage_Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox ItemCode;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}