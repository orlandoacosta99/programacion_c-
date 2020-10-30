using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Colegito.Domain;

namespace Colegito.Services
{
    /// <summary>
    /// Entity course-table model mapping configuration
    /// </summary>
    public class CourseModel : EntityTypeConfiguration<Course>
    {

        public CourseModel()
        {
            this.ToTable("courses");
        }

    }
}
