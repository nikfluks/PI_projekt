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
    
    public partial class Mjesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mjesto()
        {
            this.Autoservis = new HashSet<Autoservis>();
            this.VlasnikVozila = new HashSet<VlasnikVozila>();
            this.Zaposlenik = new HashSet<Zaposlenik>();
        }
    
        public int postanskiBroj { get; set; }
        public string naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autoservis> Autoservis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VlasnikVozila> VlasnikVozila { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zaposlenik> Zaposlenik { get; set; }
    }
}
