using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0503
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            double d = (a + b + c) / 3;
            textBox4.Text = Convert.ToString(d);
            if (d < 60)
            {
                textBox4.ForeColor = Color.DarkRed;
                MessageBox.Show("Fighting!!","", MessageBoxButtons.OK, MessageBoxIcon.None);
            }else if(d>=90){
                textBox4.ForeColor = Color.ForestGreen;
                MessageBox.Show("Good Job!!","" ,MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave?","", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
