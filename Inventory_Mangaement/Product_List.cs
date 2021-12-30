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
using System.Configuration;

namespace Inventory_Mangaement
{
    
    public partial class Product_List : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["Inventory_Mangaement.Properties.Settings.inventory_managementdbConnectionString"].ConnectionString;
        
        public Product_List()
        {
            InitializeComponent();
        }
        void listshow()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            String query = "Select ProductName,Quantity From Product_List";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void Product_List_Load(object sender, EventArgs e)
        {
            listshow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
