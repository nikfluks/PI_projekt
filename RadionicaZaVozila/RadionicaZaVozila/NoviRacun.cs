using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadionicaZaVozila
{
    class NoviRacun
    {
        public void DodajNoviRacun(string noviAutoservis, DateTime noviDatumRacuna, int noviPopravak, string noviZaposlenik)
        {
            using (var db = new ProjektEntities())
            {
                Racun noviRacun = new Racun
                {
                    Autoservis_OIB = noviAutoservis,
                    datum = noviDatumRacuna,
                    sifraPopravka = noviPopravak,
                    Zaposlenik_OIB = noviZaposlenik
                };
                db.Racun.Add(noviRacun);
                db.SaveChanges();
            }
        }
    }
}
