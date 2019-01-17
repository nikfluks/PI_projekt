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
    public partial class FrmPrikazPopravaka : Form
    {
        private Zaposlenik prijavljeniZaposlenik;

        public FrmPrikazPopravaka(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;
        }

        private void FrmPrikazPopravaka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRadionicaVozila.dtPopravak' table. You can move, or remove it, as needed.
            this.dtPopravakTableAdapter.PopuniPopravake(this.dsRadionicaVozila.dtPopravak);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNoviPopravak frmNoviPopravak = new FrmNoviPopravak(prijavljeniZaposlenik);
            frmNoviPopravak.ShowDialog();

            this.dtPopravakTableAdapter.PopuniPopravake(this.dsRadionicaVozila.dtPopravak);
        }

        private void dgvPrikazPopravaka_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int sifraPopravka = (int)dgvPrikazPopravaka.CurrentRow.Cells[0].Value;
                dtVrstaUslugeTableAdapter.FillBySifraPopravka(this.dsRadionicaVozila.dtVrstaUsluge, sifraPopravka);
                dtKatalogServisneKnjiziceTableAdapter.PopuniStavkeServisneKnjizice(this.dsRadionicaVozila.dtKatalogServisneKnjizice, sifraPopravka);
            }
            catch (NullReferenceException)
            {
               
            }
        }

        private void FrmPrikazPopravaka_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }

        private void btnIzradiRacun_Click(object sender, EventArgs e)
        {
            try
            {
                int sifra = (int)dgvPrikazPopravaka.CurrentRow.Cells[0].Value;

                Popravak odabrani = null;
                using (var db = new ProjektEntities())
                {
                    odabrani = (from r in db.Popravak
                                where r.sifra == sifra
                                select r).First<Popravak>();
                }

                FrmNoviRacun frmNoviRacun = new FrmNoviRacun(prijavljeniZaposlenik, odabrani);
                frmNoviRacun.ShowDialog();
            }
            catch (Exception)
            {

            }

        }
    }
}
