// ITN114 Wireless Internet and Pervasive Computing
// Arrays Challenge #5
// Azalea Mae C. Manimog

using System;
using static System.Console;
using System.Linq;

namespace Array5
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Input the number of elements to store in the array: ");
            int numOfElements = Convert.ToInt32(ReadLine());

            int[] num = new int[numOfElements];   

            WriteLine($"Input {numOfElements} elements in the array :");
            for (int i = 0; i < num.Length; i++)
            {
                Write($"element - {i} : ");
                int input = Convert.ToInt32(ReadLine());
                num[i] = input;
            }

            var duplicates = num
                .GroupBy(p => p)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);

            WriteLine($"Total number of duplicate elements found in the array is: {duplicates.Count()}");
        }
    }
}

