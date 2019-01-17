using Pomoc_aplikacije;
using System;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public partial class FrmNovoVozilo : Form
    {
        private Vozilo trenutnoVozilo;
        private NovoVozilo novoVozilo;

        public FrmNovoVozilo(Vozilo trenutnoVozilo = null)
        {
            InitializeComponent();
            novoVozilo = new NovoVozilo(this);
            this.trenutnoVozilo = trenutnoVozilo;
        }

        private void FrmNovoVozilo_Load(object sender, EventArgs e)
        {
            this.dtVlasnikVozilaIOIBTableAdapter.PopuniVlasnikeIOIBom(this.dsRadionicaVozila.dtVlasnikVozilaIOIB);
            this.dtVoziloTableAdapter.PopuniVozila(this.dsRadionicaVozila.dtVozilo);

            if(trenutnoVozilo != null)
            {
                txtNaziv.Text = trenutnoVozilo.naziv;
                numGodinaProizvodnje.Value = trenutnoVozilo.godinaProizvodnje;
                txtRegistracijskaOznaka.Text = trenutnoVozilo.registracijskaOznaka;
                comboVlasniciVozila.SelectedValue = trenutnoVozilo.VlasnikVozila_OIB;
            }
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text.Length > 0 && txtRegistracijskaOznaka.Text.Length > 0)
            {
                if(trenutnoVozilo == null)
                {
                    novoVozilo.DodajNovoVozilo(txtNaziv.Text, (int) numGodinaProizvodnje.Value, txtRegistracijskaOznaka.Text, comboVlasniciVozila.SelectedValue.ToString());
                }
                else
                {
                    novoVozilo.AuzurirajVozilo(this.trenutnoVozilo, txtNaziv.Text, (int) numGodinaProizvodnje.Value, txtRegistracijskaOznaka.Text, comboVlasniciVozila.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Unosi nisu ispravni !", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodajNovogVlasnika_Click(object sender, EventArgs e)
        {
            FrmNoviVlasnikVozila frmNoviVlasnikVozila = new FrmNoviVlasnikVozila();
            frmNoviVlasnikVozila.ShowDialog();
            this.dtVlasnikVozilaIOIBTableAdapter.PopuniVlasnikeIOIBom(this.dsRadionicaVozila.dtVlasnikVozilaIOIB);
        }

        private void FrmNovoVozilo_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
