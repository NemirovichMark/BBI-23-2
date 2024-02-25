using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLevel
{
    class Program
    {
        private struct Student
        {
            private string _name;
            private int[] _grades;
            public string Name { get { return _name; } }

            public Student(string name, int[] grades)
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


            public void Print()
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

        static void Main()
        {
            Student[] students = new Student[5];
            students[0] = new Student("Sergey IvanovZaq", [3, 4, 5]);
            students[1] = new Student("Jack Sparrow", [3, 3, 3]);
            students[2] = new Student("Valeriy Karpin", [4, 3, 4]);
            students[3] = new Student("Rick Sanchez", [4, 4, 5]);
            students[4] = new Student("Morty", [3, 2, 5]);

            Sort(students);

            foreach (Student student in students)
            {
                student.Print();
            }

            Console.ReadLine();


        }

        static void Sort(Student[] students)
        {
            if (students == null || students.Length <= 0) { return; } // Валидация на пропуск к сортировке
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i; j < students.Length; j++)
                {
                    if (students[j].AverageGrade() > students[i].AverageGrade())
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
    }
}

