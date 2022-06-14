using System;

namespace _10_PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            int remainingPower = power;

            while(remainingPower>=distance)
            {
                remainingPower -= distance;
                count++;

                if (remainingPower==power*0.5&&exhaustionFactor!=0)
                {
                    remainingPower /= exhaustionFactor;
                }

            }

            Console.WriteLine(remainingPower);
            Console.WriteLine(count);
        }
    }
}
