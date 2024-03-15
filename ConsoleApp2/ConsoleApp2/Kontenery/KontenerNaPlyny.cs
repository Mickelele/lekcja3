using System.Security.Policy;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2;

public class KontenerNaPlyny : Kontener, IHazardNotifier
{
    public KontenerNaPlyny(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc) : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        numerSeryjny = new NumerSeryjny("KON","L");
    }

    public void warning(string msg)
    {
        Console.WriteLine(numerSeryjny.getNumerSeryjny() + ": " + msg);
    }
    
    
    
}