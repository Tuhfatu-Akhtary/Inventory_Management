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
    public partial class Splash1 : Form
    {
        public Splash1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }
        int i;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Loaddot.Refresh();
            if (i == 5)
            {
                i = 1;
                Loaddot.Text = "";
            }
            else if (i == 1)
            {
                i = i + 1;
                Loaddot.Text = ".";
            }
            else if (i == 2)
            {
                i = i + 1;
                Loaddot.Text = "..";
            }
            else if (i == 3)
            {
                i = i + 1;
                Loaddot.Text = "...";
            }
            else if (i == 4)
            {
                i = i + 1;
                Loaddot.Text = "....";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progress.Width += 1;
            if (Progress.Width > 731)
            {
                timer1.Stop();
                timer2.Stop();
                this.Hide();
                Login Log = new Login();
                Log.Show();
            }
        }
    }
}
