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
using System.Net.Mail;
using System.Net;

namespace Inventory_Mangaement
{
    public partial class Forgot_password : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=inventory_managementdb;Integrated Security=True");
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName,Password from Login where UserName ='" + textBox1.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox2.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Username not available");
                textBox2.Text = "";
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
