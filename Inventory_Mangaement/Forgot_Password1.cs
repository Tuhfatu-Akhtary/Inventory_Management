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
using System.Net;
using System.Net.Mail;

namespace Inventory_Mangaement
{
    public partial class Forgot_Password1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8Q203MR;Initial Catalog=inventory_managementdb;Integrated Security=True");
        static string OTP;
        int count;
       
        public Forgot_Password1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            OTP = rand.Next(1000, 9999).ToString();

            con.Open();
            String query = "Update Login Set OTP ='"+OTP+"' where Email ='"+textBox1.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            String matchquery = "select Email from Login where Email='" + textBox1.Text + "'";
            SqlDataAdapter match = new SqlDataAdapter(matchquery, con);
            match.SelectCommand.ExecuteNonQuery();
            sendmail();
            con.Close();
        }
        private void sendmail()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("inventory.just.cse@gmail.com", "inventory2021");
            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "OTP to Reset Password";
            msg.Body = "Dear User,\n\n Here is your OTP " + OTP + " to reset password.\n\nPlease dont share your OTP with anyone. ";
            string toaddress = textBox1.Text;
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
                MessageBox.Show("Email doesn't exists in User details.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login where Email ='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if (count == 0)
            {
                MessageBox.Show("You have entered wrong OTP");
            }
            else
            {
                this.Hide();
                Reset_Password reset = new Reset_Password();
                reset.Show();

            }
            
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
