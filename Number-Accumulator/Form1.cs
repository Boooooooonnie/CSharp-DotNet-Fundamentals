using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0330_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1,j=0,sum=0;
            label2.Text = Convert.ToString(i);
            label4.Text = Convert.ToString(j);
            label5.Text = Convert.ToString(sum);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j,m, sum;
            m = Convert.ToInt32(textBox1.Text);
            i = Convert.ToInt32(label2.Text);
            j = Convert.ToInt32(label4.Text);
            sum = Convert.ToInt32(label5.Text);
            i++;
            j++;
            sum = sum + m;
            label2.Text = Convert.ToString(i);
            label4.Text = Convert.ToString(j);
            label5.Text = Convert.ToString(sum);
            textBox1.Clear();
        }
    }
}
