using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FicherosEstructurados
{
    public partial class fMain : Form
    {

        private OptionsManager _optionsManager;
        private MasterOptions _options;


        public fMain()
        {
            InitializeComponent();
            Init();

            //NewOptions();
            LoadOptions();
        }




        private void Init()
        {
            _optionsManager = new OptionsManager();
        }


        private void NewOptions()
        {
            this._options = new MasterOptions();
            this.bindingSource.Add(this._options);
        }


        private void LoadOptions()
        {
            this._options = _optionsManager.Read();
            this.bindingSource.Add(this._options);
        }



        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                this._options.Folder = folderBrowserDlg.SelectedPath;
                this.bindingSource.CurrencyManager.Refresh();
            }
        }

        private void btnSelectForeColor_Click(object sender, EventArgs e)
        {
            if(colorDlg.ShowDialog() == DialogResult.OK)
            {
                this._options.ForeColor = colorDlg.Color;
                this.bindingSource.CurrencyManager.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _optionsManager.Save(_options);
            MessageBox.Show("Guardar completado");
        }
    }
}
