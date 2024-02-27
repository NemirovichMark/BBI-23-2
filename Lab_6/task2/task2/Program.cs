using System;

struct Sportik
{
    private string surname;
    private double result;

    public string Surname => surname;
    public double Result => result;

    public Sportik(string surname, double result)
    {
        this.surname = surname;
        this.result = result;
    }

    public void GetSportiksInfo()
    {
        Console.WriteLine($"фамилия: {Surname} | баллы: {result}");
    }
}

class Program
{
    static void Main()
    {
        Sportik[] sportiks = new Sportik[5];
        sportiks[0] = new Sportik("Popov", 5.5);
        sportiks[1] = new Sportik("Oganezov", 6);
        sportiks[2] = new Sportik("Machkalyan", 4.5);
        sportiks[3] = new Sportik("Ershov", 2.5);
        sportiks[4] = new Sportik("Aleksandrov", 10);

        Array.Sort(sportiks, (x, y) => y.Result.CompareTo(x.Result));

        for (int i = 0; i < sportiks.Length; i++)
        {
            sportiks[i].GetSportiksInfo();
        }
    }
}
