using System.Collections.Generic;
using System.Linq;

namespace RadionicaZaVozila
{
    public class Prijava
    {
        public Zaposlenik prijavljeniZaposlenik { get; set; }

        public void OdradiPrijavu(string korisnickoIme, string lozinkaKorisnika)
        {
            //lozinkaKorisnika = RadionicaUtils.KriptirajLozinku(lozinkaKorisnika);

            List<Zaposlenik> zaposlenici = null;
            using(var db = new ProjektEntities())
            {
                zaposlenici = (from z in db.Zaposlenik
                               where z.korisnickoIme == korisnickoIme
                               && z.lozinka == lozinkaKorisnika
                               select z).ToList();
            }

            if(zaposlenici != null && zaposlenici.Count == 1)
            {
                prijavljeniZaposlenik = zaposlenici[0];
            }
        }
    }
}
