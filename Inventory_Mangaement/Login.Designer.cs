
namespace Inventory_Mangaement
{
    partial class Login
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
            this.ShowPass = new System.Windows.Forms.Button();
            this.HidePass = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginB = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Forgot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.Forgot);
            this.panel1.Controls.Add(this.ShowPass);
            this.panel1.Controls.Add(this.HidePass);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoginB);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ShowPass
            // 
            this.ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPass.Image = global::Inventory_Mangaement.Properties.Resources.show1;
            this.ShowPass.Location = new System.Drawing.Point(398, 363);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(35, 23);
            this.ShowPass.TabIndex = 10;
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.Click += new System.EventHandler(this.Show_Click);
            // 
            // HidePass
            // 
            this.HidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePass.Image = global::Inventory_Mangaement.Properties.Resources.hide1;
            this.HidePass.Location = new System.Drawing.Point(398, 363);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(35, 23);
            this.HidePass.TabIndex = 9;
            this.HidePass.UseVisualStyleBackColor = true;
            this.HidePass.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(503, 41);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 25);
            this.Close.TabIndex = 8;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(127, 263);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(306, 22);
            this.Username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginB.Location = new System.Drawing.Point(196, 443);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(150, 57);
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(127, 363);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(306, 22);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Forgot
            // 
            this.Forgot.AutoSize = true;
            this.Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgot.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Forgot.Location = new System.Drawing.Point(272, 399);
            this.Forgot.Name = "Forgot";
            this.Forgot.Size = new System.Drawing.Size(161, 20);
            this.Forgot.TabIndex = 11;
            this.Forgot.Text = "Forgot Password?";
            this.Forgot.Click += new System.EventHandler(this.Forgot_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(731, 764);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button ShowPass;
        private System.Windows.Forms.Button HidePass;
        private System.Windows.Forms.Label Forgot;
    }
}

