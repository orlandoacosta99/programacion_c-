using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public sealed class RegisterUserCommand
    {
        public string email { get; set; }
        public string password { get; set; }
        public string confirm { get; set; }

    }


    public sealed class ActivateUserCommand
    {
        public string email { get; set; }
        public string token { get; set; }

    }
}