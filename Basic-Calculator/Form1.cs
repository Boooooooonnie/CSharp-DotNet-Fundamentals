using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2,op=0;
            double sum=0;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked) { op = 1; }
            if (radioButton2.Checked) { op = 2; }
            if (radioButton3.Checked) { op = 3; }
            if (radioButton4.Checked) { op = 4; }
            switch (op)
            {
                case 1:
                    sum = n1 + n2;
                    break;
                case 2:
                    sum = n1 - n2;
                    break;
                case 3:
                    sum = n1 * n2;
                    break;
                case 4:
                    sum = n1 / n2;
                    break;
                default:
                    MessageBox.Show("錯誤 : 沒有選擇運算子!","錯誤!");
                    break;
            }
            textBox3.Text = Convert.ToString(sum);
        }
    }
}
