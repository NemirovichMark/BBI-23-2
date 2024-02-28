using System;
public struct Student
{
    private string _name;
    private int _mark;
    private int _missed;

    public Student(string name, int mark, int missed)
    {
        _name = name;
        _mark = mark;
        _missed = missed;
    }

    public int mark => _mark;

    public int missed => _missed;

    public void Print()
    {
        Console.WriteLine($"{_name} {_mark} {_missed}");
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[5]
        {
                new Student("Иван", 5, 6),
                new Student("Сергей", 2, 7),
                new Student("Коля", 2, 8),
                new Student("Виктория", 2, 10),
                new Student("Александра", 4, 1)
        };
        int fails = 0;
        for (int i = 0; i < students.Length; i++)
            if (students[i].mark == 2)
                fails++;
        Student[] failstud = new Student[fails];
        int j = 0;
        for (int i = 0; i < students.Length; i++)
            if (students[i].mark == 2)
            {
                failstud[j] = students[i];
                j++;
            }
        for (int i = 0; i < failstud.Length - 1; i++)
        {
            for (int k = 0; k < failstud.Length - i - 1; k++)
            {
                if (failstud[k].missed < failstud[k + 1].missed)
                {
                    Student temp = failstud[k];
                    failstud[k] = failstud[k + 1];
                    failstud[k + 1] = temp;
                }
            }
        }
        Console.WriteLine("студенты с неудовлетворильной оценкой:");
        for (int i = 0; i < failstud.Length; i++)
        {
            failstud[i].Print();
        }
    }
}