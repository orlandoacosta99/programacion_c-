using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBuenCodigo
{

    /// <summary>
    /// Main form to explain the good code to students
    /// </summary>
    public partial class fMain : Form
    {
        public fMain()
        {
            //init form controls and properties
            InitializeComponent();

            Student student = new Student();
            
        }
    }
}
