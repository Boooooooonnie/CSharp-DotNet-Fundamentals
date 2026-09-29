using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0602_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5;
            double s, a;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            s4 = Convert.ToInt32(textBox4.Text);
            s5 = Convert.ToInt32(textBox5.Text);

            s = sum(s1, s2, s3, s4, s5);
            label8.Text = Convert.ToString(s);

            a = average(s1, s2, s3, s4, s5);
            label9.Text = Convert.ToString(a);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public double sum(int s1, int s2, int s3, int s4, int s5)
        {
            double s;
            s = s1 + s2 + s3 + s4 + s5;
            return s;

        }
        public double average(int s1, int s2, int s3, int s4, int s5)
        {
            double a;
            a = (s1 + s2 + s3 + s4 + s5) / 5.0;
            return a;
        }
    }
}
