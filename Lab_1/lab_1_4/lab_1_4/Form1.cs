using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1_4
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private Font font;
        private int position = 0;
        public Form1()
        {
            InitializeComponent();
            font = new Font("Arial Semibold", 10, FontStyle.Italic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Label " + count;
            count++;
            label.Font = font;
            label.Location = new Point(0, position);
            position += 30;
            label.MouseClick += label_Click;
            Controls.Add(label);
        }

        private void label_Click(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            int num = int.Parse(label.Text.Split()[1]);
            MessageBox.Show("Номер обраної мітки: " + num);
        }
    }
}
