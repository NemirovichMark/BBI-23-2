using System;
using System.Linq;

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
        Lijnik[] first_group = new Lijnik[5];
        first_group[0] = new Lijnik("Иванов", 4);
        first_group[1] = new Lijnik("Петров", 6);
        first_group[2] = new Lijnik("Сидоров", 2);
        first_group[3] = new Lijnik("Орлов", 8);
        first_group[4] = new Lijnik("Клестов", 12);

        Array.Sort(first_group, (x, y) => x.Result.CompareTo(y.Result));

        Lijnik[] second_group = new Lijnik[5];
        second_group[0] = new Lijnik("Ирвинг", 4);
        second_group[1] = new Lijnik("Зубастик", 6);
        second_group[2] = new Lijnik("Волков", 2);
        second_group[3] = new Lijnik("Дзюба", 8);
        second_group[4] = new Lijnik("Пеле", 12);

        Array.Sort(second_group, (x, y) => x.Result.CompareTo(y.Result));

        Lijnik[] all_group = first_group.Concat(second_group).ToArray();
        Array.Sort(all_group, (x, y) => x.Result.CompareTo(y.Result));

        Console.WriteLine("{0,-15} {1,-10}", "Фамилия", "Результат");
        Console.WriteLine("-----------------------");

        foreach (var elem in all_group)
        {
            Console.WriteLine("{0,-15} {1,-10}", elem.Surname, elem.Result);
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
