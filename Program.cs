using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Licz liczba1 = new Licz(10);
            Licz liczba2 = new Licz(30);
            Licz liczba3 = new Licz(3);

            liczba1.dodaj(10);
            liczba2.odejmij(5);
            liczba3.odejmij(1);

            liczba1.Wypisz();
            liczba2.Wypisz();
            liczba3.Wypisz();

            Console.WriteLine("\n\nZad 2");

            int[] liczbyy = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Sumator sumator = new Sumator(liczbyy);

            int iloscElementow = sumator.IleElementow();
            Console.WriteLine("Liczba elementow w tablicy: " + iloscElementow);

            sumator.Wypisz();

            sumator.Zakres(2, 9);

            Console.WriteLine("\n\nZad 3");

            MyData gdata = new MyData(2023, 11, 25);

            gdata.OdczytajDate();

            gdata.PrzesunDate();

            gdata.PrzesunDateBefore();
        }
    }
}
