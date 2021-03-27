using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLab.Parent = pictureBox1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Dispose();
            LoadLab.Dispose();


        }
    }
}
