using System;

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

    public int GetRes()
    {
        return _res;
    }

    public void Write()
    {
        Console.WriteLine("{0}\t  {1}", _name, _res);
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
        for (int i = 1; i < competitors.Length; i++)
        {
            Competitor temp = competitors[i];
            int j = i - 1;

            while (j >= 0 && competitors[j].GetRes() < temp.GetRes())
            {
                competitors[j + 1] = competitors[j];
                j--;
            }

            competitors[j + 1] = temp;
        }
    }



static void Print(Competitor[] competitors)
    {

        foreach (Competitor competitor in competitors)
        {
            competitor.Write();
        }

    }
}
