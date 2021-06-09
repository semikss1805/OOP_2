using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    abstract class Figure
    {
        private int y;
        private int x;

        protected Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x;}
        public int Y { get => y;}

        public abstract void DrawBlack(PictureBox p);

        public abstract void HideDrawingBackGround(PictureBox p);

        public void MoveRight(PictureBox p)
        {
            HideDrawingBackGround(p);
            x += 3;
            DrawBlack(p);
        }

    }
}
