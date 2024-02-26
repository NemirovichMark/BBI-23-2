using System;
using System.Globalization;
//task #5
namespace lab6
{
    public struct Student
    {
        private string _name;
        private int _mark;
        private int _countMissed;

        public Student(string name, int mark, int countMissed)
        {
            _name = name;
            _mark = mark;
            _countMissed = countMissed;
        }

        public int Mark => _mark;

        public int CountMissed => _countMissed;

        public void WriteStudent()
        {
            Console.WriteLine($"{_name} {_mark} {_countMissed}");
        }
    }

    internal static class Program
    {
        static void Main()
        {
            //creating array of students
            Student[] students = new Student[5]
            {
                new Student("Bob", 2, 3),
                new Student("Alex", 3, 9),
                new Student("John", 4, 1),
                new Student("Mary", 2, 5),
                new Student("Katy", 2, 6)
            };

            //counting not passed students
            int count = 0;
            for (int i = 0; i < students.Length; i++) 
                if (students[i].Mark == 2)
                    count++;

            //creating array of not passed students
            Student[] notPassed = new Student[count];
            int j = 0;
            for (int i = 0; i < students.Length; i++)
                if (students[i].Mark == 2)
                {
                    notPassed[j] = students[i];
                    j++;
                }

            //sorting array of not passed students
            for (int i = 0; i < notPassed.Length - 1; i++)
                for (int k = 0; k < notPassed.Length - i - 1; k++)
                    if (notPassed[k].CountMissed < notPassed[k + 1].CountMissed)
                        (notPassed[k], notPassed[k + 1]) = (notPassed[k + 1], notPassed[k]);

            //writing an array of not passed students
            for (int i = 0; i < notPassed.Length; i++)
                notPassed[i].WriteStudent();
        }
    }
}
