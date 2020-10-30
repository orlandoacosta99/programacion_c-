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
    /// Entity department-table model mapping configuration
    /// </summary>
    public class DepartmentModel : EntityTypeConfiguration<Department>
    {

        public DepartmentModel()
        {
            this.ToTable("departments");
        }

    }
}
