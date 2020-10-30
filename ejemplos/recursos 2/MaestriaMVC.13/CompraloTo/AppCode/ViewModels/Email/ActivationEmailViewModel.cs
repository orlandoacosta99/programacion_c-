using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public sealed class ActivationEmailViewModel
    {
        public string errorMessage { get; set; }
        public string successMessage { get; set; }

        public string email { get; set; }
        public string token { get; set; }
    }
}