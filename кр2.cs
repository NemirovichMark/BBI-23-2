using System;

abstract class Company
{
    private string Name;
    private Company[] Employees;

    public abstract double CalculateAverageSalary();

    public Company(string name, Company[]employees)
    {
        Name = name;
        Employees = employees;

    }
}

class ItCompany : Company
{
    public int MaxAgeCriteria;

    public ItCompany(string name, Company[] employees, int maxAgeCriteria) : base(name, employees)
    {
        MaxAgeCriteria = maxAgeCriteria;
    }

    public override double CalculateAverageSalary()
    {
        double totalSalary = 0;
        foreach (var employee in Employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary / Employees.Length;
    }
}

class IndustrialCompany : Company
{
    public int MinYearsOfExperienceCriteria;

    public IndustrialCompany(string name, Company[] employees, int minYearsOfExperienceCriteria) : base(name, employees)
    {
        MinYearsOfExperienceCriteria = minYearsOfExperienceCriteria;
    }

    public override double CalculateAverageSalary()
    {
        double totalSalary = 0;
        foreach (var employee in Employees)
        {
            totalSalary += Company.Salary;
        }
        return totalSalary / Employees.Length;
    }
}

class Program
{
    static void Main()
    {
        Company[] itEmployees1 = new Company[]
        {
            new Employee("Иванов", 30, 2021, 50000),
            new Employee("Петров", 25, 2019, 45000),
            new Employee("Сидоров", 28, 2022, 52000),
            new Employee("Козлов", 35, 2020, 48000),
            new Employee("Смирнов", 32, 2023, 55000)
        };

        Company[] itEmployees2 = new Company[]
        {
            new Employee("Алексеев", 27, 2020, 47000),
            new Employee("Николаев", 29, 2021, 49000),
            new Employee("Григорьев", 31, 2019, 46000),
            new Employee("Федоров", 33, 2022, 51000),
            new Employee("Дмитриев", 26, 2023, 48000)
        };

        ItCompany itCompany1 = new ItCompany("IT Company 1", itEmployees1, 30);
        ItCompany itCompany2 = new ItCompany("IT Company 2", itEmployees2, 28);

        Company[] industrialEmployees1 = new Company[]
        {
            new Employee("Семенов", 40, 2018, 60000),
            new Employee("Павлов", 38, 2017, 58000),
            new Employee("Михайлов", 42, 2019, 62000),
            new Employee("Анатольев", 37, 2020, 57000),
            new Employee("Степанов", 39, 2016, 59000)
        };

        Company[] industrialEmployees2 = new Company[]
        {
            new Employee("Герасимов", 45, 2015, 65000),
            new Employee("Артемьев", 43, 2016, 63000),
            new Employee("Игнатьев", 41, 2018, 61000),
            new Employee("Тимофеев", 44, 2017, 64000),
            new Employee("Владимиров", 46, 2019, 66000)
        };

        IndustrialCompany industrialCompany1 = new IndustrialCompany("Industrial Company 1", industrialEmployees1, 5);
        IndustrialCompany industrialCompany2 = new IndustrialCompany("Industrial Company 2", industrialEmployees2, 4);

        Company[] companies = { itCompany1, itCompany2, industrialCompany1, industrialCompany2 };


        for (int i = 0; i < companies.Length - 1; i++)
        {
            for (int j = i + 1; j < companies.Length; j++)
            {
                if (companies[i].CalculateAverageSalary() < companies[j].CalculateAverageSalary())
                {
                    Company temp = companies[i];
                    companies[i] = companies[j];
                    companies[j] = temp;
                }
            }
        }


        Console.WriteLine("{0,-20} {1,-20}", "Название компании", "Средняя зарплата");
        Console.WriteLine(new string('-', 42));

        foreach (var company in companies)
        {
            Console.WriteLine("{0,-20} {1,-20}", company.Name, company.CalculateAverageSalary());
        }
    }
}