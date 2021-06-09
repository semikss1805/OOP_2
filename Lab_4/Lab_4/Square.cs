using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    class Square : Figure
    {
        public int sideLength;

        public Square(int x, int y, int sideLength) : base(x, y)
        {
            this.sideLength = sideLength;
        }

        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.Black, X, Y, sideLength, sideLength);
            }
        }

        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.WhiteSmoke, X, Y, sideLength, sideLength);
            }
        }
    }
}
