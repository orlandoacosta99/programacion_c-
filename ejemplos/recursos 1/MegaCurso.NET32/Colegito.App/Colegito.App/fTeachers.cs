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
    public partial class fTeachers : Form
    {

        private ITeacherQueryService _QueryService;


        /// <summary>
        /// Constructor from dependency injection
        /// </summary>
        public fTeachers(ITeacherQueryService queryService)
        {
            InitializeComponent();

            //assign query service
            this._QueryService = queryService;
        }


        /// <summary>
        /// Reload teachers
        /// </summary>
        private void LoadTeachers()
        {
            List<Teacher> teachers = _QueryService.GetTeachers(null, null);

            foreach(Teacher teacher in teachers)
            {
                ListViewItem item = lstTeachers.Items.Add(teacher.ID.ToString());
                item.SubItems.Add(teacher.Name);
                item.SubItems.Add(teacher.LastName);
                item.SubItems.Add(teacher.Address.PostalAddress);
                item.SubItems.Add(teacher.Department.Name);
            }

        }


        /// <summary>
        /// Refresh list of teachers when form is activated
        /// </summary>
        private void fTeachers_Activated(object sender, EventArgs e)
        {
            LoadTeachers();
        }
    }
}
