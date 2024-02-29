public struct Teacher
{
    private string _name; // поля - переменные, используемые во всей структуре
    private string _surname;
    private int _age;

    public Teacher(string name, string surname, int age) // конструктор для заполнения при создании
    {
        _name = name;
        _surname = surname;
        _age = age;
    }
    public void Rename(string name) // метод, вызываемый у переменных типа Teacher
    {
        if (name != null)
        {
            _name = name;
        }
    }

    public void Print()// метод, вызываемый у переменных типа Teacher
    {
        Console.WriteLine($"Name: {_name}\nSurname: {_surname}\nAge: {_age}");
    }
}
internal class Program
{
    private struct Student
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _age;
        public Student(int id, string name, string surname, int age)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _age = age;
        }
        public int ID { get { return _id; } }
        public int Age => _age;
    }
    static void Main()
    {
        int a;
        double b;
        string str;
        int[] arr;
        Teacher Mark = new Teacher(); // создание конструктором по умолчанию
        Mark.Print();// вызов метода переменной типа Teacher
        Mark.Rename("Jack");// вызов метода переменной типа Teacher
        Mark.Print();
        Teacher Galina = new Teacher("Galina", "Krujkova", 0);// создание своим конструктором
        Galina.Print();
        Student[] bbi232 = new Student[4]{ // создаем массив структур
            new Student(5, "Anton", "Bakhtin", 22), // инициализируем (задаем значения) отдельным элементам массива
            new Student(3, "Vasya", "Astakhov", 24),
            new Student(7, "Maria", "Supryago", 20),
            new Student(4, "Kate", "Nefedova", 21)
            };
        foreach (var student in bbi232) //var = Student in this case
        {
            Console.WriteLine(student.ID + " " + student.Age);
        }
    }

    static void Sort(Student[] students)
    {

    }
}