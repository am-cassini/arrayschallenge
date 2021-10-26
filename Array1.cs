// ITN114 Wireless Internet and Pervasive Computing
// Arrays Challenge #1
// Azalea Mae C. Manimog

using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Input 10 elements in the array: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("element - " + i + " : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            foreach (int nums in numbers)
            {
                Console.Write($"{nums} ");
            }
        }
    }
}

