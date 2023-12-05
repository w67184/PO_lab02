using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Liczba
{
    public int[] Dziesietne;
    public int size;
    public Liczba(string liczba)
    {
        Dziesietne = new int[liczba.Length];
        size = liczba.Length;

        for (int i = 0; i < liczba.Length; i++)
        {
            Dziesietne[i] = int.Parse(liczba[i].ToString());
        }
    }
    public void Wypisz()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(Dziesietne[i]);
        }

        Console.WriteLine();
    }
    public void Nadaj(string liczba)
    {
        Dziesietne = new int[liczba.Length];
        size = liczba.Length;

        for (int i = 0; i < liczba.Length; i++)
        {
            Dziesietne[i] = int.Parse(liczba[i].ToString());
        }
    }
    public void Pomnoz(int mnoznik)
    {
        BigInteger wynik = ToBigInteger() * mnoznik;

        string wynikString = wynik.ToString();
        Dziesietne = new int[wynikString.Length];
        size = wynikString.Length;

        for (int i = 0; i < wynikString.Length; i++)
        {
            Dziesietne[i] = int.Parse(wynikString[i].ToString());
        }
    }
    private BigInteger ToBigInteger()
    {
        string liczbaString = "";

        for (int i = 0; i < size; i++)
        {
            liczbaString += cyfry[i];
        }

        return BigInteger.Parse(liczbaString);
    }
    public BigInteger Silnia()
    {
        BigInteger wynik = 1;

        for (BigInteger i = 2; i <= ToBigInteger(); i++)
        {
            wynik *= i;
        }

        return wynik;
    }
}