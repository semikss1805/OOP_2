using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_3
{
    public partial class Form1 : Form
    {
        private Color color = Color.Green;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    color = Color.Red;
                    break;

                case 1:
                    color = Color.Yellow;
                    break;

                case 2:
                    color = Color.Blue;
                    break;

                default:
                    throw new Exception("Exception");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = color;
        }
    }
}
