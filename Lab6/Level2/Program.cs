using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Level2
{
    internal class Program
    {
        struct Student
        {
            private string _surname;
            private string _name;
            private double _math;
            private double _phys;
            private double _rus;
            private bool _passed;
            public bool Passed { get { return _passed; } }
            public Student(string surname, string name, double math, double phys, double rus)
            {
                _surname = surname;
                _name = name;
                _math = math;
                _phys = phys;
                _rus = rus;
                _passed = (_math != 2 & _phys != 2) & _rus != 2;
            }

            public double Avg()
            {
                return (_math + _phys + _rus) / 3;
            }
            public void Display()
            {
                Console.WriteLine($"{_surname} {_name}, средний балл: {Avg()}");
            }
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[7]
            {
                new Student("Kintina", "Darya", 4, 2, 5),
                new Student("Chernogus", "Maria", 4, 3, 5),
                new Student("Juravlev", "Stepan", 2, 3, 5),
                new Student("Abazov", "Aslan", 5, 5, 5),
                new Student("Litvin", "Mikhail", 2, 3, 2),
                new Student("Didaev", "Muhammad", 5, 4, 5),
                new Student("Kirchu", "Ksenia", 5, 4, 5)
            };
            Sort(students);
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Passed)
                students[i].Display();
            }
        }
        static void Sort(Student[] Students)
        {
            for (int i = 1; i < Students.Length; i++)
            {
                for (int j = 1; j < Students.Length; j++)
                {
                    if (Students[j].Avg() > Students[j - 1].Avg())
                    {
                        Student temp = Students[j];
                        Students[j] = Students[j - 1];
                        Students[j - 1] = temp;
                    }
                }
            }
        }
    }
}
