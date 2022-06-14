using System;
using System.Linq;

namespace _04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that receives an array and several rotations that you have to perform.
            //The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int tempEl = array[0];
                for (int operation = 0; operation < array.Length-1; operation++)
                {
                    array[operation] = array[operation+1];
                }

                array[array.Length - 1] = tempEl;
            }

            Console.WriteLine(String.Join(" ",array));

        }
    }
}
