using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumII
{
    class Flamaster : IPisanie
    {
        public string Tekst {get;set;}
        public Dictionary<string, string> Rysunki;

        public Flamaster()
        {
            Tekst = new string("");
            Rysunki = new Dictionary<string, string>();
        }

        public Flamaster(string tekst)
        {
            Tekst = tekst;
        }

        public void Pisz(string tekst)
        {
            Tekst += tekst;
        }

        public void Rysuj(string tytul)
        {
            Rysunki.Add(tytul, Tekst);
        }
}
}
