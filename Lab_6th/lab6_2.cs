using System;

struct Ychastniki
{
    private string lastName;
    private double[] results;

    public string LastName => lastName;
    public double[] Results => results;

    public Ychastniki(string lastName, double[] results)
    {
        this.lastName = lastName;
        this.results = results;
    }

    public double BestResult()
    {
        double bestResult = results[0];
        for (int i = 1; i < results.Length; i++)
        {
            if (results[i] > bestResult)
            {
                bestResult = results[i];
            }
        }
        return bestResult;
    }

    public void Print()
    {
        Console.WriteLine($"Фамилия: {LastName} | Лучший результат: {BestResult()}");
    }
}

class Program
{
    static void Main()
    {
        Ychastniki[] participants = new Ychastniki[5];
        participants[0] = new Ychastniki("Попов", new double[] { 4.5, 4.6, 4.7 });
        participants[1] = new Ychastniki("Иванов", new double[] { 4.8, 4.9, 5.0 });
        participants[2] = new Ychastniki("Сидоров", new double[] { 5.1, 5.2, 5.3 });
        participants[3] = new Ychastniki("Петров", new double[] { 5.4, 5.5, 5.6 });
        participants[4] = new Ychastniki("Смирнов", new double[] { 5.7, 5.8, 5.9 });

        Console.WriteLine("\nПротокол соревнований по прыжкам в длину:");
        Console.WriteLine("=============================================");
        Console.WriteLine("Фамилия\t\tЛучший результат");
        Console.WriteLine("=============================================");

        foreach (var participant in participants)
        {
            participant.Print();
        }

        Console.WriteLine("=============================================");
    }
}
