using System;

struct Lijnik
{
    private string surname;
    private int result;

    public string Surname => surname;
    public int Result => result;

    public Lijnik(string surname, int result)
    {
        this.surname = surname;
        this.result = result;
    }
}
class Program
{
    static void Main()
    {
        (string, int)[] all_group = new (string, int)[10];

        Lijnik[] first_group = new Lijnik[5];

        first_group[0] = new Lijnik("Иванов", 4);
        first_group[1] = new Lijnik("Петров", 6);
        first_group[2] = new Lijnik("Сидоров", 2);
        first_group[3] = new Lijnik("Орлов", 8);
        first_group[4] = new Lijnik("Клестов", 12);

        Array.Sort(first_group, (x, y) => x.Result.CompareTo(y.Result));

        for (int i = 0; i < 5; i++)
        {
            all_group[i] = (first_group[i].Surname, first_group[i].Result);
        }

        Lijnik[] second_group = new Lijnik[5];

        second_group[0] = new Lijnik("Ирвинг", 4);
        second_group[1] = new Lijnik("Зубастик", 6);
        second_group[2] = new Lijnik("Волков", 2);
        second_group[3] = new Lijnik("Дзюба", 8);
        second_group[4] = new Lijnik("Пеле", 12);

        Array.Sort(second_group, (x, y) => x.Result.CompareTo(y.Result));

        for (int i = 5; i < 10; i++)
        {
            all_group[i] = (second_group[i - 5].Surname, second_group[i - 5].Result);
        }

        Console.WriteLine("{0,-15} {1,-10}", "Фамилия", "Результат");
        Console.WriteLine("-----------------------");

        foreach (var elem in all_group)
        {
            Console.WriteLine("{0,-15} {1,-10}", elem.Item1, elem.Item2);
        }
        Console.WriteLine("    ♥♥♥    ♥♥♥    ");
        Console.WriteLine("  ♥    ♥♥♥    ♥  ");
        Console.WriteLine("♥       ♥       ♥");
        Console.WriteLine("  ♥           ♥  ");
        Console.WriteLine("    ♥       ♥    ");
        Console.WriteLine("      ♥   ♥      ");
        Console.WriteLine("        ♥        ");





    }
}