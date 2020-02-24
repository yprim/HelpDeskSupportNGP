using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class CommentModel
    {
        public int id { get; set; }
        public string description { get; set; }
        public string noteTimestamp { get; set; }
        public Nullable<int> idIssue { get; set; }
        public string reportNumber { get; set; }
    }
}