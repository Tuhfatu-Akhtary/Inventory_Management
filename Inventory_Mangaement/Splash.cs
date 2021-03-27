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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            Loading.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Login Log = new Login();
            Log.Show();
        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }
    }
}
