namespace ConsoleApp2;

public abstract class Kontener
{
    protected Kontener(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, NumerSeryjny numerSeryjny, int maksymalnaLadownosc)
    {
        this.masaLadunku = masaLadunku;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numerSeryjny = numerSeryjny;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
    }

    protected int masaLadunku { get; set; }
    protected int wysokosc { get; set; }
    protected int wagaWlasna { get; set; }
    protected int glebokosc { get; set; }
    protected NumerSeryjny numerSeryjny { get; set; }
    protected int maksymalnaLadownosc { get; set; }


    public void Unload()
    {
        masaLadunku = 0;
    }

    public void Load(int waga)
    {
        masaLadunku = waga;
        checkWeight();
    }

    public void checkWeight()
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            Console.WriteLine("Wyrzuci blad!");
        }
    }
    
    


}