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
    
    public partial class Supporter_Support
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supporter_Support()
        {
            this.Service_Support = new HashSet<Service_Support>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string first_surname { get; set; }
        public string second_surname { get; set; }
        public string email { get; set; }
        public Nullable<int> id_supervisor { get; set; }
    
        public virtual Supervisor_Support Supervisor_Support { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_Support> Service_Support { get; set; }
    }
}
