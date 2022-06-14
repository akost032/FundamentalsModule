using System;
using System.Linq;

namespace _03_ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. 
            //Form 2 new arrays in a zig-zag pattern as shown below.

            int numbers = int.Parse(Console.ReadLine());
            int[] firstArray = new int[numbers];
            int[] secondArray = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                int[] currentArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (i%2==0)
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }
                else
                {
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }
            }

            Console.WriteLine(String.Join(" ",firstArray));
            Console.WriteLine(String.Join(" ",secondArray));
        }
    }
}
