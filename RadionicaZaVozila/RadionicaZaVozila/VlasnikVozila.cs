//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RadionicaZaVozila
{
    using System;
    using System.Collections.Generic;
    
    public partial class VlasnikVozila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VlasnikVozila()
        {
            this.Vozilo = new HashSet<Vozilo>();
        }
    
        public string OIB { get; set; }
        public string prezime { get; set; }
        public string ime { get; set; }
        public System.DateTime datumRodenja { get; set; }
        public string spol { get; set; }
        public int postanskiBrojMjesta { get; set; }
    
        public virtual Mjesto Mjesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vozilo> Vozilo { get; set; }
    }
}