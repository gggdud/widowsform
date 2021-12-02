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
    public partial class fT2 : Form
    {
        double A, dVal;
        string val;
        public fT2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                A = Double.Parse(tbA.Text);
                dVal = Double.Parse(tbVal.Text);
                val = dVal.ToString();
                if (val.Length != 2)
                {
                    throw new Exception();
                }
                if ((Convert.ToDouble(val[0].ToString()) + Convert.ToDouble(val[1].ToString())) % A == 0)
                {
                    labRes.Text = "Сумма цифр числа " + dVal + " кратна числу " + A;
                }
                else
                {
                    labRes.Text = "Сумма цифр числа " + dVal + " не кратна числу " + A;
                }
            }
            catch(System.FormatException)
            {
                labRes.Text = "Введено что-то не то";
            }
            catch(Exception)
            {
                labRes.Text = "Введено не двузначное число";
            }
            finally
            {
                labRes.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
