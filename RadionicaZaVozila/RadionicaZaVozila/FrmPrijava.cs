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
    public partial class FrmPrijava : Form
    {
        Prijava prijava;

        public FrmPrijava()
        {
            InitializeComponent();
            prijava = new Prijava();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinkaKorisnika = txtLozinka.Text;

            try
            {
                prijava.OdradiPrijavu(korisnickoIme, lozinkaKorisnika);
                if (prijava.prijavljeniZaposlenik != null)
                {
                    FrmGlavna glavnaForma = new FrmGlavna(prijava.prijavljeniZaposlenik);
                    glavnaForma.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Korisnik s takvim podacima ne postoji.", "Neuspješna prijava",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception)
            {
                MessageBox.Show("Neuspjesna prijava");
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void FrmPrijava_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
