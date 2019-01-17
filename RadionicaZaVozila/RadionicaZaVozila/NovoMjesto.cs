using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadionicaZaVozila
{
    class NovoMjesto
    {
        private FrmNovoMjesto formaZaZatvaranje;

        public NovoMjesto(FrmNovoMjesto formaZaZatvaranje)
        {
            this.formaZaZatvaranje = formaZaZatvaranje;    
        }

        private bool JelPostojiPostanskiBroj(int postanskiBroj)
        {
            bool postoji = false;
            Mjesto novoMjesto = null;
            using (var db = new ProjektEntities())
            {
                try
                {
                    novoMjesto = (from m in db.Mjesto
                                  where m.postanskiBroj == postanskiBroj
                                  select m).First<Mjesto>();
                }
                catch (InvalidOperationException)
                {
                    postoji = false;
                }
            }
            if (novoMjesto != null)
            {
                postoji = true;
            }
            return postoji;
        }

        public void DodajNovoMjesto(int noviPostanskiBroj, string noviNaziv)
        {
            if(JelPostojiPostanskiBroj(noviPostanskiBroj) == false)
            {
                using (var db = new ProjektEntities())
                {
                    Mjesto novoMjesto = new Mjesto
                    {
                        naziv = noviNaziv,
                        postanskiBroj = noviPostanskiBroj
                    };

                    db.Mjesto.Add(novoMjesto);
                    db.SaveChanges();
                }
                MessageBox.Show("Novo mjesto je uspješno dodano.", "Uspješna akcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formaZaZatvaranje.Close();
            }
            else
            {
                MessageBox.Show("Mjesto s takvim poštanskim brojem već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public BindingList<Mjesto> OsvjeziMjesta()
        {
            BindingList<Mjesto> listaMjesta = null;
            using (var db = new ProjektEntities())
            {
                listaMjesta = new BindingList<Mjesto>(db.Mjesto.ToList());
            }

            return listaMjesta;
        }
    }
}
