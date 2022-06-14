using System;

namespace _11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            double bestSnowball = 0;
            double snowballSnow = 0;
            double snowballQuality = 0;
            double snowballTime = 0;
            double one = 0;
            double two = 0;
            double three = 0;
            double four = 0;
            double snowballValue = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                snowballSnow = double.Parse(Console.ReadLine());
                snowballTime = double.Parse(Console.ReadLine());
                snowballQuality = double.Parse(Console.ReadLine());
                snowballValue = Math.Pow((snowballSnow/snowballTime),snowballQuality);

                if (snowballValue>bestSnowball)
                {
                    bestSnowball = snowballValue;
                    one = snowballSnow;
                    two = snowballTime;
                    three = snowballValue;
                    four = snowballQuality;
                }
            }

            Console.WriteLine($"{one} : {two} = {three} ({four})");
        }
    }
}
