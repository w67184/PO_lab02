using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Licz
{
    private int value;

    public Licz(int startValue)
    {
        this.value = startValue;
    }
    public void dodaj(int variable)
    {
        this.value += variable;
    }
    public void odejmij(int variable)
    {
        this.value -= variable;
    }
    public void Wypisz()
    {
        Console.WriteLine("Liczba wynosi " + value);
    }
}