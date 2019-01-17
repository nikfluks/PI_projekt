using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public class NovoVozilo
    {
        FrmNovoVozilo frmNovoVozilo;

        public NovoVozilo(FrmNovoVozilo frmNovoVozilo)
        {
            this.frmNovoVozilo = frmNovoVozilo;
        }

        private bool registracijaPostoji(string registracija)
        {
            bool postoji = false;
            Vozilo vozilo = null;
            using (var db = new ProjektEntities())
            {
                try
                {
                    vozilo = (from z in db.Vozilo
                              where z.registracijskaOznaka == registracija
                              select z).First<Vozilo>();
                }
                catch (InvalidOperationException)
                {
                    postoji = false;
                }
            }
            if (vozilo != null)
            {
                postoji = true;
            }
            return postoji;
        }

        public void DodajNovoVozilo(string noviNaziv, int novaGodinaProizvodnje, string novaRegistracijskaOznaka, string noviOIBVlasnika)
        {
            if (registracijaPostoji(novaRegistracijskaOznaka) == false)
            {
                using (var db = new ProjektEntities())
                {
                    Vozilo novoVozilo = new Vozilo
                    {
                        naziv = noviNaziv.Trim(),
                        godinaProizvodnje = novaGodinaProizvodnje,
                        registracijskaOznaka = novaRegistracijskaOznaka,
                        VlasnikVozila_OIB = noviOIBVlasnika
                    };
                    db.Vozilo.Add(novoVozilo);
                    db.SaveChanges();
                    MessageBox.Show("Novo vozilo je uspješno dodano.", "Novo vozilo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNovoVozilo.Close();
                }
            }
            else
            {
                MessageBox.Show("Registracija vozila već postoji.", "Registracija vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AuzurirajVozilo(Vozilo voziloZaAzurirati, string noviNaziv, int novaGodinaProizvodnje, string novaRegistracijskaOznaka, string noviOIBVlasnika)
        {
            if (voziloZaAzurirati.registracijskaOznaka == novaRegistracijskaOznaka)
            {
                using (var db = new ProjektEntities())
                {
                    db.Vozilo.Attach(voziloZaAzurirati);
                    voziloZaAzurirati.naziv = noviNaziv;
                    voziloZaAzurirati.godinaProizvodnje = novaGodinaProizvodnje;
                    voziloZaAzurirati.registracijskaOznaka = novaRegistracijskaOznaka;
                    voziloZaAzurirati.VlasnikVozila_OIB = noviOIBVlasnika;
                    db.SaveChanges();
                    MessageBox.Show("Vozilo je uspješno izmijenjeno.", "Izmijenjeno vozilo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNovoVozilo.Close();
                }
            }
            else
            {
                if (registracijaPostoji(novaRegistracijskaOznaka) == false)
                {
                    using (var db = new ProjektEntities())
                    {
                        db.Vozilo.Attach(voziloZaAzurirati);
                        voziloZaAzurirati.naziv = noviNaziv;
                        voziloZaAzurirati.godinaProizvodnje = novaGodinaProizvodnje;
                        voziloZaAzurirati.registracijskaOznaka = novaRegistracijskaOznaka;
                        voziloZaAzurirati.VlasnikVozila_OIB = noviOIBVlasnika;
                        db.SaveChanges();
                        MessageBox.Show("Vozilo je uspješno izmijenjeno.", "Izmijenjeno vozilo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmNovoVozilo.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Registracija vozila već postoji.", "Registracija vozila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
