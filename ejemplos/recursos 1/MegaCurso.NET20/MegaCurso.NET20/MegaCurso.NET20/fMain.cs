using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaCurso.NET20
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            InitMultiLanguage();
        }



        private void InitMultiLanguage()
        {
            this.lblSalut.Text = Language.Salutation;
            this.lblFlagExtProject.Image = Language.Flag;
        }



        private void btnTest_Click(object sender, EventArgs e)
        {
            this.lblTest.Text = (123568382).ToString("c");
            this.lblDate.Text = DateTime.Now.ToString();
        }
    }
}
