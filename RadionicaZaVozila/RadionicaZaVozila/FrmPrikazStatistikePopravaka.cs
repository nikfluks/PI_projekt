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
    public partial class FrmPrikazStatistikePopravaka : Form
    {
        public FrmPrikazStatistikePopravaka()
        {
            InitializeComponent();
        }

        private void FrmPrikazStatistikePopravaka_Load(object sender, EventArgs e)
        {
            numGodina.Value = DateTime.Now.Year;

            BindingList<Vozilo> listaVozila = null;
            using (var db = new ProjektEntities())
            {
                listaVozila = new BindingList<Vozilo>(db.Vozilo.ToList());
            }
            voziloBindingSource.DataSource = listaVozila;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            grafickiPrikaz.Visible = true;

            grafickiPrikaz.ChartAreas[0].AxisX.Maximum = 12;
            

            foreach (var series in grafickiPrikaz.Series)
            {
                series.Points.Clear();
            }

            Dictionary<int, int> podaci = new Dictionary<int, int>();
            for (int i = 1; i < 13; i++)
            {
                podaci.Add(i, 0);
            }

            DataRowCollection dohvaceniPodaci = dtStatistikaPopravkaTableAdapter.DohvatiStatistikuPopravaka((int)comboVozilo.SelectedValue, numGodina.Value).Rows;

            foreach (DataRow red in dohvaceniPodaci)
            {
                podaci[int.Parse(red["Mjesec"].ToString())] = int.Parse(red["Kolicina"].ToString());
            }

            foreach (int kljuc in podaci.Keys)
            {
                grafickiPrikaz.Series["Kolicina"].Points.AddXY(kljuc,podaci[kljuc]);
            }
        }

        private void FrmPrikazStatistikePopravaka_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
