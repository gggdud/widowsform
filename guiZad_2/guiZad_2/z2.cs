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
    public partial class z2 : Form
    {
        public z2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = new DateTime(1990, 1, 1);
                int m = int.Parse(textBox1.Text);
                int d = int.Parse(textBox2.Text);
                DateTime finish = start.AddMonths(m);
                finish = finish.AddDays(d);
                int month = finish.Month;
                string s_month = "";
                switch (month)
                {
                    case 1: s_month = "Январь"; break;
                    case 2: s_month = "Февраль"; break;
                    case 3: s_month = "Март"; break;
                    case 4: s_month = "Апрель"; break;
                    case 5: s_month = "Май"; break;
                    case 6: s_month = "Июнь"; break;
                    case 7: s_month = "Июль"; break;
                    case 8: s_month = "Август"; break;
                    case 9: s_month = "Сентябрь"; break;
                    case 10: s_month = "Октябрь"; break;
                    case 11: s_month = "Ноябрь"; break;
                    case 12: s_month = "Декабрь"; break;
                }
                labRes.Text = $"Сейчас {s_month}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
