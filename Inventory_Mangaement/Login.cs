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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=inventory_managementdb;Integrated Security=True");
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login where UserName='"+Username.Text+"' and Password='"+Password.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count =Convert.ToInt32 (dt.Rows.Count.ToString());

            if (count == 0)
            {
                MessageBox.Show("Username or Password does not match");
            }
            else
            {
                this.Hide();
                Home Hm = new Home();
                Hm.Show();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            if(Password.PasswordChar == '*')
            {
                HidePass.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                ShowPass.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_Password1 fp = new Forgot_Password1();
            fp.Show();
        }
    }
}
