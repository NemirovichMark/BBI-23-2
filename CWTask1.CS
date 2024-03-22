//Вариант 14 задание 1
struct GuessGame
{
    public int toGuess;
    public bool Guessed;
    public int attempts;
    public int record;
    public void Guess(int guess)
    {
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
}
class Program
{
    static void Main()
    {
        Random random = new Random();   
        GuessGame game = new GuessGame();
        game.toGuess = random.Next(0, 11);
        game.Guessed = false;
        game.attempts = 1;
        game.record = Int32.MaxValue;

        while (!game.Guessed)
        {
            Console.Write("Загадайте число в пределах (0-10): ");
            int guess = Convert.ToInt32(Console.ReadLine());
            game.Guess(guess);
        }

        Console.WriteLine("Вы угадали число!");
        Console.WriteLine("Число: {0}", game.toGuess);
        Console.WriteLine("Количество попыток: {0}", game.attempts);
        Console.WriteLine("Рекорд: {0}", game.record);
    }
}
