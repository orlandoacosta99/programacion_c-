using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesDatos
{
    public class StudentManager
    {


        private IDbConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(@"Server=.\;Database=mgcDB;Trusted_Connection=True;");
            conn.Open();
            return conn;
        }


        private void CreateParameter<T>(IDbCommand cmd, string name, T value)
        {
            IDbDataParameter prm = cmd.CreateParameter();
            prm.ParameterName = name;
            prm.Value = value;
            cmd.Parameters.Add(prm);
        }



        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID, Name, LastName, Address FROM students";

                    using (IDataReader dr = cmd.ExecuteReader())
                    {

                        while(dr.Read())
                        {
                            students.Add(new Student() {

                                ID = Convert.ToInt32(dr["ID"]),
                                Name = dr["Name"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                Address = dr["Address"].ToString()

                            });

                        }

                    }

                }

            }

            return students;
        }


        public void Write(Student student)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbTransaction trx = conn.BeginTransaction())
                {

                    try
                    {

                        using (IDbCommand cmd = conn.CreateCommand())
                        {

                            cmd.Transaction = trx;

                            cmd.CommandText = "INSERT INTO students(Name, LastName, Address) VALUES (@Name, @LastName,@Address)";

                            CreateParameter(cmd, "Name", student.Name);
                            CreateParameter(cmd, "LastName", student.LastName);
                            CreateParameter(cmd, "Address", student.Address);

                            cmd.ExecuteNonQuery();


                            cmd.CommandText = "INSERT INTO logs(action, createDate) VALUES(@action, @createDate)";
                            CreateParameter(cmd, "action", "New student created");
                            CreateParameter(cmd, "createDate", DateTime.Now);
                            cmd.ExecuteNonQuery();

                        }


                        trx.Commit();
                    }
                    catch
                    {
                        trx.Rollback();
                    }
                }

            }
        }



        public void Update(Student student)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = 
                        "UPDATE students SET Name=@Name, LastName=@LastName, Address=@Address WHERE ID=@ID";

                    CreateParameter(cmd, "ID", student.ID);
                    CreateParameter(cmd, "Name", student.Name);
                    CreateParameter(cmd, "LastName", student.LastName);
                    CreateParameter(cmd, "Address", student.Address);

                    cmd.ExecuteNonQuery();
                }

            }
        }


        public void Delete(int ID)
        {
            using (IDbConnection conn = CreateConnection())
            {
                using (IDbCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        "DELETE FROM students WHERE ID=@ID";

                    CreateParameter(cmd, "ID", ID);

                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
