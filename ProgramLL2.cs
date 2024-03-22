using System;
using System.Linq;

public abstract class Book
{
    public string nomerKnigi { get; set; }
    public int ISBN { get; set; }
    public string Avtor { get; set; }
    public int God { get; set; }
    public double priceBook { get; set; }

}
class Program
{
    static void Main()
    {
        PaperBook[] paperBooks = new PaperBook[5];
        ElectronicBook[] electronicBooks = new ElectronicBook[5];
        AudioBook[] audioBooks = new AudioBook[5];

        FillBooks(paperBooks, electronicBooks, audioBooks);

        
        Console.WriteLine("Книги в формате бумажных книг:");
        PrintBooks(paperBooks);

        Console.WriteLine("\nКниги в формате электронных книг:");
        PrintBooks(electronicBooks);

        Console.WriteLine("\nКниги в формате аудиокниг:");
        PrintBooks(audioBooks);
    }

    static void FillBooks(PaperBook[] paperBooks, ElectronicBook[] electronicBooks, AudioBook[] audioBooks)
    {
        for (int i = 0; i < 5; i++)
        {
            paperBooks[i] = new PaperBook { nomerKnigi = $"PaperBook{i + 1}", ISBN = 1000 + i, Avtor = $"Author{i}", God = 2000 + i, priceBook = 20 + (i * 5) };
            electronicBooks[i] = new ElectronicBook { nomerKnigi = $"ElectronicBook{i + 1}", ISBN = 2000 + i, Avtor = $"Author{i}", God = 2010 + i, priceBook = 15 + (i * 3) };
            audioBooks[i] = new AudioBook { nomerKnigi = $"AudioBook{i + 1}", ISBN = 3000 + i, Avtor = $"Author{i}", God = 2020 + i, priceBook = 25 + (i * 4) };
        }
    }

    static void PrintBooks(Book[] books)
    {
        foreach (var book in books)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Название: " + book.nomerKnigi);
            Console.WriteLine("ISBN: " + book.ISBN);
            Console.WriteLine("Автор: " + book.Avtor);
            Console.WriteLine("Год издания: " + book.God);
        }
    }
}

