using System;

namespace _09_SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalSpices = 0;
            int days = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (yield>=100)
                {
                    totalSpices +=yield;
                    
                    if (totalSpices>26)
                    {
                        totalSpices -= 26;
                    }
                    
                    days++;
                }
                else
                {
                    break;
                }

                yield -= 10;

            }
            if (totalSpices>=26)
            {
                totalSpices -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpices);
        }
    }
}
