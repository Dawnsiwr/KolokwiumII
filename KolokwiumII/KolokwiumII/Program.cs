using System;

namespace KolokwiumII
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadanie 1
            KasaFiskalna kasaFiskalna = new KasaFiskalna();
            kasaFiskalna.PrzyjmijZamowienie("100");
            
            kasaFiskalna.PrzyjmijZamowienie("Z");
            kasaFiskalna.PrzyjmijZamowienie("Zzzz");
            kasaFiskalna.PrzyjmijZamowienie("200");
            foreach (var item in kasaFiskalna.HistoriaZamowien)
            {
                Console.WriteLine(item);
            }


            //Zadanie2
            Dlugopis dlugopis = new Dlugopis();
            Olowek olowek = new Olowek();
            Flamaster flamaster = new Flamaster();

            dlugopis.Pisz("Słoneczniki");
            Console.ForegroundColor = dlugopis.Kolor;
            Console.WriteLine(dlugopis.Tekst, dlugopis.Kolor);
            Console.ForegroundColor = ConsoleColor.Gray;

            olowek.Pisz("Słoneczniki");
            olowek.Popraw("Kwiaty");
            Console.WriteLine(olowek.Tekst);

            flamaster.Pisz("Słoneczniki");
            flamaster.Rysuj("Obraz");
            foreach(var obraz in flamaster.Rysunki)
            {
                Console.WriteLine(obraz.Key + " | " + obraz.Value);
            }

            //Zadanie3

            SystemWersji systemWersji = new SystemWersji();
            systemWersji.NowaWersja("Programowanie", "Zmiana tytułu na nowy");

        }
    }
}
