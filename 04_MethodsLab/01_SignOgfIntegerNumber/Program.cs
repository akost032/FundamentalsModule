using System;

namespace _01_SignOgfIntegerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            NumberCheck(input);

        }

        static void NumberCheck(int input)
        {
            if (input>0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else if (input==0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {input} is negative.");
            }
        }
    }
}
