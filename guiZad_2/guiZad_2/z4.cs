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
    public partial class z4 : Form
    {
        public z4()
        {
            InitializeComponent();
        }
        string f()
        {
            string str = "";
            int count = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = count; j >= 1; j--)
                {
                    str += $"{j} ";
                }
                str += '\n';
                count++;
            }
            return str;
        }
        private void z4_Load(object sender, EventArgs e)
        {
            label1.Text = f();
        }
    }
}
