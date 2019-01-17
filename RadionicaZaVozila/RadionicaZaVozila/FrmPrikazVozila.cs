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
    public partial class FrmPrikazVozila : Form
    {
        int sifraVozila = 0;

        public FrmPrikazVozila()
        {
            InitializeComponent();
        }

        private void FrmPrikazVozila_Load(object sender, EventArgs e)
        {
            this.dtVoziloTableAdapter.PopuniVozila(this.dsRadionicaVozila.dtVozilo);
        }

        private void btnIzmijeniVozilo_Click(object sender, EventArgs e)
        {
            List<Vozilo> listaVozila = null;
            if (sifraVozila != 0)
            {
                using (var db = new ProjektEntities())
                {
                    listaVozila = (from z in db.Vozilo
                                   where z.sifra == sifraVozila
                                   select z).ToList();
                }
                if (listaVozila != null && listaVozila.Count == 1)
                {
                    FrmNovoVozilo frmNovoVozilo = new FrmNovoVozilo(listaVozila[0]);
                    frmNovoVozilo.ShowDialog();
                    this.dtVoziloTableAdapter.PopuniVozila(this.dsRadionicaVozila.dtVozilo);
                }
            } 
        }

        private void btnDodavanjeVozila_Click(object sender, EventArgs e)
        {
            FrmNovoVozilo frmNovoVozilo = new FrmNovoVozilo();
            frmNovoVozilo.ShowDialog();
            this.dtVoziloTableAdapter.PopuniVozila(this.dsRadionicaVozila.dtVozilo);
        }

        private void dtVoziloDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtVoziloDataGridView.CurrentRow != null)
            {
                sifraVozila = int.Parse(dtVoziloDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void FrmPrikazVozila_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
