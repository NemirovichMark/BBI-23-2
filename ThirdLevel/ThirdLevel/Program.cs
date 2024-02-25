using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLevel
{
    public struct Person
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
        private struct Team
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
                foreach (Person person in _persons)
                {
                    switch (person.Pos)
                    {
                        case (1):
                            points += 5;
                            break;
                        case (2):
                            points += 4;
                            break;
                        case (3):
                            points += 3;
                            break;
                        case (4):
                            points += 2;
                            break;
                        case (5):
                            points += 1;
                            break;
                        default:
                            break;

                    }
                }
                return points;
            }

            public void Print() => Console.WriteLine($"Team: {Name} Points: {TeamPoints()}");

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
            teams[0] = new Team("Black", teamBlack);
            teams[1] = new Team("White", teamWhite);
            teams[2] = new Team("Blue", teamBlue);

            Sort(teams);

            foreach (Team team in teams)
            {
                team.Print();
            }

            Console.ReadLine();

        }

        static void Sort(Team[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = i; j < teams.Length; j++)
                {
                    if (teams[j].TeamPoints() > teams[i].TeamPoints())
                    {
                        Team temp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = temp;
                    }
                    else if (teams[j].TeamPoints() == teams[i].TeamPoints())
                    {
                        if (Favorite(teams[j]))
                        {
                            Team temp = teams[i];
                            teams[i] = teams[j];
                            teams[j] = temp;
                        }
                        else { continue; }
                    }
                }
            }
        }
        static bool Favorite(Team team)
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

