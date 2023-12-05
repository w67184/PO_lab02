using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sumator
{
    private int[] Liczby;

    public int Suma()
    {
        int sum = 0;
        foreach(int liczba in Liczby)
        {
            sum += liczba;
        }
        return sum;
    }
    public int SumaPodziel2()
    {
        int sumaPodziel2 = 0;

        foreach (int liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                sumaPodziel2 += liczba;
            }
        }

        return sumaPodziel2;
    }
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    public int IleElementow()
    {
        return Liczby.Length;
    }
    public void Wypisz()
    {
        Console.WriteLine("Elementy tablicy:");

        foreach (int liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }

        Console.WriteLine();
    }

    public void Zakres(int lowIndex, int highIndex)
    {
        Console.WriteLine($"Elementy w zakresie [{lowIndex}, {highIndex}]:");

        for (int i = lowIndex; i <= highIndex && i < Liczby.Length; i++)
        {
            Console.Write(Liczby[i] + " ");
        }
        Console.WriteLine();
    }


}