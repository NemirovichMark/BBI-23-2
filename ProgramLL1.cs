using System;
public struct Book
{
    public string nomerKnigi;
    public int ISBN;
    public string Avtor;
    public int God;

    public void PrintInfo()
    {
        Console.WriteLine("Название  " + nomerKnigi);
        Console.WriteLine("ISBN  " + ISBN);
        Console.WriteLine("Автор  " + Avtor);
        Console.WriteLine("Год издания  " + God);
        Console.WriteLine(" ");
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[10];
        books[0] = new Book { nomerKnigi = "1", ISBN = 101, Avtor = "Avtor1", God = 2022 };
        books[1] = new Book { nomerKnigi = "2", ISBN = 102, Avtor = "Avtor2", God = 1995 };
        books[2] = new Book { nomerKnigi = "3", ISBN = 103, Avtor = "Avtor3", God = 1888 };
        books[3] = new Book { nomerKnigi = "4", ISBN = 104, Avtor = "Avtor1", God = 1999 };
        books[4] = new Book { nomerKnigi = "5", ISBN = 105, Avtor = "Avtor2", God = 1858 };
        books[5] = new Book { nomerKnigi = "6", ISBN = 106, Avtor = "Avtor3", God = 1966 };
        books[6] = new Book { nomerKnigi = "7", ISBN = 107, Avtor = "Avtor1", God = 1770 };
        books[7] = new Book { nomerKnigi = "8", ISBN = 108, Avtor = "Avtor2", God = 2005 };
        books[8] = new Book { nomerKnigi = "9", ISBN = 109, Avtor = "Avtor3", God = 1967 };
        books[9] = new Book { nomerKnigi = "10", ISBN = 110, Avtor = "Avtor1", God = 2001 };

        Console.WriteLine("Информация ");
        foreach (var book in books)
        {
            book.PrintInfo();
        }
        string ssAvtor = "Avtor1";

        Console.WriteLine("Информация о книгах автора " + ssAvtor);

        foreach (var book in books)
        {
            if (book.Avtor == ssAvtor)
            {
                book.PrintInfo();
            }
        }
        Console.WriteLine("определенный век для поиска книг");
        int oprVek = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Информация о книгах, которые навпсанны в " + oprVek);
        foreach (var book in books)
        {
            int knigaInVek = (book.God / 100) + 1;
            if (knigaInVek == oprVek)
            {
                book.PrintInfo();
            }
        }
    }
}
