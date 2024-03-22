using System.Xml.Schema;

namespace kr
{
    public struct Number
    {
        private int _numeric1;
        private int _numeric2;
        //private int[] number = new int[2];
        public Number(int numeric1, int numeric2)
        {
            _numeric1 = numeric1;
            _numeric2 = numeric2;
        }
        public static int[] Sum(Number numeric1, Number numeric2)
        {

            int[] result = new int[2];
            for (int i = 0; i < 2; i++)
            {
                result[i] = numeric1[i] + numeric2[i];
            }
            return result;
        }
        public static int[] Dif(int[] numeric1, int[] numeric2)
        {
            int[] result = new int[2];
            for (int i = 0; i < 2; i++)
            {
                result[i] = numeric1[i] - numeric2[i];
            }
            return result;
        }
        public static int[] Multiple(int[] numeric1, int[] numeric2)
        {
            int[] result = new int[2];
            result[0] = (numeric1[0] * numeric2[0] + numeric1[0] * numeric2[1]);
            result[1] = (numeric1[0] * numeric2[1] + numeric2[1] * numeric1[1]);
            return result;
        }
        public static int[] Del(int[] numeric1, int[] numeric2)
        {
            int[] result = new int[2];
            for (int i = 0; i < 2; i++)
            {
                result[0] = (numeric1[0] * numeric2[0] + numeric1[1] * numeric2[1]) / (numeric2[0] * numeric2[0] + numeric2[1] * numeric2[1]);
                result[1] = (numeric2[0] * numeric1[1] - numeric1[0] * numeric2[1]) / (numeric2[0] * numeric2[0] + numeric2[1] * numeric2[1]);
            }
            return result;
        }
        public static void Display(int[] numeric1, int[] numeric2)
        {
            Console.WriteLine($"Действительная часть: {numeric1[0]}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number1 = new Number(1, 2);
            Number number2 = new Number(3, 4);
            Number sum;
            Number dif;
            Number mult;
            Number del;
            sum.Sum(number1, number2);
            dif.Dif(number1, number2);
            mult.Multiple(number1, number2);
            del.Del(number1, number2);
            number1.Display();
            number2.Display();
            sum.Display();
            dif.Display();
            mult.Display();
            del.Display();
        }
    }
}