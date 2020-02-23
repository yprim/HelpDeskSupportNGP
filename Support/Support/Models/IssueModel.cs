using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class IssueModel
    {

        public int id { get; set; }
        public string reportNumber { get; set; }
        public string classification { get; set; }
        public string status { get; set; }
        public System.DateTime reportTimestamp { get; set; }
        public string resolutionComment { get; set; }
        public Nullable<int> idSupporter { get; set; }
        public string description { get; set; }

    }
}