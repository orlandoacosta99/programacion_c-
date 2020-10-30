using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia.Domain
{
    public interface ITeacherCommandService : IStartsWithMessage<CreateTeacherCommand>
    { }



    public class TeacherCommandService : ITeacherCommandService
    {
        private readonly IDbContext _context;


        /// <summary>
        /// We receive IDbContext thru dependency injection
        /// </summary>
        public TeacherCommandService(IDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// We receive a new CreateTeacherCommand and we process it
        /// </summary>
        public void Start(CreateTeacherCommand command)
        {
            //call to factory to construct a new teacher
            Teacher teacher = Teacher.CreateNew(
                command.Name,
                command.LastName,

                Address.CreateNew(
                    command.PostalAddress,
                    command.City,
                    command.State,
                    command.PostalCode
                    )

            );

            //add teacher to DB
            _context.Add(teacher);

            //save changes in DB
            _context.SaveChanges();

            //raise NewTeacherCreatedEvent
        }
    }
}
