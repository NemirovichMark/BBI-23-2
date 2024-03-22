// first task
//using System;
//struct Point
//{
//    private double x;
//    private double y;

//    public Point(double x, double y)
//    {
//        this.x = x;
//        this.y = y;
//    }
//    public double CalculatedPoint(Point otherPoint)
//    {
//        return Math.Sqrt(Math.Pow(x - otherPoint.x, 2) + Math.Pow(y + otherPoint.y, 2));
//    }
//    public void DisInfo()
//    {
//        Console.WriteLine($"( {x} : {y} )");
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Point[] points = new Point[3];
//        {
//            points[0] = new Point(0, 0);
//            points[1] = new Point(4.1, 2);
//            points[2] = new Point(1, 5.5);

//            for (int i = 0; i < points.Length; i++)
//            {
//                for (int j = i + 1; j < points.Length; j++)
//                {
//                    Pointi(points[i], points[j]);
//                }
//            }
//        }
//        static void Pointi(Point p1, Point p2)
//        {
//            Console.Write("Первая точка:");
//            p1.DisInfo();
//            Console.Write("Вторая точка:");
//            p2.DisInfo();
//            Console.Write("Растояние между точками ");
//            Console.WriteLine(p1.CalculatedPoint(p2));
//            Console.WriteLine();
//        }

//    }
//}

//using System;

//abstract class Profession
//{
//    private string name;
//    private double nodbavka_za_stag;
//    private double zp;

//    public Profession(string name, double nodbavka_za_stag, double zp)
//    {
//        this.name = name;
//        this.nodbavka_za_stag = nodbavka_za_stag;
//        this.zp = zp;
//    }

//    public virtual double CalculatedZp()
//    {
//        return zp * nodbavka_za_stag;
//    }
//}


//second task
using System;

public abstract class Profession
{
    private string name;
    private double bonus_stag;
    private double zp;

    public Profession(string name, double bonus, double zp)
    {
        this.name = name;
        this.bonus_stag = bonus;
        this.zp = zp;
    }

    public abstract double CalculateZp();

    public double GetZp()
    {
        return zp;
    }

    public double GetBonusStag()
    {
        return bonus_stag;
    }
    public class Fireman : Profession
    {
        private double dangerBonus;

        public Fireman(string name, double bonus_stag, double zp, double dangerBonus) : base(name, bonus_stag, zp)
        {
            this.dangerBonus = dangerBonus;
        }
        public double GetBonusDanger()
        {
            return dangerBonus;
        }
        public override double CalculateZp()
        {
            return GetBonusDanger() + GetBonusStag() + GetZp();
        }
    }
    public class Engineer : Profession
    {
        private double category;

        public Engineer(string name, double bonus_stag, double zp, double category) : base(name, bonus_stag, zp)
        {
            this.category = category;
        }
        public double GetCategory()
        {
            return category;
        }
        public override double CalculateZp()
        {
            return GetCategory() + GetBonusStag() + GetZp();
        }
    }
    public class Scientist : Profession
    {
        private double stepen;

        public Scientist(string name, double bonus_stag, double zp, double stepen) : base(name, bonus_stag, zp)
        {
            this.stepen = stepen;
        }
        public double GetStepen()
        {
            return stepen;
        }
        public override double CalculateZp()
        {
            return GetStepen() + GetBonusStag() + GetZp();
        }
    }
}

class Program
{
    static void Main()
    {
        Profession[] worker = new Profession[3];
        {
            worker[0] = new Profession("Слесарь"0, 0);
            worker[1] = new Profession("Врач", 4, 5);
            worker[2] = new Profession("Пожарный", 1, 7);
        }

    }
}
