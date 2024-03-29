﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Inventory_Mangaement
{
    public partial class Library : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Inventory_Mangaement.Properties.Settings.inventory_managementdbConnectionString"].ConnectionString;
        public Library()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "insert into BookIssue (PrsonName,PersonID,BookName,BookID,IssueTime) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
 
            
                string upquery = "Update Book_Entry Set Status='Occupied' where BookCode ='" + textBox4.Text + "'";
                SqlDataAdapter SDB = new SqlDataAdapter(upquery, con);
                SDB.SelectCommand.ExecuteNonQuery();
            

            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("Book Issued successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            String query = "Select * From BookIssue";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            String query = "Update BookIssue SET PrsonName = '" + textBox1.Text + "',BookName ='" + textBox3.Text + "' ,BookID = '" + textBox4.Text + "',IssueTime ='" + textBox5.Text + "' ,ReturnTime = '" + textBox6.Text + "' Where PersonID ='" + textBox2.Text + "'";
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            String query = "Delete From BookIssue Where PersonID ='" + textBox2.Text + "'";
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

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "Update BookIssue Set ReturnTime='"+textBox6.Text+"' where BookID ='"+textBox4.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();


            string upquery = "Update Book_Entry Set Status='Available' where BookCode ='" + textBox4.Text + "'";
            SqlDataAdapter SDB = new SqlDataAdapter(upquery, con);
            SDB.SelectCommand.ExecuteNonQuery();


            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Book Issued successfully");
        }
    }
}
