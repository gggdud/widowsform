using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f(double b, double b1, int m, int n)
        {
            if (n == 2)
            {
                return 2;
            }
            if (n == 1)
            {
                return -10;
            }
            if (m == n)
            {
                return (Math.Abs(b) - 6 * b1);
            }
            return f(b1, (Math.Abs(b) - 6 * b1), ++m, n);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                int n = int.Parse(tbN.Text);
                labRes.Text = $"Результат: {f(-10, 2, 3, n)}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
