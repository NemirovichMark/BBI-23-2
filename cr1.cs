public struct Contract
{
    private string _name;
    private string _surname;
    private string _phonenum;
    private string _email;
    private static int Num = 1;
    private int _num;

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

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {_name,10} Фамилия:{_surname,10}  Телефон:{_phonenum,10}  Эл.почта:{_email,10}  Порядковый номер:{_num,10}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Contract[] contract = new Contract[5];
        contract[0] = new Contract("Иванов", "Иван", "+79774913252", "ivanov@gmail.com");
        contract[1] = new Contract("Петров", "Петр", "+79774913253", "petrov@gmail.com");
        contract[2] = new Contract("Сашин", "Саша", "+79774913254", "sashin@gmail.com");
        contract[3] = new Contract("Андрев", "Андрей", "+79774913255", "andrew@gmail.com");
        contract[4] = new Contract("Игорев", "Игорь", "+79774913256", "igorev@gmail.com");


        var sortedContact = contract.OrderBy(c => c.GetSurname()).ThenBy(c => c.GetName()).ToArray();

        foreach (Contract guy in sortedContact)
        {
            guy.PrintInfo();
        }

    }

}
