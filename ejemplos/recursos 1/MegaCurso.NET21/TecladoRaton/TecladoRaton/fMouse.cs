using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoRaton
{
    public partial class fMouse : Form
    {
        public fMouse()
        {
            InitializeComponent();
        }




        private void WriteToLog(string value)
        {
            this.txtLog.AppendText(value + Environment.NewLine);
        }


        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            WriteToLog("Panel MouseEnter");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            WriteToLog("Panel MouseHover");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            WriteToLog("Panel MouseLeave");
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //WriteToLog(string.Format("Panel MouseMove X:{0}, Y:{1}", e.X, e.Y));
            this.lblPosition.Text = string.Format("Panel MouseMove X:{0}, Y:{1}", e.X, e.Y);
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            WriteToLog(string.Format("Panel MouseDown X:{0}, Y:{1}", e.X, e.Y));
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            WriteToLog(string.Format("Panel MouseUp X:{0}, Y:{1}", e.X, e.Y));
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            WriteToLog(string.Format("Panel MouseClick X:{0}, Y:{1}", e.X, e.Y));
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WriteToLog(string.Format("Panel MouseDoubleClick X:{0}, Y:{1}", e.X, e.Y));
        }




        private Point _ClickPoint;


        private void fMouse_MouseDown(object sender, MouseEventArgs e)
        {
            _ClickPoint = e.Location;
        }

        private void fMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (_ClickPoint != Point.Empty)
            {
                this.panel1.Location = e.Location;
            }
        }

        private void fMouse_MouseUp(object sender, MouseEventArgs e)
        {
            _ClickPoint = Point.Empty;
        }
    }
}
