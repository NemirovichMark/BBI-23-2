// exercise 3.3

using System;
class Program
{
    struct Сompetition
    {
        private int[] results;

        public Сompetition(int[] results)
        {
            this.results = results;
        }

        public int TotalPoints()
        {
            int points = 0;
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] == 1)
                {
                    points += 5;
                }
                else if (results[i] == 2)
                {
                    points += 4;
                }
                else if (results[i] == 3)
                {
                    points += 3;
                }
                else if (results[i] == 4)
                {
                    points += 2;
                }
                else if (results[i] == 5)
                {
                    points += 1;
                }
            }
            return points;
        }
    }

    static void Main()
    {
        int[] results_team1 = { 7, 2, 5, 14, 6, 16 };
        int[] results_team2 = { 1, 8, 9, 10, 11, 12 };
        int[] results_team3 = { 13, 3, 4, 15, 17, 18 };
        int сheck_element = 1;

        Сompetition team1 = new Сompetition(results_team1);
        Сompetition team2 = new Сompetition(results_team2);
        Сompetition team3 = new Сompetition(results_team3);

        int points_team1 = team1.TotalPoints();
        int points_team2 = team2.TotalPoints();
        int points_team3 = team3.TotalPoints();

        Console.WriteLine($"Результат первой команды: {points_team1}");
        Console.WriteLine($"Результат второй команды: {points_team2}");
        Console.WriteLine($"Результат третьей команды: {points_team3}");

        if (points_team1 > points_team2 && points_team1 > points_team3)
        {
            Console.WriteLine($"Первая команда становится победителем");
        }
        else if (points_team2 > points_team1 && points_team2 > points_team3)
        {
            Console.WriteLine($"Вторая команда становится победителем");
        }
        else if (points_team3 > points_team1 && points_team3 > points_team2)
        {
            Console.WriteLine($"Третья команда становится победителем");
        }
        else if (points_team1 == points_team2 || points_team1 == points_team3 || points_team2 == points_team3)
        {
            foreach (int element in results_team1)
            {
                if (element == сheck_element)
                {
                    Console.WriteLine($"Первая команда становится победителем");
                }
            }
            foreach (int element in results_team2)
            {
                if (element == сheck_element)
                {
                    Console.WriteLine($"Вторая команда становится победителем");
                }
            }
            foreach (int element in results_team3)
            {
                if (element == сheck_element)
                {
                    Console.WriteLine($"Третья команда становится победителем");
                }
            }
        }
    }
}
