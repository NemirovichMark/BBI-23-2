// See https://aka.ms/new-console-template for more information

///1 level 2 task
using System;
using Internal;

struct Sportsmen
{
    private string name;
    private string surname;
    private string group;
    private string tutor;
    private double result;

    public Sportsmen(string name, string surname, string group, string tutor, double result)
    {
        this.name = name;
        this.surname = surname;
        this.group = group;
        this.tutor = tutor;
        this.result = result;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя {name}, Фамилия {surname}, Группа {group}, Тренер {tutor}, Результат {result}.");
    }

    public double GetResult()
    {
        return result;
    }
}

class Program
{
    static void Main()
    {
        Sportsmen[] sp = new Sportsmen[5];
        string[] s = new string[] {
            "Иванова", "Петрова", "Сидорова",
            "Кузнецова", "Макарова"};
        string[] n = new string[] {
            "Катя", "Маша", "Лера",
            "Соня", "Валя"};
        string[] g = new string[] {
            "160-165", "165-170", "170-175",
            "175-180", "180-185"};
        string[] t = new string[] {
            "Наумов", "Селиванов", "Аборин",
            "Киренко", "Жидков"};
        double[] r = new double[] {1.50,
            1.55, 1.47, 1.46, 1.54};
        for (int i = 0; i < sp.Length; i++)
        {
            sp[i] = new Sportsmen(n[i], s[i], g[i], t[i], r[i]);
            sp[i].DisplayInfo();
        }

        for (int i = 0; i < sp.Length; i++)
        {
            double max = double.MinValue;
            int index = i;
            for (int j = i + 1; j < sp.Length; j++)
            {
                if (sp[j].GetResult() > max)
                {
                    max = sp[j].GetResult();
                    index = j;
                }
            }
            Sportsmen temp;
            temp = sp[index];
            sp[index] = sp[i];
            sp[i] = temp;
        }

        Console.WriteLine();
        for (int i = 0; i < sp.Length; i++)
        {
            sp[i].DisplayInfo();
        }
    }
}
 


/// 2 level 1 task
using System;
struct Student
{
    private string surname;
    private double[] x;
    private double sum;

    public Student(string surname1, double[] x1)
    {
        sum = 0;
        surname = surname1;
        x = x1;
        for (int i = 0; i < 4; i++)
        {
            sum += x[i];
        }
        sum /= 4;
        Console.WriteLine($"Имя {surname}, Средний балл - {sum}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] sp = new Student[3];
        sp[0] = new Student("Наумов", new double[] { 5.0, 5.0, 5.0, 5.0, 5.0 });
        sp[1] = new Student("Селиванов", new double[] { 2.0, 2.0, 3.0, 4.0, 4.0 });
        sp[2] = new Student("Аборин", new double[] { 5.0, 4.0, 4.0, 4.0, 4.0 });

        Console.WriteLine();

        for (int i = 0; i < sp.Length - 1; i++)
        {
            double max = sp[i].sum;
            int index = i;
            for (int j = i + 1; j < sp.Length; j++)
            {
                if (sp[j].sum > max)
                {
                    max = sp[j].sum;
                    index = j;
                }

                Student temp;
                temp = sp[index];
                sp[index] = sp[i];
                sp[i] = temp;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < sp.Length; i++)
        {
            if (sp[i].sum >= 4)
            {
                Console.WriteLine($"Имя {sp[i].surname}, Средний балл - {sp[i].sum}");
            }
        }
    }
}


/// <summary>
/// 3 level 1 task
/// </summary>
using System;

class Group
{
    public string Name { get; private set; }
    private int[] examScores;

    public Group(string name, int[] scores)
    {
        Name = name;
        examScores = scores;
    }

    public int[] GetExamScores()
    {
        return examScores;
    }

    public void SetExamScores(int[] scores)
    {
        examScores = scores;
    }

    public double GetAverageScore()
    {
        int sum = 0;
        foreach (int score in examScores)
        {
            sum += score;
        }
        return (double)sum / examScores.Length;
    }
}

class Program
{
    static void Main()
    {
        Group[] groups = new Group[3];
        groups[0] = new Group("1", new int[] { 5, 5, 5, 5, 5 });
        groups[1] = new Group("2", new int[] { 2, 2, 3, 4, 4 });
        groups[2] = new Group("3", new int[] { 5, 4, 4, 4, 4 });

        Sort(groups);

        Console.WriteLine("Average Score");
        foreach (var group in groups)
        {
            Console.WriteLine($"| {group.Name,-7} | {group.GetAverageScore(),-13:F2} |");
        }
    }

    static void Sort(Group[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].GetAverageScore() < arr[j + 1].GetAverageScore())
                {
                    Group temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}


