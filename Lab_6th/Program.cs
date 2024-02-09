using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6th
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
            Student[] bbi232 = new Student[2]; // создаем массив структур
            bbi232[0] = new Student(); // инициализируем (задаем значения) отдельным элементам массива
            bbi232[1] = new Student();
        }
    }
}
