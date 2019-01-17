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
    public partial class FrmGlavna : Form
    {
        private Zaposlenik prijavljeniZaposlenik;

        public FrmGlavna(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposlenik;
        }

        private void FrmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemNoviZaposlenik_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmNoviZaposlenik") == false)
            {
                FrmNoviZaposlenik frmNoviZaposlenik = new FrmNoviZaposlenik();
                frmNoviZaposlenik.MdiParent = this;
                frmNoviZaposlenik.Show();
            }
        }

        private void MenuItemPrikazSvihZaposlenika_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazZaposlenika") == false)
            {
                FrmPrikazZaposlenika prikaz = new FrmPrikazZaposlenika(prijavljeniZaposlenik);
                prikaz.MdiParent = this;
                prikaz.Show();
            }
        }

        private bool FormaJeOtvorena(string nazivForme)
        {
            FormCollection otvoreneForme = Application.OpenForms;
            bool formaJeOtvorena = false;
            foreach (Form frm in otvoreneForme)
            {
                if (frm.Name == nazivForme)
                {
                    frm.Focus();
                    formaJeOtvorena = true;
                }
            }

            return formaJeOtvorena;
        }

        private void MenuItemPopisKlijenata_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPopisKlijenata")==false)
            {
                FrmPrikazVlasnikaVozila popisKlijenata = new FrmPrikazVlasnikaVozila();
                popisKlijenata.MdiParent = this;
                popisKlijenata.Show();
            }
        }

        private void MenuItemPrikazVozila_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazVozila") == false)
            {
                FrmPrikazVozila prikazVozila = new FrmPrikazVozila();
                prikazVozila.MdiParent = this;
                prikazVozila.Show();
            }
        }

        private void MenuItemNovVozilo_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmNovoVozilo") == false)
            {
                FrmNovoVozilo novoVozilo = new FrmNovoVozilo();
                novoVozilo.MdiParent = this;
                novoVozilo.Show();
            }
        }

        private void MenuItemPrikazRezervnihDijelova_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazRezervnihDijelova") == false)
            {
                FrmPrikazRezervnihDijelova frmPrikazRezervnihDijelova = new FrmPrikazRezervnihDijelova();
                frmPrikazRezervnihDijelova.MdiParent = this;
                frmPrikazRezervnihDijelova.Show();
            }
        }

        private void MenuItemNoviRezervniDio_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmNoviRezervniDio") == false)
            {
                FrmNoviRezervniDio frmNoviRezervniDio = new FrmNoviRezervniDio();
                frmNoviRezervniDio.MdiParent = this;
                frmNoviRezervniDio.Show();
            }
        }

        private void MenuItemPrikazPopravaka_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazPopravaka") == false)
            {
                FrmPrikazPopravaka frmPrikazPopravaka = new FrmPrikazPopravaka(prijavljeniZaposlenik);
                frmPrikazPopravaka.MdiParent = this;
                frmPrikazPopravaka.Show();
            }
        }

        private void MenuItemPrikazPopravakaPoMjesecima_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazStatistikePopravaka") == false)
            {
                FrmPrikazStatistikePopravaka frmPrikazStatistikePopravaka = new FrmPrikazStatistikePopravaka();
                frmPrikazStatistikePopravaka.MdiParent = this;
                frmPrikazStatistikePopravaka.Show();
            }
        }

        private void FrmGlavna_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }

        private void MenuItemPrikazRacuna_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmPrikazRacuna") == false)
            {
                FrmPrikazRacuna frmPrikazRacuna = new FrmPrikazRacuna(prijavljeniZaposlenik);
                frmPrikazRacuna.MdiParent = this;
                frmPrikazRacuna.Show();
            }
        }

        private void MenuItemNoviVlasnikVozila_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmNoviVlasnikVozila") == false)
            {
                FrmNoviVlasnikVozila frmNoviVlasnikVozila = new FrmNoviVlasnikVozila();
                frmNoviVlasnikVozila.MdiParent = this;
                frmNoviVlasnikVozila.Show();
            }
        }

        private void MenuItemNoviPopravak_Click(object sender, EventArgs e)
        {
            if (FormaJeOtvorena("FrmNoviPopravak") == false)
            {
                FrmNoviPopravak frmNoviPopravak = new FrmNoviPopravak(prijavljeniZaposlenik);
                frmNoviPopravak.MdiParent = this;
                frmNoviPopravak.Show();
            }
        }
    }
}
