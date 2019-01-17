using Pomoc_aplikacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public partial class FrmNoviRacun : Form
    {
        private Zaposlenik prijavljeniZaposlenik;
        private NoviRacun noviRacun;
        private Popravak odabraniPopravak;

        public FrmNoviRacun(Zaposlenik prijavljeniZaposlenik, Popravak odabraniPopravak = null)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;
            noviRacun = new NoviRacun();
            this.odabraniPopravak = odabraniPopravak;
        }

        private void FrmNoviRacun_Load(object sender, EventArgs e)
        {
            this.dtZaposlenikTableAdapter.PopuniZaposlikaOIBom(this.dsRadionicaVozila.dtZaposlenik);
            this.dtComboPopravakTableAdapter.PopuniComboPopravak(this.dsRadionicaVozila.dtComboPopravak);

            comboZaposlenik.SelectedValue = prijavljeniZaposlenik.OIB;
            DohvatiAutoservis();

            if(odabraniPopravak != null)
            {
                List<Popravak> lista = new List<Popravak>();
                lista.Add(odabraniPopravak);
                dtComboPopravakBindingSource.DataSource = null;
                dtComboPopravakBindingSource.DataSource = lista;

                comboPopravak.DisplayMember = "datumPopravka";
                comboPopravak.ValueMember = "sifra";
                //comboPopravak.sele
            }
        }

        private void DohvatiAutoservis()
        {
            BindingList<Autoservis> listaAutoservisa = null;
            using(var db = new ProjektEntities())
            {
                listaAutoservisa = new BindingList<Autoservis>(db.Autoservis.ToList());
            }
            autoservisBindingSource.DataSource = listaAutoservisa;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                noviRacun.DodajNoviRacun(comboAutoservis.SelectedValue.ToString(), dtpDatum.Value, (int) comboPopravak.SelectedValue, comboZaposlenik.SelectedValue.ToString());
                MessageBox.Show("Uspješno dodan račun", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(System.Data.EntityException)
            {
                MessageBox.Show("Došlo je do prekida veze!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmNoviRacun_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
