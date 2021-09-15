using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string [] args)
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            Swap<int>(ref num1, ref num2);
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            string str1 = "Sam";
            string str2 = "Peace";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);

            Swap<string>(ref str1, ref str2);
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
        }

        public static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}