using System;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int numbersTotal = 0;

            for (int i = 0; i <= 1000; i++)
            {
                int currentNumber = i;
                if (currentNumber%2!=0)
                {
                    Console.WriteLine(currentNumber);
                    total += currentNumber;
                    numbersTotal++;
                    if (numbersTotal>=number)
                    {
                        Console.WriteLine($"Sum: {total}");
                        break;

                    }
                }
            }
        }
    }
}
