using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint
{
    public interface IDrawing
    {
        void Draw(Graphics g);
        void AddPoint(int x, int y);
    }


    public class PathDrawing : IDrawing
    {
        public GraphicsPath Path { get; private set; }
        public Color ForeColor { get; private set; }


        public PathDrawing(Color foreColor, int x, int y)
        {
            ForeColor = foreColor;

            Path = new GraphicsPath();
            Path.AddLine(new PointF(x, y), new PointF(x,y));
        }


        public void Draw(Graphics g)
        {
            using (Pen pathPen = new Pen(ForeColor))
            {
                g.DrawPath(pathPen, Path);
            }

        }

        public void AddPoint(int x, int y)
        {
            PointF lastPoint = Path.GetLastPoint();
            PointF nextPoint = new PointF(x, y);

            Path.AddLine(lastPoint, nextPoint);
        }

    }
}
