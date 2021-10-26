// ITN114 Wireless Internet and Pervasive Computing
// Arrays Challenge #2
// Azalea Mae C. Manimog

using System;
using static System.Console;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Input the number of elements to store in the array: ");
            int numOfElements = Convert.ToInt32(ReadLine());

            int[] array = new int[numOfElements];

            WriteLine("Input 10 elements in the array :");
            for (int i = 0; i < array.Length; i++)
            {
                Write($"element - {i} : ");
                int input = Convert.ToInt32(ReadLine());
                array[i] = input;
            }

            WriteLine("The values store into the array are: ");
            foreach (int num in array)
            {
                Write($"{num} ");
            }
            WriteLine();
            Array.Reverse(array);

            WriteLine("The values store into the array in reverse are: ");
            foreach (int num in array)
            {
                Write($"{num} ");
            }
        }
    }
}


