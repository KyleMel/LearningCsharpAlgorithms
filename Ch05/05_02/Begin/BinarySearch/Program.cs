using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a binary search for {theValue} is: ");
            WriteLine(binarySearch(array, theValue));
        }
        /* <summary>
         a = array
         x = what we're searching for
         p = first index
         q = midpoint
         r = last index
        */
        public static int binarySearch(int[] a, int x)
        {
            // Step 1 - initialize variables
            int p = 0; // beginning of range
            int r = a.Length - 1; // end of range

            // Step 2 = search for value
            while (p <= r)
            {
                int q = (p + r) / 2; // find midpoint
                if (x < a[q])
                {
                    r = q - 1; //set midpoint, search left of array
                }
                else if (x > a[q])
                {
                    p = q + 1; // set midpoint, search right of array
                }
                else
                    return q;
            }
            // Step 3 - not found
            return -1;
        }
    }
}
