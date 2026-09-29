using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0322_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f, c;
            c = Convert.ToDouble(textBox1.Text);
            f = (9.0 * c) / 5.0 + 32.0;
            textBox2.Text = Convert.ToString(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double f, c;
            f = Convert.ToDouble(textBox2.Text);
            c = (5.0 / 9.0) * (f - 32);
            textBox1.Text = Convert.ToString(c);
        }
    }
}
