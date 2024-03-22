using System;
struct Car
{
    private string label;
    private string model;
    private string VIM;
    private int year;
    private int kilometrs;
    public string score; // для характеристики машины
    public Car(string label, string model, string VIM, int year, int kilometrs,string score)
    {
        this.label = label;
        this.model = model;
        this.year = year;
        this.VIM = VIM;
        this.year = year;
        this.kilometrs = kilometrs;
        this.score = score;
    }
    public int Getkilometrs()
    {
        return kilometrs;
    }
    public int Getyear()
    {
        return year;
    }
    public string Getlabel()
    {
        return label;
    }
    public string Getmodel()
    {
        return model;
    }
    public string GetVIMs()
    {
        return VIM;
    }

}
class Program
{
    
    static void Main(string[] args)
    {
        string[] VIMs = new string[5] { "93657483928123456", "4637184739854923", "6572938471049382", "7683029583019485", "7596049586783420" };
        int[] years = new int[5] { 2004, 2001, 1993, 2012, 2021 };
        int[] kilometrs = new int[5] { 11000, 120000, 450000, 120, 700 };
        string[] models = new string[5] { "S300", "E200", "E200", "GLS 300", "S500" };
        string[] label = new string[5] { "Mercedes", "Mercedes", "Mercedes", "Mercedes", "Mercedes Maybach" };

        
        Car[] cars = new Car[5];
       
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car(label[i], models[i], VIMs[i], years[i], kilometrs[i],"");
 
        }

        for (int i = 0; i < cars.Length; i++)
        {
            int kilometrs1 = cars[i].Getkilometrs();
            int years1 = cars[i].Getyear();
            double koof = kilometrs1 / years1;
            if (koof < 100) 
            {
                cars[i].score = "простаивающая";
            }
            if (100 < koof & koof < 500)
            {
                cars[i].score = "праздничная";
            }
            if (koof > 500)
            {
                cars[i].score = "рабочая";
            }
        }

        for (int i = 1; i < cars.Length; i++)
        {
            for (int j = 0; j < cars.Length - 1; j++)
            {
                if (cars[j].Getkilometrs() > cars[j + 1].Getkilometrs())
                {
                    Car car11 = cars[j];
                    cars[j] = cars[j + 1];
                    cars[j + 1] = car11;
                   

                }

            }
        }

        for (int i = 0;i < cars.Length;i++)
        {
            Console.WriteLine("Марка - {0}",cars[i].Getlabel());
            Console.WriteLine("Модель - {0}",cars[i].Getmodel());
            Console.WriteLine("Пробег - {0}",cars[i].Getkilometrs());
            Console.WriteLine("VIM номер - {0}",cars[i].GetVIMs());
            Console.WriteLine("тип - {0}",cars[i].score);
            Console.WriteLine("");

        }

    }
}
