using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class SupervisorModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}