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
    public partial class FrmPrikazRacuna : Form
    {
        private Zaposlenik prijavljeniZaposlenik;

        public FrmPrikazRacuna(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;
        }

        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            FrmNoviRacun frmNoviRacun = new FrmNoviRacun(prijavljeniZaposlenik);
            frmNoviRacun.ShowDialog();
            this.dtRacunTableAdapter.PopuniRacune(this.dsRadionicaVozila.dtRacun);
        }

        private void FrmPrikazRacuna_Load(object sender, EventArgs e)
        {
            this.dtRacunTableAdapter.PopuniRacune(this.dsRadionicaVozila.dtRacun);
        }

        private Racun DohvatiOdabraniRacun(int sifraRacuna)
        {
            Racun odabraniRacun = null;
            using (var db = new ProjektEntities())
            {
                odabraniRacun = (from r in db.Racun
                                 where r.sifra == sifraRacuna
                                 select r).First<Racun>();
            }
            return odabraniRacun;
        }

        private void btnIzradiIzvjestaj_Click(object sender, EventArgs e)
        {
            try
            {
                int sifraRacuna = (int)dgvPrikazRacuna.CurrentRow.Cells[0].Value;
                FrmPrikazIzvjestajaRacun frmPrikazIzvjestajaRacuna = new FrmPrikazIzvjestajaRacun(DohvatiOdabraniRacun(sifraRacuna));
                frmPrikazIzvjestajaRacuna.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Nepostojeći račun!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPrikazRacuna_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
