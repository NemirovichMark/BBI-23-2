namespace Example_structures
{
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
            static private int _count;
            static Student()
            {
                _count = 0;
            }
            public Student(int id, string name, string surname, int age)
            {
                _id = id;
                _name = name;
                _surname = surname;
                _age = age;
                _count++;
            }
            public int ID { get { return _id; } }
            public int Age => _age; // read-only
            public static int Counter => _count; // output static field
            public void Display()
            {
                // Console.WriteLine(_id + " " + _name + " " + _surname + " " + _age);
                Console.WriteLine($"id = {_id}" +
                    $"name = {_name}" +
                    $"surname = {_surname}" +
                    $"age = {_age}");
            }
            public string Name
            {
                get { return _name; }
                set
                {
                    if (value != null && value.Length > 4) // validation is good
                        _name = value;
                }
            }
        }
        static void Main()
        {
            #region 1st_lesson
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
            #endregion
            #region 2nd_lesson
            Console.WriteLine(Student.Counter);
            Student[] bbi232 = new Student[4]{ // создаем массив структур
            new Student(5, "Anton", "Bakhtin", 22), // инициализируем (задаем значения) отдельным элементам массива
            new Student(3, "Vasya", "Astakhov", 24),
            new Student(7, "Maria", "Supryago", 20),
            new Student(4, "Kate", "Nefedova", 21)
            };
            // foreach - 1 - for output 2 - for iterative methods call
            foreach (var student in bbi232) //var = Student in this case
            {
                Console.WriteLine(student.ID + " " + student.Age); // o
            }

            Sort(bbi232);
            Console.WriteLine("Sorting . . .");

            foreach (var student in bbi232) // sorted array's output
            {
                Console.WriteLine(student.ID + " " + student.Age);
            }

            Student youngest = FindYoungest(bbi232); // return struct
            int youngestID = FindYoungestID(bbi232); // return only one struct's field
            FindYoungestRef(bbi232, ref youngest);  // return by ref


            foreach (var student in bbi232) //var = Student in this case
            {
                //if (student.Age == youngestID)
                student.Display();
            }

            Console.WriteLine(Student.Counter);
            #endregion
        }

        static void Sort(Student[] students)
        {
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].ID < students[i - 1].ID)
                {
                    var student = students[i];
                    int j = i - 1;
                    while (j >= 0 && student.ID < students[j].ID)
                    {
                        students[j + 1] = students[j];
                        j--;
                    }
                    students[j + 1] = student;
                }
            }
        }

        static Student FindYoungest(Student[] students)
        {
            if (students == null || students.Length <= 0) // validation
                return new Student();
            Student student = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if (student.Age > students[i].Age)
                {
                    student = students[i];
                }
            }
            return student;
        }
        static int FindYoungestID(Student[] students)
        {
            if (students == null || students.Length <= 0) // validation
                return 0;
            int studentID = 0;
            for (int i = 1; i < students.Length; i++)
            {
                if (studentID > students[i].Age)
                {
                    studentID = i;
                }
            }
            return studentID;
        }
        static void FindYoungestRef(Student[] students, ref Student youngest)
        {
            if (students == null || students.Length <= 0) // validation
                return;
            youngest = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if (youngest.Age > students[i].Age)
                {
                    youngest = students[i];
                }
            }
        }
    }
}
