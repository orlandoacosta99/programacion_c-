using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FicherosEstructurados
{
    public class MasterOptions
    {

        #region GENERAL OPTIONS


        public string Folder { get; set; }

        public bool UseHardwareAcceleration { get; set; }

        public Color ForeColor { get; set; }



        #endregion


        #region DISPLAY OPTIONS


        public string Zoom { get; set; }

        public int Units { get; set; }


        public bool ShowCoordinates { get; set; }

        public bool ShowStatusBar { get; set; }


        public string DateFormat { get; set; }


        #endregion

    }
}
