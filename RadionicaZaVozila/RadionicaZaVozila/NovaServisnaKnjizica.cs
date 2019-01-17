using System.Collections.Generic;

namespace RadionicaZaVozila
{
    class NovaServisnaKnjizica
    {
        public void DodajNovuServisnuKnjizicu(int sifraPopravka, List<KatalogServisneKnjizice> listaOdabranihStavki, int kilometraza)
        {
            using(var db = new ProjektEntities())
            {
                foreach(KatalogServisneKnjizice stavka in listaOdabranihStavki)
                {
                    ServisnaKnjizica novaKnjizica = new ServisnaKnjizica();
                    novaKnjizica.Popravak_sifra = sifraPopravka;
                    novaKnjizica.KatalogServisneKnjizice_sifra = stavka.sifra;
                    novaKnjizica.vrijednost = kilometraza;

                    db.ServisnaKnjizica.Add(novaKnjizica);
                    db.SaveChanges();
                }


            }
        }
    }
}
