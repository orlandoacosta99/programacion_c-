using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using CompraloTo.DB;
using CompraloTo.Domain;


namespace CompraloTo.ViewModels
{
    public interface ICustomerCommandService
    {
        void CreateCustomer(CustomerDTO customer);
        void UpdateCustomer(CustomerDTO customer);
        void DeleteCustomer(int customerID);
    }



    public class CustomerCommandService : ICustomerCommandService
    {
        private readonly IDbContext _context;

        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public CustomerCommandService(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create new customer in the system
        /// </summary>
        public void CreateCustomer(CustomerDTO request)
        {
            Customer customer = new Customer()
            {
                name = request.name,
                lastName = request.lastName,

                address = request.address,
                invoiceAddress = request.invoiceAddress,
                shippingAddress = request.shippingAddress,

                phone = request.phone,
                email = request.email,
            };

            _context.Add(customer);

            _context.SaveChanges();
        }

        /// <summary>
        /// Update existing customer in the system
        /// </summary>
        public void UpdateCustomer(CustomerDTO request)
        {
            Customer customer = _context.Customers(true).Where(c => c.ID == request.ID).FirstOrDefault();

            Validate.NotNull(customer, string.Format("Customer with ID {0} not found", request.ID));

            customer.name = request.name;
            customer.lastName = request.lastName;

            customer.address = request.address;
            customer.invoiceAddress = request.invoiceAddress;
            customer.shippingAddress = request.shippingAddress;
            customer.phone = request.phone;
            customer.email = request.email;

            _context.SaveChanges();
        }


        /// <summary>
        /// Delete existing customer in the system
        /// </summary>
        public void DeleteCustomer(int customerID)
        {
            Customer customer = _context.Customers(true).Where(c => c.ID == customerID).FirstOrDefault();
            Validate.NotNull(customer, string.Format("Customer with ID {0} not found", customerID));

            //remove from db
            _context.Remove(customer);

            _context.SaveChanges();

        }


    }
}