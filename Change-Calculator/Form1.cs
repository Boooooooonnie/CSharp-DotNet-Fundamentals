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
            int a, b, c, d, f, g;
            if (checkBox1.Checked) { a = money / 500; } else { a = 0; }
            if (checkBox2.Checked) { b = (money - 500 * a) / 100; } else { b = 0; }
            if (checkBox3.Checked) { c = (money - 500 * a - 100 * b) / 50; } else { c = 0; }
            if (checkBox4.Checked) { d = (money - 500 * a - 100 * b - 50 * c) / 10; } else { d = 0; }
            if (checkBox5.Checked) { f = (money - 500 * a - 100 * b - 50 * c - 10 * d) / 5; } else { f = 0; }
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
