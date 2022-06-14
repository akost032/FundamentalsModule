using System;

namespace _08_BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string final = "";
            double biggestKeg = double.MinValue;

            for (int i = 1; i <=n; i++)
            {
                string kegType = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfKeg = Math.PI * (radius * radius) * height;

                if (volumeOfKeg>biggestKeg)
                {
                    biggestKeg = volumeOfKeg;
                    final = kegType;
                }
            }

            Console.WriteLine(final);
        }
    }
}
