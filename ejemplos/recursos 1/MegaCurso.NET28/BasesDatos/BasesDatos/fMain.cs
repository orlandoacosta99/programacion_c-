using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasesDatos
{
    public partial class fMain : Form
    {
        private StudentManager _Manager;

        public fMain()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            _Manager = new StudentManager();
        }



        private void btnReadStudents_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            List<Student> students = _Manager.GetStudents();

            foreach(Student student in students)
            {

                ListViewItem item = lstStudents.Items.Add(student.ID.ToString());

                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Address);

            }

        }

        private void btnWriteStudent_Click(object sender, EventArgs e)
        {

            Student student = new Student() {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text
            };

            _Manager.Write(student);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text
            };

            _Manager.Update(student);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtID.Text));
        }
    }
}
