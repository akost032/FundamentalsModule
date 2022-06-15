using System;

namespace _08_MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = Power(@base, power);
            Console.WriteLine(result);            
        }

        static double Power (double @base, int power)
        {
            return Math.Pow(@base,power);
        }
    }
}
