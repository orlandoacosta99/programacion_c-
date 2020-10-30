using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbAvanzado
{
    /// <summary>
    /// Do necessary mapping
    /// </summary>
    public class StudentModel : EntityTypeConfiguration<Student>
    {
        public StudentModel()
        {

            //this.Property(c => c.ID).HasColumnName("studentID");

            this.ToTable("students");

        }

    }
}
