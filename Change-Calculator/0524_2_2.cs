using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0524_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox1.Text);
            int a=0, b=0, c=0, d=0, f=0, g=0,sum=0;
            string[] array1;
            if (checkBox1.Checked) { 
                a++;
                array1 = new string[] {"a"};
            } else { a = 0; }
            if (checkBox2.Checked) { 
                b++;
                array1 = new string[] { "b" };
            } else { b = 0; }
            if (checkBox3.Checked) { 
                c++;
                array1 = new string[] { "c" };
            } else { c = 0; }
            if (checkBox4.Checked) { 
                d++;
                array1 = new string[] { "d" };
            } else { d = 0; }
            if (checkBox5.Checked) { 
                f++;
                array1 = new string[] { "f" };
            } else { f = 0; }
            sum = money- 500 * a - 100 * b - 50 * c - 10 * d - 5 * f;
            g = money - 500 * a - 100 * b - 50 * c - 10 * d - 5 * f;
            label3.Text = Convert.ToString(a);
            label4.Text = Convert.ToString(b);
            label5.Text = Convert.ToString(c);
            label6.Text = Convert.ToString(d);
            label7.Text = Convert.ToString(f);
            label8.Text = Convert.ToString(g);
        }
    }
}
