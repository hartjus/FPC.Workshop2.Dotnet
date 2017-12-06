using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Upload
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Uploaded { get; set; }
        public string Payload { get; set; }
    }
}