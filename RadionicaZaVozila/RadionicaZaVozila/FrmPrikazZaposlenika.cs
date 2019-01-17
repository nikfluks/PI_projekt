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
    public partial class FrmPrikazZaposlenika : Form
    {
        private Zaposlenik prijavljeniZaposlenik;

        public FrmPrikazZaposlenika(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;            
        }

        private void FrmPrikazZaposlenika_Load(object sender, EventArgs e)
        {
            this.dtInformacijeZaposlenikaTableAdapter.PopuniPodakeZaposlenika(this.dsInformacijeZaposlenika.dtInformacijeZaposlenika);
        }

        private void btnUredivanjePodataka_Click(object sender, EventArgs e)
        {
            FrmNoviZaposlenik novi = new FrmNoviZaposlenik(prijavljeniZaposlenik);
            novi.ShowDialog();
            this.dtInformacijeZaposlenikaTableAdapter.PopuniPodakeZaposlenika(this.dsInformacijeZaposlenika.dtInformacijeZaposlenika);

        }

        private void FrmPrikazZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
