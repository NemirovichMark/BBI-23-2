using System;
struct Struct1
{
    public string famile;
    public double rez;
    public double[] x;
    public Struct1(string famile1, double[] x1)
    {
        famile = famile1;
        x = x1;
        rez = x[0];
        for (int i = 1; i < 3; i = i + 1)
            if (x[i] > rez)
            {
                rez = x[i];
            }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Struct1[] c1 = new Struct1[5];
        c1[0] = new Struct1("Борисов", new double[] { 15.7, 7.5, 16.0 });
        c1[1] = new Struct1("Петров", new double[] { 16.7, 9.5, 18.0 });
        c1[2] = new Struct1("Иванов", new double[] { 19.7, 2.5, 15.0 });
        c1[3] = new Struct1("Николаев", new double[] { 20.7, 5.5, 13.0 });
        c1[4] = new Struct1("Андреев", new double[] { 12.7, 9.5, 20.0 });
        for (int i = 0; i < c1.Length - 1; i = i + 1)
        {
            double amax = c1[i].rez;
            int imax = i;
            for (int j = i + 1; j < c1.Length; j = j + 1)
            {
                if (c1[j].rez > amax)
                {
                    amax = c1[j].rez;
                    imax = j;
                }
            }
            Struct1 temp;
            temp = c1[imax];
            c1[imax] = c1[i];
            c1[i] = temp;
        }
        Console.WriteLine();
        for (int i = 0; i < c1.Length; i = i + 1)
            Console.WriteLine("Фамилия {0}\t" + "Лучший результат {1,4:f2}", c1[i].famile, c1[i].rez);
    }
}