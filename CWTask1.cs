
using System;

struct Disiple
{
    public string Name;
    public int Age;
    public int[] Grades;
    public double AverageGrade;
    public bool StraightAStudent;
    private double CalculateAverageGrade()
    {
        int summ = 0;
        foreach (int grades in Grades)
        {
            summ += grades;
        }
        return (double)summ / Grades.Length;
    }

    public Disiple(string name, int age, int[] grades, double averagegrade)
    {
        Name = name;
        Age = age;
        Grades = grades;
        AverageGrade = averagegrade;
        StraightAStudent = true;
        
    }
    public void DisplayInfo()
    {
        bool status;
        if(AverageGrade>4.5)
        {
            status = StraightAStudent;
        }
        else
        {
            status = false;
        }
      if(status==true)
        {
            Console.WriteLine($"{Name} {Age} {AverageGrade} {status}");
        }
       else
        {
            Console.WriteLine($"{Name} {Age} {AverageGrade} ");
        }
}
class Program
{
    static void Main()
    {
        double[] grades1 = new double[5] { 2, 4, 5, 5, 3 };
        double[] grades2 = new double[5] { 3, 3, 5, 4, 3 };
        double[] grades3 = new double[5] { 5, 5, 4, 5, 3 };
        double[] grade4 = new double[5]  {4, 3, 2, 5, 5 };
            
    }

    }