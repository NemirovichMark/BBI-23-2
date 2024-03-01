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

            Person[] teamFishes = new Person[6];

            teamFishes[0] = new Person("Карасев", 17);
            teamFishes[1] = new Person("Карпов", 3);
            teamFishes[2] = new Person("Лещев", 9);
            teamFishes[3] = new Person("Лососев", 2);
            teamFishes[4] = new Person("Окунев", 8);
            teamFishes[5] = new Person("Осетров", 13);

            Person[] teamBirds = new Person[6];

            teamBirds[0] = new Person("Орлов", 16);
            teamBirds[1] = new Person("Воробьев", 4);
            teamBirds[2] = new Person("Синицын", 10);
            teamBirds[3] = new Person("Воронов", 5);
            teamBirds[4] = new Person("Цаплин", 14);
            teamBirds[5] = new Person("Ястребов", 18);

            Person[] teamAnimals = new Person[6];

            teamAnimals[0] = new Person("Слонов", 11);
            teamAnimals[1] = new Person("Козлов", 6);
            teamAnimals[2] = new Person("Собакин", 7);
            teamAnimals[3] = new Person("Кошкин", 12);
            teamAnimals[4] = new Person("Медведев", 15);
            teamAnimals[5] = new Person("Ёжиков", 1);

            Team[] teams = new Team[3];
            teams[0] = new Team("Fishes", teamFishes);
            teams[1] = new Team("Birds", teamBirds);
            teams[2] = new Team("Animals", teamAnimals);

            Sort(teams);

            foreach (Team team in teams)
            {
                team.Print();
            }


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