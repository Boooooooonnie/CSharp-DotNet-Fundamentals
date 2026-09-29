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
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (a == 0528)
            {
                label2.ForeColor = Color.LightSteelBlue;
                textBox1.Clear();
                f2.Show();
            }
            else
            {
                label2.ForeColor = Color.DarkRed;
                textBox1.Clear();
            }
        }
    }
}
