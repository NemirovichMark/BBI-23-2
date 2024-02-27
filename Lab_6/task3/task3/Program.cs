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
    public string GetTable()
    {
        string table = $"{Surname,-15} {Result,-10}\n";
        table += "-----------------------\n";
        return table;
    }
}

class Program
{

    static Lijnik[] MergeArrays(Lijnik[] first, Lijnik[] second)
    {
        int totalLength = first.Length + second.Length;
        Lijnik[] merged = new Lijnik[totalLength];

        int i = 0, j = 0, k = 0;

        while (i < first.Length && j < second.Length)
        {
            if (first[i].Result <= second[j].Result)
            {
                merged[k++] = first[i++];
            }
            else
            {
                merged[k++] = second[j++];
            }
        }

        while (i < first.Length)
        {
            merged[k++] = first[i++];
        }

        while (j < second.Length)
        {
            merged[k++] = second[j++];
        }

        return merged;
    }


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

        Lijnik[] all_group = MergeArrays(first_group, second_group);

        foreach (var elem in all_group)
        {
            Console.WriteLine(elem.GetTable());
        }
    }
}
