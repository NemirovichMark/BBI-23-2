Вариант 14 задание 2
using System;
using System.Threading.Channels;

abstract class Game
{
    public abstract void StartGame(int from, int to);
}

class GuessGame : Game
{
    public override void StartGame(int from, int to)
    {
        Console.WriteLine("Введите начало диапазона");
        from = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конец диапазона");
        to = Convert.ToInt32(Console.ReadLine());
        if (to - from < 2 && from > 0 && to > 0)
        {
            Console.WriteLine("Недопустимый диапазон чисел!");
            return;
        }

        Random random = new Random();
        int toGuess = random.Next(from, to);
        bool Guessed = false;
        int attempts = 1;
        int record = Int32.MaxValue;

        while (!Guessed)
        {
            Console.Write($"Загадайте число в пределах ({from}-{to}): ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == toGuess)
            {
                Guessed = true;
                if (attempts < record)
                {
                    record = attempts;
                }
            }
            else
            {
                if (guess < toGuess)
                {
                    Console.WriteLine("Число меньше загаданного");
                }
                else
                {
                    Console.WriteLine("Число больше загаданного");
                }
                attempts++;
            }
        }

        Console.WriteLine("Вы угадали число!");
        Console.WriteLine($"Число: {toGuess}");
        Console.WriteLine($"Количество попыток: {attempts}");
        Console.WriteLine($"Рекорд: {record}");
    }
}

class Program
{
    static void Main()
    {
        GuessGame game = new GuessGame();
        game.StartGame(0, 10);
    }
}
