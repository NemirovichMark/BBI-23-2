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
        public string Club => club;
        public double FirstAttempt => firstAttempt;
        public double SecondAttempt => secondAttempt;
        public double TotalDistance => firstAttempt + secondAttempt;

        public Athlete(string lastName, string club, double firstAttempt, double secondAttempt)
        {
            this.lastName = lastName;
            this.club = club;
            this.firstAttempt = firstAttempt;
            this.secondAttempt = secondAttempt;
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

        Array.Sort(athletes, (x, y) => x.TotalDistance.CompareTo(y.TotalDistance));

        for (int i = 0; i < athletes.Length; i++)
        {
            Console.Write($"Место {i + 1} | Фамилия {athletes[i].LastName}\n");
        }
        Console.WriteLine();
    }
}