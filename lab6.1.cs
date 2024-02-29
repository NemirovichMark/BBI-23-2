public struct Competitor
{
    private string _name;
    private int _res;

    public Competitor(string name, int res1, int res2) //в конструкторе сразу отбирается наибольший результат
    {
        _name = name;
        if (res1 > res2) _res = res1;
        else _res = res2;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetRes()
    {
        return _res;
    }
}

internal class Program
{
    static void Main()
    {
        Competitor[] competitors = new Competitor[5];

        competitors[0] = new Competitor("Олег", 135, 123);
        competitors[1] = new Competitor("Виталя", 137, 121);
        competitors[2] = new Competitor("Леха", 115, 136);
        competitors[3] = new Competitor("Гена", 134, 126);
        competitors[4] = new Competitor("Вован", 112, 143);

        Sort(competitors);
        Print(competitors);

    }

    static void Sort(Competitor[] competitors)
    {
        for (int i = 0; i < competitors.Length - 1; i++)
        {
            for (int j = i; j < competitors.Length; j++)
            {
                if (competitors[i].GetRes() < competitors[j].GetRes())
                {
                    Competitor temp = competitors[i]; competitors[i] = competitors[j]; competitors[j] = temp;
                }
            }
        }
    }

    static void Print(Competitor[] competitors)
    {

        foreach (Competitor competitor in competitors)
        {
            Console.WriteLine("{0}\t  {1}", competitor.GetName(), competitor.GetRes());
        }

    }
}
