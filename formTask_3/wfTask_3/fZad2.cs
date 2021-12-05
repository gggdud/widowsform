using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfTask_3
{
    public partial class fZad2 : Form
    {
        string str = String.Empty;
        public fZad2()
        {
            InitializeComponent();
        }
        void f(double a, double b, double h)
        {
            for (double x = a; x <= b; x += h)
            {
                if (x <= 5)
                {
                    str += x * x + 5 + " ";
                }
                else if (x < 20)
                {
                    str += 0 + " ";
                }
                else
                {
                    str += 1 + " ";
                }
            }
        }
        void f(double x, out double y)
        {
            if (x <= 5)
            {
                y = x * x + 5;
            }
            else if (x < 20)
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                f(a, b, h);
                labRes1.Text = str;
                str = String.Empty;
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    str += y + " ";
                }
                labRes2.Text = str;
            }
            catch (System.FormatException)
            {
                labRes1.Text = "Введено что-то не то";
                labRes2.Text = "Введено что-то не то";
            }
            finally
            {
                labRes1.Visible = true;
                labRes2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
