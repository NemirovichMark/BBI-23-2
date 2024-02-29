using System.Globalization;
namespace lab_6th
{
    //часть 1 задание 2
    //public struct Girls
    //{
    //    private string _name;
    //    private string _surname_teacher;
    //    private int _group;
    //    private int _result;
    //    public Girls(string name, string surname_teacher, int group, int result)
    //    {
    //        _name = name;
    //        _surname_teacher = surname_teacher;
    //        _group = group;
    //        _result = result;
    //    }
    //    public int Result
    //    {
    //        get { return _result; }
    //    }
    //    public string Name
    //    {
    //        get { return _name; }
    //    }
    //    public string Surname_Teacher
    //    {
    //        get { return _surname_teacher; }
    //    }
    //    public int Group
    //    {
    //        get { return _group; }
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Girls[] girls = new Girls[4] {new Girls("Юля", "Грантова", 1 , 2 ),
    //        new Girls("Таня", " Собчак", 3, 5),
    //        new Girls("Александра", "Мармеладова", 3 , 4 ), new Girls("Лена", " Герберт", 6, int.MaxValue)};
    //        Sort(girls);
    //        for (int i = 0; i < girls.Length; i++)
    //        {
    //            string j;
    //            if (girls[i].Result == int.MaxValue)
    //            {
    //                j = Convert.ToString(girls[i].Result);
    //                j = "не пробежала";
    //            }
    //            else
    //            {
    //                j = Convert.ToString(girls[i].Result);
    //            }
    //            Console.WriteLine($"имя:{girls[i].Name}, группа:{girls[i].Group}, фамилия учителя:{girls[i].Surname_Teacher}, результат:{j}  \n");
    //        }
    //        int count = Counter(girls);
    //        Console.WriteLine($"число девушек пробежавших забег: {count}");
    //    }

    //    static int Counter(Girls[] girls)
    //    {
    //        int count = 0;
    //        for (int i = 0; i < girls.Length; i++)
    //        {
    //            if (girls[i].Result != int.MaxValue) count++;
    //        }
    //        return count;
    //    }
    //    static Girls[] Sort(Girls[] girls)
    //    {

    //        for (int i = 1; i < girls.Length; i++)
    //        {
    //            Girls temp;
    //            if (girls[i].Result < girls[i - 1].Result)
    //            {
    //                temp = girls[i];
    //                girls[i] = girls[i - 1]; girls[i - 1] = temp;
    //            }
    //        }
    //        return girls;
    //    }
    //}
    //часть 2 задание 4
    //public struct Sportsmen
    //{
    //    private string _surname;
    //    double _points;
    //    public Sportsmen(string surname, double points)
    //    {
    //        _surname = surname;
    //        _points = points;
    //    }
    //    public double Points
    //    { get { return _points; } }

    //    public string Surname
    //    { get { return _surname; } }

    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Sportsmen[] list_of_sportsmens = {
    //            new Sportsmen("Tsoy", Point_Generator()),
    //            new Sportsmen("Letov", Point_Generator()),
    //            new Sportsmen("Klinskih", Point_Generator()),
    //            new Sportsmen("Osbourne", Point_Generator()) };
    //        for (int i = 0; i < list_of_sportsmens.Length; i++)
    //        {
    //            Console.WriteLine($"имя: {list_of_sportsmens[i].Surname} очки: {list_of_sportsmens[i].Points}");
    //        }
    //        Sort(list_of_sportsmens);
    //        Console.WriteLine("список спортсменов по местам");
    //        for (int i = 0; i < list_of_sportsmens.Length; i++)
    //        {
    //            Console.WriteLine($"имя: {list_of_sportsmens[i].Surname} очки: {list_of_sportsmens[i].Points}");
    //        }

    //    }
    //    static double Point_Generator()
    //    {
    //        int[] points = new int[4]; double total_points = 0;
    //        Random point = new Random();
    //        for (int i = 0; i < 4; i++)
    //        {
    //            points[i] = point.Next(0, 42);
    //        }

    //        //поиск максимума
    //        int max = int.MinValue; int imax = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (points[i] > max)
    //            {
    //                max = points[i]; imax = i;
    //            }
    //        }

    //        //поиск минимума 
    //        int min = int.MaxValue; int imin = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (points[i] < min)
    //            {
    //                min = points[i]; imin = i;
    //            }
    //        }

    //        int sum = 0;
    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (i != imax && i != imin) sum += points[i];
    //        }

    //        //финальные очки
    //        total_points = sum * K();

    //        return total_points;
    //    }
    //    static double K()
    //    {
    //        double k = 2.5;
    //        double[] k_list = new double[6];
    //        for (int i = 0; i < 6; i++)
    //        {
    //            k_list[i] = k;
    //            k += 0.2;
    //        }
    //        Random random = new Random();
    //        int K = random.Next(0, 5);
    //        k = k_list[K];
    //        return k;
    //    }
    //    static Sportsmen[] Sort(Sportsmen[] sportsmens)
    //    {
    //        Sportsmen man;
    //        for (int i = 0; i < sportsmens.Length; i++)
    //        {
    //            for (int j = i + 1; j < sportsmens.Length; j++)
    //            {
    //                if (sportsmens[j].Points > sportsmens[i].Points)
    //                {
    //                    man = sportsmens[i];
    //                    sportsmens[i] = sportsmens[j];
    //                    sportsmens[j] = man;
    //                }
    //            }

    //        }
    //        return sportsmens;
    //    }
    //}
    //часть 3 задание 4
    //public struct Sportmen
    //{
    //    private string _name;
    //    private int _points;
    //    public Sportmen(string name, int points)
    //    {
    //        _name = name;
    //        _points = points;
    //    }
    //    public string Name { get { return _name; } }
    //    public int Points { get { return _points; } }

    //}
    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Sportmen[] s = new Sportmen[6];
    //        for (int i = 0; i < FirstGroup().Length; i++)
    //        {
    //            s[i] = FirstGroup()[i];
    //        }
    //        for (int i = 0; i < SecondGroup().Length; i++)
    //        {
    //            s[i + FirstGroup().Length] = SecondGroup()[i];
    //        }

    //        Console.WriteLine("неотсортированный список");
    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            Console.WriteLine($"фамилия:{s[i].Name} , очки: {s[i].Points}");
    //        }
    //        Sort(s);
    //        Console.WriteLine("отсортированный список");
    //        for (int i = 0; i < s.Length; i++)
    //        {
    //            Console.WriteLine($"фамилия:{s[i].Name} , очки: {s[i].Points}");
    //        }

    //    }
    //    static Sportmen[] FirstGroup()
    //    {
    //        Sportmen[] list_of_sportsmens1 = new Sportmen[3] {
    //        new Sportmen("Jordan", 44),
    //        new Sportmen("Bryant", 55),
    //        new Sportmen("Lebron", 66)};
    //        Sort(list_of_sportsmens1);
    //        return list_of_sportsmens1;
    //    }
    //    static Sportmen[] SecondGroup()
    //    {
    //        Sportmen[] list_of_sportsmens2 = new Sportmen[3] {
    //        new Sportmen("Curry", 22),
    //        new Sportmen("Garnett", 54),
    //        new Sportmen("Iverson", 98)};
    //        Sort(list_of_sportsmens2);
    //        return list_of_sportsmens2;
    //    }
    //    static Sportmen[] Sort(Sportmen[] list)
    //    {
    //        Sportmen temp;
    //        for (int i = 0; i < list.Length; i++)
    //        {
    //            for (int j = i + 1; j < list.Length; j++)
    //            {
    //                if (list[j].Points > list[i].Points)
    //                {
    //                    temp = list[i];
    //                    list[i] = list[j];
    //                    list[j] = temp;
    //                }
    //            }
    //        }
    //        return list;
    //    }
    //}
}