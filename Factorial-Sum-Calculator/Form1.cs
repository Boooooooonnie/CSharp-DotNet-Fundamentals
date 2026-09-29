using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0524_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ss, ee, sum = 0;
            ss = Convert.ToInt32(textBox1.Text);
            ee = Convert.ToInt32(textBox2.Text);
            if (((ee%2!=0)&&(ss%2!=0))||((ee%2==0)&&(ss%2==0)))
            {
                for (int x = 1; x <= ee; x += 2)
                {
                    int m = 1;
                    for (int y = 1; y <= x; y++)
                    {
                        m = m * y;
                    }
                    sum = sum + m;
                }
                if (ee-ss==2)
                {
                    label4.Text= textBox1.Text + "! + "  + textBox2.Text + "! = " + sum;
                }
                else
                {
                    label4.Text = textBox1.Text + "! + (" + textBox1.Text + " + 2)! + ... + " + textBox2.Text + "! = " + sum;
                }
            }
            else
            {
                MessageBox.Show("輸入錯誤，請確保兩項皆為奇數或偶數", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }
    }
}
