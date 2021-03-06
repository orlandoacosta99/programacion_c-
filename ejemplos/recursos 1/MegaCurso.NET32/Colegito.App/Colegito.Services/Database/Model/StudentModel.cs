﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Colegito.Domain;

namespace Colegito.Services
{
    /// <summary>
    /// Entity student-table model mapping configuration
    /// </summary>
    public class StudentModel : EntityTypeConfiguration<Student>
    {

        public StudentModel()
        {
            this.ToTable("students");

            //map value objects properties to self column names
            this.Property(t => t.Address.PostalAddress).HasColumnName("address");
            this.Property(t => t.Address.City).HasColumnName("city");
            this.Property(t => t.Address.State).HasColumnName("state");
            this.Property(t => t.Address.PostalCode).HasColumnName("postalcode");

            this.Property(t => t.Contact.Phone).HasColumnName("phone");
            this.Property(t => t.Contact.Email).HasColumnName("email");

        }

    }
}
