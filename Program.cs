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
        }
    }
}
