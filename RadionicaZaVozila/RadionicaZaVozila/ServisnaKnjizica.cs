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
    
    public partial class ServisnaKnjizica
    {
        public int KatalogServisneKnjizice_sifra { get; set; }
        public int Popravak_sifra { get; set; }
        public int vrijednost { get; set; }
    
        public virtual KatalogServisneKnjizice KatalogServisneKnjizice { get; set; }
        public virtual Popravak Popravak { get; set; }
    }
}