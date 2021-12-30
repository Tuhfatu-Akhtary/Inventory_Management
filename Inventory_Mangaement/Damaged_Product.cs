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
using System.Net.Mail;
using System.Net;

namespace Inventory_Mangaement
{
    public partial class Damaged_Product : Form
    {
        public Damaged_Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8Q203MR;Initial Catalog=inventory_managementdb;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Damaged_Product (Product_Name,Product_ID,Quantity,EntryDate) values ('" + Pname.Text + "','" + Pid.Text + "','" + textBox1.Text + "','"+textBox2+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            
            
            Pname.Text = "";
            Pid.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Data inserted successfully");
           
            string query2 = "update Product_List set Quantity ='"+textBox1.Text+"' where ProductName='"+Pname.Text+"'";
            SqlDataAdapter cmd = new SqlDataAdapter(query2, con);
            cmd.SelectCommand.ExecuteNonQuery();
            con.Close();
           
           



        }
        /*private void sendCode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("inventory.just.cse@gmail.com", "inventory2021");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Low stock of inventory";
            msg.Body = "Dear Admin, \n\n We are sorry to inform you that\n\nYou are only one step away.\n\n ";
            string toaddress = ;
            msg.To.Add(toaddress);
            string fromaddress = "Inventory Management CSE<inventory.just.cse@gmail.com>";
            msg.From = new MailAddress(fromaddress);
            try
            {
                smtp.Send(msg);
                MessageBox.Show("Email Sent Successfully");
            }
            catch
            {
                throw;
            }*/
        


        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select * From Damaged_Product";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Update Damaged_Product SET Product_Name = '" + Pname.Text + "',Quantity = '"+textBox1.Text+"',EntryDate = '" + textBox2.Text + "' Where Product_ID ='" + Pid.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            Pname.Text = "";
            Pid.Text = "";
          
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Data updated successfully");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Pid.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Delete From Damaged_Product Where Product_ID ='" + Pid.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            Pname.Text = "";
            Pid.Text = "";
  
            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Record Succussfully Deleted");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
