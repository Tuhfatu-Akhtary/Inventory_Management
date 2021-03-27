﻿using System;
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
    public partial class Manage_Stock : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=.\sqlexpress;Initial Catalog=inventory_managementdb;Integrated Security=True");
        public Manage_Stock()
        {
            InitializeComponent();
        }

        private void Manage_Stock_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Manage_Stock (ItemName,ItemCode,Quantity,Price,PurchaseDate,EntryDate) values ('"+itemname.Text+"','"+ItemCode.Text+"','"+Quantity.Text+"','"+Price.Text+"','"+ textBox1.Text+ "','" + textBox2.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            itemname.Text = "";
            ItemCode.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";



            MessageBox.Show("Data inserted successfully");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void ItemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select * From Manage_Stock";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Delete From Manage_Stock Where ItemCode ='" + ItemCode.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            itemname.Text = "";
            ItemCode.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Record Succussfully Deleted");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Update Manage_Stock SET ItemName = '" + itemname.Text + "',Quantity ='" + Quantity.Text + "' ,Price = '" + Price.Text + "',PurchaseDate ='" + textBox1.Text + "' ,EntryDate = '" + textBox2.Text + "' Where ItemCode ='" + ItemCode.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            itemname.Text = "";
            ItemCode.Text = "";
            Quantity.Text = "";
            Price.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Data updated successfully");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            itemname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ItemCode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Price.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
