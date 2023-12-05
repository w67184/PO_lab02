using System;

class MyData
{
    public int rok;
    public int miesiac;
    public int dzien;

    public MyData(int rok, int miesiac, int dzien)
    {
        this.rok = rok;
        this.miesiac = miesiac;
        this.dzien = dzien;
    }

    public void OdczytajDate()
    {
        Console.WriteLine($"data: {rok}-{miesiac}-{dzien}");
    }

    public void PrzesunDate()
    {
        dzien += 7;

        while (dzien > DniWMiesiacu(miesiac, rok))
        {
            dzien -= DniWMiesiacu(miesiac, rok);
            miesiac++;

            if (miesiac > 12)
            {
                miesiac = 1;
                rok++;
            }
        }

        if (miesiac > 12)
        {
            miesiac = 1;
            rok++;
        }

        Console.WriteLine($"Data po przesunięciu o tydzień do przodu: {rok}-{miesiac}-{dzien}");
    }

    public void PrzesunDateBefore()
    {
        dzien -= 7;

        while (dzien < 1)
        {
            if (miesiac == 1)
            {
                miesiac = 12;
                rok--;
            }
            else
            {
                miesiac--;
            }

            dzien += DniWMiesiacu(miesiac, rok);
        }

        if (miesiac < 1)
        {
            miesiac = 12;
            rok--;
        }

        Console.WriteLine($"Data po przesunięciu o tydzień do tyłu: {rok}-{miesiac}-{dzien}");
    }

    private int DniWMiesiacu(int miesiac, int rok)
    {
        switch (miesiac)
        {
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return (CzyRokPrzestepny(rok)) ? 29 : 28;
            default:
                return 31;
        }
    }

    private bool CzyRokPrzestepny(int rok)
    {
        return (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0));
    }
}