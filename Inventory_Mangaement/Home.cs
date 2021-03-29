using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Mangaement
{
    public partial class Home : Form
    {
        int i = 1;
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            DropDown.Height = 37;
            DropDown1.Height = 37;
            Dropdown3.Hide();


        }

        private void LoginH_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_User cr = new Create_User();
            cr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void ContactH_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void LoginH_Click_1(object sender, EventArgs e)
        {
            if (DropDown1.Height == 177)
            {
                DropDown1.Height = 37;
            }
            else
            {
                DropDown1.Height = 177;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if(DropDown.Height==206)
            {
                DropDown.Height = 37;
            }
            else
            {
                DropDown.Height = 206;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Stock Ms = new Manage_Stock();
            Ms.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Damaged_Product DP = new Damaged_Product();
            DP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow B = new Borrow();
            B.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                Dropdown3.Show();
            }
            else
            {
                Dropdown3.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings set = new Settings();
            set.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Damaged_product_report dr = new Damaged_product_report();
            dr.Show();
        }

        private void DropDown1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library L = new Library();
            L.Show();
        }

        private void EntryB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_Entry BE = new Book_Entry();
            BE.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Products_Report pr = new Products_Report();
            pr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Books_Report br = new Books_Report();
            br.Show();
        }
    }
}
