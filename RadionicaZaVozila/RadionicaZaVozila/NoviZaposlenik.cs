using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public class NoviZaposlenik
    {
        FrmNoviZaposlenik frmNoviZaposlenik;

        public NoviZaposlenik(FrmNoviZaposlenik frmNoviZaposlenik)
        {
            this.frmNoviZaposlenik = frmNoviZaposlenik;
        }

        public bool ProvjeraPostojanjaKorisnickogImena(string korisnickoIme)
        {
            bool postoji = false;
            Zaposlenik prijavljeniZaposlenik = null;
            using (var db = new ProjektEntities())
            {
                try
                {
                    prijavljeniZaposlenik = (from z in db.Zaposlenik
                                             where z.korisnickoIme == korisnickoIme
                                             select z).First<Zaposlenik>();
                }
                catch (InvalidOperationException)
                {
                    postoji = false;
                }
            }

            if (prijavljeniZaposlenik != null)
            {
                postoji = true;
            }
            return postoji;
        }

        public BindingList<Mjesto> OsvjeziMjesta()
        {
            BindingList<Mjesto> listaMjesta = null;
            using (var db = new ProjektEntities())
            {
                listaMjesta = new BindingList<Mjesto>(db.Mjesto.ToList());
            }

            return listaMjesta;
        }

        public BindingList<Autoservis> OsvjeziAutoservis()
        {
            BindingList<Autoservis> listaAutoservisa = null;
            using (var db = new ProjektEntities())
            {
                listaAutoservisa = new BindingList<Autoservis>(db.Autoservis.ToList());
            }

            return listaAutoservisa;
        }

        public void SpremiNovogZaposlenika(string noviOIB, string novoIme, string novoPrezime, DateTime noviDatumZaposlenja, string NovoKorisnickoIme, string NovaLozinka, int NovoMjesto_sifra, string NoviAutoservis_OIB)
        {
            if (ProvjeraPostojanjaKorisnickogImena(NovoKorisnickoIme.Trim()) == false)
            {
                try
                {
                    using (var db = new ProjektEntities())
                    {
                        Zaposlenik noviZaposlenik = new Zaposlenik
                        {
                            OIB = noviOIB.Trim(),
                            ime = novoIme.Trim(),
                            prezime = novoPrezime.Trim(),
                            datumZaposlenja = noviDatumZaposlenja,
                            korisnickoIme = NovoKorisnickoIme.Trim(),
                            lozinka = RadionicaUtils.KriptirajLozinku(NovaLozinka.Trim()),
                            Mjesto_sifra = NovoMjesto_sifra,
                            Autoservis_OIB = NoviAutoservis_OIB
                        };
                        db.Zaposlenik.Add(noviZaposlenik);
                        db.SaveChanges();
                        MessageBox.Show("Novi zaposlenik je uspješno dodan.", "Novi korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNoviZaposlenik.Close();
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    MessageBox.Show("Uneseni OIB već postoji !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Korisničko ime već postoji !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool mijenjaSeLozinka(string lozinka)
        {
            if (lozinka != "") return true;
            else return false;
        }

        public void AzurirajZaposlenika(Zaposlenik prijavljeniZaposlenik, string novoIme, string novoPrezime, DateTime noviDatumZaposlenja, string novoKorisnickoIme, string novaLozinka, int novoMjesto_sifra, string noviAutoservis_OIB)
        {

            if (mijenjaSeLozinka(novaLozinka))
            {
                if (novaLozinka.Length > 3)
                {
                    using (var db = new ProjektEntities())
                    {
                        db.Zaposlenik.Attach(prijavljeniZaposlenik);
                        prijavljeniZaposlenik.ime = novoIme.Trim();
                        prijavljeniZaposlenik.prezime = novoPrezime.Trim();
                        prijavljeniZaposlenik.datumZaposlenja = noviDatumZaposlenja;
                        prijavljeniZaposlenik.korisnickoIme = novoKorisnickoIme.Trim();
                        prijavljeniZaposlenik.lozinka = RadionicaUtils.KriptirajLozinku(novaLozinka);
                        prijavljeniZaposlenik.Mjesto_sifra = novoMjesto_sifra;
                        prijavljeniZaposlenik.Autoservis_OIB = noviAutoservis_OIB;

                        db.SaveChanges();
                        MessageBox.Show("Korisnik je uspješno izmjenjen.", "Uspješna akcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNoviZaposlenik.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lozinka mora imati više od 3 znaka !", "Lozinka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                using (var db = new ProjektEntities())
                {
                    db.Zaposlenik.Attach(prijavljeniZaposlenik);
                    prijavljeniZaposlenik.ime = novoIme.Trim();
                    prijavljeniZaposlenik.prezime = novoPrezime.Trim();
                    prijavljeniZaposlenik.datumZaposlenja = noviDatumZaposlenja;
                    prijavljeniZaposlenik.korisnickoIme = novoKorisnickoIme.Trim();
                    prijavljeniZaposlenik.Mjesto_sifra = novoMjesto_sifra;
                    prijavljeniZaposlenik.Autoservis_OIB = noviAutoservis_OIB;

                    db.SaveChanges();
                    MessageBox.Show("Korisnik je uspješno izmjenjen.", "Uspješna akcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNoviZaposlenik.Close();
                }
            }
        }


    }
}
