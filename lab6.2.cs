public struct Jumper
{
    private string _name;
    private int _lengthrate;
    private int _rate;
    private int _score;

    public Jumper(string name, int length, int rate1, int rate2, int rate3, int rate4, int rate5)
    {
        _name = name;
        _lengthrate = (length - 120) * 2 + 60; // очки за длину прыжка
        int[] rate = new int[5]; // отсеивание наибольшего и наименьшего результата
        rate[0] = rate1;
        rate[1] = rate2;
        rate[2] = rate3;
        rate[3] = rate4;
        rate[4] = rate5;
        for (int i = 0; i < rate.Length - 1; i++)
        {
            for (int j = i; j < rate.Length; j++)
            {
                if (rate[i] < rate[j])
                {
                    int temp = rate[i];
                    rate[i] = rate[j];
                    rate[j] = temp;
                }
            }
        }
        _rate = rate[1] + rate[2] + rate[3];
        _score = _lengthrate + _rate; // финальные очки спортсмена
    }

    public string GetName()
    {
        return _name;
    }

    public int GetScore()
    {
        return _score;
    }
}


class Program
{
    static void Main()
    {
        Jumper[] jumper = new Jumper[5];

        jumper[0] = new Jumper("Конов", 115, 15, 17, 11, 10, 12);
        jumper[1] = new Jumper("Петров", 120, 11, 15, 12, 14, 13);
        jumper[2] = new Jumper("Иванов", 129, 20, 19, 17, 18, 16);
        jumper[3] = new Jumper("Смирнов", 125, 17, 17, 16, 18, 19);
        jumper[4] = new Jumper("Козлов", 128, 20, 18, 18, 15, 14);

        Sort(jumper);
        Print(jumper);
    }

    static void Sort(Jumper[] jumper)
    {
        for (int i = 0; i < jumper.Length - 1; i++)
        {
            for (int j = i; j < jumper.Length; j++)
            {
                if (jumper[i].GetScore() < jumper[j].GetScore())
                {
                    Jumper temp = jumper[i];
                    jumper[i] = jumper[j];
                    jumper[j] = temp;
                }
            }
        }
    }

    static void Print(Jumper[] jumper)
    {
        foreach (Jumper jump in jumper)
        {
            Console.WriteLine("{0}\t   {1}", jump.GetName(), jump.GetScore());
        }
    }

}
