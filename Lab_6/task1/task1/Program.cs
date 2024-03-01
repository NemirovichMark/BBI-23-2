using System;

class Program
{
    struct Athlete
    {
        private string lastName;
        private string club;
        private double firstAttempt;
        private double secondAttempt;

        public string LastName => lastName;
        public double TotalDistance => firstAttempt + secondAttempt;

        public Athlete(string lastName, string club, double firstAttempt, double secondAttempt)
        {
            this.lastName = lastName;
            this.club = club;
            this.firstAttempt = firstAttempt;
            this.secondAttempt = secondAttempt;
        }

        public string GetAthleteInfo(int place)
        {
            return $"Место {place} | Фамилия {lastName}\n";
        }

    }

    static void ShellSort(Athlete[] array)
    {
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                Athlete temp = array[i];
                int j;
                for (j = i; j >= gap && array[j - gap].TotalDistance > temp.TotalDistance; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
        }
    }

    static void Main()
    {
        Athlete[] athletes = new Athlete[5];

        athletes[0] = new Athlete("Иванов", "Спартак", 5.6, 6.2);
        athletes[1] = new Athlete("Петров", "ЦСК", 6.0, 5.8);
        athletes[2] = new Athlete("Сидоров", "Локомотив", 6.5, 6.4);
        athletes[3] = new Athlete("Волчков", "Зенит", 6.6, 6.9);
        athletes[4] = new Athlete("Джугашвили", "СССР", 2.1, 3.4);

        ShellSort(athletes);

        for (int i = 0; i < athletes.Length; i++)
        {
            Console.Write(athletes[i].GetAthleteInfo(i + 1));
        }

        Console.WriteLine();
    }
}
