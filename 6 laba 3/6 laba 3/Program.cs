using System;

struct Team
{
    private string name;
    private int _GoalsScored;
    private int _GoalsConceded;
    private int _Points;

    public string Name => name;
    public int GoalsScored => _GoalsScored;
    public int GoalsConceded => _GoalsConceded;
    public int Points => _Points;

    public Team(string name, int GoalsScored, int GoalsConceded)
    {
        this.name = name;
        this._GoalsScored = GoalsScored;
        this._GoalsConceded = GoalsConceded;
        _Points = 0;
    }

    public void PlayMatch(int result)
    {
        if (result == 1)
        {
            _Points += 3;
        }
        else if (result == 0)
        {
            _Points += 0;
        }
        else
        {
            _Points += 1;
        }
    }

    public string PrintTeamInfo()
    {
        return $"{Name}: {Points} очков";
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[6];
        teams[0] = new Team("Винлайн", 1, 1);
        teams[1] = new Team("ВанВин", 3, 1);
        teams[2] = new Team("Лидер", 5, 2);
        teams[3] = new Team("Чемпион", 4, 3);
        teams[4] = new Team("Звезда", 3, 3);
        teams[5] = new Team("Герой", 1, 3);

        for (int i = 0; i < teams.Length; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                int scoreTeam1 = teams[i].GoalsScored - teams[j].GoalsConceded;
                int scoreTeam2 = teams[j].GoalsScored - teams[i].GoalsConceded;

                if (scoreTeam1 > scoreTeam2)
                {
                    teams[i].PlayMatch(3);
                    teams[j].PlayMatch(0);
                }
                else if (scoreTeam1 < scoreTeam2)
                {
                    teams[i].PlayMatch(0);
                    teams[j].PlayMatch(3);
                }
                else
                {
                    teams[i].PlayMatch(1);
                    teams[j].PlayMatch(1);
                }
            }
        }


        Array.Sort(teams, (x, y) =>
        {
            if (x.Points != y.Points)
            {
                return y.Points.CompareTo(x.Points);
            }
            else
            {
                return (y.GoalsScored - y.GoalsConceded).CompareTo(x.GoalsScored - x.GoalsConceded);
            }
        });

        Console.WriteLine("Таблица результатов:");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].PrintTeamInfo()}");
        }
    }
}