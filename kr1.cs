using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public struct Car
{
    private string _Model;
    private string _Marka;
    private int _VimNumber;
    private int _Year;
    private int _Probeg;
    private string _Character;
    public Car(string Model, string Marka, int VimNumber, int Year, int Probeg, string Character)
    {
        _Model = Model;
        _Marka = Marka;
        _VimNumber = VimNumber;
        _Year = Year;
        _Probeg = Probeg;
        _Character = Character;
        if (Probeg >= 500)
        {
            Character = "Рабочая";
        }
        if (Probeg > 100 && Probeg <500)
        {
            Character = "Праздничная";
        }
        if (Probeg <= 100)
        {
            Character = "Простаивающая";
        }
        
    }
    public void Print()
    {
        Console.WriteLine($"{_Model} {_Marka} {_Year} {_VimNumber} {_Probeg} {_Character}");
    } 
}
class Program
{
    static void Main()
    {
        Car[] cars = new Car[5]
        {
            new Car("Mercedez", "AMG", 1354, 2006, 700),
            new Car("Lada", "Vesta", 1367, 2004, 300),
            new Car("Buggati", "Charon", 1287, 2002, 20),
            new Car("Ferrari", "Enzo", 1254, 1999, 52),
            new Car("Nissan", "Almera", 1398, 1998, 400)
        };
        for (int i = 0; i < cars.Length - 1; i++)
        {
            for (int j = i + 1; j < cars.Length; j++)
            {
                if (cars[i].Probeg < cars[j].Probeg)
                {
                    Car temp = cars[i];
                    cars[i] = cars[j];
                    cars[j] = temp;
                }
            }
        }
        Console.WriteLine("сортировка по пробегу");
        for (int i=0; i < cars.Length;i++)
        {
            cars[i].Print();
        }
    } 
}

