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
    public partial class Form1 : Form
    {
        string f(int x)
        {
            string str = x.ToString();
            if (str.Length == 2)
            {
                str = str[1].ToString() + str[0].ToString();
                return str;
            }
            else
            {
                return x.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbX.Text);
                labRes.Text = f(x);
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
            fZad2 z2 = new fZad2();
            z2.ShowDialog();
        }
    }
}
