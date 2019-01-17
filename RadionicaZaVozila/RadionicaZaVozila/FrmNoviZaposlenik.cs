using Pomoc_aplikacije;
using System;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public partial class FrmNoviZaposlenik : Form
    {
        private Zaposlenik prijavljeniZaposlenik;
        private NoviZaposlenik noviZaposlenik;

        public FrmNoviZaposlenik(Zaposlenik prijavljeniZaposleni = null)
        {
            InitializeComponent();
            this.prijavljeniZaposlenik = prijavljeniZaposleni;
            noviZaposlenik = new NoviZaposlenik(this);
        }

        private void FrmNoviZaposlenik_Load(object sender, EventArgs e)
        {
            osvjeziPodatke();
            if(this.prijavljeniZaposlenik != null)
            {
                txtOIB.Text = prijavljeniZaposlenik.OIB;
                txtIme.Text = prijavljeniZaposlenik.ime;
                txtPrezime.Text = prijavljeniZaposlenik.prezime;
                txtKorisnickoIme.Text = prijavljeniZaposlenik.korisnickoIme;
                comboAutoservis.SelectedValue = prijavljeniZaposlenik.Autoservis_OIB;
                comboMjesto.SelectedValue = prijavljeniZaposlenik.Mjesto_sifra;
                dtpDatumZaposlenja.Value = prijavljeniZaposlenik.datumZaposlenja;
                txtKorisnickoIme.Enabled = false;
                txtOIB.Enabled = false;
            }
        }

        private void osvjeziPodatke()
        {
            try
            {
                mjestoBindingSource.DataSource = noviZaposlenik.OsvjeziMjesta();
                autoservisBindingSource.DataSource = noviZaposlenik.OsvjeziAutoservis();
            }
            catch(System.Data.EntityException)
            {
                MessageBox.Show("Došlo je do greške u radu s bazom. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validirajFormuZaDodavanjeNovog()
        {
            bool podaciIspravni = true;
            if(txtIme.Text.Trim() == "")
                podaciIspravni = false;
            if(txtPrezime.Text.Trim() == "")
                podaciIspravni = false;
            if(txtOIB.Text.Trim() == "")
                podaciIspravni = false;
            if(txtKorisnickoIme.Text.Trim() == "")
                podaciIspravni = false;
            if(txtLozinka.Text.Trim() == "")
                podaciIspravni = false;
            if(txtPonovljena.Text.Trim() == "")
                podaciIspravni = false;
            return podaciIspravni;
        }

        private bool validirajFormuZaAzurianje()
        {
            bool podaciIspravni = true;
            if(txtIme.Text.Trim() == "")
                podaciIspravni = false;
            if(txtPrezime.Text.Trim() == "")
                podaciIspravni = false;
            if(txtOIB.Text.Trim() == "")
                podaciIspravni = false;
            if(txtKorisnickoIme.Text.Trim() == "")
                podaciIspravni = false;
            return podaciIspravni;
        }

        private void spremiNovogKorisnika()
        {
            try
            {
                if(validirajFormuZaDodavanjeNovog())
                {
                    if(txtLozinka.Text == txtPonovljena.Text)
                    {
                        if(txtOIB.Text.Length == 11)
                        {
                            if(txtLozinka.Text.Length > 3)
                            {
                                noviZaposlenik.SpremiNovogZaposlenika(txtOIB.Text, txtIme.Text, txtPrezime.Text, dtpDatumZaposlenja.Value, txtKorisnickoIme.Text, txtLozinka.Text, (int) comboMjesto.SelectedValue, (string) comboAutoservis.SelectedValue);
                            }
                            else
                            {
                                MessageBox.Show("Lozinka mora imati više od 3 znaka !", "Lozinka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("OIB mora imati 11 znakova !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lozinka i ponovljena lozinka se moraju podudarati !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nisu popunjeni svi podaci !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(System.Data.EntityException)
            {
                MessageBox.Show("Došlo je do greške u radu s bazom. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void azurirajKorisnika()
        {
            try
            {
                if(validirajFormuZaAzurianje())
                {
                    if(txtLozinka.Text == txtPonovljena.Text)
                    {
                        noviZaposlenik.AzurirajZaposlenika(prijavljeniZaposlenik, txtIme.Text, txtPrezime.Text, dtpDatumZaposlenja.Value, txtKorisnickoIme.Text, txtLozinka.Text, (int) comboMjesto.SelectedValue, (string) comboAutoservis.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Lozinka i ponovljena lozinka se moraju podudarati !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nisu popunjeni svi podaci !", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(System.Data.EntityException)
            {
                MessageBox.Show("Došlo je do greške u radu s bazom. Pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremiZaposlenika_Click(object sender, EventArgs e)
        {
            if(prijavljeniZaposlenik == null)
            {
                spremiNovogKorisnika();
            }
            else
            {
                azurirajKorisnika();
            }
        }

        private void btnDodajMjesto_Click(object sender, EventArgs e)
        {
            FrmNovoMjesto frmNovoMjesto = new FrmNovoMjesto();
            frmNovoMjesto.ShowDialog();
            mjestoBindingSource.DataSource = noviZaposlenik.OsvjeziMjesta();
        }

        private void FrmNoviZaposlenik_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
