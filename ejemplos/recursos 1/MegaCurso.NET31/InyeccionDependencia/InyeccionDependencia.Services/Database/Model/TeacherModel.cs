using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


using InyeccionDependencia.Domain;

namespace InyeccionDependencia.Services
{
    /// <summary>
    /// Entity teacher-table model mapping configuration
    /// </summary>
    public class TeacherModel : EntityTypeConfiguration<Teacher>
    {
        public TeacherModel()
        {
            this.ToTable("teachers");

            //map value objects properties to self column names
            this.Property(t => t.Address.PostalAddress).HasColumnName("address");
            this.Property(t => t.Address.City).HasColumnName("city");
            this.Property(t => t.Address.State).HasColumnName("state");
            this.Property(t => t.Address.PostalCode).HasColumnName("postalcode");
        }

    }
}}
