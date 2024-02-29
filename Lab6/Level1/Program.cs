using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    struct Participant
    {
        private string _surname;
        private string _group;
        private string _teacher;
        private int _result;
        private bool _passed;
        public bool Passed { get { return _passed; } }
        public int Result { get { return _result; } }
        public Participant(string surname, string group, string teacher, int result)
        {
            _surname = surname;
            _group = group;
            _teacher = teacher;
            _result = result;
            if (result <= 115) // Допустим, что норматив сдан, если результат не более 115 секунд
            {
                _passed = true;
            }
            else
            {
                _passed = false;
            }
        }

        public void Display()
        {
            if (_passed)
            {
                Console.WriteLine($"{_surname}, группа: {_group} / Преподаватель: {_teacher} / Результат: {_result} секунд - сдал(-а)");
            }
            else
            {
                Console.WriteLine($"{_surname}, группа: {_group} / Преподаватель: {_teacher} / Результат: {_result} секунд - не сдал(-а)");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Participant[] participants = new Participant[6]
            {
            new Participant("Arakelyan", "1", "Nemirovich", 95),
            new Participant("Ivanova", "2", "Karelin", 114),
            new Participant("Petrova", "2", "Nemirovich", 97),
            new Participant("Sidorova", "2", "Karelin", 147),
            new Participant("Bazieva", "1", "Nemirovich", 178),
            new Participant("Kudzaeva", "1", "Karelin", 132)
            };
            Sort(participants);
            for (int i = 0; i < participants.Length; i++)
            {
                participants[i].Display();
            }
            int c = 0;
            for (int i = 0; i < participants.Length; i++)
            {
                if (participants[i].Passed)
                {
                    c++;
                }

            }
            Console.WriteLine($"Кол-во участниц, выполнивших норматив: {c}");
        }

        static void Sort(Participant[] Participants)
        {
            for (int i = 1; i < Participants.Length; i++)
            {
                for (int j = 1; j < Participants.Length; j++)
                {
                    if (Participants[j].Result < Participants[j - 1].Result)
                    {
                        Participant temp = Participants[j];
                        Participants[j] = Participants[j - 1];
                        Participants[j - 1] = temp;
                    }
                }
            }
        }
    }
}
