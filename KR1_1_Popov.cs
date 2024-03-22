using System;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;

struct Goods
{
    private string name;
    private string description = $"Для товара описание не задано";
    private int cost;
    private Guid article = Guid.NewGuid();
    bool flag = false;

    public string Name => name;
    public int Cost => cost;
    public string Description => description;
    public Guid Article => article;


    public Goods(string name, int cost)
    {
        this.name = name;
        this.cost = cost;
    }
    public void change_description(string newdisc)
    {
        while (!flag)
        {
            if (newdisc != null && newdisc.Length >= 20 && newdisc.Length <= 200)
            {
                description = newdisc;
                flag = true;
            }
            else
            {
                Console.WriteLine("Строка должна быть не короче 20 символов и не длиннее 200");
            }
        }
    }
    public static void Display(Goods[] goods)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Наименование: {goods[i].Name}");
            Console.WriteLine($"Описание: {goods[i].Description}");
            Console.WriteLine($"Стоимость: {goods[i].Cost}");
            Console.WriteLine($"Артикул: {goods[i].Article}");
            Console.WriteLine("---------------");
        }
    }
}

class Program
{
    static void Main()
    {
        Goods[] goods = new Goods[5];
        goods[0] = new Goods("Молоко",15);
        goods[1] = new Goods("Кефир",10);
        goods[2] = new Goods("Йогурт",12);
        goods[3] = new Goods("Квас",17);
        goods[4] = new Goods("Вода",20);

        goods[0].change_description("Это лучшее молоко на рынке, что я когда-либо видел");
        goods[1].change_description("Это лучший кефир на рынке, что я когда-либо видел");
        goods[2].change_description("Это лучший йогурт на рынке, что я когда-либо видел");

        Array.Sort(goods, (x, y) => x.Cost.CompareTo(y.Cost));

        Goods.Display(goods);
    }
}