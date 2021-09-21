using System;

namespace Arrays
{
    class Program
    {
        public static void Main(string [] args)
        {
            int[,] grades = new int [,] {{1, 92, 74, 89, 100},
                                     {2, 93, 96, 85, 86},
                                     {3, 83, 72, 95, 89},
                                     {4, 91, 98, 79, 88}};
            int total = 0;
            int last_grade = grades.GetUpperBound(1);
            int last_student = grades.GetUpperBound(0);
            double average = 0.0;

            for (int i = 0; i <= last_student; i++)
            {
                total = 0;
                for (int j = 0; j <= last_grade; j++)
                {
                    total += grades[i, j];
                    average = total / last_grade;
                }
                Console.WriteLine("The Total value is: {0}", total);
                Console.WriteLine("The Average grade of the Students is: {0}", average);
            }


            //SearchForX Class
            int [] array = { 4, 6, 8, 2, 9, 0 };
            int number = 0;
            int start = 0;
            int end = array.Length;

            int resultOfLinearSearch = SearchForX.LinearSearch(array, number);
            if (resultOfLinearSearch == -1)
            {
                Console.WriteLine("X is not found in the array!");
            }
            else
            {
                Console.WriteLine("Result from the Linear Search is: " + resultOfLinearSearch);
            }

            int resultOfBinarySearch = SearchForX.BinarySearch(array, start, end - 1, number);
            if (resultOfBinarySearch == -1)
            {
                Console.WriteLine("X is not found in the array!");
            }
            else
            {
                Console.WriteLine("Result from the Binary Search is: " + resultOfBinarySearch);
            }


            //Multiples Class
            Console.Write("Enter the Number here: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (Multiples.IsMultipleOf3(num) != 0)
            {
                Console.WriteLine("{0} is a multiple of 3", num);
            }
            else
            {
                Console.WriteLine("{0} is not a multiple of 3", num);
            }
        }
    }
}