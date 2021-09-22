using System;

namespace SimpleArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 10, 11 };

            Console.WriteLine("Sum of the array is: ", simpleArraySum(array));
        }

        public static int simpleArraySum (int [] array){
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
