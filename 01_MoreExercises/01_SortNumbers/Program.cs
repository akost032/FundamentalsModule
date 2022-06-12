using System;

namespace _01_SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int[] numbers = { number1, number2, number3 };

            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
