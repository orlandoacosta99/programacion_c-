using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{

    public class CreateCustomerCommand
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

    }

    public interface IDbContext
    {

        void Add<T>(T element);
        void SaveChanges();

    }


    public class CustomerService
    {
        private readonly IDbContext _context;
        public CustomerService(IDbContext context)
        {
            _context = context;
        }



        public void CreateCustomer(CreateCustomerCommand command)
        {
            Customer customer = new Customer(command.Name, command.LastName, command.Phone);


            _context.Add(customer);

            _context.SaveChanges();
        }

    }
}
