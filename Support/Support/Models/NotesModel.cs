﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Support.Models
{
    public class NotesModel
    {
        public int id { get; set; }
        public string description { get; set; }
        public System.DateTime noteTimestamp { get; set; }
        public Nullable<int> idIssue { get; set; }
    }
}