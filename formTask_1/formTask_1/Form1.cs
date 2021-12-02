using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formTask_1
{
    public partial class Form1 : Form
    {
        double x1, x2, x3, y1, y2, y3;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = Double.Parse(tbX1.Text);
                y1 = Double.Parse(tbY1.Text);
                x2 = Double.Parse(tbX2.Text);
                y2 = Double.Parse(tbY2.Text);
                x3 = Double.Parse(tbX3.Text);
                y3 = Double.Parse(tbY3.Text);
                labRes.Text = "Площадь тругольника: " + Math.Abs(0.5 * ((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)));
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
            }
            finally
            {
                labRes.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fT2 t2 = new fT2();
            t2.ShowDialog();
        }
    }
}
