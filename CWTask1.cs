namespace CWTask1
{
    public struct Disciple
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private int[] _grades;
        private double _averagegrade;
        private string _reddiplom;

        public string Name => _firstname + " " + _lastname;
        public void PrintFirstList() => Console.WriteLine($"Имя: {Name}\n Оценки: {_grades}");
        private void StatusRed(string _reddiplom)
        {
            if(_averagegrade >= 4.5)
            {
                Console.WriteLine("Студент получает красный диплом!");
            }
            else
            {
                Console.WriteLine("Студент не получает красный диплом!");
            }
        }
        public void PrintSecondList() => Console.WriteLine($"Имя: {Name}\n Возраст: {_age}\n Средний балл: {_averagegrade}\n Статус Краснодипломник: {StatusRed}");
        public Disciple(string firstname, string lastname, int age, double averagegrade, int[] grades) 
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
            _averagegrade = averagegrade;
            _reddiplom = "";
            _grades = grades;
        }
    }
    class Program
    {
        static void Main()
        {
            Disciple[] students = new Disciple[5];
           students[0] = new Disciple("Иванов", "Павел", 18, 4.6, [5, 5, 5, 4, 4]);
           students[1] = new Disciple("Попов", "Иван", 19, 4, [5, 5, 5, 4, 4]);
            students[2] = new Disciple("Орлов", "Дмитрий", 18, 4.3, [4, 4, 4, 5, 5]);
            students[3] = new Disciple("Петров", "Александр", 20, 5, [5, 5, 5, 5, 5]);
            students[4] =new Disciple("Емельянов", "Илья", 21, 3.9, [4, 4, 4, 4, 3]);

           // Sort(students);
            foreach (Disciple student in students)
            { 
                student.PrintSecondList();
            }
            Console.ReadLine();

            static void Sort(Disciple[] students )
            {
                int index = 1;
                int index1 = index + 1;
                while ( index < students.Length ) 
                {
                   
                }
            }
        }
    }
}
