using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.Domain
{
    public class User : Aggregate
    {
        public string email { get; set; }
        public string password { get; set; }

        public string token { get; set; }

        public DateTime createDate { get; set; }
        public UserRole role { get; set; }

        public Customer customer { get; set; }

        public bool activated { get; set; }
    }


    public enum UserRole
    {
        Admin = 1,
        Customer = 2,
    }

}