using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Colegito.Domain;


namespace Colegito.App
{
    public partial class fMain : Form
    {
        private IServiceInjector _ServiceInjector;


        /// <summary>
        /// Constructor from dependency injection
        /// </summary>
        public fMain(IServiceInjector injector)
        {
            InitializeComponent();

            //assign service injector reference
            _ServiceInjector = injector;
        }


        /// <summary>
        /// Dynamically open a new form, or activate if already opened
        /// </summary>
        private void OpenForm(Type formType)
        {
            //is the form already opened?
            foreach(Form form in this.MdiChildren)
            {
                if(form.GetType() == formType)
                {
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }

            //open new form, it's not already opened
            Form newForm = _ServiceInjector.Get(formType) as Form;
            newForm.MdiParent = this;
            newForm.Show();
            newForm.Activate();
        }



        private void OpenTeachersForm()
        {
            OpenForm(typeof(fTeachers));
        }


        private void OpenStudentsForm()
        {
            throw new NotImplementedException();
        }


        private void OpenDepartmentsForm()
        {
            throw new NotImplementedException();
        }


        private void OpenCoursesForm()
        {
            throw new NotImplementedException();
        }







        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlbTeachers_Click(object sender, EventArgs e)
        {
            OpenTeachersForm();
        }

        private void tlbStudents_Click(object sender, EventArgs e)
        {
            OpenStudentsForm();
        }

        private void tlbDepartments_Click(object sender, EventArgs e)
        {
            OpenDepartmentsForm();
        }

        private void tlbCourses_Click(object sender, EventArgs e)
        {
            OpenCoursesForm();
        }

    }
}
