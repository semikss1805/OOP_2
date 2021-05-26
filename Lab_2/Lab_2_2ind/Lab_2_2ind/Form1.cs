using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_2ind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                Opacity = 0.6;
            }
            else
            {
                Opacity = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(BackColor != Color.Yellow)
            {
                BackColor = Color.Yellow;
            }
            else
            {
                BackColor = Color.WhiteSmoke;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Click += button1_Click;
            }
            else
            {
                button4.Click -= button1_Click;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Click += button2_Click;
            }
            else
            {
                button4.Click -= button2_Click;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button4.Click += button3_Click;
            }
            else
            {
                button4.Click -= button3_Click;
            }
        }
    }
}
