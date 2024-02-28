using System.Globalization;

namespace lab_6th
{
    public struct Sportsmen
    {
        private string _surname;
        double _points;
        public Sportsmen(string surname, double points)
        {
            _surname = surname;
            _points = points;
        }
        public double Points
        { get { return _points; } }

        public string Surname
        { get { return _surname; } }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] list_of_sportsmens = {
                new Sportsmen("Tsoy", Point_Generator()),
                new Sportsmen("Letov", Point_Generator()),
                new Sportsmen("Klinskih", Point_Generator()),
                new Sportsmen("Osbourne", Point_Generator()) };
            for (int i = 0; i < list_of_sportsmens.Length; i++)
            {
                Console.WriteLine($"имя: {list_of_sportsmens[i].Surname} очки: {list_of_sportsmens[i].Points}");
            }
            Sort(list_of_sportsmens);
            Console.WriteLine("список спортсменов по местам");
            for (int i = 0; i < list_of_sportsmens.Length; i++)
            {
                Console.WriteLine($"имя: {list_of_sportsmens[i].Surname} очки: {list_of_sportsmens[i].Points}");
            }

        }
        static double Point_Generator()
        {
            int[] points = new int[4]; double total_points = 0;
            Random point = new Random();
            for (int i = 0; i < 4; i++)
            {
                points[i] = point.Next(0, 42);
            }

            //поиск максимума
            int max = int.MinValue; int imax = 0;
            for (int i = 0; i < 4; i++)
            {
                if (points[i] > max)
                {
                    max = points[i]; imax = i;
                }
            }

            //поиск минимума 
            int min = int.MaxValue; int imin = 0;
            for (int i = 0; i < 4; i++)
            {
                if (points[i] < min)
                {
                    min = points[i]; imin = i;
                }
            }

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i != imax && i != imin) sum += points[i];
            }

            //финальные очки
            total_points = sum * K();

            return total_points;
        }
        static double K()
        {
            double k = 2.5;
            double[] k_list = new double[6];
            for (int i = 0; i < 6; i++)
            {
                k_list[i] = k;
                k += 0.2;
            }
            Random random = new Random();
            int K = random.Next(0, 5);
            k = k_list[K];
            return k;
        }
        static Sportsmen[] Sort(Sportsmen[] sportsmens)
        {
            Sportsmen man;
            for (int i = 0; i < sportsmens.Length; i++)
            {
                for (int j = i + 1; j < sportsmens.Length; j++)
                {
                    if (sportsmens[j].Points > sportsmens[i].Points)
                    {
                        man = sportsmens[i];
                        sportsmens[i] = sportsmens[j];
                        sportsmens[j] = man;
                    }
                }

            }
            return sportsmens;
        }
    }
}