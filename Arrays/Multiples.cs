using System;

namespace Arrays
{
    public class Multiples
    {
        public static int IsMultipleOf3 (int number)
        {
            int odd_count = 0;
            int even_count = 0;

            if (number < 0)
                number = -number;
            if (number == 0)
                return 1;
            if (number == 1)
                return 0;

            while (number != 0)
            {
                if ((number & 1) != 0)
                {
                    odd_count++;
                }

                if ((number & 2) != 0)
                {
                    even_count++;
                }

                number = number >> 2;
            }

            return IsMultipleOf3(Math.Abs(odd_count - even_count));
        }
    }
}
