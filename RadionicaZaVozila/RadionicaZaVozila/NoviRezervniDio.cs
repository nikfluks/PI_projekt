using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadionicaZaVozila
{
    class NoviRezervniDio
    {

        public void DodajNoviRezervniDio(string noviNaziv, float novaCijena)
        {
            using (var db = new ProjektEntities())
            {
                RezervniDio noviRezervniDio = new RezervniDio
                {
                    naziv = noviNaziv,
                    cijena = novaCijena                    
                };
                db.RezervniDio.Add(noviRezervniDio);
                db.SaveChanges();
            }
        }

        public void IzmjeniRezervniDio(RezervniDio rezervniDioZaIzmjenu, string noviNaziv, float novaCijena)
        {
            using (var db = new ProjektEntities())
            {
                db.RezervniDio.Attach(rezervniDioZaIzmjenu);
                rezervniDioZaIzmjenu.naziv = noviNaziv;
                rezervniDioZaIzmjenu.cijena = novaCijena;
                db.SaveChanges();
            }
        }
    }
}
