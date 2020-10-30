using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraloTo.DB;
using CompraloTo.Domain;

namespace CompraloTo.ViewModels
{
    public interface IUserQueryService
    {
    }


    public class UserQueryService : IUserQueryService
    {
        private readonly IDbContext _context;


        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public UserQueryService(IDbContext context)
        {
            _context = context;
        }
        
    }
}