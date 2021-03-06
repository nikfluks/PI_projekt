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
    
    public partial class Popravak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Popravak()
        {
            this.Racun = new HashSet<Racun>();
            this.ServisnaKnjizica = new HashSet<ServisnaKnjizica>();
            this.VrstaUsluge = new HashSet<VrstaUsluge>();
        }
    
        public int sifra { get; set; }
        public int sifraRezervnogDijela { get; set; }
        public int sifraVozila { get; set; }
        public string Zaposlenik_OIB { get; set; }
        public System.DateTime datumPopravka { get; set; }
    
        public virtual RezervniDio RezervniDio { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServisnaKnjizica> ServisnaKnjizica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VrstaUsluge> VrstaUsluge { get; set; }
    }
}
