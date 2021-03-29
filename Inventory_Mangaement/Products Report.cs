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
    public partial class Products_Report : Form
    {
        public Products_Report()
        {
            InitializeComponent();
        }

        private void Products_Report_Load(object sender, EventArgs e)
        {
            this.Manage_StockTableAdapter.Fill(this.inventory_managementdbDataSet2.Manage_Stock);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
