using System;
struct SimpleDate
{
    public double den { get; }
    public double mes { get; }
    public double god { get; }


    public static double nazvanie(SimpleDate vis, SimpleDate normal, SimpleDate kolden, SimpleDate den)
    {
        if ((double kolden % 4 == 0) and(double kolden % 400 == 0) and(double kolden % 100 != 0))
            return vis;
        else
            return normal;
    }

    public static void nazvanie(SimpleDate vis, SimpleDate normal, SimpleDate kolden, SimpleDate den)
    {
        Console.WriteLine($"День: ({den})");
        Console.WriteLine($"Месяц: ({mes})");
        Console.WriteLine($"Название года: {nazvanie}");
        Console.WriteLine();
    }
}

class Program
    {
        static void Main()
        {
            SimpleDate[] gods = new SimpleDate[10];
            gods[0] = new SimpleDate(new double[] { 12, 12, 2012});
            gods[0] = new SimpleDate(new double[] { 5, 8, 2020 });
            gods[0] = new SimpleDate(new double[] { 31, 6, 1999 });
            gods[0] = new SimpleDate(new double[] { 15, 1, 1995 });
            gods[0] = new SimpleDate(new double[] { 7, 7, 2009 });

        }
    }