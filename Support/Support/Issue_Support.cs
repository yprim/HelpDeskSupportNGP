//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Support
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue_Support
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Issue_Support()
        {
            this.Notes_Support = new HashSet<Notes_Support>();
        }
    
        public int id { get; set; }
        public string report_number { get; set; }
        public string classification { get; set; }
        public string status { get; set; }
        public string report_timestamp { get; set; }
        public string resolution_comment { get; set; }
        public Nullable<int> id_supporter { get; set; }
        public string description { get; set; }
        public string service { get; set; }
    
        public virtual Supporter_Support Supporter_Support { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notes_Support> Notes_Support { get; set; }
    }
}
