using System.Globalization;

namespace lab_6th
{
    //первая часть второй номер
    public struct Girls
    {
        private string _name;
        private string _surname_teacher;
        private int _group;
        private int _result;
        public Girls(string name, string surname_teacher, int group, int result)
        {
            _name = name;
            _surname_teacher = surname_teacher;
            _group = group;
            _result = result;
        }
        public int Result
        {
            get { return _result; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Surname_Teacher
        {
            get { return _surname_teacher; }
        }
        public int Group
        {
            get { return _group; }
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Girls[] girls = new Girls[4] {new Girls("Юля", "Грантова", 1 , 2 ),
            new Girls("Таня", " Собчак", 3, 5),
            new Girls("Александра", "Мармеладова", 3 , 4 ), new Girls("Лена", " Герберт", 6, int.MaxValue)};
            Sort(girls);
            for (int i = 0; i < girls.Length; i++)
            {
                string j;
                if (girls[i].Result == int.MaxValue)
                {
                    j = Convert.ToString(girls[i].Result);
                    j = "не пробежала";
                }
                else
                {
                    j = Convert.ToString(girls[i].Result);
                }
                Console.WriteLine($"имя:{girls[i].Name}, группа:{girls[i].Group}, фамилия учителя:{girls[i].Surname_Teacher}, результат:{j}  \n");
            }
            int count = Counter(girls);
            Console.WriteLine($"число девушек пробежавших забег: {count}");

        }

        static int Counter(Girls[] girls)
        {
            int count = 0;
            for (int i = 0; i < girls.Length; i++)
            {
                if (girls[i].Result != int.MaxValue) count++;
            }
            return count;
        }
        static Girls[] Sort(Girls[] girls)
        {

            for (int i = 1; i < girls.Length; i++)
            {
                Girls temp;
                if (girls[i].Result < girls[i - 1].Result)
                {
                    temp = girls[i];
                    girls[i] = girls[i - 1]; girls[i - 1] = temp;
                }
            }
            return girls;
        }
    }
}