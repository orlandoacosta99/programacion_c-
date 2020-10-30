using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint
{
    public class PaintManager
    {
        public List<IDrawing> Drawings { get; private set; }
        public IDrawing CurrentDrawing { get; private set; }


        public PaintManager()
        {
            this.Drawings = new List<IDrawing>();
        }


        public void AddPath(Color foreColor, int x, int y)
        {
            IDrawing drawing = new PathDrawing(foreColor, x, y);
            this.Drawings.Add(drawing);
            this.CurrentDrawing = drawing;
        }

        public void AddRectangle(Color foreColor, Color backColor, int x, int y)
        {
            IDrawing drawing = new RectangleDrawing(foreColor, backColor, x, y);
            this.Drawings.Add(drawing);
            this.CurrentDrawing = drawing;
        }


        public void FinishDrawing()
        {
            this.CurrentDrawing = null;
        }

    }
}
