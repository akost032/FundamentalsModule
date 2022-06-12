using System;

namespace _07_EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] numbers = new int[input.Length];

            int evenNumbers = 0;
            int oddNumbers = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);

                if (numbers[i]%2==0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers+=numbers[i];
                }
            }

            Console.WriteLine(evenNumbers-oddNumbers);
        }
    }
}
