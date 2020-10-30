using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InyeccionDependencia.Domain;


namespace InyeccionDependencia
{
    public partial class fMain : Form
    {
        private IServiceBus _serviceBus;



        public fMain(IServiceBus serviceBus)
        {
            InitializeComponent();

            this._serviceBus = serviceBus;
        }
    }
}
