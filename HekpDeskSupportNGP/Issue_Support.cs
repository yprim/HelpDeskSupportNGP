//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HekpDeskSupportNGP
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
        public System.DateTime report_timestamp { get; set; }
        public string resolution_comment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notes_Support> Notes_Support { get; set; }
    }
}
