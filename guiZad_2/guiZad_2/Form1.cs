using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            z1 z = new z1();
            z.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            z2 z = new z2();
            z.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            z3 z = new z3();
            z.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            z4 z = new z4();
            z.ShowDialog();
        }
    }
}
