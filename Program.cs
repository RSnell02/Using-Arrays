/*
 * Project: Spr2020-UsingArrays
 * Filename: Program.cs
 * Author: R. Snell
 * Date: Mar. 09, 2020
 * Purpose: To demonstrate some static methods of arrays. Also that
 *          arrays use IEnumerable.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Array;

namespace Spr2020_UsingArrays
{
    class Program
    {
        private static int[] intVals = { 1 , 2 , 3 , 4 , 5 , 6 , 7 };
        private static double[] dblVals = { 8.4, 9.3, 0.2, 7.9, 3.4, 5.8 };
        private static int[] intValsCopy;

        static void Main(string[] args)
        {
            intValsCopy = new int[intVals.Length];  // Initialized to zeros

            Console.WriteLine("Initial array values: \n");
            PrintArrays();

            // Sort dblVals
            Sort(dblVals);  // Call to the Array static method Sort()
            // Copy intVals into intValsCopy
            Array.Copy(intVals, intValsCopy, intVals.Length);
            PrintArrays();
            Console.WriteLine();

            // Search for a value in intVals
            int result = Array.BinarySearch(intVals, 5);
            Console.WriteLine(result >= 0 ? $"5 found at element {result}" +
                $" in intVals" : "5 not found in intVals");

            // Search for 8763 in intVals
            result = Array.BinarySearch(intVals, 8763);
            Console.WriteLine(result >= 0 ? $"8763 found at element {result}" +
                $" in intVals" : "8763 not found in intVals");
        }   // end Main()

        // Output array contents with enumerators
        private static void PrintArrays()
        {
            Console.Write("dblVals: ");
            // Iterate thru the double array with an enumerator
            IEnumerator enumerator = dblVals.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current} ");
            Console.Write("\nintVals: ");
            // Iterate thru the int array with an enumerator.
            enumerator = intVals.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current}");

            Console.Write("\nintValsCopy: ");
            foreach (var element in intValsCopy)
                Console.Write($"{element} ");
            Console.WriteLine();
        }   // end PrintArrays()
    }   // end class
}   // end namespace
