using System;

struct Gymnast
{
    private string _surname;
    private double _highestResult;

    public Gymnast(string famile1, double[] results)
    {
        _surname = famile1;
        _highestResult = results[0];
        
        for (int i = 1; i < 3; i++)
        {
            if (results[i] > _highestResult)
            {
                _highestResult = results[i];
            }
        }
    }

    public string GetSurname()
    {
        return _surname;
    }

    public double GetHighestResult()
    {
        return _highestResult;
    }

    public void PrintResult()
    {
        Console.WriteLine("Фамилия: {0}\t" + "Лучший результат: {1,4:f2}", _surname, _highestResult);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gymnast[] gymnasts = new Gymnast[5]
        {
            new Gymnast("Борисов", [15.7, 7.5, 16.0]),
            new Gymnast("Петров", [16.7, 9.5, 18.0]),
            new Gymnast("Иванов", [19.7, 2.5, 15.0]),
            new Gymnast("Николаев", [20.7, 5.5, 13.0]),
            new Gymnast("Андреев", [12.7, 9.5, 20.0])
        };

        for (int i = 0; i < gymnasts.Length - 1; i++)
        {
            double amax = gymnasts[i].GetHighestResult();
            int imax = i;
            for (int j = i + 1; j < gymnasts.Length; j++)
            {
                if (gymnasts[j].GetHighestResult() > amax)
                {
                    amax = gymnasts[j].GetHighestResult();
                    imax = j;
                }
            }

            (gymnasts[imax], gymnasts[i]) = (gymnasts[i], gymnasts[imax]);
        }

        Console.WriteLine();

        foreach (var gymnast in gymnasts)
        {
            gymnast.PrintResult();
        }
    }
}