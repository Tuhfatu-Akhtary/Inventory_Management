using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Mangaement
{
    public partial class Reset_Password : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8Q203MR;Initial Catalog=inventory_managementdb;Integrated Security=True");
        
        public Reset_Password()
        {
            InitializeComponent();
          
        }

        private void Hide1_Click(object sender, EventArgs e)
        {
            if (New.PasswordChar == '\0')
            {
                Show1.BringToFront();
                New.PasswordChar = '*';
            }
        }

        private void Show1_Click(object sender, EventArgs e)
        {
            if (New.PasswordChar == '*')
            {
                Hide1.BringToFront();
                New.PasswordChar = '\0';
            }
        }

        private void Hide2_Click(object sender, EventArgs e)
        {
            if (Confirm.PasswordChar == '\0')
            {
                Show2.BringToFront();
                Confirm.PasswordChar = '*';
            }
        }

        private void Show2_Click(object sender, EventArgs e)
        {
            if (Confirm.PasswordChar == '*')
            {
                Hide2.BringToFront();
                Confirm.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if(New.Text==Confirm.Text)
            {

                String query = "Update Login SET Password = '" + Confirm.Text + "' Where UserName  ='" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();

                String changequery = "Update Registration SET Password = '" + Confirm.Text + "' Where Username  ='" + textBox1.Text + "'";
                SqlDataAdapter SDB = new SqlDataAdapter(changequery, con);
                SDB.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully.");

                this.Hide();
                Login log = new Login();
                log.Show();

            }
            else
            {

            }
            con.Close();

        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
