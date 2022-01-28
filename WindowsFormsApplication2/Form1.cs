using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public double txtVal; // متغير يخزن به القيم المكتوبة 
        public string Op = ""; // متغير يحمل علامات المعاملات
        public double SecVal; // متغير يحمل القيمة الثانية
        public double LastVal; // متغير يحمل نتيجة المعادلة
        public bool cl = true; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cl == false) 
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 1;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                txtVal = Convert.ToDouble(textBox1.Text);
                Op = "+";
                textBox2.Text = textBox1.Text + "+";
                textBox1.Clear();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

      if (textBox1.Text != "" && Op != "")
        {
                SecVal = Convert.ToDouble(textBox1.Text);
             if (Op == "+")
             {
              LastVal = txtVal + SecVal;
             }
              else if (Op == "-")
             {
              LastVal = txtVal - SecVal;
             }
             else if (Op == "*")
             {
               LastVal = txtVal * SecVal;
             }
             else if (Op == "/")
             {
               LastVal = txtVal / SecVal;
             }


                textBox2.Text = textBox2.Text + textBox1.Text + " =";
                textBox1.Text = Convert.ToString(LastVal);
                cl = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 2;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 3;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }


        private void button0_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 0;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 4;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
      if (cl == false)
        {
        textBox1.Clear();
        textBox1.Text = textBox1.Text + 5;
        cl = true;
        }
      else
        {
        textBox1.Text = textBox1.Text + 5;
        }
      }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 6;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 7;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 8;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cl == false)
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 9;
                cl = true;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               textBox1.Text = textBox1.Text + ".";
            }
            else textBox1.Text = 0 + ".";
            }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                txtVal = Convert.ToDouble(textBox1.Text);
                Op = "/";
                textBox2.Text = textBox1.Text + "/";
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                txtVal = Convert.ToDouble(textBox1.Text);
                Op = "*";
                textBox2.Text = textBox1.Text + "*";
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
        {
             textBox1.Text = "-";
             cl = true;
        }
            else
            {
                txtVal = Convert.ToDouble(textBox1.Text);
                Op = "-";
                textBox2.Text = textBox1.Text + "-";
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Op = "";

        }

    private void Button15_Click(object sender, EventArgs e)
      {
      if (textBox1.Text!="" && textBox1.Text!="-")
        textBox3.Text = textBox1.Text;
      }

    private void Button18_Click(object sender, EventArgs e)
      {
      if (textBox3.Text != "" && cl == true)
        {
        textBox1.Text = textBox3.Text;
        }
      else if (cl==false)
        {
        textBox1.Text = textBox3.Text;
        textBox2.Clear();
        }
      }
    }
}
