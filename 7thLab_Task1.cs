﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _7thLab_Task1
{
    class Member
    {
        private string _firstName;
        private string _secondName;
        private float _res1;
        private float _res2;
        private bool _disqualified;
        public string Name
        {
            get { return _firstName + " " + _secondName; }
            set
            {
                if (value != null && value.Length > 4)

                    _firstName = value;
            }
        }

        public float BestRes { get { return _res1 > _res2 ? _res1 : _res2; } }

        public Member(string firstName, string secondName, float res1, float res2)
        {
            _firstName = firstName;
            _secondName = secondName;
            _res1 = res1;
            _res2 = res2;
            _disqualified = false;
        }
        public void Disqualification(bool status)
        {
            if (!_disqualified)
            {
                _disqualified = status;
            }
        }
        public void Print()
        {
            if (!_disqualified)
            {
                Console.WriteLine($"{Name,-15} {_res1,-10:F1} {_res2,-10:F1} {BestRes,-10:F1}");
            }
        }
    }

    class Program
    {

        static void Main()
        {
            Member[] members = new Member[4];
            members[0] = new Member("Sergey", "Ivanov", 2.4f, 1.0f);
            members[1] = new Member("Valeriy", "Karpin", 2.6f, 1.4f);
            members[2] = new Member("Jack", "Sparrow", 1.5f, 1.2f);
            members[3] = new Member("Rick", "Sanchez", 2.3f, 1.4f);

            members[3].Disqualification(true);

            GnomeSort(members);

            Console.WriteLine("Name          Result1   Result2   BestResult");
            Console.WriteLine("----------------------------------------------");


            foreach (Member member in members)
            {
                member.Print();
            }
            Console.ReadLine();
        }
        public static void GnomeSort(Member[] members)
        {
            int i = 1;
            int j = i + 1;
            while (i < members.Length)
            {
                if (i == 0 || members[i].BestRes <= members[i - 1].BestRes)
                {
                    i = j;
                    j++;
                }
                else
                {
                    Member temp = members[i]; ;
                    members[i] = members[i - 1];
                    members[i - 1] = temp;
                    i--;
                }
            }
        }
    }
}