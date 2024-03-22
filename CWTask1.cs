using System;
using System.Globalization;
namespace contr1
{
    public struct GuessGame
    {
        private int _guessedNum;
        private bool _isGuessed;
        private int _attemptsCount;
        private int _record;

        public GuessGame(int guessedNum)
        {
            _guessedNum = guessedNum;
            _isGuessed = false;
            _attemptsCount = 1;
            _record = Int32.MaxValue;
        }
        public void Guessing(int writtenNum)
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

    internal static class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int Num = rnd.Next(0, 10);
            GuessGame GGame = new GuessGame(Num);
            while (GGame.IsGuessed == false)
                GGame.Guessing(Convert.ToInt32(Console.ReadLine()));
        }
    }
}