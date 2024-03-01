using lab6;
using System;
using System.Globalization;
//task #2
namespace lab6
{
    public struct Team
    {
        private int _teamID;
        private int _score;
        public Team(int teamID, int score)
        {
            _teamID = teamID;
            _score = score;
        }

        public int Score => _score;
        public int TeamID => _teamID;

        public void WriteTeam()
        {
            Console.WriteLine($"TeamID: {_teamID} Score: {_score}");
        }
    }
    }

    internal static class Program
    {
        static void MergeGroups(Team[] Group1, Team[] Group2, Team[] FinalGroup)
        {
            int i = 0, j = 0, k = 0;
            while (i < 6 && j < 6)
            {
                if (Group1[i].Score >= Group2[j].Score)
                {
                    FinalGroup[k] = Group1[i];
                    i++; k++;
                }
                else
                {
                    FinalGroup[k] = Group2[j];
                    j++; k++;
                }
            }

            while (i < 6)
            {
                FinalGroup[k] = Group2[i];
                i++; k++;
            }

        while (j < 6)
        {
            FinalGroup[k] = Group2[j];
            j++; k++;
        }
    }
        static void Main()
        {
        //creating 2 groups
        Team[] Group1 = new Team[12]
        {
            new Team(0, 3),
            new Team(1, 1),
            new Team(2, 2),
            new Team(3, 6),
            new Team(4, 4),
            new Team(5, 3),
            new Team(6, 2),
            new Team(7, 8),
            new Team(8, 5),
            new Team(9, 5),
            new Team(10, 1),
            new Team(11, 2)
        };

        Team[] Group2 = new Team[12]
        {
            new Team(12, 6),
            new Team(13, 6),
            new Team(14, 4),
            new Team(15, 3),
            new Team(16, 1),
            new Team(17, 9),
            new Team(18, 5),
            new Team(19, 2),
            new Team(20, 5),
            new Team(21, 1),
            new Team(22, 3),
            new Team(23, 4)
        };

        //sorting groups by teams scores - bubble
        //for (int i = 0; i < Group1.Length - 1; i++)
        //    for (int k = 0; k < Group1.Length - i - 1; k++)
        //        if (Group1[k].Score < Group1[k + 1].Score)
        //            (Group1[k], Group1[k + 1]) = (Group1[k + 1], Group1[k]);

        //for (int i = 0; i < Group2.Length - 1; i++)
        //    for (int k = 0; k < Group1.Length - i - 1; k++)
        //        if (Group2[k].Score < Group2[k + 1].Score)
        //            (Group2[k], Group2[k + 1]) = (Group2[k + 1], Group2[k]);

        //sorting groups by teams scores - insertion
        for (int i = 1; i < Group1.Length; i++)
        {
            Team x = Group1[i];
            int j = i - 1;
            while (j >= 0 && Group1[j].Score < x.Score)
            {
                Group1[j + 1] = Group1[j];
                j--;
            }
            Group1[j + 1] = x;
        }

        for (int i = 1; i < Group2.Length; i++)
        {
            Team x = Group2[i];
            int j = i - 1;
            while (j >= 0 && Group2[j].Score < x.Score)
            {
                Group2[j + 1] = Group2[j];
                j--;
            }
            Group2[j + 1] = x;
        }

        //creating sorted array with elements of top-6's
        Team[] FinalGroup = new Team[12];
        MergeGroups(Group1, Group2, FinalGroup);

        //writing final array
        for (int i = 0; i < FinalGroup.Length; i++)
            FinalGroup[i].WriteTeam();
    }
}
