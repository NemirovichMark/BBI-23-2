using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

 class Sportsman
{
    private string _family;
    private double[] _rez1;
    private double[] _rez2;

    public string family { get { return _family; } }
    public double[] rez1 { get { return _rez1; } }
    public double[] rez2 { get { return _rez2; } }

    public Sportsman(string family, double[] rez1, double[] rez2)
    {
        _family = family;
        _rez1 = rez1;
        _rez2 = rez2;
    }
    static string joinScores(double[] scores)
    {
        string[] formattedValues = new string[scores.Length];
        for (int i = 0; i < scores.Length; i++)
            formattedValues[i] = scores[i].ToString("0.00");

        return string.Join(", ", formattedValues) + " = " + scores.Sum().ToString("00.00");
    }
    public void printRez()
    {
          Console.WriteLine(
                "Фамилия {0} \t => 1: {1} \t 2: {2}",
                family, joinScores(rez1), joinScores(rez2));
  
    }
}

abstract class Diving
{
    public string Name { get; set; }
    public Sportsman[] sportsmens { get; }

    public Diving(string name, int participantsCount)
    {
        Name = name;
        sportsmens = new Sportsman[participantsCount];
    }
    public void printRez()
    {
        Console.WriteLine(Name);
        for(int i = 0; i < sportsmens.Length; i++)
            sportsmens[i].printRez();
    }
}

class ThreeMetre : Diving
{
    public ThreeMetre(int participantsCount)
        : base("Прыжки на 3 метра", participantsCount)
    {
    }
    
}
class FiveMetre : Diving
{
    public FiveMetre(int participantsCount)
        : base("Прыжки на 5 метров", participantsCount)
    {
    }
}


class Program
{


    static void printSportsmans(Sportsman[] sp)
    {
        Console.WriteLine();
        for (int i = 0; i < sp.Length; i++)
        {
            sp[i].printRez();
        }
    }

    static bool sp1IsBetterSp2(Sportsman sp1, Sportsman sp2)
    {

        double max1 = Math.Max(sp1.rez1.Sum(), sp1.rez2.Sum());
        double max2 = Math.Max(sp2.rez1.Sum(), sp2.rez2.Sum());


        if (max1 > max2)
            return true;

        if (max1 < max2)
            return false;

        double min1 = Math.Min(sp1.rez1.Sum(), sp1.rez2.Sum());
        double min2 = Math.Min(sp2.rez1.Sum(), sp2.rez2.Sum());


        return min1 > min2;
    }

    static void Main()
    {
        Sportsman[] sp = new Sportsman[5];
        string[] s = new string[] { "Иванов", "Петров", "Стопов", "Борцов", "Носков" };

        Random rand = new Random();

        for (int i = 0; i < sp.Length; i++)
        {
            double[] rez1 = new double[5];
            for (int index = 0; index < 5; ++index)
                rez1[index] = rand.NextDouble() * 10;

            double[] rez2 = new double[5];
            for (int index = 0; index < 5; ++index)
                rez2[index] = rand.NextDouble() * 10;

            sp[i] = new Sportsman(s[i], rez1, rez2);
        }

        printSportsmans(sp);


        for (int i = 0; i < sp.Length - 1; i++)
        {
            Sportsman spMax = sp[i];
            int imax = i;
            for (int j = i + 1; j < sp.Length; j++)
            {
                if (sp1IsBetterSp2(sp[j], spMax))
                {
                    spMax = sp[j];
                    imax = j;
                }
            }

            Sportsman temp;
            temp = sp[imax];
            sp[imax] = sp[i];
            sp[i] = temp;
        }

        printSportsmans(sp);


        ThreeMetre threeCompetition = new ThreeMetre(3) ;
        for (int i = 0; i < 3; i++)
            threeCompetition.sportsmens[i] = sp[i];
        FiveMetre fiveCompetition = new FiveMetre(2);
        for (int i = 3; i < 5; i++)
            fiveCompetition.sportsmens[i - 3] = sp[i];
        threeCompetition.printRez();
        fiveCompetition.printRez();
    }
}
