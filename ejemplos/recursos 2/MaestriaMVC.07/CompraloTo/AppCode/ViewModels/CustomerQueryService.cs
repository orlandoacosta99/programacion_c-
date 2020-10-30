using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CompraloTo.DB;


namespace CompraloTo.ViewModels
{
    public class CustomerQueryService
    {
        //private GlobalDbContext _context;
        public CustomerQueryService()
        {
            //_context = context;
        }

        /// <summary>
        /// Retrieve list of customers
        /// </summary>
        /// <returns></returns>
        public List<CustomerListDTO> GetCustomerList()
        {

            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context
                    .Customers()
                    .Select(c => new CustomerListDTO()
                    {

                        ID = c.ID,

                        name = c.name,
                        lastName = c.lastName,

                        phone = c.phone,
                        email = c.email,


                    }).ToList();
            }

        }

        /// <summary>
        /// Retrieve customer by ID
        /// </summary>
        public CustomerDTO GetCustomerByID(int customerID)
        {

            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context
                    .Customers()
                    .Where(c => c.ID == customerID)
                    .Select(c => new CustomerDTO()
                    {

                        ID = c.ID,

                        name = c.name,
                        lastName = c.lastName,

                        address = c.address,
                        invoiceAddress = c.invoiceAddress,
                        shippingAddress = c.shippingAddress,

                        phone = c.phone,
                        email = c.email,


                    }).FirstOrDefault();
            }
        }
    }
}