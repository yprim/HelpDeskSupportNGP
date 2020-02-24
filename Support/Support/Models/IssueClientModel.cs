using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class IssueClientModel
    {
        public int id { get; set; }
        public string reportNumber { get; set; }
        public string registerTimestamp { get; set; }
        public string address { get; set; }
        public string contactPhone { get; set; }
        public string contactEmail { get; set; }
        public string status { get; set; }
        public string supportUserAsigned { get; set; }
        public Nullable<int> idUser { get; set; }
        public string description { get; set; }
        public string service { get; set; }
    }
}