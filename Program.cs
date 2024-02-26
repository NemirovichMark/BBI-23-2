// See https://aka.ms/new-console-template for more information

///1 level 2 task
using System;
struct Sportsmen
{
    public string name;
    public string surname;
    public string group;
    public string tutor;
    public double result;
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
            sp[i].name = n[i];
            sp[i].surname = s[i];
            sp[i].group = g[i];
            sp[i].tutor = t[i];
            sp[i].result = r[i];
            Console.WriteLine($"Имя {sp[i].name}," +
                $" Фамилия {sp[i].surname}, Группа {sp[i].group}, " +
                $"Тренер {sp[i].tutor}, Результат {sp[i].result}.");
        }
        for (int i = 0; i < sp.Length; i++)
        {
            double max = double.MinValue;
            int index = i;
            for (int j = i + 1; j < sp.Length; j++)
            {
                if (sp[j].result > max)
                {
                    max = sp[j].result;
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
            Console.WriteLine($"Имя {sp[i].name}," +
                $" Фамилия {sp[i].surname}, Группа {sp[i].group}, " +
                $"Тренер {sp[i].tutor}, Результат {sp[i].result}.");
        }
    }
}

/// 2 level 1 task

using System;
struct Student
{
    public string surname;
    public double[] x;
    public double sum;
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

        for (int i = 0; i < sp.Length; i++)
        {
            Console.WriteLine($"Имя {sp[i].surname}, Средний балл - {sp[i].sum}");
        }

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
class Group
{
    public string Name { get; set; }
    private int[] examScores;

    public Group(string name, int[] scores)
    {
        Name = name;
        examScores = scores;
    }

    public int[] ExamScores
    {
        get { return examScores; }
        set { examScores = value; }
    }

    public double AverageScore
    {
        get
        {
            int sum = 0;
            foreach (int score in examScores)
            {
                sum += score;
            }
            return (double)sum / examScores.Length;
        }
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
            Console.WriteLine($"| {group.Name,-7} | {group.AverageScore,-13:F2} |");
        }
    }

    static void Sort(Group[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].AverageScore < arr[j + 1].AverageScore)
                {
                    Group temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
