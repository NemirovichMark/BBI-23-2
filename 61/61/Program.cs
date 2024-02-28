using System;
using System.Runtime.InteropServices;


class Program
{
    struct Sportsman
    {
        public string family;
        public double rez1;
        public double rez2;
    }

    static void printSportsmans(Sportsman[] sp)
    {
        Console.WriteLine();
        for (int i = 0; i < sp.Length; i++)
        {
            Console.WriteLine(
                "Фамилия {0} \t => 1: {1:f2} \t 2: {2:f2}",
                sp[i].family, sp[i].rez1, sp[i].rez2);
        }
    }

    static bool sp1IsBetterSp2(Sportsman sp1, Sportsman sp2)
    {
        
        double max1 = Math.Max(sp1.rez1, sp1.rez2);
        double max2 = Math.Max(sp2.rez1, sp2.rez2);

       
        if (max1 > max2)
            return true;

        if (max1 < max2)
            return false;

       
        double min1 = Math.Min(sp1.rez1, sp1.rez2);
        double min2 = Math.Min(sp2.rez1, sp2.rez2);

        return min1 > min2;
    }

    static void Main()
    {
        Sportsman[] sp = new Sportsman[5];
        string[] s = new string[] { "Иванов", "Петров", "Стопов", "Борцов", "Носков"};
        double[] r1 = new double[] {1.50, 1.55, 1.47, 1.46, 1.54};
        double[] r2 = new double[] {1.55, 1.40, 1.42, 1.60, 1.20};

        for (int i = 0; i < sp.Length; i++)
        {
            sp[i].family = s[i];
            sp[i].rez1 = r1[i];
            sp[i].rez2 = r2[i];
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
    }
}
