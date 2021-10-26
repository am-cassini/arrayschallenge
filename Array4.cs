// ITN114 Wireless Internet and Pervasive Computing
// Arrays Challenge #4
// Azalea Mae C. Manimog

using System;
using static System.Console;
using System.Linq;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Input the number of elements to store in the array: ");
            int numOfElements = Convert.ToInt32(ReadLine());

            int[] num = new int[numOfElements];
            int[] numCopy = new int[numOfElements];

            WriteLine($"Input {numOfElements} elements in the array :");
            for (int i = 0; i < num.Length; i++)
            {
                Write($"element - {i} : ");
                int input = Convert.ToInt32(ReadLine());
                num[i] = input;
            }

            WriteLine("The elements stored in the first array are :");
            foreach (int nums in num)
            {
                Write($"{nums} ");
            }

            Array.Copy(num, numCopy, numOfElements);

            WriteLine();
            WriteLine("The elements stored in the second array are :");
            foreach (int nums in numCopy)
            {
                Write($"{nums} ");
            }

        }
    }
}
