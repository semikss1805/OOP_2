using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        Circle circle = new Circle(50, 50, 20);
        Square square = new Square(100, 100, 30);

        public Form1()
        {
            InitializeComponent();

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }

        private void CircleT(Circle c)
        {
                c = new Circle(c.X, c.Y, c.radius);

                Task task = new Task(() =>
                {
                    while (c.X <= 200)
                    {
                        c.MoveRight(pictureBox1);
                        Thread.Sleep(100);
                        Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                    }
                });
                task.Start();
        }

        private void SquareT(Square s)
        {
            s = new Square(s.X, s.Y, s.sideLength);

            Task task = new Task(() =>
            {
                while (s.X <= 200)
                {
                    s.MoveRight(pictureBox1);
                    Thread.Sleep(100);
                    Invoke(new MethodInvoker(delegate { pictureBox1.Refresh(); }));
                }
            });
            task.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CircleT(circle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SquareT(square);
        }
    }
}
