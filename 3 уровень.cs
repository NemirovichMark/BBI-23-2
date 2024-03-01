struct Team
{
    private string _name;
    private int _goals_scored;
    private int _goals_conceded;
    private int _points;

    public Team(string name, int goalsScored, int goalsConceded)
    {
        _name = name;
        _goals_scored = goalsScored;
        _goals_conceded = goalsConceded;
        _points = 0;
    }
    public string Name => _name;
    public int GoalsScored => _goals_scored;
    public int GoalsConceded => _goals_conceded;
    public int Points => _points;

    public void Win()
    {
        _points += 3;
    }

    public void Draw()
    {
        _points += 1;
    }

    public void PrintTeam()
    {
        Console.WriteLine($"Team: {_name}, Points: {_points}");
    }
}

class Program
{
    static void Main()
    {
        Team[] teams = new Team[7]
        {
new Team("Team1", 4, 2),
new Team("Team2", 3, 3),
new Team("Team3", 1, 4),
new Team("Team4", 1, 1),
new Team("Team5", 5, 2),
new Team("Team6", 2, 5),
new Team("Team7", 3, 1)
        };

        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                if (teams[i].GoalsScored > teams[j].GoalsScored)
                    teams[i].Win();
                else if (teams[i].GoalsScored == teams[j].GoalsScored)
                {
                    teams[i].Draw();
                    teams[j].Draw();
                }
                else
                    teams[j].Win();
            }
        }

        for (int i = 0; i < teams.Length; i++)
        {
            for (int j = i; j < teams.Length; j++)
            {
                if (teams[i].Points < teams[j].Points)
                    (teams[i], teams[j]) = (teams[j], teams[i]);
                else if (teams[i].Points == teams[j].Points && teams[i].GoalsScored - teams[i].GoalsConceded < teams[j].GoalsScored - teams[j].GoalsConceded)
                    (teams[i], teams[j]) = (teams[j], teams[i]);
            }
        }

        for (int i = 0; i < teams.Length; i++)
        {
            teams[i].PrintTeam();
        }
    }
}