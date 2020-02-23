using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class SupporterModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string firstSurname { get; set; }
        public string secondSurname { get; set; }
        public string email { get; set; }
        public Nullable<int> idSupervisor { get; set; }
        public string password { get; set; }
        public Nullable<int> television { get; set; }
        public Nullable<int> mobilePhone { get; set; }
        public Nullable<int> telephone { get; set; }
        public Nullable<int> internet { get; set; }
    }
}