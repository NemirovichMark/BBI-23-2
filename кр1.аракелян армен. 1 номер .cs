using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    struct Book
    {
        private static int ISBN;
        private int _isbn;
        private string _name;
        private string _author;
        private int _year;
        public Book(string name, string author, int year)
        {
            _isbn = ISBN;
            ISBN++;
            _name = name;
            _author = author;
            _year = year;
        }
        public void Print()
        {
            Console.WriteLine($"{_isbn}. '{_name}' - {_author}, {_year}г.");
        }
        public static string OneAuthor(Book[] arr, string a)
        {
            string res = "";
            foreach (Book b in arr)
            {
                if (b._author == a) { res += $"{b._name}; "; }
            }
            if (res == "")
            {
                res = "Книг данного автора не найдено";
            }
            return res;
        }
        public static string OneYear(Book[] arr, int a)
        {
            string res = "";
            foreach (Book b in arr)
            {
                if (b._year > (a - 1) * 100 && b._year <= a * 100) { res += $"{b._name}; "; }
            }
            if (res == "")
            {
                res = "Книг данного века не найдено";
            }
            return res;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            books[0] = new Book("Анна Каренина", "Толстой", 1873);
            books[1] = new Book("Гордость и предубеждение", "Остен", 1797);
            books[2] = new Book("Евгений Онегин", "Пушкин", 1831);
            books[3] = new Book("Мартин Иден", "Лондон", 1909);
            books[4] = new Book("Братья Карамазовы", "Достоевский", 1880);
            books[5] = new Book("Собор Парижской Богоматери", "Гюго", 1831);
            books[6] = new Book("Малое собрание сочинений", "Лермонтов", 1835);
            books[7] = new Book("Ромео и Джульетта", "Шекспир", 1595);
            books[8] = new Book("Мастер и Маргарита", "Булгаков", 1928);
            books[9] = new Book("Финансист", "Драйзер", 1912);
            for (int i = 0; i < books.Length; i++)
            {
                books[i].Print();
            }
            Console.WriteLine("Введите фамилию автора:");
            string aut = Console.ReadLine();
            Console.WriteLine(Book.OneAuthor(books, aut));
            Console.WriteLine("Введите век арабскими цифрами:");
            int ye = int.Parse(Console.ReadLine());
            Console.WriteLine(Book.OneYear(books, ye));
        }
    }
}