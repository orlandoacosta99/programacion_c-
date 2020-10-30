using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CompraloTo.DB;
using CompraloTo.Domain;

namespace CompraloTo.ViewModels
{
    public class CustomerQueryService : ICustomerQueryService
    {
        private readonly IDbContext _context;


        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public CustomerQueryService(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve list of customers
        /// </summary>
        /// <returns></returns>
        public List<CustomerListDTO> GetCustomerList(GetCustomerListRequest request)
        {
            IQueryable<Customer> query = _context.Customers();

            if (request != null)
            {
                if(!string.IsNullOrEmpty(request.searchText))
                {
                    query = query.Where(c =>

                        c.name.Contains(request.searchText) ||
                        c.lastName.Contains(request.searchText) ||
                        c.phone.Contains(request.searchText) ||
                        c.email.Contains(request.searchText)

                    );
                }


                string sortDir = request.sortDir;
                if (string.IsNullOrEmpty(sortDir))
                {
                    sortDir = "asc";
                }

                string sortField = request.sortField;
                if (sortField == "name")
                {
                    query = sortDir == "asc" ? query.OrderBy(c => c.name) : query.OrderByDescending(c => c.name);
                }
                else if (string.Compare(request.sortField, "lastName", true) == 0)
                {
                    query = sortDir == "asc" ? query.OrderBy(c => c.lastName) : query.OrderByDescending(c => c.lastName);
                }
                else if (sortField == "phone")
                {
                    query = sortDir == "asc" ? query.OrderBy(c => c.phone) : query.OrderByDescending(c => c.phone);
                }
                else if (sortField == "email")
                {
                    query = sortDir == "asc" ? query.OrderBy(c => c.email) : query.OrderByDescending(c => c.email);
                }
            }

            return query
                .Select(c => new CustomerListDTO()
                {

                    ID = c.ID,

                    name = c.name,
                    lastName = c.lastName,

                    phone = c.phone,
                    email = c.email,


                }).ToList();

        }

        /// <summary>
        /// Retrieve customer by ID
        /// </summary>
        public CustomerDTO GetCustomerByID(int customerID)
        {
            return _context
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