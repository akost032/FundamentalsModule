using System;

namespace _06_EvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read an array from the console and sum only its even values. 
            string[] input = Console.ReadLine().Split(" ");
            int[] array = new int[input.Length];

            int sumEvenNums = 0;
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);

                if (array[i]%2==0)
                {
                    sumEvenNums += array[i];
                }
            }

            Console.WriteLine(sumEvenNums);
        }
    }
}
