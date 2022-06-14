using System;

namespace _07_WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPours = int.Parse(Console.ReadLine());
            int capacity = 255;
            int total = 0;

            for (int i = 0; i <=numOfPours-1; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                total += liters;

                if (total>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    total -= liters;
                }
            }

            Console.WriteLine(total);
        }
    }
}
