//1 номер
using System;

public struct Point
{
    public int X;
    public int Y;

    public Point(int[] coordinates)
    {
        X = coordinates[0];
        Y = coordinates[1];
    }

    public double DistanceTo(Point otherPoint)
    {
        return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
    }

    public static void PrintPointInfo(Point point1, Point point2)
    {
        double distance = point1.DistanceTo(point2);
        Console.WriteLine($"Точка 1: ({point1.X}, {point1.Y})");
        Console.WriteLine($"Точка 2: ({point2.X}, {point2.Y})");
        Console.WriteLine($"Расстояние между точками: {distance:F2}\n");
    }
}

class Program
{
    static void Main()
    {
        Point[] points = new Point[]
        {
            new Point(new int[] {1, 2}),
            new Point(new int[] {3, 6}),
            new Point(new int[] {5, 8})
        };

        Console.WriteLine("Информация о каждой паре точек:");
        Console.WriteLine();

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point.PrintPointInfo(points[i], points[j]);
            }
        }
    }
}




////2 номер
//using System;



//public abstract class Profession
//{
//    public string Name { get; set; }
//    public string Title { get; set; }
//    public double ExperienceBonus { get; set; }

//    public abstract double CalculateSalary();
//}

//public class Fireman : Profession
//{
//    public double DangerBonus { get; set; }

//    public Fireman(string name,string title, double experienceBonus, double dangerBonus)
//    {
//        Name = name;
//        Title = title;
//        ExperienceBonus = experienceBonus;
//        DangerBonus = dangerBonus;
//    }

//    public override double CalculateSalary()
//    {
//        return 2000 + ExperienceBonus * 100 + DangerBonus * 150;
//    }
//}

//public class Engineer : Profession
//{
//    public int Category { get; set; }

//    public Engineer(string name,string title, double experienceBonus, int category)
//    {
//        Name = name;
//        Title = title;
//        ExperienceBonus = experienceBonus;
//        Category = category;
//    }

//    public override double CalculateSalary()
//    {
//        return 2500 + ExperienceBonus * 120 + Category * 200;
//    }
//}

//public class Scientist : Profession
//{
//    public string Degree { get; set; }

//    public Scientist(string name, string title, double experienceBonus, string degree)
//    {
//        Name = name;
//        Title = title;
//        ExperienceBonus = experienceBonus;
//        Degree = degree;
//    }

//    public override double CalculateSalary()
//    {
//        return 3000 + ExperienceBonus * 150 + (Degree == "PhD" ? 500 : 0);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Profession[] employees = new Profession[]
//        {
//            new Fireman("John","Fireman", 5.5, 2),
//            new Fireman("Michel","Fireman", 3.5, 3),
//            new Engineer("Bob","Engineer", 4.5, 2),
//            new Engineer("Arnold","Engineer", 6.0, 3),
//            new Scientist("Scientist","Scientist", 7.0, "PhD"),
//            new Fireman("Bobby","Fireman", 5.0, 2),
//            new Fireman("Victor","Fireman", 3.0, 3),
//            new Engineer("Simon","Engineer", 5.5, 2),
//            new Engineer("Gustavo","Engineer", 6.0, 3),
//            new Scientist("Petya","Scientist", 7.5, "Professor"),
//            new Fireman("Sasha","Fireman", 5.0, 3),
//            new Fireman("Saul","Fireman", 4.0, 3),
//            new Engineer("Brandon","Engineer",5.5, 2),
//            new Engineer("Jeremy","Engineer", 6.0, 2),
//            new Scientist("Pit","Scientist", 8.0, "PhD")
//        };

//        Console.WriteLine("Информация о зарплате работников (по убыванию):");
//        Console.WriteLine("");

//        var sortedEmployees = employees.OrderByDescending(e => e.CalculateSalary()).ToList();

//        foreach (var emp in sortedEmployees)
//        {
//            Console.WriteLine($"Профессия: {emp.Title}");
//            Console.WriteLine($"Зарплата: {emp.CalculateSalary()}$");
//            Console.WriteLine("");
//        }
//    }
//}
