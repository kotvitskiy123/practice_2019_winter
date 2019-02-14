using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (String.IsNullOrEmpty(textBox2.Text)))
            {
                textBox3.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(textBox1.Text);
            double x2 = double.Parse(textBox2.Text);
            double y = Math.Sin(x1-Math.Pow(x2, 3)+Math.Sqrt(x1))-(1.3*Math.Pow(x1, 3));
            textBox3.Text = y.ToString("0.###");

            if( x1 > x2)
            {
                textBox4.Text = x2.ToString();
            }
            else
            {
                textBox4.Text = x1.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
