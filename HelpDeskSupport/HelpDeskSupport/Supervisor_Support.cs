//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDeskSupport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supervisor_Support
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supervisor_Support()
        {
            this.Supporter_Support = new HashSet<Supporter_Support>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string first_surname { get; set; }
        public string second_surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supporter_Support> Supporter_Support { get; set; }
    }
}
