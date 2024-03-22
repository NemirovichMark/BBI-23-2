using System;
struct Employee
{
    private string Name;
    private int UniqueID;
    private int Age;
    private int YearOfHiring;
    private double Salary;
    Employee[] employees = new Employee[5];
    private static int employeesHiredAfter2020 = 0;

    public Employee(string name, int age, int yearOfHiring, double salary)
    {
        Name = name;
        UniqueID = ++employeesHiredAfter2020;
        Age = age;
        YearOfHiring = yearOfHiring;
        Salary = salary;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Сотрудник {Name} (Табельный номер: {UniqueID})");
        Console.WriteLine($"Возраст: {Age}, Год приема на работу: {YearOfHiring}, Зарплата: {Salary}");
        Console.WriteLine();
    }
    public static void SortEmployees(Employee[] employees)
    {
        for (int i = 0; i < employees.Length - 1; i++)
        {
            for (int j = i + 1; j < employees.Length; j++)
            {
                if (string.Compare(employees[i].Name, employees[j].Name) > 0)
                {
                    Employee temp = employees[i];
                    employees[i] = employees[j];
                    employees[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[5];
        employees[0] = new Employee("Иванов", 30, 2021, 50000);
        employees[1] = new Employee("Петров", 25, 2019, 45000);
        employees[2] = new Employee("Сидоров", 28, 2022, 52000);
        employees[3] = new Employee("Козлов", 35, 2020, 48000);
        employees[4] = new Employee("Смирнов", 32, 2023, 55000);

        Employee.SortEmployees(employees);

        foreach (var employee in employees)
        {
            employee.DisplayInfo();
        }
    }
}
















