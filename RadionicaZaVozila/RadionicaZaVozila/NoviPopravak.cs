using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    class NoviPopravak
    {
        public int DodajNoviPopravak(List<VrstaUsluge> listaOdabranihUsluga, int novaSifraRezDjela, int novaSifraVozila, string noviOIBZaposlenika, DateTime noviDatumPopravka)
        {
            using (var db = new ProjektEntities())
            {
                Popravak noviPopravak = new Popravak();
                noviPopravak.sifraRezervnogDijela = novaSifraRezDjela;
                noviPopravak.sifraVozila = novaSifraVozila;
                noviPopravak.Zaposlenik_OIB = noviOIBZaposlenika;
                noviPopravak.datumPopravka = noviDatumPopravka;

                foreach (VrstaUsluge usluga in listaOdabranihUsluga)
                {
                    db.VrstaUsluge.Attach(usluga);
                    noviPopravak.VrstaUsluge.Add(usluga);
                }

                db.Popravak.Add(noviPopravak);
                db.SaveChanges();

                return noviPopravak.sifra;
            }
        }
    }
}
