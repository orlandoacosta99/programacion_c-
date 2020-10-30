using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnTestInterface_Click(object sender, EventArgs e)
        {

            Student student = new Student() { Name = "Manuel Gómez" };

            Teacher teacher = new Teacher() { Name = "Dn Jaime Alarcón " };


            using (IPersonSerializer serializer = new PersonFileSerializer())
            {
                PersonManager managerToTxt = new PersonManager();
                managerToTxt.AddPerson(student);
                managerToTxt.AddPerson(teacher);
                managerToTxt.Serialize(serializer);
            }


            using (IPersonSerializer serializer = new PersonExcelSerializer())
            {
                PersonManager managerToXls = new PersonManager();
                managerToXls.AddPerson(student);
                managerToXls.AddPerson(teacher);
                managerToXls.Serialize(serializer);
            }

        }



        private void btnTestDynamic_Click(object sender, EventArgs e)
        {
            dynamic myDynElement = new
            {
                Name = "Juan Martínez",
                Phone = "78717161625"
            };

            //myDynElement.Address = "C/ Buenaventura 17, 2";

            MessageBox.Show(myDynElement.Name);

        }


    }
}
