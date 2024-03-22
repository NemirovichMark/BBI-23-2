using System.Xml.Linq;
using System;

abstract class Contract
{
    protected string _name;
    protected string _surname;
    protected string _phonenum;
    protected string _email;
    protected static int Num = 1;
    protected int _num;

    public Contract(string name, string surname, string phonenum, string email)
    {
        _name = name;
        _surname = surname;
        _phonenum = phonenum;
        _email = email;
        _num = Num;
        Num++;
    }
    public string GetSurname()
    {
        return _surname;
    }

    public string GetName()
    {
        return _name;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Имя: {_name,10} Фамилия:{_surname,10}  Телефон:{_phonenum,10}  Эл.почта:{_email,10}  Порядковый номер:{_num,10}");
    }
}

class Employee: Contract
{
    private int _paycheck;
    private string _empdate;
    public Employee(string name, string surname, string phonenum, string email, int paycheck, string empdate) : base(name, surname, phonenum, email)
    {
        _paycheck = paycheck;
        _empdate = empdate;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Имя: {_name,5} Фамилия:{_surname,5} Телефон:{_phonenum,5} Эл.почта:{_email,5} Порядковый номер:{_num} Зарплата:{_paycheck, 5} Дата тр-ва {_empdate,5}");
    }
}

class Counteragent : Contract
{
    private int _contractcost;
    private int _contractterm; //days
    public Counteragent(string name, string surname, string phonenum, string email, int contractcost, int contractterm) : base(name, surname, phonenum, email)
    {
        _contractcost = contractcost;
        _contractterm = contractterm;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Имя: {_name,5} Фамилия:{_surname,5}  Телефон:{_phonenum,5}  Эл.почта:{_email,5}  Порядковый номер:{_num,5} Стоимость договора: {_contractcost,5} Срок договора {_contractterm,5} ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employee = new Employee[5];
        employee[0] = new Employee("Иванов", "Иван", "+79774913252", "ivanov@gmail.com",100000,"14.05,2003");
        employee[1] = new Employee("Петров", "Петр", "+79774913253", "petrov@gmail.com", 150000, "12.10,2005");
        employee[2] = new Employee("Сашин", "Саша", "+79774913254", "sashin@gmail.com", 130000, "11.07,2006");
        employee[3] = new Employee("Андрев", "Андрей", "+79774913255", "andrew@gmail.com", 110000, "17.01,2010");
        employee[4] = new Employee("Игорев", "Игорь", "+79774913256", "igorev@gmail.com", 170000, "10.08,2001");

        Counteragent[] counteragent = new Counteragent[5];
        counteragent[0] = new Counteragent("Смирнов", "Олег", "+79774913257", "smirnov@gmail.com", 1000000, 1000);
        counteragent[1] = new Counteragent("Кузнецов", "Петр", "+79774913258", "kuznets@gmail.com", 1500000, 700);
        counteragent[2] = new Counteragent("Васильев", "Олег", "+79774913259", "vasilev@gmail.com", 1300000, 1500);
        counteragent[3] = new Counteragent("Кашин", "Руслан", "+79774913260", "kashin@gmail.com", 1100000, 1200);
        counteragent[4] = new Counteragent("Орлов", "Игорь", "+79774913261", "orlov@gmail.com", 1700000, 1400);

        var sortedEmployee = employee.OrderBy(e => e.GetSurname()).ThenBy(e => e.GetName()).ToArray();

        foreach (Employee guy in sortedEmployee)
        {
            guy.PrintInfo();
        }

        Console.WriteLine();


        var sortedCouteragent = counteragent.OrderBy(c => c.GetSurname()).ThenBy(c => c.GetName()).ToArray();

        foreach (Counteragent agent in sortedCouteragent)
        {
            agent.PrintInfo();
        }
    }

}

