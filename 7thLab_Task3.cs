
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7thLab_Task3
{

    class Person
    {

        private string _name;
        private int _pos;

        public string Name { get { return _name; } }
        public int Pos { get { return _pos; } }

        public Person(string name, int pos)
        {
            _name = name;
            _pos = pos;
        }

    }

    class Program
    {
        abstract class Team
        {

            private string _name;
            private Person[] _persons;

            public string Name { get { return _name; } }

            public Person[] Persons { get { return _persons; } }

            public Team(string name, Person[] persons)
            {
                _name = name;
                _persons = persons;
            }

            public int TeamPoints()
            {
                int points = 0;
                foreach (Person person in Persons)
                {
                    if (person.Pos >= 1 && person.Pos <= 5) points += 5 - (person.Pos - 1);
                }
                return points;
            }
            public virtual void Print() => Console.WriteLine($"Team: {Name} Points: {TeamPoints()}");
        }

        class MaleTeam : Team
        {
            private string _name;
            private Person[] _persons;

            public MaleTeam(string name, Person[] persons) : base(name, persons)
            {
                _name = name;
                _persons = persons;
            }
            public override void Print()
            {
                Console.WriteLine($"Мale Team: {Name} Points: {TeamPoints()}");
            }

        }
        class FemaleTeam : Team
        {
            private string _name;
            private Person[] _persons;

            public FemaleTeam(string name, Person[] persons) : base(name, persons)
            {
                _name = name;
                _persons = persons;
            }
            public override void Print()
            {
                Console.WriteLine($"Female Team: {Name} Points: {TeamPoints()}");
            }

        }

        static void Main()
        {

            Person[] teamBlack = new Person[6];

            teamBlack[0] = new Person("Ivanov", 3);
            teamBlack[1] = new Person("Petrov", 6);
            teamBlack[2] = new Person("Sidorov", 8);
            teamBlack[3] = new Person("Smirnov", 14);
            teamBlack[4] = new Person("Sparrow", 16);
            teamBlack[5] = new Person("Sanchez", 15);

            Person[] teamWhite = new Person[6];

            teamWhite[0] = new Person("Rai", 1);
            teamWhite[1] = new Person("Dai", 7);
            teamWhite[2] = new Person("Nai", 5);
            teamWhite[3] = new Person("Vai", 10);
            teamWhite[4] = new Person("Tay", 11);
            teamWhite[5] = new Person("May", 12);

            Person[] teamBlue = new Person[6];

            teamBlue[0] = new Person("Ret", 2);
            teamBlue[1] = new Person("Ter", 4);
            teamBlue[2] = new Person("Mer", 9);
            teamBlue[3] = new Person("Ser", 18);
            teamBlue[4] = new Person("Ley", 17);
            teamBlue[5] = new Person("Pop", 13);

            Team[] teams = new Team[3];
            teams[0] = new MaleTeam("Black Team", teamBlack);
            teams[1] = new MaleTeam("White Team", teamWhite);
            teams[2] = new FemaleTeam("Blue Team", teamBlue);

            Sort(teams);

            teams[0].Print();

            Console.ReadLine();

        }
        static void Sort(Team[] teams)
        {
            int i = 1;
            int j = i + 1;
            while (i < teams.Length)
            {
                if (i == 0 || teams[i].TeamPoints() <= teams[i - 1].TeamPoints())
                {
                    i = j;
                    i++;
                }
                else if (teams[i].TeamPoints() > teams[i - 1].TeamPoints())
                {
                    Team temp = teams[i - 1];
                    teams[i - 1] = teams[i];
                    teams[i] = temp;
                }
                else if (teams[i].TeamPoints() == teams[i - 1].TeamPoints())
                {
                    if (Favorite(teams[i]))
                    {
                        Team temp = teams[i];
                        teams[i] = teams[i - 1];
                        teams[i - 1] = temp;
                    }
                    else { continue; }
                }
            }
        }

        private static bool Favorite(Team team)
        {
            foreach (Person person in team.Persons)
            {
                if (person.Pos == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}



