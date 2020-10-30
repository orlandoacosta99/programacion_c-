using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPaint
{
    public partial class fMain : Form
    {

        private PaintManager _PaintManager;

        private Color _ForeColor;
        private Color _BackColor;

        private DrawingType _DrawingType;


        public fMain()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            _PaintManager = new PaintManager();

            _ForeColor = Color.Black;
            colorDlg.Color = Color.Black;

            _DrawingType = DrawingType.FreePath;
        }




        private void pctCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_DrawingType == DrawingType.FreePath)
            {
                _PaintManager.AddPath(_ForeColor, e.X, e.Y);
            }
            else if(_DrawingType == DrawingType.Rectangle)
            {
                _PaintManager.AddRectangle(_ForeColor, _BackColor, e.X, e.Y);
            }

        }


        private void pctCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_PaintManager.CurrentDrawing == null)
                return;

            _PaintManager.CurrentDrawing.AddPoint(e.X, e.Y);
            this.pctCanvas.Invalidate();
        }



        private void pctCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _PaintManager.FinishDrawing();
        }



        private void pctCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (IDrawing drawing in _PaintManager.Drawings)
            {
                drawing.Draw(e.Graphics);
            }
        }



        private void lblForeColor_Click(object sender, EventArgs e)
        {
            if(colorDlg.ShowDialog() == DialogResult.OK)
            {
                this._ForeColor = colorDlg.Color;
                this.lblForeColor.BackColor = colorDlg.Color;
            }
        }



        private void btnRectangle_Click(object sender, EventArgs e)
        {
            _DrawingType = DrawingType.Rectangle;
        }

        private void btnFreePath_Click(object sender, EventArgs e)
        {
            _DrawingType = DrawingType.FreePath;
        }
    }
}
