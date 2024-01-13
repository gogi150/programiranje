using System;

public class PrvaKlasa
{
    private static int counter;

    public PrvaKlasa()
    {
        counter++;
    }

    public static int Counter
    {
        get { return counter; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PrvaKlasa x = new PrvaKlasa();
        PrvaKlasa y = new PrvaKlasa();
        PrvaKlasa z = new PrvaKlasa();

        Console.WriteLine(PrvaKlasa.Counter);
    }
}