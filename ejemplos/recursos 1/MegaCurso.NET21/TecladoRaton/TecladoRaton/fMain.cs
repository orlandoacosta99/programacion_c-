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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            WriteToLog(string.Format("KeyDown :{0}", e.KeyCode.ToString()));
            WriteToLog(string.Format("KeyDown key value:{0}", e.KeyValue.ToString()));
            WriteToLog(string.Format("KeyDown alt:{0}", e.Alt.ToString()));
            WriteToLog(string.Format("KeyDown shift:{0}", e.Shift.ToString()));
            WriteToLog(string.Format("KeyDown ctrl:{0}", e.Control.ToString()));
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            int intCode = Convert.ToInt32(e.KeyChar);

            if (e.KeyChar == '\r')
            {
                WriteToLog("KeyPress se pulsó la tecla return");
            }

            WriteToLog(string.Format("KeyPress:{0}", e.KeyChar.ToString()));
            WriteToLog(string.Format("KeyPress intCode:{0}", intCode.ToString()));
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            WriteToLog(string.Format("KeyUp :{0}", e.KeyCode.ToString()));
        }


        private void WriteToLog(string value)
        {
            this.txtLog.AppendText(value + Environment.NewLine);
        }




        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
          //  e.Handled = true;
            WriteToLog(string.Format("Form KeyDown :{0}", e.KeyCode.ToString()));
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
            //this.txtInput.AppendText("*");

            WriteToLog(string.Format("Form KeyPress :{0}", e.KeyChar.ToString()));
        }

        private void fMain_KeyUp(object sender, KeyEventArgs e)
        {
            WriteToLog(string.Format("Form KeyUp :{0}", e.KeyCode.ToString()));
        }



        private void btnShowHidePass_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = new char();
        }

        private void btnShowHidePass_MouseUp(object sender, MouseEventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }
    }
}
