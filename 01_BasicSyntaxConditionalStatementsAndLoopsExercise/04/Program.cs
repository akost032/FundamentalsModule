using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.Write($"{i} ");
                total += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {total}");
        }
    }
}
