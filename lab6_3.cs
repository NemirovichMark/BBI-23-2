using System;

struct Team
{
    private string name;
    private int _zabit;
    private int _propusk;
    private int _ochki;

    public string Name => name;
    public int Zabit => _zabit;
    public int Propusk => _propusk;
    public int Ochki => _ochki;

    public Team(string name, int Zabit, int Propusk)
    {
        this.name = name;
        this._zabit = Zabit;
        this._propusk = Propusk;
        if (Zabit > Propusk)
        {
            _ochki = 3;
        }
        else if (Zabit == Propusk)
        {
            _ochki = 1;
        }
        else
        {
            _ochki = 0;
        }
    }

    public string PrintTeamInfo()
    {
        return $"{Name}: {Ochki} очков";
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[5];
        teams[0] = new Team("Винлайн", 1, 1);
        teams[1] = new Team("ВанВин", 3, 1);
        teams[2] = new Team("БЕТБУМ", 4, 0);
        teams[3] = new Team("Крылья Советов", 2, 3);
        teams[4] = new Team("Енисей", 2, 2);

        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {

                if (teams[i].Ochki < teams[j].Ochki)
                {
                    Team temp = teams[i];
                    teams[i] = teams[j];
                    teams[j] = temp;
                }
                else if (teams[i].Ochki == teams[j].Ochki)
                {
                    int diff1 = teams[i].Zabit - teams[i].Propusk;
                    int diff2 = teams[j].Zabit - teams[j].Propusk;
                    if (diff1 < diff2)
                    {
                        Team temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Таблица результатов:");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].PrintTeamInfo()}");
        }
    }
}
