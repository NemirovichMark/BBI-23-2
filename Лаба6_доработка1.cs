using System;

struct RunnerResult
{
    private string lastName;//защищённые данные
    private string group;
    private string teacherLastName;
    private double resultInSeconds;
    private bool norm;

    public double ResultInSeconds => resultInSeconds;//помогает пользоваться мне приватным полем

    public RunnerResult(string lastName, string group, string teacherLastName, double resultInSeconds)//конструктор, помогающий пользоваться этими полями
    {
        this.lastName = lastName;
        this.group = group;
        this.teacherLastName = teacherLastName;
        this.resultInSeconds = resultInSeconds;
        this.norm = resultInSeconds <= 300;
    }

    public void PrintResult()//метод для вывода на экран конечного результата
    {
        Console.WriteLine($"{lastName}\t\t{group}\t\t{teacherLastName}\t\t{ResultInSeconds}\t\t{(norm ? "Да" : "Нет")}");
    }
}
//конструктор и структура помогают пользоваться мне приватными полями

class Program
{
    static void Main(string[] args)
    {
        // Создание массива результатов
        RunnerResult[] results = new RunnerResult[]
        {
            new RunnerResult("Перекресткова", "Группа 1", "Петров", 300),
            new RunnerResult("Пятерочкина", "Группа 2", "Сидоров", 287.89),
            new RunnerResult("Жульенова", "Группа 2", "Сидоров", 562),
            new RunnerResult("Акакиева", "Группа 3", "Сидоров", 499),

        };

        // Сортировка результатов по времени
        Array.Sort(results, (x, y) => x.ResultInSeconds.CompareTo(y.ResultInSeconds));

        // Вывод таблицы результатов
        Console.WriteLine("Фамилия\t\t         Группа\t\t  Преподаватель\t\tРезультат\t Норматив");
        foreach (var result in results)
        {
            result.PrintResult();//объявляю метод в основном коде
        }

        // Подсчет количества участниц, выполнивших норматив
        int countNorm = 0;
        foreach (var result in results)
        {
            if (result.ResultInSeconds <= 300)
                countNorm++;
        }

        Console.WriteLine($"Количество участниц, выполнивших норматив: {countNorm}");
    }

}






using System;
struct Student
{
    private string name;//защищённые данные
    private string group;
    private double[] examScores;

    public Student(string name, string group, double[] examScores)//конструктор, помогающий пользоваться этими полями
    {
        this.name = name;
        this.group = group;
        this.examScores = examScores;
    }

    public double CalculateAverageScore()
    {
        double sum = 0;
        foreach (var score in examScores)
        {
            sum += score;
        }
        return sum / examScores.Length;
    }

    public void PrintStudent()//метод для вывода на экран конечного результата
    {
        Console.WriteLine($"{name}\t\t{group}\t\t{CalculateAverageScore()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Создание массива студентов
        Student[] students = new Student[]
        {
        new Student("Чиназес", "ББИ-23-1", new double[] { 3, 3, 2, 3 }),
        new Student("Ажож", "ББИ-23-1", new double[] { 5, 5, 5, 4 }),
        new Student("Асос", "ББИ-23-1", new double[] { 3, 5, 4, 4 }),
        new Student("Роберто", "ББИ-23-1", new double[] { 5, 5, 5, 5 }),
        new Student("Ли-кой-чын", "ББИ-23-1", new double[] { 5, 3, 2, 5 }),
        new Student("Мадина", "ББИ-23-1", new double[] { 4, 4, 4, 4 }),
        };

        // Фильтрация студентов
        var filteredStudents = Array.FindAll(students, s => s.CalculateAverageScore() >= 4);

        // Сортировка студентов по среднему баллу
        Array.Sort(filteredStudents, (x, y) => y.CalculateAverageScore().CompareTo(x.CalculateAverageScore()));

        // Вывод таблицы результатов
        Console.WriteLine("Имя\t\tГруппа\t\t  Средний балл");
        foreach (var student in filteredStudents)
        {
            student.PrintStudent();
        }
    }

}






using System;

struct FootballTeam
{
    private string name;//защищённые поля
    private int group;
    private int points;
    public int Points => points;//помогает пользоваться приватными полями
    public FootballTeam(string name, int group, int points)//конструктор, помогающий пользоваться этими полями
    {
        this.name = name;
        this.group = group;
        this.points = points;
    }

    public void PrintTeam()//метод для вывода на экран конечного результата
    {
        Console.WriteLine($"{name}, Группа {group}, Очки: {Points}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Создание массива команд первого этапа
        FootballTeam[] teamsGroup1 = new FootballTeam[]
        {
        new FootballTeam("Барсы", 1, 20),
        new FootballTeam("Реалы", 1, 18),
        new FootballTeam("Спукискери", 1, 16),
        new FootballTeam("Скибиди", 1, 14),
        new FootballTeam("Сюдахи", 1, 12),
        new FootballTeam("Пепешки", 1, 10),
        };

        FootballTeam[] teamsGroup2 = new FootballTeam[]
        {
        new FootballTeam("Волки", 2, 22),
        new FootballTeam("Стронги", 2, 20),
        new FootballTeam("Пиналки", 2, 18),
        new FootballTeam("Альфа-фут", 2, 16),
        new FootballTeam("Топчики", 2, 14),
        new FootballTeam("Лузеры", 2, 12),
        };

        // Сортировка команд первого этапа по очкам
        Array.Sort(teamsGroup1, (x, y) => y.Points.CompareTo(x.Points));
        Array.Sort(teamsGroup2, (x, y) => y.Points.CompareTo(x.Points));

        // Выбор шести лучших команд каждой группы
        var selectedTeamsGroup1 = teamsGroup1.Take(3);
        var selectedTeamsGroup2 = teamsGroup2.Take(3);

        // Вывод списка команд второго этапа
        Console.WriteLine("Команды участников второго этапа:");
        foreach (var team in selectedTeamsGroup1.Concat(selectedTeamsGroup2))
        {
            team.PrintTeam();
        }
    }


}