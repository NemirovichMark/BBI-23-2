using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        struct Employee
        {
            private static int ID;
            public static int count_after_2020;
            private int _id;
            private string _name;
            private int _age;
            private int _year;
            private int _salary;
            public string Name { get { return _name; } }
            public int Salary { get { return _salary; } }
            public int Age { get { return _age; } }
            public int Year { get { return _year; } }
            public Employee(string name, int age, int year, int salary)
            {
                _id = ID; ID++;
                _name = name; _age = age;
                _year = year; _salary = salary;
                if (year > 2020) { count_after_2020++; }
            }
            public void Display()
            {
                Console.WriteLine($"{_id}. {_name}, {_age} лет, в {_year}г. принят на работу, зарплата - {_salary} у.е.");
            }
        }
        abstract class Company
        {
            protected string name;
            protected Employee[] employees;
            public Company(string name, Employee[] employees)
            {
                this.name = name;
                this.employees = employees;
            }
            public abstract double AverageSalary();

            public void PrintInfo()
            {
                Console.WriteLine($"{name}, средняя зарплата сотрудников - {AverageSalary()}");
            }
        }

        class ITCompany : Company
        {
            public ITCompany(string name, Employee[] employees) : base(name, employees)
            {

            }

            public override double AverageSalary()
            {
                double average = 0;
                int count = 0;
                foreach (Employee employee in employees)
                {
                    if (employee.Age > 20 && employee.Year <= 2022)
                    {
                        average += employee.Salary;
                        count++;
                    }
                }
                return average / count;
            }
        }

        class IndustrialCompany : Company
        {
            public IndustrialCompany(string name, Employee[] employees) : base(name, employees)
            {
            }

            public override double AverageSalary()
            {
                double average = 0;
                int count = 0;
                foreach (Employee employee in employees)
                {
                    if (employee.Age > 27 && employee.Year <= 2019)
                    {
                        average += employee.Salary;
                        count++;
                    }
                }
                return average / count;
            }
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Никита", 21, 2017, 60000); employees[2] = new Employee("Андрей", 19, 2021, 40000);
            employees[1] = new Employee("Мария", 28, 2016, 130000); employees[3] = new Employee("Виктор", 30, 2022, 100000);
            employees[4] = new Employee("Ксения", 18, 2023, 70000); Sort(employees);
            ITCompany[] itCompanies = new ITCompany[5];
            IndustrialCompany[] industrialCompanies = new IndustrialCompany[5];
            for (int i = 0; i < 5; i++)
            {
                itCompanies[i] = new ITCompany($"IT Company {i + 1}", employees);
                industrialCompanies[i] = new IndustrialCompany($"Industrial Company {i + 1}", employees);
            }
            SortCompanies(itCompanies);
            SortCompanies(industrialCompanies);
            foreach (Company company in itCompanies)
            {
                company.PrintInfo();
            }
            foreach (Company company in industrialCompanies)
            {
                company.PrintInfo();
            }
            Console.ReadKey();
        }

        static void Sort(Employee[] arr)
        {
            int n = arr.Length; for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j].Name.CompareTo(arr[j + 1].Name) > 0)
                    {
                        Employee temp = arr[j];
                        arr[j] = arr[j + 1]; arr[j + 1] = temp;
                    }
                }
            }
        }
        static void SortCompanies(Company[] arr)
        {
            int n = arr.Length; for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j].AverageSalary() > arr[j].AverageSalary())
                    {
                        Company temp = arr[j];
                        arr[j] = arr[j + 1]; arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
