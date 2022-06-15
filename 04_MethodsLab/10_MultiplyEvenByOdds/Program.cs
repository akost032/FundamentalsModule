using System;

namespace _10_MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = Math.Abs(input);
            int sumEven = GetSumOfEvenDigits(number);
            int sumOdd = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(sumEven, sumOdd);
           
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            int digit = number;

            while (digit > 0)
            {
                int currentDigit = digit % 10;
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
                digit = digit / 10;
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int number)
        {
                int sumOdd = 0;
                int digit = number;

                while (digit > 0)
                {
                    int currentDigit = digit % 10;
                    if (currentDigit % 2 != 0)
                    {
                        sumOdd += currentDigit;
                    }
                    digit = digit / 10;
                }
                return sumOdd;
        }

        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }

        
    }
}
