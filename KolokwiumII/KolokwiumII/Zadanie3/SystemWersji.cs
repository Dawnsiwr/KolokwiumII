using KolokwiumII.Zadanie3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KolokwiumII
{
    class SystemWersji
    {
        public int Id { get; }
        private double NrWersji { get; set; }

        public Dzielo Dzielo;

        public SystemWersji()
        {
            Id = new Random().Next(100);
            Dzielo = new Dzielo();
            NrWersji = 0;
        }

        public void NowaWersja(string nowaTresc, string opisZmian)
        {
            Dzielo.Tresc = nowaTresc;
            NrWersji++;
            string zapis = "[" + DateTime.Now + "][" + NrWersji + "] - [" + opisZmian + "]";
            

            using (StreamWriter outputFile = new StreamWriter("changelog.txt"))
            {
                outputFile.WriteLine(zapis);
            }
        }
    }
}
