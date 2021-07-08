using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Inventory_Mangaement
{
    public partial class Borrow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8Q203MR;Initial Catalog=inventory_managementdb;Integrated Security=True");
        public Borrow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Delete From Borrow Where PersonID ='" + textBox4.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            MessageBox.Show("Record Succussfully Deleted");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Borrow (IName,Quantity,Person_Name,PersonID,Date,Time) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            
            
            MessageBox.Show("Data inserted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Update Borrow SEt IName = '" + textBox1.Text + "',Quantity ='" + textBox2.Text + "' ,Person_Name = '" + textBox3.Text + "',Date ='" + textBox5.Text + "' ,Time = '" + textBox6.Text + "' Where PersonID ='" + textBox4.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            MessageBox.Show("Data updated successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select * From Borrow";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
