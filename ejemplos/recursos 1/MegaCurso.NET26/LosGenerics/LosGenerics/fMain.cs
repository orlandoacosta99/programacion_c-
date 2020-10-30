using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LosGenerics
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnTestGenerics_Click(object sender, EventArgs e)
        {

            PersonManager<Student> studentManager = new PersonManager<Student>();

            PersonManager<Teacher> teacherManager = new PersonManager<Teacher>();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Type studentType = typeof(Student);


            Student myStudent = new Student()
            {
                Name = "Juan García",
                StudentCode = "45678",
                StudentNumber = "stunumber"
            };

            Type studentType = myStudent.GetType();


            PropertyInfo[] properties =  studentType.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                this.txtTypeInfo.AppendText(string.Format("Property:{0}", property.Name) + System.Environment.NewLine);

                if(property.Name == "StudentCode")
                {
                    property.SetValue(myStudent, "other student code");

                    string propValue = property.GetValue(myStudent).ToString(); 
                }

            }


            MemberInfo[] members = studentType.GetMembers();
            foreach(MemberInfo member in members)
            {
                this.txtTypeInfo.AppendText(string.Format("Member:{0}", member.Name) + System.Environment.NewLine);
            }

            FieldInfo[] fields = studentType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(FieldInfo field in fields)
            {
                this.txtTypeInfo.AppendText(string.Format("Field:{0}", field.Name) + System.Environment.NewLine);
            }

        }


        private void btnTestActivator_Click(object sender, EventArgs e)
        {

            PersonManager<Teacher> teacherManager = new PersonManager<Teacher>();

            Teacher teacher = teacherManager.CreateNew("teacher number");

        }

        private void btnTestGenericNew_Click(object sender, EventArgs e)
        {

            JobManager jobManager = new JobManager();

            Student student = jobManager.GetJob<Student>();

            Teacher teacher = jobManager.GetJob<Teacher>();

        }
    }
}
