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
    public partial class z1 : Form
    {
        public z1()
        {
            InitializeComponent();
        }
        string f(double x, double y)
        {
            if ((x < 40 && x > -40) && (y < 40 && y > -40))
            {
                return "Точка находится внутри";
            }
            else if (((x == 40 || x == -40) && (y <= 40 && y >= -40)) || ((y == 40 || y == -40) && (x <= 40 && x >= -40)))
            {
                return "Точка находится на границе";
            }
            return "Точка находится вне";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(tbX.Text);
                double y = Double.Parse(tbY.Text);
                labRes.Text = f(x, y);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
