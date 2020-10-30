using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CompraloTo.Domain;

namespace CompraloTo.ViewModels
{
    public class UserDTO
    {
        public int ID { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public DateTime createDate { get; set; }
        public UserRole role { get; set; }
    }


}