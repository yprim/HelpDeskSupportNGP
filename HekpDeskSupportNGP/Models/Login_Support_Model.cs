using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HekpDeskSupportNGP.Models
{
    public class Login_Support_Model
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int is_supervisor { get; set; }
    }
}