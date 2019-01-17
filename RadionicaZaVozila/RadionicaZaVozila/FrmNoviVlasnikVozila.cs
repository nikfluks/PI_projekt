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
    public partial class FrmNoviVlasnikVozila : Form
    {
        NoviVlasnikVozila noviVlasnikVozila;
        private VlasnikVozila odabraniVlasnik;


        public FrmNoviVlasnikVozila(VlasnikVozila odabraniVlasnik = null)
        {
            InitializeComponent();
            noviVlasnikVozila = new NoviVlasnikVozila(this);
            this.odabraniVlasnik = odabraniVlasnik;
        }

        private void FrmNoviKlijent_Load(object sender, EventArgs e)
        {
            PrikazMjesta();
            comboSpol.SelectedItem = "M";

            if (odabraniVlasnik != null)
            {
                txtOIB.Text = odabraniVlasnik.OIB;
                txtPrezime.Text = odabraniVlasnik.prezime;
                txtIme.Text = odabraniVlasnik.ime;
                dtpDatumRodenja.Value = odabraniVlasnik.datumRodenja;
                comboSpol.SelectedItem = odabraniVlasnik.spol;
                comboMjesto.SelectedValue = odabraniVlasnik.postanskiBrojMjesta;
                txtOIB.Enabled = false;
            }

        }

        private void PrikazMjesta()
        {
            BindingList<Mjesto> listaMjesta = null;
            using (var db = new ProjektEntities())
            {
                listaMjesta = new BindingList<Mjesto>(db.Mjesto.ToList());
            }
            mjestoBindingSource.DataSource = listaMjesta;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool ispravno = false;
            long oib;

            if (ProvjeraUnosa() == true)
            {
                if (txtOIB.Text.Trim().Length != 11)
                {
                    MessageBox.Show("OIB mora imati 11 znakova!", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ispravno = false;
                }
                else
                {
                    if (long.TryParse(txtOIB.Text.Trim(), out oib))
                    {
                        DateTime datumRod = dtpDatumRodenja.Value;
                        if (datumRod >= DateTime.Now)
                        {
                            MessageBox.Show("Nevaljani datum!", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ispravno = false;
                        }

                        else
                        {
                            ispravno = true;
                        }
                    }

                    else
                    {
                        MessageBox.Show("OIB mora imati samo brojeve!", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ispravno = false;
                    }

                }
            }

            else
            {
                MessageBox.Show("Nisu popunjeni svi podaci!", "Oprez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ispravno = false;
            }

            if (ispravno == true)
            {
                if (odabraniVlasnik == null)
                {
                    noviVlasnikVozila.DodajNovogVlasnikaVozila(txtOIB.Text, txtPrezime.Text, txtIme.Text, dtpDatumRodenja.Value, (string)comboSpol.SelectedItem, (int)comboMjesto.SelectedValue);
                }
                else
                {
                    noviVlasnikVozila.IzmjeniVlasnikaVozila(odabraniVlasnik, txtPrezime.Text, txtIme.Text, dtpDatumRodenja.Value, (string)comboSpol.SelectedItem, (int)comboMjesto.SelectedValue);
                }
            }

        }

        private bool ProvjeraUnosa()
        {
            bool provjera = true;

            if (txtOIB.Text.Trim() == "")
            {
                provjera = false;
            }

            if (txtPrezime.Text.Trim() == "")
            {
                provjera = false;
            }

            if (txtIme.Text.Trim() == "")
            {
                provjera = false;
            }

            return provjera;
        }

        private void btnDodajMjesto_Click(object sender, EventArgs e)
        {
            FrmNovoMjesto frmNovoMjesto = new FrmNovoMjesto();
            frmNovoMjesto.ShowDialog();
            PrikazMjesta();

        }

        private void FrmNoviVlasnikVozila_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
