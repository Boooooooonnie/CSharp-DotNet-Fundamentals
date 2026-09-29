using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,a1,a2,a3, b,b1,b2,b3, c,c1,c2;
            double sum = 0;
            if (checkBox2.Checked)
            {
                a1 = Convert.ToInt32(textBox1.Text);
                sum = sum + (a1 * 40);
                label3.Text += checkBox2.Text + textBox1.Text + label4.Text;
            }
            if (checkBox3.Checked)
            {
                a2 = Convert.ToInt32(textBox2.Text);
                sum = sum + (a2 * 40);
                label3.Text += checkBox3.Text + textBox2.Text + label4.Text;
            }
            if (checkBox8.Checked)
            {
                a3 = Convert.ToInt32(textBox3.Text);
                sum = sum + (a3 * 40);
                label3.Text += checkBox8.Text + textBox3.Text + label4.Text;
            }
            if (checkBox4.Checked)
            {
                b1 = Convert.ToInt32(textBox4.Text);
                sum = sum + (b1 * 20);
                label3.Text += checkBox4.Text + textBox4.Text + label9.Text;
            }
            if (checkBox5.Checked)
            {
                b2 = Convert.ToInt32(textBox5.Text);
                sum = sum + (b2 * 20);
                label3.Text += checkBox5.Text + textBox5.Text + label9.Text;
            }
            if (checkBox9.Checked)
            {
                b3 = Convert.ToInt32(textBox6.Text);
                sum = sum + (b3 * 20);
                label3.Text += checkBox9.Text + textBox6.Text + label9.Text;
            }
            if (checkBox6.Checked)
            {
                c1 = Convert.ToInt32(textBox7.Text);
                sum = sum + (c1 * 50);
                label3.Text += checkBox6.Text + textBox7.Text + label7.Text;
            }
            if (checkBox7.Checked)
            {
                c2 = Convert.ToInt32(textBox8.Text);
                sum = sum + (c2 * 50);
                label3.Text += checkBox7.Text + textBox8.Text + label8.Text;
            }
            if (radioButton1.Checked) { sum = sum * 0.9; }
            if (radioButton2.Checked) { sum = sum - 50; }
            if (checkBox10.Checked) { sum = sum + 30; }
            label12.Text = Convert.ToString(sum);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
