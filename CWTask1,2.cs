//задание 1

public struct Rectangle
{
    private double length;
    private double width;

    public double Length { get => length; set => length = value; }
    public double Width { get => width; set => width = value; }

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area()
    {
        return Length * Width;
    }

    public double Perimeter()
    {
        return 2 * (Length + Width);
    }

    public void CompareTo(Rectangle other)
    {
        if (Length > other.Length)
            Console.WriteLine($"Прямоугольник {Length} длиннее, чем {other.Length}");
        else if (Length < other.Length)
            Console.WriteLine($"Прямоугольник {other.Length} длиннее, чем {Length}");
        else
            Console.WriteLine($"Прямоугольники имеют одинаковую длину: {Length}");

        if (Width > other.Width)
            Console.WriteLine($"Прямоугольник {Width} шире, чем {other.Width}");
        else if (Width < other.Width)
            Console.WriteLine($"Прямоугольник {other.Width} шире, чем {Width}");
        else
            Console.WriteLine($"Прямоугольники имеют одинаковую ширину: {Width}");

        if (Area() > other.Area())
            Console.WriteLine($"Прямоугольник {Area()} больше по площади, чем {other.Area()}");
        else if (Area() < other.Area())
            Console.WriteLine($"Прямоугольник {other.Area()} больше по площади, чем {Area()}");
        else
            Console.WriteLine($"Прямоугольники имеют одинаковую площадь: {Area()}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Rectangle[] rectangles = new Rectangle[3];
        rectangles[0] = new Rectangle(3, 4);
        rectangles[1] = new Rectangle(5, 2);
        rectangles[2] = new Rectangle(4, 4);

        Console.WriteLine("Прямоугольники:");
        Console.WriteLine("№\tДлина\tШирина\tПлощадь\tПериметр");
        for (int i = 0; i < rectangles.Length; i++)
        {
            Console.WriteLine($"{i + 1}\t{rectangles[i].Length}\t{rectangles[i].Width}\t{rectangles[i].Area()}\t{rectangles[i].Perimeter()}");
        }

        Console.WriteLine("\nСравнение прямоугольников:");
        Console.WriteLine("№\tДлина\tШирина\tПлощадь\tПериметр");
        for (int i = 0; i < rectangles.Length - 1; i++)
        {
            for (int j = i + 1; j < rectangles.Length; j++)
            {
                Console.WriteLine($"Сравнение {i + 1} и {j + 1}:");
                rectangles[i].CompareTo(rectangles[j]);
            }
        }
    }
}



//задание 2



public abstract class Opening
{
    private string Name;
    private double Width;
    private double Length;
    private double Thickness;

    public Opening(string name, double width, double length, double thickness)
    {
        Name = name;
        Width = width;
        Length = length;
        Thickness = thickness;
    }

    public string Name1 { get => Name; set => Name = value; }
    public double Width1 { get => Width; set => Width = value; }
    public double Length1 { get => Length; set => Length = value; }
    public double Thickness1 { get => Thickness; set => Thickness = value; }

    public abstract double InstallationCost();
}

public class Window : Opening
{
    private int Layers;

    public Window(string name, double width, double length, double thickness, int layers)
        : base(name, width, length, thickness)
    {
        Layers = layers;
    }

    public int Layers1 { get => Layers; set => Layers = value; }

    public override double InstallationCost()
    {
        return Width1 * Length1 * Layers1 * 10; 
    }
}

public class Door : Opening
{
    private int Layers;
    private bool HasPattern;
    private bool HasGlass;

    public Door(string name, double width, double length, double thickness, int layers, bool hasPattern, bool hasGlass)
        : base(name, width, length, thickness)
    {
        Layers = layers;
        HasPattern = hasPattern;
        HasGlass = hasGlass;
    }

    public int Layers1 { get => Layers; set => Layers = value; }
    public bool HasPattern1 { get => HasPattern; set => HasPattern = value; }
    public bool HasGlass1 { get => HasGlass; set => HasGlass = value; }

    public override double InstallationCost()
    {
        double cost = Width1 * Length1 * Layers * 15;

        if (HasPattern)
            cost += 50; 
        if (HasGlass)
            cost += 100; 

        return cost;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Window[] windows = new Window[5];
        Door[] doors = new Door[5];

        for (int i = 0; i < windows.Length; i++)
        {
            windows[i] = new Window("Окно " + (i + 1), 3.0, 1.5, 0.5, i + 1);
            doors[i] = new Door("Дверь " + (i + 1), 2.0, 1.2, 0.2, i + 1, true, i % 2 == 0);
        }

        Console.WriteLine("\nОкна:");
        PrintOpenings(windows);

        Console.WriteLine("\nДвери:");
        PrintOpenings(doors);

        Opening[] allOpenings = new Opening[windows.Length + doors.Length];
        windows.CopyTo(allOpenings, 0);
        doors.CopyTo(allOpenings, windows.Length);

        
        for (int i = 0; i < allOpenings.Length - 1; i++)
        {
            for (int j = 0; j < allOpenings.Length - 1 - i; j++)
            {
                if (allOpenings[j].InstallationCost() > allOpenings[j + 1].InstallationCost())
                {
                    Opening temp = allOpenings[j];
                    allOpenings[j] = allOpenings[j + 1];
                    allOpenings[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nВсе проемы (окна и двери) отсортированные по стоимости:");
        Console.WriteLine("№\tНазвание\tШирина\tДлина\tТолщина\tСтоимость установки");
        for (int i = 0; i < allOpenings.Length; i++)
        {
            Console.WriteLine($"{i + 1}\t{allOpenings[i].Name1}\t\t{allOpenings[i].Width1}\t{allOpenings[i].Length1}\t{allOpenings[i].Thickness1}\t{allOpenings[i].InstallationCost()}");
        }
    }

    static void PrintOpenings(Opening[] openings)
    {
        Console.WriteLine("№\tНазвание\tШирина\tДлина\tТолщина\tСлои\tУзор\tСтекло");
        for (int i = 0; i < openings.Length; i++)
        {
            string hasPattern = openings[i] is Door ? (((Door)openings[i]).HasPattern1 ? "Да" : "Нет") : "-";
            string hasGlass = openings[i] is Door ? (((Door)openings[i]).HasGlass1 ? "Да" : "Нет") : "Да"; 
            string layers = openings[i] is Window ? ((Window)openings[i]).Layers1.ToString() : "-"; 
            string pattern = openings[i] is Window ? "-" : hasPattern; 

            Console.WriteLine($"{i + 1}\t{openings[i].Name1}\t\t{openings[i].Width1}\t{openings[i].Length1}\t{openings[i].Thickness1}\t{layers}\t{pattern}\t{hasGlass}");
        }
    }




}