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
    public partial class Create_User : Form
    {
        static string activationCode;
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=inventory_managementdb;Integrated Security=True");
        public Create_User()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            String query = "Select * From Registration where Username = '" + UsernameT.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;

            activationCode = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            if (activationCode== ActivationCode.Text)
            {
                changestatus();
                MessageBox.Show("User Created Successfully");

            }
            else
            {
                MessageBox.Show("You have entered wrong OTP");
            }
            String infoquery = "Insert into Login(UserName,Password,Email) Select Username,Password,Email from Registration Where Status ='Verified' And Email='"+EmailT.Text+"'";
            SqlDataAdapter cmd = new SqlDataAdapter(infoquery, con);
            cmd.SelectCommand.ExecuteNonQuery();

            con.Close();

             }
        private void changestatus()
        {
            
            String query = "Update Registration SET Status ='Verified' Where Username = '" + UsernameT.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home Hm = new Home();
            Hm.Show();
        }

        private void View_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select Fullname,Email,PhoneNo,Address,Category,Username,Password,Status From Registration";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AddressT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Update Registration SET Fullname = '" + Fname.Text + "',Email ='" + EmailT.Text + "',PhoneNo ='" + PhoneNoT.Text + "' ,Address = '" + AddressT.Text + "',Category ='" + CategoryT.Text + "' ,Password = '" + PasswordT.Text + "',ActivationCode = '" + ActivationCode.Text + "' Where Username = '" + UsernameT.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            Fname.Text = "";
            EmailT.Text = "";
            PhoneNoT.Text = "";
            AddressT.Text = "";
            CategoryT.Text = "";
            PasswordT.Text = "";

            MessageBox.Show("Data updated successfully");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Fname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EmailT.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PhoneNoT.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            AddressT.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CategoryT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            UsernameT.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            PasswordT.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Delete From Registration Where Username = '" + UsernameT.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            Fname.Text = "";
            EmailT.Text = "";
            PhoneNoT.Text = "";
            AddressT.Text = "";
            CategoryT.Text = "";
            UsernameT.Text = "";
            PasswordT.Text = "";
            MessageBox.Show("Record Succussfully Deleted");
        }

        private void Show1_Click(object sender, EventArgs e)
        {
            if (PasswordT.PasswordChar == '*')
            {
                Hide1.BringToFront();
                PasswordT.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (PasswordT.PasswordChar == '\0')
            {
                Show1.BringToFront();
                PasswordT.PasswordChar = '*';
            }
        }
    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int len = 8;
                const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder result = new StringBuilder();
                Random rand = new Random();
                while (0 < len--)
                {
                    result.Append(ValidChar[rand.Next(ValidChar.Length)]);
                }
                PasswordT.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Password required");
            }
        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            activationCode = random.Next(1000, 9999).ToString();

            con.Open();
            string query = "insert into Registration (Fullname,Email,PhoneNo,Address,Category,Username,Password,ActivationCode,status) values ('" + Fname.Text + "','" + EmailT.Text + "','" + PhoneNoT.Text + "','" + AddressT.Text + "','" + CategoryT.Text + "','" + UsernameT.Text + "','" + PasswordT.Text + "','" + activationCode + "','Unverified')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            sendCode();
            
        }
        private void sendCode()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("inventory.just.cse@gmail.com", "inventory2021");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Activation code to verify account";
            msg.Body ="Dear "+Fname.Text+",\n\n We are glad to inform you that ,You are now registered as an user of Just CSE Inventory Management System\n\nYou are only one step away.\n\nYour Username is "+ UsernameT.Text + " ,and your password is" + PasswordT.Text + " and your OTP is "+activationCode+ "\n\nPlease confirm your account by confirming OTP. ";
            string toaddress = EmailT.Text ;
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
            }
        }
    }
    }
    

