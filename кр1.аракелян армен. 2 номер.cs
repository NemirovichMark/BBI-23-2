using System;
using System.Collections.Generic;
using System.Linq;

abstract class Book : IComparable<Book>
{
    public string Title { get; }
    public long ISBN { get; }
    public string Author { get; }
    public int Year { get; }
    public decimal Price { get; }

    public Book(string title, long isbn, string author, int year, decimal price)
    {
        Title = title;
        ISBN = isbn;
        Author = author;
        Year = year;
        Price = price;
    }

    public abstract decimal CalculatePrice();

    public int CompareTo(Book other)
    {
        return other.Price.CompareTo(Price);
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Price: {Price:C}");
    }
}

class PaperBook : Book
{
    public bool HardCover { get; }

    public PaperBook(string title, long isbn, string author, int year, decimal price, bool hardCover)
        : base(title, isbn, author, year, price)
    {
        HardCover = hardCover;
    }

    public override decimal CalculatePrice()
    {
        return HardCover ? Price * 1.2m : Price;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Hard Cover: {HardCover}");
    }
}

class ElectronicBook : Book
{
    public string Format { get; }

    public ElectronicBook(string title, long isbn, string author, int year, decimal price, string format)
        : base(title, isbn, author, year, price)
    {
        Format = format;
    }

    public override decimal CalculatePrice()
    {
        return Price;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Format: {Format}");
    }
}

class AudioBook : Book
{
    public bool StudioRecorded { get; }

    public AudioBook(string title, long isbn, string author, int year, decimal price, bool studioRecorded)
        : base(title, isbn, author, year, price)
    {
        StudioRecorded = studioRecorded;
    }

    public override decimal CalculatePrice()
    {
        return StudioRecorded ? Price * 1.5m : Price;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Studio Recorded: {StudioRecorded}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[]
        {
            new PaperBook("Анна Каренина", 9780743273565, "Толстой", 1873, 20.50m, true),
            new ElectronicBook("Гордость и предубеждение", 9780061120084, "Остен", 1797, 15.99m, "pdf"),
            new AudioBook("Евгений Онегин", 9780451524935, "Пушкин", 1831, 25.00m, true),
            new PaperBook("Мартин Иден", 9780141439518, "Лондон", 1909, 18.75m, false),
            new ElectronicBook("Братья Карамазовы", 9780590353427, "Достоевский", 1880, 12.99m, "epub"),
            new AudioBook("Собор Парижской Богоматери", 9780316769488, "Гюго", 1831, 30.00m, false),
            new PaperBook("Малое собрание сочинений", 9780618640157, "Лермонтов", 1835, 40.25m, true),
            new ElectronicBook("Ромео и Джульетта", 9780547928227, "Шекспир", 1595, 9.99m, "fb2"),
            new AudioBook("Мастер и Маргарита", 9780143058142, "Булгаков", 1928, 35.50m, true),
            new PaperBook("Финансист", 9780486278070, "Драйзер", 1912, 22.99m, false)
        };

        var paperBooks = books.OfType<PaperBook>().OrderByDescending(b => b.Price).ToList();
        var electronicBooks = books.OfType<ElectronicBook>().OrderByDescending(b => b.Price).ToList();
        var audioBooks = books.OfType<AudioBook>().OrderByDescending(b => b.Price).ToList();

        Console.WriteLine("Paper Books:");
        foreach (var book in paperBooks)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
        Console.WriteLine("Electronic Books:");
        foreach (var book in electronicBooks)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Audio Books:");
        foreach (var book in audioBooks)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }

        var allBooks = books.OrderByDescending(b => b.Price).ToList();

        Console.WriteLine("All Books:");
        foreach (var book in allBooks)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
    }
}