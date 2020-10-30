using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbAvanzado
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

            List<Student> students = _Manager.GetStudents(this.txtSearch.Text);

            foreach (Student student in students)
            {

                ListViewItem item = lstStudents.Items.Add(student.ID.ToString());

                item.SubItems.Add(student.Name);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.Address);
                item.SubItems.Add(student.Phone);
            }
        }

        private void btnWriteStudent_Click(object sender, EventArgs e)
        {

            _Manager.Write(
                this.txtName.Text,
                this.txtLastName.Text,
                this.txtAddress.Text,
                this.txtPhone.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            _Manager.Update(
                int.Parse(this.txtID.Text),
                this.txtName.Text,
                this.txtLastName.Text,
                this.txtAddress.Text,
                this.txtPhone.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            _Manager.Delete(int.Parse(this.txtID.Text));

        }
    }
}
