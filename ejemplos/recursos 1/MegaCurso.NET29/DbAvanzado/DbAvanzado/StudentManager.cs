using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAvanzado
{
    public class StudentManager
    {


        public List<Student> GetStudents(string searchText)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {
                IQueryable<Student> query  = dbContext.Students();

                //filter students by sarch text
                if (!string.IsNullOrEmpty(searchText))
                {
                    query = query.Where(student =>

                        student.Name.Contains(searchText) ||
                        student.LastName.Contains(searchText) ||
                        student.Address.Contains(searchText) ||
                        student.Phone.Contains(searchText)

                    );

                }

                //sort records by student name
                query = query.OrderBy(student => student.Name);

                //string sql = "WHERE Name like '%@searchText%' OR LastName like ' ... "

                return query.ToList();
            }
        }


        public void Write(string name, string lastName, string address, string phone)
        {

            Student student = new Student()
            {
                Name = name,
                LastName = lastName,
                Address = address,
                Phone = phone
            };

            using (GlobalDbContext dbContext = new GlobalDbContext())
            {


                dbContext.Add(student);


                dbContext.SaveChanges();

            }
                
        }

        public void Update(int id, string name, string lastName, string address, string phone)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {

                Student student = dbContext.Students(true)
                    .Where(s => s.ID == id)
                    .FirstOrDefault();

                if(student != null)
                {
                    student.Name = name;
                    student.LastName = lastName;
                    student.Address = address;
                    student.Phone = phone;


                    dbContext.SaveChanges();
                }

            }
        }


        public void Delete(int id)
        {
            using (GlobalDbContext dbContext = new GlobalDbContext())
            {

                Student student = dbContext.Students(true)
                    .Where(s => s.ID == id)
                    .FirstOrDefault();

                if (student != null)
                {
                    dbContext.Remove(student);

                    dbContext.SaveChanges();
                }

            }

        }


    }
}
