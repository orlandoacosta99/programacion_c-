using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroLinq
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }



        private void btnTest_Click(object sender, EventArgs e)
        {



            TestMisc();

            //TestWhereSelect();
            //TestForEach();
            //TestAction();
            //TestFuncSimple();
            //TestSum();
        }


        private void TestMisc()
        {
            List<string> myList = new List<string>() { "pepito", "juanito", "francisco" };

            List<string> sortedList = myList.OrderBy(theString => theString).ToList();

            List<string> sortedListDesc = myList.OrderByDescending(theString => theString).ToList();

            List<int> myNumbers = new List<int>() { 4, 8, 9 };
            List<int> sortedNumbers = myNumbers.OrderBy(theNumber => theNumber).ToList();


            List<Student> students = new List<Student>()
            {
                new Student() { age = 21, name = "Juan Valderrama" },
                new Student() { age = 23, name = "Carlos Sanjuán" }
            };

            List<Student> sortedStudents = students.OrderBy(student => student.name).ToList();


            List<Student> skipOneTakeOne =  students.Skip(1).Take(1).ToList();

            Dictionary<string, Student> dict = students.ToDictionary(student => student.name, student => student);

        }



        private void TestWhereSelect()
        {
            List<string> myList = new List<string>() { "pepito", "juanito", "francisco" };

            List<string> filteredList = myList
                .Where(theString => theString.Contains("f"))
                //.Where(theString => theString.Contains("m"))
                .ToList();


            List<string> filteredListWithSelect = filteredList.Select(theString => theString.Replace("o", "ó")).ToList();
            
        }



        private void TestForEach()
        {

            List<string> myList = new List<string>() { "pepito", "juanito", "francisco" };

            string output = "";
            myList.ForEach(name => {

                output += name;

            });

            List<Student> students = new List<Student>()
            {
                new Student() { age = 21, name = "Juan Valderrama" },
                new Student() { age = 23, name = "Carlos Sanjuán" }
            };

            students.ForEach(student => student.name = student.name.Replace("u", "j"));


        }






        private void TestAction()
        {

            TestActionTT.Test(theString =>
            {
                MessageBox.Show(theString);
            });

        }


        private void TestFuncSimple()
        {

            TestFunc.Test(
                
            (str1, str2) => 
            
            {

                string strOut = str1 + str2;

                return strOut.Length;
            }

            );


            int result = TestFunc.SumTwoNumbers(5, 6);


        }



        private void TestSum()
        {

            List<string> myList = new List<string>() { "pepito", "juanito", "francisco" };
            int totalLengths = myList.Sum(theString => theString.Length);


            List<int> myNumbers = new List<int>() { 4, 8, 9 };
            int totalNumbers = myNumbers.Sum(theNumber => theNumber );


            List<Student> students = new List<Student>()
            {
                new Student() { age = 21, name = "Juan Valderrama" },
                new Student() { age = 23, name = "Carlos Sanjuán" }
            };

            int totalAge = students.Sum(student => student.age);


        }


    }
}
