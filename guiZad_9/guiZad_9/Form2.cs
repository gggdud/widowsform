using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiZad_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task2 t = new Task2(int.Parse(tbLen.Text));
                t.F();
                labS.Text = $"Считанные строки:\n{t.Show()}";
                labRes.Text = $"Строки с заданной длиной:\n{t.F()}";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
    class Task2
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + "\\file.txt";
        string[] strArr;
        int len;
        public Task2(int len)
        {
            this.len = len;
            strArr = File.ReadAllLines(path, Encoding.Default);
        }
        public string F()
        {
            string str = "";
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length == len)
                {
                    str += $"{strArr[i]}\n";
                }
            }
            return str != "" ? str : "Строк с заданной длиной нет";
        }
        public string Show()
        {
            return String.Join('\n'.ToString(), strArr);
        }
    }
}
