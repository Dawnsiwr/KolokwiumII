using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumII
{
    class Olowek : IPisanie
    {
        public string Tekst { get; set; }

        public Olowek()
        {
            Tekst = new string("");
        }

        public Olowek(string tekst)
        {
            Tekst = tekst;
        }
        public void Pisz(string tekst)
        {
            Tekst += tekst;
        }

        public void Popraw(string tekstPoprawiony)
        {
            Tekst = new string(tekstPoprawiony);
        }
    }
}
