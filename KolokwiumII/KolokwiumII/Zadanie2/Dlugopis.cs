using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumII
{
    class Dlugopis : IPisanie
    {
        public string Tekst { get; set; }
        public ConsoleColor Kolor { get; set; }

        public Dlugopis()
        {
            Tekst = new string("");
            Kolor = ConsoleColor.Green;
        }

        public Dlugopis(string tekst)
        {
            Tekst = tekst;
        }
    public void Pisz(string tekst)
        {
            Tekst += tekst;
        }
    }
}
