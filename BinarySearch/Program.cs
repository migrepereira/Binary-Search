using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains");
            Array.ForEach(array, x => Console.Write(x + " "));

            Console.Write($"\n\nThe result of a binary search for {value} is: ");
            Console.WriteLine(binarySearch(array, value));
            Console.ReadLine();
        }
        public static int binarySearch(int[] a, int x)
        {
            // Step 1: Initialize variables
            int p = 0; // Beginning of range
            int r = a.Length - 1; // End of range

            // Step 2: Search for target value

            while (p <= r)
            {
                int q = (p + r) / 2; // To find midpoint
                if (x < a[q])
                {
                    // Set r to mid. In the case x is less than the value in slot q
                    // the arrow was narrowed to the first half
                    r = q - 1;

                }
                else if (x > a[q])
                    p = q + 1;
                else return q;
            }

            // Last step, if value is not found
            return -1;
        }
    }

    // a = array
    // x = target value
    // p = first index
    // q = mid of array
    // r = last index


}
