public struct Team
{
    private string _name { get; set; }
    private int _points { get; set; }
    private int _group { get; set; }

    public Team(string name, int group, int points)
    {
        _name = name;
        _points = points;
        _group = group;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetGroup(int group)
    {
        _group = group;
    }

    public int GetGroup()
    {
        return _group;
    }
}

class Program
{
    static void Main()
    {
        Team[] firststage = new Team[24];
        Team[] secondstage = new Team[12];

        for (int i = 0; i < 12; i++)
        {
            firststage[i] = new Team($"Team {i + 1}", 1, new Random().Next(0, 50));

        }

        for (int i = 12; i < 24; i++)
        {
            firststage[i] = new Team($"Team {i + 1}", 2, new Random().Next(0, 50));

        }

        Sort(firststage);

        for (int i = 0; i < 6; i++)
        {
            secondstage[i] = firststage[i];
        }
        int k = 6;
        for (int i = firststage.Length - 1; i > 17; i--)
        {
            secondstage[k] = firststage[i];
            k++;
        }

        Print(secondstage);
    }

    static void Sort(Team[] teams)
    {
        for (int i = 0; i < teams.Length / 2 - 1; i++) // сортировка 1 группы по убыванию
        {
            for (int j = i; j < teams.Length / 2; j++)
            {
                if (teams[i].GetPoints() < teams[j].GetPoints())
                {
                    Team temp = teams[i];
                    teams[i] = teams[j];
                    teams[j] = temp;
                }
            }
        }
        for (int i = teams.Length - 1; i > teams.Length / 2 - 1; i--) // сортировка 2 группы по возрастанию
        {
            for (int j = i; j > teams.Length / 2; j--)
            {
                if (teams[i].GetPoints() < teams[j].GetPoints())
                {
                    Team temp = teams[i];
                    teams[i] = teams[j];
                    teams[j] = temp;
                }
            }
        }
    }
    static void Print(Team[] secondstage)
    {
        Console.WriteLine("Участники второго этапа:");
        foreach (Team elem in secondstage)
        {
            Console.WriteLine("{0}\t ----- {1}", elem.GetName(), elem.GetPoints());
        }
    }

}
