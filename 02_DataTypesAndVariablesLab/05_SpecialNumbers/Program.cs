using System;

namespace _05_SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while (digits>0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}
