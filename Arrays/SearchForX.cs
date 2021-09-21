using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SearchForX
    {
        public static int LinearSearch(int [] arr, int x)
        {
            //Search for element in the array
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        } 

        public static int BinarySearch(int [] arr, int start, int end, int x)
        {
            //Sort array in ascending order
            //Array.Sort(arr);

            if (end >= start)
            {
                int average = start + (end - 1) / 2;
                if (arr[average] == x)
                {
                    return average;
                }

                if (arr[average] > x)
                {
                    return BinarySearch(arr, start, average - 1, x);
                }

                if (arr[average] < x)
                {
                    return BinarySearch(arr, average + 1, end, x);
                }
            }

            return -1;
            
        }
    }
}
