using System;

struct Ychastniki
{
    private string lastName;
    private string group;
    private string teacherLastName;
    private double result;

    public string LastName => lastName;
    public string Group => group;
    public string TeacherLastName => teacherLastName;
    public double Result => result;

    public Ychastniki(string lastName, string group, string teacherLastName, double result)
    {
        this.lastName = lastName;
        this.group = group;
        this.teacherLastName = teacherLastName;
        this.result = result;
    }

    public void Print()
    {
        Console.WriteLine($"Фамилия: {LastName} | Группа: {Group} | Преподаватель: {TeacherLastName} | Результат: {Result}");
    }
}

class Program
{
    static void Main()
    {
        Ychastniki[] participants = new Ychastniki[5];
        participants[0] = new Ychastniki("Попова", "Группа 1", "Иванов", 210);
        participants[1] = new Ychastniki("Иванова", "Группа 2", "Петров", 180);
        participants[2] = new Ychastniki("Сидорова", "Группа 1", "Смирнов", 195);
        participants[3] = new Ychastniki("Петрова", "Группа 3", "Козлов", 220);
        participants[4] = new Ychastniki("Смирнова", "Группа 2", "Васильев", 190);

        Array.Sort(participants, (x, y) => x.Result.CompareTo(y.Result));

        Console.WriteLine("\nРезультаты кросса на 500 м для женщин:");
        Console.WriteLine("=============================================");
        Console.WriteLine("Фамилия\t\tГруппа\t\tПреподаватель\t\tРезультат");
        Console.WriteLine("=============================================");

        foreach (var participant in participants)
        {
            participant.Print();
        }

        Console.WriteLine("=============================================");
    }
}
