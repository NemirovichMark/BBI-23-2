// exercise 2.1
using System;

class Program
{
    struct Exam
    {
        private string second_name;
        private double first_exam;
        private double second_exam;
        private double third_exam;
        private double fourth_exam;
        private double points;

        public Exam(string second_name, double first_exam, double second_exam, double third_exam, double fourth_exam)
        {
            this.second_name = second_name;
            this.first_exam = first_exam;
            this.second_exam = second_exam;
            this.third_exam = third_exam;
            this.fourth_exam = fourth_exam;
            this.points = (first_exam + second_exam + third_exam + fourth_exam) / 4;
        }

        public string GetExamInfo()
        {
            if (points >= 4)
            {
                return $" Фамилия {second_name} | Средний балл: {points}  \n";
            }
            else
            {
                return $" ";
            }

        }
        public double GetResult()
        {
            return points;
        }
    }
    static void Main()
    {
        Exam[] student = new Exam[5];

        student[0] = new Exam("Иванов", 5, 4, 3, 5);
        student[1] = new Exam("Петров", 5, 3, 4, 4);
        student[2] = new Exam("Сидоров", 3, 3, 3, 4);
        student[3] = new Exam("Кузнецов", 5, 5, 4, 5);
        student[4] = new Exam("Макаров", 5, 4, 3, 2);

        for (int i = 0; i < student.Length - 1; i++)
        {
            for (int j = 0; j < student.Length - 1 - i; j++)
            {
                if (student[j].GetResult() < student[j + 1].GetResult())
                {
                    Exam temp = student[j];
                    student[j] = student[j + 1];
                    student[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < student.Length; i++)
        {
            Console.Write(student[i].GetExamInfo());
        }
    }
}
