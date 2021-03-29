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
    public partial class Books_Report : Form
    {
        public Books_Report()
        {
            InitializeComponent();
        }

        private void Books_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventory_managementdbDataSet1.Book_Entry' table. You can move, or remove it, as needed.
            this.Book_EntryTableAdapter.Fill(this.inventory_managementdbDataSet1.Book_Entry);

            this.reportViewer1.RefreshReport();
        }
    }
}
