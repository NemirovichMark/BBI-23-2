//2.1
using System;

struct Employee
{
    private static int number = 1;
    private string name;
    private int employeeNumber;
    private int age;
    private int hireYear;
    private double salary;
    private static int hiredAfter2020 = 0;
    public string Name { get { return name; } }
    public Employee(string name, int age, int hireYear, double salary)
    {
        this.name = name;
        this.age = age;
        this.hireYear = hireYear;
        this.salary = salary;
        employeeNumber = number;
        number++;
        if (hireYear > 2020)
        {
            hiredAfter2020++;
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Табельный номер: {employeeNumber}");
        Console.WriteLine($"Водраст: {age}");
        Console.WriteLine($"Год устройства: {hireYear}");
        Console.WriteLine($"Зарплата: {salary}");
        Console.WriteLine();
    }
    public static void PrintHiredAfter2020()
    {
        Console.WriteLine($"Устроились после 2020: {hiredAfter2020} человек");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[5];
        employees[0] = new Employee("Ярков", 35, 2022, 500000);
        employees[1] = new Employee("Ведерин", 28, 2023, 155000);
        employees[2] = new Employee("Дронов", 40, 2019, 160000);
        employees[3] = new Employee("Лежкин", 32, 2023, 152000);
        employees[4] = new Employee("Цой", 45, 2022, 148000);

        for (int i = 1; i < 5; i++)
        {
            Employee val = employees[i];
            for (int j = i - 1; j >= 0;)
            {
                if (val.Name.CompareTo(employees[j].Name) < 0)
                {
                    employees[j + 1] = employees[j];
                    j--;
                    employees[j + 1] = val;
                }
                else
                {
                    break;
                }
            }
        }

        foreach (Employee employee in employees)
        {
            employee.PrintInfo();
        }
        Employee.PrintHiredAfter2020();
        Console.ReadKey();
    }
}
