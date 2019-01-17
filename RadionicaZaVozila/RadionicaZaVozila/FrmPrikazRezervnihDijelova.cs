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
    public partial class FrmPrikazRezervnihDijelova : Form
    {
        RezervniDio rezervniDioZaIzmjenu = null;

        public FrmPrikazRezervnihDijelova()
        {
            InitializeComponent();
        }

        private void FrmPrikazRezervnihDijelova_Load(object sender, EventArgs e)
        {
            DohvatiRezervneDijelove();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmNoviRezervniDio frmNoviRezervniDio = new FrmNoviRezervniDio();
            frmNoviRezervniDio.ShowDialog();
            DohvatiRezervneDijelove();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            FrmNoviRezervniDio frmNoviRezervniDio = new FrmNoviRezervniDio(rezervniDioZaIzmjenu);
            frmNoviRezervniDio.ShowDialog();
            DohvatiRezervneDijelove();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rezervniDioZaIzmjenu = rezervniDioBindingSource.Current as RezervniDio;
        }

        private void FrmPrikazRezervnihDijelova_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
