using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint
{
    public class RectangleDrawing : IDrawing
    {
        public Color ForeColor { get; private set; }
        public Color BackColor { get; private set; }
        public Rectangle Rectangle { get; private set; }

        private Point _Initial;


        public RectangleDrawing(Color foreColor, Color backColor, int x, int y)
        {
            ForeColor = foreColor;
            BackColor = backColor;
            _Initial = new Point(x, y);
        }


        public void Draw(Graphics g)
        {
            using (Pen penRectangle = new Pen(ForeColor))
            {
                g.DrawRectangle(penRectangle, Rectangle);
            }
        }


        public void AddPoint(int x, int y)
        {
            Rectangle = new Rectangle(_Initial.X, _Initial.Y, x - _Initial.X, y - _Initial.Y);
        }
    }
}
