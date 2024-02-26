using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ThirstLevel
{
    struct Member
    {
        private string _firstName;
        private string _secondName;
        private float _res1;
        private float _res2;
        public string Name { get { return _firstName + " " + _secondName; } }
        public float BestRes { get { return _res1 > _res2 ? _res1 : _res2; } }

        public Member(string firstName, string secondName, float res1, float res2)
        {
            _firstName = firstName;
            _secondName = secondName;
            _res1 = res1;
            _res2 = res2;
        }

        public void Print() => Console.WriteLine($"Name: {Name}\nResult1: {_res1}\nResult2: {_res2}\nBestResult: {BestRes}");
    }


    class Program
    {

        static void Main()
        {
            Member[] members = new Member[4];
            members[0] = new Member("Sergey", "Ivanov", 2.4f, 1.0f);
            members[1] = new Member("Valeriy", "Karpin", 2.6f, 1.4f);
            members[2] = new Member("Jack", "Sparrow", 1.5f, 1.3f);
            members[3] = new Member("Rick", "Sanchez", 2.3f, 1.4f);

            Sort(members);

            foreach (Member member in members)
            {
                member.Print();
            }
            Console.ReadLine();
        }

        static void Sort(Member[] members)
        {
            for (int i = 0; i < members.Length - 1; i++)
            {
                for (int j = i; j < members.Length; j++)
                {

                    if (members[j].BestRes > members[i].BestRes)
                    {
                        Member temp = members[i];
                        members[i] = members[j];
                        members[j] = temp;
                    }
                }
            }
        }
    }
}

