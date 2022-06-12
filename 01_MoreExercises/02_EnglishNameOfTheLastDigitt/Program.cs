using System;

namespace _02_EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] a = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            int lastDigit = input % 10;
            Console.WriteLine(a[lastDigit]);
        }
    }
}
