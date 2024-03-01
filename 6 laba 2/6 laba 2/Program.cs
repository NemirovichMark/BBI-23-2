using System;

class HockeyPlayer
{
    private string LastName;
    private int TotalPenaltyTime;

    public HockeyPlayer(string lastName, int totalPenaltyTime)
    {
        LastName = lastName;
        TotalPenaltyTime = totalPenaltyTime;
    }

    public int GetTotalPenaltyTime()
    {
        return TotalPenaltyTime;
    }

    public static void SortPlayersByPenaltyTime(ref HockeyPlayer[] players)
    {
        for (int i = 0; i < players.Length - 1; i++)
        {
            for (int j = i + 1; j < players.Length; j++)
            {
                if (players[i].GetTotalPenaltyTime() > players[j].GetTotalPenaltyTime())
                {
                    HockeyPlayer temp = players[i];
                    players[i] = players[j];
                    players[j] = temp;
                }
            }
        }
    }

    public void DisplayPlayer()
    {
        Console.WriteLine($"{LastName}\t{TotalPenaltyTime} мин");
    }
}

class Program
{
    static void Main()
    {
        HockeyPlayer[] players = new HockeyPlayer[3];

        for (int i = 0; i < players.Length; i++)
        {
            Console.Write($"Введите фамилию {i + 1}-го игрока: ");
            string lastName = Console.ReadLine();

            int penaltyTime;
            while (true)
            {
                Console.Write($"Введите штрафное время {i + 1}-го игрока: ");
                if (!int.TryParse(Console.ReadLine(), out penaltyTime))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                }
                else
                {
                    break;
                }
            }

            players[i] = new HockeyPlayer(lastName, penaltyTime);
        }

        HockeyPlayer.SortPlayersByPenaltyTime(ref players);

        Console.WriteLine("Фамилия\tШтрафное время");
        foreach (var player in players)
        {
            if (player.GetTotalPenaltyTime() < 10)
            {
                player.DisplayPlayer();
            }
        }
    }
}