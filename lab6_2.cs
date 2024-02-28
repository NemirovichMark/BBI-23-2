
using System;
using System.Xml.Linq;

struct Student
{
    private string _Name;
    private string _Surname;
    private int _Math;
    private int _Phys;
    private int _Russ;


    public string Name => _Name;
    public string Surname => _Surname;
    public int Math => _Math;
    public int Phys => _Phys;
    public int Russ => _Russ;
    public double Average => (_Math + _Phys + _Russ) / 3.0;

    public Student(string name, string surname, int math, int phys, int russ)
    {
        _Name = name;
        _Surname = surname;
        _Math = math;
        _Phys = phys;
        _Russ = russ;

        if (math == 2 ^ russ == 2 ^ phys == 2)
        {
            _Math = 0;
            _Russ = 0;
            _Phys = 0;
        }
    }

    public void Print()
    {
        Console.WriteLine($"{_Name} {_Surname} - средний балл: {Average}");
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[5]
        {
            new Student("Ivan", "Ivanov", 3, 4, 5),
            new Student("Igor", "Igorev", 4, 5, 4),
            new Student("Volga", "Motors", 5, 5, 5),
            new Student("Erik", "Davidov", 2, 3, 4),
            new Student("Face", "Eshkere", 4, 3, 2),
        };

        Student[] successfulStudents = new Student[students.Length];
        int successfulCount = 0;

        foreach (var student in students)
        {
            if (student.Average >= 3.5)
            {
                successfulStudents[successfulCount] = student;
                successfulCount++;
            }
        }

        for (int i = 0; i < successfulCount - 1; i++)
        {
            for (int j = 0; j < successfulCount - 1 - i; j++)
            {
                if (successfulStudents[j].Average < successfulStudents[j + 1].Average)
                {
                    var temp = successfulStudents[j];
                    successfulStudents[j] = successfulStudents[j + 1];
                    successfulStudents[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Отсортированный список успешно сдавших экзамены учащихся:");
        for (int i = 0; i < successfulCount; i++)
        {
            successfulStudents[i].Print();
        }
        Console.ReadKey();
    }
}