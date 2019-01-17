using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    class NoviVlasnikVozila
    {
        private FrmNoviVlasnikVozila frmNoviVlasnikVozila;

        public NoviVlasnikVozila(FrmNoviVlasnikVozila frmNoviVlasnikVozila)
        {
            this.frmNoviVlasnikVozila = frmNoviVlasnikVozila;
        }

        public void DodajNovogVlasnikaVozila(string oib, string prez, string i, DateTime datumRod, string sp, int postanskiBr)
        {
           try
            {
                using (var db = new ProjektEntities())
                {
                    VlasnikVozila noviVlasnikVozila = new VlasnikVozila
                    {
                        OIB = oib.Trim(),
                        prezime = prez.Trim(),
                        ime = i.Trim(),
                        datumRodenja = datumRod,
                        spol = sp,
                        postanskiBrojMjesta = postanskiBr
                    };
                    db.VlasnikVozila.Add(noviVlasnikVozila);
                    db.SaveChanges();
                    MessageBox.Show("Novi vlasnik je uspješno dodan.", "Novi vlasnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNoviVlasnikVozila.Close();
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Vlasnik vozila s tim OIB-om već postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.EntityException)
            {
                MessageBox.Show("Pogreška", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void IzmjeniVlasnikaVozila(VlasnikVozila vlasnikZaIzmjenu, string prez, string i, DateTime datumRod, string sp, int postanskiBr)
        {
            using (var db = new ProjektEntities())
            {
                db.VlasnikVozila.Attach(vlasnikZaIzmjenu);
                vlasnikZaIzmjenu.prezime = prez.Trim();
                vlasnikZaIzmjenu.ime = i.Trim();
                vlasnikZaIzmjenu.datumRodenja = datumRod;
                vlasnikZaIzmjenu.spol = sp;
                vlasnikZaIzmjenu.postanskiBrojMjesta = postanskiBr;

                db.SaveChanges();
                MessageBox.Show("Uspješno izmjenjen vlasnik vozila.", "Uspješna izmjena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNoviVlasnikVozila.Close();
            }
        }
    }
}
