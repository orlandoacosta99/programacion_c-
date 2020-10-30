using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace CompraloTo.WebPortal
{
    public sealed class SendEmailCommand
    {
        public string fromName { get; set; }
        public string fromEmail { get; set; }
        public string toName { get; set; }
        public string toEmail { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
    }


}