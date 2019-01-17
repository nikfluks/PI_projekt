using Pomoc_aplikacije;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    public partial class FrmNovoMjesto : Form
    {
        NovoMjesto novoMjesto;
        public FrmNovoMjesto()
        {
            InitializeComponent();
            novoMjesto = new NovoMjesto(this);
        }

        private void FrmNovoMjesto_Load(object sender, EventArgs e)
        {
            mjestoBindingSource.DataSource = novoMjesto.OsvjeziMjesta();
        }

        private void btnDodajMjesto_Click(object sender, EventArgs e)
        {
            if(ValidirajFormu())
            {
                if(txtPostanskiBroj.Text.Trim().Length == 5)
                {
                    try
                    {
                        novoMjesto.DodajNovoMjesto(int.Parse(txtPostanskiBroj.Text), txtNaziv.Text);
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Poštanski broj mora biti broj !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Poštanski broj mora imati 5 brojeva !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajFormu()
        {
            bool ispravno = true;
            if(txtNaziv.Text.Trim().Length == 0)
                ispravno = false;
            if(txtPostanskiBroj.Text.Trim().Length == 0)
                ispravno = false;
            return ispravno;
        }

        private void btnPrikazSvihMjesta_Click(object sender, EventArgs e)
        {
            if(btnPrikazSvihMjesta.Text == "Prikaži sva mjesta")
            {
                this.Size = new Size(650, 245);
                btnPrikazSvihMjesta.Text = "Sakrij prikaz";
            }
            else
            {
                this.Size = new Size(315, 245);
                btnPrikazSvihMjesta.Text = "Prikaži sva mjesta";
            }
        }

        private void FrmNovoMjesto_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc.PrikaziPomoc(this);
        }
    }
}
