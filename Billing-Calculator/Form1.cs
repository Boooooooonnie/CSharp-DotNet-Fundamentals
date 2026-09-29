using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0602_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b,sum;
            if (textBox1.Text == "")
            {
                a = 0;
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            if (textBox2.Text == "")
            {
                b = 0;
            }
            else
            {
                b = Convert.ToInt32(textBox2.Text);
            }
            sum = bill(a, b);
            label4.Text = Convert.ToString(sum);
            textBox1.Clear();
            textBox2.Clear();
        }

        public int bill(int a,int b)
        {
            int sum;
            if((a==0 && b<=60)||(a==1 && b == 0))
            {
                sum = a * 60 * 2 + b * 2;
            }
            else
            {
                sum = a * 60 * 1 + b * 1;
            }
            return sum;
        }
    }
}
