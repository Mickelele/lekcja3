using System.Text.RegularExpressions;
using ConsoleApp2.Exceptions;

namespace ConsoleApp2;

public abstract class Kontener
{
    protected Kontener(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc)
    {
        this.masaLadunku = masaLadunku;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        numerSeryjny = null;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
        checkWeight();
    }

    public int masaLadunku { get; set; }
    public int wysokosc { get; set; }
    public int wagaWlasna { get; set; }
    public int glebokosc { get; set; }
    public NumerSeryjny numerSeryjny { get; set; }
    public int maksymalnaLadownosc { get; set; }


    public virtual void Unload()
    {
        masaLadunku = 0;
    }

    public virtual void Load(int waga)
    {
        masaLadunku = waga;
        checkWeight();
    }

    public void checkWeight()
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException("To much weight!");
        }
    }
    
    


}