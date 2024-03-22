using System;
using System.Globalization;
namespace contr2
{
    public class Game
    {
        private int _guessedNum;
        private bool _isGuessed;
        private int _attemptsCount = 1;
        private int _record = Int32.MaxValue;

        public void StartGame(int writtenNum)
        {
            _isGuessed = false;
            if (_guessedNum != writtenNum)
            {
                if (writtenNum > _guessedNum)
                    Console.WriteLine("Введенное число больше");
                else
                    Console.WriteLine("Введенное число меньше");
                _attemptsCount++;
            }
            else
            {
                _isGuessed = true;
                if (_attemptsCount < _record)
                    _record = _attemptsCount;
                Console.WriteLine($"Число: {_guessedNum} Количество попыток: {_attemptsCount} Рекорд: {_record}");
            }
        }

        public bool IsGuessed => _isGuessed;
    }
    public class GuessGame : Game
    {
        public void StartGame(int leftBorder, int rightBorder)
        {
            Random rnd = new Random();
            int _guessedNum = rnd.Next(leftBorder, rightBorder);
            StartGame(Convert.ToInt32(Console.ReadLine()));
        }
    }

    internal static class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int Num = rnd.Next(0, 10);
            GuessGame GGame = new GuessGame();
            int Written;
            Console.WriteLine("Введите левую границу:");
            int Left = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите правую границу:");
            int Right = Convert.ToInt32(Console.ReadLine());
            GGame.StartGame(Left, Right);
            while (GGame.IsGuessed == false)
                GGame.StartGame(Convert.ToInt32(Console.ReadLine()));
        }
    }
}