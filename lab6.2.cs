using System;
using System.Globalization;
//task #2
namespace lab6
{
    public struct Student
    {
        private string _name;
        private int _markMath;
        private int _markPhys;
        private int _markRus;

        public Student(string name, int markMath, int markPhys, int markRus)
        {
            _name = name;
            _markMath = markMath;
            _markPhys = markPhys;
            _markRus = markRus;
        }

        public int MarkMath => _markMath;

        public int MarkPhys => _markPhys;

        public int MarkRus => _markRus;

        public void WriteStudent()
        {
            Console.WriteLine($"{_name} Math: {_markMath} Physics: {_markPhys} Russian: {_markRus}");
        }

        public bool Passed => (_markMath != 2 && _markPhys != 2 && _markRus != 2);

        public double Average => (_markMath + _markPhys + _markRus) / 3.0;
    }

    internal static class Program
    {
        static void Main()
        {
            //creating a list of students
            Student[] students = new Student[5]
            {
                new Student("Alex", 2, 3, 4),
                new Student("Mark", 3, 3, 5),
                new Student("John", 4, 3, 5),
                new Student("Sam", 4, 3, 2),
                new Student("Pete", 5, 5, 4)
            };

            //counting passed students
            int countPassed = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Passed)
                    countPassed++;
            }

            //creating an array of passed students
            Student[] PassedStudents= new Student[countPassed];
            int j = 0;
            for (int i = 0; i < students.Length; i++)
                if (students[i].Passed)
                {
                    PassedStudents[j] = students[i];
                    j++;
                }

            //sorting an array of passed students
            for (int i = 0; i < PassedStudents.Length - 1; i++)
                for (int k = 0; k < PassedStudents.Length - i - 1; k++)
                    if (PassedStudents[k].Average < PassedStudents[k + 1].Average)
                        (PassedStudents[k], PassedStudents[k + 1]) = (PassedStudents[k + 1], PassedStudents[k]);

            //writing sorted array of passed students
            for (int i = 0; i < PassedStudents.Length; i++)
                PassedStudents[i].WriteStudent();
        }
    }
}
