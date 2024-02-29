using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    internal class Program
    {
        struct Team
        {
            private string _name;
            private int _score;
            public string Name { get { return _name; } }
            public int Score { get { return _score; } }
            public Team(string name, int score)
            {
                _name = name;
                _score = score;
            }
            public void Display()
            {
                Console.WriteLine($"{_name}: {_score}");
            }
        }
        static void Main(string[] args)
        {
            Team[] group1 = new Team[12]
            { new Team("Real Madrid", 21),  new Team("Barcelona", 29),
            new Team("Atletico Mardid", 24), new Team("Real Betis", 13), new Team("Villareal", 17),
            new Team("Rayo Vallecano", 8), new  Team("Selta", 12), new Team("Girona", 16), new Team("Eibar", 3),
            new Team("Valencia", 19), new Team("Sevilla", 24), new Team("Osasuna", 6)};
            Team[] group2 = new Team[12]
            { new Team("Liverpool", 34), new Team("Chelsea", 27), new Team("Tottenham", 19), new Team("Arsenal", 23),
            new Team("Aston Villa", 13), new Team("Stoke City", 15), new Team("Lester", 19), new Team("QPR", 13),
            new Team("Nottinham Forest", 14), new Team("Manchester United", 24), new Team("Manchester City", 28),
            new Team("Everton", 19) };
            Sort(group1);
            Sort(group2);
            Team[] next = TwoToOne(group1, group2);
            for (int i = 0; i < next.Length; i++)
            {
                next[i].Display();
            }
        }
        static void Sort(Team[] Teams)
        {
            for (int i = 1; i < Teams.Length; i++)
            {
                for (int j = 1; j < Teams.Length; j++)
                {
                    if (Teams[j].Score > Teams[j - 1].Score)
                    {
                        Team temp = Teams[j];
                        Teams[j] = Teams[j - 1];
                        Teams[j - 1] = temp;
                    }
                }
            }
        }
        static Team[] TwoToOne(Team[] group1, Team[] group2)
        {
            Team[] result = new Team[group1.Length/2 + group2.Length/2];
            int i, j;
            i = j = 0;
            for (int k = 0; k < result.Length; k++)
            {
                if (i >= group1.Length)
                {
                    result[k] = group2[j];
                    j++;
                }
                else if (j >= group2.Length)
                {
                    result[k] = group1[i];
                    i++;
                }
                else if (group1[i].Score < group2[j].Score)
                {
                    result[k] = group2[j];
                    j++;
                }
                else
                {
                    result[k] = group1[i];
                    i++;
                }
            }
            return result;
        }
    }
}
