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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void f(int i, int n)
        {
            if (i == 0)
            {
                return;
            }
            if (n % i == 0)
            {
                labRes.Text+=i+"\n";
            }
            f(--i, n);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(tbN.Text);
                f(n, n);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
