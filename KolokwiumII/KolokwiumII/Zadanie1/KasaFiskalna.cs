using System;
using System.Collections.Generic;
using System.Text;

namespace KolokwiumII
{
    class KasaFiskalna
    {
        public double SumaZamowienia { get; set; }
        public Stack<double> HistoriaZamowien { get; set; }

        public KasaFiskalna()
        {
            SumaZamowienia = 0;
            HistoriaZamowien = new Stack<double>();
        }

        public void PrzyjmijZamowienie(string zamowienie)
        {
            if(zamowienie.Length==1 && zamowienie[0]=='Z')
            {
                HistoriaZamowien.Pop();
                try
                {
                    HistoriaZamowien.Peek();
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine("Historia zamówień jest pusta");
                }
            }
            else
            {
                try
                {
                    double cena = Convert.ToDouble(zamowienie);
                    HistoriaZamowien.Push(cena);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Błędna sekwencja kodu zamówienia");
                }
                
            }
        }

        
    }
}
