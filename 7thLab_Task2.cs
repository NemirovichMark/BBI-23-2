using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thLab_Task2
{

    class Program
    {
        abstract class Person
        {
            private string _name;
            private int[] _grades;

            public string Name { get { return _name; } }
            public Person(string name, int[] grades)
            {
                _name = name;
                _grades = grades;
            }

            public float AverageGrade()
            {
                float res = 0;
                for (int i = 0; i < _grades.Length; i++)
                {
                    if (_grades[i] == 2)
                    {
                        return 0;
                    }
                    res += _grades[i];
                }
                res = res / _grades.Length;
                return res;
            }


            public virtual void Print()
            {
                if (AverageGrade() != 0)
                {
                    Console.WriteLine($"{Name} {AverageGrade()}");
                }
                else
                {
                    Console.WriteLine($"{Name} отчислен");
                }
            }
        }

        class Student : Person
        {
            private int _id;
            public int Id { get { return _id; } }
            public Student(string name, int[] grades, int id) : base(name, grades)
            {
                _id = id;
            }
            public override void Print()
            {
                if (AverageGrade() != 0)
                {
                    Console.WriteLine($"{Name,-20} {AverageGrade(),-10:F1} {Id,-10:F1}");
                }
                else
                {
                    Console.WriteLine($"{Name,-20}отчислен    {Id,-10:F1}");
                }
            }
        }

        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("Sergey Ivanov", [3, 4, 5], 143);
            students[1] = new Student("Jack Sparrow", [3, 3, 3], 783);
            students[2] = new Student("Valeriy Karpin", [4, 3, 4], 210);
            students[3] = new Student("Rick Sanchez", [4, 4, 5], 305);
            students[4] = new Student("Morty", [3, 2, 5], 549);

            GnomeSort(students);

            Console.WriteLine("Name           Average Grade     ID");
            Console.WriteLine("-------------------------------------");

            foreach (Student student in students)
            {
                student.Print();
            }

            Console.ReadLine();


        }
        static void GnomeSort(Student[] students)
        {
            int i = 1;
            int j = i + 1;
            while (i < students.Length)
            {
                if (i == 0 || students[i].AverageGrade() <= students[i - 1].AverageGrade())
                {
                    i = j;
                    j++;
                }
                else
                {
                    Student temp = students[i]; ;
                    students[i] = students[i - 1];
                    students[i - 1] = temp;
                    i--;
                }
            }
        }
    }
}
