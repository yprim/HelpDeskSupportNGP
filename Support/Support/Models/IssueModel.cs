using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class IssueModel
    {

        public int id { get; set; }
        public string report_number { get; set; }
        public string classification { get; set; }
        public string status { get; set; }
        public System.DateTime report_timestamp { get; set; }
        public string resolution_comment { get; set; }
        public Nullable<int> id_supporter { get; set; }
        public string description { get; set; }

    }
}