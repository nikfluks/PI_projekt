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
    public partial class FrmNoviRezervniDio : Form
    {
        private NoviRezervniDio noviRezervniDio;
        private RezervniDio rezervniDioZaIzmjenu;

        public FrmNoviRezervniDio(RezervniDio rezervniDioZaIzmjenu = null)
        {
            InitializeComponent();
            noviRezervniDio = new NoviRezervniDio();
            this.rezervniDioZaIzmjenu = rezervniDioZaIzmjenu;

        }

        private void FrmNoviRezervniDio_Load(object sender, EventArgs e)
        {
            if (rezervniDioZaIzmjenu != null)
            {
                txtNaziv.Text = rezervniDioZaIzmjenu.naziv;
                txtCijena.Text = rezervniDioZaIzmjenu.cijena.ToString();
            }
        }

        private bool ValidacijaForme()
        {
            bool validacija = true;
            if (txtNaziv.Text == "")
            {
                validacija = false;
            }
            if (txtCijena.Text == "")
            {
                validacija = false;
            }
            return validacija;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (rezervniDioZaIzmjenu == null)
            {
                if (ValidacijaForme() == true)
                {
                    float cijena = 0;
                    if (float.TryParse(txtCijena.Text, out cijena))
                    {
                        noviRezervniDio.DodajNoviRezervniDio(txtNaziv.Text, cijena);
                        MessageBox.Show("Rezervni dio je uspješno dodan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cijena mora biti broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                if (ValidacijaForme() == true)
                {
                    float cijena = 0;
                    if (float.TryParse(txtCijena.Text, out cijena))
                    {
                        noviRezervniDio.IzmjeniRezervniDio(rezervniDioZaIzmjenu, txtNaziv.Text, cijena);
                        MessageBox.Show("Rezervni dio je uspješno izmjenjen!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cijena mora biti broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FrmNoviRezervniDio_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
