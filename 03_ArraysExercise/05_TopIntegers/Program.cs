using System;
using System.Linq;

namespace _05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1])
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.Write($"{array[array.Length-1]}");
        }
    }
}
