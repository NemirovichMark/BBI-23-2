using System;
using System;

struct RunnerResult
{
    public string LastName;//фамилия 
    public string Group;//группа
    public string TeacherLastName;//фамилия препода
    public double ResultInSeconds;//результат в сек
    public bool Norm;//норма
}

class Program
{
    static void Main(string[] args)
    {
        // Создание массива результатов
        RunnerResult[] results = new RunnerResult[]
        {
            new RunnerResult { LastName = "Перекресткова", Group = "Группа 1", TeacherLastName = "Петров", ResultInSeconds = 300 },//задаю данные
            new RunnerResult { LastName = "Пятерочкина", Group = "Группа 2", TeacherLastName = "Сидоров", ResultInSeconds = 287.89 },
            new RunnerResult { LastName = "Жульенова", Group = "Группа 2", TeacherLastName = "Сидоров", ResultInSeconds = 562},
            new RunnerResult { LastName = "Акакиева", Group = "Группа 3", TeacherLastName = "Сидоров", ResultInSeconds = 499},
            // Добавьте еще результатов по аналогии
        };

        // Сортировка результатов по времени
        Array.Sort(results, (x, y) => x.ResultInSeconds.CompareTo(y.ResultInSeconds));//сортировка студентов по результатам

        // Вывод таблицы результатов
        Console.WriteLine("Фамилия\t\t         Группа\t\t  Преподаватель\t\tРезультат\t Норматив");
        foreach (var result in results)//перебор данных
        {
            Console.WriteLine($"{result.LastName}\t\t{result.Group}\t\t{result.TeacherLastName}\t\t{result.ResultInSeconds}\t\t{(result.ResultInSeconds <= 300 ? "Да" : "Нет")}");//если результат больше нормы, то всё ок
        }

        // Подсчет количества участниц, выполнивших норматив
        int countNorm = 0;//переменная для норматива
        foreach (var result in results)//цикл с условием, определяет кол-во спортсменов с результатом >=300
        {
            if (result.ResultInSeconds >= 300)
                countNorm++;// кол-во 
        }

        Console.WriteLine($"Количество участниц, выполнивших норматив: {countNorm}");
    }
}




struct Student
{
    public string Name;//имя
    public string Group;//группа
    public double[] ExamScores;//баллы

    public double CalculateAverageScore()
    {
        double sum = 0;
        foreach (var score in ExamScores)//цикл для перебора баллов
        {
            sum += score;
        }
        return sum / ExamScores.Length;//среднее
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание массива студентов
        Student[] students = new Student[]
        {
            new Student { Name = "Чиназес", Group = "ББИ-23-1", ExamScores = new double[] { 3, 3, 2, 3 } },
            new Student { Name = "Ажож", Group = "ББИ-23-1", ExamScores = new double[] { 5, 5, 5, 4 } },
              new Student { Name = "Асос", Group = "ББИ-23-1", ExamScores = new double[] { 3, 5, 4, 4 } },
                new Student { Name = "Роберто", Group = "ББИ-23-1", ExamScores = new double[] { 5, 5, 5, 5 } },
            new Student { Name = "Ли-кой-чын", Group = "ББИ-23-1", ExamScores = new double[] { 5, 3, 2, 5 } },
                    new Student { Name = "Мадина", Group = "ББИ-23-1", ExamScores = new double[] { 4, 4, 4, 4 } },

        };

        // Фильтрация студентов с баллом >=4
        var filteredStudents = Array.FindAll(students, s => s.CalculateAverageScore() >= 4);

        // Сортировка студентов по среднему баллу
        Array.Sort(filteredStudents, (x, y) => y.CalculateAverageScore().CompareTo(x.CalculateAverageScore()));

        // Вывод таблицы результатов
        Console.WriteLine("Имя\t\tГруппа\t\t  Средний балл");
        foreach (var student in filteredStudents)//цикл 
        {
            Console.WriteLine($"{student.Name}\t\t{student.Group}\t\t{student.CalculateAverageScore()}");
        }
    }
}

using System;

struct FootballTeam
{
    public string Name;//имя
    public int Group;//группа
    public int Points;//оценка
}

class Program
{
    static void Main(string[] args)
    {
        // Создание массива команд первого этапа
        FootballTeam[] teams = new FootballTeam[]
        {
            new FootballTeam { Name = "Барсы", Group = 1, Points = 20 },
            new FootballTeam { Name = "Реалы", Group = 1, Points = 18 },
            new FootballTeam { Name = "Спукискери", Group = 1, Points = 16 },
            new FootballTeam { Name = "Скибиди", Group = 1, Points = 14 },
            new FootballTeam { Name = "Сюдахи", Group = 1, Points = 12 },
            new FootballTeam { Name = "Пепешки", Group = 1, Points = 10 },
            new FootballTeam { Name = "Волки", Group = 2, Points = 22 },
            new FootballTeam { Name = "Стронги", Group = 2, Points = 20 },
            new FootballTeam { Name = "Пиналки", Group = 2, Points = 18 },
            new FootballTeam { Name = "Альфа-фут", Group = 2, Points = 16 },
            new FootballTeam { Name = "Топчики", Group = 2, Points = 14 },
            new FootballTeam { Name = "Лузеры", Group = 2, Points = 12 },
        };

        // Сортировка команд первого этапа по очкам
        Array.Sort(teams, (x, y) => y.Points.CompareTo(x.Points));

        // Выбираю шесть лучших команд каждой группы
        var selectedTeamsGroup1 = teams.Where(t => t.Group == 1).Take(3);//помогает вывести лучшие команды
        var selectedTeamsGroup2 = teams.Where(t => t.Group == 2).Take(3);//помогает вывести лучшие команды

        // Вывод списка команд второго этапа
        Console.WriteLine("Команды участников второго этапа:");//для красоты)
        foreach (var team in selectedTeamsGroup1.Concat(selectedTeamsGroup2))//для вывода массива
        {
            Console.WriteLine($"{team.Name}, Группа {team.Group}, Очки: {team.Points}");
        }
    }
}