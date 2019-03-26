using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form1 : Form
    {
        decimal end = 0;
        decimal store = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void badd_Click(object sender, EventArgs e)
        {
            textBox1.Text += badd.Text;
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            textBox1.Text += bsub.Text;
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            textBox1.Text += bmul.Text;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += bdiv.Text;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text += bdot.Text;
        }

        private void bdel_Click(object sender, EventArgs e)
        {
            StringBuilder obj = new StringBuilder(textBox1.Text);
            obj.Remove(textBox1.Text.Length - 1, 1);
            textBox1.Text = obj.ToString();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void breset_Click(object sender, EventArgs e)
        {
            int ind = textBox1.Text.Length - 1;
            while (textBox1.Text[ind] != '+' && textBox1.Text[ind] != '-' && textBox1.Text[ind] != '*' && textBox1.Text[ind] != '/')
            {
                    StringBuilder obj = new StringBuilder(textBox1.Text);
                    obj.Remove(ind, 1);
                    textBox1.Text = obj.ToString();
                    ind = ind - 1;          
            }
        }

        private void beq_Click(object sender, EventArgs e)
        {
            DataTable obj = new DataTable();
            var result = obj.Compute(textBox1.Text, null);
            textBox1.Text = Convert.ToString(result);
        }

        private void breci_Click(object sender, EventArgs e)
        {
            double ans = Convert.ToDouble(textBox1.Text);
            ans = 1 / ans;
            textBox1.Text = Convert.ToString(ans);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            store = 0;
            return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            store = store - end;
            return;
        }

        private void bmr_Click(object sender, EventArgs e)
        {
            textBox1.Text = store.ToString();
            return;
        }

        private void bmplus_Click(object sender, EventArgs e)
        {
            store += end;
            return;
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            store -= end;
            return;
        }

        private void bsqrt_Click(object sender, EventArgs e)
        {
           // textBox1.Text += bsqrt.Text;
            double ans = Convert.ToDouble(textBox1.Text);
            ans = Math.Sqrt(ans);
            textBox1.Text = Convert.ToString(ans);
        }

        private void bminplus_Click(object sender, EventArgs e)
        {
            double neg = Convert.ToDouble(textBox1.Text);
            neg = neg*(-1);
            textBox1.Text = Convert.ToString(neg);
        }

        private void bpercent_Click(object sender, EventArgs e)
        {
            double sqr = Convert.ToDouble(textBox1.Text);
            sqr *= sqr;
            textBox1.Text = Convert.ToString(sqr);
        }
    }
}
