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
    public partial class FrmPrikazIzvjestajaRacun : Form
    {
        private Racun racunZaIzvjestaj;

        public FrmPrikazIzvjestajaRacun(Racun racunZaIzvjestaj)
        {
            InitializeComponent();
            this.racunZaIzvjestaj = racunZaIzvjestaj;
        }

        private void FrmPrikazIzvjestajaRacun_Load(object sender, EventArgs e)
        {
            this.dtVoziloTableAdapter.PopuniVozilaPoSifri(this.dsRadionicaVozila.dtVozilo, racunZaIzvjestaj.sifraPopravka);
            this.dtRacunTableAdapter.PopuniRacune(this.dsRadionicaVozila.dtRacun);
            this.dtPodaciOZaposlenikuIAutoservisuTableAdapter.PopuniPodatkeOZaposlenikuIAutoservisu(this.dsRadionicaVozila.dtPodaciOZaposlenikuIAutoservisu, racunZaIzvjestaj.Zaposlenik_OIB);
            this.dtRezervniDioTableAdapter.PopuniPodatkeORezernomDijelu(this.dsRadionicaVozila.dtRezervniDio, racunZaIzvjestaj.sifraPopravka);
            this.dtVrstaUslugeTableAdapter.FillBySifraPopravka(this.dsRadionicaVozila.dtVrstaUsluge, racunZaIzvjestaj.sifraPopravka);

            this.izvjRacun.RefreshReport();
        }
    }
}
