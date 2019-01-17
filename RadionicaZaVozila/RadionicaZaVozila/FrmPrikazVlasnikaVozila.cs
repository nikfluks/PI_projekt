using Pomoc_aplikacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public partial class FrmPrikazVlasnikaVozila : Form
    {
        VlasnikVozila odabraniVlasnik = null;

        public FrmPrikazVlasnikaVozila()
        {
            InitializeComponent();
        }

        private void FrmPopisKlijenata_Load(object sender, EventArgs e)
        {
            DohvatiVlasnikeVozila();
        }

        private void DohvatiVlasnikeVozila()
        {
            BindingList<Mjesto> listaMjesta = null;
            using (var db = new ProjektEntities())
            {
                listaMjesta = new BindingList<Mjesto>(db.Mjesto.ToList());
            }
            mjestoBindingSource.DataSource = listaMjesta;

            BindingList<VlasnikVozila> listaVlasnikaVozila = null;
            using (var db = new ProjektEntities())
            {
                listaVlasnikaVozila = new BindingList<VlasnikVozila>(db.VlasnikVozila.ToList());
            }
            vlasnikVozilaBindingSource.DataSource = listaVlasnikaVozila;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNoviVlasnikVozila noviVlasnik = new FrmNoviVlasnikVozila();
            noviVlasnik.ShowDialog();
            DohvatiVlasnikeVozila();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            FrmNoviVlasnikVozila noviVlasnik = new FrmNoviVlasnikVozila(odabraniVlasnik);
            noviVlasnik.ShowDialog();
            DohvatiVlasnikeVozila();
        }

        private void dgvPopisKlijenata_SelectionChanged(object sender, EventArgs e)
        {
            odabraniVlasnik = vlasnikVozilaBindingSource.Current as VlasnikVozila;
        }

        private void FrmPrikazVlasnikaVozila_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
