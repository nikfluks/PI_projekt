using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pomoc_aplikacije;

namespace RadionicaZaVozila
{
    public partial class FrmNoviPopravak : Form
    {
        private Zaposlenik prijavljeniZaposlenik;
        private NoviPopravak noviPopravak;
        private NovaServisnaKnjizica novaServisnaKnjizica;

        public FrmNoviPopravak(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            noviPopravak = new NoviPopravak();
            novaServisnaKnjizica = new NovaServisnaKnjizica();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                int sifraPopravka = noviPopravak.DodajNoviPopravak(DohvatiOdabraneUsluge(), (int)comboRezervniDio.SelectedValue, (int)comboVozilo.SelectedValue, (string)comboZaposlenik.SelectedValue, dtpDatumPopravka.Value);
                novaServisnaKnjizica.DodajNovuServisnuKnjizicu(sifraPopravka, DohvatiOdabraneStavkeKataloga(), int.Parse(txtKilometraza.Text));

                MessageBox.Show("Popravak je uspješno dodan", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Došlo je do prekida veze!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void FrmNoviPopravak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRadionicaVozila.dtZaposlenik' table. You can move, or remove it, as needed.
            this.dtZaposlenikTableAdapter.PopuniZaposlikaOIBom(this.dsRadionicaVozila.dtZaposlenik);
            DohvatiRezervneDijelove();
            DohvatiVozila();
            DohvatiUsluge();
            DohvatiStavkeServisneKnjizice();
            comboZaposlenik.SelectedValue = prijavljeniZaposlenik.OIB;
        }

        private List<VrstaUsluge> DohvatiOdabraneUsluge()
        {
            List<VrstaUsluge> listaUsluga = new List<VrstaUsluge>();

            foreach (DataGridViewRow red in dgvPopisUsluga.SelectedRows)
            {
                listaUsluga.Add(vrstaUslugeBindingSource[red.Index] as VrstaUsluge);
            }

            return listaUsluga;
        }

        private void DohvatiUsluge()
        {
            BindingList<VrstaUsluge> listaUsluga = null;
            using (var db = new ProjektEntities())
            {
                listaUsluga = new BindingList<VrstaUsluge>(db.VrstaUsluge.ToList());
            }
            vrstaUslugeBindingSource.DataSource = listaUsluga;
        }

        private void DohvatiStavkeServisneKnjizice()
        {
            BindingList<KatalogServisneKnjizice> listaStavkiServisneKnjizice = null;
            using (var db = new ProjektEntities())
            {
                listaStavkiServisneKnjizice = new BindingList<KatalogServisneKnjizice>(db.KatalogServisneKnjizice.ToList());
            }
            katalogServisneKnjiziceBindingSource.DataSource = listaStavkiServisneKnjizice;
        }

        private List<KatalogServisneKnjizice> DohvatiOdabraneStavkeKataloga()
        {
            List<KatalogServisneKnjizice> listaStavkiServisneKnjizice = new List<KatalogServisneKnjizice>();

            foreach (DataGridViewRow red in dgvPopisStavkiServisneKnjizice.SelectedRows)
            {
                listaStavkiServisneKnjizice.Add(katalogServisneKnjiziceBindingSource[red.Index] as KatalogServisneKnjizice);
            }
            return listaStavkiServisneKnjizice;
        }

        private void DohvatiRezervneDijelove()
        {
            BindingList<RezervniDio> listaRezervnihDijelova = null;
            using (var db = new ProjektEntities())
            {
                listaRezervnihDijelova = new BindingList<RezervniDio>(db.RezervniDio.ToList());
            }
            rezervniDioBindingSource.DataSource = listaRezervnihDijelova;
        }

        private void DohvatiVozila()
        {
            BindingList<Vozilo> listaVozila = null;
            using (var db = new ProjektEntities())
            {
                listaVozila = new BindingList<Vozilo>(db.Vozilo.ToList());
            }
            voziloBindingSource.DataSource = listaVozila;
        }

        private void btnDodajRezervniDio_Click(object sender, EventArgs e)
        {
            FrmNoviRezervniDio frmNoviRezrvniDio = new FrmNoviRezervniDio();
            frmNoviRezrvniDio.ShowDialog();

            DohvatiRezervneDijelove();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            FrmNovoVozilo frmNovoVozilo = new FrmNovoVozilo();
            frmNovoVozilo.ShowDialog();

            DohvatiVozila();
        }

        private void FrmNoviPopravak_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
