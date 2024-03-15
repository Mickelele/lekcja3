namespace ConsoleApp2;

public class NumerSeryjny
{
    private string first;
    private string second;
    private static int number = 1;
    private int numer;

    public NumerSeryjny(string first, string second)
    {
        this.first = first;
        this.second = second;
        number++;
        numer = number;
    }

    public string getNumerSeryjny()
    {
        return first + "-" + second + "-" + numer;
    }

}