using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RadionicaZaVozila
{
    class RadionicaUtils
    {
        public static string KriptirajLozinku(string lozinka)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //računa hash vrijednost za tekst
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(lozinka));
            byte[] rezultat = md5.Hash;

            StringBuilder kriptirano = new StringBuilder();
            for (int i = 0; i < rezultat.Length; i++)
            {
                //svaki byte pretvara u 2 hexadecimale vrijednosti
                kriptirano.Append(rezultat[i].ToString("x2"));
            }

            return kriptirano.ToString();
        }


    }
}
