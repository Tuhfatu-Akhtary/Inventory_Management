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
    public partial class Key : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Inventory_Mangaement.Properties.Settings.inventory_managementdbConnectionString"].ConnectionString;
        public Key()
        {
            InitializeComponent();
        }
        private void Key_Load(object sender, EventArgs e)
        {
           
        }

        private void Addkey_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            String query = "Insert into key(RoomNo,Status) values ('"+Room.Text+"','Available')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
